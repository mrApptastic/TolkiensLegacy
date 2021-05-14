
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class BaseStat : StatView
   {  
       [Key]
       public int Id { get; set; }  
       public bool Enabled { get; set; }
       public bool EnabledInWeb { get; set; } 
   }  

public class StatView 
    {
        public Guid? EId { get; set; } 
        public string Name { get; set; }
        public string Abbr { get; set; }
        public int Value { get; set; }
       
    }