import { Pipe, PipeTransform } from '@angular/core';

// export interface PipeTransform { 
//     transform(value: any, ...args: any[]): any; 
// }

@Pipe({name: 'Search'})
export class SearchPipe implements PipeTransform { 
    transform(value: Array<any>,...args:Array<any>): any[] { 
        let searchArray:Array<any> = []; 

        if(args[0]=='' || args[0]==undefined || value==undefined)
        {
            return value;
        }

        value.forEach((advertise) => {
            if(advertise.Name.includes(args[0]) || advertise.Category.includes(args[0]) || advertise.Title.includes(args[0]))
            {
                searchArray.push(advertise);
                console.log(advertise);
            }

        })
        return searchArray;
    } 
} 