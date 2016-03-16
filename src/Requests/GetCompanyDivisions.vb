Imports ServiceStack.ServiceHost

<Route("/company/{CompanyID}/divisions.json", "GET")>
Public Class GetCompanyDivisions
    Implements IReturn(Of CompanyDivisions)

    Public Property CompanyID As Integer

End Class
