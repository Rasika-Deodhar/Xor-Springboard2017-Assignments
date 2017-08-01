import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http'; 
//export class ProductService {  }

@Injectable() 
export class AdvertisementService { 
    
    constructor(private _http: Http) { 

    }

     this._http.get('http://localhost:8000/product');

}