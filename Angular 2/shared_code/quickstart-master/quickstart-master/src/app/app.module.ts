import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AdvertisementFormComponent } from './Component/Advertisement/AdvertisementFormComponent';
import { AdvertisementTableComponent } from './Component/Advertisement/AdvertisementTableComponent';
import { AppComponent }  from './app.component';
import { SearchPipe} from './Pipe/Search.pipe';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {FormComponent} from './Component/Template-Driven-Form/FormComponent';
import {ModelDrivenForm} from './Component/Model-Driven-Form/MDFFormComponent';
import {ProductFormBuilderComponent} from './Component/Form-Builder/FormBuilderComponent';
import { RouterModule } from '@angular/router'; 
import {HomeComponent} from './Component/Advertisement/HomeComponent';
import {EditProductComponent} from './Component/Advertisement/EditProductComponent';

@NgModule({
  imports:      [ BrowserModule , FormsModule,ReactiveFormsModule ,RouterModule.forRoot([ {path: '', component: HomeComponent}, {path: 'edit/:name', component: EditProductComponent} ])],
  declarations: [ AppComponent , AdvertisementFormComponent,AdvertisementTableComponent,SearchPipe,FormComponent,ModelDrivenForm,ProductFormBuilderComponent,HomeComponent,EditProductComponent],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }