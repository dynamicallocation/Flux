using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRoster
{

    //employee class for base salary
    class BaseEmployee : Employee
    {
        private decimal baseSalary;
        private Boolean isProductive = false;

        public BaseEmployee(String firstName, String lastName, String ssn, decimal salary)
            : base(firstName, lastName, ssn)
        {
            baseSalary = salary;
        }



        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            } // end get
            set
            {
                baseSalary = (value >= 0) ? value : 0; // validation
            } // end set
        } // end property BaseSalary

        // calculate earnings; override method Earnings in CommissionEmployee
        public override decimal Earnings()
        {
            return baseSalary;
        } // end method Earnings               

        // return string representation of BasePlusCommissionEmployee object
        public override string ToString()
        {
            return "Salaried Employee" + base.ToString() + " " + baseSalary;
        } // end method ToString 
        

        public void analyzeBaseProductivity()
        {
            if(base.GeneratedRevenue > baseSalary)
            {
                isProductive = true;
            }
        }

        public Boolean getBaseProductivity()
        {
            return isProductive;
        }



        
    } // end class BasePlusCommissionEmployee


}
