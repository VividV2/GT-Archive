namespace ICSharpCode.SharpZipLib.Core
{
	public interface IScanFilter
	{
		bool IsMatch(string name);
	}
}
namespace ICSharpCode.SharpZipLib.Core
{
	public delegate void ProgressHandler(object sender, ProgressEventArgs e);
}
