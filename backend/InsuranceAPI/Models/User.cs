using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

public class User
{
	 [Key] // Primary Key
    public int Id { get; set; }

    [Required] // cannot be null
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [EmailAddress] // validates email format
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public UserRole Role { get; set; }

	public User()
	{
	
	}
}
