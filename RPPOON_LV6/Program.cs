using System;
using System.Collections.Generic;

namespace RPPOON_LV6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 1: \n");
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("Rijesiti LV6", "Rijesiti LV6 iz RPPOONa"));
            notebook.AddNote(new Note("Rijesiti kolokvij", "Rijesiti kolokvij iz xy"));
            notebook.AddNote(new Note("Rijesiti z", "Rijesiti!"));
            Iterator iterator = (Iterator)notebook.GetIterator();
            for (Note currNote = iterator.First(); !iterator.IsDone; currNote = iterator.Next())
            {
                currNote.Show();
            }
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
        }
    }
}
