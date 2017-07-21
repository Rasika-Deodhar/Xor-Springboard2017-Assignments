function BankAccount(accNo,accBal,accName)
{
	this.accNo = accNo;
	this.accBal = accBal;
	this.accName = accName;
	
	this.withdraw = function (amt)
	{
		accBal-=amt;
		return accBal;
	}
	
	this.deposit = function (amt)
	{
		accBal+=amt;
		return accBal;
	}
}

function test2()
{
	var BAcc = new BankAccount(12345,12000,"Rasika");
	document.write("Initial Account Balance = " + BAcc.accBal);
	document.write("<br>");
	document.write("After Deposit of 100 Rs= " + BAcc.deposit(100));
	document.write("<br>");
	document.write("After Withdrawal of 500 Rs= " + BAcc.withdraw(500));
}

