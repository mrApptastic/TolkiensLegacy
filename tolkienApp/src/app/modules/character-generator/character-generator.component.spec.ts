import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterGeneratorComponent } from './character-generator.component';
import { StatPipe } from './pipes/stat.pipe';
import { PowerPointPipe } from './pipes/power-point.pipe';
import { LevelPipe } from './pipes/level.pipe';

describe('CharacterGeneratorComponent', () => {
  let component: CharacterGeneratorComponent;
  let fixture: ComponentFixture<CharacterGeneratorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CharacterGeneratorComponent, StatPipe, PowerPointPipe, LevelPipe ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CharacterGeneratorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
