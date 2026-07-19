namespace UnityEngine.TextCore.Text
{
	internal struct WordInfo
	{
		public int firstCharacterIndex;

		public int lastCharacterIndex;

		public int characterCount;
	}
}
namespace UnityEngine.TextCore.Text
{
	internal enum TagValueType
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4
	}
}
