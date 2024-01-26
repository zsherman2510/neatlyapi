using System;
using System.Collections.Generic;

namespace NeatlyApi.Models
{
  public class CustomerEntity : BaseModelClass
  {
    public int Id { get; set; } // Assuming you have an ID field

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string PrimaryAddress { get; set; } = string.Empty;

    public string PaymentInfo { get; set; } = string.Empty; // Consider encrypting this data for security

    public string ProfileImage { get; set; } = string.Empty; // Store the URL/path to the image

    public string Preferences { get; set; } = string.Empty; // Store as JSON or serialized text

    public string Password { get; set; } = string.Empty; // Remember to handle password hashing in your application logic

    // Navigation properties for associations
    public List<JobEntity> Jobs { get; set; } = new List<JobEntity>(); // Initialize as an empty list

    public List<PropertyEntity> Properties { get; set; } = new List<PropertyEntity>(); // Initialize as an empty list
  }
}
