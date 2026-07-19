using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Backtrace.Unity.Common
{
	internal static class MetricsHelper
	{
		public static string GetMicroseconds(this Stopwatch stopwatch)
		{
			return Math.Max(1L, stopwatch.ElapsedTicks * 1000000 / Stopwatch.Frequency).ToString(CultureInfo.InvariantCulture);
		}

		public static void Restart(this Stopwatch stopwatch)
		{
			stopwatch.Stop();
			stopwatch.Reset();
			stopwatch.Start();
		}
	}
}
namespace Backtrace.Unity.Common
{
	public static class TypeHelper
	{
		private static readonly HashSet<Type> NumericTypes = new HashSet<Type>
		{
			typeof(int),
			typeof(double),
			typeof(decimal),
			typeof(long),
			typeof(short),
			typeof(sbyte),
			typeof(byte),
			typeof(ulong),
			typeof(ushort),
			typeof(uint),
			typeof(float)
		};

		public static bool IsNumeric(Type myType)
		{
			return NumericTypes.Contains(Nullable.GetUnderlyingType(myType) ?? myType);
		}
	}
}
