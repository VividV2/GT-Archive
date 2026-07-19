using System.Reflection.Emit;
using System.Reflection.Emit;

namespace System.Xml.Serialization
{
	internal class RecursionLimiter
	{
		private int maxDepth;

		private int depth;

		private WorkItems deferredWorkItems;

		internal bool IsExceededLimit => depth > maxDepth;

		internal int Depth
		{
			get
			{
				return depth;
			}
			set
			{
				depth = value;
			}
		}

		internal WorkItems DeferredWorkItems
		{
			get
			{
				if (deferredWorkItems == null)
				{
					deferredWorkItems = new WorkItems();
				}
				return deferredWorkItems;
			}
		}

		internal RecursionLimiter()
		{
			depth = 0;
			maxDepth = (DiagnosticsSwitches.NonRecursiveTypeLoading.Enabled ? 1 : int.MaxValue);
		}
	}
}
namespace System.Xml.Serialization
{
	internal class ForState
	{
		private LocalBuilder indexVar;

		private Label beginLabel;

		private Label testLabel;

		private object end;

		internal LocalBuilder Index => indexVar;

		internal Label BeginLabel => beginLabel;

		internal Label TestLabel => testLabel;

		internal object End => end;

		internal ForState(LocalBuilder indexVar, Label beginLabel, Label testLabel, object end)
		{
			this.indexVar = indexVar;
			this.beginLabel = beginLabel;
			this.testLabel = testLabel;
			this.end = end;
		}
	}
}
