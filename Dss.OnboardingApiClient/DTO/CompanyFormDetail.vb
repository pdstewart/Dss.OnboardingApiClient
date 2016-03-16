
<DataContract()>
Public Class CompanyFormDetail

    <DataMember(Name:="form_questions")>
    Public Property Questions As List(Of CompanyFormQuestion)

    <DataMember(Name:="form_details")>
    Public Property FormInfo As CompanyForm

End Class
