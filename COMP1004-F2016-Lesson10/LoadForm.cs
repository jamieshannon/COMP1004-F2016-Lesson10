using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Required for file IO
using System.IO;

namespace COMP1004_F2016_Lesson10
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> FullName = new List<string>();

                // Step 1 - Create a StreamReader object
                StreamReader reader = new StreamReader("Names.txt");

                // Step 2 - use ReadLine method to read the data
                while (reader.Peek() != -1)
                {
                    string FullNameString = reader.ReadLine();
                    FullNamesListBox.Items.Add(FullNameString);
                }
                

                // step 2 - Close the Stream
                reader.Close();

                /*
                string[] linestring = FullNameString.Split(' ');
                FirstNameTextBox.Text = linestring[0];
                LastNameTextBox.Text = linestring[1];
                */

                /* Alternate way
                int spaceIndex = FullNameString.IndexOf(' ');
                FirstNameTextBox.Text = FullNameString.Substring(0, spaceIndex);
                LastNameTextBox.Text = FullNameString.Substring(spaceIndex + 1);
                */
            }
            catch
            {
                MessageBox.Show("File Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
