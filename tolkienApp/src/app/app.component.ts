import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  races: any;
  title = 'tolkienApp';

  constructor(private http: HttpClient) {

  }

  ngOnInit(): void {
    this.getRaces();
  }

  getRaces(): any {
    return this.http.get("https://localhost:5001/api/open/raceList").subscribe(x => {
      this.races = x;
      console.log(x);
    }, e => {
      console.log(e);
    });
  }
}
