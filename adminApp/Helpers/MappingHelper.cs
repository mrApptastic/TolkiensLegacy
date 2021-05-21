using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using admin_app.Data;
using admin_app.Models;

namespace admin_app.Helpers
{
    public class MappingHelper
    {
        public static RaceExtended MapRaceToExtendedViewModel (Race race) {
            return new RaceExtended() {
                Name = race.Name,
                Stats = race.Stats,
                Skills = race.Skills,
                Languages = race.Languages,
                SpellListChance = race.SpellListChance,
                ExtraLanguageRanks = race.ExtraLanguageRanks,
                BackgroundOptions = race.BackgroundOptions,
                Frequency = race.Frequency,
                EId = race.EId,
                Description = race.Description
            };
        }

        public static RaceView MapRaceToViewModel (Race race) {
            return new RaceView() {
                Name = race.Name,
                SpellListChance = race.SpellListChance,
                ExtraLanguageRanks = race.ExtraLanguageRanks,
                BackgroundOptions = race.BackgroundOptions,
                Frequency = race.Frequency,
                EId = race.EId,
                Description = race.Description
            };
        }

    }


        
}
