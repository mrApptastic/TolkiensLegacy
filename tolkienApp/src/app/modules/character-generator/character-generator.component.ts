import { Component, OnInit } from '@angular/core';
import { Character, CharacterInformation, CharacterStatSet } from './models/character';
import { DiceService } from './services/dice.service';
import { jsPDF } from 'jspdf';

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

  download(): void {

    // Default export is a4 paper, portrait, using millimeters for units
    const doc = new jsPDF();

    const name = this.character?.information?.firstName + " " + this.character?.information?.lastName;

    doc.text("Strength " + this.character.stats.strength.value, 10, 10);
    doc.text("Agility " + this.character.stats.agility.value, 10, 30);
    doc.text("Constitution " + this.character.stats.constitution.value, 10, 50);
    doc.text("Intelligence " + this.character.stats.intelligence.value, 10, 70);
    doc.text("Intuition " + this.character.stats.intuition.value, 10, 90);
    doc.text("Presence " + this.character.stats.presence.value, 10, 110);
    doc.text("Appearance " + this.character.stats.appearance.value, 10, 130);
    doc.save(name ? name : "Character" + ".pdf");
  }

}
