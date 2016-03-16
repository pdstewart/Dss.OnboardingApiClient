
Imports ServiceStack.ServiceHost

<Route("/users/{Username}/uploads/{RouteFileID}", "GET")>
Public Class GetUserUploadedFile
    Implements IReturn(Of UploadedFile)

    Public Property Username As String

    Public Property FileID As Integer

    Public ReadOnly Property RouteFileID As String
        Get
            Return String.Format("{0}.json", FileID)
        End Get
    End Property

End Class
