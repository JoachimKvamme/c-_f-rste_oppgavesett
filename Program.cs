﻿using System.Security.Cryptography.X509Certificates;

namespace c__første_oppgavesett;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Oppgave 1 var å lage selve c#-prosjektet.
        // Oppgave 2
        int myNumber = 1;
        string myString = "Hei hei";
        double myDouble = 3.14;
        char myChar = 'A';
        int[] myNumberArray = {1, 2, 3, 4};
        string[] myStringArray = {"Hei", "hallo", "hadetbra"};

        // Skriver ut verdiene i myNumberArray med en for-løkke.
        for (int i = 0; i < myNumberArray.Length; i++)
        {
            Console.WriteLine(myNumberArray[i]);
        }

        // Skriver ut verdiene i myStringArray med en foreach-løkke, for å vise at det også er mulig.

        foreach (string item in myStringArray)
        {
            Console.WriteLine(item);
        }

        List<string> myListOfStrings = new List<string>();

        myListOfStrings.Add("string");
        myListOfStrings.Add("Enda en");
        myListOfStrings.Add("Hadetbra");

        foreach (string item in myListOfStrings)
        {
            Console.WriteLine(item);
            
        }

        // Oppgave 3, ekstraoppgaver

        Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        myDictionary.Add(1, "en");
        myDictionary.Add(2, "to");
        myDictionary.Add(3, "tre");
        myDictionary.Add(4,"fire");

        foreach (var item in myDictionary)
        {
            Console.WriteLine(item);
        }

        myAdditionMethod(5, 5);
        myWelcomeMessage("Jørgen");

    }

    // Metode som legger sammen to tall og skriver dem til konsollen.
    static void myAdditionMethod(int a, int b) {
        Console.WriteLine(a + b);
    }
    // Metode som tar en string, helst et navn, og skriver en hilsen i konsollen.
    static void myWelcomeMessage(string name) {
        Console.WriteLine("Heihei " + name + "!");
    }
}
