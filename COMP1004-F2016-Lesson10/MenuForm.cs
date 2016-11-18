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

namespace COMP1004_F2016_Lesson10
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*"; 

            //Opne the Dialog Box by using showDialog()
            DialogResult result = openFileDialog.ShowDialog();
            
            //If the result is not cancel then open the file
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Step 1 - Create a StreamReader object and pass in the FileName
                    StreamReader reader = new StreamReader(openFileDialog.FileName);

                    // Step 2 - Read in the data with ReadLine

                    // recommended to read your data into an object so that you can pass
                    // it to the next form

                    // Step 3 - Close the Stream
                    reader.Close();
                }
                catch
                {

                    MessageBox.Show("Some Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /*
            LoadForm loadForm = new LoadForm();
            loadForm.Show();
            this.Hide();
            */
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Specify properties for the saveFileDialog
            saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Title = "Save File";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                // Step 1 - Create n instance of the StreamWriter object and pass in the file name 
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName, true);

                // Step 2 - Writer.WriteLine to write the data to the file

                // Step 3 - Close the stream
                writer.Close();
            }
            /*
            SaveForm saveForm = new SaveForm();
            saveForm.Show();
            this.Hide();
            */
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadButton.Focus();
        }
    }
}
