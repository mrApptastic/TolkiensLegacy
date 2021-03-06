
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Language : LanguageView
   {  
       [Key]
       public int Id { get; set; }  
       public bool Enabled { get; set; }
       public bool EnabledInWeb { get; set; } 
   }  

public class LanguageView 
    {
        public Guid? EId { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
    }

public enum LanguageRank {
    Simple = 1,
    Basic = 2,
    Native = 3,
    Literate = 4,
    Fluent = 5

}