import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  getRaces(): Observable<any> {
    return this.http.get("https://localhost:5001/api/open/raceList", {observe: 'response'});
  }
}
