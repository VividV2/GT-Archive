using System.Text;

namespace VYaml.Internal
{
	internal static class StringEncoding
	{
		public static readonly Encoding Utf8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
	}
}
namespace VYaml.Parser
{
	internal enum ParseState
	{
		StreamStart,
		ImplicitDocumentStart,
		DocumentStart,
		DocumentContent,
		DocumentEnd,
		BlockNode,
		BlockSequenceFirstEntry,
		BlockSequenceEntry,
		IndentlessSequenceEntry,
		BlockMappingFirstKey,
		BlockMappingKey,
		BlockMappingValue,
		FlowSequenceFirstEntry,
		FlowSequenceEntry,
		FlowSequenceEntryMappingKey,
		FlowSequenceEntryMappingValue,
		FlowSequenceEntryMappingEnd,
		FlowMappingFirstKey,
		FlowMappingKey,
		FlowMappingValue,
		FlowMappingEmptyValue,
		End
	}
}
namespace VYaml.Annotations
{
}
