Imports ServiceStack.ServiceHost

<Route("/users/{UserID}/responses.json", "GET")>
<DataContract()>
Public Class FindUserAnswers
    Implements IReturn(Of List(Of UserAnswer))

    Public Sub New(userID As String)
        _UserID = userID
    End Sub

    <DataMember(Name:="UserID")>
    Public Property UserID As String

    Public Property PageIndex As Integer

    <DataMember(Name:="limit")>
    Public Property PageSize As Integer = 100

    <DataMember(Name:="offset")>
    Public ReadOnly Property Offset As Integer
        Get
            Return PageIndex * PageSize
        End Get
    End Property

End Class
