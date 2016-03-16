<DataContract()>
Public Class UploadedFile

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

    <DataMember(Name:="extension")>
    Public Property MimeType As String

    <DataMember(Name:="data")>
    Public Property UrlBase64Data As String

    Public ReadOnly Property FileBytes As Byte()
        Get
            Return Convert.FromBase64String(System.Web.HttpUtility.UrlDecode(UrlBase64Data))
        End Get
    End Property

End Class
