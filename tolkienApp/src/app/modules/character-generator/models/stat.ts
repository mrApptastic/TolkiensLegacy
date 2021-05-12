export class StatSet {
  strength: Stat = { name: "Strength", abbr: "ST", value: 0 };
  agility: Stat = { name: "Agility", abbr: "AG", value: 0 };
  constitution: Stat = { name: "Constitution", abbr: "CO", value: 0 };
  intelligence: Stat = { name: "Intelligence", abbr: "IG", value: 0 };
  intuition: Stat = { name: "Intuition", abbr: "IT", value: 0 };
  presence: Stat = { name: "Presence", abbr: "PR", value: 0 };
  appearance: Stat = { name: "Appearance", abbr: "AP", value: 0 };
}

export class ResistanceRollSet {
  essence: Stat = { name: "Essence", abbr: "ESS", value: 0 };
  channeling: Stat = { name: "Channeling", abbr: "CHN", value: 0 };
  poison: Stat = { name: "Poison", abbr: "POS", value: 0 };
  disease: Stat = { name: "Disease", abbr: "DIS", value: 0 };
}

export class Stat {
  name: string;
  abbr: string;
  value: number;

}
