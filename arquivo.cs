using System; 
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

class Arquivo<T> {
  XmlSerializer xml = new XmlSerializer(typeof(T));
  StreamReader sw = new StreamReader(arquivo, Encoding.Default);
  T obj = (T) xml.Deserialize(sw);
  sw.Close();
}

    /* Passar para outro arquivo

    try
    { 
        // Passa a tragetoria e o nome do arquivo para o construtor StreamWriter
        StreamReader sr = new StreamReader("teste.txt");
        string data  = sr.ReadLine();
        
        // Ler até o fim do arquivo
        while (data != null)
        {
          Console.WriteLine("data");
            
          //ler a prox line
          data = sr.ReadLine();
        }
        
        //fechando o arquivo
        sr.Close();
        Console.ReadLine();
    }
        
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);    
    }
        
    finally
    {
        Console.WriteLine("executando o ultimo");
    }
      
    try
    {
        StreamWriter sw = new StreamWriter("teste.txt");
        sw.WriteLine("testando");
        sw.WriteLine("testando2");
        sw.Close();
    }
        
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);    
    }
        
    finally
    {
        Console.WriteLine("executando o ultimo");
    }
    */
