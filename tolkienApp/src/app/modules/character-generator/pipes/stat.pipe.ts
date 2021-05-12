import { Pipe, PipeTransform } from '@angular/core';
import { StatService } from '../services/stat.service';

@Pipe({
  name: 'stat'
})
export class StatPipe implements PipeTransform {
  constructor (private statService: StatService) {}

  transform(stat: number): number {
    return this.statService.getStatBonus(stat);
  }

}
