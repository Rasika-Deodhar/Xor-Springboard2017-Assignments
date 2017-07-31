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

@NgModule({
  imports:      [ BrowserModule , FormsModule,ReactiveFormsModule ],
  declarations: [ AppComponent , AdvertisementFormComponent,AdvertisementTableComponent,SearchPipe,FormComponent,ModelDrivenForm,ProductFormBuilderComponent],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
