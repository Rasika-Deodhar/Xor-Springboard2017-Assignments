interface Printable{
    element:number;
    print:()=>void;
}

let circle: Printable = {  
    element:1000,
    print:()=>console.log("Circle Printed with value = ",circle.element) 
}

let employee: Printable = {  
    element:2000,
    print:()=>console.log("Employee Printed with value = ",employee.element)
}

function printAll(circle:Printable,employee:Printable):void{
    circle.print();
    employee.print(); 
}

printAll(circle,employee);