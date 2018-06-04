using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class Form1 : Form
    {
        List<Figure> figures = new List<Figure>();
        public Form1()
        {
            InitializeComponent();
        }

        private void cbFigure_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFigure.Text == "Окружность")
            {
                lRadius.Enabled = true;
                tbRadius.Enabled = true;
                lWidth.Enabled = false;
                tbWidth.Enabled = false;
                lHeight.Enabled = false;
                tbHeight.Enabled = false;
            }
            if (cbFigure.Text == "Прямоугольник")
            {
                lRadius.Enabled = false;
                tbRadius.Enabled = false;
                lWidth.Enabled = true;
                tbWidth.Enabled = true;
                lHeight.Enabled = true;
                tbHeight.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbFigure.Text)
                {
                    case "Окружность":
                        Circle circle = new Circle(
                            Convert.ToInt16(tbX.Text),
                            Convert.ToInt16(tbY.Text),
                            Convert.ToInt16(tbRadius.Text));
                        figures.Add(circle);
                        break;
                    case "Прямоугольник":
                        Rect rect = new Rect(
                            Convert.ToInt16(tbX.Text),
                            Convert.ToInt16(tbY.Text),
                            Convert.ToInt16(tbWidth.Text),
                            Convert.ToInt16(tbHeight.Text));
                        figures.Add(rect);
                        break;
                    default:
                        MessageBox.Show("Выберите фигуру!");
                        break;
                }
            } catch {
                MessageBox.Show("Проверьте правильность введённых данных!");
            }
            }

        private void btnDrawCircles_Click(object sender, EventArgs e)
        {
            Form canvas = new Form();
            canvas.Show();
            Pen pen = new Pen(Color.Red);
            Graphics graphics;
            graphics = canvas.CreateGraphics();
            foreach (Figure fig in figures)
            {
                if (fig.GetType() == typeof(Circle))
                {
                    fig.Draw(graphics, pen);
                }
                
            }


        }

        private void btnDrawAll_Click(object sender, EventArgs e)
        {
            Form canvas = new Form();
            canvas.Show();
            Pen pen = new Pen(Color.Green);
            Graphics graphics;
            graphics = canvas.CreateGraphics();
            foreach (Figure fig in figures)
            {
                fig.Draw(graphics, pen);
            }
        }
    }
}
