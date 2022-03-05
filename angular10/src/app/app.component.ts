import { Component } from '@angular/core';
import {SharedService} from './shared.service'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular10';
  data: any;
  constructor(private usrservice:SharedService){
    this.usrservice.getUsersList().subscribe(data=>{
      console.warn(data);
      this.data = data
    })
  }
}
