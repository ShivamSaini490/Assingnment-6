using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeSalaryCalculator
{
    
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public double BaseSalary { get; set; }
    }

   
    public partial class Employee
    {
        
        public double CalculateBaseSalary()
        {
            return BaseSalary;
        }

        
        public double CalculateSalaryWithBonus(double bonusAmount)
        {
            return BaseSalary + bonusAmount;
        }

        
        public double CalculateSalaryWithDeduction(double deductionAmount)
        {
            if (BaseSalary - deductionAmount < 0)
            {
                Console.WriteLine("Deduction amount exceeds base salary.");
                return 0;
            }
            return BaseSalary - deductionAmount;
        }


        public double CalculateSalaryWithBonusAndDeduction(double bonusAmount, double deductionAmount)
        {
            double salaryAfterBonus = BaseSalary + bonusAmount;
            double salaryAfterDeduction = salaryAfterBonus - deductionAmount;

            if (salaryAfterDeduction < 0)
            {
                Console.WriteLine("Deduction amount exceeds base salary with bonus.");
                return 0;
            }

            return salaryAfterDeduction;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp = new Employee
            {
                EmployeeId = 1,
                FirstName = "Shivam",
                LastName = "Saini",
                Department = "CS",
                BaseSalary = 50000
            };

            Console.WriteLine("Base Salary: " + emp.CalculateBaseSalary());
            Console.WriteLine("Salary with Bonus: " + emp.CalculateSalaryWithBonus(1000));
            Console.WriteLine("Salary with Deduction: " + emp.CalculateSalaryWithDeduction(500));
            Console.WriteLine("Salary with Bonus and Deduction: " + emp.CalculateSalaryWithBonusAndDeduction(1000, 500));
        }
    }
}
