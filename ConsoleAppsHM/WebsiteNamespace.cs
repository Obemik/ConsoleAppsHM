namespace WebsiteNamespace
{
    public class Website
    {
        public string Name { get; private set; }
        public string Url { get; private set; }
        public string Description { get; private set; }
        public string IpAddress { get; private set; }

        public void SetWebsiteData(string name, string url, string description, string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(ipAddress))
                throw new ArgumentException("Name, URL and IP address cannot be empty.");

            Name = name;
            Url = url;
            Description = description;
            IpAddress = ipAddress;
        }

        public string GetWebsiteInfo()
        {
            return $"Website Name: {Name}\n" +
                   $"URL: {Url}\n" +
                   $"Description: {Description}\n" +
                   $"IP Address: {IpAddress}";
        }

        public string GetName() => Name;
        public string GetUrl() => Url;
        public string GetDescription() => Description;
        public string GetIpAddress() => IpAddress;
    }
}