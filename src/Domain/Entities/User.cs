﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "invalid Email Address")]
        public string Email { get; set; }

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password should be at least 6 characters.")]
        public string Password { get; set; }

        [Required]
        public UserType Type { get; set; }
        
        public Shop Shop { get; set; }
        
        public StatusType Status { get; set; } = StatusType.Active;

        public ICollection<Schedule> WorkSchedules { get; set; }


    }
}
