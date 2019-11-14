using System;
namespace bankOfSimba.Models
{
    public class BankAccount
    {

        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount(string name, double balance, string animalType, bool isKing, bool isGood)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
            IsGood = isGood;
        }
    }
}
