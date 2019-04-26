using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company bestCompany = new Company();
            bestCompany.companyName = "Best Company";
            bestCompany.dateFounded = DateTime.Now;


            Employee bobby = new Employee();
            bobby.firstName = "Bobby";
            bobby.lastName = "Bobby";
            bobby.title = "Supervisor";
            bobby.startDate = DateTime.Now;

            Employee sable = new Employee();
            sable.firstName = "Sable";
            sable.lastName = "Sable";
            sable.title = "Associate";
            sable.startDate = DateTime.Now;

            Employee nick = new Employee();
            nick.firstName = "Nick";
            nick.lastName = "Nick";
            nick.title = "CEO";
            nick.startDate = DateTime.Now;


            bestCompany.employeeList.Add(bobby);
            bestCompany.employeeList.Add(sable);
            bestCompany.employeeList.Add(nick);

            foreach(Employee employee in bestCompany.employeeList){
                Console.WriteLine($"{employee.firstName} {employee.lastName} works for the company Best Company as a {employee.title} and started on {employee.startDate}.");
            }













        }
    }
}
