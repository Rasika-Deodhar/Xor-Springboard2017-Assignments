import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AdvertisementFormComponent } from './Component/Advertisement/AdvertisementFormComponent';

import { AppComponent }  from './app.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent , AdvertisementFormComponent],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
