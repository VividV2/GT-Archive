using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Backtrace.Unity.Types;
using UnityEngine;

namespace Backtrace.Unity.Common;

internal static class MinidumpHelper
{
	private static readonly string[] Libraries = new string[2] { "kernel32.dll", "dbghelp.dll" };

	private static bool IsMemoryDumpAvailable()
	{
		if (UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WindowsEditor || UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WindowsPlayer)
		{
			return SystemHelper.IsLibraryAvailable(Libraries);
		}
		return false;
	}

	[System.Runtime.InteropServices.DllImport("dbghelp.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern bool MiniDumpWriteDump(System.IntPtr hProcess, uint processId, System.Runtime.InteropServices.SafeHandle hFile, uint dumpType, ref MiniDumpExceptionInformation expParam, System.IntPtr userStreamParam, System.IntPtr callbackParam);

	[System.Runtime.InteropServices.DllImport("dbghelp.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern bool MiniDumpWriteDump(System.IntPtr hProcess, uint processId, System.Runtime.InteropServices.SafeHandle hFile, uint dumpType, System.IntPtr expParam, System.IntPtr userStreamParam, System.IntPtr callbackParam);

	internal static bool Write(string filePath, Backtrace.Unity.Types.MiniDumpType options = Backtrace.Unity.Types.MiniDumpType.WithFullMemory, Backtrace.Unity.Types.MinidumpException exceptionType = Backtrace.Unity.Types.MinidumpException.None)
	{
		if (!IsMemoryDumpAvailable())
		{
			return false;
		}
		System.Diagnostics.Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();
		System.IntPtr handle = currentProcess.Handle;
		uint id = (uint)currentProcess.Id;
		MiniDumpExceptionInformation expParam = MiniDumpExceptionInformation.GetInstance(exceptionType);
		using System.IO.FileStream fileStream = new System.IO.FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.Write);
		return (expParam.ExceptionPointers == System.IntPtr.Zero) ? MiniDumpWriteDump(handle, id, fileStream.SafeFileHandle, (uint)options, System.IntPtr.Zero, System.IntPtr.Zero, System.IntPtr.Zero) : MiniDumpWriteDump(handle, id, fileStream.SafeFileHandle, (uint)options, ref expParam, System.IntPtr.Zero, System.IntPtr.Zero);
	}
}
