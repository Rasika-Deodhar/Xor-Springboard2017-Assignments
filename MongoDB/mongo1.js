show dbs

use emp_db

db.createCollection("Dept")

db.Dept.insert([
{
    empno : 7369,
    ename : 'Smith',
    job : 'Clerk',
    mgr : 7902,
    hiredate : Date("2000-12-17"),
    sal : 800,
    comm : null,
    deptno : 20,
    dname : 'Research',
    loc : 'Dallas'
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
    ename:'Martin', 
    job:'Salesman',
    mgr:7698, 
    hiredate:Date("28-09-01"),
    sal:1250, 
    comm:1400,
    deptno:30,
    dname : 'Sales',
    loc : 'Chicago'
},
{   empno:7698,
    ename:'Blake', 
    job:'Manager',
    mgr:7839, 
    hiredate:Date("01-05-01"),
    sal:2850, 
    comm:null,
    deptno:30,
    dname : 'Sales',
    loc : 'Chicago'
},
{
    empno:7782,
    ename:'Clark', 
    job:'Manager',
    mgr:7839, 
    hiredate:Date("09-06-01"),
    sal:2450, 
    comm:null,
    deptno:10,
    dname : 'Accounting',
    loc : 'New York'
},
{   empno:7788,
    ename:'Scott', 
    job:'Analyst',
    mgr:7566, 
    hiredate:Date("19-04-07"),
    sal:3000, 
    comm:null,
    deptno:20,
    dname : 'Research',
    loc : 'Dallas'
},
{   empno:7839,
    ename:'King', 
    job:'President',
    mgr:null, 
    hiredate:Date("17-11-01"),
    sal:5000, 
    comm:null,
    deptno:10,
    dname : 'Accounting',
    loc : 'New York'
},
{   empno:7844,
    ename:'Turner', 
    job:'Salesman',
    mgr:7698, 
    hiredate:Date("08-09-01"),
    sal:1500, 
    comm:0,
    deptno:30,
    dname : 'Sales',
    loc : 'Chicago'
},
{   empno:7876,
    ename:'Adams', 
    job:'Clerk',
    mgr:7788, 
    hiredate:Date("23-05-07"),
    sal:1100, 
    comm:null,
    deptno:20,
    dname : 'Research',
    loc : 'Dallas'
},
{   empno:7900,
    ename:'James', 
    job:'Clerk',
    mgr:7698, 
    hiredate:Date("03-12-01"),
    sal:950, 
    comm:null,
    deptno:30,
    dname : 'Sales',
    loc : 'Chicago'
},
{   empno:7934,
    ename:'Miller', 
    job:'Clerk',
    mgr:7782, 
    hiredate:Date("23-01-01"),
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
                {deptno:10}
            ]
        }
    ]        
    })

/*15*/
db.Dept.find({
    $or:
    [
        {
            $and:
            [
                {job:'manager'},
                {deptno:10}
            ]
        },
        {
            $and:
            [
                {job:'clerk'},
                {deptno:20}
            ]
        }
    ]
    })
    
/*16*/
db.Dept.find({
    $and:
    [
        {job: {$ne:'clerk'}},
        {job: {$ne:'manager'}},
        {sal: {$gte:2000}}
    ]
    })    
    
/*17*/
db.Dept.find({
    $and:
    [
        {sal:{$gt:1200}},
        {sal:{$lt:1400}}
    ]
    })
    
/*18*/
db.Dept.find({
    $or:
    [
        {job:'Analyst'},
        {job:'analyst'},
        {job:'clerk'},
        {job:'Clerk'},
        {job:'Salesman'},
        {job:'salesman'}
    ]
    })
    
/*19*/
db.Dept.find({
    $or:
    [
        {job: {$ne: 'Analyst'}},
        {job: {$ne: 'analyst'}},
        {job: {$ne: 'clerk'}},
        {job: {$ne: 'Clerk'}},
        {job: {$ne: 'Salesman'}},
        {job: {$ne: 'salesman'}}
    ]
    })
    
/*20*/
db.Dept.find({
    comm:null
    })
    
/*21*/
db.Dept.find({
    comm:0
    })
    
/*22*/
db.Dept.distinct('job',{comm:{$ne: null}})

/*23*/
db.Dept.find({
    $or:
    [
        {comm : {$eq: null}},
        {comm : {$lt: 100}}
    ]
    })
    
/*24*/

/*25*/
db.Dept.find({
    $where:"(this.sal+this.comm) > 200"
    })
    
/*26*/
db.Dept.find({
    ename : {$regex: /^m./}
    })
    
/*27*/
db.Dept.find({
    ename : {$regex: /s$/}
    })
    
/*28*/
db.Dept.find({
    ename : {$regex: /.*m.*/}
    })

/*29*/
db.Dept.find({
    ename : {$regex: /^[a-zA-Z]{4}n$/}
    })    

/*30*/
db.Dept.find({
    ename : {$regex: /^[a-zA-Z]{2}r.*$/}
    })   


/*31*/
    

/*55*/
db.Dept.find().sort({'ename' : 1})

/*56*/
db.Dept.find().sort({'hiredate' : -1})

/*57*/
db.Dept.find({},{'ename':1,'job':1,'sal':1}).sort({'sal':1},{'job':1})

/*58*/
db.Dept.find({},{'ename':1,'job':1,'sal':1}).sort({'job':1},{'sal':-1})

/*59*/
db.Dept.find({},{'ename':1,'job':1,'sal':1}).sort({'job':-1},{'sal':-1})

/*60*/
db.Dept.aggregate(
    [
        {
            "$project":
            {
                "ename":1,
                "year": { "$year": "$hiredate" },
                "month": { "$month": "$hiredate" }
            },
        },
        {
                "$sort":{"month" : 1}
        }
    ])

db.Dept.find()