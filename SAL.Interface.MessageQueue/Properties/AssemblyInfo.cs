using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Guid("4bfc5ee2-9412-4676-a89f-f04d99491501")]
[assembly: System.CLSCompliant(true)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://github.com/DKorablin/SAL.Interface.MessageQueue")]
#else

[assembly: AssemblyTitle("Interface.MessageQueue")]
[assembly: AssemblyDescription("Interfaces for Message Queue implementation")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Danila Korablin")]
[assembly: AssemblyProduct("Interface.MessageQueue")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2020")]
#endif