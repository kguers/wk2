using System;

namespace PizzaStore.Domain.Models
{
     public class User
     {
          public List<Order> Orders {get; set;}
          public Name Name { get; set; }
     }
}