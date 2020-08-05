using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Console;

namespace Exercise02
{
	class Program
	{
		static void Main(string[] args)
		{
			// create a list of Shapes to serialize
			var listOfShapes = new List<Shape>
			{
                new Circle { Colour = "Red", Radius = 2.5 },
                new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
                new Circle { Colour = "Green", Radius = 8.0 },
                new Circle { Colour = "Purple", Radius = 12.3 },
                new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
			};

            var serializerXml = new XmlSerializer(typeof(List<Shape>));

            string filePath = Path.Combine(Environment.CurrentDirectory, "shapes.xml");

            using (FileStream fileXml = File.Create(filePath))
            {
                serializerXml.Serialize(fileXml, listOfShapes);
            }

            using (FileStream XmlLoad = File.Open(filePath, FileMode.Open))
            {
                List<Shape> loadedShapesXml = serializerXml.Deserialize(XmlLoad) as List<Shape>;

                foreach (Shape shape in loadedShapesXml)
                {
                    WriteLine(
                        "{0} is {1} and has an area of {2:N2}",
                        shape.GetType(),
                        shape.Colour,
                        shape.Area
                    );
                }
            }
		}
	}
}
