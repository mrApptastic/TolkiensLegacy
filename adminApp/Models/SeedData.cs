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
                    Name = "No Armor",
                    Category = MovementSkills,
                    SortOrder = 0
                };
                    #endregion
                var WeaponSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Weapon skills",
                    SortOrder = 5
                };
                var GeneralSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "General skills",
                    SortOrder = 10
                };
                var SubterfugeSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Subterfuge skills",
                    SortOrder = 15
                };
                var MagicalSkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Subterfuge skills",
                    SortOrder = 20
                };
                var BodyDevelopment = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Body development",
                    SortOrder = 25
                };
                var Bonuses = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Misc. skills and bonuses",
                    SortOrder = 30
                };
                var SecondarySkills = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = true,
                    EId = Guid.NewGuid(),
                    Name = "Secondary Skills",
                    SortOrder = 35
                };
                var Languages = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = false,
                    EId = Guid.NewGuid(),
                    Name = "Languages",
                    SortOrder = 40
                };
                var SpellLists = new SkillCategory() {
                    Enabled = true,
                    EnabledInWeb = false,
                    EId = Guid.NewGuid(),
                    Name = "Spell Lists",
                    SortOrder = 45
                };
                #endregion
                #region Races      
                    #region Hobbit  
                     
                    context.MerpRaces.AddRange(
                        new Race {
                            EId = Guid.NewGuid(),
                            Enabled = true,
                            EnabledInWeb = true,
                            Name = "Hobbit",
                            Stats = new StatSet() {
                                Strength = new BaseStat {
                                    Abbr = StatAbbr.St,
                                    Value = -20
                                },
                                Agility = new BaseStat {
                                    Abbr = StatAbbr.Ag,
                                    Value = 15
                                },
                                Constitution = new BaseStat {
                                    Abbr = StatAbbr.Co,
                                    Value = 15
                                },
                                Intelligence = new BaseStat {
                                    Abbr = StatAbbr.Ig,
                                    Value = 0
                                },
                                Intuition = new BaseStat {
                                    Abbr = StatAbbr.In,
                                    Value = -5
                                },
                                Presence = new BaseStat {
                                    Abbr = StatAbbr.Pr,
                                    Value = -5
                                },
                                Appearance = new BaseStat {
                                    Abbr = StatAbbr.Ap,
                                    Value = 0
                                }
                            },
                            RR = new RRStatSet() {
                                Essence = new BaseStat {
                                    Abbr = StatAbbr.Ess,
                                    Value = 50
                                },
                                Channeling = new BaseStat {
                                    Abbr = StatAbbr.Chn,
                                    Value = 20
                                },
                                Poison = new BaseStat {
                                    Abbr = StatAbbr.Pos,
                                    Value = 30
                                },
                                Disease = new BaseStat {
                                    Abbr = StatAbbr.Dis,
                                    Value = 15
                                },
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
                            Stats = new StatSet() {
                                Strength = new BaseStat {
                                    Abbr = StatAbbr.St,
                                    Value = 5
                                },
                                Agility = new BaseStat {
                                    Abbr = StatAbbr.Ag,
                                    Value = 0
                                },
                                Constitution = new BaseStat {
                                    Abbr = StatAbbr.Co,
                                    Value = 10
                                },
                                Intelligence = new BaseStat {
                                    Abbr = StatAbbr.Ig,
                                    Value = 0
                                },
                                Intuition = new BaseStat {
                                    Abbr = StatAbbr.In,
                                    Value = -5
                                },
                                Presence = new BaseStat {
                                    Abbr = StatAbbr.Pr,
                                    Value = -5
                                },
                                Appearance = new BaseStat {
                                    Abbr = StatAbbr.Ap,
                                    Value = 0
                                }
                            },
                            RR = new RRStatSet() {
                                Essence = new BaseStat {
                                    Abbr = StatAbbr.Ess,
                                    Value = 20
                                },
                                Channeling = new BaseStat {
                                    Abbr = StatAbbr.Chn,
                                    Value = 0
                                },
                                Poison = new BaseStat {
                                    Abbr = StatAbbr.Pos,
                                    Value = 5
                                },
                                Disease = new BaseStat {
                                    Abbr = StatAbbr.Dis,
                                    Value = 5
                                },
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
