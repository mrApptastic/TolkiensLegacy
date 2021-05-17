using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using admin_app.Models;
using admin_app.Data;
using System;

namespace admin_app {

    public class SeedData {

        public static void SeedDatabase(ApplicationDbContext context) {
            if (context.Database.GetMigrations().Count() > 0
                    && context.Database.GetPendingMigrations().Count() == 0
                    && context.MerpRaces.Count() == 0
                    && context.MerpStats.Count() == 0) {
                #region Deities
                if (context.MerpDeities.Count() == 0) {
                    context.MerpDeities.AddRange(
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Manwë",
                            Description = "King of the Valar. Wind lord. Master of the Air and Weather."
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Varda",
                            Description = "Queen of the Valar. Lady of the Stars. Spirit of Light. Also called Elbereth or Elentári."
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Ulmo",
                            Description = "Ocean Lord. Master of the Waters."
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Aulë",
                            Description = "The Smith. Master of the Earth. Lord of Craft. Maker of Mountains. Maker of Dwarves. Also called Mahal."
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Yavanna",
                            Description = "Nourisher. Mistress of the Earth. Giver of fruits. Keeperr of Plants. Also called Kementári"
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Námo",
                            Description = ""
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Nienna",
                            Description = ""
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Orome",
                            Description = ""
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Morgoth",
                            Description = ""
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Vána",
                            Description = ""
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Lessa",
                            Description = ""
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Irmo",
                            Description = ""
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Lórien",
                            Description = ""
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Estë",
                            Description = "Healer"
                        },
                        new Deity() {
                            Enabled = true,
                            EnabledInWeb = true,
                            EId = Guid.NewGuid(),
                            Name = "Vairë",
                            Description = "Weaver of Fate, wife of Mandos"
                        }
                    );
                }
                #endregion
                #region Languages  
                var Adunaic = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Adûnaic"
                };

                var Apysaic = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Apysaic"
                };

