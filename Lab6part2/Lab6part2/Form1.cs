using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6part2
{
    delegate void Comporator(bool isASC);
    public partial class Form1 : Form
    {
        private Button GenerateCollection;
        private Button SortingCollectionASC;
        private Button SortingCollectionDESC;
        private ListBox MyCollection;
        List<string> elements;
        private Comporator comporator;

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
        private TextBox GenerationCollectionHowManyValue;
        public Form1()
        {
            InitializeComponent();
            this.GenerateCollection = this.GenerationObjects;
            this.SortingCollectionASC = this.SortCollectionASC;
            this.SortingCollectionDESC = this.SortCollectionDESC;
            this.GenerationCollectionHowManyValue = this.GenerationObjectHowMany;
            this.MyCollection = this.MyCollectionListBox;
            this.button1.Click += MyLinq1;
            this.button2.Click += MyLinq2;
            this.button3.Click += MyLinq3;

            //   Only for training)
            this.GenerateCollection.Click += (object sender, EventArgs e) =>
            {
                int b;
                try
                {
                    b = Int32.Parse(GenerationCollectionHowManyValue.Text);
                }
                catch
                {
                    b = 5;
                    GenerationCollectionHowManyValue.Text = @"5";

                }
                Random rand = new Random();
                this.elements = new List<string>();
                for (int i = 0; i < b; i++)
                {
                    string a = "";
                    for (int j = 0; j < b; j++)
                        a += Arr[rand.Next(Form1.Arr.Length)];
                    this.elements.Add(a);
                }
                this.MyCollection.Items.Clear();
                for (int i = 0; i < b; i++)
                {
                    this.MyCollection.Items.Add(elements[i]);
                }
            };
            SortingCollectionASC.Click += (object sender, EventArgs e) =>
            {
                comporator = SortedAsc;
                comporator.Invoke(true);
                this.ResultSortingAndQueries.Items.Clear();
                for (int i = 0; i < elements.Count; i++)
                {
                    this.ResultSortingAndQueries.Items.Add(elements[i]);
                }
            };
            SortCollectionDESC.Click += (object sender, EventArgs e) =>
            {
                comporator = SortedAsc;
                comporator.Invoke(false);
                this.ResultSortingAndQueries.Items.Clear();
                for (int i = 0; i < elements.Count; i++)
                {
                    this.ResultSortingAndQueries.Items.Add(elements[i]);
                }
            };

        }

        void MyLinq1(object sender, EventArgs e)
        {
            try
            {
                var query2 = (from el in elements
                    select el).Skip(3);
                this.ResultSortingAndQueries.Items.Clear();
                foreach (var a in query2)
                {
                    this.ResultSortingAndQueries.Items.Add(a);
                }     
            }
            catch
            {

            }
        }
        void MyLinq2(object sender, EventArgs e)
        {
            try
            {
                var query = (from el in elements
                    select el).Count();
                this.ResultSortingAndQueries.Items.Clear();
                this.ResultSortingAndQueries.Items.Add(query); 
            }
            catch
            {

            }  
        }
        void MyLinq3(object sender, EventArgs e)
        {
            try
            {
                var query2 = (from el in elements
                    where el.IndexOf('W') != -1 || el.IndexOf('w') != -1 || el.IndexOf('X') != -1 || el.IndexOf('x') != -1
                    select el);
                this.ResultSortingAndQueries.Items.Clear();
                foreach (var a in query2)
                {
                    this.ResultSortingAndQueries.Items.Add(a);
                }                                      
            }
            catch
            {

            }
        }
        void SortedAsc(bool isval)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (elements[i].CompareTo(elements[j]) == 1 && isval == true)
                    {
                        var a = elements[i];
                        elements[i] = elements[j];
                        elements[j] = a;
                    }
                    else if (elements[i].CompareTo(elements[j]) == -1 && isval == false)
                    {
                        var a = elements[i];
                        elements[i] = elements[j];
                        elements[j] = a;
                    }
                }
            }
        }           
    }
}
