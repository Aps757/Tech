using System.ComponentModel.DataAnnotations;

namespace Tech.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

    }
}
