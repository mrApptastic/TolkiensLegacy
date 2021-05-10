import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CharacterGeneratorComponent } from './character-generator.component';
import { StatPipe } from './pipes/stat.pipe';
import { PowerPointPipe } from './pipes/power-point.pipe';

@NgModule({
  declarations: [
    CharacterGeneratorComponent,
    StatPipe,
    PowerPointPipe
  ],
  imports: [
    CommonModule
  ],
  exports: [
    CharacterGeneratorComponent
  ]
})
export class CharacterGeneratorModule { }
