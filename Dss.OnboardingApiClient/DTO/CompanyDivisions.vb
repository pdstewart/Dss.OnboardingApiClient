<DataContract()>
Public Class CompanyDivisions

    <DataMember(Name:="companyID")>
    Public Property CompanyID As Integer

    <DataMember(Name:="divisions")>
    Public Property Divisions As List(Of Division)

End Class
