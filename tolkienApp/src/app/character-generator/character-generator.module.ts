import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CharacterGeneratorComponent } from './character-generator.component';

@NgModule({
  declarations: [
    CharacterGeneratorComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    CharacterGeneratorComponent
  ]
})
export class CharacterGeneratorModule { }
