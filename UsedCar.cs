using System;

namespace CarLibrary
{
    public class UsedCar : Car
    {
        public int Mileage { get; set; }
        public string Condition { get; set; }

        public UsedCar(string brand, int year, string vin, CarBodyType bodyType, int mileage, string condition)
            : base(brand, year, vin, bodyType)
        {
            Mileage = mileage;
            Condition = condition;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            return new string[]
            {
                baseInfo[0],
                baseInfo[1],
                $"Подержанное авто. Пробег: {Mileage} км",
                $"Состояние: {Condition}"
            };
        }
    }
}