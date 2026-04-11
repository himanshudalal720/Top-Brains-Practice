using System;
using System.Linq;
using System.Xml.Linq;

namespace EmployeeDataGridview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Parse(@"
<Employees>
    <Employee>
        <Name>Thomas</Name>
        <Designation>Executive</Designation>
        <Department>Accounts</Department>
        <Salary>5000</Salary>
    </Employee>
    <Employee>
        <Name>Wills</Name>
        <Designation>Manager</Designation>
        <Department>Accounts</Department>
        <Salary>24000</Salary>
    </Employee>
    <Employee>
        <Name>Brod</Name>
        <Designation>Manager</Designation>
        <Department>Finance</Department>
        <Salary>28000</Salary>
    </Employee>
    <Employee>
        <Name>Smith</Name>
        <Designation>Analyst</Designation>
        <Department>Finance</Department>
        <Salary>21000</Salary>
    </Employee>
</Employees>
");

            var res = from emp in xdoc.Root.Elements("Employee")
                      where emp.Element("Department").Value == "Finance"
                      && int.Parse(emp.Element("Salary").Value) > 25000
                      select new
                      {
                          Name = emp.Element("Name").Value,
                          Department = emp.Element("Department").Value,
                          Salary = emp.Element("Salary").Value
                      };

            Console.WriteLine("Filtered Employees:\n");

            foreach (var emp in res)
            {
                Console.WriteLine("Name: " + emp.Name);
                Console.WriteLine("Department: " + emp.Department);
                Console.WriteLine("Salary: " + emp.Salary);
            }

            Console.ReadLine();
        }
    }
}