using System.Runtime.InteropServices;

namespace VisualStudioLogViewer.Classes;

/// <summary>
/// Provides a sort for file names ending with a number e.g. file1.doc
/// </summary>
/// <remarks>
/// Windows platform only
/// </remarks>
public class NaturalStringComparer : Comparer<string>
{

    [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
    private static extern int StrCmpLogicalW(string x, string y);

    public override int Compare(string x, string y)
        => StrCmpLogicalW(x, y);
}