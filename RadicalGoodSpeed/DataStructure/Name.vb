Public Class Name
    
    public ReadOnly Property GivenName() As String
    Public ReadOnly Property FamilyName() As String
    
    Public sub New(givenName As String, familyName As String)
        Me.GivenName = givenName
        Me.FamilyName = familyName
    End sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim other = TryCast(obj, Name)

        If other Is Nothing then Return False

        Return GivenName = other.GivenName AndAlso FamilyName = other.FamilyName
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return GivenName.GetHashCode() Xor FamilyName.GetHashCode()
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0} {1}", GivenName, FamilyName)
    End Function

End Class