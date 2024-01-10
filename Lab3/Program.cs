using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SQLite;

namespace WebApplication1
{
class Program
{
    static void Main()
    {
        Console.WriteLine("����� ���������� � ��������� ������� ������������ ����");
        var session = new WordsDictionary();
        while (true)
        {
            Console.WriteLine("�������� ��������:");
            Console.WriteLine("1. ���� �����");
            Console.WriteLine("2. ���������� � JSON");
            Console.WriteLine("3. �������� �� JSON");
            Console.WriteLine("4. ���������� � XML");
            Console.WriteLine("5. �������� �� XML");
            Console.WriteLine("6. ���������� � SQLite");
            Console.WriteLine("7. �������� �� SQLite");
            Console.WriteLine("q. �����");
            Console.WriteLine("v. ������� � ����");
            Console.Write("> ");

            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":
                    session.ProcessInput();
                    break;
                case "2":
                    session.SaveToJson();
                    break;
                case "3":
                        session.LoadFromJson();
                    break;
                case "4":
                        session.SaveToXml();
                    break;
                case "5":
                        session.LoadFromXml();
                    break;
                case "6":
                        session.SaveToSQLite();
                    break;
                case "7":
                        session.LoadFromSQLite();
                    break;
                case "q":
                    return;
                default:
                Console.WriteLine("������������ �����.");
                break;
            }
        }
    }
}
}

