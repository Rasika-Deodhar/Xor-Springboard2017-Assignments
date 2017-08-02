import { Component } from '@angular/core';
import { AdvertisementService } from "../../Services/AdvertisementService.Services";

@Component({
  selector: 'navBarLogin',
  templateUrl: `./navBarLogin.html`,
  styleUrls:['./navBarLogin.css']
})
export class Register  { 

    constructor(private advertisementservice:AdvertisementService){
    }

    token:any;

    ngDoCheck(){
      this.token=this.advertisementservice.getLoginToken();
    }
 }
