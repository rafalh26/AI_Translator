using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AI_Translator
{
    public partial class mainForm : Form
    {
        string inputPrompt = string.Empty;
        TalkWithMe talk;
        private OnScreenKeyboard onScreenKeyboard;
        DataHandler dataTransfer;

        public mainForm()
        {
            InitializeComponent();
            talk = new TalkWithMe();
            //greetings();                                  // DON'T FORGET TO TURN IT ON AGAIN !!!!!!!!!!!!!!!!!!!!!!
            fromLanguageList.SelectedIndex = 0;
            toLanguageList.SelectedIndex = 1;

        }


        private async void greetings()
        {
            inputPrompt = "Translate the word 'Hello' into the following languages:";
            for (int i = 0; i < fromLanguageList.Items.Count; i++)
            {
                inputPrompt += fromLanguageList.Items[i].ToString() + "\r\n";
            }
            MessageBox.Show(await talk.talkToMe(inputPrompt));
        }







        //==========================EVENTS==========================================//



        public async void translateButton_Click(object sender, EventArgs e)
        {
            inputPrompt = "Translate this:\n" + inputBox.Text + "\n" + " from "+ fromLanguageList.Text + " into " + toLanguageList.Text;
            outputBox.Text = await talk.talkToMe(inputPrompt);
        }

        private void saveTextToFileButtonLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputBox.Text != "")
                {
                    DialogResult result = saveFileDialog1.ShowDialog();

                    if(result!= DialogResult.Cancel)
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, inputBox.Text);
                        MessageBox.Show("File Saved to: " + saveFileDialog1.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot save empty file. Write something first");
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void saveTextToFileButtonRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (outputBox.Text != "")
                {
                    DialogResult result = saveFileDialog2.ShowDialog();

                    if (result != DialogResult.Cancel)
                    {
                        System.IO.File.WriteAllText(saveFileDialog2.FileName, outputBox.Text);
                        MessageBox.Show("File Saved to: " + saveFileDialog2.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Result is empty cannot be saved.\n Please first generate translation before continue.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // call TTS class and pass as argument outputTextBox don't return

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (onScreenKeyboard == null || onScreenKeyboard.IsDisposed)
            {
                onScreenKeyboard = new OnScreenKeyboard(this);
                onScreenKeyboard.Show();
            }

        }
    }
}