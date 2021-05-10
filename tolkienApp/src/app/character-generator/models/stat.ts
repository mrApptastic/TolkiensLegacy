export class StatSet {
  strength: Stat = { name: "Strength", abbr: "ST", norm: 0 };
  agility: Stat = { name: "Agility", abbr: "AG", norm: 0 };
  constitution: Stat = { name: "Constitution", abbr: "CO", norm: 0 };
  intelligence: Stat = { name: "Intelligence", abbr: "IG", norm: 0 };
  intuition: Stat = { name: "Intuition", abbr: "IT", norm: 0 };
  presence: Stat = { name: "Presence", abbr: "PR", norm: 0 };
  appearance: Stat = { name: "Appearance", abbr: "AP", norm: 0 };
}

export class Stat {
  name: string;
  abbr: string;
  norm: number;

}
