Public Class Cliente

    Private Usuario As String = "a"
    Private Password As String = "1"
    Private Nombre As String = "Cosme Fulanito"
    Private Dir As String = "Calle Falsa nro 123"
    Private Tel As String = "555-5555"

    Public Function ObtenerUser() As String
        Return Usuario
    End Function

    Public Function ObtenerPass() As String
        Return Password
    End Function

    Public Function ObtenerNom() As String
        Return Nombre
    End Function

    Public Function ObtenerDir() As String
        Return Dir
    End Function

    Public Function ObtenerTel() As String
        Return Tel
    End Function

End Class
