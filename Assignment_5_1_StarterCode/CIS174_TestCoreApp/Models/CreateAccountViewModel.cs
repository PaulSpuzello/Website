using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CIS174_TestCoreApp.Models
{
    public class CreateAccountViewModel
    {
        public static List<SelectListItem> ItemsWithGroups { get; private set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(25)]
        [MinLength(2)]
        public string LastName { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        [Range(typeof(DateTime), "1,1,1900", "12,31,2108")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        public IEnumerable<string> SelectedValues { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }
        public static void SelectListsViewModel()

        {

            var country = new SelectListGroup { Name = "Country" };
            ItemsWithGroups = new List<SelectListItem>
            {
                new SelectListItem{Value= "USA", Text = "USA", Group = country },
                new SelectListItem { Value = "Mexico", Text = "Mexico", Group = country },
                new SelectListItem { Value = "Canada", Text = "Canada", Group = country },
            };
        }
    }
}
