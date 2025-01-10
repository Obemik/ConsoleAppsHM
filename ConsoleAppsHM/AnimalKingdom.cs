namespace AnimalKingdom
{
    public class Animal
    {
        public string Name { get; private set; }
        public string Habitat { get; private set; }
        public string Diet { get; private set; }

        public Animal(string name, string habitat, string diet)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            if (string.IsNullOrWhiteSpace(habitat))
                throw new ArgumentException("Habitat cannot be empty.");
            if (string.IsNullOrWhiteSpace(diet))
                throw new ArgumentException("Diet cannot be empty.");

            Name = name;
            Habitat = habitat;
            Diet = diet;
        }

        public virtual string GetDescription()
        {
            return $"Name: {Name}, Habitat: {Habitat}, Diet: {Diet}";
        }
    }

    public class Tiger : Animal
    {
        public string StripeColor { get; private set; }

        public Tiger(string name, string habitat, string diet, string stripeColor)
            : base(name, habitat, diet)
        {
            if (string.IsNullOrWhiteSpace(stripeColor))
                throw new ArgumentException("Stripe color cannot be empty.");
            StripeColor = stripeColor;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $", Stripe Color: {StripeColor}";
        }

        public string Roar()
        {
            return $"{Name} lets out a powerful roar!";
        }
    }

    public class Crocodile : Animal
    {
        public double Length { get; private set; }

        public Crocodile(string name, string habitat, string diet, double length)
            : base(name, habitat, diet)
        {
            if (length <= 0)
                throw new ArgumentException("Length must be greater than zero.");
            Length = length;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $", Length: {Length} meters";
        }

        public string Swim()
        {
            return $"{Name} swims stealthily through the water.";
        }
    }

    public class Kangaroo : Animal
    {
        public double JumpHeight { get; private set; }

        public Kangaroo(string name, string habitat, string diet, double jumpHeight)
            : base(name, habitat, diet)
        {
            if (jumpHeight <= 0)
                throw new ArgumentException("Jump height must be greater than zero.");
            JumpHeight = jumpHeight;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $", Jump Height: {JumpHeight} meters";
        }

        public string Jump()
        {
            return $"{Name} jumps {JumpHeight} meters high!";
        }
    }
}
