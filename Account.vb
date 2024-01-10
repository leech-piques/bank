' Account.vb

Public Class Account
    Private accountNumber As Integer
    Private balance As Decimal

    Public Sub New(accNumber As Integer, initialBalance As Decimal)
        accountNumber = accNumber
        balance = initialBalance
    End Sub

    Public Sub Deposit(amount As Decimal)
        balance += amount
    End Sub

    Public Sub Withdraw(amount As Decimal)
        If balance >= amount Then
            balance -= amount
        Else
            Console.WriteLine("Insufficient funds!")
        End If
    End Sub

    Public Sub Display()
        Console.WriteLine($"Account Number: {accountNumber}, Balance: ${balance}")
    End Sub
End Class