                var Atliduk = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Atliduk"
                };

                var Kuduk = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Kuduk"
                };

                var Khuzdul = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Khuzdul"
                };

                var Labba = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Labba"
                };

                var Morbeth = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Morbeth"
                };

                var Umitic = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Umitic"
                };

                var Westron = new Language() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Westron"
                };


                    // var strength = new BaseStat {
                    //     Name = "Strength"
                    // };
                    // var agility = new BaseStat {
                    //     Name = "Agility"
                    // };
                    // var constitution = new BaseStat {
                    //     Name = "Constitution"
                    // };
                    // var intuition = new BaseStat {
                    //     Name = "Intuition"
                    // };
                    // var intelligence = new BaseStat {
                    //     Name = "Intelligence"
                    // };
                    // var presence = new BaseStat {
                    //     Name = "Presence"
                    // };
                    // var appearance = new BaseStat {
                    //     Name = "Appearance"
                    // };
                    #endregion
                #region Stats
                var Strength = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Strength",
                    Abbr = "ST"
                };
                var Agility = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Agility",
                    Abbr = "AG"
                };
                var Constitution = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Constitution",
                    Abbr = "CO"
                };
                var Intellligence = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Intellligence",
                    Abbr = "IG"
                };
                var Intuition = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Intuition",
                    Abbr = "IN"
                };
                var Presence = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Presence",
                    Abbr = "PR"
                };
                var Appearance = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Appearance",
                    Abbr = "AP"
                };
                var Essence = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Essence",
                    Abbr = "ESS"
                };
                var Channeling = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Channeling",
                    Abbr = "CHN"
                };
                var Poison = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Poison",
                    Abbr = "POS"
                };
                var Disease = new BaseStat() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Disease",
                    Abbr = "DIS"
                };
                #endregion
                #region Skills
                    #region MovementSkills
                var MovementSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Movement and maneuver",
                    SortOrder = 0
                };
                var NoArmor = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "No armor",
                    Category = MovementSkills,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 2,
                    SortOrder = 0
                };
                var SoftLeather = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Soft leather",
                    Category = MovementSkills,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 3,
                    SortOrder = 5
                };
                var RigidLeather = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "RigidLeather",
                    Category = MovementSkills,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 5,
                    SortOrder = 10
                };
                var Chain = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Chain",
                    Category = MovementSkills,
                    Stat = new SkillStat() {
                        Stat = Strength
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 7,
                    SortOrder = 15
                };
                var Plate = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Plate",
                    Category = MovementSkills,
                    Stat = new SkillStat() {
                        Stat = Strength
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 9,
                    SortOrder = 20
                };
                    #endregion
                    #region WeaponSkills
                var WeaponSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Weapon skills",
                    SortOrder = 5
                };
                var OneHandEdged = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "1-H Edged",
                    Category = WeaponSkills,
                    Stat = new SkillStat() {
                        Stat = Strength
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 0
                };
                var OneHandConcussion = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "1-H Concusssion",
                    Category = WeaponSkills,
                    Stat = new SkillStat() {
                        Stat = Strength
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 5
                };
                var TwoHanded = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "2-Handed",
                    Category = WeaponSkills,
                    Stat = new SkillStat() {
                        Stat = Strength
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 10
                };
                var Thrown = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Thrown",
                    Category = WeaponSkills,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 15
                };
                var Missile = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Missile",
                    Category = WeaponSkills,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 20
                };
                var PoleArms = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Pole-arms",
                    Category = WeaponSkills,
                    Stat = new SkillStat() {
                        Stat = Strength
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 25
                };
                    #endregion
                    #region GeneralSkills
                var GeneralSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "General skills",
                    SortOrder = 10
                };
                var Climb = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Climb",
                    Category = GeneralSkills,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 0
                };
                var Ride = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Ride",
                    Category = GeneralSkills,
                    Stat = new SkillStat() {
                        Stat = Intuition
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 5
                };
                var Swim = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Swim",
                    Category = GeneralSkills,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 10
                };
                var Track = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "1-H Edged",
                    Category = GeneralSkills,
                    Stat = new SkillStat() {
                        Stat = Intellligence
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 15
                };
                    #endregion
                    #region SubterfugeSkills
                var SubterfugeSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Subterfuge skills",
                    SortOrder = 15
                };
                var Ambush = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Ambush",
                    Category = SubterfugeSkills,
                    ExcludeLevelBonus = true,
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 0
                };
                 var StalkHide = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Stalk/Hide",
                    Category = SubterfugeSkills,
                    Stat = new SkillStat() {
                        Stat = Presence
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 5
                };
                var PickLock = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Pick lock",
                    Category = SubterfugeSkills,
                    Stat = new SkillStat() {
                        Stat = Intellligence
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 10
                };
                var DisarmTrap = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Disarm trap",
                    Category = SubterfugeSkills,
                    Stat = new SkillStat() {
                        Stat = Intuition
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 15
                };
                    #endregion
                    #region MagicalSkills
                var MagicalSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Magical skills",
                    SortOrder = 20
                };
                var ReadRunes = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Read runes",
                    Category = MagicalSkills,
                    Stat = new SkillStat() {
                        Stat = Intellligence
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 0
                };
                var UseItems = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Use items",
                    Category = MagicalSkills,
                    Stat = new SkillStat() {
                        Stat = Intuition
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 0
                };
                var DirectedSpells = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Directed spells",
                    Category = MagicalSkills,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 0
                };
                    #endregion
                    #region Bonuses
                var Bonuses = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Misc. skills and bonuses",
                    SortOrder = 30
                };
                var Perception = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Perception",
                    Category = Bonuses,
                    Stat = new SkillStat() {
                        Stat = Intuition
                    },
                    RankValue = RankValue.Always5,
                    MaxRanks = 15,
                    SortOrder = 0
                };
                var BodyDevelopment = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Body development",
                    Category = Bonuses,
                    Stat = new SkillStat() {
                        Stat = Constitution
                    },
                    RankValue = RankValue.d10,
                    MaxRanks = 15,
                    SortOrder = 5
                };
                var BaseSpells = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Base spells",
                    Category = Bonuses,
                    RankValue = RankValue.None,
                    MaxRanks = 0,
                    SortOrder = 10
                };
                var Leadership = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Leadership and influence",
                    Category = Bonuses,
                    Stat = new SkillStat() {
                        Stat = Presence
                    },
                    RankValue = RankValue.None,
                    MaxRanks = 0,
                    SortOrder = 15
                };
                var DefensiveBonus = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Defensive bonus",
                    Category = Bonuses,
                    Stat = new SkillStat() {
                        Stat = Agility
                    },
                    RankValue = RankValue.None,
                    MaxRanks = 0,
                    SortOrder = 20
                };
                var EssenceRR = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Essence RR",
                    Category = Bonuses,
                    Stat = new SkillStat() {
                        Stat = Intellligence
                    },
                    RankValue = RankValue.None,
                    MaxRanks = 0,
                    SortOrder = 25
                };
                var ChannelingRR = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Channeling RR",
                    Category = Bonuses,
                    Stat = new SkillStat() {
                        Stat = Intuition
                    },
                    RankValue = RankValue.None,
                    MaxRanks = 0,
                    SortOrder = 30
                };
                 var PoisonRR = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Poison RR",
                    Category = Bonuses,
                    Stat = new SkillStat() {
                        Stat = Constitution
                    },
                    RankValue = RankValue.None,
                    MaxRanks = 0,
                    SortOrder = 35
                };
                var DiseaseRR = new Skill() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Disease RR",
                    Category = Bonuses,
                    Stat = new SkillStat() {
                        Stat = Constitution
                    },
                    RankValue = RankValue.None,
                    MaxRanks = 0,
                    SortOrder = 40
                };
                    #endregion
                var SecondarySkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Secondary Skills",
                    SortOrder = 35
                };
                // var Languages = new SkillCategory() {
                //     Enabled = true,
                //     EnabledInWeb = false,
                //     EId = Guid.NewGuid(),
                //     Name = "Languages",
                //     SortOrder = 40
                // };
                // var SpellLists = new SkillCategory() {
                //     Enabled = true,
                //     EnabledInWeb = false,
                //     EId = Guid.NewGuid(),
                //     Name = "Spell Lists",
                //     SortOrder = 45
                // };
                #endregion
                #region Races      
                    #region Hobbit  
                     
                    context.MerpRaces.AddRange(
                        new Race {
                            EId = Guid.NewGuid(),
                            Enabled = true,
                            EnabledInWeb = true,
                            Name = "Hobbit",
                            Stats = new List<RaceStat>() {
                                new RaceStat() {
                                    Stat = Strength,
                                    Value = -20
                                },
                                new RaceStat() {
                                    Stat = Agility,
                                    Value = 15
                                },
                                new RaceStat() {
                                    Stat = Constitution,
                                    Value = 15
                                },
                                new RaceStat() {
                                    Stat = Intellligence,
                                    Value = 0
                                },
                                new RaceStat() {
                                    Stat = Intuition,
                                    Value = -5
                                },
                                new RaceStat() {
                                    Stat = Presence,
                                    Value = -5
                                },
                                new RaceStat() {
                                    Stat = Appearance,
                                    Value = 0
                                }
                            },
                            RRs = new List<RaceRR>() {
                                new RaceRR() {
                                    Stat = Essence,
                                    Value = 50
                                },
                                new RaceRR() {
                                    Stat = Channeling,
                                    Value = 20
                                },
                                new RaceRR() {
                                    Stat = Poison,
                                    Value = 30
                                },
                                new RaceRR() {
                                    Stat = Disease,
                                    Value = 15
                                }
                            },
                            // Stats = new StatSet() {
                            //     Strength = new BaseStat {
                            //         Abbr = StatAbbr.St,
                            //         Value = -20
                            //     },
                            //     Agility = new BaseStat {
                            //         Abbr = StatAbbr.Ag,
                            //         Value = 15
                            //     },
                            //     Constitution = new BaseStat {
                            //         Abbr = StatAbbr.Co,
                            //         Value = 15
                            //     },
                            //     Intelligence = new BaseStat {
                            //         Abbr = StatAbbr.Ig,
                            //         Value = 0
                            //     },
                            //     Intuition = new BaseStat {
                            //         Abbr = StatAbbr.In,
                            //         Value = -5
                            //     },
                            //     Presence = new BaseStat {
                            //         Abbr = StatAbbr.Pr,
                            //         Value = -5
                            //     },
                            //     Appearance = new BaseStat {
                            //         Abbr = StatAbbr.Ap,
                            //         Value = 0
                            //     }
                            // },
                            // RR = new RRStatSet() {
                            //     Essence = new BaseStat {
                            //         Abbr = StatAbbr.Ess,
                            //         Value = 50
                            //     },
                            //     Channeling = new BaseStat {
                            //         Abbr = StatAbbr.Chn,
                            //         Value = 20
                            //     },
                            //     Poison = new BaseStat {
                            //         Abbr = StatAbbr.Pos,
                            //         Value = 30
                            //     },
                            //     Disease = new BaseStat {
                            //         Abbr = StatAbbr.Dis,
                            //         Value = 15
                            //     },
                            // },
                            Skills = new List<RaceSkill>() {
                                new RaceSkill() {
                                    Ranks = 1,
                                    Bonus = 0,
                                    Skill = NoArmor
                                },
                                new RaceSkill() {
                                    Ranks = 0,
                                    Bonus = 0,
                                    Skill = SoftLeather
                                },
                                new RaceSkill() {
                                    Ranks = 0,
                                    Bonus = 0,
                                    Skill = RigidLeather
                                },
                                new RaceSkill() {
                                    Ranks = 0,
                                    Bonus = 0,
                                    Skill = Chain
                                },
                                new RaceSkill() {
                                    Ranks = 0,
                                    Bonus = 0,
                                    Skill = Plate
                                }
                            },
                            Languages = new List<RaceLanguage>() { 
                                new RaceLanguage() {
                                    Language = Kuduk,
                                    Rank = LanguageRank.Fluent
                                },
                                new RaceLanguage() {
                                    Language = Westron,
                                    Rank = LanguageRank.Fluent
                                }
                            },
                            SpellListChance = 3,
                            ExtraLanguageRanks = 3,
                            BackgroundOptions = 5,
                            Frequency = 30
                            // Stats = new List<BaseStat>() {strength, agility, constitution, intuition, intelligence, presence, appearance}
                        },
                        #endregion
                    #region Umli 
                        new Race {
                            EId = Guid.NewGuid(),
                            Enabled = true,
                            EnabledInWeb = true,
                            Name = "Umli",
                            Stats = new List<RaceStat>() {
                                new RaceStat() {
                                    Stat = Strength,
                                    Value = 5
                                },
                                new RaceStat() {
                                    Stat = Agility,
                                    Value = 0
                                },
                                new RaceStat() {
                                    Stat = Constitution,
                                    Value = 10
                                },
                                new RaceStat() {
                                    Stat = Intellligence,
                                    Value = 0
                                },
                                new RaceStat() {
                                    Stat = Intuition,
                                    Value = -5
                                },
                                new RaceStat() {
                                    Stat = Presence,
                                    Value = -5
                                },
                                new RaceStat() {
                                    Stat = Appearance,
                                    Value = 0
                                }
                            },
                            RRs = new List<RaceRR>() {
                                new RaceRR() {
                                    Stat = Essence,
                                    Value = 20
                                },
                                new RaceRR() {
                                    Stat = Channeling,
                                    Value = 0
                                },
                                new RaceRR() {
                                    Stat = Poison,
                                    Value = 5
                                },
                                new RaceRR() {
                                    Stat = Disease,
                                    Value = 5
                                }
                            },
                            // Stats = new StatSet() {
                            //     Strength = new BaseStat {
                            //         Abbr = StatAbbr.St,
                            //         Value = 5
                            //     },
                            //     Agility = new BaseStat {
                            //         Abbr = StatAbbr.Ag,
                            //         Value = 0
                            //     },
                            //     Constitution = new BaseStat {
                            //         Abbr = StatAbbr.Co,
                            //         Value = 10
                            //     },
                            //     Intelligence = new BaseStat {
                            //         Abbr = StatAbbr.Ig,
                            //         Value = 0
                            //     },
                            //     Intuition = new BaseStat {
                            //         Abbr = StatAbbr.In,
                            //         Value = -5
                            //     },
                            //     Presence = new BaseStat {
                            //         Abbr = StatAbbr.Pr,
                            //         Value = -5
                            //     },
                            //     Appearance = new BaseStat {
                            //         Abbr = StatAbbr.Ap,
                            //         Value = 0
                            //     }
                            // },
                            // RR = new RRStatSet() {
                            //     Essence = new BaseStat {
                            //         Abbr = StatAbbr.Ess,
                            //         Value = 20
                            //     },
                            //     Channeling = new BaseStat {
                            //         Abbr = StatAbbr.Chn,
                            //         Value = 0
                            //     },
                            //     Poison = new BaseStat {
                            //         Abbr = StatAbbr.Pos,
                            //         Value = 5
                            //     },
                            //     Disease = new BaseStat {
                            //         Abbr = StatAbbr.Dis,
                            //         Value = 5
                            //     },
                            // },
                            Skills = new List<RaceSkill>() {
                                new RaceSkill() {
                                    Ranks = 1,
                                    Bonus = 0,
                                    Skill = NoArmor
                                },
                                new RaceSkill() {
                                    Ranks = 3,
                                    Bonus = 0,
                                    Skill = SoftLeather
                                },
                                new RaceSkill() {
                                    Ranks = 3,
                                    Bonus = 0,
                                    Skill = RigidLeather
                                },
                                new RaceSkill() {
                                    Ranks = 0,
                                    Bonus = 0,
                                    Skill = Chain
                                },
                                new RaceSkill() {
                                    Ranks = 0,
                                    Bonus = 0,
                                    Skill = Plate
                                }
                            },
                            Languages = new List<RaceLanguage>() { 
                                new RaceLanguage() {
                                    Language = Khuzdul,
                                    Rank = LanguageRank.Simple
                                },
                                new RaceLanguage() {
                                    Language = Labba,
                                    Rank = LanguageRank.Basic
                                },
                                new RaceLanguage() {
                                    Language = Umitic,
                                    Rank = LanguageRank.Fluent
                                },
                                new RaceLanguage() {
                                    Language = Westron,
                                    Rank = LanguageRank.Basic
                                }
                            },
                            SpellListChance = 5,
                            ExtraLanguageRanks = 3,
                            BackgroundOptions = 4,
                            Frequency = 20
                        }
                        #endregion
                        );                        
                    };                   
                #endregion

                context.SaveChanges();
            }
        }
    }
