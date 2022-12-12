using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSB04WarreVanpaemel
{
    internal class Figuren
    {
        

        public void TekenCirckel(Graphics g, MouseEventArgs e, Pen p)
        {
            //Hier is de code om een cirkel te tekenen, de ofset van de e coordinaten zorgen ervoor dat je cursor in het midden van de cirkel is
            Brush b = new SolidBrush(p.Color);
            Rectangle r = new Rectangle(e.X-5,e.Y-5, 10, 10);
            g.FillEllipse(b, r);
        }
        public void TekenSquare(Graphics g, MouseEventArgs e, Pen p)
        {
            //Code voor een square te tekene, weer offset voor je curosr in het midden
            Brush b = new SolidBrush(p.Color);
            Point pA = new Point();
            pA.X = e.X - 5;
            pA.Y = e.Y - 5;
            Point pB = new Point();
            pB.X = e.X + 5;
            pB.Y = e.Y - 5;
            Point pC = new Point();
            pC.X = e.X + 5;
            pC.Y = e.Y + 5;
            Point pD = new Point();
            pD.X = e.X - 5;
            pD.Y = e.Y + 5;
            g.FillPolygon(b, new Point[] {pA,pB,pC,pD });
        }
        public void TekenLine(Graphics g, MouseEventArgs e, Pen p)
        {
            //Code voor line te tekenen
            
            Point pA = new Point();
            pA.X = e.X;
            pA.Y = e.Y;
            Point pB = new Point();
            pB.X = e.X + 10;
            pB.Y = e.Y - 10;
            g.DrawLine(p, pA, pB);
        }
    }
}
