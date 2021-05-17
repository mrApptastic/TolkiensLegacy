
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Skill : SkillView
   {  
       [Key]
       public int Id { get; set; }  
       public bool Enabled { get; set; }
       public bool EnabledInWeb { get; set; } 
   }  

public class SkillView 
    {
        public Guid? EId { get; set; } 
        public string Name { get; set; }
        public SkillCategory Category { get; set; }
        public SkillStat Stat { get; set; }
        public RankValue RankValue { get; set; }
        public int MaxRanks { get; set; }
        public bool ExcludeLevelBonus { get; set; } 
        public int? SortOrder { get; set; }
    }


public enum RankValue {
    None = 0,
    Always5 = 5,
    d10 = 10
}