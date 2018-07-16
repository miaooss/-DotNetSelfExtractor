using DotNetWrappers.IO;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace SelfExtractorSample
{
    public partial class Form1 : Form
    {
        private readonly IIOOperation ioOperation;

        public Form1()
        {
            InitializeComponent();
            ioOperation = new IOOperation();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;
            var destination = folderBrowserDialog1.SelectedPath;

            var codeBase = new Uri(Assembly.GetExecutingAssembly().CodeBase);

            var extractor = new SelfExtractor.Extractor(ioOperation);

            extractor.Extract(codeBase.LocalPath, destination);
        }
    }
}
