
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ListModel
   {  
       [Key]
       public int Count { get; set; }  
       public List<dynamic> Results { get; set; }
   }  