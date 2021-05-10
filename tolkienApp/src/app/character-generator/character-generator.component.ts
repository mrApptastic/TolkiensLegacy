import { Component, OnInit } from '@angular/core';
import { Character, CharacterInformation, CharacterStatSet } from './models/character';
import { DiceService } from './services/dice.service';

@Component({
  selector: 'app-character-generator',
  templateUrl: './character-generator.component.html',
  styleUrls: ['./character-generator.component.scss']
})
export class CharacterGeneratorComponent implements OnInit {
  character: Character;

  constructor(public dice: DiceService) { }

  ngOnInit(): void {
    this.generate();
  }

  generate(): void {
    this.character = new Character();
    this.character.information = new CharacterInformation();
    this.character.stats = new CharacterStatSet();
    this.character.stats.strength.value = this.rollStat();
    this.character.stats.agility.value = this.rollStat();
    this.character.stats.constitution.value = this.rollStat();
    this.character.stats.intelligence.value = this.rollStat();
    this.character.stats.intuition.value = this.rollStat();
    this.character.stats.presence.value = this.rollStat();
    this.character.stats.appearance.value = this.rollStat();
  }

  rollStat(): number {
    let value = 0;
    while (value < 20) {
      value = this.dice.rollDie(100);
    }

    return value;
  }

}
