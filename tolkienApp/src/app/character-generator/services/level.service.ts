import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LevelService {

  constructor() { }

  getLevel(ep: number): number {
    if (ep < 10000) {
      return 0;
    } else if (ep < 10000) {
      return 1;
    } else if (ep < 20000) {
      return 2;
    } else if (ep < 30000) {
      return 3;
    } else if (ep < 40000) {
      return 4;
    } else if (ep < 50000) {
      return 5;
    } else if (ep < 70000) {
      return 6;
    } else if (ep < 90000) {
      return 7;
    } else if (ep < 110000) {
      return 8;
    } else if (ep < 130000) {
      return 9;
    } else if (ep < 150000) {
      return 10;
    }
  }
}
