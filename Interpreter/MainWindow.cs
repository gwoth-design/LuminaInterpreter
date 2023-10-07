using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interpreter
{
    public partial class LuminaMainWindow : Form
    {
        private bool Saved = true;
        private bool SavedAtLeastOnce = false;
        private string OpenFileSavedLocation = "";
        public LuminaMainWindow()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        //New File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void NewFile()
        {
            if (!Saved)
            {
                DialogResult result = MessageBox.Show("Do You Want To Save Your Work", "Confirm New File", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }
            CodeMain.Clear();
            Saved = true;
            SavedAtLeastOnce = false;
            OpenFileSavedLocation = "";
            SaveLabel.Text = "Saved";
        }
        //set save to false
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Saved = false;
            SaveLabel.Text = "Not Saved";
        }

        //The Save Button / Function
        private void saveCopyAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            string Code = CodeMain.Text;
            bool continues = true;
            if(!SavedAtLeastOnce)
            {
                SaveAs();
                continues = false;
            }
            if (continues)
            {
                string filePath = OpenFileSavedLocation;

                try
                {
                    // Open the file for writing (create if it doesn't exist)
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Write some text to the file
                        writer.WriteLine(Code);
                    }

                    Console.WriteLine("Data has been written to the file.");
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
                Saved = true;
                SaveLabel.Text = "Saved";
            }
            

        }
        //save as
        private void saveCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Lumina File(*.lum)|*.lum";
            saveFileDialog.Title = "Save Data File";
            saveFileDialog.ShowDialog();
            //set up dialog and show it

            // If the file name is not an empty string, open it for saving.
            if (saveFileDialog.FileName != "")
            {
                // Get the text from your RichTextBox
                string textToSave = CodeMain.Text;

                // Create a StreamWriter to write the text to the selected file.
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.Write(textToSave);
                }
                OpenFileSavedLocation = saveFileDialog.FileName;
                Saved = true;
                SaveLabel.Text = "Saved";
                if (!SavedAtLeastOnce)
                {
                    SavedAtLeastOnce = true;
                }
            }

        }
        //close ide
        private void closeIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        //x button close ide
        private void LuminaMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // The close window button was pressed by the user
                // You can put your custom logic here
                // For example, ask the user for confirmation
                if (!Saved)
                {
                    DialogResult result = MessageBox.Show("Do You Want To Save Your Work", "Confirm Exit", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Save();
                    }
                }

            }

            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                AutoSave(true);
            }
        }

        private void AutoSave(bool Shutdown)
        {
            string filePath = "";
            string Code = CodeMain.Text;
            if(OpenFileSavedLocation == "")
            {
                if (Shutdown)
                {
                    filePath = "ESave.lum";//emergency save feature
                }
            }
            else
            {
                filePath = OpenFileSavedLocation;
            }
            

            try
            {
                // Open the file for writing (create if it doesn't exist)
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write some text to the file
                    writer.WriteLine(Code);
                }

                Console.WriteLine("Data has been written to the file.");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        private void CloseWindow()
        {
            if (!Saved)
            {
                DialogResult result = MessageBox.Show("Do You Want To Save Your Work", "Confirm Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }
            Application.Exit();
        }

        //open file
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Lumina File(*.lum)|*.lum";
            openFileDialog.Title = "Open Data File";
            openFileDialog.ShowDialog();
            //setup the openfiledialogue

            if (!Saved)
            {
                DialogResult result = MessageBox.Show("Do You Want To Save Your Work", "Confirm Exit", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }

            if (openFileDialog.FileName != "")
            {
                // Create a StreamWriter to write the text to the selected file.
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string Code = sr.ReadToEnd();
                    CodeMain.Text = Code;
                }
            }
            OpenFileSavedLocation = openFileDialog.FileName;//set to the opened file location

            SavedAtLeastOnce = true;
            Saved = true;
            SaveLabel.Text = "Saved";
        }

        private void configureIDLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //RUN PROGRAM
        private void runProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallRun();
        }
        //PROGRAM CALLS THE INTERPRETER TO DO ITS THING
        private void CallRun()
        {
            Lumina Lumina = new Lumina();
            if (!Saved)
            {
                DialogResult result = MessageBox.Show("You MUST Save Your Work Before Running", "Save Before Run", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }
            Lumina.StartProgram(CodeMain.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaveLabel.Text = "Saved";
            this.KeyPreview = true;

            // Attach the KeyDown event handler
            //this.KeyDown += new KeyEventHandler(LuminaMainWindow_KeyDown);
        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {

        }
        //undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }
        private void Undo()
        {
            CodeMain.Undo();
        }
        //redo
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }
        private void Redo()
        {
            CodeMain.Redo();
        }
        //selct all
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecA();
        }
        private void SelecA()
        {
            CodeMain.SelectAll();
        }
        //cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }
        private void Cut()
        {
            CodeMain.Cut();
        }
        //copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void Copy()
        {
            CodeMain.Copy();
        }
        //paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }
        private void Paste()
        {
            CodeMain.Paste();
        }
        //find
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find();
        }
        private void Find()
        {
            //CodeMain.Find();
        }
        //replace
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace();
        }
        private void Replace()
        {
            
        }

        private void LuminaMainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Control key and S key are pressed simultaneously
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                // Perform your desired action here, such as saving the data.
                // Replace this with your actual code.
                Save();

                // Prevent the event from being processed further (e.g., beep sound)
                
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                Open();

                // Prevent the event from being processed further (e.g., beep sound)
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                NewFile();

                // Prevent the event from being processed further (e.g., beep sound)
                e.SuppressKeyPress = true;
            }


            else if(e.KeyCode == Keys.F5)
            {
                CallRun();
            }
        }


    }
}
