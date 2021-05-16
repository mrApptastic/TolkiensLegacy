
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RaceLanguage : RaceLanguageView
   {  
       [Key]
       public int Id { get; set; }  
   }  

public class RaceLanguageView 
    {
        public Language Language { get; set; }
        public LanguageRank Rank { get; set; }
    }