using System.ComponentModel.DataAnnotations;

namespace unitoneproject.Models
{
    public class MathModel
    {
        [Required(ErrorMessage = "Please enter the first number")]
        public double Number1 { get; set; }

        [Required(ErrorMessage = "Please enter the second number")]
        public double Number2 { get; set; }

        public double Result { get; set; }
    }
}
