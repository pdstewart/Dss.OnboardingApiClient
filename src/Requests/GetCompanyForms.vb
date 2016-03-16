

Imports ServiceStack.ServiceHost

<Route("/company/{CompanyID}/forms.json", "GET")>
Public Class GetCompanyForms
    Implements IReturn(Of List(Of CompanyForm))

    Public Property CompanyID As Integer

End Class
