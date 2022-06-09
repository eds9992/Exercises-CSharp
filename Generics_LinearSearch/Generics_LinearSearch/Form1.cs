using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics_LinearSearch
{
    /*
     * Write generic method, Search, that searches array using linear search. 
     * Method Search should compare the search key with each element in its array parameter until the search key is found or until end of array is reached. 
     * If key is found, return location in array, return -1 otherwise.
     * Write test app that inputs/searches int/double array.
     * Provide buttons that user can click to randomly generate int/double values.
     * Display generated values in TextBox, so user knows what values they can search for.
     * HINT: Use (T: : IComparable in where clause for method Search so you can use CompareTo method to compare search key to array elements. 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInt_Click(object sender, EventArgs e)
        {
            Random randomNumbers = new Random();
            int[] numbers = new int[20];

            for (int i = 0; i < 20; ++i)
            {
                numbers[i] = randomNumbers.Next(1, 20);
                ArrayBox.Text += (numbers[i] + " ");
            }
        }

        private void BtnDbl_Click(object sender, EventArgs e)
        {
            Random randomNumbers = new Random();
            double[] numbers = new double[10];

            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = randomNumbers.Next(1, 10);
                ArrayBox.Text += (numbers[i] + " ");
            }
        }

        private void ArrayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int Search<T>(T[] values, T SearchKey) where T : IComparable<T> //Doesn't do anything affter pressing the button
            {
                for (int i = 0; i < values.Length; ++i)
                {
                    if (values[i].Equals(SearchKey))
                    {
                        ResultBox.Text += ("Found " + SearchKey + " at position " + values[i]);
                        return i;
                    }
                }
                return -1;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(richTextBox1.Text); //Not sure what to put here
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

            ResultBox.Text += ("Found " + SearchKey + " at position " + values[i]); //Not sure what to put here either
        }
    }
}
