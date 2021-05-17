
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RaceStat : RaceStatView
   {  
       [Key]
       public int Id { get; set; }  
   }  

public class RaceStatView 
    {
        public BaseStat Stat { get; set; }
        public int Value { get; set; }
    }

public class RaceRR: RaceStat {
    
}