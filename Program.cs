using System;

namespace ConsoleApp
{
    
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            System.Console.WriteLine("Документ открыт");

        }
        public virtual void Editdocument()
        {
           System.Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
        System.Console.WriteLine("Сохранение доумента доступно в версии Про");
        } 
    }
    class ProDocumentWorker:DocumentWorker
    {
        public override void OpenDocument()
        {
            System.Console.WriteLine("Документ отредактирован");
        }
        public override void Editdocument()
        {
            System.Console.Write("Документ сохранен в старом формате");
        }
        public override void SaveDocument()
        {
     Console.WriteLine(", сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        {
        System.Console.WriteLine("Документ сохранен в новом формате");
        }
     }
     enum DocumentType
     {
         DocumentWorker,
         ProDocumentWorker,
         ExpertDocumentsWorker
     }
    class Program
    {
        static void Main(string[] args)
        {
             System.Console.WriteLine(
"Чего вы хотите создать?\npro. ProDocumentWorker exp. ExpertDocumentsWorker doc. Пропустить\nВыбор:"
                 );
                 DocumentWorker d=null;
                 DocumentType type=DocumentType.DocumentWorker;
                 var choise=Console.ReadLine();
                switch(choise)
                {
                    case "doc": type=DocumentType.DocumentWorker; break;
                    case "pro": type=DocumentType.ProDocumentWorker;break;
                    case "exp":  type=DocumentType.ExpertDocumentsWorker; break;
                }
                switch (type)
                {
                    case DocumentType.DocumentWorker:
                    d=new DocumentWorker(); break;
                    case DocumentType.ProDocumentWorker:
                    d=new ProDocumentWorker(); break;
                    case DocumentType.ExpertDocumentsWorker:
                    d=new ExpertDocumentWorker(); break;
                    default: break;
                }
                if(type == DocumentType.DocumentWorker||type == DocumentType.ProDocumentWorker)
                {
                d.OpenDocument();
                d.Editdocument();
                d.SaveDocument();
                }
                else
                d.SaveDocument();
        }
    }
}
