var circle = {
    element: 1000,
    print: function () { return console.log("Circle Printed with value = ", circle.element); }
};
var employee = {
    element: 2000,
    print: function () { return console.log("Employee Printed with value = ", employee.element); }
};
function printAll(circle, employee) {
    circle.print();
    employee.print();
}
printAll(circle, employee);
