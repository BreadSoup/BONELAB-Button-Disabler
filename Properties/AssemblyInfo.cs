using System.Reflection;
using ButtonDisabler;
using MelonLoader;

[assembly: AssemblyTitle(ButtonDisabler.Main.Description)]
[assembly: AssemblyDescription(ButtonDisabler.Main.Description)]
[assembly: AssemblyCompany(ButtonDisabler.Main.Company)]
[assembly: AssemblyProduct(ButtonDisabler.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + ButtonDisabler.Main.Author)]
[assembly: AssemblyTrademark(ButtonDisabler.Main.Company)]
[assembly: AssemblyVersion(ButtonDisabler.Main.Version)]
[assembly: AssemblyFileVersion(ButtonDisabler.Main.Version)]
[assembly: MelonInfo(typeof(ButtonDisabler.Main), ButtonDisabler.Main.Name, ButtonDisabler.Main.Version, ButtonDisabler.Main.Author, ButtonDisabler.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]