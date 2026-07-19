using System.Collections;
using System.Collections;

namespace System.Text.RegularExpressions
{
	internal class MatchSparse : Match
	{
		internal new readonly Hashtable _caps;

		public override GroupCollection Groups
		{
			get
			{
				if (_groupcoll == null)
				{
					_groupcoll = new GroupCollection(this, _caps);
				}
				return _groupcoll;
			}
		}

		internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos)
			: base(regex, capcount, text, begpos, len, startpos)
		{
			_caps = caps;
		}
	}
}
namespace System.Security.Cryptography.X509Certificates
{
}
namespace Microsoft.Win32
{
	/// <summary>Represents the method that will handle the <see cref="E:Microsoft.Win32.SystemEvents.SessionEnding" /> event from the operating system.</summary>
	/// <param name="sender">The source of the event. When this event is raised by the <see cref="T:Microsoft.Win32.SystemEvents" /> class, this object is always <see langword="null" />.</param>
	/// <param name="e">A <see cref="T:Microsoft.Win32.SessionEndingEventArgs" /> that contains the event data.</param>
	public delegate void SessionEndingEventHandler(object sender, SessionEndingEventArgs e);
}
