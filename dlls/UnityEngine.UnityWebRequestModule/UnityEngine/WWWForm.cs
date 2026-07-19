using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using System;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public class WWWForm
	{
		private List<byte[]> formData;

		private List<string> fieldNames;

		private List<string> fileNames;

		private List<string> types;

		private byte[] boundary;

		private bool containsFiles = false;

		private static byte[] dDash = DefaultEncoding.GetBytes("--");

		private static byte[] crlf = DefaultEncoding.GetBytes("\r\n");

		private static byte[] contentTypeHeader = DefaultEncoding.GetBytes("Content-Type: ");

		private static byte[] dispositionHeader = DefaultEncoding.GetBytes("Content-disposition: form-data; name=\"");

		private static byte[] endQuote = DefaultEncoding.GetBytes("\"");

		private static byte[] fileNameField = DefaultEncoding.GetBytes("; filename=\"");

		private static byte[] ampersand = DefaultEncoding.GetBytes("&");

		private static byte[] equal = DefaultEncoding.GetBytes("=");

		internal static Encoding DefaultEncoding => Encoding.ASCII;

		public Dictionary<string, string> headers
		{
			get
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				if (containsFiles)
				{
					dictionary["Content-Type"] = "multipart/form-data; boundary=\"" + Encoding.UTF8.GetString(boundary, 0, boundary.Length) + "\"";
				}
				else
				{
					dictionary["Content-Type"] = "application/x-www-form-urlencoded";
				}
				return dictionary;
			}
		}

		public byte[] data
		{
			get
			{
				using MemoryStream memoryStream = new MemoryStream(1024);
				if (containsFiles)
				{
					for (int i = 0; i < formData.Count; i++)
					{
						memoryStream.Write(crlf, 0, crlf.Length);
						memoryStream.Write(dDash, 0, dDash.Length);
						memoryStream.Write(boundary, 0, boundary.Length);
						memoryStream.Write(crlf, 0, crlf.Length);
						memoryStream.Write(contentTypeHeader, 0, contentTypeHeader.Length);
						byte[] bytes = Encoding.UTF8.GetBytes(types[i]);
						memoryStream.Write(bytes, 0, bytes.Length);
						memoryStream.Write(crlf, 0, crlf.Length);
						memoryStream.Write(dispositionHeader, 0, dispositionHeader.Length);
						string headerName = Encoding.UTF8.HeaderName;
						string text = fieldNames[i];
						if (!WWWTranscoder.SevenBitClean(text, Encoding.UTF8) || text.IndexOf("=?") > -1)
						{
							text = "=?" + headerName + "?Q?" + WWWTranscoder.QPEncode(text, Encoding.UTF8) + "?=";
						}
						byte[] bytes2 = Encoding.UTF8.GetBytes(text);
						memoryStream.Write(bytes2, 0, bytes2.Length);
						memoryStream.Write(endQuote, 0, endQuote.Length);
						if (fileNames[i] != null)
						{
							string text2 = fileNames[i];
							if (!WWWTranscoder.SevenBitClean(text2, Encoding.UTF8) || text2.IndexOf("=?") > -1)
							{
								text2 = "=?" + headerName + "?Q?" + WWWTranscoder.QPEncode(text2, Encoding.UTF8) + "?=";
							}
							byte[] bytes3 = Encoding.UTF8.GetBytes(text2);
							memoryStream.Write(fileNameField, 0, fileNameField.Length);
							memoryStream.Write(bytes3, 0, bytes3.Length);
							memoryStream.Write(endQuote, 0, endQuote.Length);
						}
						memoryStream.Write(crlf, 0, crlf.Length);
						memoryStream.Write(crlf, 0, crlf.Length);
						byte[] array = formData[i];
						memoryStream.Write(array, 0, array.Length);
					}
					memoryStream.Write(crlf, 0, crlf.Length);
					memoryStream.Write(dDash, 0, dDash.Length);
					memoryStream.Write(boundary, 0, boundary.Length);
					memoryStream.Write(dDash, 0, dDash.Length);
					memoryStream.Write(crlf, 0, crlf.Length);
				}
				else
				{
					for (int j = 0; j < formData.Count; j++)
					{
						byte[] array2 = WWWTranscoder.DataEncode(Encoding.UTF8.GetBytes(fieldNames[j]));
						byte[] toEncode = formData[j];
						byte[] array3 = WWWTranscoder.DataEncode(toEncode);
						if (j > 0)
						{
							memoryStream.Write(ampersand, 0, ampersand.Length);
						}
						memoryStream.Write(array2, 0, array2.Length);
						memoryStream.Write(equal, 0, equal.Length);
						memoryStream.Write(array3, 0, array3.Length);
					}
				}
				return memoryStream.ToArray();
			}
		}

		public WWWForm()
		{
			formData = new List<byte[]>();
			fieldNames = new List<string>();
			fileNames = new List<string>();
			types = new List<string>();
			boundary = new byte[40];
			for (int i = 0; i < 40; i++)
			{
				int num = Random.Range(48, 110);
				if (num > 57)
				{
					num += 7;
				}
				if (num > 90)
				{
					num += 6;
				}
				boundary[i] = (byte)num;
			}
		}

		public void AddField(string fieldName, string value)
		{
			AddField(fieldName, value, Encoding.UTF8);
		}

		public void AddField(string fieldName, string value, Encoding e)
		{
			fieldNames.Add(fieldName);
			fileNames.Add(null);
			formData.Add(e.GetBytes(value));
			types.Add("text/plain; charset=\"" + e.WebName + "\"");
		}

		public void AddField(string fieldName, int i)
		{
			AddField(fieldName, i.ToString());
		}

		[ExcludeFromDocs]
		public void AddBinaryData(string fieldName, byte[] contents)
		{
			AddBinaryData(fieldName, contents, null, null);
		}

		[ExcludeFromDocs]
		public void AddBinaryData(string fieldName, byte[] contents, string fileName)
		{
			AddBinaryData(fieldName, contents, fileName, null);
		}

		public void AddBinaryData(string fieldName, byte[] contents, [DefaultValue("null")] string fileName, [DefaultValue("null")] string mimeType)
		{
			containsFiles = true;
			bool flag = contents.Length > 8 && contents[0] == 137 && contents[1] == 80 && contents[2] == 78 && contents[3] == 71 && contents[4] == 13 && contents[5] == 10 && contents[6] == 26 && contents[7] == 10;
			if (fileName == null)
			{
				fileName = fieldName + (flag ? ".png" : ".dat");
			}
			if (mimeType == null)
			{
				mimeType = ((!flag) ? "application/octet-stream" : "image/png");
			}
			fieldNames.Add(fieldName);
			fileNames.Add(fileName);
			formData.Add(contents);
			types.Add(mimeType);
		}
	}
}
namespace UnityEngineInternal
{
	internal static class WebRequestUtils
	{
		private static Regex domainRegex = new Regex("^\\s*\\w+(?:\\.\\w+)+(\\/.*)?$");

