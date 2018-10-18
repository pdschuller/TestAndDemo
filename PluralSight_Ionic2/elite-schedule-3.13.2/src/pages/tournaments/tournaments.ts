import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, LoadingController } from 'ionic-angular';
import { TeamsPage } from '../teams/teams';
import { EliteApi } from '../../providers/elite-api/elite-api';


@IonicPage()
@Component({
  selector: 'page-tournaments',
  templateUrl: 'tournaments.html',
})
export class TournamentsPage {
  public tournaments: any;

  constructor(
    public loadingController: LoadingController,
    public navCtrl: NavController, 
    public navParams: NavParams, 
    public eliteApi: EliteApi) {
  }

  
  ionViewDidLoad() {
    let loader = this.loadingController.create({
      content: 'Getting tournaments...'
      //spinner: 'dots'
    });

    loader.present().then(() => {
      this.eliteApi.getTournaments().then(data => {
        this.tournaments = data;
        loader.dismiss();
      });
    });
  }

  itemTapped($event, tourney) {
    this.navCtrl.push(TeamsPage, tourney);
  }


 
}
