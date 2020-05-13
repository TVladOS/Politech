using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        Triangls triangls;
        int i = 0;
        public Form1()
        {
            InitializeComponent();

            var load = MessageBox.Show("Загрузить предыдущие данные?", "Wait...", MessageBoxButtons.YesNo);
            if (load == DialogResult.Yes)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string path = openFileDialog1.FileName;
                string ans;
                int t = 0;

                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        int num = reader.ReadInt32();
                        Point point1 = new Point(reader.ReadString(), reader.ReadInt32(), reader.ReadInt32());
                        Point point2 = new Point(reader.ReadString(), reader.ReadInt32(), reader.ReadInt32());
                        Point point3 = new Point(reader.ReadString(), reader.ReadInt32(), reader.ReadInt32());
                        double p = reader.ReadDouble();
                        double s = reader.ReadDouble();
                        bool isOrt = reader.ReadBoolean();
                        t++;
                    }
                }

                triangls = new Triangls(t);

                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        int num = reader.ReadInt32();
                        Point point1 = new Point(reader.ReadString(), reader.ReadInt32(), reader.ReadInt32());
                        Point point2 = new Point(reader.ReadString(), reader.ReadInt32(), reader.ReadInt32());
                        Point point3 = new Point(reader.ReadString(), reader.ReadInt32(), reader.ReadInt32());
                        double p = reader.ReadDouble();
                        double s = reader.ReadDouble();
                        bool isOrt = reader.ReadBoolean();

                        triangls.addTriangle(num, point1, point2, point3, p, s, isOrt);
                    }
                }
                richTextTriengleInfo.AppendText(triangls.ShowAllTriangls());
                if (t > 1)
                    richTextTriengleInfo.AppendText(triangls.ReturnResult());
            }
        }
        private void savePointBtn_Click(object sender, EventArgs e)
        {
            i = i + 1;
            try
            {
                Point point1 = new Point(x2NameBox.Text, Int32.Parse(x2TextBox.Text), Int32.Parse(y2TextBox.Text));
                Point point3 = new Point(x3NameBox.Text, Int32.Parse(x3TextBox.Text), Int32.Parse(y3TextBox.Text));
                Point point2 = new Point(x1NameBox.Text, Int32.Parse(x1TextBox.Text), Int32.Parse(y1TextBox.Text));

                Triangle triangle = new Triangle(i, point1, point2, point3);


                TriangleNumBox.Clear();
                TriangleNumBox.AppendText(i + "");

                if (triangle.IsTriangle())
                    triangls.addTriangle(i, point1, point2, point3, triangle.getP(), triangle.getS(), triangle.IsOrthogonal());
                else
                {
                    i = i - 1;
                    if (i < 1)
                    {
                        TriangleNumBox.Clear();
                        TriangleNumBox.AppendText("1");
                    }

                }

                richTextTriengleInfo.AppendText(triangle.ToString());

                if (i >= Int32.Parse(AmoutTextBox.Text))
                {
                    x1NameBox.Enabled = false;
                    x1TextBox.Enabled = false;
                    y1TextBox.Enabled = false;

                    x2NameBox.Enabled = false;
                    x2TextBox.Enabled = false;
                    y2TextBox.Enabled = false;

                    x3NameBox.Enabled = false;
                    x3TextBox.Enabled = false;
                    y3TextBox.Enabled = false;

                    savePointBtn.Enabled = false;
                    TriangleNumBox.Enabled = false;
                    if (i > 1)
                        richTextTriengleInfo.AppendText(triangls.ReturnResult());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                i = i - 1;
            }

            x1NameBox.Clear();
            x1TextBox.Clear();
            y1TextBox.Clear();

            x2NameBox.Clear();
            x2TextBox.Clear();
            y2TextBox.Clear();

            x3NameBox.Clear();
            x3TextBox.Clear();
            y3TextBox.Clear();
        }
        private void InitAmoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                triangls = new Triangls(Int32.Parse(AmoutTextBox.Text));

                x1NameBox.Enabled = true;
                x1TextBox.Enabled = true;
                y1TextBox.Enabled = true;

                x2NameBox.Enabled = true;
                x2TextBox.Enabled = true;
                y2TextBox.Enabled = true;

                x3NameBox.Enabled = true;
                x3TextBox.Enabled = true;
                y3TextBox.Enabled = true;

                savePointBtn.Enabled = true;
                TriangleNumBox.Enabled = true;

                AmoutLabel.Enabled = false;
                InitAmoutBtn.Enabled = false;

                ResetBtn.Enabled = true;

                TriangleNumBox.AppendText(i + "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void RndFillBtn_Click(object sender, EventArgs e)
        {
            ResetBtn.Enabled = true;

            triangls = new Triangls(4);

            Point point1 = new Point("P", 6, 4);
            Point point2 = new Point("M", 0, 3);
            Point point3 = new Point("S", 0, 2);

            Triangle triangle1 = new Triangle(1, point1, point2, point3);

            triangls.addTriangle(1, point1, point2, point3, triangle1.getP(), triangle1.getS(), triangle1.IsOrthogonal());

            richTextTriengleInfo.AppendText(triangle1.ToString());

            Point point4 = new Point("U", 19, 2);
            Point point5 = new Point("S", 6, 35);
            Point point6 = new Point("A", 7, 6);

            Triangle triangle2 = new Triangle(2, point4, point5, point6);

            triangls.addTriangle(2, point4, point5, point6, triangle2.getP(), triangle2.getS(), triangle2.IsOrthogonal());

            richTextTriengleInfo.AppendText(triangle2.ToString());

            Point point7 = new Point("Y", 9, -6);
            Point point8 = new Point("O", 5, 6);
            Point point9 = new Point("U", 3, 5);

            Triangle triangle3 = new Triangle(3, point7, point8, point9);

            triangls.addTriangle(3, point7, point8, point9, triangle3.getP(), triangle3.getS(), triangle3.IsOrthogonal());

            richTextTriengleInfo.AppendText(triangle3.ToString());

            Point point10 = new Point("C", 3, -4);
            Point point11 = new Point("A", 2, 3);
            Point point12 = new Point("R", 5, 8);

            Triangle triangle4 = new Triangle(4, point10, point11, point12);

            triangls.addTriangle(4, point10, point11, point12, triangle4.getP(), triangle4.getS(), triangle4.IsOrthogonal());

            richTextTriengleInfo.AppendText(triangle4.ToString());


            richTextTriengleInfo.AppendText(triangls.ReturnResult());
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var save = MessageBox.Show("Сохранить введенные данные?", "Wait...", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

        
                string filename = saveFileDialog1.FileName;

                triangls.saveTo(filename);

                MessageBox.Show("Сохранено");
            }
            this.Close();
        }
    private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.webmath.ru/");
        }
        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}