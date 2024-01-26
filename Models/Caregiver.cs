using System;
using System.Collections.Generic;

namespace Caregiver.Models;


public class Caregiver
{
  public int Id { get; set; } // Assuming you have an ID field

  public string FirstName { get; set; }

  public string LastName { get; set; }

  public string Email { get; set; }

  public string PhoneNumber { get; set; }

  public string Password { get; set; }

  // Work Experience
  public int YearsOfExperience { get; set; }

  public List<string> ServicesOffered { get; set; } // Use List<string> to store multiple services

  // Location
  public List<string> PreferredServiceAreas { get; set; } // Use List<string> to store multiple areas

  // Profile Photo
  public string ProfilePhotoUrl { get; set; } // Store the URL of the uploaded photo

  public string PayRate { get; set; }

  // Brief Bio
  public string Bio { get; set; }
}