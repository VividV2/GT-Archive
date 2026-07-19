using System;
using System.Buffers.Text;
using System.Collections.Generic;
using VYaml.Emitter;
using VYaml.Parser;
using System.Collections.Generic;
using VYaml.Emitter;
using VYaml.Parser;

namespace VYaml.Serialization
{
	public class GuidFormatter : IYamlFormatter<Guid>, IYamlFormatter
	{
		public static readonly GuidFormatter Instance = new GuidFormatter();

		public void Serialize(ref Utf8YamlEmitter emitter, Guid value, YamlSerializationContext context)
		{
			byte[] buffer = context.GetBuffer64();
			if (Utf8Formatter.TryFormat(value, buffer, out var bytesWritten))
			{
				emitter.WriteScalar(buffer[..bytesWritten]);
				return;
			}
			throw new YamlSerializerException($"Cannot serialize {value}");
		}

		public Guid Deserialize(ref YamlParser parser, YamlDeserializationContext context)
		{
			if (parser.TryGetScalarAsSpan(out var span) && Utf8Parser.TryParse(span, out Guid value, out int bytesConsumed, '\0') && bytesConsumed == span.Length)
			{
				parser.Read();
				return value;
			}
			throw new YamlSerializerException($"Cannot detect a scalar value of Guid : {parser.CurrentEventType} {parser.GetScalarAsString()}");
		}
	}
}
namespace VYaml.Serialization
{
	public class InterfaceReadOnlyCollectionFormatter<T> : IYamlFormatter<IReadOnlyCollection<T>?>, IYamlFormatter
	{
		public void Serialize(ref Utf8YamlEmitter emitter, IReadOnlyCollection<T>? value, YamlSerializationContext context)
		{
			if (value == null)
			{
				emitter.WriteNull();
				return;
			}
			emitter.BeginSequence();
			if (value.Count > 0)
			{
				IYamlFormatter<T> formatterWithVerify = context.Resolver.GetFormatterWithVerify<T>();
				foreach (T item in value)
				{
					IYamlFormatter<T> formatterWithVerify;
					formatterWithVerify.Serialize(ref emitter, item, context);
				}
			}
			emitter.EndSequence();
		}

		public IReadOnlyCollection<T>? Deserialize(ref YamlParser parser, YamlDeserializationContext context)
		{
			if (parser.IsNullScalar())
			{
				parser.Read();
				return null;
			}
			parser.ReadWithVerify(ParseEventType.SequenceStart);
			List<T> list = new List<T>();
			IYamlFormatter<T> formatterWithVerify = context.Resolver.GetFormatterWithVerify<T>();
			List<T> list;
			while (!parser.End && parser.CurrentEventType != ParseEventType.SequenceEnd)
			{
				IYamlFormatter<T> formatterWithVerify;
				T item = context.DeserializeWithAlias(formatterWithVerify, ref parser);
				T item;
				list.Add(item);
			}
			parser.ReadWithVerify(ParseEventType.SequenceEnd);
			return list;
		}
	}
}
