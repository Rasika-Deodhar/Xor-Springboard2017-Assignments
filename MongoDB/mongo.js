db

use emp_db

db.createCollection("Dept")

db.Dept.insert([
{
    empno : 7369,
    ename : 'Smith',
    job : 'Clerk',
    mgr : 7902,
    hiredate : Date("2000-12-17"),
    sal : 4000,
    comm : null,
    deptno : 10,
    dname : 'Accounting',
    loc : 'New York'
},
{
    empno : 7499,
    ename : 'Allen',
    job : 'Salesman',
    mgr : 7698,
    hiredate : Date("2001-02-20"),
    sal : 1600,
    comm : 300,
    deptno : 30,
    dname : 'Sales',
    loc : 'Chicago'
},
{
    empno : 7521,
    ename : 'Ward',
    job : 'Salesman',
    mgr : 7698,
    hiredate : Date("2001-02-22"),
    sal : 1250,
    comm : 500,
    deptno : 30,
    dname : 'Sales',
    loc : 'Chicago'
},
{
    empno : 7566,
    ename : 'Jones',
    job : 'Manager',
    mgr : 7839,
    hiredate : Date("2002-04-02"),
    sal : 2975,
    comm : null,
    deptno : 20,
    dname : 'Research',
    loc : 'Dallas'
},
{   empno:7654,
    ename:'martin', 
    job:'salesman',
    mgr:7698, 
    hiredate:Date("28-sep-01"),
    sal:1250, 
    comm:1400,
    deptno:30,
    dname : 'Sales',
    loc : 'Chicago'
},
{   empno:7698,
    ename:'blake', 
    job:'manager',
    mgr:7839, 
    hiredate:Date("01-may-01"),
    sal:2850, 
    comm:null,
    deptno:30,
    dname : 'Sales',
    loc : 'Chicago'
},
{
    empno:7782,
    ename:'clark', 
    job:'manager',
    mgr:7839, 
    hiredate:Date("09-jun-01"),
    sal:2450, 
    comm:null,
    deptno:10,
    dname : 'Accounting',
    loc : 'New York'
},
{   empno:7788,
    ename:'scott', 
    job:'analyst',
    mgr:7566, 
    hiredate:Date("19-apr-07"),
    sal:3000, 
    comm:null,
    deptno:20,
    dname : 'Research',
    loc : 'Dallas'
},
{   empno:7839,
    ename:'king', 
    job:'president',
    mgr:null, 
    hiredate:Date("17-nov-01"),
    sal:5000, 
    comm:null,
    deptno:10,
    dname : 'Accounting',
    loc : 'New York'
},
{   empno:7844,
    ename:'turner', 
    job:'salesman',
    mgr:7698, 
    hiredate:Date("08-sep-01"),
    sal:1500, 
    comm:0,
    deptno:30,
    dname : 'Sales',
    loc : 'Chicago'
},
{   empno:7876,
    ename:'adams', 
    job:'clerk',
    mgr:7788, 
    hiredate:Date("23-may-07"),
    sal:1100, 
    comm:null,
    deptno:20,
    dname : 'Research',
    loc : 'Dallas'
},
{   empno:7900,
    ename:'james', 
    job:'clerk',
    mgr:7698, 
    hiredate:Date("03-dec-01"),
    sal:950, 
    comm:null,
    deptno:30,
    dname : 'Sales',
    loc : 'Chicago'
},
{   empno:7934,
    ename:'miller', 
    job:'clerk',
    mgr:7782, 
    hiredate:Date("23-jan-01"),
    sal:1300, 
    comm:null,
    deptno:10,
    dname : 'Accounting',
    loc : 'New York'
}
])

db.Dept.find()
db.Dept.find().pretty()
db.Dept.drop()

/*1*/
db.Dept.distinct('dname')

/*2*/
db.Dept.find({}, {"ename" : 1,_id: 0})
db.Dept.distinct('ename')

/*3*/
db.Dept.find({deptno:30})

/*4*/
db.Dept.find({job:'clerk'}, {"ename" : 1,"job" : 1,"empno" : 1,"deptno" : 1,_id: 0})

/*5*/
db.Dept.find({deptno:{$gte:20}}, {"deptno":1,"ename" : 1,_id: 0})

/*6*/
db.Dept.find({$where:"this.comm > this.sal"})

/*7*/
db.Dept.find({$where:"this.comm > this.sal * 0.6"})

/*8*/
db.Dept.find({$where:"this.comm > this.sal * 0.5"})

/*9*/
/*db.Dept.find({$where:"this.sal>2000"},{dept:{$e:20}}, {"ename" : 1,"job":1,"sal":1,_id: 0})*/
db.Dept.find({
    $and:
    [
        {deptno : {$eq:20}},
        {sal : {$gte:2000}}
    ]
    })

/*10*/
db.Dept.find({
    $and:
    [
        {deptno : {$eq:30}},
        {sal : {$gte:1500}}
    ]
    })
    
/*11*/
db.Dept.find({
    $or:
    [
        {job : 'president'},
        {job : 'manager'}
    ]
    })
    
/*12*/
db.Dept.find({
    $and:
    [
        {job:'manager'},
        {deptno: {$ne:30}}
    ]        
    })

/*13*/
db.Dept.find({
    $and:
    [
        {
            $or:
            [
                {job:'manager'},
                {job:'clerk'}
            ]
        },
        {deptno:10}
    ]        
    })

/*14*/
db.Dept.find({
    $or:
    [
        {
            job:'manager'
        },
        {
            $and:
            [
                {job:'clerk'},
                {dept:10}
            ]
        }
    ]        
    })

db.Dept.find()