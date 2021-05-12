import { ResistanceRollSet, StatSet } from "./stat";

export class Race {
  name: string;
  stats: RaceStatModificationSet;
  resistanceModifications: RaceRRModificationSet;
  backgroundOptions: number;
}

export class RaceStatModificationSet extends StatSet {}

export class RaceRRModificationSet extends ResistanceRollSet {}



