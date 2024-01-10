using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordsDictionary1;
namespace TestLab5

{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void SearchWordsByRoot_WithValidSearchRoot_ShouldReturnMatchingWords()
        {
            // Arrange
            var dictionary = new WordsDictionary();
            dictionary.AddToDictionary("�����_�����", "�����", "������");
            dictionary.AddToDictionary("���_�����", "�����", "������_������");
            dictionary.AddToDictionary("������_�����", "������", "������");

            // Act
            var matchingWords = dictionary.SearchWordsByRoot("������");

            // Assert
            CollectionAssert.AreEqual(new List<string> { "�����_�����", "������_�����" }, matchingWords);
        }


        [TestMethod]
        public void SearchWordsByRoot_WithInvalidSearchRoot_ShouldReturnEmptyList()
        {
            // Arrange
            var dictionary = new WordsDictionary();
            dictionary.AddToDictionary("�����_�����", "�����", "������");
            dictionary.AddToDictionary("���_�����", "�����", "������_������");
            dictionary.AddToDictionary("������_�����", "������", "������");

            // Act
            var matchingWords = dictionary.SearchWordsByRoot("��_������������_������");

            // Assert
            Assert.AreEqual(0, matchingWords.Count);
        }
        
            [TestMethod]
        public void AddToDictionary_���������������������������()
        {
            // Arrange
            var dictionary = new WordsDictionary();
            string key = "�����_�����";
            string word = "�����";
            string root = "������";

            // Act
            dictionary.AddToDictionary(key, word, root);

            // Assert
            Assert.IsTrue(dictionary.GetDictionary().ContainsKey(key));
            Assert.AreEqual(dictionary.GetDictionary()[key].Word, word);
            Assert.AreEqual(dictionary.GetDictionary()[key].Root, root);
        }

        [TestMethod]
        public void SaveAndLoadToJson_���������������������Json()
        {
            // Arrange
            var dictionary = new WordsDictionary();
            string key = "�����_�����";
            string word = "�����";
            string root = "������";
            dictionary.AddToDictionary(key, word, root);

            // Act
            dictionary.SaveToJson();
            dictionary.GetDictionary().Clear(); // ������� �������
            dictionary.LoadFromJson();

            // Assert
            Assert.IsTrue(dictionary.GetDictionary().ContainsKey(key));
            Assert.AreEqual(dictionary.GetDictionary()[key].Word, word);
            Assert.AreEqual(dictionary.GetDictionary()[key].Root, root);
        }

        [TestMethod]
        public void SaveAndLoadToXml_���������������������Xml()
        {
            // Arrange
            var dictionary = new WordsDictionary();
            string key = "�����_�����";
            string word = "�����";
            string root = "������";
            dictionary.AddToDictionary(key, word, root);

            // Act
            dictionary.SaveToXml();
            dictionary.GetDictionary().Clear(); // ������� �������
            dictionary.LoadFromXml();

            // Assert
            Assert.IsTrue(dictionary.GetDictionary().ContainsKey(key));
            Assert.AreEqual(dictionary.GetDictionary()[key].Word, word);
            Assert.AreEqual(dictionary.GetDictionary()[key].Root, root);
        }
        [TestMethod]
        public void SaveToSQLite_����������SQLite()
        {
            // Arrange
            var dictionary = new WordsDictionary();
            string key = "�����_�����";
            string word = "�����";
            string root = "������";
            dictionary.AddToDictionary(key, word, root);

            // Act
            dictionary.SaveToSQLite();

            // Assert
            dictionary.GetDictionary().Clear(); // ������� �������
            dictionary.LoadFromSQLite();
            Assert.IsTrue(dictionary.GetDictionary().ContainsKey(key));
            Assert.AreEqual(dictionary.GetDictionary()[key].Word, key);
            Assert.AreEqual(dictionary.GetDictionary()[key].Root, root);
        }

        [TestMethod]
        public void LoadFromSQLite_�����������SQLite()
        {
            // Arrange
            var dictionary = new WordsDictionary();
            string key = "�����_�����";
            string word = "�����";
            string root = "������";
            dictionary.AddToDictionary(key, word, root);
            dictionary.SaveToSQLite();

            // Act
            dictionary.GetDictionary().Clear(); // ������� ������� ����� ���������
            dictionary.LoadFromSQLite();

            // Assert
            Assert.IsTrue(dictionary.GetDictionary().ContainsKey(key));
            Assert.AreEqual(dictionary.GetDictionary()[key].Word, key);
            Assert.AreEqual(dictionary.GetDictionary()[key].Root, root);
        }


    }
}
