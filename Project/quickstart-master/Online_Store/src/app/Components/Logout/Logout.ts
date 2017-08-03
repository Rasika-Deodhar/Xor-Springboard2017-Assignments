import { Component } from '@angular/core';
import { Router,RouterModule } from '@angular/router';
import { AdvertisementService } from '../../Services/AdvertisementService.Services';

@Component({
  selector: 'logout',
  templateUrl: './logout.html',
  styleUrls:['./logout.css']
})
export class Logout  {

//token:any=null;

constructor(private advertisementService: AdvertisementService,private router:Router){
    advertisementService.setLoginToken(null);    
}
}
