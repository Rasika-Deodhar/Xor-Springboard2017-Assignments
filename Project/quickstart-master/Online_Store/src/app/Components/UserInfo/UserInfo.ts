import { Component } from '@angular/core';
import { Router,RouterModule } from '@angular/router';
import { AdvertisementService } from "../../Services/AdvertisementService.Services";

@Component({
  selector: 'userInfo',
  templateUrl: `./userInfo.html`,
  styleUrls:['./userInfo.css']
})

export class UserInfo  { 

//userinfo:any;
userinfo=this.advertisementservice.getUserInfo();
userDetails:any;
    constructor(private advertisementservice:AdvertisementService){
        
        this.advertisementservice.getUserDetails(this.userinfo).subscribe(
            (response:any)=>{
                this.userDetails=response.data.user
            }
        );
        console.log("User Info =",this.userinfo);
    }
    
 }
