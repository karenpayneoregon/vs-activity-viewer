using System.Text.Json;
using VisualStudioLogViewer.Models;

namespace VisualStudioLogViewer.Classes;

/// <summary>
/// 
///
/// IMPORTANT:
///    ActivityLogFolder location may be different on your machine dependent on the version and  edition of Microsoft Visual Studio installed.
///    BrowserExecutable points in this case to Google Chrome browser, feel free to point to another browser
/// </summary>
public class SettingsOperations
{
    public static string AppSettingsFileName => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

    /// <summary>
    /// Used to create initial appsettings.json file for those interested
    /// </summary>
    public static void CreateInitialSettingsFile()
    {
        Configuration configuration = new()
        {
            ActivityLogFolder = $"C:\\Users\\{Environment.UserName}\\AppData\\Roaming\\Microsoft\\VisualStudio\\17.0_f56beab6",
            BrowserExecutable = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"
        };

        File.WriteAllText(AppSettingsFileName,
            JsonSerializer.Serialize(configuration, new JsonSerializerOptions { WriteIndented = true }));
    }

    /// <summary>
    /// Read appsettings.json values
    /// </summary>
    public static Configuration ReadConfiguration() 
        => JsonSerializer.Deserialize<Configuration>(File.ReadAllText(AppSettingsFileName))!;
}