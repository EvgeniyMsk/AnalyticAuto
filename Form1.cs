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
using exporttoword = Microsoft.Office.Interop.Word;

namespace TasLight2
{
    
    public partial class Form1 : Form
    {
        DateTime startTime;
        private List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            treeView1.AllowDrop = true;
            treeView1.DragEnter += new DragEventHandler(treeView1_DragEnter);
            treeView1.DragDrop += new DragEventHandler(treeView1_DragDrop);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))

                e.Effect = DragDropEffects.Move;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                string fileName = objects[0];
                int counter = 0;
                people.Clear();
                treeView1.Nodes.Clear();
                if (fileName.Contains(".csv"))
                {
                    TreeNode root = new TreeNode("Root");
                    treeView1.Nodes.Add(root);
                    StreamReader reader = new StreamReader(fileName, Encoding.Default);
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Person person = new Person();
                        string[] data = line.Split(';');
                        if (data.Length == 4)
                        {
                            person.lastname = data[0];
                            person.firstname = data[1];
                            person.patronymic = data[2];
                            person.birth = data[3];
                            people.Add(person);
                            counter++;
                        }
                        else if (data.Length == 3)
                        {
                            person.lastname = data[0];
                            person.firstname = data[1];
                            person.patronymic = data[2];
                            person.birth = "";
                            people.Add(person);
                            counter++;
                        }
                    }

                    foreach (Person person in people)
                    {
                        root.Nodes.Add(person.lastname + " " + person.firstname + " " + person.patronymic + " " + person.birth);
                    }
                    MessageBox.Show("Прочитано " + people.Count + " человек(а)!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    treeView1.ExpandAll();
                }

            }
        }

        private void selectKeys(string searchKey)
        {
            int posStart = richTextBox1.Text.Length; // сохраняем позицию курсора
            int i = 0, sl = searchKey.Length;
            int firstPos = richTextBox1.Text.IndexOf(searchKey, i);
            richTextBox1.Select(firstPos, sl);
            richTextBox1.ScrollToCaret();
            while (i <= richTextBox1.Text.Length - sl)
            {
                i = richTextBox1.Text.IndexOf(searchKey, i);
                if (i < 0) break;
                richTextBox1.Select(i, sl); //выделяем слово
                richTextBox1.SelectionColor = Color.Red; //меняем цвет выделенному слову
                richTextBox1.SelectionBackColor = Color.Blue;
                i += sl;
                richTextBox1.SelectionStart = posStart; // курсор в начальное положение
                richTextBox1.SelectionColor = Color.Black; // текст снова черный
                richTextBox1.SelectionBackColor = Color.White;
            }
        }

        private void exportToWord(string searchKey)
        {
            int i = 0, sl = searchKey.Length;
            int firstPos = richTextBox1.Text.IndexOf(searchKey, i);
            exporttoword.Application wordapp = new exporttoword.Application();
            wordapp.Visible = true;
            exporttoword.Document worddoc;
            object wordobj = System.Reflection.Missing.Value;
            worddoc = wordapp.Documents.Add(ref wordobj);
            if (firstPos - 2000 < 0)
            {
                firstPos = 0;
            }
            int length = firstPos + 2000;
            string data = "";
            if (length > richTextBox1.Text.Length)
            {
                data = richTextBox1.Text.Substring(firstPos);
            }
            else
            {
                data = richTextBox1.Text.Substring(firstPos, 2000);
            }
            wordapp.Selection.TypeText(data);
            wordapp.Selection.TypeText("100");
            wordapp = null;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void начатьПроверкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            startTime = DateTime.Now;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - startTime;
            label1.Text = "Прошло: " + string.Format("{0}:{1:mm':'ss}", (int)ts.TotalHours, ts);
            progressBar1.Value = progressBar1.Value + 1;
            this.Text = "АналитикАвто " + progressBar1.Value.ToString() + "%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списокБанковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void добавитьЧеловекаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        internal void addPerson(Person person)
        {
            this.people.Add(person);
            treeView1.Nodes[0].Nodes.Add(person.lastname + " " + person.firstname + " " + person.patronymic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Hello");
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.people.Clear();
            this.timer1.Stop();
            this.richTextBox1.Clear();
            this.label1.Text = "Прошло времени:";
            this.Text = "АналитикАвто";
            this.treeView1.Nodes.Clear();
            this.progressBar1.Value = 0;
        }

        private void учтенныеСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selectKeys("Бориса");
        }

        private void экспортВWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void весьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SaveFile("E:\\1.rtf");
        }

        private void толькоКонтекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportToWord("Бормса");
        }
    }
}
