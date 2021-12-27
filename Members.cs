using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy
{
    internal class Members
    {

        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member - public field
        public int age;

        //property with capital first letter
        //member - property - exposes jobTitle safely
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }

            set
            {
                jobTitle = value;
            }
        }
            //public member method
            public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
              
            }
            else
            {
                Console.WriteLine($"Hi my name is{memberName} age is {age} job is {jobTitle}");
            }
        }
            private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {this.salary}");
        }

        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Rosco";
            salary = 20000;
            jobTitle = "developer";
            Console.WriteLine("object created");
        }

        //member-= - finalizer - destructor
        //only one destructor per class
        //cannot inherit or cannot be called
        //cant be used empty
        ~Members()
        {
            //clean up statements
            Console.WriteLine("destruction of members object");

            Debug.Write("destruction of members object");
        }

    }




    }

