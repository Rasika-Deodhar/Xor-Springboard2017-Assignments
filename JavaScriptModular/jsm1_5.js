function BankAccount(accNo,accBal,accName)
{
	this.accNo = accNo;
	this.accBal = accBal;
	this.accName = accName;
	
	/*this.withdraw = function (amt)
	{
		accBal-=amt;
		return accBal;
	}
	
	this.deposit = function (amt)
	{
		accBal+=amt;
		return accBal;
	}*/
}

BankAccount.prototype.withdraw = function(amt)
{
	this.accBal-=amt;
}
BankAccount.prototype.deposit = function(amt)
{
	this.accBal+=amt;
}
BankAccount.prototype.getBal = function()
{
	return this.accBal;
}

function test5()
{
	var BA = new BankAccount(1234,10000,"Rasika");
	
	document.write("Initial Account Balance = " + BA.getBal());
	document.write("<br>");
	BA.deposit(100);
	document.write("After Deposit of 100 Rs= " + BA.getBal());
	document.write("<br>");
	BA.withdraw(500);
	document.write("After Withdrawal of 500 Rs= " + BA.getBal());
}