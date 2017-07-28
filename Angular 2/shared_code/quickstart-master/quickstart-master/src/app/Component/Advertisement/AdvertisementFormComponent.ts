import { Component,EventEmitter } from '@angular/core';

@Component({ 
    selector: 'Advertisement-Form',
    templateUrl: './form.html',
    outputs: ['childEvent']
})  

export class AdvertisementFormComponent { 
    defaultName:string='Rasika';

    childEvent = new EventEmitter<any>();
     //onChange(value: string) { this.childEvent.emit(value);  }}
     //Arr:Array<any> = [];
     
AddAd(Title:any,Name:any,Category:any,Description:any)
{
    let advObj = {Title:Title,Name:Name,Category:Category,Description:Description};
    
     this.childEvent.emit(advObj);
    
}

}