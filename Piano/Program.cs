using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Toub.Sound.Midi;
using System.Windows.Forms;

namespace Piano
{
    internal class Program : Form
    {

        public event KeyEventHandler KeyDown;

        public Program()
        {
            MidiPlayer.OpenMidi();
            ConsoleKeyInfo k;
            MidiPlayer.Play(new ProgramChange(0, 0, GeneralMidiInstruments.PanFlute));
            string note = "C0";

            while (true)
            {
                this.KeyDown = new KeyEventHandler(TestKeyDown);
                k = Console.ReadKey();
                char c = k.KeyChar;

                

                //TODO: Need to use KeyDown- and KeyUp-events instead. A note will start on down and stop on up.

                // To play black keys we write for intance "C#5",
                // which will be the key imediatly to the right of "C5"

                if (c == 'e')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "C4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
//                    System.Threading.Thread.Sleep(1000);
//                    MidiPlayer.Play(new NoteOff(0, 0, "C4", 127));
                }
                if (c == '4')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "C#4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == 'r')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "D4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == '5')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "D#4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == 't')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "E4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == 'y')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "F4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == '7')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "F#4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == 'u')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "G4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == '8')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "G#4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == 'i')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "A4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == '9')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "A#4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == 'o')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "B4";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == 'p')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "C5";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == '+')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "C#5";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }
                if (c == 'å')
                {
                    MidiPlayer.Play(new NoteOff(0, 0, note, 127));
                    note = "D5";
                    MidiPlayer.Play(new NoteOn(0, 0, note, 127));
                }



                // Play a chord

//                if (c == 'r')
//
//                {
//                    MidiPlayer.Play(new NoteOn(0, 0, "C4", 127));
//                    MidiPlayer.Play(new NoteOn(0, 0, "F4", 127));
//                    MidiPlayer.Play(new NoteOn(0, 0, "A4", 127));
//                }
//                if(c =='t')
//                {
//                    MidiPlayer.Play(new NoteOn(0, 0, "G4", 127));
//                    MidiPlayer.Play(new NoteOn(0, 0, "B4", 127));
//                    MidiPlayer.Play(new NoteOn(0, 0, "D4", 127));
//                }
            }

        }

        private static void TestKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                MidiPlayer.Play(new NoteOn(0, 1, "C4", 127));
            }
        }

        private static void Main(string[] args)
        {
            Application.Run(new Program());

            
        }
    }
}
