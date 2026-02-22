using System;
using System.Collections.Generic;
using System.Linq;

public class Pokemon
{
    public int Dex { get; }
    public string Name { get; }
    public string Type1 { get; }
    public string? Type2 { get; }
    public int Attack { get; }
    public int Defense { get; }
    public int Speed { get; }
    public int Total { get; }
    public bool IsLegendary { get; }

    public Pokemon(int dex, string name, string type1, string? type2,
        int attack, int defense, int speed, int total, bool isLegendary)
    {
        Dex = dex;
        Name = name;
        Type1 = type1;
        Type2 = type2;
        Attack = attack;
        Defense = defense;
        Speed = speed;
        Total = total;
        IsLegendary = isLegendary;
    }
}

class Program
{
    static void Main()
    {
        var pokedex = new List<Pokemon>
        {
            new(  1, "Bulbasaur",  "Grass",  "Poison", 49, 49, 45, 318, false),
            new(  4, "Charmander", "Fire",   null,     52, 43, 65, 309, false),
            new(  7, "Squirtle",   "Water",  null,     48, 65, 43, 314, false),
            new( 25, "Pikachu",    "Electric",null,    55, 40, 90, 320, false),
            new( 39, "Jigglypuff", "Normal", "Fairy",  45, 20, 20, 270, false),
            new( 52, "Meowth",     "Normal", null,     45, 35, 90, 290, false),
            new( 63, "Abra",       "Psychic",null,     20, 15, 90, 310, false),
            new( 92, "Gastly",     "Ghost",  "Poison", 35, 30, 80, 310, false),
            new( 95, "Onix",       "Rock",   "Ground", 45,160, 70, 385, false),
            new(129, "Magikarp",   "Water",  null,     10, 55, 80, 200, false),
            new(131, "Lapras",     "Water",  "Ice",    85, 80, 60, 535, false),
            new(133, "Eevee",      "Normal", null,     55, 50, 55, 325, false),
            new(143, "Snorlax",    "Normal", null,    110, 65, 30, 540, false),
            new(149, "Dragonite",  "Dragon", "Flying",134, 95, 80, 600, false),
            new(150, "Mewtwo",     "Psychic",null,    110, 90,130, 680, true),
            new(151, "Mew",        "Psychic",null,    100,100,100, 600, true),
            new(245, "Suicune",    "Water",  null,     75,115, 85, 580, true),
            new(248, "Tyranitar",  "Rock",   "Dark",  134,110, 61, 600, false),
            new(384, "Rayquaza",   "Dragon", "Flying",150, 90, 95, 680, true),
            new(445, "Garchomp",   "Dragon", "Ground",130, 95,102, 600, false),
        };

        // =====================================================
        // A. FILTERING (Where)
        // =====================================================

        // Returns IEnumerable<Pokemon>
        var waterTypes = pokedex.Where(p => p.Type1 == "Water");
        foreach (var p in waterTypes) Console.WriteLine(p.Name);

        // Returns IEnumerable<Pokemon>
        var legendaries = pokedex.Where(p => p.IsLegendary);
        foreach (var p in legendaries) Console.WriteLine(p.Name);

        // Returns IEnumerable<Pokemon>
        var fastPokemon = pokedex.Where(p => p.Speed >= 90);
        foreach (var p in fastPokemon) Console.WriteLine(p.Name);

        // Returns IEnumerable<Pokemon>
        var lowTotal = pokedex.Where(p => p.Total < 320);
        foreach (var p in lowTotal) Console.WriteLine(p.Name);

        // Returns IEnumerable<Pokemon>
        var dualType = pokedex.Where(p => p.Type2 != null);
        foreach (var p in dualType) Console.WriteLine(p.Name);

        // =====================================================
        // B. PROJECTION (Select)
        // =====================================================

        // Returns IEnumerable<string>
        var names = pokedex.Select(p => p.Name);
        foreach (var n in names) Console.WriteLine(n);

        // Returns IEnumerable<int>
        var dexNumbers = pokedex.Select(p => p.Dex);
        foreach (var d in dexNumbers) Console.WriteLine(d);

        // Returns IEnumerable<string>
        var primaryTypes = pokedex.Select(p => p.Type1);
        foreach (var t in primaryTypes) Console.WriteLine(t);

        // =====================================================
        // C. FILTER + PROJECT (Where → Select)
        // =====================================================

        // Returns IEnumerable<string>
        var strongNames = pokedex
            .Where(p => p.Attack >= 120)
            .Select(p => p.Name);
        foreach (var n in strongNames) Console.WriteLine(n);

        // Returns IEnumerable<string>
        var dragonNames = pokedex
            .Where(p => p.Type1 == "Dragon")
            .Select(p => p.Name);
        foreach (var n in dragonNames) Console.WriteLine(n);

        // Returns IEnumerable<string>
        var fastDisplay = pokedex
            .Where(p => p.Speed >= 90)
            .Select(p => $"{p.Name} - {p.Speed}");
        foreach (var s in fastDisplay) Console.WriteLine(s);

        // Returns IEnumerable<string>
        var strongWater = pokedex
            .Where(p => p.Type1 == "Water" && p.Total >= 500)
            .Select(p => p.Name);
        foreach (var n in strongWater) Console.WriteLine(n);

        // =====================================================
        // D. READ THE QUERY (Explain)
        // =====================================================

        var q1 = pokedex.Where(p => p.Total >= 600);
        // Filters Pokémon with Total >= 600
        // Returns IEnumerable<Pokemon>

        var q2 = pokedex.Select(p => p.Type1);
        // No filtering
        // Returns IEnumerable<string> (Type1 values)

        var q3 = pokedex.Where(p => p.Type2 != null).Select(p => p.Name);
        // Filters Pokémon with a second type
        // Returns IEnumerable<string> (names only)
    }
}