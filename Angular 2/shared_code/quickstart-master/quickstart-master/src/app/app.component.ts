import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<Advertisement-Form (childEvent)="toRetriveValue($event)" #parentData></Advertisement-Form>
             <Advertisement-Table [TableData]="AdArr" (ArrIndex)="DeleteAd($event)"></Advertisement-Table>`,
})
export class AppComponent  { 
  
  AdArr:Array<any> = [];
  
  toRetriveValue(temp:any){
    this.AdArr.push(temp);

    console.log(this.AdArr);
  }

  DeleteAd(adv:object){
    let i=this.AdArr.length;
    console.log("Adv 1= ",adv);
        while(i--)
        {
            if(this.AdArr[i]===adv){
                console.log("Array Trace = ",this.AdArr[i]);
                this.AdArr.splice(i,1);
            }
        }
  }

}
