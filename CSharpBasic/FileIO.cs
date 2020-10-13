using System.IO;
using System;
  
  namespace LearningAboutFile
  {

    public class FileIO
    {
        public void LearnFileReading()
        {
          string filecontent =  File.ReadAllText("Program.cs");
        }

        public void LeranFileWriting()
        {
            File.WriteAllText("A.txt","I created new file just now");
        }

        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.html");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"Directory:{x}");
            Console.WriteLine($"created:{y}");
            Console.WriteLine($"Directory:{z}");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\a.prasun","this is new file");
        }

        internal void LearnDirectoryInfo()
        {
            string folderpath = @"E:\.net centric computing\Vedas-Lab\Prasun.Neupane";
            DirectoryInfo directory = new DirectoryInfo(folderpath);
            var files = directory.GetFiles();
            Console.WriteLine("file count:" + files.Length);
        }
    }
  }  
