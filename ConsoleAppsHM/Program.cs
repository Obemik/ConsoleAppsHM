using System;
using System.Collections.Generic;

class Character
{
    public string Name { get; set; }
    public string Appearance { get; set; }
    public string Weapon { get; set; }
    public int Health { get; set; }

    public Character Clone() 
    {
        return (Character)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Character: {Name}, Appearance: {Appearance}, Weapon: {Weapon}, Health: {Health}";
    }
}

class CharacterBuilder
{
    private Character _character = new Character();

    public CharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public CharacterBuilder SetAppearance(string appearance)
    {
        _character.Appearance = appearance;
        return this;
    }

    public CharacterBuilder SetWeapon(string weapon)
    {
        _character.Weapon = weapon;
        return this;
    }

    public CharacterBuilder SetHealth(int health)
    {
        _character.Health = health;
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}

class CharacterRegistry
{
    private static CharacterRegistry _instance;
    private List<Character> _characters = new List<Character>();

    private CharacterRegistry() { }

    public static CharacterRegistry Instance
    {
        get
        {
            if (_instance == null)
                _instance = new CharacterRegistry();
            return _instance;
        }
    }

    public void RegisterCharacter(Character character)
    {
        if (!_characters.Contains(character))
        {
            _characters.Add(character);
            Console.WriteLine($"Registered: {character}");
        }
        else
        {
            Console.WriteLine($"Character already registered: {character.Name}");
        }
    }

    public void DisplayAllCharacters()
    {
        Console.WriteLine("\nAll Registered Characters:");
        foreach (var character in _characters)
        {
            Console.WriteLine(character);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CharacterBuilder builder = new CharacterBuilder();
        Character hero = builder
            .SetName("Hero")
            .SetAppearance("Tall and strong")
            .SetWeapon("Sword")
            .SetHealth(100)
            .Build();

        Character villain = builder
            .SetName("Villain")
            .SetAppearance("Dark and mysterious")
            .SetWeapon("Magic Staff")
            .SetHealth(120)
            .Build();

        CharacterRegistry registry = CharacterRegistry.Instance;
        registry.RegisterCharacter(hero);
        registry.RegisterCharacter(villain);

        Character clonedVillain = villain.Clone();
        clonedVillain.Name = "Villain Clone";
        registry.RegisterCharacter(clonedVillain);

        registry.DisplayAllCharacters();

        Console.ReadLine();
    }
}