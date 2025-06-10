using System;

namespace ConsigmentStruct
{
    public struct Consigment
    {
        private int _quantity;
        private double _price;

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество не может быть отрицательным");
                _quantity = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Цена не может быть отрицательной");
                _price = Math.Round(value, 2); 
            }
        }

        public double Cost => Math.Round(Quantity * Price, 2);

        public Consigment(int quantity, double price) : this()
        {
            Quantity = quantity;
            Price = price;
        }

        public override string ToString() => $"{Quantity} шт. по {Price:F2} руб.";

        public override bool Equals(object obj)
        {
            if (obj is Consigment other)
                return Quantity == other.Quantity && Price == other.Price;
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Quantity.GetHashCode();
                hash = hash * 23 + Price.GetHashCode();
                return hash;
            }
        }

        public static Consigment operator +(Consigment left, Consigment right)
        {
            if (left.Price != right.Price)
                throw new InvalidOperationException("Нельзя складывать партии с разной ценой");
            return new Consigment(left.Quantity + right.Quantity, left.Price);
        }

        public static Consigment operator -(Consigment left, Consigment right)
        {
            if (left.Price != right.Price)
                throw new InvalidOperationException("Нельзя вычитать партии с разной ценой");
            if (right.Quantity > left.Quantity)
                throw new InvalidOperationException("Количество вычитаемой партии больше исходной");
            return new Consigment(left.Quantity - right.Quantity, left.Price);
        }
    }
}