import { Component, EventEmitter} from '@angular/core';
import { ProductService } from '../../Services/AdvertisementService.Services';

@Component({ 
    selector: 'Advertisement-Table', // HTML Tag 
    templateUrl: './table.html', //template:I am Advertisement form!
    inputs: ['TableData'],
    outputs:['ArrIndex']
})  

export class AdvertisementTableComponent { 
    
    TableData :Array<any> = [];
    ArrIndex = new EventEmitter<any>();
    TableVal:boolean=true;
    TableFind:boolean=true;
    //AdArr:Array<object>=[];

    constructor(private productService: ProductService) { 
    //Declaring service dependency 
    //console.log("Products = ", productService.getAdvertise()); 
    this.TableData = productService.getAllAdvertises();
  }

    deleteAdvertise(adv:any){
//console.log("Adv = ",adv);
    // let i=this.AdArr.length;
    // console.log("Adv = ",adv);
    //     while(i--)
    //     {
    //         if(this.AdArr[i]===adv){
    //             console.log("Array Trace = ",this.AdArr[i]);
    //             this.AdArr = this.AdArr.splice(i,1);
    //         }
    //     }

        //this.ArrIndex.emit(adv);
        this.productService.deleteAdvertise(adv);
         }

// callPipe(searchText:any){

// }
}