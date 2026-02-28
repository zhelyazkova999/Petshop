using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Employee
    {
        [Key]
        public string Id { get; set; } 

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Position")]
        public string Position { get; set; }

        [Required]
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }

        [Required]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string position, decimal salary, DateTime hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
        }

        public decimal CalculateYearlySalary()
        {
            return Salary * 12;
        }

        public int GetYearsOfExperience()
        {
            var today = DateTime.Today;
            int years = today.Year - HireDate.Year;

            if (HireDate.Date > today.AddYears(-years))
            {
                years--;
            }

            return years;
        }

        public string GetInfo()
        {
            return $"Employee: {FirstName} {LastName}, Position: {Position}, Salary: {Salary} lv";
        }
    }
}
