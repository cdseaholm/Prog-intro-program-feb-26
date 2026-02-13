


namespace Banking.Domain;

public class Account
{
    private decimal _currentBalance = 5000M;

    public void Deposit(decimal amountToDeposit)
    {

        _currentBalance += amountToDeposit;
    }

    public decimal GetBalance()
    {

        return _currentBalance;
    }

    // Primitive Obsession 
    public void Withdraw(decimal amountToWithdraw)
    {

        if (amountToWithdraw > _currentBalance)
        {
            // exit with an exception - abnormal end.
            throw new OverdraftNotAllowedException();
        }
        _currentBalance -= amountToWithdraw;


    }


}

public class OverdraftNotAllowedException : ArgumentOutOfRangeException { }