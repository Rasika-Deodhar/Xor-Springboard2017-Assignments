import { Injectable } from '@angular/core';
import { Http, Response,RequestOptions,Headers } from '@angular/http';
import 'rxjs/add/operator/map';
 
//export class ProductService {  }

@Injectable() 
export class AdvertisementService { 

    constructor(private _http: Http) { 

    }
    token:any;

    Login(formData:any){
        let url="http://192.168.3.144:9000/login";
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });

        return this._http.post(url,JSON.stringify(formData),options).map((response:Response)=>response.json());
    }

    Register(formData:any){
        let url="http://192.168.3.144:9000/register";
        let headers = new Headers({});
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });

        console.log("Registered User = ",formData);
        console.log("stringify", JSON.stringify(formData));

        return this._http.post(url,JSON.stringify(formData),options).map((response:Response)=>response.json());
    }

    setLoginToken(Token:any){
        this.token=Token;
    }

    getLoginToken(){
        return this.token;
    }

    getCategories(){
        let url="http://192.168.3.144:9000/categories";
        let headers = new Headers({});
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });

        return this._http.get(url).map((response:Response)=>response.json());

    }

}