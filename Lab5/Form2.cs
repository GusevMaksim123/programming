using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordsDictionary1
{
    public partial class Form2 : Form
    {
        public string Pre1Part { get; set; }
        public string Pre2Part { get; set; }

        public string KorenPart { get; set; }
        public string Suf1Part { get; set; }
        public string Suf2Part { get; set; }
        public string KonPart { get; set; }
        public Form2()
        {
            InitializeComponent();
            CheckRootValidity();
        }

        private void pre1Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void pre2Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void korenText_TextChanged(object sender, EventArgs e)
        {
            CheckRootValidity();
        }

        private void suf1Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void suf2Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void konText_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckRootValidity()
        {
            bool korenValid = !string.IsNullOrWhiteSpace(korenText.Text);

            okButton.Enabled = korenValid;

            if (!korenValid)
            {
                korenText.BackColor = Color.LightPink;
            }
            else
            {
                korenText.BackColor = SystemColors.Window;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CheckRootValidity();
            // Обработка нажатия кнопки OK
            if (okButton.Enabled)
            {
                // Получить текст из текстовых полей на форме Form2
                Pre1Part = pre1Text.Text;
                Pre2Part = pre2Text.Text;
                KorenPart = korenText.Text;
                Suf1Part = suf1Text.Text;
                Suf2Part = suf2Text.Text;
                KonPart = konText.Text;

                DialogResult = DialogResult.OK; // Установка результата диалога на ОК
                Close(); // Закрыть форму после нажатия кнопки OK
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        [TestMethod]
        public void CheckRootValidity_WhenKorenTextIsNotEmpty_EnablesOkButton()
        {
            // Arrange
            var form2 = new Form2();
            form2.korenText.Text = "SomeText";

            // Act
            form2.CheckRootValidity();

            // Assert
            Assert.IsTrue(form2.okButton.Enabled);
        }

        [TestMethod]
        public void CheckRootValidity_WhenKorenTextIsEmpty_DisablesOkButton()
        {
            // Arrange
            var form2 = new Form2();
            form2.korenText.Text = ""; // Empty text

            // Act
            form2.CheckRootValidity();

            // Assert
            Assert.IsFalse(form2.okButton.Enabled);
        }

        [TestMethod]
        public void OkButton_Click_WhenKorenIsValid_SetsDialogResultToOk()
        {
            // Arrange
            var form2 = new Form2();
            form2.korenText.Text = "SomeText"; // Valid koren

            // Act
            form2.okButton.PerformClick();

            // Assert
            Assert.AreEqual(DialogResult.OK, form2.DialogResult);
        }

        [TestMethod]
        public void OkButton_Click_WhenKorenIsInvalid_DoesNotSetDialogResultToOk()
        {
            // Arrange
            var form2 = new Form2();
            form2.korenText.Text = ""; // Empty koren

            // Act
            form2.okButton.PerformClick();

            // Assert
            Assert.AreNotEqual(DialogResult.OK, form2.DialogResult);
        }
    }
}
