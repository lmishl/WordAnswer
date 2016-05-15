using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordAnswer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void buttonCans_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IspolPhone = textBoxIspolPhone.Text.ToString();
            Properties.Settings.Default.IspolFIO = textBoxIspolFIO.Text.ToString();
            Properties.Settings.Default.NachFIO = textBoxNachFIO.Text.ToString();
            Properties.Settings.Default.NachDolz = textBoxNachDolz.Text.ToString();
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBoxIspolFIO.Text = Properties.Settings.Default.IspolFIO;
            textBoxIspolPhone.Text = Properties.Settings.Default.IspolPhone;
            textBoxNachFIO.Text = Properties.Settings.Default.NachFIO;
            textBoxNachDolz.Text = Properties.Settings.Default.NachDolz;
        }
    }
}
