namespace PetShop.Models
{
    public class PetShop
    {
        public List<Product> Products { get; set; }
        public List<Pet> Pets { get; set; }
        public List<Employee> Employees { get; set; }

        public PetShop()
        {
            Products = new List<Product>();
            Pets = new List<Pet>();
            Employees = new List<Employee>();
        }

        public void AddProduct(Product product)
        {
            if (product != null)
                Products.Add(product);
        }

        public void AddPet(Pet pet)
        {
            if (pet != null)
                Pets.Add(pet);
        }

        public void AddEmployee(Employee employee)
        {
            if (employee != null)
                Employees.Add(employee);
        }

        public void RemoveProduct(string name)
        {
            var product = Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                Products.Remove(product);
            }
        }

        public void RemoveEmployee(string firstName, string lastName)
        {
            var employee = Employees
                .FirstOrDefault(e => e.FirstName == firstName && e.LastName == lastName);

            if (employee != null)
            {
                Employees.Remove(employee);
            }
        }

        public decimal CalculateTotalValue()
        {
            decimal productValue = Products.Sum(p => p.Price * p.Quantity);
            decimal petValue = Pets.Sum(p => p.Price);

            return productValue + petValue;
        }

        public decimal CalculateMonthlySalaryExpense()
        {
            return Employees.Sum(e => e.Salary);
        }
    }
}
