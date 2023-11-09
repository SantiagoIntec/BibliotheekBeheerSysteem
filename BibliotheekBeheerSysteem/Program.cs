using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheekBeheerSysteem
{
    internal class Program 
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] boekTitels = new string[] { "Deep work", "Odisea", "Learn C# in One Day and Learn It Well" };
            string[] boekAuteurs = new string[] { "Cal Newportk", "Homero", "Jamie Chan" };
            string[] tijdschriftNamen = new string[] { "Paris Match", "Fashion", "Technology Magazine" };
            string[] gebruikers = new string[] { "Administrator", "User", "Guess" };
            string[] lenenBoek = new string[] { };
            string[] lenentijdschriftNamen = new string[] { };
            Boolean logged = false;
            string user ="";             

            ShowMenu(ref boekTitels, ref boekAuteurs, ref tijdschriftNamen, ref gebruikers, ref lenenBoek, ref lenentijdschriftNamen, ref logged, ref user);

        }

        private static string toonMateriaalAllen(string user, string materiaalNaam)
        {
            int pos = 0;
            for (int i = 0; i < materiaalNaam.Length; i++)
            {
                if (materiaalNaam[i].ToString() == "+") { pos = i; break; }


            }

            String newStr = materiaalNaam.Remove(pos, user.Length + 1);
            
            return newStr;

            Console.ReadLine();
        }

        private static void TerugbrengenMateriaal(ref string[] boekTitels, ref string[] tijdschriftNamen, ref string[] lenenBoek, ref string[] lenentijdschriftNamen, ref string user)
        {
            string verwijderd;
            string textVerwijderd;
            int index;
            string materiaal;
      

            Console.SetCursorPosition(25, 10);
            Console.WriteLine($"Een materiaal terugbrengen");
            Console.SetCursorPosition(5, 11);
            Console.WriteLine("Lenen BoekTitels");

            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Lenen TijdschriftNamen");
            int itemsLenenboek = lenenBoek.Length;
            int itemsTijdschr = lenentijdschriftNamen.Length;
            if (itemsTijdschr > itemsLenenboek) { itemsLenenboek = itemsTijdschr; }

            //for (int i = 0; i < lenenBoek.Length; i++)
            for (int i = 0; i < itemsLenenboek; i++)
            {
                Console.SetCursorPosition(5, 12 + i);
                if (lenenBoek.Count() == 0) { Console.WriteLine(""); }
                else 
                {
                    materiaal = toonMateriaalAllen(user, lenenBoek[i]);
                    Console.WriteLine($" ({i}) {materiaal} uitgeleend aan {user} ");                     
                }

                //for (int j = 0; j < lenentijdschriftNamen.Length; j++)
                for (int j = 0; j < itemsTijdschr; j++)
                {
                    Console.SetCursorPosition(50, 12 + j);
                    if (lenentijdschriftNamen.Count() == 0) { Console.WriteLine(""); }
                    else
                    {
                        materiaal = toonMateriaalAllen(user, lenentijdschriftNamen[j]);
                        Console.WriteLine($" ({itemsTijdschr + j}) {materiaal} uitgeleend aan {user}");
                    }
                }

            }
            Console.Write($"\n Voer het nummer in dat overeenkomt met de mateiral die je wilt opnemen. ==>  ");
            verwijderd = Console.ReadLine();

            if (int.Parse(verwijderd) <= (lenentijdschriftNamen.Length + lenenBoek.Length))
            {
                if (int.Parse(verwijderd) > lenentijdschriftNamen.Length || lenenBoek.Count() == 0)
                {
                    if (lenentijdschriftNamen.Count() == 0)
                    {
                        index = 0;
                    }
                    else
                    {
                        index = int.Parse(verwijderd) - lenentijdschriftNamen.Length;
                    }
                    
                    //textVerwijderd = lenentijdschriftNamen[index];
                    textVerwijderd = toonMateriaalAllen(user, lenentijdschriftNamen[index]);

                    // add the material selected to tijdschriftNamen
                    Array.Resize(ref tijdschriftNamen, tijdschriftNamen.Length + 1);
                    tijdschriftNamen.SetValue(textVerwijderd, tijdschriftNamen.Length - 1);
                    // delete the material selected from lenentijdschriftNamen
                    lenentijdschriftNamen = lenentijdschriftNamen.Where(val => val != textVerwijderd).ToArray();
                    Console.WriteLine($"\n het materiaal geleend: {toonMateriaalAllen(user, textVerwijderd)}");
                    Console.ReadLine();
                }
                else
                {
                    index = int.Parse(verwijderd);
                    textVerwijderd = lenenBoek[index];

                    // add the material selected to lenen book
                    Array.Resize(ref boekTitels, boekTitels.Length + 1);
                    boekTitels.SetValue(textVerwijderd, boekTitels.Length - 1);
                     
                    // add the material selected to lenen book

                    lenenBoek = lenenBoek.Where(val => val != textVerwijderd).ToArray();
                    Console.WriteLine($"\n het materiaal geleend: {toonMateriaalAllen(user,textVerwijderd)}");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Voer een geldig nummer in, probeer opnieuw!!!!");
                Console.ReadLine();
            }
        }

        private static void LenenBoek(ref string[] boekTitels, ref string[] tijdschriftNamen, ref string[] lenenBoek, ref string[] lenentijdschriftNamen, ref string  user)
        {
            string verwijderd;
            string textLenen;
            int index;
            Console.Clear();
            Console.SetCursorPosition(25, 10);
            Console.WriteLine($"Lenen een materiaal");
            Console.SetCursorPosition(5, 11);
            Console.WriteLine("BoekTitels");

            Console.SetCursorPosition(50, 11);
            Console.WriteLine("TijdschriftNamen");

            for (int i = 0; i < boekTitels.Length; i++)
            {
                Console.SetCursorPosition(5, 12 + i);
                Console.WriteLine($" ({i}) {boekTitels[i]}");

                for (int j = 0; j < tijdschriftNamen.Length; j++)
                {

                    Console.SetCursorPosition(50, 12 + j);
                    Console.WriteLine($" ({tijdschriftNamen.Length + j}) {tijdschriftNamen[j]}");
                }

            }
            Console.Write($"\n Voer het nummer in dat overeenkomt met de mateiral die je wilt opnemen. ==>  ");
            verwijderd = Console.ReadLine();

            if (int.Parse(verwijderd) <= (tijdschriftNamen.Length + boekTitels.Length))
            {
                if (int.Parse(verwijderd) >= boekTitels.Length)
                {
                    index = int.Parse(verwijderd) - tijdschriftNamen.Length;
                    textLenen = tijdschriftNamen[index];

                    // add the material selected to lenentijdschriftNamen
                    Array.Resize(ref lenentijdschriftNamen, lenentijdschriftNamen.Length + 1);
                    lenentijdschriftNamen.SetValue(textLenen + "+" + user, lenentijdschriftNamen.Length - 1);
                    // delete the material from tijdschriftNamen
                    tijdschriftNamen = tijdschriftNamen.Where(val => val != textLenen).ToArray();
                    Console.WriteLine($"\n het materiaal geleend: {textLenen}");
                    
                }
                else
                {
                    index = int.Parse(verwijderd);
                    textLenen = boekTitels[index];

                    // add the material selected to lenen book
                    Array.Resize(ref lenenBoek, lenenBoek.Length + 1);
                    lenenBoek.SetValue(textLenen + "+" + user, lenenBoek.Length - 1);                    
                    //Console.ReadLine();
                    // add the material selected to lenen book

                    boekTitels = boekTitels.Where(val => val != textLenen).ToArray();
                    Console.WriteLine($"\n het materiaal geleend: {textLenen}");
                    
                }
            }
            else
            {
                Console.WriteLine("Voer een geldig nummer in, probeer opnieuw!!!!");
                //Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static string[] RegistreerGebruiker(string[] gebruikers, string user)
        {
            if (!gebruikers.Contains(user))
            {
                Array.Resize(ref gebruikers, gebruikers.Length + 1);
                gebruikers.SetValue(user, gebruikers.Length - 1);
                Console.WriteLine($"Welcome  {user}");
            }
            else
            {
                Console.WriteLine("De gebruiker bestaat al, probeer het opnieuw");
            }

            //for (int i = 0; i < gebruikers.Length; i++)
            //{
            //    Console.WriteLine(gebruikers[i]); 
            //}

            return gebruikers;
        }

        private static void ZoekMateriaal(string[] boekTitels, string[] tijdschriftNamen)
        {
            string zoekText;
            Console.Write($"\n voer de naam in van het materiaal waarnaar u wilt zoeken: ");
            zoekText = Console.ReadLine();

            if (boekTitels.Contains(zoekText) || tijdschriftNamen.Contains(zoekText))
            {
                Console.WriteLine($"\n Gevonden materiaal!!! : {zoekText}");
            }
            else
            {
                Console.WriteLine($"\n sorry materiaal NIET gevonden : {zoekText}");
            }
        }

        private static void VerwijderMateriaal(ref string[] boekTitels, ref string[] tijdschriftNamen)
        {
            string verwijderd;
            string textVerwijderd;
            int index;
             
            Console.SetCursorPosition(5, 11);
            Console.WriteLine("BoekTitels");

            Console.SetCursorPosition(50, 11);
            Console.WriteLine("TijdschriftNamen");

            for (int i = 0; i < boekTitels.Length; i++)
            {
                Console.SetCursorPosition(5, 12 + i);
                Console.WriteLine($" ({i}) {boekTitels[i]}");

                for (int j = 0; j < tijdschriftNamen.Length; j++)
                {

                    Console.SetCursorPosition(50, 12 + j);
                    Console.WriteLine($" ({tijdschriftNamen.Length + j}) {tijdschriftNamen[j]}");
                }

            }
            Console.Write($"\n Voer het nummer in dat overeenkomt met de mateiral die verwijderd moet worden ==>  ");
            verwijderd = Console.ReadLine();

            if (int.Parse(verwijderd) <= (tijdschriftNamen.Length + boekTitels.Length))
            {
                if (int.Parse(verwijderd) >= boekTitels.Length)
                {
                    index = int.Parse(verwijderd) - tijdschriftNamen.Length;
                    textVerwijderd = tijdschriftNamen[index];
                    tijdschriftNamen = tijdschriftNamen.Where(val => val != textVerwijderd).ToArray();
                    Console.WriteLine($"\n het materiaal verwijderd: {textVerwijderd}");
                    Console.ReadLine();
                }
                else
                {
                    index = int.Parse(verwijderd);
                    textVerwijderd = boekTitels[index];
                    boekTitels = boekTitels.Where(val => val != textVerwijderd).ToArray();
                    Console.WriteLine($"\n het materiaal verwijderd: {textVerwijderd}");
                    //Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Voer een geldig nummer in, probeer opnieuw!!!!");
                //Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void VoegMateriaalToe(ref string[] boekTitels, ref string[] boekAuteurs, ref string[] tijdschriftNamen)
        {
            Console.Clear();
            string titel;
            string auteur;
            bool isBoek = false;
            string jaofnee;

            Console.WriteLine("Nieuw materiaal");
            Console.Write("Titel: ");
            titel = Console.ReadLine();

            Console.Write("auteur:");
            auteur = Console.ReadLine();

            Console.Write(" Is een boeak? [J/N]: ");
            jaofnee = Console.ReadLine();

            if (jaofnee.ToLower() == "j") { isBoek = true; }

            if (isBoek)
            {
                Array.Resize(ref boekTitels, boekTitels.Length + 1);
                boekTitels.SetValue(titel, boekTitels.Length - 1);
            }
            else
            {
                Array.Resize(ref tijdschriftNamen, tijdschriftNamen.Length + 1);
                tijdschriftNamen.SetValue(titel, tijdschriftNamen.Length - 1);
            }

            Array.Resize(ref boekAuteurs, boekAuteurs.Length + 1);
            boekAuteurs.SetValue(auteur, boekAuteurs.Length - 1);
        }

        private static void ToonMaterialen(string[] boekTitels, string[] tijdschriftNamen)
        {

            Console.SetCursorPosition(5, 11);
            Console.WriteLine($"boekTitels");

            Console.SetCursorPosition(50, 11);
            Console.WriteLine($"tijdschriftNamen");

            for (int i = 0; i < boekTitels.Length; i++)
            {
                Console.SetCursorPosition(5, 13 + i);
                Console.WriteLine(boekTitels[i]);

                for (int j = 0; j < tijdschriftNamen.Length; j++)
                {
                     
                    Console.SetCursorPosition(50, 13 + j);
                    Console.WriteLine(tijdschriftNamen[j]);
                    //break;
                }
            }
        }

        private static void ShowMenu(ref string[] boekTitels, ref string[] boekAuteurs, ref string[] tijdschriftNamen, ref string[] gebruikers, ref string[] lenenBoek, ref string[] lenentijdschriftNamen, ref Boolean logged, ref string user)
        {
            string option;
            int num;

            do
            {
                if (logged) 
                { Console.SetCursorPosition(80, 1); 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" Gebruiker ==> : {user}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.WriteLine($"Menu");
                }
                
                Console.WriteLine("[0] materialen tonen");
                Console.WriteLine("[1] materiaal toevoegen");
                Console.WriteLine("[2] materiaal verwijderen");
                Console.WriteLine("[3] Mmateriaal zoeken");
                Console.WriteLine("[4] nieuwe gebruiker registreren");
                Console.WriteLine("[5] Lenen een materiaael");
                Console.WriteLine("[6] Terugbrengen een materiaal");
                Console.WriteLine("[7] Exit");
                Console.Write("Kies een nummer: ");
                option = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                if (!Int32.TryParse(option, out num)) continue;

                switch (num)
                {
                    case 0:
                        ToonMaterialen(boekTitels, tijdschriftNamen);
                        EndCase();                        
                        break;
                    case 1:
                        if (!logged)
                        {
                            logged = CheckUser(gebruikers, logged, user);
                        }
                        else
                        {
                            VoegMateriaalToe(ref boekTitels, ref boekAuteurs, ref tijdschriftNamen);
                            ToonMaterialen(boekTitels, tijdschriftNamen);
                            EndCase();
                        }

                        Console.ReadLine();
                        break;
                    case 2:
                        VerwijderMateriaal(ref boekTitels, ref tijdschriftNamen);
                        Console.Clear();
                        ToonMaterialen(boekTitels, tijdschriftNamen);
                        EndCase();
                        break;
                    case 3:
                        ZoekMateriaal(boekTitels, tijdschriftNamen);
                        EndCase();
                        break;
                    case 4:
                        string naam;
                        Console.Write("Voer de naam van de nieuwe gebruiker in: ");
                        user = Console.ReadLine();
                        gebruikers = RegistreerGebruiker( gebruikers, user);
                        EndCase();
                        break;
                    case 5:
                        if (!logged)
                        {
                            //Console.WriteLine(user);
                            logged = CheckUser(gebruikers, logged, user);
                        }
                        else
                        {
                            LenenBoek(ref boekTitels, ref tijdschriftNamen, ref lenenBoek, ref lenentijdschriftNamen, ref user);
                            EndCase();
                        }
                        break;
                    case 6:
                        if (!logged)
                        {
                            logged = CheckUser(gebruikers, logged, user);
                        }
                        else
                        {
                            TerugbrengenMateriaal(ref boekTitels, ref tijdschriftNamen, ref lenenBoek, ref lenentijdschriftNamen, ref user);
                            EndCase();
                        }
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.Clear();
            } while (true);

            

        }

        private static bool CheckUser(string[] gebruikers, bool logged, string user)
        {
            Console.Write("Je moet eerst inloggen ==> Login : ");
            string naam = Console.ReadLine();
            if (gebruikers.Contains(naam))
            {
                Console.WriteLine($"Welcome : {naam} nu bent u ingelogd in het systeem ");
                user = naam;
                logged = true;
            }
            else
            {
                Console.WriteLine($"De gebruiker {naam} bestaat niet, Gebruik optie 4 om een ​​nieuwe gebruiker aan te maken.");
            }

            return logged;
        }

        private static void EndCase()
        {
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}
