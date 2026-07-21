namespace System.Xml.Schema
{
	internal class Datatype_monthDay : Datatype_dateTimeBase
	{
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GMonthDay;
			}
		}

		internal Datatype_monthDay()
		{
			base..ctor(XsdDateTimeFlags.GMonthDay);
		}
	}
}
namespace System.Xml.Schema
{
	internal enum AttributeMatchState
	{
		AttributeFound,
		AnyIdAttributeFound,
		UndeclaredElementAndAttribute,
		UndeclaredAttribute,
		AnyAttributeLax,
		AnyAttributeSkip,
		ProhibitedAnyAttribute,
		ProhibitedAttribute,
		AttributeNameMismatch,
		ValidateAttributeInvalidCall
	}
}
namespace System.Xml.Schema
{
}
