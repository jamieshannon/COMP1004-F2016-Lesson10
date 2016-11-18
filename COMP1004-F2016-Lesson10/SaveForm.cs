using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace COMP1004_F2016_Lesson10
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }   

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // Step 1 - Open a stream
                StreamWriter writer = new StreamWriter("Names.txt", true);

                // Step 2 - Write to the buffer
                writer.WriteLine(FirstNameTextBox.Text + " " + LastNameTextBox.Text);

                // Step 3 - Close the file
                writer.Close();

                //Step 4 - Reset the Form
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                FirstNameTextBox.Focus();
            }
            else
            {
                FirstNameTextBox.Focus();
                FirstNameTextBox.SelectAll();
            }
        }
    }
}
