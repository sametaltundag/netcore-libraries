using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCPGood
{
    // Open Closed Prensibi değişikliğe kapalı, yeniliğe açık.

    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 5;
        }
    }

    public class MiddleSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 10;
        }
    }

    public class HighSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 15;
        }
    }

    public class ManagerSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 20;
        }
    }

    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary,ISalaryCalculate salaryCalculate)
        {
            return salaryCalculate.Calculate(salary);
        }
    }

    public class SalaryCalculator2
    {
        public decimal Calculate(decimal salary, Func<decimal,decimal> calculateDelegate)
        {
            return calculateDelegate(salary);
        }
    }

}
