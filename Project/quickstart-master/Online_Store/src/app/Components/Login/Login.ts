import { Component } from '@angular/core';
import { Router,RouterModule } from '@angular/router';
import { AdvertisementService } from '../../Services/AdvertisementService.Services';

@Component({
  selector: 'login',
  templateUrl: './login.html',
  styleUrls:['./login.css']
})
export class Login  {

constructor(private advertisementService: AdvertisementService,private router:Router){
    }
  
  onSubmit(UserNameValue:any,PasswordValue:any){
    
    let user={userName:UserNameValue,password:PasswordValue};
    this.advertisementService.Login(user).subscribe((formData)=>
    {
      var token = formData.data['auth-token'];

      if(token==null){
        alert("Invalid Credentials!");
      }
      else{
        this.advertisementService.setLoginToken(token);
        this.router.navigate(['/home_login']);
      }

      console.log("Inside service=",formData,"Auth Token = ",token);
    });
    
  }
}
