﻿using System.IO;
using System.IO.Compression;
using System.Xml;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace WorkingWithStreams
{
	class Program
	{
		// define an array of Viper pilot call signs
		static string[] callsigns = new string[]
		{
			"Husker", "Starbuck", "Apollo", "Boomer",
			"Bulldog", "Athena", "Helo", "Racetrack"
		};

		static void Main(string[] args)
		{
			// WorkWithText();
			WorkWithXml();
            WorkWithCompression();
		}

		static void WorkWithText()
		{
			// define a file to write to
			string textFile = Combine(CurrentDirectory, "streams.txt");
			// create a text file and return a helper writer
			StreamWriter text = File.CreateText(textFile);
			// enumerate the strings, writing each one
			// to the stream on a separate line
			foreach (string item in callsigns)
			{
				text.WriteLine(item);
			}
			text.Close(); // release resources
						  // output the contents of the file
			WriteLine("{0} contains {1:N0} bytes.",
				arg0: textFile,
				arg1: new FileInfo(textFile).Length);
			WriteLine(File.ReadAllText(textFile));
		}

		static void WorkWithXml()
		{
			// define a file to write to
			string xmlFile = Combine(CurrentDirectory, "streams.xml");
			// create a file stream
			FileStream xmlFileStream = File.Create(xmlFile);
			// wrap the file stream in an XML writer helper
			// and automatically indent nested elements
			XmlWriter xml = XmlWriter.Create(xmlFileStream,
				new XmlWriterSettings { Indent = true });
			// write the XML declaration
			xml.WriteStartDocument();
			// write a root element
			xml.WriteStartElement("callsigns");
			// enumerate the strings writing each one to the stream
			foreach (string item in callsigns)
			{
				xml.WriteElementString("callsign", item);
			}
			// write the close root element
			xml.WriteEndElement();
			// close helper and stream
			xml.Close();
			xmlFileStream.Close();
			// output all the contents of the file
			WriteLine("{0} contains {1:N0} bytes.",
			arg0: xmlFile,
			arg1: new FileInfo(xmlFile).Length);
			WriteLine(File.ReadAllText(xmlFile));
		}

		static void WorkWithCompression()
		{
			// compress the XML output
			string gzipFilePath = Combine(
			    CurrentDirectory, "streams.gzip");
			FileStream gzipFile = File.Create(gzipFilePath);
			using (GZipStream compressor = new GZipStream(
			    gzipFile, CompressionMode.Compress))
			{
				using (XmlWriter xmlGzip = XmlWriter.Create(compressor))
				{
					xmlGzip.WriteStartDocument();
					xmlGzip.WriteStartElement("callsigns");
					foreach (string item in callsigns)
					{
						xmlGzip.WriteElementString("callsign", item);
					}
					// the normal call to WriteEndElement is not necessary
					// because when the XmlWriter disposes, it will
					// automatically end any elements of any depth
				}
			} // also closes the underlying stream
			  // output all the contents of the compressed file
			WriteLine("{0} contains {1:N0} bytes.",
			gzipFilePath, new FileInfo(gzipFilePath).Length);
			WriteLine($"The compressed contents:");
			WriteLine(File.ReadAllText(gzipFilePath));
			// read a compressed file
			WriteLine("Reading the compressed XML file:");
			gzipFile = File.Open(gzipFilePath, FileMode.Open);
			using (GZipStream decompressor = new GZipStream(
			gzipFile, CompressionMode.Decompress))
			{
				using (XmlReader reader = XmlReader.Create(decompressor))
				{
					while (reader.Read()) // read the next XML node
					{
						// check if we are on an element node named callsign
						if ((reader.NodeType == XmlNodeType.Element)
						&& (reader.Name == "callsign"))
						{
							reader.Read(); // move to the text inside element
							WriteLine($"{reader.Value}"); // read its value
						}
					}
				}
			}
		}

	}
}
