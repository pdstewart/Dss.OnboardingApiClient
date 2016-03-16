<DataContract()>
Public Class User

    <DataMember(Name:="id")>
    Public Property ID As Integer

    <DataMember(Name:="first_name")>
    Public Property FirstName As String

    <DataMember(Name:="last_name")>
    Public Property LastName As String

    <DataMember(Name:="username")>
    Public Property Username As String

    <DataMember(Name:="active")>
    Public Property IsActive As Boolean

    <DataMember(Name:="email_address")>
    Public Property EmailAddress As String

End Class