using System;
using System.Windows.Forms;

namespace kpl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string namaPraktikan = textBoxInput.Text;

            if (!string.IsNullOrWhiteSpace(namaPraktikan))
            {
                labelOutput.Text = "Halo " + namaPraktikan;
            }
            else
            {
                MessageBox.Show("Mohon isi nama praktikan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}