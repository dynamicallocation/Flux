using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRoster
{
    abstract class Employee
    {
        private String firstName;
        private String lastName;
        private String socialSecurityNum;
        private String userIdentificationNumber;
        private decimal generatedRevenue;
        private decimal costPerUnit;
        private decimal unitsSold;
        public Employee(String first, String last, String ssn,String uid)
        {

            firstName = first;
            lastName = last;
            socialSecurityNum = ssn;
            //unique identification number used to input employee sales
            userIdentifiction number = uid;
            unitCost = costPerUnit;
            soldUnits = unitsSold;

        }

        public decimal GeneratedRevenue
        {
            get
            {
                return generatedRevenue;
            }
            set
            {
                generatedRevenue = costPerUnit * unitsSold;
            }
        }

   

        //This is our employees base class it represents the commanalities all employees share i.e 
        //every employee will have a salary,ssn,and userid
    }

}
