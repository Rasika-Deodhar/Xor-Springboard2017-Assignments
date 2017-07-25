show dbs

use Emp_Dept_Db

db.createCollection("Emp")

db.Emp.insert([
{
    empno : 7369,
    ename : 'Smith',
    job : 'Clerk',
    mgr : 7902,
    hiredate : ISODate("2000-12-17"),
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
    hiredate : ISODate("2001-02-20"),
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
    hiredate : ISODate("2001-02-22"),
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
    hiredate : ISODate("2002-04-02"),
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
    hiredate:ISODate("2001-09-28"),
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
    hiredate:ISODate("2001-05-01"),
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
    hiredate:ISODate("2009-06-01"),
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
    hiredate:ISODate("2007-04-19"),
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
    hiredate:ISODate("2001-11-17"),
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
    hiredate:ISODate("2008-09-01"),
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
    hiredate:ISODate("2007-05-23"),
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
    hiredate:ISODate("2001-12-03"),
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
    hiredate:ISODate("2001-01-23"),
    sal:1300, 
    comm:null,
    deptno:10,
    dname : 'Accounting',
    loc : 'New York'
}
])


db.Emp.find()
db.Emp.find().pretty()
db.Emp.drop()

/*31*/
db.Emp.aggregate(
{
    "$project":
    {
        "ename":1,
        "hiredate":1,
        "month": {"$month" : "$hiredate"}
    }
},
{
    "$match" : 
    {
        month : 02
    }
}
)

/*32*/
/*db.Emp.aggregate(
{
    "$project":
    {
        "ename":1,
        "hiredate":1,
        "day": {"$dayOfMonth" : "$hiredate"},
        "month": {"$month" : "$hiredate"}
    }
},
{
    "$match" : 
    {
        $or:
        [
        {
          $and : [ {day:31},{$or:[{month:01},{month:03},{month:05},{month:07},{month:08},{month:10},{month:12}]}]
        },
        {
          $and : [ {day:30},{$or:[{month:04},{month:06},{month:09},{month:11}]}]
        },
        {
          $and : [ {day:29},{month:02}]
        }
        ]
    }
}
)*/
db.Emp.aggregate(
{
    "$project":
    {
        "ename":1,
        "hiredate":1,
        "day": {"$dayOfMonth" : "$hiredate"},
        "month": {"$month" : "$hiredate"},
        "lastday":{"$last" : "$day"}
    }
},
{
    "$match" : 
    {
        day : "lastday"
    }
}
)

/*33*/
db.Emp.aggregate([
{
    "$project":
    {
        "ename":1,
        "hiredate":1,
        "year" : {"$year" : "$hiredate"},
        /*"curryear":{"$year": new Date()},*/
        "curryear":{"$year": new ISODate()},
        //"diff" : {"$subtract" : ["$year": new ISODate(),"$year"]},
        //"diffyear" : {"$year" : "$diff"}
        //"sub" : {"$subtract" : [{"$year":new ISODate()},{"$year":"$hiredate"}]}
        "sub" : {"$subtract" : [{"$year":new ISODate()},{"$year":"$hiredate"}]}
    }
}
])

/*34*/
db.Emp.aggregate(
{
    "$project":
    {
        "ename":1,
        "job":1,
        "year" : {"$year" : "$hiredate"}
    }
},
{
      "$match" : 
    {
        "$and":
        [{year : 2007},{job:"Manager"}]
    }
}
)

/*35*/
db.Emp.aggregate(
{
    "$project":
    {
        "concat" : {"$concat":["$ename",",","$job"]}
    }
}
)

/*36*/
db.Emp.aggregate(
{
    "$project":
    {
        //"name" : {"$concat":{"$toUpper":{"$substr":["$ename",0,1]}},{"$substr":["$ename",1,**3**]}}
        "name":
        {"$concat":[{"$toUpper":{"$substr":["$ename",0,1]}},{"$substr":["$ename",1,{"$strLenCP":"$ename"}]}]}
        //db.toupper.aggregate([{$project:{name:{$concat:[{$toUpper:{$substr:["$name1",0,1]}},{$substr:["$name1",1,**3**]}]}}}])
    }
}
)

/*37*/

/*38*/

/*39*/
db.Emp.aggregate(
{
    "$project":
    {
        "ename" : 1,
        "length" : {"$strLenCP":"$ename"}
    }
}
)

/*40*/

/*41*/

/*42*/

