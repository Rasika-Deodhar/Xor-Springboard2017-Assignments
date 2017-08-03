import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AdvertisementService } from '../../Services/AdvertisementService.Services';

@Component({
  selector: 'post',
  templateUrl: `./post.html`,
  styleUrls:['./post.css']
})
export class Post  { 
    categories:Array<any>=[];

    constructor(private advertisementService:AdvertisementService,private router:Router)
    {
      advertisementService.getCategories().subscribe((res:any)=>{
          res.data.itemList.forEach((element:any) => 
          {
            this.categories.push(element.name);
          });
          console.log("Categories in form = ",this.categories);
      });
      // this.advertisementService.getCategories().subscribe((res:any)=>{
      // console.log(res.data.itemList.name);
      // });
      console.log("Categories in form = ",this.categories);
    }

    onSubmit(Title:any,Name:any,Category:any,Description:any){
      var postAdv = {title:Title,name:Name,category:Category,description:Description};
      this.advertisementService.postAd(postAdv).subscribe((response)=>
        {
                alert("New Advertise posted!!");
                console.log("New Ad Registered = ",postAdv);
        });
    }
    
}
