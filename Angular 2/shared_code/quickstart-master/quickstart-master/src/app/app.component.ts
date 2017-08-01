import { Component } from '@angular/core';
import { Pipe,PipeTransform} from '@angular/core';
import { ProductService } from './Services/AdvertisementService.Services';

@Component({
  selector: 'my-app',
  /*template: `<Advertisement-Form (childEvent)="toRetriveValue($event)" #parentData></Advertisement-Form>
             <Advertisement-Table [TableData]="AdArr" (ArrIndex)="DeleteAd($event)"></Advertisement-Table>`,*/
  
  //template: `<Home></Home>`,

template: `<nav>
<a routerLink="/HomeComponent" routerLinkActive="active" > Home </a> 
<a routerLink="/EditProductComponent" routerLinkActive="active" > Edit </a>
</nav>
<router-outlet></router-outlet>`,
  providers: [ProductService]
})

export class AppComponent  { 
  
  AdArr:Array<any> = [];
  
  toRetriveValue(temp:any){
    this.AdArr.push(temp);

    console.log(this.AdArr);
  }

  // DeleteAd(adv:any){
  //   let i=this.AdArr.length;
  //   console.log("Adv 1= ",adv);
  //       while(i--)
  //       {
  //           if(this.AdArr[i]===adv){
  //               console.log("Array Trace = ",this.AdArr[i]);
  //               this.AdArr.splice(i,1);
  //           }
  //       }
  // }

  constructor(productService: ProductService) { 
    //Declaring service dependency 
    console.log("Products = ", productService.getAdvertise()); 
  }

}
