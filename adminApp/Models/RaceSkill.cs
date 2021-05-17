
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RaceSkill : RaceSkillView
   {  
       [Key]
       public int Id { get; set; }  
   }  

public class RaceSkillView 
    {
        public int Ranks { get; set; }
        public int Bonus { get; set; }
        public Skill Skill { get; set; }
    }