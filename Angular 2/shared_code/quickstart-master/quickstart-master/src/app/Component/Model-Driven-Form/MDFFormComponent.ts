import { Component} from '@angular/core';
import {FormGroup,FormControl,Validators} from '@angular/forms'

@Component({ 
    selector: 'mdf', 
    templateUrl: `./formMDF.html`
    
}) 

export class ModelDrivenForm
{
    productForm = new FormGroup({ 
        name: new FormControl(null, [Validators.required, Validators.minLength(3), 
Validators.maxLength(8)]),
 
        quantity: new FormControl(50), 
        price: new FormControl() });

    onSubmit() { console.log(this.productForm.value); } 
}