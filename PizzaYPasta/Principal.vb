Public Class Principal
    Dim ClienteLogueado As Cliente = New Cliente
    Dim LPrecios As ListaDePrecios = New ListaDePrecios
    Dim TotalPizza As Decimal
    Dim TotalPasta As Decimal
    Dim CantIngredientes As Byte

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelPrincipal.Visible = False
        LblError.Visible = False
    End Sub

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        If ClienteLogueado.ObtenerUser = TxtUsuario.Text And ClienteLogueado.ObtenerPass = TxtPass.Text Then
            PanelPrincipal.Visible = True
            LblError.Visible = False
            PanelIngredientes.Visible = False
            PanelSalsa.Visible = False
        Else
            LblError.Visible = True
            TxtUsuario.Text = "" 'Limpia la caja de texto
            TxtPass.Text = ""
            TxtUsuario.Focus()
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub RbtnMedia_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbtnMedia.CheckedChanged
        PanelIngredientes.Visible = True
    End Sub

    Private Sub RbtnMolde_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbtnMolde.CheckedChanged
        PanelIngredientes.Visible = True
    End Sub

    Private Sub RbtnPiedra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbtnPiedra.CheckedChanged
        PanelIngredientes.Visible = True
    End Sub

    Private Sub LBoxTipoPasta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBoxTipoPasta.SelectedIndexChanged
        PanelSalsa.Visible = True
    End Sub

    Private Sub BtnComprar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComprar.Click
        CalcularPrecioPizza()
        CalcularPrecioPasta()
        If TotalPizza > 0 Or TotalPasta > 0 Then
            MessageBox.Show("Importe Total de Pizza: $" & TotalPizza & vbCrLf & _
            "Importe Total de Pasta: $" & TotalPasta & vbCrLf & _
            "Importe Total: $" & TotalPizza + TotalPasta, "Precio del Pedido", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TotalPasta = 0
            TotalPizza = 0
            BtnLimpiarPedido.PerformClick()
        End If
    End Sub
    Private Sub CalcularPrecioPizza()
        If ChkAnana.Checked = True Then
            CantIngredientes += 1
        End If
        If RbtnMolde.Checked Or RbtnMedia.Checked Or RbtnPiedra.Checked Then
            TotalPizza = LPrecios.ObtenerPrecioMasa + _
            CantIngredientes * LPrecios.ObtenerPrecioIngredientes
        End If
    End Sub
    Private Sub CalcularPrecioPasta()
        Dim IndicePasta, IndiceSalsa As Integer
        IndicePasta = LBoxTipoPasta.SelectedIndex
        IndiceSalsa = CBoxSalsa.SelectedIndex
        If IndicePasta >= 0 And IndiceSalsa >= 0 Then
            If ChkBoxExtraQueso.Checked = True Then
                TotalPasta = TotalPasta + LPrecios.ObtenerPrecioExtra
            End If
            If ChkBoxExtraSalsa.Checked = True Then
                TotalPasta = TotalPasta + LPrecios.ObtenerPrecioExtra
            End If
            TotalPasta = TotalPasta + LPrecios.ObtenerPrecioPasta + _
            LPrecios.ObtenerPrecioSalsa
        Else
            If IndicePasta >= 0 Then
                MessageBox.Show("Debe seleccionar al menos una Salsa", "", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BtnLimpiarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiarPedido.Click
        RbtnMolde.Checked = False
        ChkAnana.Checked = False
        LBoxTipoPasta.SelectedIndex = -1
        CBoxSalsa.SelectedIndex = -1
        ChkBoxExtraQueso.Checked = False
        ChkBoxExtraSalsa.Checked = False
        TotalPasta = 0
        TotalPizza = 0
        PanelIngredientes.Visible = False
        PanelSalsa.Visible = False
    End Sub
End Class
