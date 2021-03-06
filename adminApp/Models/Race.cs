
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Race : RaceExtended
   {  
       [Key]
       public int Id { get; set; }  
       public bool Enabled { get; set; }
       public bool EnabledInWeb { get; set; } 
   }  

public class RaceExtended : RaceView
    {
        public ICollection<RaceStat> Stats { get; set; }
        public ICollection<RaceSkill> Skills { get; set; }
        public ICollection<RaceLanguage> Languages { get; set; } 
    }

public class RaceView : RaceDescription
    {
        // public ICollection<RaceStat> Stats { get; set; }

        // public ICollection<RaceRR> RRs { get; set; }
        // public RRStatSet RR { get; set; }
        // public int St { get; set; }
        // public int Ag { get; set; }
        // public int Co { get; set; }
        // public int In { get; set; }
        
        // public int Ig { get; set; }
        
        // public int Pr { get; set; }
        // public int Ap { get; set; }
        // public int Dis  { get; set; }
        // public int Pos { get; set; }
        // public int Chn { get; set; }
        // public int Ess { get; set; }

        // public ICollection<RaceSkill> Skills { get; set; }
        // public ICollection<RaceLanguage> Languages { get; set; }

        public int SpellListChance { get; set; }
        public int ExtraLanguageRanks { get; set; }
        public int BackgroundOptions { get; set; }
        public int Frequency { get; set; }
    }

    public class RaceDescription 
    {
        public Guid? EId { get; set; } 
        
        public string Name { get; set; }
        public string Description { get; set; }
    }