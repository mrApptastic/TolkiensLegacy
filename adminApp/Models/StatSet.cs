
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class StatSet : StatSetView
   {  
       [Key]
       public int Id { get; set; }  
   }  

public class StatSetView 
    {
        public BaseStat Strength { get; set; }
        
        public BaseStat Agility { get; set; }
        
        public BaseStat Constitution { get; set; }
        
        public BaseStat Intuition { get; set; }
        
        public BaseStat Intelligence { get; set; }
        
        public BaseStat Presence { get; set; }
        
        public BaseStat Appearance { get; set; }
       
    }