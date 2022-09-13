using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
            Console.ReadLine();
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
            Console.ReadLine();
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
            Console.ReadLine();
        }
        class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован");
                Console.ReadLine();
            }
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
                Console.ReadLine();
            }
        }
        class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в новом формате");
                Console.ReadLine();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                string pro_key = "proversion01";
                string exp_key = "expversion01";
                int counter = 0;
                Console.WriteLine("Если у вас есть нет ключа доступа, то Вы можете" +
                    "использовать только бесплатной версией. Если у вас есть ключ от pro версии, то нажмите '1'," +
                    "если ключ от exp версии нажмите '2', в противном случае 0");
                counter = Convert.ToInt32(Console.ReadLine());
                if (counter>= 3 || counter < 0)
                {
                    Console.WriteLine("Error");
                    Console.ReadLine();
                }
                if (counter == 0)
                {
                    DocumentWorker ob1 = new DocumentWorker();
                    int counter_1;
                    Console.WriteLine("Введите, что Вы хотите сделать:" +
                        "\n[0] - открыть" +
                        "\n[1] - редактировать" +
                        "\n[2] - сохранить");
                    counter_1 = Convert.ToInt32(Console.ReadLine());
                    if(counter_1 >=3 || counter_1<0)
                    {
                        Console.WriteLine("Error");
                        Console.ReadLine();
                    }
                    if(counter_1 == 0)
                    {
                        ob1.OpenDocument();
                    }
                    if (counter_1 == 1)
                    {
                        ob1.EditDocument();
                    }
                    if (counter_1 == 2)
                    {
                        ob1.SaveDocument();
                    }
                }
                if (counter == 1)
                {
                    Console.WriteLine("Введите ключ для pro версии:");
                    string key_pro_1 = Console.ReadLine();
                    if (key_pro_1 == pro_key)
                    {
                        ProDocumentWorker ob2 = new ProDocumentWorker();
                        int counter_1;
                        Console.WriteLine("Введите, что Вы хотите сделать:" +
                            "\n[0] - открыть" +
                            "\n[1] - редактировать" +
                            "\n[2] - сохранить");
                        counter_1 = Convert.ToInt32(Console.ReadLine());
                        if (counter_1 >= 3 || counter_1 < 0)
                        {
                            Console.WriteLine("Error");
                            Console.ReadLine();
                        }
                        if (counter_1 == 0)
                        {
                            ob2.OpenDocument();
                        }
                        if (counter_1 == 1)
                        {
                            ob2.EditDocument();
                        }
                        if (counter_1 == 2)
                        {
                            ob2.SaveDocument();
                        }
                    } else
                    {
                        Console.WriteLine("Неверный ключ");
                        Console.ReadLine();
                    }
                }
                if (counter == 2)
                {
                    Console.WriteLine("Введите ключ для exp версии:");
                    string key_exp_1 = Console.ReadLine();
                    if (key_exp_1 == exp_key)
                    {
                        ExpertDocumentWorker ob3 = new ExpertDocumentWorker();
                        int counter_1;
                        Console.WriteLine("Введите, что Вы хотите сделать:" +
                            "\n[0] - открыть" +
                            "\n[1] - редактировать" +
                            "\n[2] - сохранить");
                        counter_1 = Convert.ToInt32(Console.ReadLine());
                        if (counter_1 >= 3 || counter_1 < 0)
                        {
                            Console.WriteLine("Error");
                            Console.ReadLine();
                        }
                        if (counter_1 == 0)
                        {
                            ob3.OpenDocument();
                        }
                        if (counter_1 == 1)
                        {
                            ob3.EditDocument();
                        }
                        if (counter_1 == 2)
                        {
                            ob3.SaveDocument();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ключ");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}