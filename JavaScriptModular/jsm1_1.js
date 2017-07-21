var BankAccount = {
accNo:12345,
accBal : 12000, 
accName : "Rasika",
withdraw: function(amt)
	{
		this.accBal-=amt;
		return BankAccount.accBal;
	},
deposit: function(amt)
	{
		this.accBal+=amt;
		return BankAccount.accBal;
	}	
};

function test1()
{
	document.write("Initial Account Balance = " + BankAccount.accBal);
	document.write("<br>");
	document.write("After Deposit of 100 Rs= " + BankAccount.deposit(100));
	document.write("<br>");
	document.write("After Withdrawal of 500 Rs= " + BankAccount.withdraw(500));
}	