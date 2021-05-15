
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class BaseStat : StatView
   {  
       [Key]
       public int Id { get; set; }  
   }  

public class StatView 
    {
        public StatAbbr Abbr { get; set; }
        public int Value { get; set; }
       
    }

public enum StatAbbr {
    St,
    Co,
    Ag,
    In,
    Ig,
    Pr,
    Ap,
    Ess,
    Chn,
    Pos,
    Dis
}