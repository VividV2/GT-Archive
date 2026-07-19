namespace System.CodeDom
{
	/// <summary>Represents a member of a type using a literal code fragment.</summary>
	[Serializable]
	public class CodeSnippetTypeMember : CodeTypeMember
	{
		private string _text;

		/// <summary>Gets or sets the literal code fragment for the type member.</summary>
		/// <returns>The literal code fragment for the type member.</returns>
		public string Text
		{
			get
			{
				return _text ?? string.Empty;
			}
			set
			{
				_text = value;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeSnippetTypeMember" /> class.</summary>
		public CodeSnippetTypeMember()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeSnippetTypeMember" /> class using the specified text.</summary>
		/// <param name="text">The literal code fragment for the type member.</param>
		public CodeSnippetTypeMember(string text)
		{
			Text = text;
		}
	}
}
namespace System.IO.Compression
{
	/// <summary>Specifies values that indicate whether a compression operation emphasizes speed or compression size.</summary>
	/// <summary>Specifies values that indicate whether a compression operation emphasizes speed or compression size.</summary>
	public enum CompressionLevel
	{
		/// <summary>The compression operation should be optimally compressed, even if the operation takes a longer time to complete.</summary>
		/// <summary>The compression operation should be optimally compressed, even if the operation takes a longer time to complete.</summary>
		Optimal,
		/// <summary>The compression operation should complete as quickly as possible, even if the resulting file is not optimally compressed.</summary>
		/// <summary>The compression operation should complete as quickly as possible, even if the resulting file is not optimally compressed.</summary>
		Fastest,
		/// <summary>No compression should be performed on the file.</summary>
		/// <summary>No compression should be performed on the file.</summary>
		NoCompression
	}
}
namespace Mono.Net.Security
{
}
namespace Mono.Unity
{
}