		[RequiredByNativeCode]
		internal static string RedirectTo(string baseUri, string redirectUri)
		{
			Uri uri = ((redirectUri[0] != '/') ? new Uri(redirectUri, UriKind.RelativeOrAbsolute) : new Uri(redirectUri, UriKind.Relative));
			Uri uri;
			if (uri.IsAbsoluteUri)
			{
				return uri.AbsoluteUri;
			}
			Uri baseUri2 = new Uri(baseUri, UriKind.Absolute);
			Uri baseUri2;
			Uri uri2 = new Uri(baseUri2, uri);
			Uri uri2;
			return uri2.AbsoluteUri;
		}

		internal static string MakeInitialUrl(string targetUrl, string localUrl)
		{
			if (string.IsNullOrEmpty(targetUrl))
			{
				return "";
			}
			bool prependProtocol = false;
			Uri uri = new Uri(localUrl);
			Uri uri2 = null;
			Uri uri2;
			Uri uri;
			bool prependProtocol;
			if (targetUrl[0] == '/')
			{
				uri2 = new Uri(uri, targetUrl);
				prependProtocol = true;
			}
			if (uri2 == null && domainRegex.IsMatch(targetUrl))
			{
				targetUrl = uri.Scheme + "://" + targetUrl;
				prependProtocol = true;
			}
			FormatException ex = null;
			FormatException ex;
			try
			{
				if (uri2 == null && targetUrl[0] != '.')
				{
					uri2 = new Uri(targetUrl);
				}
			}
			catch (FormatException ex2)
			{
				ex = ex2;
			}
			if (uri2 == null)
			{
				try
				{
					uri2 = new Uri(uri, targetUrl);
					prependProtocol = true;
				}
				catch (FormatException)
				{
					throw ex;
				}
			}
			return MakeUriString(uri2, targetUrl, prependProtocol);
		}

		internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol)
		{
			if (targetUri.IsFile)
			{
				if (!targetUri.IsLoopback)
				{
					return targetUri.OriginalString;
				}
				string text = targetUri.AbsolutePath;
				string originalString = targetUri.OriginalString;
				string text;
				string originalString;
				if (text.Contains("%"))
				{
					if (text.Contains('+') && !originalString.StartsWith("file:"))
					{
						return "file:///" + originalString.Replace('\\', '/');
					}
					text = URLDecode(text);
				}
				if (text.Length > 0 && text[0] != '/')
				{
					text = "/" + text;
				}
				if (originalString.StartsWith("file://\\\\?\\", StringComparison.InvariantCultureIgnoreCase) || originalString.StartsWith("file:///\\\\?\\", StringComparison.InvariantCultureIgnoreCase))
				{
					return originalString;
				}
				return "file://" + text;
			}
			string scheme = targetUri.Scheme;
			string scheme;
			if (!prependProtocol && targetUrl.Length >= scheme.Length + 2 && targetUrl[scheme.Length + 1] != '/')
			{
				StringBuilder stringBuilder = new StringBuilder(scheme, targetUrl.Length);
				StringBuilder stringBuilder;
				stringBuilder.Append(':');
				if (scheme == "jar")
				{
					string text2 = targetUri.AbsolutePath;
					string text2;
					if (text2.Contains("%"))
					{
						text2 = URLDecode(text2);
					}
					if (text2.StartsWith("file:/") && text2.Length > 6 && text2[6] != '/')
					{
						stringBuilder.Append("file://");
						stringBuilder.Append(text2.Substring(5));
					}
					else
					{
						stringBuilder.Append(text2);
					}
					return stringBuilder.ToString();
				}
				stringBuilder.Append(targetUri.PathAndQuery);
				stringBuilder.Append(targetUri.Fragment);
				return stringBuilder.ToString();
			}
			if (targetUrl.Contains("%"))
			{
				return targetUri.OriginalString;
			}
			return targetUri.AbsoluteUri;
		}

		private static string URLDecode(string encoded)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(encoded);
			byte[] bytes;
			byte[] bytes2 = WWWTranscoder.URLDecode(bytes);
			byte[] bytes2;
			return Encoding.UTF8.GetString(bytes2);
		}
	}
}
