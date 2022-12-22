using System;

namespace InterfacesTutorial
{
    public abstract class Manager : Employee, IManager
    {
        public string OfficeId { get; set; }
        public int SecretaryId { get; set; }

        public override string GetBasicInformation()
        {
            return base.GetBasicInformation() + $"{Environment.NewLine}Office Id: {OfficeId}{Environment.NewLine}Secretary Id: {SecretaryId}";
        }
    }

}


