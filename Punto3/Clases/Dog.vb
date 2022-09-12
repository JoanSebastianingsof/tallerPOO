Public Class Dog : Inherits Pet
    Public Sub New(idPet As Integer, namePet As String, breedPet As String, agePet As Integer, owner As Person)
        MyBase.New(idPet, namePet, breedPet, agePet, owner)

    End Sub
    Public Function training() As Boolean
        Return True
    End Function
End Class
