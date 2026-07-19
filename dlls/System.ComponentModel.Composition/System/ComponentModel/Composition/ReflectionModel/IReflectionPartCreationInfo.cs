using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Reflection;

namespace System.ComponentModel.Composition.ReflectionModel
{
	internal abstract class ReflectionWritableMember : ReflectionMember
	{
		public abstract bool CanWrite { get; }

		public abstract void SetValue(object instance, object value);

		protected ReflectionWritableMember()
		{
			base..ctor();
		}
	}
}
namespace System.ComponentModel.Composition.ReflectionModel
{
	internal interface IReflectionPartCreationInfo : ICompositionElement
	{
		bool IsDisposalRequired { get; }

		Type GetPartType();

		Lazy<Type> GetLazyPartType();

		ConstructorInfo GetConstructor();

		IDictionary<string, object> GetMetadata();

		IEnumerable<ExportDefinition> GetExports();

		IEnumerable<ImportDefinition> GetImports();
	}
}
