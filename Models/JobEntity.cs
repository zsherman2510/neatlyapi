using System;
using System.Collections.Generic;

namespace NeatlyApi.Models
{
  public class JobEntity : BaseModelClass
  {
    public int Id { get; set; } // Assuming you have an ID field

    public int CustomerId { get; set; }

    public CustomerEntity? Customer { get; set; } // Assuming you have a Customer class

    public int PropertyId { get; set; }

    public PropertyEntity? Property { get; set; } // Assuming you have a Property class

    public int? CaregiverId { get; set; }

    public CaregiverEntity? Caregiver { get; set; } // Assuming you have a Cleaner class

    public string TypeOfCare { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string JobStatus { get; set; } = string.Empty;

    public string SpecialRequests { get; set; } = string.Empty;

    public string Tasks { get; set; } = string.Empty; // Store as JSON or serialized text

    public string Frequency { get; set; } = string.Empty;

    public string Duration { get; set; } = string.Empty;

    public double? Price { get; set; }
  }
}
