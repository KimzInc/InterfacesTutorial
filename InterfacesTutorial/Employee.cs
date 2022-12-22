using System;

namespace InterfacesTutorial
{
    public abstract class Employee : IEmployee
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual decimal AnnualSalary { get; set; }
        public char Gender { get; set; }
        public DateTime JoinDate { get; set; }
        public string HighestQualification { get; set; }


        public virtual string GetBasicInformation()
        {
            return $"Id: {Id}{Environment.NewLine}Job Title: {JobTitle}{Environment.NewLine}First Name: {FirstName}{Environment.NewLine}" +
                $"Last Name: {LastName}{Environment.NewLine}Annual Salary: {AnnualSalary}";
        }

        public int GetFullYearsWorked()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);

            TimeSpan span = DateTime.Now.Subtract(JoinDate);

            int years = zeroTime.Add(span).Year - 1;

            return years;
        }
    }

}


