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
using System.Xml.Serialization;
using System.Data.SQLite;
using Newtonsoft.Json;

namespace WordsDictionary1
{
    public partial class Form1 : Form
    {
        WordsDictionary dictionary = new WordsDictionary();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // Показать форму как диалоговое окно
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // Если результат диалога ОК, получить введенные значения
                string pre1 = form2.Pre1Part;
                string pre2 = form2.Pre2Part;
                string koren = form2.KorenPart;
                string suf1 = form2.Suf1Part;
                string suf2 = form2.Suf2Part;
                string kon = form2.KonPart;

                // Создать переменную для слова
                string word = "";

                // Добавить части слова с учётом их наличия
                if (!string.IsNullOrWhiteSpace(pre1))
                {
                    word += $"{pre1}-";
                }
                if (!string.IsNullOrWhiteSpace(pre2))
                {
                    word += $"{pre2}-";
                }
                if (!string.IsNullOrWhiteSpace(koren))
                {
                    word += $"{koren}-";
                }
                if (!string.IsNullOrWhiteSpace(suf1))
                {
                    word += $"{suf1}-";
                }
                if (!string.IsNullOrWhiteSpace(suf2))
                {
                    word += $"{suf2}-";
                }
                if (!string.IsNullOrWhiteSpace(kon))
                {
                    word += $"{kon}";
                }

                string newKey = $"{pre1 + pre2 + koren + suf1 + suf2 + kon}";

                // Проверка наличия ключа в словаре
                if (!dictionary.GetDictionary().ContainsKey(newKey))
                {
                    dictionary.AddToDictionary(newKey,word, koren);
                    UpdateWordCountLabel();
                }
                else
                {
                    MessageBox.Show("Слово уже существует в словаре.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveJSONButton_Click(object sender, EventArgs e)
        {
            dictionary.SaveToJson();
        }

        private void loadJSONButton_Click(object sender, EventArgs e)
        {
            dictionary.LoadFromJson();
            UpdateWordCountLabel();
        }

        private void saveXMLButton_Click(object sender, EventArgs e)
        {
            dictionary.SaveToXml();
        }

        private void loadXMLButton_Click(object sender, EventArgs e)
        {
            dictionary.LoadFromXml();
            UpdateWordCountLabel();
        }

        private void saveSQLiteButton_Click(object sender, EventArgs e)
        {
            dictionary.SaveToSQLite();
        }

        private void loadSQLiteButton_Click(object sender, EventArgs e)
        {
            dictionary.LoadFromSQLite();
            UpdateWordCountLabel();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string searchWord = searchTextBox.Text.Trim(); // Получаем слово для поиска

            if (!string.IsNullOrWhiteSpace(searchWord))
            {
                treeView1.Nodes.Clear();
                TreeNode rootNode = treeView1.Nodes.Add(searchWord); // Создание нового узла с искомым словом

                // Поиск слов с заданным корнем
                foreach (var entry in dictionary.dictionary)
                {
                    string word = entry.Value.Word; // Получаем слово
                    string root = entry.Value.Root; // Получаем корень

                    if (root.StartsWith(searchWord))
                    {
                        TreeNode childNode = rootNode.Nodes.Add(word); // Добавление слов с корнем как дочерних узлов
                    }
                }

                rootNode.Expand(); // Раскрыть новый узел с результатами поиска
            }
            else
            {
                MessageBox.Show("Введите слово для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Метод для обновления Label1 с количеством слов в словаре
        private void UpdateWordCountLabel()
        {
            int wordCount = dictionary.GetDictionary().Count;
            label1.Text = $"Кол-во слов в словаре: {wordCount}";
        }

        private void openDictionaryButton_Click(object sender, EventArgs e)
        {
            Dictionary dictionaryForm = new Dictionary(dictionary.GetDictionary());
            dictionaryForm.Show();
        }
    }
}
