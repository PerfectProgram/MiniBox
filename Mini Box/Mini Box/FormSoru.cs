using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace Mini_Box
{
    public partial class FormSoru : DevExpress.XtraEditors.XtraForm
    {
        StreamReader degisken_okuyucu,toolbox_okuyucu;
        ArrayList toolbox = new ArrayList(100);
        ArrayList degisken = new ArrayList(100);
        int sayac;
        public FormSoru()
        {
            InitializeComponent();
        }

        private void FormSoru_Load(object sender, EventArgs e)
        {
            degisken_okuyucu = new StreamReader(Application.StartupPath + @"\degisken.txt");
            var okuma = degisken_okuyucu.ReadLine();
            while (okuma != null)
            {
                okuma = okuma.Substring(3);
                degisken.Add(okuma);
                okuma = degisken_okuyucu.ReadLine();
            }
            degisken_okuyucu = null;
            toolbox_okuyucu = new StreamReader(Application.StartupPath + @"\toolbox.txt");
            okuma = toolbox_okuyucu.ReadLine();
            while (okuma!= null)
            {
                okuma = okuma.Substring(3);
                toolbox.Add(okuma);
                okuma = toolbox_okuyucu.ReadLine();
            }
            foreach (var item in toolbox)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            sayac = 0;
            if (radioButton1.Checked)
            {
                foreach (var item in toolbox)
                {
                    comboBox1.Items.Add(toolbox[sayac]);
                    sayac++;
                }
            }
            else
            {
                foreach (var item in degisken)
                {
                    comboBox1.Items.Add(degisken[sayac]);
                    sayac++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Width = this.Width - 2;
                if (this.Width <= 314)
                {
                    timer1.Enabled = false;
                }
            }
            else if (this.Width < 494)
            {
                this.Width = this.Width + 2;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                timer1.Enabled = true;
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir seçim yap.");
                    return;
                }
                #region veri okuma
                degisken_okuyucu = new StreamReader(Application.StartupPath + @"\degisken.txt");
                var okuma = degisken_okuyucu.ReadLine();
                while (okuma != null)
                {
                    if (okuma.Contains(comboBox1.SelectedItem.ToString()))
                    {
                        break;
                    }
                    else
                    {
                        okuma = degisken_okuyucu.ReadLine();
                    }
                }
                var number = okuma.Substring(0, 2);
                degisken_okuyucu = null;
                degisken_okuyucu = new StreamReader(Application.StartupPath + @"\degisken_aciklama.txt");
                okuma = degisken_okuyucu.ReadLine();
                while (okuma != null)
                {
                    if (okuma.Contains(number))
                    {
                        break;
                    }
                    else
                    {
                        okuma = degisken_okuyucu.ReadLine();
                    }
                }
                var aciklama = okuma.Substring(3);
                #endregion
                richTextBox1.Text = aciklama;
                #region resim bölümü
                pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\tex\ornek.png");
                #endregion
            }
            else if (radioButton1.Checked)
            {
                timer1.Enabled = true;
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir seçim yap.");
                    return;
                }
                toolbox_okuyucu = new StreamReader(Application.StartupPath + @"\toolbox.txt");
                var okuma = toolbox_okuyucu.ReadLine();
                while (okuma != null)
                {
                    if (okuma.Contains(comboBox1.SelectedItem.ToString()))
                    {
                        break;
                    }
                    else
                    {
                        okuma = toolbox_okuyucu.ReadLine();
                    }
                }
                var number = okuma.Substring(0, 2);
                toolbox_okuyucu = null;
                toolbox_okuyucu = new StreamReader(Application.StartupPath + @"\toolbox_aciklama.txt");
                okuma = toolbox_okuyucu.ReadLine();
                while (okuma != null)
                {
                    if (okuma.Contains(number))
                    {
                        break;
                    }
                    else
                    {
                        okuma = toolbox_okuyucu.ReadLine();
                    }
                }
                var aciklama = okuma.Substring(3);
                richTextBox1.Text = aciklama;
            }
        }
    }
}