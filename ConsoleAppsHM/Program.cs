using System;
using MusicalInstrumentNamespace;

class Program
{
    static void Main()
    {
        MusicalInstrument[] instruments = {
            new Violin("Violin", "A string instrument with a high-pitched tone."),
            new Trombone("Trombone", "A brass instrument with a sliding mechanism."),
            new Ukulele("Ukulele", "A small string instrument from Hawaii."),
            new Cello("Cello", "A larger string instrument with deep tones.")
        };

        foreach (var instrument in instruments)
        {
            instrument.Show();
            instrument.Desc();
            instrument.Sound();
            instrument.History();
            Console.WriteLine();
        }
    }
}