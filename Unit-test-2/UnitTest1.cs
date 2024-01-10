using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Lab2
{
    [TestClass]
    public class WordsDictionaryTests
    {
        [TestMethod]
        public void Check_�����������_���������������������()
        {
            var session = new WordsDictionary();

            Assert.ThrowsException<ArgumentNullException>(() => session.Check(""));
        }

        [TestMethod]
        public void Check_�����������������_�����������������������()
        {
            var session = new WordsDictionary();
            string word = "������������";
            session.AddToDictionary(word, "������������-�����", "���");

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                session.Check(word);

                string ��������� = "��������� ������������ �����:";
                Assert.IsTrue(sw.ToString().Contains(���������));
            }
        }

        [TestMethod]
        public void AddToDictionary_�����������������()
        {
            var session = new WordsDictionary();
            string ���� = "����";
            string ����� = "�����";
            string ������ = "������";

            session.AddToDictionary(����, �����, ������);

            Assert.IsTrue(session.dictionary.ContainsKey(����));
            Assert.AreEqual(session.dictionary[����][0], �����);
            Assert.AreEqual(session.dictionary[����][1], ������);
        }

        [TestMethod]
        public void AddToDictionary_����������������������������_�����������������()
        {
            var session = new WordsDictionary();
            string ���� = "����";
            string ����� = "������";
            string ������ = "��";
            string ���������������� = "��-" + ����� + "-�������";

            session.AddToDictionary(����, ����������������, ������);

            Assert.IsTrue(session.dictionary.ContainsKey(����));
            Assert.AreEqual(session.dictionary[����][0], ����������������);
            Assert.AreEqual(session.dictionary[����][1], ������);
        }

        [TestMethod]
        public void RemoveFromDictionary_���������������������()
        {
            var session = new WordsDictionary();
            string ���� = "����";
            string ����� = "���������";

            session.AddToDictionary(����, �����, "����");

            session.dictionary.Remove(����);

            Assert.IsFalse(session.dictionary.ContainsKey(����));
        }
    }
}
