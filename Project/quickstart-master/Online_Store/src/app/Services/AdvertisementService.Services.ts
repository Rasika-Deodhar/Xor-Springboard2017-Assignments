import { Injectable } from '@angular/core';
import { Http, Response,RequestOptions,Headers } from '@angular/http';
import 'rxjs/add/operator/map';
 
//export class ProductService {  }

@Injectable() 
export class AdvertisementService { 

name:any;
email:any;
phone:any;
user:any;
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
        console.log("set login token = ",this.token);
    }

    getLoginToken(){
        console.log("get login token = ",this.token);
        return this.token;
    }

    getCategories(){
        let url="http://192.168.3.144:9000/categories";
        let headers = new Headers({});
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });

        return this._http.get(url).map((response:Response)=>response.json());

    }

    setName(name:any){
        this.name=name;
    }
    getName(){
        return this.name;
    }

    logout(){
        let url = "http://192.168.3.144:9000/logout";
        let headers = new Headers();
        headers.append('auth-token',this.token);
        let options=new RequestOptions({headers:headers});
        return this._http.delete(url,options).map((response:Response)=>response.json());
    }

    getActions(){
        let url="http://192.168.3.144:9000/actions";
        let headers = new Headers();
        headers.append('auth-token', this.token);
        let options = new RequestOptions({ headers: headers });

        return this._http.get(url,options).map((response:Response)=>response.json());
    }

    postAd(formData:any){
        let url = "http://192.168.3.144:9000/postAd";
        let headers2 = new Headers();
        headers2.append('Content-Type', 'application/json');
        headers2.append('auth-token', this.token);
        let options = new RequestOptions({ headers: headers2 }); 

        console.log("Registered User = ",formData);
        console.log("Token post ad= ",this.token);
        console.log("stringify", JSON.stringify(formData));

        return this._http.post(url,JSON.stringify(formData),options).map((response:Response)=>response.json());
    }

    viewAds(){
        let url = "http://192.168.3.144:9000/posts";
        let headers2 = new Headers();
        headers2.append('Content-Type', 'application/json');
        headers2.append('auth-token', this.token);
        let options = new RequestOptions({ headers: headers2 }); 

        console.log("Token = ",this.token);
        //console.log("stringify", JSON.stringify();

        return this._http.get(url,options).map((response:Response)=>response.json());
    }

    setUserInfo(name:any){
        this.name=name;
        //this.email=email;
        //this.phone=phone;
        //this.user = {name:name,email:email,phone:phone};
    }
    getUserInfo(){
        return this.name;
    }
    getUserDetails(name:any){
        let url = "http://192.168.3.144:9000/user";
        let headers2 = new Headers();
        headers2.append('Content-Type', 'application/json');
        headers2.append('auth-token', this.token);
        let options = new RequestOptions({ headers: headers2 }); 

        console.log("Token = ",this.token);
        //console.log("stringify", JSON.stringify();

        return this._http.get(url + "?userId=" + name,options).map((response:Response)=>response.json());
    }
}