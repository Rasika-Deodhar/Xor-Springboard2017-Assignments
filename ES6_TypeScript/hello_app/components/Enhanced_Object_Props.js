export function Enhanced_Obj_Props(){

    var Order = { 
        id : 101, title : "Phone", price : 14000,
        printOrder(price){
            console.log("Object is = ",Order);
        },
        getPrice(){
            return this.price;
        }
    }

    var Order1={ };
    var OrderCopy = Object.assign(Order1,Order);

    console.log("Order-");
    console.log(Order.printOrder());
    console.log("Price = ",Order.getPrice());

    console.log("Order1-");
    console.log(OrderCopy.printOrder());
    console.log("Price = ",OrderCopy.getPrice());
}