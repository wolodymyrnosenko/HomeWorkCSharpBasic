using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_16_1_CopyTxtFile
{
    public sealed class FileCopier
    {
        public string SourcePath { get; private set; }
        public string DestinationPath { get; private set; }
        private int bufferSize = 1024;//To copy by chank

        public FileCopier(string sourcePath, string destinationPath)
        {
            SourcePath = sourcePath;
            DestinationPath = destinationPath;
        }

        public void Copy()
        {
            if(!File.Exists(SourcePath))
            {
                Console.WriteLine("файл відсутній");
                return;
            }
            if(!Directory.Exists(Path.GetDirectoryName(DestinationPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(DestinationPath));
            }
            byte[] buffer = new byte[bufferSize];
            using (FileStream sourceStream = new FileStream(SourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(DestinationPath, FileMode.Create, FileAccess.Write))
            {
                int bytesRead;
                while((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
                Console.WriteLine("Файл успішно скопійовано!");
        }
    }
}
