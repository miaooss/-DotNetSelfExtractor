using DotNetWrappers.IO;
using Ionic.Zip;
using System;
using System.IO;

namespace SelfExtractor
{
    public class Extractor
    {
        private readonly IIOOperation ioOperation;

        public event EventHandler<ExtractProgressEventArgs> ExtractProgress;

        public Extractor(IIOOperation ioOperation)
        {
            this.ioOperation = ioOperation ?? throw new System.ArgumentNullException(nameof(ioOperation));
        }

        public void Extract(string selfExtractPath, string folderPathOutput)
        {
            Extract(selfExtractPath, folderPathOutput, ExtractExistingFileAction.Throw);
        }


        public void Extract(string selfExtractPath, string folderPathOutput, ExtractExistingFileAction extractExistingFile)
        {
            if (!ioOperation.FileExist(selfExtractPath))
                throw new FileNotFoundException("SelfExtractor Executable path cannot be found");

            if (!ioOperation.DirectoryExist(folderPathOutput))
                throw new FileNotFoundException("The output path does not exist");

            if (!ZipFile.IsZipFile(selfExtractPath))
                throw new System.NotSupportedException("The provided SelfExtractor does not contain anything");

            using (var zipFile = ZipFile.Read(selfExtractPath))
            {
                zipFile.ExtractProgress += (sender, arg) => ExtractProgress?.Invoke(sender, arg);
                zipFile.ExtractAll(folderPathOutput, extractExistingFile);
            }
        }
    }
}
