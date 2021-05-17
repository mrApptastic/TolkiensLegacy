
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SkillStat : SkillStatView
   {  
       [Key]
       public int Id { get; set; }  
   }  

public class SkillStatView 
    {
        public BaseStat Stat { get; set; }
    }