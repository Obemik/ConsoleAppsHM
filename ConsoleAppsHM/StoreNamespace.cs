namespace StoreNamespace
{
    public class Store
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string ProfileDescription { get; private set; }
        public string ContactPhone { get; private set; }
        public string Email { get; private set; }

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
                   $"Email: {Email}";
        }

        public string GetName() => Name;
        public string GetAddress() => Address;
        public string GetProfileDescription() => ProfileDescription;
        public string GetContactPhone() => ContactPhone;
        public string GetEmail() => Email;
    }
}