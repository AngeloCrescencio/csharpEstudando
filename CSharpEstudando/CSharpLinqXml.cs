using CSharpEstudando;
using System.Xml.Linq;
using System;
using System.IO;

partial class Program {
    static void CSharpLinqXml()
    {
        /*
          <AluraTunes>
              <Generos>
                <Genero>
                  <GeneroId>1</GeneroId>
                  <Nome>Rock</Nome>
                </Genero>
                <Genero>
                  <GeneroId>2</GeneroId>
                  <Nome>Reggae</Nome>
                </Genero>
        */
        #region consultando_xml_com_linq1
        //C:\0-csharpEstudando\CSharpEstudando\Data
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string parentDirectory = System.IO.Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;

        //XElement root = XElement.Load(@"C:\0-csharpEstudando\CSharpEstudando\Data\AluraTunes.xml");
        XElement root = XElement.Load(@$"{parentDirectory}\Data\AluraTunes.xml");

        Console.WriteLine("Generos");
        var queryXMLGeneros = from g in root.Element("Generos").Elements("Genero") // uso element quando só tem um, e elements quando é um array
                              select g;
        foreach (var genero in queryXMLGeneros) {

            Console.WriteLine("{0}\t{1}", genero.Element("GeneroId").Value, genero.Element("Nome").Value); // somente genero.Element("GeneroId") mostraria assim: <GeneroId>1</GeneroId>, pois o element recupera o nó xml

        }
        Console.WriteLine();

        Console.WriteLine("Musicas e seus generos");
        var queryXml = from g in root.Element("Generos").Elements("Genero")
                       join m in root.Element("Musicas").Elements("Musica")
                       on g.Element("GeneroId").Value equals m.Element("GeneroId").Value
                       select new { idMusica = m.Element("MusicaId").Value, NomeMusica = m.Element("Nome").Value , NomeGenero = g.Element("Nome").Value };

        foreach (var musica in queryXml) {
            Console.WriteLine("{0}\t{1}\t{2}", musica.idMusica, musica.NomeMusica.PadRight(25), musica.NomeGenero); // somente genero.Element("GeneroId") mostraria assim: <GeneroId>1</GeneroId>, pois o element recupera o nó xml
        }

        #endregion
    }
}
