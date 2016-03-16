<DataContract()>
Public Class AssignedForm

    <DataMember(Name:="form_id")>
    Public Property FormID As Integer

    <DataMember(Name:="utc_latest_submission_date")>
    Public Property LatestSubmissionUtc As DssDate

    <DataMember(Name:="utc_latest_approved_date")>
    Public Property LatestApprovalUtc As DssDate

End Class
