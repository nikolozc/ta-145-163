Public Class Enemy

    Public Shared StartHealth As Integer = 100
    Private intHealth As Integer
    Public ReadOnly Attacks(3) As String
    Public attackNum As Integer
    Public ReadOnly AttackDamage(3) As String
    Public strName As String

    Sub New()
        intHealth = StartHealth
    End Sub

    Public Overridable Sub Attack(ByRef userHealth As Integer)
    End Sub

    Public Property Health() As Integer
        Get
            Return intHealth
        End Get
        Set(value As Integer)
            intHealth = value
        End Set
    End Property
End Class
