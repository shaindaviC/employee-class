using System;


public class Employee
{
    public string EmployeeName { get; set; }
    public decimal BasicSalary { get; set; }

   
    public decimal HRA { get; private set; }
    public decimal DA { get; private set; }
    public decimal GrossPay { get; private set; }
    public decimal TAX { get; private set; }
    public decimal NetSalary { get; private set; }

  
    private const decimal HRA_RATE = 0.15m; 
    private const decimal DA_RATE = 0.10m;
    private const decimal TAX_RATE = 0.08m;

  
    public Employee(string name, decimal basicSalary)
    {
        this.EmployeeName = name;
        this.BasicSalary = basicSalary;
    }

    
    public void CalculateNetPay()
    {
        
        this.HRA = this.BasicSalary * HRA_RATE;

        
        this.DA = this.BasicSalary * DA_RATE;

        
        this.GrossPay = this.BasicSalary + this.HRA + this.DA;

        
        this.TAX = this.GrossPay * TAX_RATE;

        
        this.NetSalary = this.GrossPay - this.TAX;
    }

    
    public void DisplaySalaryStructure()
    {
        Console.WriteLine("\n===Employee Salary Structure===");
        Console.WriteLine($"Employee Name:{this.EmployeeName}");
        Console.WriteLine($"Basic Salary:{this.BasicSalary:C}");
        Console.WriteLine("===Earnings===");
        Console.WriteLine($"HRA (15%):{this.HRA:C}");
        Console.WriteLine($"DA (10%):{this.DA:C}");
        Console.WriteLine($"Gross Pay:{this.GrossPay:C}");
        Console.WriteLine("Deductions");
        Console.WriteLine($"Tax (8%):{this.TAX:C}");
        Console.WriteLine($"Net Salary:{this.NetSalary:C}");
       
    }
}