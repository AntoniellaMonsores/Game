using System; 
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

class Arquivo<T> {
  XmlSerializer xml = new XmlSerializer(typeof(T));
  StreamReader sw = new StreamReader(arquivo, Encoding.Default);
  T obj = (T) xml.Deserialize(sw);
}
