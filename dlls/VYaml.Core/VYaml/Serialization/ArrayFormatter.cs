using System;
using System.Collections.Generic;
using System;
using System;

namespace VYaml.Parser
{
	public class Tag : ITokenContent
	{
		public string Handle { get; }

		public string Suffix { get; }

		public Tag(string handle, string suffix)
		{
			Handle = handle;
			Suffix = suffix;
		}

		public override string ToString()
		{
			return Handle + Suffix;
		}

		public bool Equals(string tagString)
		{
			if (tagString.Length != Handle.Length + Suffix.Length)
			{
				return false;
			}
			int num = tagString.IndexOf(Handle, StringComparison.Ordinal);
			int num;
			int num;
			if (num < 0)
			{
				return false;
			}
			return tagString.IndexOf(Suffix, num, StringComparison.Ordinal) > 0;
		}
	}
}
namespace VYaml.Parser
{
}
namespace VYaml.Serialization
{
}
namespace VYaml.Serialization
{
	public class ArrayFormatter<T> : IYamlFormatter<T[]?>, IYamlFormatter
	{
		public void Serialize(ref VYaml.Emitter.Utf8YamlEmitter emitter, T[]? value, YamlSerializationContext context)
		{
			if (value == null)
			{
				emitter.WriteNull();
				return;
			}
			IYamlFormatter<T> formatterWithVerify = context.Resolver.GetFormatterWithVerify<T>();
			emitter.BeginSequence();
			foreach (T value2 in value)
			{
				formatterWithVerify.Serialize(ref emitter, value2, context);
			}
			emitter.EndSequence();
		}

		public T[]? Deserialize(ref VYaml.Parser.YamlParser parser, YamlDeserializationContext context)
		{
			if (parser.IsNullScalar())
			{
				parser.Read();
				return null;
			}
			parser.ReadWithVerify(VYaml.Parser.ParseEventType.SequenceStart);
			List<T> list = new System.Collections.Generic.List<T>();
			IYamlFormatter<T> formatterWithVerify = context.Resolver.GetFormatterWithVerify<T>();
			while (!parser.End && parser.CurrentEventType != VYaml.Parser.ParseEventType.SequenceEnd)
			{
				T item = context.DeserializeWithAlias(formatterWithVerify, ref parser);
				list.Add(item);
			}
			parser.ReadWithVerify(VYaml.Parser.ParseEventType.SequenceEnd);
			return list.ToArray();
		}
	}
}
namespace VYaml.Serialization
{
	public interface IYamlFormatterResolver
	{
		IYamlFormatter<T>? GetFormatter<T>();
	}
}
