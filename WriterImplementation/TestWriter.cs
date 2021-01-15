using System.Threading;
using System.Threading.Tasks;
using IRepository;

namespace WriterImplementation
{
    public class TestWriter : IWriter
    {
        public string Result { get; private set; } = "";
        public async Task WriteAsync(string subject)
        {
            await Task.Run(() =>
            {
                //Имитируем ассинхронность пусть поток в котором вызван этот таск поспит секунду.
                Thread.Sleep(1000);
                Result = subject;
            });
        }
    }
}