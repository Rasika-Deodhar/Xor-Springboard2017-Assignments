var BankAccount = {
accNo:0000,
accBal : 100, 
accName : "R",
withdraw: function(amt)
	{
		this.accBal-=amt;
		return this.accBal;
	},
deposit: function(amt)
	{
		this.accBal+=amt;
		return this.accBal;
	}	
};

function test3()
{
	var BA = Object.create(BankAccount);
	BA.accNo=1234;
	BA.accBal=13000;
	BA.accName="Rasika";
	
	
	document.write("Initial Account Balance = " + BA.accBal);
	document.write("<br>");
	document.write("After Deposit of 100 Rs= " + BA.deposit(100));
	document.write("<br>");
	document.write("After Withdrawal of 500 Rs= " + BA.withdraw(500));
	
}