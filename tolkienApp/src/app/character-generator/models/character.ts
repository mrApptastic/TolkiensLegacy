export class Character {

}

export class CharacterStat {
  strength = new Stat { name: "Strength"; abbr: "St"; norm: 0 };

}

export class Stat {
  name: string;
  abbr: string;
  norm: number;

}
