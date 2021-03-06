
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Deity : DeityView
   {  
       [Key]
       public int Id { get; set; }  
       public bool Enabled { get; set; }
       public bool EnabledInWeb { get; set; } 
   }  

public class DeityView 
    {
        public Guid? EId { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
    }