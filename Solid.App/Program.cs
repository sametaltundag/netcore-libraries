/* using Solid.App.OCPBad;
using Solid.App.OCPGood;

SalaryCalculator salaryCalculator = new SalaryCalculator();
SalaryCalculator2 salaryCalculator2 = new SalaryCalculator2();


//Bad way
Console.WriteLine($"Low Salary: { salaryCalculator.Calculate(1000, SalaryType.Low)}");
Console.WriteLine($"Medium Salary: { salaryCalculator.Calculate(1000,SalaryType.Middle)}");
Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000, SalaryType.High)}");


// OCP Good way
Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000,new LowSalaryCalculate())}");
Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000,new MiddleSalaryCalculate())}");
Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000,new HighSalaryCalculate())}");
Console.WriteLine($"Manager Salary: {salaryCalculator.Calculate(1000,new ManagerSalaryCalculate())}");

// OCP Good way 2 (Delegate)
Console.WriteLine($"Low Salary: {salaryCalculator2.Calculate(1000, new LowSalaryCalculate().Calculate)}");
Console.WriteLine($"Middle Salary: {salaryCalculator2.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
Console.WriteLine($"High Salary: {salaryCalculator2.Calculate(1000, new HighSalaryCalculate().Calculate)}");
Console.WriteLine($"Manager Salary: {salaryCalculator2.Calculate(1000, new ManagerSalaryCalculate().Calculate)}");

Console.WriteLine($"Custom salary: { salaryCalculator2.Calculate(1000, x =>
{
    return x * 10;
})}");


using Solid.App.LSPBad;

using Solid.App.LSPGood;


BasePhone phone = new IPhone();

phone.Call();

((ITakePhoto)phone).TakePhoto();

phone = new Nokia3310();

phone.Call();


*/

using Solid.App.DIPGoodAndBad;

var ProductService = new ProductService(new ProductRepoFromOracleServer());

ProductService.GetAll().ForEach(x => Console.WriteLine(x));