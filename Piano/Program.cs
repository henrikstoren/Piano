using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Toub.Sound.Midi;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            MidiPlayer.OpenMidi();
            ConsoleKeyInfo k;
            int count = 0;
            while (true)
            {
                k = Console.ReadKey();
                char c = k.KeyChar;
                int a = (int) c;
                int freq = a*70;
                //dette er teit
                //nei det er det ikke!!!!
                if (c == 'i')
                {
                    MidiPlayer.Play(new NoteOn(0, 0, "B4", 127));
                }
                else if (c == 'o')
                {
                    MidiPlayer.Play(new NoteOn(0, 0, "C5", 127));
                }
                else if (c == 'p')
                {
                    MidiPlayer.Play(new NoteOn(0, 0, "D5", 127));
                }
                else if (c == 'u')
                {
                    MidiPlayer.Play(new NoteOn(0, 0, "A4", 127));
                }
                else if (c == 'y')
                {
                    MidiPlayer.Play(new NoteOn(0, 0, "G4", 127));
                }

                

                // Play a chord
//                if (count%2 == 0)
//                {
//                    MidiPlayer.Play(new NoteOn(0, 0, "C4", 127));
//                    MidiPlayer.Play(new NoteOn(0, 0, "F4", 127));
//                    MidiPlayer.Play(new NoteOn(0, 0, "A4", 127));
//                }
//                else
//                {
//                    MidiPlayer.Play(new NoteOn(0, 0, "G4", 127));
//                    MidiPlayer.Play(new NoteOn(0, 0, "B4", 127));
//                    MidiPlayer.Play(new NoteOn(0, 0, "D4", 127));
//                }
//                
//                count += 1;


//                MidiPlayer.Play(new NoteOn(0, 15, "C4", 127));
//                MidiPlayer.Play(new NoteOn(0, 15, "F4", 127));
//                MidiPlayer.Play(new NoteOn(0, 15, "A4", 127));
                // Wait x milliseconds before we stop the note.
                // May not be useful when we want to play consecutive/simultanous notes.
//                System.Threading.Thread.Sleep(5000);
//                MidiPlayer.Play(new NoteOff(0, 15, "C4", 127));
//                MidiPlayer.Play(new NoteOff(0, 15, "F4", 127));
//                MidiPlayer.Play(new NoteOff(0, 15, "A4", 127));
//                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
        }
    }
}
