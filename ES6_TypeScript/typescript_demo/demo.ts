class Bank{

    id:number;
    name:String;
    balance:number;

    constructor(id:number,name:String,balance:number){
        this.id = id;
        this.name = name;
        this.balance = balance;
    }

    getBalance():number{
        return this.balance;
    }
}

class SavingAccount extends Bank{

    interest:number;

    constructor(id:number,name:String,balance:number,interest:number){
        super(id,name,balance);
        this.interest = interest;
    }

    getBalance():number{
        return (this.balance+this.interest);
    }    
}

class CurrentAccount extends Bank{

    cashCredit:number;

    constructor(id:number,name:String,balance:number,cashCredit:number){
        super(id,name,balance);
        this.cashCredit = cashCredit;
    }

    getBalance():number{
        return (this.balance+this.cashCredit);
    }     
}

testAccounts();

function testAccounts():void{

    let s1= new SavingAccount(123,'Gilly',1000,1000);
    let s2= new SavingAccount(124,'Billy',1000,1000);
    let c1= new SavingAccount(125,'Milly',1000,1000);
    let c2= new SavingAccount(126,'Villy',1000,1000);
    let acc:Array<object> = [s1,s2,c1,c2];

    getTotalBankCash(acc);
}

function getTotalBankCash(acc):void{

    let total_cash:number = 0;

    acc.forEach(a=> {
        total_cash+=a.getBalance();
    });


    console.log("Total cash = ",total_cash);
}