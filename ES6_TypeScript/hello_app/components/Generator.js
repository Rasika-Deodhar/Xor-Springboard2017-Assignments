// var i,n,temp,rem;
// var num1=0;
// var num2=1000;
function* Generator(){
    //let num = 0;
   var i,n,temp,rem;
   var num1=0;
   var num2=1000;


    if(num1<1000)
    {
        //  let reset = yield n;
        //  if(reset)
        //  {
        //      num1=0;
        //  }
        //else
        //{
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
                                var reset = yield i;
                                //console.log(i);
                            }
                            if(reset)
                            {
                                i=0;
                            }
                            }
        //}
    }
    else{
        yield
        {
            "Number greator than 1000"
        };
    }
}

export function testGenerator(){
    let armstrong = Generator();
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next(true).value);
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next().value);
    console.log("Value is = ", armstrong.next().value);
}