<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelPrincipal = New System.Windows.Forms.Panel
        Me.BtnLimpiarPedido = New System.Windows.Forms.Button
        Me.BtnComprar = New System.Windows.Forms.Button
        Me.PanelPasta = New System.Windows.Forms.Panel
        Me.PanelSalsa = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.ChkBoxExtraSalsa = New System.Windows.Forms.CheckBox
        Me.CBoxSalsa = New System.Windows.Forms.ComboBox
        Me.ChkBoxExtraQueso = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LBoxTipoPasta = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanelPizza = New System.Windows.Forms.Panel
        Me.PanelIngredientes = New System.Windows.Forms.Panel
        Me.ChkAlbahaca = New System.Windows.Forms.CheckBox
        Me.ChkTomate = New System.Windows.Forms.CheckBox
        Me.ChkHuevo = New System.Windows.Forms.CheckBox
        Me.ChkAnchoas = New System.Windows.Forms.CheckBox
        Me.ChkSalame = New System.Windows.Forms.CheckBox
        Me.ChkSalchichas = New System.Windows.Forms.CheckBox
        Me.ChkRoquefort = New System.Windows.Forms.CheckBox
        Me.ChkParmesano = New System.Windows.Forms.CheckBox
        Me.ChkPapasPay = New System.Windows.Forms.CheckBox
        Me.ChkPalmitos = New System.Windows.Forms.CheckBox
        Me.ChkMozzarella = New System.Windows.Forms.CheckBox
        Me.ChkMorron = New System.Windows.Forms.CheckBox
        Me.ChkLonganiza = New System.Windows.Forms.CheckBox
        Me.ChkJamonCocido = New System.Windows.Forms.CheckBox
        Me.ChkJamon = New System.Windows.Forms.CheckBox
        Me.ChkHongos = New System.Windows.Forms.CheckBox
        Me.ChkEspinaca = New System.Windows.Forms.CheckBox
        Me.ChkCebolla = New System.Windows.Forms.CheckBox
        Me.ChkChoclo = New System.Windows.Forms.CheckBox
        Me.ChkAnana = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PanelMasa = New System.Windows.Forms.Panel
        Me.RbtnPiedra = New System.Windows.Forms.RadioButton
        Me.RbtnMedia = New System.Windows.Forms.RadioButton
        Me.RbtnMolde = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtPass = New System.Windows.Forms.TextBox
        Me.BtnIngresar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.LblError = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelPasta.SuspendLayout()
        Me.PanelSalsa.SuspendLayout()
        Me.PanelPizza.SuspendLayout()
        Me.PanelIngredientes.SuspendLayout()
        Me.PanelMasa.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Controls.Add(Me.BtnLimpiarPedido)
        Me.PanelPrincipal.Controls.Add(Me.BtnComprar)
        Me.PanelPrincipal.Controls.Add(Me.PanelPasta)
        Me.PanelPrincipal.Controls.Add(Me.PanelPizza)
        Me.PanelPrincipal.Location = New System.Drawing.Point(15, 69)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(601, 421)
        Me.PanelPrincipal.TabIndex = 0
        '
        'BtnLimpiarPedido
        '
        Me.BtnLimpiarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarPedido.Location = New System.Drawing.Point(365, 388)
        Me.BtnLimpiarPedido.Name = "BtnLimpiarPedido"
        Me.BtnLimpiarPedido.Size = New System.Drawing.Size(132, 23)
        Me.BtnLimpiarPedido.TabIndex = 3
        Me.BtnLimpiarPedido.Text = "Limpiar Pedido"
        Me.BtnLimpiarPedido.UseVisualStyleBackColor = True
        '
        'BtnComprar
        '
        Me.BtnComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComprar.Location = New System.Drawing.Point(155, 388)
        Me.BtnComprar.Name = "BtnComprar"
        Me.BtnComprar.Size = New System.Drawing.Size(75, 23)
        Me.BtnComprar.TabIndex = 2
        Me.BtnComprar.Text = "Comprar"
        Me.BtnComprar.UseVisualStyleBackColor = True
        '
        'PanelPasta
        '
        Me.PanelPasta.Controls.Add(Me.PanelSalsa)
        Me.PanelPasta.Controls.Add(Me.Label7)
        Me.PanelPasta.Controls.Add(Me.LBoxTipoPasta)
        Me.PanelPasta.Controls.Add(Me.Label4)
        Me.PanelPasta.Location = New System.Drawing.Point(313, 4)
        Me.PanelPasta.Name = "PanelPasta"
        Me.PanelPasta.Size = New System.Drawing.Size(278, 367)
        Me.PanelPasta.TabIndex = 1
        '
        'PanelSalsa
        '
        Me.PanelSalsa.Controls.Add(Me.Label8)
        Me.PanelSalsa.Controls.Add(Me.ChkBoxExtraSalsa)
        Me.PanelSalsa.Controls.Add(Me.CBoxSalsa)
        Me.PanelSalsa.Controls.Add(Me.ChkBoxExtraQueso)
        Me.PanelSalsa.Controls.Add(Me.Label9)
        Me.PanelSalsa.Location = New System.Drawing.Point(25, 165)
        Me.PanelSalsa.Name = "PanelSalsa"
        Me.PanelSalsa.Size = New System.Drawing.Size(239, 183)
        Me.PanelSalsa.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Elija el tipo de salsa"
        '
        'ChkBoxExtraSalsa
        '
        Me.ChkBoxExtraSalsa.AutoSize = True
        Me.ChkBoxExtraSalsa.Location = New System.Drawing.Point(6, 143)
        Me.ChkBoxExtraSalsa.Name = "ChkBoxExtraSalsa"
        Me.ChkBoxExtraSalsa.Size = New System.Drawing.Size(52, 17)
        Me.ChkBoxExtraSalsa.TabIndex = 8
        Me.ChkBoxExtraSalsa.Text = "Salsa"
        Me.ChkBoxExtraSalsa.UseVisualStyleBackColor = True
        '
        'CBoxSalsa
        '
        Me.CBoxSalsa.FormattingEnabled = True
        Me.CBoxSalsa.Items.AddRange(New Object() {"Cuatro Quesos", "Bolognesa", "Filetto", "Salsa Rosa", "Crema", "Salsa Blanca", "Roquefort", "Pesto", "Portuguesa", "Tuco", "Manteca"})
        Me.CBoxSalsa.Location = New System.Drawing.Point(6, 48)
        Me.CBoxSalsa.Name = "CBoxSalsa"
        Me.CBoxSalsa.Size = New System.Drawing.Size(147, 21)
        Me.CBoxSalsa.TabIndex = 5
        '
        'ChkBoxExtraQueso
        '
        Me.ChkBoxExtraQueso.AutoSize = True
        Me.ChkBoxExtraQueso.Location = New System.Drawing.Point(6, 119)
        Me.ChkBoxExtraQueso.Name = "ChkBoxExtraQueso"
        Me.ChkBoxExtraQueso.Size = New System.Drawing.Size(96, 17)
        Me.ChkBoxExtraQueso.TabIndex = 7
        Me.ChkBoxExtraQueso.Text = "Queso Rallado"
        Me.ChkBoxExtraQueso.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Recarga extra de:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Elija el tipo de pasta"
        '
        'LBoxTipoPasta
        '
        Me.LBoxTipoPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBoxTipoPasta.FormattingEnabled = True
        Me.LBoxTipoPasta.ItemHeight = 16
        Me.LBoxTipoPasta.Items.AddRange(New Object() {"Tallarines", "Sorrentinos", "Ravioles", "Ñoquis", "Agnolotis"})
        Me.LBoxTipoPasta.Location = New System.Drawing.Point(25, 65)
        Me.LBoxTipoPasta.Name = "LBoxTipoPasta"
        Me.LBoxTipoPasta.Size = New System.Drawing.Size(148, 84)
        Me.LBoxTipoPasta.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pastas"
        '
        'PanelPizza
        '
        Me.PanelPizza.Controls.Add(Me.PanelIngredientes)
        Me.PanelPizza.Controls.Add(Me.PanelMasa)
        Me.PanelPizza.Controls.Add(Me.Label3)
        Me.PanelPizza.Location = New System.Drawing.Point(4, 4)
        Me.PanelPizza.Name = "PanelPizza"
        Me.PanelPizza.Size = New System.Drawing.Size(303, 367)
        Me.PanelPizza.TabIndex = 0
        '
        'PanelIngredientes
        '
        Me.PanelIngredientes.Controls.Add(Me.ChkAlbahaca)
        Me.PanelIngredientes.Controls.Add(Me.ChkTomate)
        Me.PanelIngredientes.Controls.Add(Me.ChkHuevo)
        Me.PanelIngredientes.Controls.Add(Me.ChkAnchoas)
        Me.PanelIngredientes.Controls.Add(Me.ChkSalame)
        Me.PanelIngredientes.Controls.Add(Me.ChkSalchichas)
        Me.PanelIngredientes.Controls.Add(Me.ChkRoquefort)
        Me.PanelIngredientes.Controls.Add(Me.ChkParmesano)
        Me.PanelIngredientes.Controls.Add(Me.ChkPapasPay)
        Me.PanelIngredientes.Controls.Add(Me.ChkPalmitos)
        Me.PanelIngredientes.Controls.Add(Me.ChkMozzarella)
        Me.PanelIngredientes.Controls.Add(Me.ChkMorron)
        Me.PanelIngredientes.Controls.Add(Me.ChkLonganiza)
        Me.PanelIngredientes.Controls.Add(Me.ChkJamonCocido)
        Me.PanelIngredientes.Controls.Add(Me.ChkJamon)
        Me.PanelIngredientes.Controls.Add(Me.ChkHongos)
        Me.PanelIngredientes.Controls.Add(Me.ChkEspinaca)
        Me.PanelIngredientes.Controls.Add(Me.ChkCebolla)
        Me.PanelIngredientes.Controls.Add(Me.ChkChoclo)
        Me.PanelIngredientes.Controls.Add(Me.ChkAnana)
        Me.PanelIngredientes.Controls.Add(Me.Label6)
        Me.PanelIngredientes.Location = New System.Drawing.Point(14, 97)
        Me.PanelIngredientes.Name = "PanelIngredientes"
        Me.PanelIngredientes.Size = New System.Drawing.Size(274, 267)
        Me.PanelIngredientes.TabIndex = 2
        '
        'ChkAlbahaca
        '
        Me.ChkAlbahaca.AutoSize = True
        Me.ChkAlbahaca.Location = New System.Drawing.Point(141, 234)
        Me.ChkAlbahaca.Name = "ChkAlbahaca"
        Me.ChkAlbahaca.Size = New System.Drawing.Size(71, 17)
        Me.ChkAlbahaca.TabIndex = 20
        Me.ChkAlbahaca.Text = "Albahaca"
        Me.ChkAlbahaca.UseVisualStyleBackColor = True
        '
        'ChkTomate
        '
        Me.ChkTomate.AutoSize = True
        Me.ChkTomate.Location = New System.Drawing.Point(13, 234)
        Me.ChkTomate.Name = "ChkTomate"
        Me.ChkTomate.Size = New System.Drawing.Size(62, 17)
        Me.ChkTomate.TabIndex = 19
        Me.ChkTomate.Text = "Tomate"
        Me.ChkTomate.UseVisualStyleBackColor = True
        '
        'ChkHuevo
        '
        Me.ChkHuevo.AutoSize = True
        Me.ChkHuevo.Location = New System.Drawing.Point(141, 211)
        Me.ChkHuevo.Name = "ChkHuevo"
        Me.ChkHuevo.Size = New System.Drawing.Size(58, 17)
        Me.ChkHuevo.TabIndex = 18
        Me.ChkHuevo.Text = "Huevo"
        Me.ChkHuevo.UseVisualStyleBackColor = True
        '
        'ChkAnchoas
        '
        Me.ChkAnchoas.AutoSize = True
        Me.ChkAnchoas.Location = New System.Drawing.Point(141, 187)
        Me.ChkAnchoas.Name = "ChkAnchoas"
        Me.ChkAnchoas.Size = New System.Drawing.Size(68, 17)
        Me.ChkAnchoas.TabIndex = 17
        Me.ChkAnchoas.Text = "Anchoas"
        Me.ChkAnchoas.UseVisualStyleBackColor = True
        '
        'ChkSalame
        '
        Me.ChkSalame.AutoSize = True
        Me.ChkSalame.Location = New System.Drawing.Point(141, 163)
        Me.ChkSalame.Name = "ChkSalame"
        Me.ChkSalame.Size = New System.Drawing.Size(61, 17)
        Me.ChkSalame.TabIndex = 16
        Me.ChkSalame.Text = "Salame"
        Me.ChkSalame.UseVisualStyleBackColor = True
        '
        'ChkSalchichas
        '
        Me.ChkSalchichas.AutoSize = True
        Me.ChkSalchichas.Location = New System.Drawing.Point(141, 140)
        Me.ChkSalchichas.Name = "ChkSalchichas"
        Me.ChkSalchichas.Size = New System.Drawing.Size(78, 17)
        Me.ChkSalchichas.TabIndex = 15
        Me.ChkSalchichas.Text = "Salchichas"
        Me.ChkSalchichas.UseVisualStyleBackColor = True
        '
        'ChkRoquefort
        '
        Me.ChkRoquefort.AutoSize = True
        Me.ChkRoquefort.Location = New System.Drawing.Point(141, 116)
        Me.ChkRoquefort.Name = "ChkRoquefort"
        Me.ChkRoquefort.Size = New System.Drawing.Size(73, 17)
        Me.ChkRoquefort.TabIndex = 14
        Me.ChkRoquefort.Text = "Roquefort"
        Me.ChkRoquefort.UseVisualStyleBackColor = True
        '
        'ChkParmesano
        '
        Me.ChkParmesano.AutoSize = True
        Me.ChkParmesano.Location = New System.Drawing.Point(141, 92)
        Me.ChkParmesano.Name = "ChkParmesano"
        Me.ChkParmesano.Size = New System.Drawing.Size(79, 17)
        Me.ChkParmesano.TabIndex = 13
        Me.ChkParmesano.Text = "Parmesano"
        Me.ChkParmesano.UseVisualStyleBackColor = True
        '
        'ChkPapasPay
        '
        Me.ChkPapasPay.AutoSize = True
        Me.ChkPapasPay.Location = New System.Drawing.Point(141, 67)
        Me.ChkPapasPay.Name = "ChkPapasPay"
        Me.ChkPapasPay.Size = New System.Drawing.Size(77, 17)
        Me.ChkPapasPay.TabIndex = 12
        Me.ChkPapasPay.Text = "Papas Pay"
        Me.ChkPapasPay.UseVisualStyleBackColor = True
        '
        'ChkPalmitos
        '
        Me.ChkPalmitos.AutoSize = True
        Me.ChkPalmitos.Location = New System.Drawing.Point(141, 43)
        Me.ChkPalmitos.Name = "ChkPalmitos"
        Me.ChkPalmitos.Size = New System.Drawing.Size(65, 17)
        Me.ChkPalmitos.TabIndex = 11
        Me.ChkPalmitos.Text = "Palmitos"
        Me.ChkPalmitos.UseVisualStyleBackColor = True
        '
        'ChkMozzarella
        '
        Me.ChkMozzarella.AutoSize = True
        Me.ChkMozzarella.Location = New System.Drawing.Point(141, 20)
        Me.ChkMozzarella.Name = "ChkMozzarella"
        Me.ChkMozzarella.Size = New System.Drawing.Size(76, 17)
        Me.ChkMozzarella.TabIndex = 10
        Me.ChkMozzarella.Text = "Mozzarella"
        Me.ChkMozzarella.UseVisualStyleBackColor = True
        '
        'ChkMorron
        '
        Me.ChkMorron.AutoSize = True
        Me.ChkMorron.Location = New System.Drawing.Point(14, 211)
        Me.ChkMorron.Name = "ChkMorron"
        Me.ChkMorron.Size = New System.Drawing.Size(59, 17)
        Me.ChkMorron.TabIndex = 9
        Me.ChkMorron.Text = "Morrón"
        Me.ChkMorron.UseVisualStyleBackColor = True
        '
        'ChkLonganiza
        '
        Me.ChkLonganiza.AutoSize = True
        Me.ChkLonganiza.Location = New System.Drawing.Point(14, 187)
        Me.ChkLonganiza.Name = "ChkLonganiza"
        Me.ChkLonganiza.Size = New System.Drawing.Size(75, 17)
        Me.ChkLonganiza.TabIndex = 8
        Me.ChkLonganiza.Text = "Longaniza"
        Me.ChkLonganiza.UseVisualStyleBackColor = True
        '
        'ChkJamonCocido
        '
        Me.ChkJamonCocido.AutoSize = True
        Me.ChkJamonCocido.Location = New System.Drawing.Point(14, 163)
        Me.ChkJamonCocido.Name = "ChkJamonCocido"
        Me.ChkJamonCocido.Size = New System.Drawing.Size(88, 17)
        Me.ChkJamonCocido.TabIndex = 7
        Me.ChkJamonCocido.Text = "Jamon Crudo"
        Me.ChkJamonCocido.UseVisualStyleBackColor = True
        '
        'ChkJamon
        '
        Me.ChkJamon.AutoSize = True
        Me.ChkJamon.Location = New System.Drawing.Point(14, 140)
        Me.ChkJamon.Name = "ChkJamon"
        Me.ChkJamon.Size = New System.Drawing.Size(57, 17)
        Me.ChkJamon.TabIndex = 6
        Me.ChkJamon.Text = "Jamon"
        Me.ChkJamon.UseVisualStyleBackColor = True
        '
        'ChkHongos
        '
        Me.ChkHongos.AutoSize = True
        Me.ChkHongos.Location = New System.Drawing.Point(14, 116)
        Me.ChkHongos.Name = "ChkHongos"
        Me.ChkHongos.Size = New System.Drawing.Size(63, 17)
        Me.ChkHongos.TabIndex = 5
        Me.ChkHongos.Text = "Hongos"
        Me.ChkHongos.UseVisualStyleBackColor = True
        '
        'ChkEspinaca
        '
        Me.ChkEspinaca.AutoSize = True
        Me.ChkEspinaca.Location = New System.Drawing.Point(14, 92)
        Me.ChkEspinaca.Name = "ChkEspinaca"
        Me.ChkEspinaca.Size = New System.Drawing.Size(70, 17)
        Me.ChkEspinaca.TabIndex = 4
        Me.ChkEspinaca.Text = "Espinaca"
        Me.ChkEspinaca.UseVisualStyleBackColor = True
        '
        'ChkCebolla
        '
        Me.ChkCebolla.AutoSize = True
        Me.ChkCebolla.Location = New System.Drawing.Point(14, 68)
        Me.ChkCebolla.Name = "ChkCebolla"
        Me.ChkCebolla.Size = New System.Drawing.Size(61, 17)
        Me.ChkCebolla.TabIndex = 3
        Me.ChkCebolla.Text = "Cebolla"
        Me.ChkCebolla.UseVisualStyleBackColor = True
        '
        'ChkChoclo
        '
        Me.ChkChoclo.AutoSize = True
        Me.ChkChoclo.Location = New System.Drawing.Point(14, 44)
        Me.ChkChoclo.Name = "ChkChoclo"
        Me.ChkChoclo.Size = New System.Drawing.Size(59, 17)
        Me.ChkChoclo.TabIndex = 2
        Me.ChkChoclo.Text = "Choclo"
        Me.ChkChoclo.UseVisualStyleBackColor = True
        '
        'ChkAnana
        '
        Me.ChkAnana.AutoSize = True
        Me.ChkAnana.Location = New System.Drawing.Point(14, 20)
        Me.ChkAnana.Name = "ChkAnana"
        Me.ChkAnana.Size = New System.Drawing.Size(57, 17)
        Me.ChkAnana.TabIndex = 1
        Me.ChkAnana.Text = "Ananá"
        Me.ChkAnana.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Elija los ingredientes:"
        '
        'PanelMasa
        '
        Me.PanelMasa.Controls.Add(Me.RbtnPiedra)
        Me.PanelMasa.Controls.Add(Me.RbtnMedia)
        Me.PanelMasa.Controls.Add(Me.RbtnMolde)
        Me.PanelMasa.Controls.Add(Me.Label5)
        Me.PanelMasa.Location = New System.Drawing.Point(14, 31)
        Me.PanelMasa.Name = "PanelMasa"
        Me.PanelMasa.Size = New System.Drawing.Size(274, 59)
        Me.PanelMasa.TabIndex = 1
        '
        'RbtnPiedra
        '
        Me.RbtnPiedra.AutoSize = True
        Me.RbtnPiedra.Location = New System.Drawing.Point(177, 39)
        Me.RbtnPiedra.Name = "RbtnPiedra"
        Me.RbtnPiedra.Size = New System.Drawing.Size(75, 17)
        Me.RbtnPiedra.TabIndex = 3
        Me.RbtnPiedra.TabStop = True
        Me.RbtnPiedra.Text = "a la Piedra"
        Me.RbtnPiedra.UseVisualStyleBackColor = True
        '
        'RbtnMedia
        '
        Me.RbtnMedia.AutoSize = True
        Me.RbtnMedia.Location = New System.Drawing.Point(87, 39)
        Me.RbtnMedia.Name = "RbtnMedia"
        Me.RbtnMedia.Size = New System.Drawing.Size(83, 17)
        Me.RbtnMedia.TabIndex = 2
        Me.RbtnMedia.TabStop = True
        Me.RbtnMedia.Text = "Media Masa"
        Me.RbtnMedia.UseVisualStyleBackColor = True
        '
        'RbtnMolde
        '
        Me.RbtnMolde.AutoSize = True
        Me.RbtnMolde.Location = New System.Drawing.Point(4, 39)
        Me.RbtnMolde.Name = "RbtnMolde"
        Me.RbtnMolde.Size = New System.Drawing.Size(65, 17)
        Me.RbtnMolde.TabIndex = 1
        Me.RbtnMolde.TabStop = True
        Me.RbtnMolde.Text = "al Molde"
        Me.RbtnMolde.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Elija el tipo de masa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pizzas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(66, 33)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(125, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(286, 32)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(134, 20)
        Me.TxtPass.TabIndex = 4
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(438, 30)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIngresar.TabIndex = 5
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(532, 30)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(286, 53)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(202, 13)
        Me.LblError.TabIndex = 7
        Me.LblError.Text = """Usuario o Contraseña incorrecta"""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Principal
        '
        Me.AcceptButton = Me.BtnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(617, 519)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Pizzas y Pastas ""La Nonna"""
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPasta.ResumeLayout(False)
        Me.PanelPasta.PerformLayout()
        Me.PanelSalsa.ResumeLayout(False)
        Me.PanelSalsa.PerformLayout()
        Me.PanelPizza.ResumeLayout(False)
        Me.PanelPizza.PerformLayout()
        Me.PanelIngredientes.ResumeLayout(False)
        Me.PanelIngredientes.PerformLayout()
        Me.PanelMasa.ResumeLayout(False)
        Me.PanelMasa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents BtnIngresar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents PanelPasta As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelPizza As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelMasa As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RbtnPiedra As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnMedia As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnMolde As System.Windows.Forms.RadioButton
    Friend WithEvents PanelIngredientes As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChkEspinaca As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCebolla As System.Windows.Forms.CheckBox
    Friend WithEvents ChkChoclo As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAnana As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMorron As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLonganiza As System.Windows.Forms.CheckBox
    Friend WithEvents ChkJamonCocido As System.Windows.Forms.CheckBox
    Friend WithEvents ChkJamon As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHongos As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMozzarella As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHuevo As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAnchoas As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSalame As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSalchichas As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRoquefort As System.Windows.Forms.CheckBox
    Friend WithEvents ChkParmesano As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPapasPay As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPalmitos As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAlbahaca As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTomate As System.Windows.Forms.CheckBox
    Friend WithEvents BtnLimpiarPedido As System.Windows.Forms.Button
    Friend WithEvents BtnComprar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBoxTipoPasta As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBoxSalsa As System.Windows.Forms.ComboBox
    Friend WithEvents ChkBoxExtraSalsa As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBoxExtraQueso As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblError As System.Windows.Forms.Label
    Friend WithEvents PanelSalsa As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip

End Class
