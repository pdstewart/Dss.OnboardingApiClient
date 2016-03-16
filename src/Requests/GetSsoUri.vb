
Imports ServiceStack.ServiceHost

<Route("/SSO/{RouteUid}", "POST")>
Public Class GetSsoUri
    Implements IReturn(Of SsoInfo)

    Public Property Uid As Guid

    Public ReadOnly Property RouteUid As String
        Get
            Return String.Format("{0}.json", Helper.CreateCFUuid(Uid))
        End Get
    End Property

End Class
