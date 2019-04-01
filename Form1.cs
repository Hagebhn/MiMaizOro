using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool aux = false, auxdec = false, bsum = false, bmul = false, bdiv = false, bresta = false, bandera= false;
        float a = 0, b = 0, res = 0, carryres = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Display.Text = "0";
            Display.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            setNum("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            setNum("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            setNum("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            setNum("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            setNum("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            setNum("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            setNum("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            setNum("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            setNum("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            setNum("0");
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if(auxdec == false)
            {
                setNum(".");
                auxdec = true;
            }
            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void setNum(string x)
        {
            if (bandera == true)
            {
                aux = false;
                auxdec = false;
                bandera = false;
                Display.Text = "";
            }

            if (aux == false)
            {
                Display.Text = x;
                aux = true;
            }
            else
            {
                Display.Text = Display.Text + x;
            }

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            funcRes();
            a = float.Parse(Display.Text);
            efecto();
            Display.Text = a.ToString();
            bsum = true;
            bandera = true;
            bresta = false;
            bmul = false;
            bdiv = false;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            funcRes();
            a = float.Parse(Display.Text);
            efecto();
            Display.Text = a.ToString();
            bresta = true;
            bandera = true;
            bsum = false;
            bmul = false;
            bdiv = false;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            funcRes();
            a = float.Parse(Display.Text);
            efecto();
            Display.Text = a.ToString();
            bmul = true;
            bandera = true;
            bresta = false;
            bsum = false;
            bdiv = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            funcRes();
            a = float.Parse(Display.Text);
            efecto();
            Display.Text = a.ToString();
            bdiv = true;
            bandera = true;
            bresta = false;
            bmul = false;
            bsum = false;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            funcRes();
        }

        public void clear()
        {
            a = b = res = 0;
            aux = false;
            auxdec = false;
            bandera = false;
            bsum = bresta = bmul = bdiv = false;
            carryres = 0;
            efecto();
            Display.Text = "0";
        }

        public void efecto()
        {
            this.Refresh();
            Display.Text = "";
            this.Refresh();
            Thread.Sleep(200);
            this.Refresh();
        }

        public void funcRes()
        {
            if (bsum == true)
            {
                b = float.Parse(Display.Text);
                efecto();

                res = a + b + carryres;
                carryres = res;

                Display.Text = res.ToString();
                bandera = true;
                bsum = false;
            }

            if (bresta == true)
            {
                b = float.Parse(Display.Text);
                efecto();

                res = a - b - carryres;
                carryres = res;

                Display.Text = res.ToString();
                bandera = true;
                bresta = false;
            }

            if (bmul == true)
            {
                b = float.Parse(Display.Text);
                efecto();
                if (carryres == 0)
                    carryres = 1;

                res = a * b * carryres;
                carryres = res;

                Display.Text = res.ToString();
                bandera = true;
                bmul = false;
            }

            if (bdiv == true)
            {
                b = float.Parse(Display.Text);
                efecto();
                if (carryres == 0)
                    carryres = 1;

                res = a / b / carryres;
                carryres = res;

                Display.Text = res.ToString();
                bandera = true;
                bmul = false;
            }

            a = b = res = carryres = 0;
            aux = false;
            auxdec = false;
            bsum = bresta = bmul = bdiv = false;
        }
    }
}
