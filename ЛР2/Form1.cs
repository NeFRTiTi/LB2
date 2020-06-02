using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР2
{
    public partial class Form1 : Form
    {
        public void texs(out int pp)
        {
            pp = 8;
        }
        public Form1()
        {
            InitializeComponent();
            int g;
            texs(out g);
            MessageBox.Show(g.ToString());

            StringBuilder sb = new StringBuilder("Hello World");


            //string s = ReplaceTB.Text;
            //string pattern = @"[b|c|d]+";
            //string target = " ";
            //Regex regex = new Regex(pattern);
            //ReplaceTB.Text = regex.Replace(s, target);
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string[] array = FieldTB.Text.Split(' ');
            int[] arr = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                //arr[i] = Convert.ToInt32(array[i], 16);
                //FieldRTB.Text = FieldRTB.Text + Convert.ToString(arr[i], 10) + "\r";
                HexToDec(array[i]);             
            }
        }
        public void HexToDec(string hex)
        {
            string number = hex;
            int dec = 0;
            bool check = true;
            for (int i = 0; i < number.Length; i++)
            {
                try
                {
                    if (number[i].ToString() == "A") { dec += 10 * (int)Math.Pow(16, (number.Length - 1) - i); }
                    else if (number[i].ToString() == "B") { dec += 11 * (int)Math.Pow(16, (number.Length - 1) - i); }
                    else if (number[i].ToString() == "C") { dec += 12 * (int)Math.Pow(16, (number.Length - 1) - i); }
                    else if (number[i].ToString() == "D") { dec += 13 * (int)Math.Pow(16, (number.Length - 1) - i); }
                    else if (number[i].ToString() == "E") { dec += 14 * (int)Math.Pow(16, (number.Length - 1) - i); }
                    else if (number[i].ToString() == "F") { dec += 15 * (int)Math.Pow(16, (number.Length - 1) - i); }
                    else { dec += Convert.ToInt32(number[i].ToString()) * (int)Math.Pow(16, (number.Length - 1) - i); }
                }
                catch
                {
                    check = false;
                    break;
                }

            }
            if(check)FieldRTB.Text += dec + "\r";
        }
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            FieldRTB.Text = "";
        }

        private void ReplaceBTN_Click(object sender, EventArgs e)
        {
            ReplaceAnswerTB.Text = "";
            string s = ReplaceTB.Text;
            char[] mass = new char[] {'a','e','i','o','q','u','y' };
            char[] text = new char[s.Length];
            for(int i = 0; i < s.Length; i++)
            {
                text[i] = s[i];
            }
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (text[i] == mass[j] && i != text.Length-1)
                    {
                        int assci = (int)text[i+1];
                        if(assci == 122)
                        {
                            text[i+1] = Convert.ToChar(97);
                        }
                        else if(assci < 122 || assci > 97)
                        {
                            text[i+1] = Convert.ToChar(assci + 1);
                        }                        
                        break;
                    }
                }
            }
            for (int i = 0; i < text.Length; i++)
                ReplaceAnswerTB.Text += text[i].ToString();
        }

        private void ReversBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReversTB.Text.Length != 0)
                {
                    string[] mass = ReversTB.Text.Split(' ');
                    ReversTB.Text = "";
                    for (int i = mass.Length - 1; i >= 0; i--)
                    {
                        ReversTB.Text += mass[i];
                        if (i != 0) ReversTB.Text += " ";
                    }
                }
                else throw new Exception("Поле пустое, нечего переворачивать!");
            }
            catch(Exception message)
            {
                MessageBox.Show(message.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditorRTB.Text.Length == 0) throw new Exception("В поле текстового редактора нет текста(!");
                if (FindEditorTB.Text.Length == 0) throw new Exception("Поле \"Искомого слова\" не заполнено!");
                int count = 0;
                string text = EditorRTB.Text;
                string rep = FindEditorTB.Text;
                while (text.IndexOf(rep) != -1)
                {
                    int i = text.IndexOf(rep);
                    EditorRTB.SelectionStart = i+count*rep.Length;
                    EditorRTB.SelectionLength = FindEditorTB.Text.Length;
                    EditorRTB.SelectionBackColor = Color.Blue;
                    text = text.Remove(i, rep.Length);
                    count++;
                }
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaceEditorBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditorRTB.Text.Length == 0) throw new Exception("В поле текстового редактора нет текста(!");
                if (ReplaceFromEditorTB.Text.Length == 0) throw new Exception("Поле \"Что заменить\" не заполнено!");
                if (ReplaceToEditorTB.Text.Length == 0) throw new Exception("Поле \"На что заменить\" не заполнено!");
                EditorRTB.Text = EditorRTB.Text.Replace(ReplaceFromEditorTB.Text, ReplaceToEditorTB.Text);
            }
            catch(Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaceEditorFirstTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditorRTB.Text.Length == 0) throw new Exception("В поле текстового редактора нет текста(!");
                if (ReplaceFromEditorTB.Text.Length == 0) throw new Exception("Поле \"Что заменить\" не заполнено!");
                if (ReplaceToEditorTB.Text.Length == 0) throw new Exception("Поле \"На что заменить\" не заполнено!");
                int i = EditorRTB.Text.IndexOf(ReplaceFromEditorTB.Text);
                EditorRTB.Text = EditorRTB.Text.Remove(i, ReplaceFromEditorTB.Text.Length).Insert(i, ReplaceToEditorTB.Text);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}