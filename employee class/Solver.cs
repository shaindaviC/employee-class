internal class Program
{
    static void Main(string[] args)
    {

        Employee alice = new Employee("Alice Johnson", 60000.00m);
        alice.CalculateNetPay();
        alice.DisplaySalaryStructure();
    }
}