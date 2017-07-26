export function Class_Modules(){

class Account{

    constructor(accId,accName,accBal){
        this.accId=accId;
        this.accName=accName;
        this.accBal=accBal;
    }

    getaccBal(){
        return this.accBal;
    }
}

class SavingAccount extends Account{

    constructor(accId,accName,accBal,interest){
        super(accId,accName,accBal);
        this.interest=interest;
    }

    getaccBal(){
        return this.accBal+this.interest;
    } 
}

class CurrentAccount extends Account{

    constructor(accId,accName,accBal,cashCredit){
        super(accId,accName,accBal);
        this.cashCredit=cashCredit;
    }

    getaccBal(){
        return this.accBal+this.cashCredit;
    } 
}

test_accounts();

function test_accounts(){

let sAccount1 = new SavingAccount(123,'Gilly',1000,1000);
let sAccount2 = new SavingAccount(124,'Billy',1000,1000);
let sAccount3 = new SavingAccount(125,'Milly',1000,1000);

let cAccount1 = new CurrentAccount(151,'Gilly',1000,1000);
let cAccount2 = new CurrentAccount(152,'Billy',1000,1000);
let cAccount3 = new CurrentAccount(153,'Milly',1000,1000);

//console.log(cAccount1.getaccBal());

let accounts = [sAccount1,sAccount2,sAccount3,cAccount1,cAccount2,cAccount3];
getTotalCashInBank(accounts);
}

function getTotalCashInBank(accounts){
    let total_cash = 0;
    // for(let acc of accounts){
    //     total_cash+=acc.getaccBal();
    //     console.log("Account Bal = ", acc.getaccBal());
    // }
    // console.log("Total Cash in Bank is = ",total_cash);

    accounts.forEach(function(acc){

            total_cash = total_cash + acc.getaccBal();


    });
    //console.log(total_cash);
    console.log("Total Cash in Bank is = ",total_cash);
}

}