using CarLib1;

namespace CarLib1
{
    public class NewCar : Car
    {
        public string Manufacturer { get; set; }
        public int WarrantyMonths { get; set; }

        public NewCar(string brand, int year, string vin, CarBodyType bodyType,
                     string manufacturer, int warrantyMonths)
            : base(brand, year, vin, bodyType)
        {
            Manufacturer = manufacturer;
            WarrantyMonths = warrantyMonths;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            return new string[]
            {
                baseInfo[0],
                baseInfo[1],
                $"Новое авто. Производитель: {Manufacturer}",
                $"Гарантия: {WarrantyMonths} мес."
            };
        }
    }
}