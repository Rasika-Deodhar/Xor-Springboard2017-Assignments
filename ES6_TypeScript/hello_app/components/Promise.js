export function testPromise(){

 var sum = 0;

    let x = new Promise(function(resolve,reject){
        resolve(10);
    });

    let y = new Promise(function(resolve,reject){
        resolve(20);
    });

   
    Promise.all([x,y]).then(function(promises){
        promises.forEach(function(add){
            sum+=add;
            console.log(add);
        });
        console.log("Addition = ",sum);
    });
    
}