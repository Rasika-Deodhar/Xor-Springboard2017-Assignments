function BankAccount(accNo,accBal,accName)
{
	var accNo = accNo;
	var accBal = accBal;
	var accName = accName;
	
	function pWithdraw(amt)
	{
		accBal-=amt;
		//return accBal;
	}
	function pDeposit(amt)
	{
		accBal+=amt;
		//return accBal;
	}
	
	var obj1 = {
		withdraw(amt)
		{
			pWithdraw(amt);
			
		},
		deposit(amt)
		{
			pDeposit(amt);
			
		},
		getBal()
		{
			return accBal;
		}
	}
	
	return obj1;
	
}

function test4()
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