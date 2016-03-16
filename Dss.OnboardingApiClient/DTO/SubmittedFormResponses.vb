
<DataContract()>
Public Class SubmittedFormResponses

    <DataMember(Name:="formID")>
    Public Property FormID As Integer

    <DataMember(Name:="formInfo")>
    Public Property FormInfo As SubmittedFormInfo

    <DataMember(Name:="questions")>
    Public Property Responses As List(Of FormResponse)

    <DataContract()>
    Public Class FormResponse

        <DataMember(Name:="question_number")>
        Public Property QuestionNumber As Integer

        <DataMember(Name:="response")>
        Public Property Response As String

    End Class

End Class
