using System.Diagnostics;
using VisualStudioLogViewer.Classes;
using VisualStudioLogViewer.Models;

namespace VisualStudioLogViewer;

public partial class Form1 : Form
{
    private Configuration _configuration;
    public Form1()
    {
        InitializeComponent();

        if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json")))
        {
            _configuration = SettingsOperations.ReadConfiguration();
            var fileNames = FileOperations.AvailableLogFiles(_configuration.ActivityLogFolder);
            fileNames.Sort(new NaturalStringComparer());
            listBox1.DataSource = fileNames;
            ViewCurrentButton.Enabled = true;
        }

    }

    private void ViewCurrentButton_Click(object sender, EventArgs e)
    {
        var result = FileOperations.ViewLog(
            Path.Combine(_configuration.ActivityLogFolder, listBox1.Text),
            _configuration.BrowserExecutable);
        if (result is not null)
        {
            MessageBox.Show(result.Message);
        }
    }
}
