Imports ServiceStack.ServiceHost

<Route("/division/{DivisionID}/complete.json", "GET")>
<DataContract()>
Public Class FindCompletedUsers
    Implements IReturn(Of List(Of CompletedUser))

    Public Sub New(divisionID As Integer)
        _DivisionID = divisionID
    End Sub

    <DataMember(Name:="DivisionID")>
    Public Property DivisionID As Integer

    Public Property PageIndex As Integer

    <DataMember(Name:="limit")>
    Public Property PageSize As Integer = 25

    <DataMember(Name:="offset")>
    Public ReadOnly Property Offset As Integer
        Get
            Return PageIndex * PageSize
        End Get
    End Property

    <DataMember(Name:="show_uid")>
    Public Property IncludeUserID As String = "true"

End Class
