using System;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
	public sealed class JsonConstructorAttribute : Attribute
	{
	}
}
namespace Newtonsoft.Json
{
	public enum StringEscapeHandling
	{
		Default,
		EscapeNonAscii,
		EscapeHtml
	}
}
