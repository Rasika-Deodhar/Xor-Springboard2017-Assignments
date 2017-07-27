// export function Iterators(){

// var arr = [];
// var l=0;

// for (var i = 1; i < 10; ++i) 
//  {
//    for (var j = 0; j < 10; ++j) 
//      {
//         for (var k = 0; k < 10; ++k)
//         {
//           var pow = (Math.pow(i,3) + Math.pow(j,3) + Math.pow(k,3));
//           var plus = (i * 100 + j * 10 +  k);
//           if (pow == plus) 
//            {     
//              //console.log(pow);
//              arr[l] = pow;
//              l++;
//             }
//          }
//        }
//     }

//     console.log(arr);
//     let itr = arr[Symbol.iterator]();
//     console.log(itr.next());
//     console.log(itr.next());
// }

var i,n,temp,rem;
var num1=0;
var num2=1000;
let amstrong = { 
     
    [Symbol.iterator]()
     { 
           return {
               next() {
                        for(i=num1+1; i<num2; i++)
                            {
                                temp = i;
                                n = 0;
                                while(temp != 0)
                                {
                                    rem = temp%10;
                                    n = n + rem*rem*rem;
                                    temp = parseInt(temp/10);
                                }
                                if(i == n)
                                {
    
                                console.log(i);
                                }
                            }
                 } 
                }
             }
}
export function Iterators(){
let itr = amstrong[Symbol.iterator]();
console.log(itr.next()); 
}
