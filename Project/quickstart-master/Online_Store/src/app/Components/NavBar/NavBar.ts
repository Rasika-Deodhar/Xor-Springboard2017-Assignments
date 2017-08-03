import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AdvertisementService } from '../../Services/AdvertisementService.Services';

@Component({
  selector: 'navBar',
  templateUrl: `./navBar.html`,
  styleUrls:['./navBar.css']
})
export class NavBar  { 

token:any;
name:any;

  categories:Array<any>=[];
  action:Array<any>=[];
    constructor(private advertisementService:AdvertisementService,private tokenService:AdvertisementService,private actions:AdvertisementService,private router:Router)
    {
      advertisementService.getCategories().subscribe((res:any)=>{
          res.data.itemList.forEach((element:any) => 
          {
            this.categories.push(element.name);
          });
          console.log(this.categories);
      });

      actions.getActions().subscribe((actions:any)=>{
        actions.data.itemList.forEach((element:any) => {
          this.action.push(element.name);
        });
        console.log(this.action);
      });
    }

    categoryOption(category: string){
      switch(category){
        case 'Cloths' : this.router.navigate(['/clothing']);
        break;
        case 'Furniture' : this.router.navigate(['/furniture']);
        break;
        case 'Mobile' : this.router.navigate(['/mobile']);
        break;
        case 'Real Estate' : this.router.navigate(['/realEstate']);
        break;
      }
      console.log("category", category);
    }

    ngDoCheck(){
      this.token=this.tokenService.getLoginToken();
      this.name=this.tokenService.getName();
      console.log("after get login token = ",this.token);
      console.log("after get login name = ",this.name);
    }

 }
