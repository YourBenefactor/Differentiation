using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;

namespace Дифференцирование
{
    public partial class FunctionGraphic : Form
    {
        private const double h = 0.05f;

        private Func<double, double, double> function;
        private List<string> xValues;
        private LiveCharts.ChartValues<double> yValues;
        private double x, y, b, k0, k1, k2, k3;

        public FunctionGraphic()
        {
            InitializeComponent();
        }

        private void FunctionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Info.Clear();
            int selectedFunction = FunctionBox.SelectedIndex;
            switch (selectedFunction)
            {
                case 0:
                    SetFunction(Function1);
                    SetFunctionInfo(1.0, 1.0, 2.0);
                    SetImageOfFunction(0);
                    break;
                case 1:
                    SetFunction(Function2);
                    SetFunctionInfo(0.0, 1.0, 1.0);
                    SetImageOfFunction(1);
                    break;
                case 2:
                    SetFunction(Function3);
                    SetFunctionInfo(0.0, 1.0, 1.0);
                    SetImageOfFunction(2);
                    break;
                case 3:
                    SetFunction(Function4);
                    SetFunctionInfo(3.0, 3.0, 4.0);
                    SetImageOfFunction(3);
                    break;
                case 4:
                    SetFunction(Function5);
                    SetFunctionInfo(0.0, 1.0, 1.0);
                    SetImageOfFunction(4);
                    break;
            }
            SetDefaults();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            SetDefaults();
            SolveEquation();
        }

        private void SetDefaults()
        {
            xValues = new List<string>();
            yValues = new LiveCharts.ChartValues<double>();
            k0 = 0; k1 = 0; k2 = 0; k3 = 0;

            Table.Rows.Clear();
            Table.Update();

            Graphic.AxisX.Clear();
            Graphic.AxisY.Clear();
        }

        private void SolveEquation()
        {
            if (function == null) return;
            while (x <= b + h)
            {
                SendValuesToTable();
                CalculateValues();
                TakeStep();
            }
            SendValuesToGraphic();
        }

        private void SendValuesToTable()
        {
            Table.Rows.Add(x, k0, k1, k2, k3, y);
            xValues.Add(Math.Round(x,2).ToString());
            yValues.Add(Math.Round(y,2));
        }

        private void CalculateValues()
        {
            k0 = h * function(x, y);
            k1 = h * function(x + h / 2.0, y + k0 / 2.0);
            k2 = h * function(x + h / 2.0, y + k1 / 2.0);
            k3 = h * function(x + h, y + k2);
            y += 1.0 / 6.0 * (k0 + 2.0 * k1 + 2.0 * k2 + k3);
        }

        private void TakeStep()
        {
            x += h;
        }

        private void SendValuesToGraphic()
        {
            LiveCharts.SeriesCollection seriesCollection = new LiveCharts.SeriesCollection();

            Graphic.AxisX.Add(new Axis()
            {
                Labels = xValues
            });

            LineSeries line = new LineSeries();
            line.Title = "Y";
            line.Values = yValues;
            seriesCollection.Add(line);

            Graphic.Series = seriesCollection;
        }

        private void SetFunction(Func<double, double, double> function)
        {
            this.function = function;
        }

        private void SetFunctionInfo(double x, double y, double b)
        {
            this.x = x; this.b = b; this.y = y;
            AddLine(Info, $"X0 = {x}");
            AddLine(Info, $"Y0 = {y}");
            AddLine(Info, $"B = {b}");
            AddLine(Info, $"H = {Math.Round(h,2)}");
        }

        private void SetImageOfFunction(int index)
        {
            ImageOfFunction.Image = FunctionsIMG.Images[index];
        }

        private void AddLine(TextBox textBox, string line)
        {
            textBox.Text += line;
            textBox.Text += "\r\n";
        }

        private double Function1(double x, double y)
        {
            return x * Math.Pow(Math.Sin(y), 2.0);
        }

        private double Function2(double x, double y)
        {
            return x/Math.Sqrt(2)*y;
        }

        private double Function3(double x, double y)
        {
            return 2*x*Math.Sqrt(y);
        }

        private double Function4(double x, double y)
        {
            return Math.Sqrt(x*y);
        }

        private double Function5(double x, double y)
        {
            return y * Math.Cos(x);
        }
    }
}
