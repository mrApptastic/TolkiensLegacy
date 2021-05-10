import { Stat } from "./stat";

export class Skill {
  ranks: Ranks;
  stat: Stat;
  item: number;
  special: number;
  type: SkillType;
  order: number;
  group: SkillGroup;
}

export class Ranks {
  current: number;
  max: number;
}

export enum SkillType {
  Primary,
  Secondary
}

export class SkillGroup {
  name: string;
  order: number;
}
