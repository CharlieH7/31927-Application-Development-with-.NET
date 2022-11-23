using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class TextEditorForm : Form
    {
        LoginForm loginForm;
        string currentFile;
        string userType;
        string name;
        public TextEditorForm(LoginForm loginForm, string userType, string name)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.userType = userType;
            this.name = name;
        }
        
        // check if the usertype is equals to view or not, if it's view then disable the richtextbox and all the toolstrip.
        // also change the username label to the current username from the loginform
        private void TextEditorForm_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = $"Currently logged in as: {this.name} ({this.userType})";
            if (userType == "View")
            {
                richTextBox1.Enabled = false;
                TopToolStrip.Enabled = false;
                LeftToolStrip.Enabled = false;
            }
        }

        // called when the about toolstrip menu item is called, display a message box with author, version number, etc..
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text editor\nVersion Number: 1.0.0\nCreated by Charlie Huang", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // when cut is clicked then cut the text in the richtextbox
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        // when copy is clicked then cut the text in the richtextbox
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        // paste the contents in the clickboard
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        // new file button which makes the richtextbox empty
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        // new file tool strip menu item which makes the richtextbox empty
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        // Open menu will allow to select a text file and load all the text from the file into the the richtextbox area
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open";
            dialog.Filter = "Plain Text files (*.txt)|*.txt|" + "Rich Text Format files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                Text = currentFile;
                string fileExtension = Path.GetExtension(currentFile);
                if (fileExtension == ".txt")
                {
                    richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
                }    
                else if (fileExtension == ".rtf")
                {
                    richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.RichText);
                }   
            }
        }

        // save the file based on the format chosen
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileExtension = Path.GetExtension(currentFile);
            if (fileExtension == ".txt")
            {
                richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
            }
            else if (fileExtension == ".rtf")
            {
                richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.RichText);
            }
        }

        // save the file based on the format chosen (open a new dialog)
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As";
            dialog.Filter = "Plain Text files (*.txt)|*.txt|" + "Rich Text Format files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                Text = currentFile;
                string fileExtension = Path.GetExtension(currentFile);
                if (fileExtension == ".txt")
                {
                    richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
                }
                else if (fileExtension == ".rtf")
                {
                    richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.RichText);
                }
            }
        }

        // logout tool strip menu item clicked will close the text editor and open the login form
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        // called when the about toolstrip menu item is called, display a message box with author, version number, etc..
        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text editor\nVersion Number: 1.0.0\nCreated by Charlie Huang", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // cut the text in richtextbox
        private void CutButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        // copy the text in richtextbox
        private void CopyButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        // paste the text in richtextbox
        private void PasteButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        // Open menu will allow to select a text file and load all the text from the file into the the richtextbox area
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open";
            dialog.Filter = "Plain Text files (*.txt)|*.txt|" + "Rich Text Format files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                Text = currentFile;
                string fileExtension = Path.GetExtension(currentFile);
                if (fileExtension == ".txt")
                {
                    richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
                }
                else if (fileExtension == ".rtf")
                {
                    richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.RichText);
                }
            }
        }

        // save the file based on the format chosen
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string fileExtension = Path.GetExtension(currentFile);
            if (fileExtension == ".rtf")
            {
                File.WriteAllText(currentFile, richTextBox1.Rtf);
            }
            else if (fileExtension == ".txt")
            {
                File.WriteAllText(currentFile, richTextBox1.Text);
            }
        }

        // save the file based on the format chosen (open a new dialog)
        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As";
            dialog.Filter = "Plain Text files (*.txt)|*.txt|" + "Rich Text Format files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                Text = currentFile;
                string fileExtension = Path.GetExtension(currentFile);
                if (fileExtension == ".rtf")
                {
                    File.WriteAllText(currentFile, richTextBox1.Rtf);
                }
                else if (fileExtension == ".txt")
                {
                    File.WriteAllText(currentFile, richTextBox1.Text);
                }

            }
        }

        // change the selected text in richtextbox into bold with certain conditions.
        private void BoldButton_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (font.Bold)
            {
                if (font.Italic && font.Underline)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Italic | FontStyle.Underline);
                }
                else if (font.Underline)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Underline);
                }
                else if (font.Italic)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Regular);
                }
                BoldButton.Checked = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(font, font.Style | FontStyle.Bold);
                BoldButton.Checked = true;
            }
        }

        // change the selected text in richtextbox into italics with certain conditions.
        private void ItalicsButton_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (font.Italic)
            {
                if (font.Bold && font.Underline)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Bold | FontStyle.Underline);
                }
                else if (font.Underline)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Underline);
                }
                else if (font.Bold)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Regular);
                }
                ItalicsButton.Checked = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(font, font.Style | FontStyle.Italic);
                ItalicsButton.Checked = true;
            }
        }

        // change the selected text in richtextbox into underline with certain conditions.
        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (font.Underline)
            {
                if (font.Bold && font.Italic)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Bold | FontStyle.Italic);
                }
                else if (font.Italic)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Italic);
                }
                else if (font.Bold)
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(font, FontStyle.Regular);
                }
                UnderlineButton.Checked = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(font, font.Style | FontStyle.Underline);
                UnderlineButton.Checked = true;
            }
        }

        // change the selected text in richtextbox into differnet font size based on the size selected in the combo box
        private void FontComboBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToSingle(FontComboBox.SelectedItem), richTextBox1.SelectionFont.Style);
        }
    }
}
