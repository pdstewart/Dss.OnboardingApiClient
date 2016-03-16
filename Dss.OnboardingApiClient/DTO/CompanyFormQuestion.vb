
<DataContract()>
Public Class CompanyFormQuestion

    <DataMember(Name:="question_number")>
    Public Property QuestionNumber As Integer

    <DataMember(Name:="question_text")>
    Public Property QuestionText As String

    <DataMember(Name:="question_type")>
    Public Property QuestionType As String

    <DataMember(Name:="choices")>
    Public Property Choices As List(Of String)

    <DataMember(Name:="special_format")>
    Public Property SpecialFormat As String

    <DataMember(Name:="max_length")>
    Public Property MaxLength As String

    <DataMember(Name:="max_value")>
    Public Property MaxValue As String

    <DataMember(Name:="min_value")>
    Public Property MinValue As String

End Class
