using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7MSSM
{
    public partial class Form1 : Form
    {

        public double firstNum;
        public double secondNum;
        public int opType;

        public List<string> opHistory = new List<string>();

        public Form1()
        {
            InitializeComponent();
    }


        public bool checkSyntax(string input)
        {
            try
            {
                double num = Convert.ToDouble(input);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

            
        }


        //Funcion que recibe como parametro un string y cambia el TextBox de input con el 
        //valor de este string. 
        public void cambiarTexto (string entradaUsuario)
        {
            if (userInput.Text == "0" && userInput.Text != null) 
            {   
                userInput.Text = entradaUsuario; 
            }
            if (userInput.Text != "0" && userInput.Text != null)
            {
                userInput.Text += entradaUsuario;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambiarTexto("1");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            cambiarTexto("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cambiarTexto("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cambiarTexto("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cambiarTexto("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cambiarTexto("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cambiarTexto("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cambiarTexto("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cambiarTexto("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cambiarTexto("0");
        }

        
        
      
        //Boton punto agrega un punto al string del TextBox. 
        private void dotButton_Click(object sender, EventArgs e)
        {
            if (userInput.Text.Length > 0)
            {
                cambiarTexto(",");
            }
            else { return; }
            
        }
        //Boton DEL elimina un caracter del TextBox. 
        private void delButton_Click(object sender, EventArgs e)
        {
            if (userInput.Text.Length > 0)
            {
                userInput.Text = userInput.Text.Remove(userInput.Text.Length - 1);
            }
        }


        //Boton AC elimina todos los caracteres del TextBox. 
        private void ACButton_Click(object sender, EventArgs e)
        {
            int textLength = userInput.Text.Length;
            for (int i = 0; i < textLength; i++)
            {
                userInput.Text = userInput.Text.Remove(userInput.Text.Length - 1);
            }
        }

   
        private void plusButton_Click(object sender, EventArgs e)
        {
            if (checkSyntax(userInput.Text))
            {
                firstNum = Convert.ToDouble(userInput.Text);
                userInput.Text = "";
                opType = 1;
            }
            else
            {
                userInput.Text = "SYNTAX ERROR";
            }

        }


        private void minusButton_Click(object sender, EventArgs e)
        {

            if (checkSyntax(userInput.Text))
            {
                firstNum = Convert.ToDouble(userInput.Text);
                userInput.Text = "";
                opType = 2;
            }
            else
            {
                userInput.Text = "SYNTAX ERROR";
            }

        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            if (checkSyntax(userInput.Text))
            {
                firstNum = Convert.ToDouble(userInput.Text);
                userInput.Text = "";
                opType = 3;
            }
            else
            {
                userInput.Text = "SYNTAX ERROR";
            }


        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (checkSyntax(userInput.Text))
            {
                firstNum = Convert.ToDouble(userInput.Text);
                userInput.Text = "";
                opType = 4;
            }
            else
            {
                userInput.Text = "SYNTAX ERROR";
            }

           
        }

        private void isEqualButton_Click(object sender, EventArgs e)
        {
            double output;
            if (checkSyntax(userInput.Text))
            {
                secondNum = Convert.ToDouble(userInput.Text);
            }
            else
            {
                userInput.Text = "SYNTAX ERROR";
            }

            if (opType == 1)
            {
                output = firstNum + secondNum;
                userInput.Text = Convert.ToString(output);
                
                string savedOp = Convert.ToString(firstNum) + "+" + Convert.ToString(secondNum);
                opHistory.Add(savedOp);
            }
            if (opType == 2)
            {
                output = firstNum - secondNum;
                userInput.Text = Convert.ToString(output);
               
                string savedOp = Convert.ToString(firstNum) + "-" + Convert.ToString(secondNum);
                opHistory.Add(savedOp);
            }
            if (opType == 3)
            {
                output = firstNum * secondNum;
                userInput.Text = Convert.ToString(output);

                string savedOp = Convert.ToString(firstNum) + "X" + Convert.ToString(secondNum);
                opHistory.Add(savedOp);
            }
            if (opType == 4)
            {
                
                if (secondNum == 0)
                {
                    userInput.Text = "MATH ERROR";
                }

                else 
                {
                    output = firstNum / secondNum;
                    userInput.Text = Convert.ToString(output);

                    string savedOp = Convert.ToString(firstNum) + "/" + Convert.ToString(secondNum);
                    opHistory.Add(savedOp);
                }
            }
        }

        //Func. que checkea si un form esta abierto.
        public static bool isOpen (string f)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.Name == f)
                {
                    return true;
                }
            }
            return false;
        }

        //Si no esta abierto, lo muestro. Si esta abierto y hago click, lo cierro. 
        private void HistButton_Click(object sender, EventArgs e)
        {
            opHistory opData = new opHistory(opHistory);
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.Name == "opData")
                {
                    OpenForm.Close(); return;
                }
            }

            opData.Show(); 

        }
     
    }
}
