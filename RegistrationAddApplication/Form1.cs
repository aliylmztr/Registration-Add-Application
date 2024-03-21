using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistrationAddApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            string resimYolu = openFileDialog.FileName;

            pictureBox1.Image = Image.FromFile(resimYolu);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for(int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if(groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is RichTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }
    }
}
