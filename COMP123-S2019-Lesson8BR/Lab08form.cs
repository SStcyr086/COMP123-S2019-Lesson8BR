using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8BR
{
    public partial class Lab08 : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        public Lab08()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the lab08FormLoad event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //SubmitButton.Enabled = false;
            ClearForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Event handler for sumbit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            UserAge = float.Parse(AgeTextBox.Text);

            OutPutLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();
        }

        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// input validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UserAge = float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }

        /// <summary>
        ///  input event handler for name textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}