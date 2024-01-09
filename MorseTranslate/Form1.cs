using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MorseTranslate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainLanguage.SelectedIndex = 0;
            resultLanguage.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTranslate_Click(object sender, EventArgs e)
        {
            LStatusOfTranslate.Text = null;
            Translation();
        }

        private void Translation()
        {
            string inputLanguage = mainLanguage.Text.Trim();
            string resultLanguageLocal = resultLanguage.Text;
            string translateMode = ChoiceTranslateMode(inputLanguage, resultLanguageLocal);

            string textToWork = inputText.Text.ToUpper();
            StartTranslate(textToWork, translateMode);
            outputText.Text = StartTranslate(textToWork, translateMode);
        }

        private string ChoiceTranslateMode(string inputLanguage, string resultLanguageLocal)
        {
            if (inputLanguage == "English" && resultLanguageLocal == "Morse")
                return "EngToMorseDictionary";
            if (inputLanguage == "Morse" && resultLanguageLocal == "English")
                return "MorseToEngDictionary";

            return " ";
        }

        private string StartTranslate(string textToWork, string mode)
        {
            char[] charsOfInputText = textToWork.ToCharArray();

            StringBuilder translatedText = new StringBuilder();
            ClassDict dictionaryObject = new ClassDict();

            if (mode == "EngToMorseDictionary")
            {

                for (int i = 0; i < charsOfInputText.Length; i++)
                {
                    string keyToCheck = charsOfInputText[i].ToString();
                    if (dictionaryObject.EngToMorseDictionary.ContainsKey(keyToCheck))
                    {
                        translatedText.Append(
                            dictionaryObject.EngToMorseDictionary[charsOfInputText[i]
                            .ToString()]);
                        translatedText.Append(' ');                       
                    }
                    else
                    {
                        LStatusOfTranslate.Text = "Some letters were wrong";
                        continue;
                    }
                }

            }
            else if (mode == "MorseToEngDictionary")
            {

                string[] arrayOfMorseWords = textToWork.Split(' ');

                for (int i = 0; i < arrayOfMorseWords.Length; i++)
                {
                    string keyToCheck = arrayOfMorseWords[i].ToString();
                    if (dictionaryObject.MorseToEngDictionary.ContainsKey(keyToCheck))
                    {
                        translatedText.Append(
                           dictionaryObject.MorseToEngDictionary[arrayOfMorseWords[i]
                           .ToString()]);
                    }
                    else
                    {
                        LStatusOfTranslate.Text = "Some letters were wrong";
                        continue;
                    }
                }

            }

            return translatedText.ToString().Trim();
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void BClear_Click(object sender, EventArgs e)
        {
            inputText.Text = string.Empty;
            outputText.Text = string.Empty;
        }

        private void BChangePlaces_Click(object sender, EventArgs e)
        {
            string stringeToSwap = mainLanguage.Text;
            mainLanguage.Text = resultLanguage.Text;
            resultLanguage.Text = stringeToSwap;            
        }

        private void textForInput_Click(object sender, EventArgs e)
        {

        }
        
        private void LStatusOfTranslate_Click(object sender, EventArgs e)
        {

        }

        private void BCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(outputText.Text))
            {
                Clipboard.SetText(outputText.Text);
            }           
        }
    }
}