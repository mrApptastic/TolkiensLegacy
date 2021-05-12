import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DiceService {

  rollDie(sides: number): number {
    return Math.ceil(Math.random() * sides);
  }

  rollDice(numberOfDice: number, sides: number): number {
    let result = 0;

    for (let i = 0; i < numberOfDice; i++) {
      result += this.rollDie(sides);
    }

    return result;
  }

  constructor() { }
}
