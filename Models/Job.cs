using System;

namespace Job.Models
{
  public class Job
  {
    public int Id { get; set; } // Assuming you have an ID field

    public int CustomerId { get; set; }

    public Customer Customer { get; set; } // Assuming you have a Customer class

    public int PropertyId { get; set; }

    public Property Property { get; set; } // Assuming you have a Property class

    public int? CleanerId { get; set; }

    public Cleaner Cleaner { get; set; } // Assuming you have a Cleaner class

    public string TypeOfCare { get; set; }

    public string Address { get; set; }

    public string JobStatus { get; set; }

    public string SpecialRequests { get; set; }

    public string Tasks { get; set; } // Store as JSON or serialized text

    public string Frequency { get; set; }

    public string Duration { get; set; }

    public double? Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
  }
}
