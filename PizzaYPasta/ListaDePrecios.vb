Public Class ListaDePrecios
    Private TipoDeMasa As Decimal = 75
    Private Ingredientes As Decimal = 12.5
    Private TipoDePasta As Decimal = 67.5
    Private Salsa As Decimal = 12.5
    Private PrecioExtra As Decimal = 5
    Public Function ObtenerPrecioMasa() As Decimal
        Return TipoDeMasa
    End Function
    Public Function ObtenerPrecioIngredientes() As Decimal
        Return Ingredientes
    End Function
    Public Function ObtenerPrecioPasta() As Decimal
        Return TipoDePasta
    End Function
    Public Function ObtenerPrecioSalsa() As Decimal
        Return Salsa
    End Function
    Public Function ObtenerPrecioExtra() As Decimal
        Return PrecioExtra
    End Function

End Class
