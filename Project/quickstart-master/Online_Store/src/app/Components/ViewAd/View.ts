import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AdvertisementService } from '../../Services/AdvertisementService.Services';

@Component({
  selector: 'view',
  templateUrl: `./view.html`,
  styleUrls:['./view.css']
})
export class View  { 
    advertisements:Array<any>=[];
    token:any=this.advertisementService.getLoginToken();

    constructor(private advertisementService:AdvertisementService){
      advertisementService.viewAds().subscribe((response:any)=>{
          response.data.mypostList.forEach((element:any)=> 
          {
            this.advertisements.push({"title":element.title,"description":element.description,"category":element.category});
            //console.log("Ads=",element);
          });
          console.log("Advertisements  = ",this.advertisements);
      });
    }

    userInfo(){
      
    }
 }
