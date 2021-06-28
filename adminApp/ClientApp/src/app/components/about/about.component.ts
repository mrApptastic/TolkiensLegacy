import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.scss']
})
export class AboutComponent implements OnInit {
  races: any;
  loadingData = false;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getAll();
  }

  getAll(): any {
    this.loadingData = true;
    return this.http.get("https://localhost:5001/api/race").subscribe(x => {
      this.races = x;
      this.loadingData = false;
    }, e => {
      console.log(e);
      this.loadingData = false;
    });
  }

  saveData(obj: any): any {
    this.http.put("https://localhost:5001/api/race", obj).subscribe(x => {
      console.log(x);
    }, e => {
      console.log(e);
    });
  }

  addData(): any {
    this.http.get("https://localhost:5001/api/race/new").subscribe(obj => {
      this.http.post("https://localhost:5001/api/race", obj).subscribe(x => {
        this.races.push(x);
      }, e => {
        console.log(e);
      });
    }, e => {
      console.log(e);
    });
  }

  removeData(id: string): any {
    const ok = confirm("Are you sure?")

    if (ok) {
      this.http.delete("https://localhost:5001/api/race/" + id).subscribe(x => {
        console.log(x);
        const index = this.races.findIndex(i => i.eId === id);
        console.log(index);

        if (index) {
          this.races.splice(index, 1);
        }
      }, e => {
        console.log(e);
      });
    }
  }

}
