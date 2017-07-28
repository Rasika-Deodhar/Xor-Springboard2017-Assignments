import { Component, EventEmitter} from '@angular/core';

@Component({ 
    selector: 'Advertisement-Table', // HTML Tag 
    templateUrl: './table.html', //template:I am Advertisement form!
    inputs: ['TableData'],
    outputs:['ArrIndex']
})  

export class AdvertisementTableComponent { 
    
    TableData :Array<any> = [];
    ArrIndex = new EventEmitter<any>();
    //AdArr:Array<object>=[];

    DeleteAd(adv:object){
console.log("Adv = ",adv);
    // let i=this.AdArr.length;
    // console.log("Adv = ",adv);
    //     while(i--)
    //     {
    //         if(this.AdArr[i]===adv){
    //             console.log("Array Trace = ",this.AdArr[i]);
    //             this.AdArr = this.AdArr.splice(i,1);
    //         }
    //     }

        this.ArrIndex.emit(adv);
         }
}