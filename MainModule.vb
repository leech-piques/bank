' MainModule.vb

Module MainModule
    Sub Main()
        ' Create an account with initial balance
        Dim myAccount As New Account(12345, 1000.0)

        ' Perform transactions
        Transaction.PerformTransaction(myAccount, 500.0)

        ' Display the final account information
        Console.WriteLine("Final account information:")
        myAccount.Display()

        ' Create a bank
        Dim bank As New Bank()

        ' Add accounts to the bank
        bank.AddAccount(myAccount)
        bank.AddAccount(New Account(67890, 1500.0))

        ' Display all accounts in the bank
        bank.DisplayAllAccounts()
    End Sub
End Module
