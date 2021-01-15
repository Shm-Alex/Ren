using System;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Dto;
using IRepository;
using Repository;
using SimpleSerializer;
using WriterImplementation;

namespace Ren
{
    
        class Program
        {
            static async Task Main(string[] args)
            {
                ISerializer.ISerializer<User> serialiser = new SimpleXmlSerializer<User>(new XmlSerializer(typeof(User)));
                IWriter writer = new TestWriter();
                var repository = new UserRepository<User>(writer, serialiser);

                var fio0 = new User()
                {
                    FName = "Александр",
                    LName = "Шмыков",
                    MName = "Дмитриевич",
                    PassportNumber = "4507 171833",
                    Lang = ELang.Rus
                };
                await repository.SaveAsXmlAsync(fio0);



                Console.WriteLine($"Result :{((TestWriter)writer).Result}");
                Console.WriteLine($"{fio0.GetFullName()}");

            }
        }
    }

