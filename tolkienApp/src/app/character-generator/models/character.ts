import { Profession } from "./profession";
import { Race } from "./race";
import { Skill } from "./skill";
import { Stat, StatSet } from "./stat";

export class Character {
  information: CharacterInformation;
  stats: CharacterStatSet;
  race: Race;
  proffession: Profession;
  skills: Skill[];
}

export class CharacterInformation {
  firstName: string;
  lastName: string;
  height?: string;
  width?: string;
  dateOfBirth?: Date;

}

export class CharacterStatSet extends StatSet {}

export class CharacterStat extends Stat {}



