' Bank.vb

Public Class Bank
    Private accounts As List(Of Account)

    Public Sub New()
        accounts = New List(Of Account)()
    End Sub

    Public Sub AddAccount(account As Account)
        accounts.Add(account)
    End Sub

    Public Sub DisplayAllAccounts()
        Console.WriteLine("All Accounts in the Bank:")
        For Each account In accounts
            account.Display()
        Next
    End Sub
End Class
