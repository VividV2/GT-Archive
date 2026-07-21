namespace System.Drawing.Imaging;

/// <summary>Used to specify the data type of the <see cref="T:System.Drawing.Imaging.EncoderParameter" /> used with the <see cref="Overload:System.Drawing.Image.Save" /> or <see cref="Overload:System.Drawing.Image.SaveAdd" /> method of an image.</summary>
public enum EncoderParameterValueType
{
	ValueTypeByte = 1,
	ValueTypeAscii,
	ValueTypeShort,
	ValueTypeLong,
	ValueTypeRational,
	ValueTypeLongRange,
	ValueTypeUndefined,
	ValueTypeRationalRange
}
namespace System
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoNotSupportedAttribute : MonoTODOAttribute
	{
		public MonoNotSupportedAttribute(string comment)
			: base(comment)
		{
		}
	}
}
