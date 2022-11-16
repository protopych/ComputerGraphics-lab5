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

namespace ComputerGraphic_lab5
{
    using PointTuple = Tuple<double, double, double, double>;
    public partial class Form2 : Form
    {
        Graphics g;
        string axiom;
        double angle;
        string direction;
        int iterations;
        SortedDictionary<char, string> rules;
        Stack<PointTuple> savedStates;
        Pen p;
        String prettyrules;
        String path;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var b = new SolidBrush(Color.Blue);
            p = new Pen(b);
            p.Width = 1;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            rules = new SortedDictionary<char, string>();
            savedStates = new Stack<PointTuple>();

            prettyrules = "";

        }

        string buildPath()
        {
            string prev = axiom;
            string next = axiom;
            int iter = 0;
            while (iter < iterations)
            {
                prev = next;
                next = "";

                for (int i = 0; i < prev.Length; ++i)
                {
                    if (rules.ContainsKey(prev[i]))
                        next += rules[prev[i]];
                    else
                        next += prev[i];
                }
                ++iter;

            }
            Console.WriteLine(axiom, "\n");
            if (prettyrules == "")
            {
                foreach (var key in rules.Keys)
                {
                    prettyrules += key.ToString() + " -> " + rules[key] + "\n";
                }
            }
            path = next;
            return next;
        }



        void drawLSystem(string path)
        {
            List<double> xPoints = new List<double>();
            List<double> yPoints = new List<double>();
            List<PointTuple> lSystPoints =
                new List<PointTuple>();
            double x = 0, y = 0, dx = 0, dy = 0;

            switch (direction)
            {
                case "L":
                    x = pictureBox1.Width;
                    y = pictureBox1.Height / 2;
                    dx = -(pictureBox1.Width / Math.Pow(10, iterations + 1));
                    break;

                case "R":
                    y = pictureBox1.Height / 2;
                    dx = pictureBox1.Width / Math.Pow(10, iterations + 1);
                    break;

                case "U":
                    x = pictureBox1.Width / 2;
                    y = pictureBox1.Height;
                    dy = -(pictureBox1.Height / Math.Pow(10, iterations + 1));
                    break;

                case "D":
                    x = pictureBox1.Width / 2;
                    dy = pictureBox1.Height / Math.Pow(10, iterations + 1);
                    break;

                default: break;
            }

            xPoints.Add(x);
            yPoints.Add(y);

            double rx, ry;
            for (int i = 0; i < path.Length; ++i)
            {
                char c = path[i];
                switch (c)
                {
                    case 'F':
                        lSystPoints.Add(
                            new PointTuple(x, y, x + dx, y + dy));
                        x += dx;
                        y += dy;
                        xPoints.Add(x);
                        yPoints.Add(y);
                        break;

                    case '+':
                        rx = dx;
                        ry = dy;
                        dx = rx * Math.Cos(angle * Math.PI / 180) - ry * Math.Sin(angle * Math.PI / 180);
                        dy = rx * Math.Sin(angle * Math.PI / 180) + ry * Math.Cos(angle * Math.PI / 180);
                        break;

                    case '-':
                        rx = dx;
                        ry = dy;
                        dx = rx * Math.Cos(-angle * Math.PI / 180) - ry * Math.Sin(-angle * Math.PI / 180);
                        dy = rx * Math.Sin(-angle * Math.PI / 180) + ry * Math.Cos(-angle * Math.PI / 180);
                        break;

                    case '[':
                        savedStates.Push(new PointTuple(x, y, dx, dy));
                        break;

                    case ']':
                        PointTuple coords = savedStates.Pop();
                        x = coords.Item1;
                        y = coords.Item2;
                        dx = coords.Item3;
                        dy = coords.Item4;
                        break;

                    default: break;
                }
            }

            double xMax = xPoints.Max();
            double xMin = xPoints.Min();
            double yMax = yPoints.Max();
            double yMin = yPoints.Min();
            double scale = Math.Max(xMax - xMin, yMax - yMin);

            foreach (var ps in lSystPoints)
                g.DrawLine(Pens.Blue,
                    (float)((xMax - ps.Item1) / scale * pictureBox1.Width),
                    (float)((yMax - ps.Item2) / scale * pictureBox1.Height),
                    (float)((xMax - ps.Item3) / scale * pictureBox1.Width),
                    (float)((yMax - ps.Item4) / scale * pictureBox1.Height));

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files|*.TXT";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fname = openDialog.FileName;

                    string[] flines = File.ReadAllLines(fname);
                    string[] parameters = flines[0].Split(' ');

                    axiom = parameters[0];
                    angle = Convert.ToDouble(parameters[1]);
                    direction = parameters[2];

                    rules.Clear();
                    string[] rule;
                    for (int i = 1; i < flines.Length; ++i)
                    {
                        rule = flines[i].Split('→');
                        rules[Convert.ToChar(rule[0])] = rule[1];
                    }
                    numericUpDown1.Value = 0;
                    file_label.Text = "Loaded file: " + openDialog.SafeFileName;

                }
                catch
                {
                    DialogResult result = MessageBox.Show("Can't open file",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void draw()
        {
            g.Clear(Color.White);

            iterations = Convert.ToInt32(numericUpDown1.Value);
            string path = buildPath();
            drawLSystem(path);
            pictureBox1.Invalidate();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            draw();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            iterations = Convert.ToInt32(numericUpDown1.Value);
            iterations++;
            numericUpDown1.Value = iterations;
            draw();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Axiom: " + axiom + "\n\nRules:\n" + prettyrules + "\nPath:\n" + path, rules.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void file_label_Click(object sender, EventArgs e)
        {

        }
    }
}
