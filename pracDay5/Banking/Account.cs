namespace Banking;
using Taxation;
using Notification;

public class Account{
    public event NotificationOperation underBalance;
    public event Taxoperation overBalance;
    public float Balance{get;set;}
    public void Deposit(float amount)
    {
        this.Balance = this.Balance+amount;
        if(this.Balance>=200000)
        {
            overBalance(5000);
        }
    }
    public void Withdraw(float amount)
    {
        this.Balance = this.Balance-amount;
        if(this.Balance<10000)
        {
            underBalance("rohit","your account is block");
        }
    }
}
