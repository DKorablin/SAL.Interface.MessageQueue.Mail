using System.Reflection;
using System.Runtime.InteropServices;

[assembly: Guid("4bfc5ee2-9412-4676-a89f-f04d99491501")]
[assembly: System.CLSCompliant(true)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://github.com/DKorablin/SAL.Interface.MessageQueue.Mail")]
#else

[assembly: AssemblyDescription("Interfaces for mail Message Queue implementation")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2020")]
#endif