/*
 Austin Stephens
11/05/2022
 *
 * -----------------------------------------------------------------------
Let’s go back to our D&D game program idea. You are now creating the character generator explanation portion. So eventually we want to make our program so that, if the user has no idea what he wants to be, he can select one of the character types and it will explain to them what that character can do.



So, using the abstract class example of the animal, you will create a base-class called characterinfo.
In this class you should have two modules (like in the Dungeon and Dragons style game program that you developed and altered previously):
The introduction module will simply say: “You are looking at the fighter style classes. Be warned, you will be in the thick of all the fighting!”
The second module will be the one you will override – and be used for text. You may Name this how you wish.
Using the abstract class – you should have two derived classes: Fighter and Paladin.
You will override the second module to give more specific details of the fighter and paladin.
Fighter: The fighter is one of the standard classes in Dungeons & Dragons. A fighter is a versatile, weapons-oriented warrior who fights using skill, strategy and tactics. Fighter is a generic and broad class but can be tailored the players ideas.
Paladin: The paladin is a holy knight. Paladins crusade on behalf of their chosen deity and could be either good or evil (anti-paladin). Because the deity grants their powers, they are also considered a limited divine spellcaster.
In the main module you will call both to show that they work (Like in like in the Dungeon and Dragons style game program that you developed and altered previously).

-------------------------------------------------------------

You program must have the following:

An introductory statement that allows the user to understand what type of program they are running.
Abstract Classes/Regular Classes
Variable declarations
User input acceptance
Proper output
You must provide the following:
Your code
Screenshot of your fully functioning program with inputs/outputs
## ---------------------------
*/

using System;


internal class Character
{     
    private string Name;
    private int Age;
    private string CharGen;
    private string CharRace;
    private string CharClass;
    private string NamePlyr;
    private int CharLvl;
    
    public Character()
    {
        Name = "";
        Age = 0;
        NamePlyr = "";
        CharLvl = 0;
        CharGen = "";
        CharRace = "";
        CharClass = "";
    }
    public void setName(string Name)
    {
        this.Name = Name;
    }

    public void setAge(int Age)
    {
        this.Age = Age;
    }

    public void setNamePlyr(string NamePlyr)
    {
        this.NamePlyr = NamePlyr;
    }

    public void setCharLvl(int CharLvl)
    {
        this.CharLvl = CharLvl;
    }

    public void setCharGen(string CharGen)
    {
        this.CharGen = CharGen;
    }

    public void setCharRace(string CharRace)
    {
        this.CharRace = CharRace;
    }

    public void setCharClass(string CharClass)
    {
        this.CharClass = CharClass;
    }

    public string getName()
    {
        return Name;
    }

    public int getAge()
    {
        return Age;
    }

    public string getNamePlyr()
    {
        return NamePlyr;
    }

    public int getCharLvl()
    {
        return CharLvl;
    }

    public string getCharGen()
    {
        return CharGen;
    }

    public string getCharRace()
    {
        return CharRace;
    }

    public string getCharClass()
    {
        return CharClass;
    }

    public void Print()
    {
        Console.WriteLine("Character details:");
        Console.WriteLine("Character Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Player Name: " + NamePlyr);
        Console.WriteLine("CharLvl: " + CharLvl);
        Console.WriteLine("CharGen: " + CharGen);
        Console.WriteLine("CharRace: " + CharRace);
        Console.WriteLine("Character class: " + CharClass);
    }
}

internal class Fighter : Character
{
    private string Deity;
    private string DivineSpell1, DivineSpell2;
    private string HealingTypes;

    public Fighter(string Deity, string DivineSpell1, string DivineSpell2, string HealingTypes)
    {
        this.Deity = Deity;
        this.DivineSpell1 = DivineSpell1;
        this.DivineSpell2 = DivineSpell2;
        this.HealingTypes = HealingTypes;
    }

    public void Print_fighter()
    {
        Console.WriteLine("Fighter details:");
        Console.WriteLine("Deity : " + Deity);
        Console.WriteLine("Divine Spell 1: " + DivineSpell1);
        Console.WriteLine("Divine Spell 2: " + DivineSpell2);
        Console.WriteLine("Types of Healing: " + HealingTypes);
    }
}

internal class Paladin : Character
{
    private string SourcePower;
    private string ArcaneSpell1;
    private string ArcaneSpell2;

    public Paladin(string SourcePower, string ArcaneSpell1, string ArcaneSpell2)
    {
        this.SourcePower = SourcePower;
        this.ArcaneSpell1 = ArcaneSpell1;
        this.ArcaneSpell2 = ArcaneSpell2;
    }
    public void Print_Paladin()
    {
        Console.WriteLine("Fighter details:");
        Console.WriteLine("Source : " + SourcePower);
        Console.WriteLine("Arcane Spell 1: " + ArcaneSpell1);
        Console.WriteLine("Arcane Spell 2: " + ArcaneSpell2);
    }
}

internal class Characters
{
    public static void Main()
    {
        string deity;        
        string divinespell1, divinespell2;   
        string Name, NamePlyr, CharGen, CharRace, CharClass;
        string typesof_healing; 
        int Age, CharLvl;
        Console.Write("Your Name Name: ");
        NamePlyr = Console.ReadLine();
        Console.Write("Your Age: ");
        Age = Int32.Parse(Console.ReadLine());
        Console.Write("Character Name: ");
        Name = Console.ReadLine();
        Console.Write("CharGen: ");
        CharGen = Console.ReadLine();
        Console.Write("Character Level: ");
        CharLvl = Int32.Parse(Console.ReadLine());
        Console.Write("Character Race: ");
        CharRace = Console.ReadLine();
        Console.Write("Character class: ");
        CharClass = Console.ReadLine();
        Character character = new Character();
        character.setCharGen(CharGen);
        character.setCharRace(CharRace);
        character.setName(Name);
        character.setNamePlyr(NamePlyr);
        character.setCharLvl(CharLvl);
        character.setCharClass(CharClass);
        character.setAge(Age);
        character.Print();

                        
        Console.WriteLine("Fighter: ");
        Console.Write("Deity: ");
        deity = Console.ReadLine();
        Console.Write("Divine Spell1: ");
        divinespell1 = Console.ReadLine();
        Console.Write("Divine Spell2: ");
        divinespell2 = Console.ReadLine();
        Console.Write("Type of Healing: ");
        typesof_healing = Console.ReadLine();
        Fighter fight = new Fighter(deity, divinespell1, divinespell2, typesof_healing); 
        fight.Print_fighter();

        string sourceof_power;
        string arcane_spell1; 
        string arcane_spell2; 
        Console.WriteLine("Program to input details of a Paladin: ");
        Console.Write("Source of power;: ");
        sourceof_power = Console.ReadLine();
        Console.Write("Arcane Spell 1: ");
        arcane_spell1 = Console.ReadLine();
        Console.Write("Arcane Spell 2: ");
        arcane_spell2 = Console.ReadLine();
        Paladin paladin = new Paladin(sourceof_power, arcane_spell1, arcane_spell2);

        paladin.Print_Paladin();    

        Console.ReadLine();
    }
}