import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StatService {

  constructor() { }

  getStatBonus(stat: number): number {
    if (stat < 2) {
      return -25;
    } else if (stat < 3) {
      return -20;
    } else if (stat < 5) {
      return -15;
    } else if (stat < 10) {
      return -10;
    } else if (stat < 25) {
      return -5;
    } else if (stat < 75) {
      return 0;
    } else if (stat < 90) {
      return 5;
    } else if (stat < 95) {
      return 10;
    } else if (stat < 98) {
      return 15;
    } else if (stat < 100) {
      return 20;
    }else if (stat === 100) {
      return 25;
    } else if (stat === 101) {
      return 30;
    } else {
      return 35;
    }
  }

  getPowerPoints(stat: number): number {
    if (stat < 75) {
      return 0;
    } else if (stat < 90) {
      return 1;
    } else if (stat < 98) {
      return 2;
    }else if (stat === 100) {
      return 3;
    } else if (stat === 101) {
      return 3;
    } else {
      return 4;
    }
  }
}
