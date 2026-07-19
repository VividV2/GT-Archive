namespace Unity.Collections;

[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct NativeListDispose
{
	[NativeDisableUnsafePtrRestriction]
	public UntypedUnsafeList* m_ListData;

	public void Dispose()
	{
		listData = (UnsafeList<int>*)m_ListData;
		UnsafeList<int>.Destroy(listData);
	}
}
