Imports ServiceStack.ServiceHost

<Route("/users/{Username}/forms.json", "GET")>
Public Class GetUserSubmittedForms
    Implements IReturn(Of List(Of AssignedForm))

    Public Property Username As String

End Class