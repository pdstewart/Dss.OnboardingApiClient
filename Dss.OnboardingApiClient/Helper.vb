Imports System.Security.Cryptography
Imports System.Text

Public Class Helper

    Private Sub New()

    End Sub

    Public Shared Function GetBase64EncodedHmacSha1(text As String, key As String) As String
        Using alg = New HMACSHA1(ASCIIEncoding.ASCII.GetBytes(key))
            Dim hashBytes = alg.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text))
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    ''' <summary>
    ''' Returns a Coldfusion format UUID for use in SSO
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function CreateCFUuid(g As Guid) As String
        Return g.ToString.Remove(23, 1)
    End Function

End Class
