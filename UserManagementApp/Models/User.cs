using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagementApp.Models;

public class User
{
    [Key]
    public int Id { get; set; } // Required 

    [Required]
    public string FullName { get; set; } = string.Empty; // Required 

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty; // Required 

    [Required]
    public DateTime BirthDate { get; set; } // Required 

    public DateTime RegistrationDate { get; set; } = DateTime.Now; // Required 
}