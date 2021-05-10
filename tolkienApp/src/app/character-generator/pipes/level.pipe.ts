import { Pipe, PipeTransform } from '@angular/core';
import { LevelService } from '../services/level.service';

@Pipe({
  name: 'level'
})
export class LevelPipe implements PipeTransform {
  constructor (private levelService: LevelService) {}

  transform(ep: number): number {
    return this.levelService.getLevel(ep);
  }

}
