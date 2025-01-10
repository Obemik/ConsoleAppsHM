using System;

namespace StoreNamespace
{
    public class Store
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string ProfileDescription { get; private set; }
        public string ContactPhone { get; private set; }
        public string Email { get; private set; }

        private double _area;
        public double Area
        {
            get => _area;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Area cannot be negative.");
                _area = value;
            }
        }

        public void SetStoreData(string name, string address, string profileDescription, string contactPhone, string email)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(contactPhone) || string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Name, address, contact phone, and email cannot be empty or invalid.");

            Name = name;
            Address = address;
            ProfileDescription = profileDescription;
            ContactPhone = contactPhone;
            Email = email;
        }

        public string GetStoreInfo()
        {
            return $"Store Name: {Name}\n" +
                   $"Address: {Address}\n" +
                   $"Profile Description: {ProfileDescription}\n" +
                   $"Contact Phone: {ContactPhone}\n" +
                   $"Email: {Email}\n" +
                   $"Area: {Area} square meters";
        }

        public static Store operator +(Store store, double additionalArea)
        {
            store.Area += additionalArea;
            return store;
        }

        public static Store operator -(Store store, double reductionArea)
        {
            store.Area -= reductionArea;
            return store;
        }

        public static bool operator ==(Store a, Store b)
        {
            return a?.Area == b?.Area;
        }

        public static bool operator !=(Store a, Store b)
        {
            return !(a == b);
        }

        public static bool operator >(Store a, Store b)
        {
            return a?.Area > b?.Area;
        }

        public static bool operator <(Store a, Store b)
        {
            return a?.Area < b?.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj is Store otherStore)
            {
                return Area == otherStore.Area;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Area.GetHashCode();
        }
    }
}
