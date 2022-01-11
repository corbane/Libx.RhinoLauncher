namespace Libx.RhinoLauncher.FixWindowsToolbar;

using Rhino.PlugIns;

public class FixWindowsToolbarPlugin : PlugIn
{
    public static FixWindowsToolbarPlugin Instance { get; private set; }

    public FixWindowsToolbarPlugin () { Instance = this; }
        
    public override PlugInLoadTime LoadTime => PlugInLoadTime.AtStartup;

    protected override LoadReturnCode OnLoad (ref string errorMessage)
    {
        Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance.SetApplicationIdForSpecificWindow (
            Rhino.RhinoApp.MainWindowHandle (),
            "Rhino " + Rhino.RhinoApp.ExeVersion.ToString ()
        );
        return base.OnLoad (ref errorMessage);
    }
}
