Imports ServiceStack.ServiceHost

<Route("/users/{RouteUsername}", "GET")>
Public Class GetUser
    Implements IReturn(Of User)

    Public Property Username As String

    Public ReadOnly Property RouteUsername As String
        Get
            Return String.Format("{0}.json", Username)
        End Get
    End Property

End Class
