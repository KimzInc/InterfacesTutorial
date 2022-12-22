namespace InterfacesTutorial
{
    public class CraneOperator : Employee
    {
        private decimal GetDangerPayIncrease()
        {
            return 0.04m;
        }

        public override decimal AnnualSalary { get => base.AnnualSalary + (base.AnnualSalary * GetDangerPayIncrease()); }
    }

}


