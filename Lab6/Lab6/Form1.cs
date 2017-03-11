using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public static Button ButtonrandomStrings;
        public static Button _buttonChangeSubstring;
        public static Button _buttonDeleteGlas;
        public static Button _buttonDeleteSubstring;
        public static Button _buttonLength;
        public static Button ButtonUnion;

        public static TextBox Inputlength;
        public static TextBox Inputunion1;
        public static TextBox Inputunion2;
        public static TextBox Inputdeletesubstring1;
        public static TextBox Inputdeletesubstring2;
        public static TextBox Inputchangesubstring1;
        public static TextBox Inputchangesubstring2;
        public static TextBox Inputchangesubstring3;
        public static TextBox Inputdoubleglas;
        public static TextBox Inputrandomsstrings;


        public static TextBox OutputResult;
        public static Label Resultlabel;


        public Form1()
        {
            InitializeComponent();
            ButtonrandomStrings = ButtonRandomStrings;
            _buttonChangeSubstring = ButtonChangeSubstring;
            _buttonDeleteGlas = ButtonDeleteGlas;
            _buttonDeleteSubstring = ButtonDeleteSubstring;
            _buttonLength = ButtonLength;
            ButtonUnion = ButtonUnoin;

            _buttonChangeSubstring.Click += Calculator.ChangeSubstring;
            ButtonrandomStrings.Click += Calculator.GenerateRandomStrings;
            _buttonDeleteGlas.Click += Calculator.DoubleGlas;
            _buttonDeleteSubstring.Click += Calculator.DeleteSubstring;
            _buttonLength.Click += Calculator.GenerateLength;
            ButtonUnion.Click += Calculator.GenerateUnion;

            Inputlength = InputLength;
            Inputunion1 = InputUnion1;
            Inputunion2 = InputUnion2;
            Inputdeletesubstring1 = InputDeleteSubstring1;
            Inputdeletesubstring2 = InputDeleteSubstring2;
            Inputchangesubstring1 = InputChangeSubstring1;
            Inputchangesubstring2 = InputChangeSubstring2;
            Inputchangesubstring3 = InputChangeSubstring3;
            Inputrandomsstrings = InputRandomStrings;

            Inputdoubleglas = InputDoubleGlas;
            OutputResult = OutputResultBox;

            Resultlabel = ResultText;
        }
        public static char[] Arr = new char[52 + 32 * 2];
        static Form1()
        {
            for (int i = 0; i < 26; i++)
            {
                Arr[i] = (char)('a' + i);
                Arr[i + 26] = (char)('A' + i);
            }
            for (int i = 52; i + 32 < Arr.Length; i++)
            {
                Arr[i] = (char)('а' + i - 52);
                Arr[i + 32] = (char)('А' + i - 52);
            }
        }

        private static char[] GlasArrya =
            {
            'У', 'Е', 'Ы', 'А', 'О', 'Э', 'Я', 'И', 'Ю', 'Ё',
            'E', 'Y', 'U', 'I', 'O', 'A' };
        public static bool IsGlas(char check)
        {
            for (int i = 0; i < GlasArrya.Length; i++) if (GlasArrya[i] == char.ToUpper(check)) return true;
            return false;
        }

    }

    public static class Calculator
    {
        public static void GenerateRandomStrings(object sender, EventArgs e)
        {
            int size;
            try
            {
                size = Int32.Parse(Form1.Inputrandomsstrings.Text);
            }
            catch
            {
                Form1.Inputlength.Text = @"5";
                size = 5;
            }
            Random rand = new Random();
            string[] a = new string[10];
            for (int j = 0; j < 10; j++)
                for (int i = 0; i < size; i++)
                {
                    a[j] += Form1.Arr[rand.Next(Form1.Arr.Length)];

                }
            Form1.Inputlength.Text = a[0];
            Form1.Inputunion1.Text = a[1];
            Form1.Inputunion2.Text = a[2];
            Form1.Inputdeletesubstring1.Text = a[3];
            Form1.Inputdeletesubstring2.Text = a[4];
            Form1.Inputchangesubstring1.Text = a[5];
            Form1.Inputchangesubstring2.Text = a[6];
            Form1.Inputdoubleglas.Text = a[7];
            Form1.Inputlength.Text = a[8];
        }
        public static void ChangeSubstring(object sender, EventArgs e)
        {
            string inputstring = Form1.Inputchangesubstring1.Text;
            string tochangeinputstring = Form1.Inputchangesubstring2.Text;
            string onchange = Form1.Inputchangesubstring3.Text;
            if (onchange.IndexOf(tochangeinputstring, StringComparison.Ordinal) != -1)
            {
                Form1.Resultlabel.Text = @"It's bag idea";
                Form1.OutputResult.Text = @"Readl bad idea";
                return;
            }
            while (inputstring.IndexOf(tochangeinputstring, StringComparison.Ordinal) != -1)
            {
                int a = inputstring.IndexOf(tochangeinputstring, StringComparison.Ordinal);
                string buffer = "";
                if (a != 0)
                    buffer = inputstring.Substring(0, a);
                buffer += onchange;
                if (a + tochangeinputstring.Length != inputstring.Length &&
                    a + tochangeinputstring.Length != inputstring.Length - 1)
                    buffer += inputstring.Substring(a + tochangeinputstring.Length, inputstring.Length - a - tochangeinputstring.Length);       
                inputstring = buffer;
                if (inputstring == tochangeinputstring) inputstring = onchange;

            }
            Form1.Resultlabel.Text = $@"change in '{Form1.Inputchangesubstring1}' from '{Form1.Inputchangesubstring2}' to '{Form1.Inputchangesubstring3}'";
            Form1.OutputResult.Text = inputstring;
        }
        public static void DoubleGlas(object sender, EventArgs e)
        {
            string buffer = Form1.Inputdoubleglas.Text;
            string bufferresult = "";
            for (int i = 0; i < buffer.Length; i++)
            {
                bufferresult += buffer[i];
                if (Form1.IsGlas(buffer[i]))
                    bufferresult += buffer[i];
            }

            Form1.Resultlabel.Text = $@"Гласные *2 для '{buffer}'=";
            Form1.OutputResult.Text = bufferresult;
        }

        public static void DeleteSubstring(object sender, EventArgs e)
        {
            string inputstring = Form1.Inputdeletesubstring1.Text;
            string todeleteinputstring = Form1.Inputdeletesubstring2.Text;
            while (inputstring.IndexOf(todeleteinputstring, StringComparison.Ordinal) != -1)
            {
                int a = inputstring.IndexOf(todeleteinputstring, StringComparison.Ordinal);
                string buffer = "";
                if (a != 0)
                    buffer = inputstring.Substring(0, a);

                if (a + todeleteinputstring.Length != inputstring.Length &&
                         a + todeleteinputstring.Length != inputstring.Length - 1)
                    buffer += inputstring.Substring(a + todeleteinputstring.Length, inputstring.Length - a - todeleteinputstring.Length);
                else if (a+todeleteinputstring.Length == inputstring.Length)
                {
                    
                }
                else
                    buffer += inputstring[inputstring.Length - 1];
                inputstring = buffer;
                if (inputstring == todeleteinputstring) inputstring = "";

            }
            Form1.Resultlabel.Text = $@"Delete '{Form1.Inputdeletesubstring1}' from '{Form1.Inputdeletesubstring2}'";
            Form1.OutputResult.Text = inputstring;
        }
        public static void GenerateLength(object sender, EventArgs e)
        {
            Form1.Resultlabel.Text = $@"Length of '{Form1.Inputlength.Text}'=";
            Form1.OutputResult.Text = Convert.ToString(Form1.Inputlength.Text.Length);
        }
        public static void GenerateUnion(object sender, EventArgs e)
        {
            Form1.Resultlabel.Text = Form1.Inputunion1.Text + '+' + Form1.Inputunion2.Text + '=';
            Form1.OutputResult.Text = Form1.Inputunion1.Text + Form1.Inputunion2.Text;
        }
    }
}
