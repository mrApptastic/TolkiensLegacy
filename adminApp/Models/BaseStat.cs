
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class BaseStat : BaseStatView
   {  
       [Key]
       public int Id { get; set; }  
       public bool Enabled { get; set; }
       public bool EnabledInWeb { get; set; } 
   }  

public class BaseStatView 
    {
        public Guid? EId { get; set; } 
        public string Name { get; set; }
       
    }