using Rhino.PlugIns;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Plug-in Description Attributes - all of these are optional.
// These will show in Rhino's option dialog, in the tab Plug-ins.
[assembly: PlugInDescription (DescriptionType.Address, "")]
[assembly: PlugInDescription (DescriptionType.Country, "")]
[assembly: PlugInDescription (DescriptionType.Email, "")]
[assembly: PlugInDescription (DescriptionType.Phone, "")]
[assembly: PlugInDescription (DescriptionType.Fax, "")]
[assembly: PlugInDescription (DescriptionType.Organization, "")]
[assembly: PlugInDescription (DescriptionType.UpdateUrl, "")]
[assembly: PlugInDescription (DescriptionType.WebSite, "https://github.com/corbane/Libx.RhinoLauncher")]

// Icons should be Windows .ico files and contain 32-bit images in the following sizes: 16, 24, 32, 48, and 256.
[assembly: PlugInDescription (DescriptionType.Icon, "FixWindowsToolbar.EmbeddedResources.rhn.ico")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
// This will also be the Guid of the Rhino plug-in
[assembly: Guid ("0885FE09-FBA2-4A6D-B86F-E5E9824AB34F")]

