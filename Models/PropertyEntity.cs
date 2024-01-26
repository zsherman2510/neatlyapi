using System;
using System.Collections.Generic;

namespace NeatlyApi.Models
{
  public class PropertyEntity : BaseModelClass
  {
    public int Id { get; set; } // Assuming you have an ID field

    public int CustomerId { get; set; }

    public CustomerEntity? Customer { get; set; } // Assuming you have a Customer class

    public string Address { get; set; } = string.Empty;

    public string PropertyType { get; set; } = string.Empty;

    public int? Bedrooms { get; set; }

    public int? Bathrooms { get; set; }

    public bool SuppliesRequired { get; set; }

    public bool EquipmentRequired { get; set; }

    public bool IsPrimary { get; set; }

    // Navigation property for associated jobs
    public List<JobEntity>? Jobs { get; set; } // Assuming you have a Job class
  }
}
