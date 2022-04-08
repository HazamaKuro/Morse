using System;
using System.Windows.Forms;

namespace Morse
{
    public partial class Morse : Form
    {
        public Morse()
        {
            InitializeComponent();
        }

        char[] characters = new char[]
        { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
          'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
          'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
          'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
          '8', '9', '0'
        };

        string[] morse = new string[]
        { "*–", "–***", "*––", "––*",
          "–**", "*", "***–", "––**",
          "**", "*–––", "–*–", "*–**",
          "––", "–*", "–––", "*––*",
          "*–*", "***", "–", "**–",
          "**–*", "****", "–*–*",
          "–––*", "––––", "−−*−",
          "−*−−", "−**−", "**−**",
          "**−−", "*−*−", "*−−−−",
          "**−−−", "***−−", "****−",
          "*****", "−****", "−−***",
          "−−−**", "−−−−*", "−−−−−"
        };

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textInput1.Text;
            input = input.ToUpper();
            string output = "";
            int i;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    i = Array.IndexOf(characters, c);
                    output += morse[i] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBoxOutput1.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBoxOutput1.Text;
            string[] split = input.Split(' ');
            string output = "";
            int i;
            foreach (string s in split)
            {
                i = Array.IndexOf(morse, s);
                output += characters[i] + " ";
            }
            output = output.Remove(output.Length - 1);
            textBoxOutput2.Text = output;
        }
    }
}
