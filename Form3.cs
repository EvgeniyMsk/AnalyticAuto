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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1) Application.OpenForms[0];
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                try
                {
                    Person person = new Person();
                    person.lastname = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    person.firstname = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    person.patronymic = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    form.addPerson(person);
                } catch (Exception) {
                    MessageBox.Show("Ошибка введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dataGridView1.Rows.Clear();
            form.Show();
        }
    }
}
