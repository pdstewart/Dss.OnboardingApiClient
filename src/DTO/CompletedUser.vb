<DataContract()>
Public Class CompletedUser
    <DataMember(Name:="division_id")>
    Public Property DivisionID As Integer

    <DataMember(Name:="username")>
    Public Property Username As String

    <DataMember(Name:="utc_latest_approved_date")>
    Public Property LatestApproval As Date

    <DataMember(Name:="user_id")>
    Public Property ID As Integer

End Class
