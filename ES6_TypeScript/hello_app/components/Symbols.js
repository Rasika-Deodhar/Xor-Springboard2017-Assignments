let prevNo = Symbol();
let currNo = Symbol();

class Fibonacci{
        
        constructor(prev,curr){
            this[prevNo] = prev;
            this[currNo] = curr;
        }

        next(){
            [this[prevNo], this[currNo]] = [this[currNo], this[prevNo] + this[currNo]];
            console.log("Next Value = ",this[currNo]); 
            //return {done: false, value: this[currNo]};
        }
    }

export function Symbols(){

    let fib1 = new Fibonacci(0,1);
    fib1.next();
    fib1.next();
    fib1.next();
}