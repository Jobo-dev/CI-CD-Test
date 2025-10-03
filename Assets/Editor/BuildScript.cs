using UnityEditor;
using UnityEngine;
using System.IO;

public class BuildScript
{
    // M�todo que Unity ejecutar� en batchmode
    public static void BuildWindows()
    {
        // Carpeta donde se guardar� el build
        string buildPath = "Builds/Windows";

        // Crear la carpeta si no existe
        if (!Directory.Exists(buildPath))
        {
            Directory.CreateDirectory(buildPath);
        }

        // Obtener todas las escenas habilitadas en Build Settings
        string[] scenes = new string[EditorBuildSettings.scenes.Length];
        for (int i = 0; i < scenes.Length; i++)
        {
            scenes[i] = EditorBuildSettings.scenes[i].path;
        }

        // Configuraci�n de build
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = Path.Combine(buildPath, "MyGame.exe"),
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None
        };

        // Ejecutar build
        BuildPipeline.BuildPlayer(buildPlayerOptions);

        Debug.Log("Build completado exitosamente en: " + buildPath);
    }
}

