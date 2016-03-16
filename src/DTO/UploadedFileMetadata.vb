<DataContract()>
Public Class UploadedFileMetadata

    <DataMember(Name:="id")>
    Public Property ID As Integer

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="description")>
    Public Property Description As String

    <DataMember(Name:="category")>
    Public Property Category As String

    <DataMember(Name:="utc_upload_timestamp")>
    Public Property UploadTimeUtc As DssDate

End Class
