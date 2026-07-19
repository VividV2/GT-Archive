using System.Runtime.InteropServices;

namespace GorillaTag.Scripts.Utilities;

public struct RPCArgBuffer<T>(T argStruct) where T : struct
{
	public T Args = argStruct;

	public byte[] Data = new byte[DataLength];

	public int DataLength = Marshal.SizeOf(typeof(T));
}
