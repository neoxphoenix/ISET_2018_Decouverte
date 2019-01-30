using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ISET_2018_Decouverte
{
    public partial class EcranCarnaval : Form
    {
        public EcranCarnaval()
        {
            InitializeComponent();
        }

        private void DefinirZone()
        {
            GraphicsPath dessin = new GraphicsPath();
            System.Drawing.Point[] points = new System.Drawing.Point[]
            {
                new System.Drawing.Point(0,0),
                new System.Drawing.Point(0, Size.Height),
                new System.Drawing.Point(Size.Width /  4, 4 * Size.Height / 5),
                new System.Drawing.Point(Size.Width / 2, Size.Height),
                new System.Drawing.Point(3 * Size.Width/4, 4 * Size.Height / 5),
                new System.Drawing.Point(Size.Width, Size.Height),
                new System.Drawing.Point(Size.Width, 0)
            };
            dessin.AddCurve(points);
            dessin.CloseAllFigures();
            Region = new Region(dessin);
        }

        private void DessinerBoutonTexte()
        {
            GraphicsPath gp = new GraphicsPath();
            StringFormat sf = new StringFormat(StringFormat.GenericDefault);
            sf.Alignment = StringAlignment.Center;
            gp.AddString("Cliquons ensemble !", new FontFamily("Courier New"), (int)FontStyle.Bold,
                24, new System.Drawing.Point(ClientSize.Width / 2, 0), sf);
            btnText.Region = new Region(gp);
        }

        private void DessinerBoutonGeometrique()
        {
            int w = btnGeometrique.Size.Width;
            int h = btnGeometrique.Size.Height;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(0, 0, w / 2, h));
            gp.AddEllipse(new Rectangle(w / 4, h / 2, w / 6, h / 3));
            gp.AddEllipse(new Rectangle(w / 2, 0, w / 2, h));
            gp.AddEllipse(new Rectangle(3 * w / 4 - w / 6, h / 2, w / 6, h / 3));
            btnGeometrique.Region = new Region(gp);
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bien vu l'aveugle !");
        }

        private void btnGeometrique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rien de plus, l'aveugle !");
        }

        private void EcranCarnaval_Paint(object sender, PaintEventArgs e)
        {
            DefinirZone();
            DessinerBoutonTexte();
            btnGeometrique.Size = new Size(ClientSize.Width - 20, ClientSize.Height / 4 - 20);
            DessinerBoutonGeometrique();
            btnText.Size = new Size(ClientSize.Width - 20, btnText.Size.Height);
        }

        private void EcranCarnaval_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