/*43*/
db.Emp.aggregate(
{
    "$project":
    {
        "ename" : 1,
        "first3" : {"$substr":["$ename",0,3]}
    }
}
)

/*44*/
db.Emp.aggregate(
{
    "$project":
    {
        "ename" : 1,
        "last3" : { "$regex": /[a-zA-Z]{3}$/}
    }
}
)

db.Emp.find().forEach(function(doc)
{
var str=doc.ename.substr(doc.ename.length-3,3);
print(str);
}
)

/*45*/
db.Emp.find().forEach(function(doc)
{
    var str1 = doc.ename;
    doc.ename = doc.ename.replace('a','e');
    print(str1 + " = " + doc.ename);
}
)

/*46*/
db.Emp.find().forEach(function(doc)
{
var str=doc.ename.search("ar");
var name=doc.ename;
    if(str!=-1)
    {
       print(name+ " " +str);
    }
    else
    {
        print(name+ " has no occurance");
    }

}
)

/*47*/
db.Emp.find().forEach(function(doc)
{
    var name = doc.ename;
    var sal = doc.sal;
    sal = sal/1000;
    sal = Math.round(sal);
    sal*=1000;
    print(name + " has salary = " + sal);
}
)

db.Emp.aggregate(
{
    "$project":
    {
        "ename" : 1,
        "sal" : Math.round("($sal/1000)")*1000
    }
}
)

/*48*/
db.Emp.find().forEach(function(doc)
{
    var name = doc.ename;
    var sal = doc.sal;
    sal = sal/30;
    sal = Math.floor(sal);
    print(name + " has salary = " + sal);
}
)

/*49*/
db.Emp.find().forEach(function(doc)
{
    var name = doc.ename;
    var sal = doc.sal;
    var bonus = (0.2*sal);
    if(bonus>500)
    {
        bonus=500;
    }
    print(name + " has bonus = " + bonus);
}
)

/*50*/
db.Emp.find().forEach(function(doc)
{
    var name = doc.ename;
    var sal = doc.sal;
    var bonus = (0.2*sal);
    if(bonus>200)
    {
        bonus=200;
    }
    print(name + " has bonus = " + bonus);
}
)

/*51*/
db.Emp.aggregate(
{
    "$project" : {
        "_id" : 1,
        "daySince" : {
            "$divide" : [
                {
                    "$subtract" : [
                        new ISODate(),
                        "$hiredate"
                    ]
                },
                86400000 //1000*60*60*24
            ]
        }
    }
}
)

/*52*/
db.Emp.aggregate(
{
    "$project" : {
        "_id" : 1,
        "daySince" : {
            "$divide" : [
                {
                    "$subtract" : [
                        new ISODate(),
                        "$hiredate"
                    ]
                },
                1036800000 //1000*60*60*24*12
            ]
        }
    }
}
)

/*53*/
db.Emp.find().forEach(function(doc)
{
    var date = doc.hiredate;
    var curr = new ISODate();
    
    print(doc.ename + " has completed " + (curr-date)/86400000 + " days, " + (curr-date)/1036800000 + " months and " + (curr-date)/31536000000 +" years.")
})

/*54*/


db.sales.aggregate( [ { $project: { item: 1, dateDifference: { $subtract: [ "$date", 5 * 60 * 1000 ] } } } ] )

/********************************MONGO DB COMPLEX QUERIES*******************/

/*1*/
db.Emp.aggregate(
{
    "$project":
    {
        "ename":1,
        "dname":1,
        "sal": 1
    }
},
{
       "$group":
        {
           _id: "$item",
            "$ename":1,
        "$dname":1,
        "$sal": 1,
           minsal: { $min: "$sal" }
        }
}
)
db.Emp.find().sort(sal).limit(1)
db.Emp.aggregate(
   [
     { $project : {ename:1,sal:1,dname:1} },
     { $sort : { sal : 1} },
     { $limit : 1 }
   ]
)

/*2*/
db.Emp.aggregate(
[
   {$group : {_id: "$deptno", salary : {$min : "$sal"}}}
]
)

/*3*/
db.Emp.find({job:"Clerk"})

/*6*/
db.Emp.find()

/*7*/
db.Emp.find({},{deptno:1,dname:1,ename:1}).sort({deptno:1})

/*8*/
db.Emp.find({loc:"New York"},{ename:1,deptno:1,dname:1,loc:1})

/*9*/
db.Emp.aggregate(
[
   {$sort : {s}},
   {$group : {_id: "$deptno", salary : {$min : "$sal"}}}
]
)

db.Emp.find()