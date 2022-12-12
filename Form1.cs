using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSB04WarreVanpaemel
{
    public partial class Form1 : Form
    {
        //we maken een object van onze klasse zodat we de methoden kunnen aanspreken
        //ook de pen die we gaan nodig hebben voor het tekenen van onze figuren
        Figuren f = new Figuren();
        Pen penColor;
        ColorDialog c;
        Brush b;
        Boolean hover = false;

        public Form1()
        {
            //we voegen de keuzes toe aan de combobox bij het opstarten van het programma
            InitializeComponent();
            cmbKeuze.Items.Add("Line");
            cmbKeuze.Items.Add("Ball");
            cmbKeuze.Items.Add("Square");
            
        }

        private void cmbKeuze_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //panel leegmaken
            pnlDraw.Refresh();
        }
        private void btnKleur_Click(object sender, EventArgs e)
        {
            //we showen de colordialog en nemen het kleur op in de pen en veranderen de background
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            penColor = new Pen(c.Color,1);
            Brush b = new SolidBrush(c.Color);
            btnKleur.BackColor = c.Color;
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            hover = true;
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            //we maken van onze panel een graphics
            //als de combobox leeg is gebeurt er niks
            //als er iets is geselct in de combobox kijkt het programa of er een kleur aanwezig is
            //dan kijkt het wat er geselct is en voert de code uit
            Graphics g = pnlDraw.CreateGraphics();
            if(hover == true)
            {
                if (cmbKeuze.SelectedItem == null)
                {

                }
                else
                {
                    if (penColor == null)
                    {
                        MessageBox.Show("Gelieve een kleur te kiezen");
                    }
                    else
                    {
                        if (cmbKeuze.SelectedItem.ToString() == "Line")
                        {
                            f.TekenLine(g, e, penColor);
                        }
                        if (cmbKeuze.SelectedItem.ToString() == "Square")
                        {
                            f.TekenSquare(g, e, penColor);
                        }
                        if (cmbKeuze.SelectedItem.ToString() == "Ball")
                        {
                            f.TekenCirckel(g, e, penColor);
                        }

                    }
                }
            }       
        }

        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            hover = false;
        }
    }
}
