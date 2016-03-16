Imports ServiceStack.ServiceHost

<Route("/users/{Username}/form/{RouteFormID}", "GET")>
Public Class GetUserSubmittedFormResponses
    Implements IReturn(Of SubmittedFormResponses)

    Public Property Username As String

    Public Property FormID As Integer

    Public Property type As String = "questions"

    Public ReadOnly Property RouteFormID As String
        Get
            Return String.Format("{0}.json", FormID)
        End Get
    End Property


End Class
