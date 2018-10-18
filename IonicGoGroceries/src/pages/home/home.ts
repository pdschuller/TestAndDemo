import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { MyHttpClientProvider } from '../../providers/my-http-client/my-http-client';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  public LongString: any;
  public GroceriesJson: any;

  constructor(
    public navCtrl: NavController,
    public myHttpClientProvider: MyHttpClientProvider
    ) {    
  }  
  ClearGroceryList() {
    this.LongString = "";
  }
  LoadGroceries() {        
    this.myHttpClientProvider.GetGroceries().then(TheResponse => {
      this.GroceriesJson = TheResponse;
    });
  }
  LoadGroceriesString() {        
    this.myHttpClientProvider.GetGroceriesString().then(TheResponse => {
      this.LongString = TheResponse;
    });
  }
  WriteGroceriesJson() {    
    console.log(this.GroceriesJson);
  }

  ionViewDidLoad() {
    console.log("ionViewDidLoad");
    // this.myHttpClientProvider.GetGroceries().then(TheResponse => {
    //   this.LongString = TheResponse;
    // });
    // console.log(ff);
  }
}
