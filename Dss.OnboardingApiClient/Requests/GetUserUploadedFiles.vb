
Imports ServiceStack.ServiceHost

<Route("/users/{Username}/uploads.json", "GET")>
Public Class GetUserUploadedFiles
    Implements IReturn(Of List(Of UploadedFileMetadata))

    Public Property Username As String

End Class
