using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheekBeheerSysteem
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string[] boekTitels = new string[] { "Deep work", "Odisea", "Learn C# in One Day and Learn It Well" };
            string[] boekAuteurs = new string[] { "Cal Newportk", "Homero", "Jamie Chan" };
            string[] tijdschriftNamen = new string[] { "Paris Match", "Fashion", "Technology Magazine" };
            string[] gebruikers = new string[] { "Administrator", "User", "Guess" };
            string[] lenenBoek = new string[] {};
            string[] lenentijdschriftNamen = new string[] {};
            string[] buffer;
            ConsoleKeyInfo keyinfo;


            ShowMenu(ref boekTitels, ref boekAuteurs, ref tijdschriftNamen, ref gebruikers, ref lenenBoek, ref lenentijdschriftNamen);

            //string verwijderd;
            //string textVerwijderd;
            //int index;
            //bool result;
            //Console.WriteLine("Terugbrengen een materieel: ");
            //Console.SetCursorPosition(5, 8);
            //Console.WriteLine("BoekTitels");

            //Console.SetCursorPosition(50, 8);
            //Console.WriteLine("TijdschriftNamen");

            //for (int i = 0; i < boekTitels.Length; i++)
            //{
            //    Console.SetCursorPosition(5, 10 + i);
            //    Console.WriteLine($" ({i}) {boekTitels[i]}");

            //    for (int j = 0; j < tijdschriftNamen.Length; j++)
            //    {

            //        Console.SetCursorPosition(50, 10 + j);
            //        Console.WriteLine($" ({tijdschriftNamen.Length + j}) {tijdschriftNamen[j]}");
            //    }

            //}
            //Console.Write($"\n Voer het nummer in dat overeenkomt met de mateiral die je wilt opnemen. ==>  ");
            //verwijderd = Console.ReadLine();

            //if (int.Parse(verwijderd) < (tijdschriftNamen.Length + boekTitels.Length))
            //{
            //    if (int.Parse(verwijderd) >= boekTitels.Length)
            //    {
            //        index = int.Parse(verwijderd) - tijdschriftNamen.Length;
            //        textVerwijderd = tijdschriftNamen[index];

            //        // add the material selected to lenen book
            //        Array.Resize(ref lenenBoek, lenenBoek.Length + 1);
            //        lenenBoek.SetValue(textVerwijderd, lenenBoek.Length - 1);
            //        Console.WriteLine(lenenBoek[0]);
            //        // add the material selected to lenen book

            //        tijdschriftNamen = tijdschriftNamen.Where(val => val != textVerwijderd).ToArray();
            //        Console.WriteLine($"\n het materiaal geleend: {textVerwijderd}");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        index = int.Parse(verwijderd);
            //        textVerwijderd = boekTitels[index];

            //        // add the material selected to lenen book
            //        Array.Resize(ref lenenBoek, lenenBoek.Length + 1);
            //        lenenBoek.SetValue(textVerwijderd, lenenBoek.Length - 1);
            //        Console.WriteLine(lenenBoek[0]);
            //        Console.ReadLine();
            //        // add the material selected to lenen book

            //        boekTitels = boekTitels.Where(val => val != textVerwijderd).ToArray();
            //        Console.WriteLine($"\n het materiaal geleend: {textVerwijderd}");
            //        Console.ReadLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Voer een geldig nummer in, probeer opnieuw!!!!");
            //    Console.ReadLine();
            //}


            //LenenBoek(ref boekTitels, ref tijdschriftNamen, ref lenenBoek);


            //ToonMaterialen(boekTitels, tijdschriftNamen);


            //Console.ReadLine();



        }

        private static void LenenBoek(ref string[] boekTitels, ref string[] tijdschriftNamen, ref string[] lenenBoek, ref string[] lenentijdschriftNamen)
        {
            string verwijderd;
            string textVerwijderd;
            int index;
            bool result;
            
            Console.WriteLine("Lenen een materiaal: ");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("BoekTitels");

            Console.SetCursorPosition(50, 10);
            Console.WriteLine("TijdschriftNamen");

            for (int i = 0; i < boekTitels.Length; i++)
            {
                Console.SetCursorPosition(5, 12 + i);
                Console.WriteLine($" ({i}) {boekTitels[i]}");

                for (int j = 0; j < tijdschriftNamen.Length; j++)
                {

                    Console.SetCursorPosition(5, 12 + j);
                    Console.WriteLine($" ({tijdschriftNamen.Length + j}) {tijdschriftNamen[j]}");
                }

            }
            Console.Write($"\n Voer het nummer in dat overeenkomt met de mateiral die je wilt opnemen. ==>  ");
            verwijderd = Console.ReadLine();

            if (int.Parse(verwijderd) < (tijdschriftNamen.Length + boekTitels.Length))
            {
                if (int.Parse(verwijderd) >= boekTitels.Length)
                {
                    index = int.Parse(verwijderd) - tijdschriftNamen.Length;
                    textVerwijderd = tijdschriftNamen[index];

                    // add the material selected to lenen book
                    Array.Resize(ref lenentijdschriftNamen, lenentijdschriftNamen.Length + 1);
                    lenentijdschriftNamen.SetValue(textVerwijderd, lenentijdschriftNamen.Length - 1);
                    Console.WriteLine(lenentijdschriftNamen[0]);
                    // add the material selected to lenen book
                    tijdschriftNamen = tijdschriftNamen.Where(val => val != textVerwijderd).ToArray();
                    Console.WriteLine($"\n het materiaal geleend: {textVerwijderd}");
                    Console.ReadLine();
                }
                else
                {
                    index = int.Parse(verwijderd);
                    textVerwijderd = boekTitels[index];

                    // add the material selected to lenen book
                    Array.Resize(ref lenenBoek, lenenBoek.Length + 1);
                    lenenBoek.SetValue(textVerwijderd, lenenBoek.Length - 1);
                    Console.WriteLine(lenenBoek[0]);
                    Console.ReadLine();
                    // add the material selected to lenen book

                    boekTitels = boekTitels.Where(val => val != textVerwijderd).ToArray();
                    Console.WriteLine($"\n het materiaal geleend: {textVerwijderd}");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Voer een geldig nummer in, probeer opnieuw!!!!");
                Console.ReadLine();
            }
        }

        private static string[] RegistreerGebruiker(string[] gebruikers)
        {
            string naam;
            Console.Write("Voer de naam van de nieuwe gebruiker in: ");
            naam = Console.ReadLine();

            Array.Resize(ref gebruikers, gebruikers.Length + 1);
            gebruikers.SetValue(naam, gebruikers.Length - 1);

            for (int i = 0; i < gebruikers.Length; i++)
            {
                Console.WriteLine(gebruikers[i]);
            }

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
            bool result;
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("BoekTitels");

            Console.SetCursorPosition(50, 8);
            Console.WriteLine("TijdschriftNamen");

            for (int i = 0; i < boekTitels.Length; i++)
            {
                Console.SetCursorPosition(5, 10 + i);
                Console.WriteLine($" ({i}) {boekTitels[i]}");

                for (int j = 0; j < tijdschriftNamen.Length; j++)
                {

                    Console.SetCursorPosition(50, 10 + j);
                    Console.WriteLine($" ({tijdschriftNamen.Length + j}) {tijdschriftNamen[j]}");
                }

            }
            Console.Write($"\n Voer het nummer in dat overeenkomt met de mateiral die verwijderd moet worden ==>  ");
            verwijderd = Console.ReadLine();

            if (int.Parse(verwijderd) < (tijdschriftNamen.Length + boekTitels.Length))
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
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Voer een geldig nummer in, probeer opnieuw!!!!");
                Console.ReadLine();
            }
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

            Console.SetCursorPosition(5, 8);
            Console.WriteLine($"boekTitels");

            Console.SetCursorPosition(50, 8);
            Console.WriteLine($"tijdschriftNamen");

            for (int i = 0; i < boekTitels.Length; i++)
            {
                Console.SetCursorPosition(5, 10 + i);
                Console.WriteLine(boekTitels[i]);

                for (int j = 0; j < tijdschriftNamen.Length; j++)
                {
                     
                    Console.SetCursorPosition(50, 10 + j);
                    Console.WriteLine(tijdschriftNamen[j]);
                    //break;
                }
            }
        }

        private static void ShowMenu(ref string[] boekTitels, ref string[] boekAuteurs, ref string[] tijdschriftNamen, ref string[] gebruikers, ref string[] lenenBoek, ref string[] lenentijdschriftNamen)
        {
            string option;
            int num;

            do
            {
                
                Console.WriteLine("Menu");
                Console.WriteLine("[0] materialen tonen");
                Console.WriteLine("[1] materiaal toevoegen");
                Console.WriteLine("[2] materiaal verwijderen");
                Console.WriteLine("[3] mmateriaal zoeken");
                Console.WriteLine("[4] nieuwe gebruiker registreren");
                Console.WriteLine("[5] Lenen een materiaael");
                Console.WriteLine("[6] Terugbrengen een materiaal");
                Console.WriteLine("[7] Exit");
                Console.Write("Kies een nummer: ");
                option = Console.ReadLine();

                if (!Int32.TryParse(option, out num)) continue;

                switch (num)
                {
                    case 0:
                        ToonMaterialen(boekTitels, tijdschriftNamen);
                        EndCase();                        
                        break;
                    case 1:
                        VoegMateriaalToe(ref boekTitels, ref boekAuteurs, ref tijdschriftNamen);
                        ToonMaterialen(boekTitels, tijdschriftNamen);
                        EndCase();
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
                        RegistreerGebruiker(gebruikers);
                        EndCase();
                        break;
                    case 5:
                        LenenBoek(ref boekTitels, ref tijdschriftNamen, ref lenenBoek, ref lenentijdschriftNamen);
                        EndCase();
                        break;
                    case 6:
                        //LenenBoek(ref boekTitels, ref tijdschriftNamen, ref lenenBoek);
                        //EndCase();
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (true);
            
        }

        private static void EndCase()
        {
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}
