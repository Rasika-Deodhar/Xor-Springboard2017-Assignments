import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AdvertisementFormComponent } from './Component/Advertisement/AdvertisementFormComponent';
import { AdvertisementTableComponent } from './Component/Advertisement/AdvertisementTableComponent';
import { AppComponent }  from './app.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent , AdvertisementFormComponent,AdvertisementTableComponent],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
