using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscalationTest
{
    class Program
    {
        const string _dataFilePath = "EscalationProgrammerTest.bin";
        private static List<Entity> entities = new List<Entity>();
        
        static void Main(string[] args)
        {
            ParseDataFile();
            foreach (Entity entity in entities)
            {
                Console.WriteLine(entity.ToString());
            }

            Console.ReadLine();
        }

        static void ParseDataFile()
        {
            using (FileStream stream = File.OpenRead(_dataFilePath))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    uint numberOfEntities = reader.ReadUInt32();
                    for (int i = 0; i < numberOfEntities; i++)
                    {
                        ushort id = reader.ReadUInt16();
                        ushort typeId = reader.ReadUInt16();
                        float xPosition = reader.ReadSingle();
                        float yPosition = reader.ReadSingle();
                        float xForward = reader.ReadSingle();
                        float yForward = reader.ReadSingle();
                        reader.ReadBytes(12);
                        entities.Add(new Entity() {Id = id, TypeId = typeId, XPosition = xPosition, YPosition = yPosition ,XForward = xForward, YForward = yForward});
                    }
                }

                    
            }
        }
    }
}
