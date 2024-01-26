using System;
using System.Collections.Generic;

namespace Customer.Models // Replace with your desired namespace
{
  public class Customer
  {
    public int Id { get; set; } // Assuming you have an ID field

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string PrimaryAddress { get; set; }

    public string PaymentInfo { get; set; } // Consider encrypting this data for security

    public string ProfileImage { get; set; } // Store the URL/path to the image

    public string Preferences { get; set; } // Store as JSON or serialized text

    public string Password { get; set; } // Remember to handle password hashing in your application logic

    // Navigation properties for associations
    public List<Job> Jobs { get; set; } // Assuming you have a Job class

    public List<Property> Properties { get; set; } // Assuming you have a Property class
  }
}
