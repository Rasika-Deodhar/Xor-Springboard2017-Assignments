import { Injectable } from '@angular/core';

@Injectable() 
export class ProductService { 
    products : Array<any> = [ ];

    addProduct(prod:any){
        this.products.push(prod);
    }

    getAllAdvertises(){
        return this.products;
    }

    deleteAdvertise(prod:any){
        let i=this.products.length;
    //console.log("Adv 1= ",adv);
        while(i--)
        {
            if(this.products[i]===prod){
                console.log("Array Trace = ",this.products[i]);
                this.products.splice(i,1);
            }
        }
    }

    updateAdvertise(){

    }

    getAdvertise(){

    }
}