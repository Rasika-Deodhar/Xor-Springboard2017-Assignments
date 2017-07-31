import { Component,EventEmitter } from '@angular/core';
import { ProductService } from '../../Services/AdvertisementService.Services';

@Component({ 
    selector: 'Advertisement-Form',
    templateUrl: './form.html',
    outputs: ['childEvent']
})  

export class AdvertisementFormComponent { 
    defaultName:string='Rasika';

    childEvent = new EventEmitter<any>();

constructor(private productService: ProductService) { //Declaring service dependency 
    //console.log("Products = ", productService.addProduct()); 
  }

     //onChange(value: string) { this.childEvent.emit(value);  }}
     //Arr:Array<any> = [];
     
AddAd(Title:any,Name:any,Category:any,Description:any)
{
    let advObj = {Title:Title,Name:Name,Category:Category,Description:Description};
    
     //this.childEvent.emit(advObj);
    this.productService.addProduct(advObj);
}

}