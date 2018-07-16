using DotNetWrappers.IO;
using System;
using System.Windows.Forms;

namespace SelfExtractorGeneratorSample
{
    public partial class Form1 : Form
    {
        private readonly IIOOperation ioOperation;

        public Form1()
        {
            InitializeComponent();
            ioOperation = new IOOperation();
        }

        private void btnSelfExtractorContent_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtSelfExtractorContent.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnSelectSelfExtractorExec_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtSelectSelfExtractorExec.Text = openFileDialog1.FileName;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!ioOperation.FileExist(txtSelectSelfExtractorExec.Text))
            {
                MessageBox.Show("Path to Self extractor not found");
                return;
            }

            if (!ioOperation.DirectoryExist(txtSelfExtractorContent.Text))
            {
                MessageBox.Show("Path to Self extractor content directory not found");
                return;
            }

            openFileDialog1.CheckFileExists = false;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            var outputPath = openFileDialog1.FileName;
            var genrator = new SelfExtractor.SelfExtractorGenerator(ioOperation);
            genrator.Create(txtSelectSelfExtractorExec.Text, txtSelfExtractorContent.Text, "CustomSelfExtractor.exe");
        }
    }
}
