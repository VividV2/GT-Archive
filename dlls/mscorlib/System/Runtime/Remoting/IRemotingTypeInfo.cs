namespace System.Runtime;

/// <summary>Indicates whether the next blocking garbage collection compacts the large object heap (LOH).</summary>
public enum GCLargeObjectHeapCompactionMode
{
	Default = 1,
	CompactOnce
}
