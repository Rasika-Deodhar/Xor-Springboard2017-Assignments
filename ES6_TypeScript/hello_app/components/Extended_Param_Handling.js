export function Extended_Param_Handling(){

    //Default
    let add = (a=5,b=5) => {
        console.log("Add = ",a+b);
    }

    console.log("Default values- 10");
    add();
    console.log("Default values- 7");
    add(2);
    console.log("Default values- 15");
    add(undefined,10);

    //Rest
    function userFriends(uName,...uFriends){
        console.log("User is -", uName, " and Friends are- ",uFriends);
        //uFriends.map(f()=>console.log("Friends of User are - ",uFriends));
    }
    userFriends('Rasika','Sakshi','Aishwariya','Padmaja');

    //Spread
    function printCapitalNames(name1,name2,name3,name4,name5){
        console.log(name1.toUpperCase());
        console.log(name2.toUpperCase());    
        console.log(name3.toUpperCase());
        console.log(name4.toUpperCase());
        console.log(name5.toUpperCase());
    }
    let a = ['Kiara','Tiya','Meera','Tom','Tonny','John'];
    printCapitalNames(...a);

}