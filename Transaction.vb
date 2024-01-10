' Transaction.vb

Public Class Transaction
    Public Shared Sub PerformTransaction(account As Account, amount As Decimal)
        Console.WriteLine($"Performing transaction on account {account}:")
        account.Deposit(amount)
        account.Withdraw(amount / 2)
        account.Display()
    End Sub
End Class
