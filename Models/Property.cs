using System;
using System.Collections.Generic;

namespace Property.Models // Replace with your desired namespace
{
  public class Property
  {
    public int Id { get; set; } // Assuming you have an ID field

    public int CustomerId { get; set; }

    public Customer Customer { get; set; } // Assuming you have a Customer class

    public string Address { get; set; }

    public string PropertyType { get; set; }

    public int? Bedrooms { get; set; }

    public int? Bathrooms { get; set; }

    public bool SuppliesRequired { get; set; }

    public bool EquipmentRequired { get; set; }

    public bool IsPrimary { get; set; }

    // Navigation property for associated jobs
    public List<Job> Jobs { get; set; } // Assuming you have a Job class
  }
}
