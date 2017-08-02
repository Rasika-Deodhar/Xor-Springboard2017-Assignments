import { Component } from '@angular/core';
import { Router,RouterModule } from '@angular/router';
import { AdvertisementService } from "../../Services/AdvertisementService.Services";

@Component({
  selector: 'register',
  templateUrl: `./register.html`,
  styleUrls:['./register.css']
})

export class Register  { 

    constructor(private advertisementservice:AdvertisementService){
    }
    
    onSubmit(FirstName:any,LastName:any,UserName:any,Password:any,Email:any,Phone:any){

        let newUser = {firstName:FirstName,lastName:LastName,userName:UserName,password:Password,email:Email,phone:Phone};
        console.log("New user=",newUser);
        this.advertisementservice.Register(newUser).subscribe((response)=>
        {
            var token = response.data['auth-token'];
            console.log("New user inserted=",newUser,"Token = ",token);
        });
    }
 }
