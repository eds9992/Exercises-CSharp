using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryNumConverter
{
    /*
     * Create a Windows app that converts decimal numbers to binary numbers. 
     * Your project will need two text boxes, one to display the decimal number and one to display the binary number. 
     * You need a Convert button to kick off the conversion and a Clear button to clear the text boxes. 
     * Your program should use a stack to store the converted number. 
     * Here is the algorithm for converting a decimal number to a binary number: 
     * n = decimal number
     * B = base (2 in this case)
     * 1. Take n % B and push result to the stack.
     * 2. n = n / B
     * 3. Repeat 1 and 2 while n > 1
     * 4. Continually pop stack into a string until stack is empty. 
     * The resulting string is the converted number.
     */
    public partial class Form1 : Form
    {
        public class Stack<T>
        {
            private int top;
            private T[] elements;
            private int stackSize = 8;

            public Stack()
            {
                elements = new T[stackSize];
                top = -1;
            }

            internal void push(T value)
            {
                ++top;
                elements[top] = value;
            }

            public T pop()
            {
                --top;
                return elements[top + 1];
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void DecimalValBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BinaryValBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            /*
            1. Take n % B and push result to the stack.
            2. n = n / B
            3. Repeat 1 and 2 while n > 1
            4. Continually pop stack into a string until stack is empty.
            */
            Stack<int> Decimal = new Stack<int>();
            decimal n = Convert.ToDecimal(DecimalValBox.Text);
            int B = 2;
            while (n >= 1)
            {
                int x = Convert.ToInt32(n % B);
                Decimal.push(x);
                n = n / B;
                //B = Convert.ToInt32(n % B);
                //Decimal.push(B);
                //n = n / B;
                //B.ToString();
                Decimal.pop();
            }
            BinaryValBox.Text = Decimal.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DecimalValBox.Text = String.Empty;
            BinaryValBox.Text = String.Empty;
        }
    }
}