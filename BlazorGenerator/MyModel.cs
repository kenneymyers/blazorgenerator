using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorGenerator
{
    public partial class MyModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3, 
            ErrorMessage = "FirstName should be minimum 3 characters and a maximum of 50 characters")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, 
            ErrorMessage = "LastName should be minimum 3 characters and a maximum of 50 characters")]
        public string LastName { get; set; }
        public bool NoWay { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter valid integer Number between 1 and 100.")]
        public int Count { get; set; }
        [Range(0.01, 100.00,ErrorMessage = "Price must be between 0.01 and 100.00")]
        public double Fees { get; set; }
        public DateTime CreateDate { get; set; }
        public List<string> Names { get; set; }
    }
}
