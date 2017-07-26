export function DeStruct_Assign(){

    let [a,,b,] = [1,2,3,4];

    console.log("3rd = ",b);

    var org = {
        name : 'Ram',
        address : {
            location:'Pune',
            zip : 1234
        }
    }

    let {address: {location, zip}} = org; 
    console.log("Location:", location, "Zip:", zip); 
}