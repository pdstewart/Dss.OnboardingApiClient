
<DataContract()>
Public Class SubmittedFormPdf

    <DataMember(Name:="formID")>
    Public Property FormID As Integer

    <DataMember(Name:="formInfo")>
    Public Property FormInfo As SubmittedFormInfo

    <DataMember(Name:="pdf")>
    Public Property Pdf As PdfData

    <DataContract()>
    Public Class PdfData

        <DataMember(Name:="data")>
        Public Property UrlBase64Data As String

        Public ReadOnly Property FileBytes As Byte()
            Get
                Return Convert.FromBase64String(System.Web.HttpUtility.UrlDecode(UrlBase64Data))
            End Get
        End Property

    End Class

End Class
