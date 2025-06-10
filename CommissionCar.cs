using CarLib1;
using CarLib1;

namespace CarLibrary
{
    public class CommissionCar : UsedCar
    {
        public CarBodyType BodyType { get; }
        public string OwnerFullName { get; set; }
        public string OwnerAddress { get; set; }
        public string ContractNumber { get; set; }

        public CommissionCar(string brand, int year, string vin, CarBodyType bodyType,
                           int mileage, string condition,
                           string ownerFullName, string ownerAddress, string contractNumber)
            : base(brand, year, vin, bodyType, mileage, condition)
        {
            BodyType = bodyType;
            OwnerFullName = ownerFullName;
            OwnerAddress = ownerAddress;
            ContractNumber = contractNumber;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            return new string[]
            {
                baseInfo[0],
                baseInfo[1],
                baseInfo[2],
                baseInfo[3],
                $"Комиссионный авто. Владелец: {OwnerFullName}",
                $"Адрес: {OwnerAddress}",
                $"Договор №: {ContractNumber}"
            };
        }
    }
}