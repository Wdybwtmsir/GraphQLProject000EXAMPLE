using System.ComponentModel.DataAnnotations;

namespace GraphQLClient0.DataAccess.Model
{
    public class CreateEmployeeModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(minimum:20,maximum:50)]
        public int Age { get; set; }
        [Required(ErrorMessage = "DepartmentName is required")]
        public string? DepartmentName { get; set; }
    }
}
