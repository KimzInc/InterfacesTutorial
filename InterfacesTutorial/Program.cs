using System;
using System.Collections.Generic;

namespace InterfacesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IEmployee> employees = new List<IEmployee>();

            Seed(employees);
            Navigation(employees);

            Console.ReadKey();
        }

        private static void Seed(IList<IEmployee> employees)
        {
            ChiefExecutiveOfficer executiveOfficer = new ChiefExecutiveOfficer();
            executiveOfficer.Id = 1;
            executiveOfficer.JobTitle = "CEO";
            executiveOfficer.FirstName = "James";
            executiveOfficer.LastName = "Foly";
            executiveOfficer.AnnualSalary = 200000;
            executiveOfficer.HighestQualification = "Masters Degree";
            executiveOfficer.Gender = 'M';
            executiveOfficer.OfficeId = "O180";
            executiveOfficer.JoinDate = new DateTime(2013, 1, 12);
            executiveOfficer.SecretaryId = 42;
            executiveOfficer.PersonalAssistant = 120;

            employees.Add(executiveOfficer);

            Manager projectManager = new ProjectManager();

            projectManager.Id = 2;
            projectManager.JobTitle = "Project Manager";
            projectManager.FirstName = "Bob";
            projectManager.LastName = "Jones";
            projectManager.AnnualSalary = 100000;
            projectManager.HighestQualification = "Honours Degree";
            projectManager.Gender = 'm';
            projectManager.OfficeId = "D017";
            projectManager.JoinDate = new DateTime(2015, 4, 1);
            projectManager.SecretaryId = 110;
            projectManager.Id = 2;

            employees.Add(projectManager);

            Manager safetyManager = new SafetyManager();

            safetyManager.Id = 3;
            safetyManager.JobTitle = "Safety Manager";
            safetyManager.FirstName = "Jane";
            safetyManager.LastName = "Summers";
            safetyManager.AnnualSalary = 100000;
            safetyManager.HighestQualification = "Honours Degree";
            safetyManager.Gender = 'f';
            safetyManager.OfficeId = "D018";
            safetyManager.JoinDate = new DateTime(2016, 2, 3);
            safetyManager.SecretaryId = 145;

            employees.Add(safetyManager);

            Employee craneOperator = new CraneOperator();

            craneOperator.Id = 4;
            craneOperator.JobTitle = "Crane Operator";
            craneOperator.FirstName = "Sam";
            craneOperator.LastName = "Drake";
            craneOperator.AnnualSalary = 50000;
            craneOperator.HighestQualification = "Bachelor's Degree";
            craneOperator.Gender = 'm';
            craneOperator.JoinDate = new DateTime(2012, 5, 7);

            employees.Add(craneOperator);

            Employee electrician = new Electrician();

            electrician.Id = 5;
            electrician.JobTitle = "Electrician";
            electrician.FirstName = "James";
            electrician.LastName = "Ross";
            electrician.AnnualSalary = 45000;
            electrician.HighestQualification = "Bachelor's Degree";
            electrician.Gender = 'm';
            electrician.JoinDate = new DateTime(2013, 1, 16);

            employees.Add(electrician);

            Employee electrician2 = new Electrician();

            electrician2.Id = 6;
            electrician2.JobTitle = "Electrician";
            electrician2.FirstName = "Henry";
            electrician2.LastName = "Sanders";
            electrician2.AnnualSalary = 45000;
            electrician2.HighestQualification = "Bachelor's Degree";
            electrician2.Gender = 'm';
            electrician2.JoinDate = new DateTime(2017, 1, 16);

            employees.Add(electrician2);


        }

        private static void Navigation(IList<IEmployee> employees)
        {

            int counter = 0;

            while (true)
            {
                if (counter < 0 || counter > employees.Count - 1)
                {
                    counter = 0;
                }

                WriteEmployeeInformationToScreen(employees[counter]);

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.RightArrow)
                {
                    counter++;
                }
                else if (consoleKey == ConsoleKey.LeftArrow)
                {
                    counter--;
                }
                else if (consoleKey == ConsoleKey.Spacebar)
                {
                    break;
                }


            }
        }

        private static void WriteHeading()
        {
            Console.WriteLine("The Construction Company");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

        private static void WriteEmployeeInformationToScreen(IEmployee employee)
        {
            Console.Clear();
            WriteHeading();

            Console.WriteLine(employee.GetBasicInformation());
        }

    }

}


