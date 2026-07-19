using System;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

namespace Unity.Properties
{
}
namespace Unity.Properties.Internal
{
	internal class SystemVersionPropertyBag : ContainerPropertyBag<Version>
	{
		private class MajorProperty : Property<Version, int>
		{
			public override string Name => "Major";

			public override bool IsReadOnly => true;

			public MajorProperty()
			{
				AddAttribute(new MinAttribute(0f));
			}

			public override int GetValue(ref Version container)
			{
				return container.Major;
			}

			public override void SetValue(ref Version container, int value)
			{
			}
		}

		private class MinorProperty : Property<Version, int>
		{
			public override string Name => "Minor";

			public override bool IsReadOnly => true;

			public MinorProperty()
			{
				AddAttribute(new MinAttribute(0f));
			}

			public override int GetValue(ref Version container)
			{
				return container.Minor;
			}

			public override void SetValue(ref Version container, int value)
			{
			}
		}

		private class BuildProperty : Property<Version, int>
		{
			public override string Name => "Build";

			public override bool IsReadOnly => true;

			public BuildProperty()
			{
				AddAttribute(new MinAttribute(0f));
			}

			public override int GetValue(ref Version container)
			{
				return container.Build;
			}

			public override void SetValue(ref Version container, int value)
			{
			}
		}

		private class RevisionProperty : Property<Version, int>
		{
			public override string Name => "Revision";

			public override bool IsReadOnly => true;

			public RevisionProperty()
			{
				AddAttribute(new MinAttribute(0f));
			}

			public override int GetValue(ref Version container)
			{
				return container.Revision;
			}

			public override void SetValue(ref Version container, int value)
			{
			}
		}

		public SystemVersionPropertyBag()
		{
			AddProperty(new MajorProperty());
			AddProperty(new MinorProperty());
			AddProperty(new BuildProperty());
			AddProperty(new RevisionProperty());
		}
	}
}
namespace Unity.Properties.Internal
{
	internal class RectIntPropertyBag : ContainerPropertyBag<RectInt>
	{
		private class XProperty : Property<RectInt, int>
		{
			public override string Name => "x";

			public override bool IsReadOnly => false;

			public override int GetValue(ref RectInt container)
			{
				return container.x;
			}

			public override void SetValue(ref RectInt container, int value)
			{
				container.x = value;
			}
		}

		private class YProperty : Property<RectInt, int>
		{
			public override string Name => "y";

			public override bool IsReadOnly => false;

			public override int GetValue(ref RectInt container)
			{
				return container.y;
			}

			public override void SetValue(ref RectInt container, int value)
			{
				container.y = value;
			}
		}

		private class WidthProperty : Property<RectInt, int>
		{
			public override string Name => "width";

			public override bool IsReadOnly => false;

			public override int GetValue(ref RectInt container)
			{
				return container.width;
			}

			public override void SetValue(ref RectInt container, int value)
			{
				container.width = value;
			}
		}

		private class HeightProperty : Property<RectInt, int>
		{
			public override string Name => "height";

			public override bool IsReadOnly => false;

			public override int GetValue(ref RectInt container)
			{
				return container.height;
			}

			public override void SetValue(ref RectInt container, int value)
			{
				container.height = value;
			}
		}

		public RectIntPropertyBag()
		{
			AddProperty(new XProperty());
			AddProperty(new YProperty());
			AddProperty(new WidthProperty());
			AddProperty(new HeightProperty());
		}
	}
}
namespace Unity.Properties
{
	public interface ISetPropertyBagVisitor
	{
		void Visit<TSet, TValue>(ISetPropertyBag<TSet, TValue> properties, ref TSet container) where TSet : ISet<TValue>;
	}
}
namespace Unity.Properties
{
	public interface IVisitPropertyAdapter<TContainer, TValue> : IPropertyVisitorAdapter
	{
		void Visit(in VisitContext<TContainer, TValue> context, ref TContainer container, ref TValue value);
	}
}
