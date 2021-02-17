
using System.ComponentModel.DataAnnotations;
namespace dojo_survey.Models
{
    
    public class Survey 
    {
        // [Required(ErrorMessage="You must supply a title.")]
        // [MinLength(5, ErrorMessage="The title must be at least 5 characters.")][Required]
        [MinLength(2)]
        public string Name {get; set;}
        
        [Required]
        public string Location {get; set;}
        [Required]
        public string Language {get; set;}

        public string Comments {get; set;}
    }
}
