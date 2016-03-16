Imports ServiceStack.ServiceHost

<Route("/company/{CompanyID}/form/{RouteFormID}", "GET")>
Public Class GetCompanyFormDetail
    Implements IReturn(Of CompanyFormDetail)

    Public Property CompanyID As Integer

    Public Property FormID As Integer

    Public Property Type As String = "questions"

    Public ReadOnly Property RouteFormID As String
        Get
            Return String.Format("{0}.json", FormID)
        End Get
    End Property

End Class
