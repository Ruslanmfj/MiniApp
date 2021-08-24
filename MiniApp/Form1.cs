using System;
using System.Windows.Forms;
using System.IO;

namespace MiniApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Loadandrun_Click(object sender, EventArgs e)
        {
            int PC = 0;
            int NB = 0;
            int Other = 0;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName,System.Text.Encoding.UTF8,false))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Remove(7, line.Length - 7);
                        string line2 = line.Remove(0, 5);
                        if (line2 == "PC") PC++;
                        else if (line2 == "NB") NB++;
                        else
                        {
                            Other++;
                            Returned.Text = Returned.Text + "\n" + line;
                        }
                    }
                }
                Returned.Text = Returned.Text + "\n" + "Компьютеры: "+PC.ToString();
                Returned.Text = Returned.Text + "\n" + "Ноутбуки: "+NB.ToString();
                Returned.Text = Returned.Text + "\n" + "Другие: "+Other.ToString();
                Returned.Text = Returned.Text + "\n" + "Всего: "+(PC+NB+Other).ToString();
            }
        }
    }
}
