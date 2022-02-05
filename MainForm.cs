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

namespace PractWork5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int d, n, crypt = 1, file= 0, fldr = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = 1;
                textTextBox.Text = openFileDialog.FileName;
            }
        }

        private void CrButtonOnClick(object sender, EventArgs e)
        {
            if (textTextBox.Text != "")
            {
                if (file == 0 && fldr == 0)
                {
                    textTextBox.Text = CryptText(textTextBox.Text);
                }
                else
                {
                    if (file == 1)
                    {
                        string res ="";
                        
                        byte[] str = File.ReadAllBytes(textTextBox.Text.TrimEnd());
                        for (int i = 0; i < str.Length; i++)
                        {
                            res += CryptText(str[i].ToString());
                        }
                        resTextBox.Text = res;
                    }
                    else
                    {
                        //string[,] res = null;
                        string[] arrFileNames = textTextBox.Text.Split(' ');
                        foreach (var file in arrFileNames)
                        {
                            if (file != "")
                            {
                                byte[] str = File.ReadAllBytes(file);
                                string[] res = new string[str.Length];
                                for (int i = 0; i < str.Length; i++)
                                {
                                    res[i] = CryptText(str[i].ToString());
                                    resTextBox.Text += res[i];
                                }
                                resTextBox.Text += Environment.NewLine;
                            }
                        }
                        
                        MessageBox.Show("Файлы успешно зашифрованы!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите текст или выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {}

        private void label2_Click(object sender, EventArgs e)
        { }

        private void FolderButtonOnClick(object sender, EventArgs e)
        {
            file = 2;
            string folderNames = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in Directory.GetFiles(folder.SelectedPath))
                {
                    folderNames += item + " ";
                } 
                textTextBox.Text = folderNames;  
            }
        }

        private void UncrButtonOnClick(object sender, EventArgs e)
        {
            if (textTextBox.Text == "")
            {
                MessageBox.Show("Введите текст или выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (file == 0 && fldr == 0)
                {
                    textTextBox.Text = UncryptText(textTextBox.Text);
                }
                else if(file == 1)
                {
                    resTextBox.Text = UncryptText(resTextBox.Text);
                }
                else 
                    resTextBox.Text = UncryptText(resTextBox.Text);
            }
        }
        public string UncryptText(string text)
        {
            List<int> arrCode = new List<int>();
            string mbx = "";
            if (file == 2)
            {
                string[] splitStr = text.Split(new char[] {'\r', '\n' });
                for (int i = 0; i < splitStr.Length; i++)
                {
                    string[] str = splitStr[i].Split(' ');
                    foreach (var item in str)
                    {
                        if (item != "")
                        {
                            for (int j = 0; j < d; j++)
                            {
                                crypt = (Convert.ToInt32(item) * crypt) % n;
                            }
                            mbx += (char)crypt;
                        }
                    }
                };
            }
            else
            {
                foreach (var item in text.Split(' '))
                {
                    if (item != "")
                        arrCode.Add(Convert.ToInt32(item));
                }
                foreach (var item in arrCode)
                {
                    for (int i = 0; i < d; i++)
                    {
                        crypt = (item * crypt) % n;
                    }
                    mbx += (char)crypt;
                }
            }
            return mbx;
        }
        public string CryptText(string text) 
        {
            int q, p, f, ex;
            Random random = new Random();
            q = random.Next(3, 100);
            p = random.Next(3, 100);
            bool past = false;
            while (past == false)
            {
                past = true;
                for (int i = 2; i < q; i++)
                {
                    if (q % i == 0 || q*p < 255)
                    {
                        past = false;
                        q = random.Next(3, 100);
                        break;
                    }
                }
               
            }
            past = false;
           
            while (past == false)
            {
                past = true;
                for (int i = 2; i < p; i++)
                {
                    if (p % i == 0 || q * p < 255)
                    {
                        past = false;
                        p = random.Next(3, 100);
                        break;
                    }
                }
               
            }
            n = q * p;
            f = (p - 1) * (q - 1);
            ex = random.Next(2, f - 1);
            past = false;
            while (past == false)
            {
                past = true;
                for (int i = 2; i < ex; i++)
                {
                    if (ex % i == 0)
                    {
                        past = false;

                        ex = random.Next(2, f - 1);

                        break;
                    }
                }
            }
            d = random.Next(2, f);
            past = false;
            while (past == false)
            {
                past = true;
                for (int i = 2; i < d; i++)
                {
                    if (d % i == 0 || (d * ex) % f != 1 || d == ex)
                    {
                        past = false;

                        d = random.Next(2, f);

                        break;
                    }
                }
            }
            //MessageBox.Show(ex.ToString() + "=" + d.ToString());
            string mbx = "";
            foreach (char item in text)
            {
                for (int i = 0; i < ex; i++)
                {
                    crypt = ((int)item * crypt) % n;
                }

                mbx += crypt.ToString() + " ";
            }
            return mbx;
        }
    }
}
