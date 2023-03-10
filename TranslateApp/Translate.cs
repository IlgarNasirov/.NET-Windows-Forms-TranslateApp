using System;
using System.Windows.Forms;
using TranslateApp.Services;
using TranslateApp.Entities;

namespace TranslateApp
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fromText.Text))
            MessageBox.Show("From text could not empty!","Error");
            wait.Visible = true;
            TranslateEntity translateEntity=new TranslateEntity { Text = fromText.Text, To = comboBoxLanguages.Text.Split('-')[1]};
            TranslateService translateService=new TranslateService();
            string result=translateService.Translate(translateEntity);
            wait.Visible = false;
            if (result == null)
            {
                MessageBox.Show("Some errors occured!", "Error");
            }
            else
            {
                toText.Text = result;
            }
        }
    }
}
