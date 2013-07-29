using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void TGenerate_Click(object sender, EventArgs e)
        {
            string _symbols = ReplaceStrings(TSymbolsEdit.Text, new[] { "\n", "\t" , " " }, new[] { "", "" , "" })
                , FullText = "";

            if (_symbols == "")
            {
                MessageBox.Show(this,
                "Пустое поле с символами!",
                "Ошибка!"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var rand = new Random();

            TPaswords.Text = "";
 
            for (int i = 0; i < TPasswCount.Value; i++)
            {
                string passwords = "";
                Text = "Password Generator - Генерация: " + i;
                Application.DoEvents();
                for (int j = 0; j < TPasswLenght.Value; j++)
                {
                    passwords += _symbols[rand.Next(_symbols.Length)].ToString(CultureInfo.InvariantCulture);
                }
                FullText += (i + 1) + ". " + passwords + "\r\n";
            }

            TPaswords.Text = FullText;
            Text = "Password Generator";
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TPaswords.Copy();
        }

        private void копироватьСлучайныйПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var regex = new Regex(@"\d+\.\s(.*)");
            if (TPaswords.Lines[rand.Next(TPaswords.Lines.Length)] != "")
            {
                Clipboard.SetText(regex.Replace(TPaswords.Lines[rand.Next(TPaswords.Lines.Length)], "$1"));   
            } 
        }

        private void THelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(this, 
                "Passord Generator\nВерсия:  " + Application.ProductVersion + "\n\n"
              + "Разработчик:  Medic84 a.k.a D.Kozhanov \n"
              + "Домашняя страница:  http://mediclab.org", 
                "Информация..." 
                ,MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        public static string ReplaceStrings(string str, string[] aOldChars, string[] aNewChars, bool truing = true)
        {
            string RetStr = str;
            if (RetStr == String.Empty) return RetStr;
            if (aOldChars.Length != aNewChars.Length) return str;
            if (truing)
            {
                for (int i = 0; i < aOldChars.Length; i++)
                    RetStr = RetStr.Replace(aOldChars[i], aNewChars[i]);
            }


            return RetStr;
        }
    }
}
