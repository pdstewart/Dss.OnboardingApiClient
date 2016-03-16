<DataContract()>
Public Class RequestHeader

    <DataMember(Name:="Authorization")>
    Public Property Authorization As String

    <DataMember(Name:="Username")>
    Public Property Username As String

    <DataMember(Name:="SentDate")>
    Public Property SentDate = String.Format("{{ts '{0:yyyy-MM-dd HH:mm:ss}'}}",
                                             Date.UtcNow)
    <DataMember(Name:="Action")>
    Public Property Action As String = "GET"

    Public Sub AddTo(headers As System.Collections.Specialized.NameValueCollection)

        With headers
            .Clear()
            .Add("Authorization", Authorization)
            .Add("Username", Username)
            .Add("SentDate", SentDate)
            .Add("Action", Action)
        End With


    End Sub

End Class
