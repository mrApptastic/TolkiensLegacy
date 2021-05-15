
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RRStatSet : RRStatSetView
   {  
       [Key]
       public int Id { get; set; }  
   }  

public class RRStatSetView 
    {
        public BaseStat Essence { get; set; }
        
        public BaseStat Channeling { get; set; }
        
        public BaseStat Poison { get; set; }
        
        public BaseStat Disease { get; set; }       
    }