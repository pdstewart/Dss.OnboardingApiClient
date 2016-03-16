Public Structure DssDate

    Public Sub New(d As Date?)
        _value = d
    End Sub

    Private _value As Date?

    Public ReadOnly Property HasValue As Boolean
        Get
            Return _value.HasValue
        End Get
    End Property

    Public Property Value As Date
        Get
            Return _value.Value
        End Get
        Set(value As Date)
            _value = value
        End Set
    End Property

    Public Function GetValueOrDefault() As Date
        Return _value.GetValueOrDefault()
    End Function

    Public Overrides Function ToString() As String
        Return _value.ToString()
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return _value.GetHashCode()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If TypeOf obj Is DssDate Then
            Dim other = DirectCast(obj, DssDate)

            Return _value.GetValueOrDefault().Equals(other.GetValueOrDefault())

        End If

        Return _value.Equals(obj)
    End Function

End Structure
