// Imports nescessarios
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;
using ICSharpCode.SharpZipLib;

// Classe principal do programa
class Program
{

    // Função Para rodar o jogo
    public static async Task Main()
    {
         var launcher = new MinecraftLauncher();
         // Jogo inicia Depois daqui
         var gameprocess = await launcher.InstallAndBuildProcessAsync("1.12.2", new MLaunchOption {
             Session = MSession.CreateOfflineSession("Manosh1ts"),
             MaximumRamMb = 4096
         });
         // Inicia o processo do jogo
        gameprocess.Start();
    }

    // Função para pegar as versoes do jogo
    public static async Task GetVersions()
    {
        var launcher = new MinecraftLauncher();
        var versions = await launcher.GetAllVersionsAsync();
        foreach (var version in versions)
        {
            Console.WriteLine(version.Name);
        }
    }
}