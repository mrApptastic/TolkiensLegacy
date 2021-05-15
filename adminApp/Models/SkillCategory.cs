
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SkillCategory : SkillCategoryView
   {  
       [Key]
       public int Id { get; set; }  
       public bool Enabled { get; set; }
       public bool EnabledInWeb { get; set; } 
   }  

public class SkillCategoryView 
    {
        public Guid? EId { get; set; } 
        public string Name { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public int? SortOrder { get; set; }

    }