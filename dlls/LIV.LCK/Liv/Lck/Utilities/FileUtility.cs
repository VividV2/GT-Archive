using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Liv.Lck.Settings;
using Liv.NativeGalleryBridge;
using UnityEngine;

namespace Liv.Lck.Utilities;

public static class FileUtility
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Action<bool, string> callback;

		public string sourceFilePath;
	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_1
	{
		public string destinationFilePath;

		public <>c__DisplayClass1_0 CS$<>8__locals1;

		internal void <CopyToGallery>b__1()
		{
			File.Copy(CS$<>8__locals1.sourceFilePath, destinationFilePath, overwrite: true);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <CopyToGallery>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<bool, string> callback;

		public string sourceFilePath;

		public string albumName;

		private <>c__DisplayClass1_0 <>8__1;

		private <>c__DisplayClass1_1 <>8__2;

		private TaskAwaiter<NativeGallery.Permission> <>u__1;

		private TaskAwaiter <>u__2;

		private void MoveNext()
		{
			int num = <>1__state;
			try
			{
				if ((uint)num <= 3u)
				{
					goto IL_0069;
				}
				<>8__1 = new <>c__DisplayClass1_0();
				<>8__1.callback = callback;
				<>8__1.sourceFilePath = sourceFilePath;
				bool flag = default(bool);
				if (File.Exists(<>8__1.sourceFilePath))
				{
					flag = Path.GetExtension(<>8__1.sourceFilePath) == ".mp4";
					goto IL_0069;
				}
				<>8__1.callback(arg1: false, <>8__1.sourceFilePath);
				LckLog.LogError("LCK Source file does not exist: " + <>8__1.sourceFilePath, "CopyToGallery", ".\\Packages\\tv.liv.lck\\Runtime\\Scripts\\Components\\FileUtilities.cs", 100);
				goto end_IL_0007;
				IL_0069:
				try
				{
					TaskAwaiter<NativeGallery.Permission> awaiter2;
					TaskAwaiter awaiter;
					NativeGallery.Permission permission;
					NativeGallery.Permission result;
					switch (num)
					{
					default:
					{
						string fileName = Path.GetFileName(<>8__1.sourceFilePath);
						if (Application.platform == RuntimePlatform.Android)
						{
							if (flag)
							{
								awaiter2 = NativeGallery.SaveVideoToGallery(<>8__1.sourceFilePath, albumName, fileName, WrappedMediaSaveCallback).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = (<>1__state = 0);
									<>u__1 = awaiter2;
									<>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_011b;
							}
							awaiter2 = NativeGallery.SaveImageToGallery(<>8__1.sourceFilePath, albumName, fileName, WrappedMediaSaveCallback).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (<>1__state = 1);
								<>u__1 = awaiter2;
								<>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01a2;
						}
						<>8__2 = new <>c__DisplayClass1_1();
						<>8__2.CS$<>8__locals1 = <>8__1;
						string text = Path.Combine(Environment.GetFolderPath(flag ? Environment.SpecialFolder.MyVideos : Environment.SpecialFolder.MyPictures), albumName);
						if (!Directory.Exists(text))
						{
							Directory.CreateDirectory(text);
						}
						<>8__2.destinationFilePath = Path.Combine(text, fileName);
						awaiter = Task.Run(delegate
						{
							File.Copy(<>8__2.CS$<>8__locals1.sourceFilePath, <>8__2.destinationFilePath, overwrite: true);
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (<>1__state = 2);
							<>u__2 = awaiter;
							<>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02b9;
					}
					case 0:
						awaiter2 = <>u__1;
						<>u__1 = default(TaskAwaiter<NativeGallery.Permission>);
						num = (<>1__state = -1);
						goto IL_011b;
					case 1:
						awaiter2 = <>u__1;
						<>u__1 = default(TaskAwaiter<NativeGallery.Permission>);
						num = (<>1__state = -1);
						goto IL_01a2;
					case 2:
						awaiter = <>u__2;
						<>u__2 = default(TaskAwaiter);
						num = (<>1__state = -1);
						goto IL_02b9;
					case 3:
						{
							awaiter = <>u__2;
							<>u__2 = default(TaskAwaiter);
							num = (<>1__state = -1);
							break;
						}
						IL_01ab:
						permission = result;
						if (permission != NativeGallery.Permission.Granted)
						{
							<>8__1.callback(arg1: false, <>8__1.sourceFilePath);
							LckLog.LogError($"LCK Gallery permission not granted: {permission}", "CopyToGallery", ".\\Packages\\tv.liv.lck\\Runtime\\Scripts\\Components\\FileUtilities.cs", 68);
						}
						goto end_IL_0069;
						IL_01a2:
						result = awaiter2.GetResult();
						goto IL_01ab;
						IL_02b9:
						awaiter.GetResult();
						awaiter = DeleteMatchingFilesAsync(<>8__2.CS$<>8__locals1.sourceFilePath).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (<>1__state = 3);
							<>u__2 = awaiter;
							<>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
						IL_011b:
						result = awaiter2.GetResult();
						goto IL_01ab;
					}
					awaiter.GetResult();
					<>8__2.CS$<>8__locals1.callback(arg1: true, <>8__2.destinationFilePath);
					<>8__2 = null;
					end_IL_0069:;
				}
				catch (Exception ex)
				{
					<>8__1.callback(arg1: false, <>8__1.sourceFilePath);
					LckLog.LogError("LCK Error reading file: " + ex.Message, "CopyToGallery", ".\\Packages\\tv.liv.lck\\Runtime\\Scripts\\Components\\FileUtilities.cs", 94);
				}
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				<>1__state = -2;
				<>8__1 = null;
				<>t__builder.SetException(exception);
				return;
			}
			<>1__state = -2;
			<>8__1 = null;
			<>t__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			<>t__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const string EchoFileMarker = "_Echo_";

	public static bool IsFileLocked(string filePath)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (IOException)
		{
			return true;
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}

	public unsafe static async Task CopyToGallery(string sourceFilePath, string albumName, Action<bool, string> callback)
	{
		Action<bool, string> action = default(Action<bool, string>);
		Action<bool, string> callback2 = action;
		string text = default(string);
		string sourceFilePath2 = text;
		if (File.Exists(sourceFilePath2))
		{
			bool flag = Path.GetExtension(sourceFilePath2) == ".mp4";
			try
			{
				string fileName = Path.GetFileName(sourceFilePath2);
				string text2 = default(string);
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = default(AsyncTaskMethodBuilder);
				if (Application.platform == RuntimePlatform.Android)
				{
					NativeGallery.Permission result;
					if (flag)
					{
						TaskAwaiter<NativeGallery.Permission> awaiter = NativeGallery.SaveVideoToGallery(sourceFilePath2, text2, fileName, WrappedMediaSaveCallback).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							asyncTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref *(<CopyToGallery>d__1*)/*Error near IL_00f3: stateMachine*/);
							return;
						}
						result = awaiter.GetResult();
					}
					else
					{
						TaskAwaiter<NativeGallery.Permission> awaiter = NativeGallery.SaveImageToGallery(sourceFilePath2, text2, fileName, WrappedMediaSaveCallback).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							asyncTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref *(<CopyToGallery>d__1*)/*Error near IL_017a: stateMachine*/);
							return;
						}
						result = awaiter.GetResult();
					}
					NativeGallery.Permission permission = result;
					if (permission != NativeGallery.Permission.Granted)
					{
						callback2(arg1: false, sourceFilePath2);
						LckLog.LogError($"LCK Gallery permission not granted: {permission}", "CopyToGallery", ".\\Packages\\tv.liv.lck\\Runtime\\Scripts\\Components\\FileUtilities.cs", 68);
					}
					return;
				}
				string text3 = Path.Combine(Environment.GetFolderPath(flag ? Environment.SpecialFolder.MyVideos : Environment.SpecialFolder.MyPictures), text2);
				if (!Directory.Exists(text3))
				{
					Directory.CreateDirectory(text3);
				}
				string destinationFilePath = Path.Combine(text3, fileName);
				TaskAwaiter awaiter2 = Task.Run(delegate
				{
					File.Copy(sourceFilePath2, destinationFilePath, overwrite: true);
				}).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					asyncTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref *(<CopyToGallery>d__1*)/*Error near IL_0291: stateMachine*/);
					return;
				}
				awaiter2.GetResult();
				awaiter2 = DeleteMatchingFilesAsync(sourceFilePath2).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					asyncTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref *(<CopyToGallery>d__1*)/*Error near IL_02fe: stateMachine*/);
					return;
				}
				awaiter2.GetResult();
				callback2(arg1: true, destinationFilePath);
				return;
			}
			catch (Exception ex)
			{
				callback2(arg1: false, sourceFilePath2);
				LckLog.LogError("LCK Error reading file: " + ex.Message, "CopyToGallery", ".\\Packages\\tv.liv.lck\\Runtime\\Scripts\\Components\\FileUtilities.cs", 94);
				return;
			}
		}
		callback2(arg1: false, sourceFilePath2);
		LckLog.LogError("LCK Source file does not exist: " + sourceFilePath2, "CopyToGallery", ".\\Packages\\tv.liv.lck\\Runtime\\Scripts\\Components\\FileUtilities.cs", 100);
		async void WrappedMediaSaveCallback(bool success, string path)
		{
			callback2(success, path);
			if (success)
			{
				await DeleteMatchingFilesAsync(sourceFilePath2);
			}
		}
	}

	public static string GenerateFilename(string extension)
	{
		string text = DateTime.Now.ToString(LckSettings.Instance.RecordingDateSuffixFormat);
		return LckSettings.Instance.RecordingFilenamePrefix + "_" + text + "." + extension;
	}

	public static string GenerateEchoFilename(string extension)
	{
		string text = DateTime.Now.ToString(LckSettings.Instance.RecordingDateSuffixFormat);
		return LckSettings.Instance.RecordingFilenamePrefix + "_Echo_" + text + "." + extension;
	}

	private static bool IsEchoFile(string filePath)
	{
		return Path.GetFileName(filePath).Contains("_Echo_");
	}

	private static async Task DeleteMatchingFilesAsync(string filePath)
	{
		try
		{
			string text = default(string);
			string folderPath = Path.GetDirectoryName(text);
			string fileExtension = Path.GetExtension(text);
			bool sourceIsEcho = IsEchoFile(text);
			if (folderPath == null)
			{
				return;
			}
			await Task.Run(delegate
			{
				string[] files = Directory.GetFiles(folderPath, "*" + fileExtension);
				foreach (string text2 in files)
				{
					if (IsEchoFile(text2) == sourceIsEcho)
					{
						try
						{
							File.Delete(text2);
						}
						catch (Exception ex)
						{
							LckLog.LogError("LCK Error deleting file " + text2 + ": " + ex.Message, "DeleteMatchingFilesAsync", ".\\Packages\\tv.liv.lck\\Runtime\\Scripts\\Components\\FileUtilities.cs", 155);
						}
					}
				}
			});
		}
		catch (Exception ex)
		{
			LckLog.LogError("LCK Error during file deletion: " + ex.Message, "DeleteMatchingFilesAsync", ".\\Packages\\tv.liv.lck\\Runtime\\Scripts\\Components\\FileUtilities.cs", 163);
		}
	}
}
