using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using admin_app.Models;
using admin_app.Data;

namespace admin_app {

    public class SeedData {

        public static void SeedDatabase(ApplicationDbContext context) {
            if (context.Database.GetMigrations().Count() > 0
                    && context.Database.GetPendingMigrations().Count() == 0
                    && context.MerpRaces.Count() == 0
                    && context.MerpStats.Count() == 0) {

                    var strength = new BaseStat {
                        Name = "Strength"
                    };
                    var agility = new BaseStat {
                        Name = "Agility"
                    };
                    var constitution = new BaseStat {
                        Name = "Constitution"
                    };
                    var intuition = new BaseStat {
                        Name = "Intuition"
                    };
                    var intelligence = new BaseStat {
                        Name = "Intelligence"
                    };
                    var presence = new BaseStat {
                        Name = "Presence"
                    };
                    var appearance = new BaseStat {
                        Name = "Appearance"
                    };
                        
                    context.MerpRaces.AddRange(
                        new Race {
                            Name = "Commmon Orc",
                            Stats = new List<BaseStat>() {strength, agility, constitution, intuition, intelligence, presence, appearance}
                        },
                        new Race {
                            Name = "Sindar Elf",
                            Stats = new List<BaseStat>() {strength, agility, constitution, intuition, intelligence, presence, appearance}
                        });
                    };                   


                context.SaveChanges();
            }
        }
    }
