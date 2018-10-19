import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
// best import { Camera, CameraOptions } from '@ionic-native/camera';
// import { Camera, CameraOptions } from '@ionic-native';

@Component({
  selector: 'page-about',
  templateUrl: 'about.html'
})
export class AboutPage {
  public imgSrc: any;
  // public ModelProof: any;

  // constructor(public navCtrl: NavController, public camera: Camera) {
  constructor(public navCtrl: NavController) {
  }
  TakePicture() {
    console.log("logging is working");
    // this.ModelProof = "ha ha";

/*     let options: CameraOptions = {
      quality: 100,
      destinationType: this.camera.DestinationType.FILE_URI,
      sourceType: this.camera.PictureSourceType.CAMERA,
      encodingType: this.camera.EncodingType.PNG,
      targetHeight: 500,
      targetWidth: 500,
      saveToPhotoAlbum: false
    }

    this.camera.getPicture(options).then((imageData) => {
        // imageData is either a base64 encoded string or a file URI
        // If it's base64 (DATA_URL):
        this.imgSrc = imageData;
      }, (err) => {
        console.log(err);
     }); */

  }
}
