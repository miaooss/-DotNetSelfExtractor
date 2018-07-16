using DotNetWrappers.IO;
using Ionic.Zip;
using System.IO;

namespace SelfExtractor
{
    public class SelfExtractorGenerator
    {
        private readonly IIOOperation ioOperation;

        public SelfExtractorGenerator(IIOOperation ioOperation)
        {
            this.ioOperation = ioOperation ?? throw new System.ArgumentNullException(nameof(ioOperation));
        }

        /// <summary>
        /// The Method will create a SelfExtractor content.
        /// The selfExtractor executable should be already provided Using the Extractor Class
        /// </summary>
        /// <param name="selfExtractorExec">SelfExtractor Executable path </param>
        /// <param name="selfExtractorContent">Path to a folder that will be included to a self extracor content</param>
        /// <param name="fileOutputName">Name of the outputfile (If already exist then it will be repplace)</param>
        public void Create(string selfExtractorExec, string selfExtractorFolderContent, string fileOutputPath)
        {
            if (!ioOperation.FileExist(selfExtractorExec))
                throw new FileNotFoundException("SelfExtractor Executable path cannot be found");

            if (!ioOperation.DirectoryExist(selfExtractorFolderContent))
                throw new FileNotFoundException("SelfExtractor Content Folder path cannot be found");

            if (ZipFile.IsZipFile(selfExtractorExec))
                throw new System.NotSupportedException("The provided SelfExtractor is already a ZipFile");

            if (ioOperation.FileExist(fileOutputPath))
                ioOperation.FileDelete(fileOutputPath);

            //TODO: create ZipFactory
            using (var conbineSelfExtractor = ioOperation.CreateFile(fileOutputPath))
            {
                using (var seflextract = ioOperation.FileOpenRead(selfExtractorExec))
                    seflextract.CopyTo(conbineSelfExtractor);

                using (var zipFile = new ZipFile())
                {
                    zipFile.AddDirectory(selfExtractorFolderContent, string.Empty);
                    zipFile.Save(conbineSelfExtractor);
                }
            }
        }
    }
}
