using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasLight2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Titles.Clear();
            chart1.Series[0].Points.AddXY("1 отдел", "10000");
            chart1.Series[0].Points.AddXY("2 отдел", "8000");
            chart1.Series[0].Points.AddXY("3 отдел", "7000");
            chart1.Series[0].Points.AddXY("4 отдел", "10000");
            chart1.Series[0].Points.AddXY("5 отдел", "8500");
            chart1.Series[0].Points.AddXY("6 отдел", "10000");
            chart1.Series[0].Points.AddXY("7 отдел", "8000");
            chart1.Series[0].Points.AddXY("8 отдел", "7000");
            chart1.Series[0].Points.AddXY("9 отдел", "10000");
            chart1.Series[0].Points.AddXY("10 отдел", "8500");
            chart1.Series[0].Points.AddXY("11 отдел", "8500");
            chart1.Series[0].Points.AddXY("12 отдел", "8500");
            chart1.Series[0].Points.AddXY("13 отдел", "8500");
            chart1.Titles.Add("Статистика учтенных справок с " + dateTimePicker1.Value.Date.ToString("dd.MM.yyyy") + " по " + dateTimePicker2.Value.Date.ToString("dd.MM.yyyy"));
            chart1.Titles[0].Font = button1.Font;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Titles.Clear();
            chart1.Series[0].Points.AddXY("1 отдел", "10000");
            chart1.Series[0].Points.AddXY("2 отдел", "8000");
            chart1.Series[0].Points.AddXY("3 отдел", "7000");
            chart1.Series[0].Points.AddXY("4 отдел", "10000");
            chart1.Series[0].Points.AddXY("5 отдел", "8500");
            chart1.Series[0].Points.AddXY("6 отдел", "10000");
            chart1.Series[0].Points.AddXY("7 отдел", "8000");
            chart1.Series[0].Points.AddXY("8 отдел", "7000");
            chart1.Series[0].Points.AddXY("9 отдел", "10000");
            chart1.Series[0].Points.AddXY("10 отдел", "8500");
            chart1.Series[0].Points.AddXY("11 отдел", "8500");
            chart1.Series[0].Points.AddXY("12 отдел", "8500");
            chart1.Series[0].Points.AddXY("13 отдел", "8500");
            chart1.Titles.Add("Статистика учтенных справок с " + dateTimePicker1.Value.Date.ToString("dd.MM.yyyy") + " по " + dateTimePicker2.Value.Date.ToString("dd.MM.yyyy"));
            chart1.Titles[0].Font = button1.Font;
        }
    }
}
