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

                // if (context.MerpLanguages.Count() == 0) {
                //     context.MerpLanguages.AddRange(
                //         new Language() {
                //             Enabled = true,
                //             EnabledInWeb = true,
                //             EId = Guid.NewGuid(),
                //             Name = "Adunaic"
                //         },
                //         new Language() {
                //             Enabled = true,
                //             EnabledInWeb = true,
                //             EId = Guid.NewGuid(),
                //             Name = "Adunaic"
                //         },
                //         new Language() {
                //             Enabled = true,
                //             EnabledInWeb = true,
                //             EId = Guid.NewGuid(),
                //             Name = "Adunaic"
                //         },
                //         new Language() {
                //             Enabled = true,
                //             EnabledInWeb = true,
                //             EId = Guid.NewGuid(),
                //             Name = "Adunaic"
                //         },
                //         new Language() {
                //             Enabled = true,
                //             EnabledInWeb = true,
                //             EId = Guid.NewGuid(),
                //             Name = "Adunaic"
                //         }
                //     );
                // }
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
