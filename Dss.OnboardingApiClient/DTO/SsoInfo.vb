<DataContract()>
Public Class SsoInfo

    <DataMember(Name:="endpoint")>
    Public Property RelativePath As String

    <DataMember(Name:="confirmed")>
    Public Property IsSsoConfirmed As Boolean

End Class
