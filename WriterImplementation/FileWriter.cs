using System;
using System.IO;
using System.Threading.Tasks;
using IRepository;

namespace WriterImplementation
{
    public class FileWriter : IWriter
    {

        string _dirForXml;
        public FileWriter(string dirForXml)
        {
            _dirForXml = dirForXml;
        }
        public async Task WriteAsync(string subject)
        {

            string file = $"{Guid.NewGuid()}.txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(_dirForXml, file)))
            {
                await outputFile.WriteAsync(subject);
            }
        }
    }
}