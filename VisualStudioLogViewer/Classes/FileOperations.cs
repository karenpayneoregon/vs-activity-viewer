using System.Diagnostics;

namespace VisualStudioLogViewer.Classes;

public class FileOperations
{
    public static string[] ExcludeTheseFiles = { "ActivityLog.Setup.xml", "ActivityLogFirstLaunch.xml" };
    /// <summary>
    /// ActivityLog.Setup.xml
    /// ActivityLogFirstLaunch.xml
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static List<string> AvailableLogFiles(string path) =>
        Directory.GetFiles(path, "ActivityLog*.xml")
            .Select(Path.GetFileName)
            .Where(x => !ExcludeTheseFiles.Contains(x))
            .ToList();


    /// <summary>
    /// View an activity log file
    /// </summary>
    /// <param name="fileName">File to view</param>
    /// <param name="command">Browser to view with</param>
    public static Exception ViewLog(string fileName, string command)
    {
        try
        {
            var start = new ProcessStartInfo
            {
                FileName = command,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                Arguments = $"file:///{fileName}",
                CreateNoWindow = true
            };
            var process = Process.Start(start);
            return null;
        }
        catch (Exception localException)
        {
            return localException;
        }
    }
}