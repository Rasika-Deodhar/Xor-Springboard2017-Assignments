function Employee(empid,ename,empSalary,deptno)
{
	this.empid = empid;
	this.ename = ename;
	this.empSalary = empSalary;
	this.deptno = deptno;
}

var EmployeeList = (function() 
{ 
	var employees = []; 
	var obj = { 
		addEmployee: function(employee){ 
			employees.push(employee);
		}, 
		getEmployees: function() { 
			return employees;
		},
		sort: function() {
			return employees.sort(function(a, b){return a.empid-b.empid});
		}
	};
	return obj;
})();

function test1()
{
	var emp1 = new Employee(22,"Ram",45661,12);
	var emp2 = new Employee(12,"Raj",45662,13);
	
	EmployeeList.addEmployee(emp1);
	EmployeeList.addEmployee(emp2);
	
	var employees = EmployeeList.getEmployees();
	console.log("employees", employees);
	
	var empSort = EmployeeList.sort();
	console.log("sorted",empSort);
	
}