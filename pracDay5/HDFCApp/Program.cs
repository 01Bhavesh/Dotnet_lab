using System.Threading;
using Banking;
using Notification;
using Taxation;
Account acct = new Account();
acct.Balance = (50000);
acct.Deposit(6000);
float CurrentBalance = acct.Balance;
Console.WriteLine("current Balance = "+ CurrentBalance);
NotificationService.sendEmail("raj","your salary is deposited");
TaxationService.PayIncometax(5000);
Taxoperation revdi = new Taxoperation(TaxationService.PayServicetax);
revdi(6000);
//chaining
NotificationOperation proxyEml = new NotificationOperation(NotificationService.sendEmail);
NotificationOperation proxySMS = new NotificationOperation(NotificationService.sendSMS);
NotificationOperation proxyWhatsApp = new NotificationOperation(NotificationService.sendWhatsApp);
NotificationOperation proxy = null;

proxy+=proxyEml;
proxy+=proxySMS;
proxy+=proxyWhatsApp;

proxy("virat","hava ka jhoka");



//asynchronize
proxy.Invoke("rohit" , "captain");


Thread currentThread = Thread.CurrentThread;
int threadID = currentThread.ManagedThreadId;
Console.WriteLine("primary thread id = "+threadID);
Console.WriteLine("primary thread prioitry " + currentThread.Priority );


Account acct45 = new Account();
acct45.overBalance += TaxationService.PayIncometax;
acct45.overBalance += TaxationService.PayGSTtax;
acct45.underBalance += NotificationService.sendEmail;
acct45.underBalance += NotificationService.sendSMS;
acct45.underBalance += NotificationService.sendWhatsApp;


acct45.Balance=190000;
acct45.Withdraw(189000);
acct45.Deposit(500000);

// float currentBalance_2=acct45.Balance;
// Console.WriteLine(" Latest Balance of acct45 "+currentBalance_2);


Console.WriteLine(acct45.Balance);

