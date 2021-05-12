import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SkillService {

  constructor() { }

  getBaseValue(ranks: number): number {
    switch (ranks) {
      case 0: return -25;
      case 1: return 5;
      case 2: return 10;
      case 3: return 15;
      case 4: return 20;
      case 5: return 25;
      case 6: return 30;
      case 7: return 35;
      case 8: return 35;
      case 9: return 45;
      case 10: return 50;
      case 11: return 52;
      case 12: return 54;
      case 13: return 56;
      case 14: return 58;
      case 15: return 60;
      case 16: return 62;
      case 17: return 64;
      case 18: return 66;
      case 19: return 68;
      case 20: return 70;
      case 21: return 71;
      case 22: return 72;
      case 23: return 73;
      case 24: return 74;
      case 25: return 75;
      case 26: return 76;
      case 27: return 77;
      case 28: return 78;
      case 29: return 79;
      case 30: return 80;
    }
  }
}
