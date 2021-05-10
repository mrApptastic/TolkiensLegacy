import { Pipe, PipeTransform } from '@angular/core';
import { StatService } from '../services/stat.service';

@Pipe({
  name: 'powerPoint'
})
export class PowerPointPipe implements PipeTransform {

  constructor (private statService: StatService) {}

  transform(stat: number): number {
    return this.statService.getPowerPoints(stat);
  }

}
