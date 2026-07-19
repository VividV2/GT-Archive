using System.IO;

namespace ICSharpCode.SharpZipLib
{
}
namespace ICSharpCode.SharpZipLib.Zip
{
	public interface IDynamicDataSource
	{
		Stream GetSource(ZipEntry entry, string name);
	}
}
