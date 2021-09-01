import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from './modules/character-generator/services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  races: any;
  title = 'tolkienApp';

  constructor(private data: DataService) {

  }

  ngOnInit(): void {
    this.getRaces();
  }

  getRaces(): void {
    this.data.getRaces().subscribe(x => {
      this.races = x?.body;
      console.log(x?.body);
      console.log(x.headers.get('X-Count'));
    }, e => {
      console.log(e);
    });
  }
}



