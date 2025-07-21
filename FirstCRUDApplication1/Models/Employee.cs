using System.ComponentModel.DataAnnotations;

namespace FirstCRUDApplication1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter your Name...")]
        public string Name { get; set; }
        [Range(16,60, ErrorMessage = "Age 16-60 only")]
        public int Age { get; set; }
        [RegularExpression(@"\d+(\.\d{1,2})?",ErrorMessage = "Invalide, Enter like # or #.##")]
        public decimal Salary { get; set; }
        public string Department { get; set; }
        [RegularExpression(@"^[MF]+$" , ErrorMessage = "Select any one option")]
        public Char Sex { get; set; }
    }


}
