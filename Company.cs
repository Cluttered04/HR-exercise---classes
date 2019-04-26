using System;
using System.Collections.Generic;

namespace classes {
    class Company {
        public DateTime dateFounded {get; set;}
        public string companyName {get; set;}
        public List<Employee> employeeList {get; set;} = new List<Employee>();
        public void listEmployees(){
            foreach(Employee employee in employeeList){
                Console.WriteLine($"{employee.firstName} {employee.lastName}");
            }
        }

    }

}
