using System;
using VYaml.Emitter;
using VYaml.Parser;

namespace VYaml.Serialization;

public class TupleFormatter<T1, T2, T3> : IYamlFormatter<Tuple<T1, T2, T3>?>, IYamlFormatter
{
	public void Serialize(ref Utf8YamlEmitter emitter, Tuple<T1, T2, T3>? value, YamlSerializationContext context)
	{
		if (value == null)
		{
			emitter.WriteNull();
			return;
		}
		emitter.BeginSequence(SequenceStyle.Flow);
		context.Serialize(ref emitter, value.Item1);
		context.Serialize(ref emitter, value.Item2);
		context.Serialize(ref emitter, value.Item3);
		emitter.EndSequence();
	}

	public Tuple<T1, T2, T3>? Deserialize(ref YamlParser parser, YamlDeserializationContext context)
	{
		if (parser.IsNullScalar())
		{
			return null;
		}
		parser.ReadWithVerify(ParseEventType.SequenceStart);
		T1 item = context.DeserializeWithAlias<T1>(ref parser);
		T2 item2 = context.DeserializeWithAlias<T2>(ref parser);
		T3 item3 = context.DeserializeWithAlias<T3>(ref parser);
		parser.ReadWithVerify(ParseEventType.SequenceEnd);
		return new Tuple<T1, T2, T3>(item, item2, item3);
	}
}
