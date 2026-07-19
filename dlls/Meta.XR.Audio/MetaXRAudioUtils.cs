using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine;

public class MetaXRAudioVersion : MonoBehaviour
{
	private void Awake()
	{
		int Major = 0;
		int Minor = 0;
		int Patch = 0;
		int Major;
		int Minor;
		int Patch;
		MetaXRAudio_GetVersion(ref Major, ref Minor, ref Patch);
		Debug.Log(string.Format($"MetaXRAudio Version: {Major}.{Minor}.{Patch}"));
	}

	[DllImport("MetaXRAudioUnity")]
	private static extern void MetaXRAudio_GetVersion(ref int Major, ref int Minor, ref int Patch);
}
internal class MetaXRAudioUtils
{
	internal static string GetCaseSensitivePathForFile(string path)
	{
		if (!File.Exists(path))
		{
			return path;
		}
		string text = Path.GetPathRoot(path);
		string[] array = path.Substring(text.Length).Split(Path.DirectorySeparatorChar);
		foreach (string searchPattern in array)
		{
			text = Enumerable.First(Directory.EnumerateFileSystemEntries(text, searchPattern));
		}
		return text;
	}

	internal static void CreateDirectoryForFilePath(string absPath)
	{
		int num = Math.Max(absPath.LastIndexOf('/'), absPath.LastIndexOf('\\'));
		if (num >= 0)
		{
			string path = absPath.Substring(0, num);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}
	}
}
