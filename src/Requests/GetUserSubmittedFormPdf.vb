Imports ServiceStack.ServiceHost

<Route("/users/{Username}/form/{RouteFormID}", "GET")>
Public Class GetUserSubmittedFormPdf
    Implements IReturn(Of SubmittedFormPdf)

    Public Property Username As String

    Public Property FormID As Integer

    Public Property type As String = "pdf"

    Public ReadOnly Property RouteFormID As String
        Get
            Return String.Format("{0}.json", FormID)
        End Get
    End Property


End Class
