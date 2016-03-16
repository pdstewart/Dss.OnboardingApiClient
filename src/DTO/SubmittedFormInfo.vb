
<DataContract()>
Public Class SubmittedFormInfo

    <DataMember(Name:="utc_submission_timestamp")>
    Public Property TimeSubmittedUtc As DssDate

    <DataMember(Name:="utc_approved_timestamp")>
    Public Property TimeApprovedUtc As DssDate

    <DataMember(Name:="approved")>
    Public Property IsApproved As Boolean

End Class
