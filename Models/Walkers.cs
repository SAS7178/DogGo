using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DogGo.Models
{
    public class Walker
    { 
        public int Id { get; set; }
        [Required(ErrorMessage ="Gonna need to name him bud...")]
        public string Name { get; set; }
        public int NeighborhoodId { get; set; }
        [DisplayName("Walker Image")]
        public string ImageUrl { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public List<Walks> Walks { get; set; }

        public int TotalDuration { get 
            {
                return Walks.Sum(w => w.Duration);
            }
        }

    }
}