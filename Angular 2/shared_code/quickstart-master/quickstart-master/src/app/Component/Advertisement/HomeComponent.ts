import { Component} from '@angular/core';
import { ProductService } from '../../Services/AdvertisementService.Services';

@Component({ 
    selector: 'Home', 
    template: `<Advertisement-Form></Advertisement-Form> <br> <Advertisement-Table></Advertisement-Table>`,
})  

export class HomeComponent {

}