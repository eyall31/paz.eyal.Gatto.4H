using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paz.eyal.Gatto._4H
{
    public partial class Form1 : Form
    {
        const int LATO_X = 200;
        const int LATO_Y = 300;

        const int MARGINE_SINISTRO = 100;
        const int MARGINE_DESTRO = 100;
        const int MARGINE_SUPERIORE = 100;
        const int MARGINE_INFERIORE = 100;


        const int LATO_X_FORM = (MARGINE_SINISTRO + LATO_X + MARGINE_DESTRO);
        const int LATO_Y_FORM = (MARGINE_SUPERIORE + LATO_Y + MARGINE_INFERIORE);
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(LATO_X_FORM, LATO_Y_FORM);
            this.MaximumSize = new Size(LATO_X_FORM, LATO_Y_FORM);
        }
        private int X(double x)
        {
            int xLogico = 0;
            xLogico = (int)(x) + MARGINE_SINISTRO;
            return xLogico;
        }

        private int Y(double y)
        {
            int yLogico = 0;
            yLogico = (MARGINE_SUPERIORE + LATO_Y - (int)(y));
            return yLogico;
        }

        private void btnDisegna_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black, 1);
            Pen Blue = new Pen(Color.Blue, 1);
            dc.DrawRectangle(BlackPen, MARGINE_SINISTRO + 0, MARGINE_SUPERIORE + 0, LATO_X, LATO_Y);
            Punto[] p = new Punto[34];
            p[0] = new Punto(0, 0); //20 X 20 Y
            p[1] = new Punto(20, 0);
            p[2] = new Punto(40, 20);
            p[3] = new Punto(20, 0);
            p[4] = new Punto(40, 0);
            p[5] = new Punto(60, 20);
            p[6] = new Punto(140, 20);
            p[7] = new Punto(140, 0);
            p[8] = new Punto(120, 20);
            p[9] = new Punto(140, 20);
            p[10] = new Punto(160, 0);
            p[11] = new Punto(160, 20);
            p[12] = new Punto(120, 60);
            p[13] = new Punto(140, 80);
            p[14] = new Punto(160, 80);
            p[15] = new Punto(180, 60);
            p[16] = new Punto(180, 40);
            p[17] = new Punto(160, 60);
            p[18] = new Punto(140, 60);
            p[19] = new Punto(140, 40);
            p[20] = new Punto(120, 60);
            p[21] = new Punto(60, 60);
            p[22] = new Punto(60, 100);
            p[23] = new Punto(40, 80);
            p[24] = new Punto(20, 80);
            p[25] = new Punto(0, 100);
            p[26] = new Punto(0, 60);
            p[27] = new Punto(20, 40);
            p[28] = new Punto(40, 40);
            p[29] = new Punto(60, 60);
            p[30] = new Punto(40, 40);
            p[31] = new Punto(20, 40);
            p[32] = new Punto(20, 20);
            p[33] = new Punto(0, 0);

            for (int i = 0; i < 34; i++)
          
            {
                int j = i + 1;
                if (j == 34) j = 0;
                dc.DrawLine(Blue, X(p[i].X), Y(p[i].Y), X(p[j].X), Y(p[j].Y));
            }
        }
    }
}
