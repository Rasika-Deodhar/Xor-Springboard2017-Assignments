import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import { HttpModule } from '@angular/http'; 
import { RouterModule } from '@angular/router'; 

import { HomePage }  from './Components/HomePage/HomePage';
import { HomeLoginPage }  from './Components/HomeLoginPage/HomeLoginPage';
import { Clothing }  from './Components/Clothing/Clothing';
import { Edit }  from './Components/EditAd/Edit';
import { Furniture }  from './Components/Furniture/Furniture';
import { Login }  from './Components/Login/Login';
import { Mobile }  from './Components/Mobile/Mobile';
import { Post }  from './Components/PostAd/Post';
import { RealEstate }  from './Components/RealEstate/RealEstate';
import { Register }  from './Components/Register/Register';
import { View }  from './Components/ViewAd/View';

@NgModule({
  imports:      [ BrowserModule , RouterModule.forRoot([{path: '', component: HomePage},{path: 'login', component: Login}]) ],
  declarations: [ AppComponent ,HomePage,HomeLoginPage,Clothing,Edit,Furniture,Login,Mobile,Post,RealEstate,Register,View],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
//RouterModule.forRoot([ {path: 'first', component: FirstComponent}, {path: 'second', component: SecondComponent} ])
//HomePage,HomeLoginPage,Clothing,Edit,Furniture,Login,Mobile,Post,RealEstate,Register,View