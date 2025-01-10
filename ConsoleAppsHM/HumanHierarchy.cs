namespace HumanHierarchy
{
    public class Human
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Human(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            if (age <= 0)
                throw new ArgumentException("Age must be greater than 0.");

            Name = name;
            Age = age;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    public class Builder : Human
    {
        public string Specialty { get; private set; }

        public Builder(string name, int age, string specialty) : base(name, age)
        {
            if (string.IsNullOrWhiteSpace(specialty))
                throw new ArgumentException("Specialty cannot be empty.");

            Specialty = specialty;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Specialty: {Specialty}";
        }

        public string BuildHouse()
        {
            return $"{Name} is building a house.";
        }
    }

    public class Sailor : Human
    {
        public string Rank { get; private set; }

        public Sailor(string name, int age, string rank) : base(name, age)
        {
            if (string.IsNullOrWhiteSpace(rank))
                throw new ArgumentException("Rank cannot be empty.");

            Rank = rank;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Rank: {Rank}";
        }

        public string Navigate()
        {
            return $"{Name} is navigating the ship.";
        }
    }

    public class Pilot : Human
    {
        public string Airline { get; private set; }

        public Pilot(string name, int age, string airline) : base(name, age)
        {
            if (string.IsNullOrWhiteSpace(airline))
                throw new ArgumentException("Airline cannot be empty.");

            Airline = airline;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Airline: {Airline}";
        }

        public string FlyPlane()
        {
            return $"{Name} is flying a plane.";
        }
    }
}
