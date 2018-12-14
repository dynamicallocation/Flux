﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRoster
{
    // BasePlusCommissionEmployee.cs
    // BasePlusCommissionEmployee class that extends CommissionEmployee.
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary; // base salary per week
        private Boolean isProductive = false;//productivity of the employee measured differently depending on the employee

        // six-parameter constructor
        public BasePlusCommissionEmployee(string first, string last,
           string ssn, decimal sales, decimal rate, decimal salary)
           : base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary; // validate base salary via property
        } // end six-parameter BasePlusCommissionEmployee constructor

        // property that gets and sets 
        // base-salaried commission employee's base salary
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
            return BaseSalary + base.Earnings();
        } // end method Earnings 

        public void analyzeBaseProductivity()
        {
            if (base.GeneratedRevenue > baseSalary)
            {
                isProductive = true;
            }
        }

        public Boolean getBaseProductivity()
        {
            return isProductive;
        }


        // return string representation of BasePlusCommissionEmployee object
        public override string ToString()
        {
            return string.Format("base-salaried {0}; base salary: {1:C}",
               base.ToString(), BaseSalary);
        } // end method ToString                                            
    } // end class BasePlusCommissionEmployee

    /**************************************************************************
     * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
     * Pearson Education, Inc. All Rights Reserved.                           *
     *                                                                        *
     * DISCLAIMER: The authors and publisher of this book have used their     *
     * best efforts in preparing the book. These efforts include the          *
     * development, research, and testing of the theories and programs        *
     * to determine their effectiveness. The authors and publisher make       *
     * no warranty of any kind, expressed or implied, with regard to these    *
     * programs or to the documentation contained in these books. The authors *
     * and publisher shall not be liable in any event for incidental or       *
     * consequential damages in connection with, or arising out of, the       *
     * furnishing, performance, or use of these programs.                     *
     **************************************************************************/
}
