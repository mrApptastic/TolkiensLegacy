
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Race : RaceView
   {  
       [Key]
       public int Id { get; set; }  
       public bool Enabled { get; set; }
       public bool EnabledInWeb { get; set; } 
   }  

public class RaceView 
    {
        public Guid? EId { get; set; } 
        public string Name { get; set; }

        public ICollection<BaseStat> Stats { get; set; }
    }