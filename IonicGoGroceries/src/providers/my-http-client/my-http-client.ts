import { HttpClient } from '@angular/common/http';
// import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { resolveDefinition } from '@angular/core/src/view/util';
// import 'rxjs/add/observable/of';
// import 'rxjs/add/operator/map';
/*
  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class MyHttpClientProvider {
    private baseUrl = "http://www.GoGroceries.biz/WebServices/gg.svc/HomeGroceryJson?UserId=1&StoreId=19";
    private GroceryObject = {};
    private GroceryArray = [];

  constructor(public http: HttpClient) {
    // console.log('Hello MyHttpClientProvider Provider');
  }
  GetGroceries() {    
    // pds: pretty sure this returns json by default
    return new Promise(resolve => {
      this.http.get(this.baseUrl).subscribe(data => {
        resolve(data);
      }, err => {
        console.log(err);
      });
    });



    // return new Promise(resolve => {
    //   this.http.get(this.baseUrl).subscribe(res => resolve());
    // });

  }
  
  GetGroceriesString() {
    
    return new Promise(resolve => {
      this.http.get(this.baseUrl).subscribe(res => resolve(res.toString()));
    });
  }

}
