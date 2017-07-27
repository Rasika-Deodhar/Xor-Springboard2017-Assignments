var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Bank = (function () {
    function Bank(id, name, balance) {
        this.id = id;
        this.name = name;
        this.balance = balance;
    }
    Bank.prototype.getBalance = function () {
        return this.balance;
    };
    return Bank;
}());
var SavingAccount = (function (_super) {
    __extends(SavingAccount, _super);
    function SavingAccount(id, name, balance, interest) {
        var _this = _super.call(this, id, name, balance) || this;
        _this.interest = interest;
        return _this;
    }
    SavingAccount.prototype.getBalance = function () {
        return (this.balance + this.interest);
    };
    return SavingAccount;
}(Bank));
var CurrentAccount = (function (_super) {
    __extends(CurrentAccount, _super);
    function CurrentAccount(id, name, balance, cashCredit) {
        var _this = _super.call(this, id, name, balance) || this;
        _this.cashCredit = cashCredit;
        return _this;
    }
    CurrentAccount.prototype.getBalance = function () {
        return (this.balance + this.cashCredit);
    };
    return CurrentAccount;
}(Bank));
testAccounts();
function testAccounts() {
    var s1 = new SavingAccount(123, 'Gilly', 1000, 1000);
    var s2 = new SavingAccount(124, 'Billy', 1000, 1000);
    var c1 = new SavingAccount(125, 'Milly', 1000, 1000);
    var c2 = new SavingAccount(126, 'Villy', 1000, 1000);
    var acc = [s1, s2, c1, c2];
    getTotalBankCash(acc);
}
function getTotalBankCash(acc) {
    var total_cash = 0;
    acc.forEach(function (a) {
        total_cash += a.getBalance();
    });
    console.log("Total cash = ", total_cash);
}
