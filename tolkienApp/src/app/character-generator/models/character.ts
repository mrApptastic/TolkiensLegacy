import { Stat, StatSet } from "./stat";

export class Character {
  information: CharacterInformation;
  stats: CharacterStatSet;
}

export class CharacterInformation {
  firstName: string;
  lastName: string;
  height: string;
  width: string;
}


export class CharacterStatSet extends StatSet {

}



export class CharacterStat extends Stat {

}



