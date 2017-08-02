import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AdvertisementService } from '../../Services/AdvertisementService.Services';

@Component({
  selector: 'navBar',
  templateUrl: `./navBar.html`,
  styleUrls:['./navBar.css']
})
export class NavBar  { 

  categ:Array<any>=[];
    constructor(private categories:AdvertisementService)
    {
      categories.getCategories().subscribe((res:any)=>{
          res.data.itemList.forEach((element:any) => 
          {
            this.categ.push(element.name);
          });
          console.log(this.categ);
      });
    }

 }
