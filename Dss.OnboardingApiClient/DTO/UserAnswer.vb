<DataContract()>
Public Class UserAnswer
    <DataMember(Name:="question_text")>
    Public Property QuestionText As String

    <DataMember(Name:="question_number")>
    Public Property QuestionID As Integer

    <DataMember(Name:="responses")>
    Public Property Responses As List(Of String)

    Public Overrides Function ToString() As String
        Return String.Format("{0} {1}",
                             QuestionText,
                             String.Join(", ", Responses))
    End Function
End Class