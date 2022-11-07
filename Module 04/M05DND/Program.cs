/*
 Austin Stephens
10-31-2022
 *
 * -----------------------------------------------------------------------
#
Let’s go back to our D&D game program idea. You are now creating the character generator explanation portion. So eventually we want to make our program so that, if the user has no idea what he wants to be, he can select one of the character types and it will explain to them what that character can do.

So, using the abstract class example of the animal, you will create a base-class called characterinfo.
In this class you should have two modules (like in the Dungeon and Dragons style game program that you developed and altered previously):
The introduction module will simply say: “You are looking at the fighter style classes. Be warned, you will be in the thick of all the fighting!”
The second module will be the one you will override – and be used for text. You may name this how you wish.
Using the abstract class – you should have two derived classes: Fighter and Paladin.
You will override the second module to give more specific details of the fighter and paladin.
Fighter: The fighter is one of the standard classes in Dungeons & Dragons. A fighter is a versatile,
weapons-oriented warrior who fights using skill, strategy and tactics. Fighter is a generic and broad class but can be tailored the players ideas.
Paladin: The paladin is a holy knight. Paladins crusade on behalf of their chosen deity and could be either good or evil (anti-paladin).
Because the deity grants their powers, they are also considered a limited divine spellcaster.
-------------------------------------------------------------

In the main module you will call both to show that they work (Like in like in the Dungeon and Dragons style game program that you developed and altered previously).

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
using System.Data;
using System.Reflection.Metadata.Ecma335;

internal class Characters
{
    private string CharGen;
    private string CharRac;
    private string CharClass;
    private string NameC;
    private int AgeC;
    private string playerNameC;
    private int LevelChar;

    public void Character()
    {
        NameC = "";
        AgeC = 0;
        playerNameC = "";
        LevelChar = 0;
        CharGen = "";
        CharRac = "";
        CharClass = "";
    }

    public void PrintSaying()
    {
        Console.WriteLine("Parent Class");
    }

    public string getCharClass()
    {
        return CharClass;
    }

    public void setCharClass(string CharClass)
    {
        this.CharClass = CharClass;
    }

    public int getLevelChar()
    {
        return LevelChar;
    }

    public string getCharGen()
    {
        return CharGen;
    }

    public void setNameC(string NameC)
    {
        this.NameC = NameC;
    }

    public void setAgeC(int AgeC)
    {
        this.AgeC = AgeC;
    }

    public string getCharRac()
    {
        return CharRac;
    }

    public void setLevelChar(int LevelChar)
    {
        this.LevelChar = LevelChar;
    }

    public void setCharGen(string CharGen)

    {
        this.CharGen = CharGen;
    }

    public void setCharRac(string CharRac)

    {
        this.CharRac = CharRac;
    }

    public void setPlayerNameC(string playerNameC)

    {
        this.playerNameC = playerNameC;
    }

    public string getNameC()
    {
        return NameC;
    }

    public int getAgeC()
    {
        return AgeC;
    }

    public string getPlayerNameC()
    {
        return playerNameC;
    }

    public void Output()
    {
        Console.WriteLine("Character details: ");
        Console.WriteLine("Character Name: " + NameC);
        Console.WriteLine("Age: " + AgeC);
        Console.WriteLine("Player Name: " + playerNameC);
        Console.WriteLine("Level of Character: " + LevelChar);
        Console.WriteLine("CharGen: " + CharGen);
        Console.WriteLine("Race of Character: " + CharRac);
        Console.WriteLine("Character Class: " + CharClass);
    }
}

internal class Fighter : Characters
{
    private string Deity = "";
    public string DivineSpell1 = "";
    public string DivineSpell2 = "";
    public string HealType = "";
    private string IntroCharacterInfo = "";
    private string CharacterInfo = "";

    public Fighter()
    {
        Console.WriteLine("This is the fighter style classes. Be warned, you will be in the thick of all the fighting!");
    }
}

internal class Wizard : Characters
{
    private string SourcePower = "";
    private string ArcaneSpell1 = "";
    private string ArcaneSpell2 = "";
    private string CharacterInfo = "";
    private string IntroCharacterInfo = "";

    public Wizard()
    {
        Console.WriteLine("Wizard class contains much magic but low stats");
    }
}

internal class Mainn
{
    private static void Main()
    {
        int i = 0;
        string NameC,
            playerNameC, CharGen, CharRac, CharClass;
        int AgeC, LevelChar;

        string
        string[] WizardSources = new string[] { "Orbs", "Lava", "Mist" };

        Console.WriteLine("+---- Character Menu -----+");
        Console.Write("Your Name: ");
        playerNameC = Console.ReadLine();

        Clear();
        Console.WriteLine("+---- Character Menu -----+");
        Console.Write("Your Age: ");
        AgeC = Convert.ToInt32(Console.ReadLine());

        while (AgeC < 18)
        {
            Console.Write("You Must Be 18 Years or older to play\n");
            AgeC = Convert.ToInt32(Console.ReadLine());
        }

        Clear();
        Console.WriteLine("+---- Character Menu -----+");
        Console.Write("Enter Character Name: ");
        NameC = Console.ReadLine();

        Clear();
        Console.WriteLine("+---- Character Menu -----+");
        Console.Write("Enter Character Level");
        LevelChar = Convert.ToInt32(Console.ReadLine());

        Clear();
        Console.WriteLine("+---- Character Menu -----+");
        Console.Write("Enter Character Race: ");
        CharRac = Console.ReadLine();

        Clear();
        Console.WriteLine("+---- Character Menu -----+");
        Console.WriteLine("Please Choose Class: ");

        Console.Write("Please Choose A Class ");
        //foreach (var VARIABLE in WizardSources)
        // {
        //  i++;
        //   Console.WriteLine(i + VARIABLE);
        // }
        CharClass = Console.ReadLine();

        Characters character = new Characters();
        //character.PrintSaying();
        Console.ReadLine();

        character.setNameC(NameC);
        character.setPlayerNameC(playerNameC);
        character.setAgeC(AgeC);
        character.setCharClass(CharClass);
        character.setCharRac(CharRac);
        character.setLevelChar(LevelChar);
        character.Output();

        void Clear()
        {
            Console.Clear();
        }
    }
}