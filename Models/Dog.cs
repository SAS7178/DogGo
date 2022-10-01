using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{  
    public class Dog
    { 
        public int Id { get; set; }
        [Required(ErrorMessage = "Give this dog a name!")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Dog Owner")]
        public int OwnerId { get; set; }
        public string Breed { get; set; }
        public string Notes { get; set; }
        [Required(ErrorMessage = "Don't be trying to get a bear on here..need that picture!")]
        [DisplayName("Dog Image")]
        public string ImageUrl { get; set; }
        public Owner Owner { set; get; }

    }
}
