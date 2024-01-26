using System;
using System.Collections.Generic;

namespace NeatlyApi.Models
{
  public class CaregiverEntity : BaseModelClass
  {
    public int Id { get; set; } // Assuming you have an ID field

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    // Work Experience
    public int YearsOfExperience { get; set; }

    public List<string> ServicesOffered { get; set; } = new List<string>(); // Initialize as an empty list

    // Location
    public List<string> PreferredServiceAreas { get; set; } = new List<string>(); // Initialize as an empty list

    // Profile Photo
    public string ProfilePhotoUrl { get; set; } = string.Empty;

    public string PayRate { get; set; } = string.Empty;

    // Brief Bio
    public string Bio { get; set; } = string.Empty;

    public List<JobEntity> Jobs { get; set; } = new List<JobEntity>(); // Initialize as an empty list
  }
}
