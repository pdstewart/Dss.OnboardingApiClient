Imports ServiceStack.ServiceHost

<DataContract()>
<Route("/users/{RouteUsername}", "PUT")>
Public Class DeactivateUser
    Implements IReturnVoid

    <IgnoreDataMember()>
    Public Property Username As String

    <DataMember(Name:="active")>
    Public Property Active As Boolean = False

    <DataMember(Name:="RouteUsername")>
    Public ReadOnly Property RouteUsername As String
        Get
            Return String.Format("{0}.json", Username)
        End Get
    End Property

End Class

