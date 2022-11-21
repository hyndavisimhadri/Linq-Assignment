using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    public class employee



    {
        public int employeeid;
        public string firstname;
        public string lastname;
        public string title;
        //DateTime Dob;
        //DateTime Doj;
        public string city;




        public static void Main()
        {
            IList<employee> emp = new List<employee>
        {
            //emp.Add(new employee() { employeeid = 1001, firstname =})
            new employee { employeeid = 1001, firstname = "malcolm", lastname = "Darwalla", title = "manager", city = "mumbai" },
            new employee { employeeid = 1002, firstname = "Asdin", lastname = "Dhalla", title = "Asstmanager", city = "mumbai" },
            new employee { employeeid = 1003, firstname = "madavi", lastname = "oza", title = "consulant", city = "mumbai" },
            new employee { employeeid = 1004, firstname = "Saba", lastname =" Shaikh", title = "SE", city = "Pune" },
            new employee { employeeid = 1005, firstname = "Nazia", lastname = "shaikh", title = "SE", city = "Pune" },
            new employee { employeeid = 1006, firstname = "Amit", lastname = "Pathak", title = "Consultant", city = "Chennai" },
            new employee { employeeid = 1007, firstname = "vijay", lastname = "natrajan", title = "Consultant", city = "mumbai" },
            new employee { employeeid = 1008, firstname = "Rahul", lastname = "Dubey", title="Associate", city = "Chennai" },
            new employee { employeeid = 1009, firstname = "suresh", lastname = "mistry", title = "Associate", city = "Chennai" },
            new employee { employeeid = 1010, firstname ="sumit", lastname = "Shah", title = "manager", city = "pune" }
        };
            var result = (from s in emp select s);
            foreach (employee E in result)
            {
                // Console.WriteLine(E.result);  
                Console.WriteLine("employeeid:" + E.employeeid + "firstname:" + E.firstname + "lastname:" + E.lastname + "title:" + E.title + "city:" + E.city);
                Console.ReadLine();



            }



        }



    }



}