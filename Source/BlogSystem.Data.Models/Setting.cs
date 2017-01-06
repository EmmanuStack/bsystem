﻿namespace BlogSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Setting
    {
        [Key]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
