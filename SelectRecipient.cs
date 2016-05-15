using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace wordAnswer
{
    public partial class SelectRecipient : Form
    {
        List<Recipient> listRecipient = new List<Recipient>();

        public SelectRecipient()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            CommonClass.forRecipient = richTextBox1.Text;
            this.Close();
        }

        private void buttonCans_Click(object sender, EventArgs e)
        {
            CommonClass.forRecipient = "";
            this.Close();
        }

        private void SelectRecipient_Load(object sender, EventArgs e)
        {            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Recipient>));
            
            serializer.UnknownNode += new
            XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new
            XmlAttributeEventHandler(serializer_UnknownAttribute);

            
            FileStream fs = new FileStream("input.xml", FileMode.Open);

            listRecipient = (List<Recipient>)serializer.Deserialize(fs);
            fs.Close();

            foreach(Recipient r in listRecipient)
                comboBox1.Items.Add(r.shortName);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

        }

        private void serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        private void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = listRecipient[comboBox1.SelectedIndex].fullName;
            buttonOK.Enabled = true;
        }
    }
}
