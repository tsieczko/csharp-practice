﻿using System;
using System.IO;
using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;


namespace WorkingWithFileSystems
{
	class Program
	{
		static void Main(string[] args)
		{
			// OutputFileSystemInfo();
			// WorkWithDrives();
			// WorkWithDirectorie();
			WorkWithFiles();
		}

		static void OutputFileSystemInfo()
		{
			WriteLine(
				"{0,-33} {1}",
				"Path.PathSeparator",
				PathSeparator
			);
			WriteLine(
				"{0,-33} {1}",
				"Path.DirectorySeparatorChar",
				DirectorySeparatorChar
			);
			WriteLine(
				"{0,-33} {1}",
				"Directory.GetCurrentDirectory()",
				GetCurrentDirectory()
			);
			WriteLine(
				"{0,-33} {1}",
				"Environment.CurrentDirectory",
				CurrentDirectory
			);
			WriteLine(
				"{0,-33} {1}",
				"Environment.SystemDirectory",
				SystemDirectory
			);
			WriteLine(
				"{0,-33} {1}",
				"Path.GetTempPath()",
				GetTempPath()
			);

			WriteLine("GetFolderPath(SpecialFolder)");
			WriteLine(
				"{0,-33} {1}",
				"  .System",
				GetFolderPath(SpecialFolder.System)
			);
			WriteLine(
				"{0,-33} {1}",
				"  .ApplicationData",
				GetFolderPath(SpecialFolder.ApplicationData)
			);
			WriteLine(
				"{0,-33} {1}",
				"  .MyDocuments",
				GetFolderPath(SpecialFolder.MyDocuments)
			);
			WriteLine(
				"{0,-33} {1}",
				"  .Personal",
				GetFolderPath(SpecialFolder.Personal)
			);
		}

		static void WorkWithDrives()
		{
			WriteLine(
				"{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
				"NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE"
			);

			foreach (DriveInfo drive in DriveInfo.GetDrives())
			{
				if (drive.IsReady)
				{
					WriteLine(
						"{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
						drive.Name, drive.DriveType, drive.DriveFormat,
						drive.TotalSize, drive.AvailableFreeSpace
					);
				}
				else
				{
					WriteLine(
						"{0,-30} | {1,-10}",
						drive.Name,
						drive.DriveType
					);
				}
			}
		}

		static void WorkWithDirectories()
		{
			var newFolder = Combine(CurrentDirectory, "NewFolder");

			WriteLine($"Working with: {newFolder}");

			// check if it exists
			WriteLine($"Does it exist? {Exists(newFolder)}");

			// create directory
			WriteLine("Creating it...");
			CreateDirectory(newFolder);
			WriteLine($"Does it exist? {Exists(newFolder)}");

			Write("Confirm the directory exists, and then press ENTER: ");
			ReadLine();

			// delete directory
			WriteLine("Deleting it...");
			Delete(newFolder, recursive: true);
			WriteLine($"Does it exist? {Exists(newFolder)}");
		}

		static void WorkWithFiles()
		{
			var dir = Combine(CurrentDirectory, "OutputFiles");

			CreateDirectory(dir);

			string textFile = Combine(dir, "Dummy.txt");
			string backupFile = Combine(dir, "Dummy.bak");

			WriteLine($"Working with: {textFile}");

			StreamWriter textWriter = File.CreateText(textFile);
			textWriter.WriteLine("Hello, C#!");
			textWriter.Close(); // close file and release resources

			WriteLine($"Does it exist? {File.Exists(textFile)}");

			// copy the file, and overwrite if it already exists
			File.Copy(sourceFileName: textFile, destFileName: backupFile, overwrite: true);

			WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");

			Write($"Confirm the files exist, and the press ENTER: ");
			ReadLine();

			// delete file
			File.Delete(textFile);

			WriteLine($"Does it exist? {File.Exists(textFile)}");

			// read from the text file backup
			WriteLine($"Reading contents of {backupFile}:");
			StreamReader textReader = File.OpenText(backupFile);
			WriteLine(textReader.ReadToEnd());
			textReader.Close();

			// Managing paths
			WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
			WriteLine($"File Name: {GetFileName(textFile)}");
			WriteLine($"File Name without Extension: {GetFileNameWithoutExtension(textFile)}");
			WriteLine($"File Extension: {GetExtension(textFile)}");
			WriteLine($"Random File Name: {GetRandomFileName()}");
			WriteLine($"Temporary File Name: {GetTempFileName()}");

			var info = new FileInfo(backupFile);
			WriteLine($"{backupFile}:");
			WriteLine($"Contains {info.Length} bytes");
			WriteLine($"Last accessed {info.LastAccessTime}");
			WriteLine($"Has readonly set to {info.IsReadOnly}");
		}
	}
}
