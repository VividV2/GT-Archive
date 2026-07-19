namespace System.IO.Ports
{
	internal enum SerialSignal
	{
		None = 0,
		Cd = 1,
		Cts = 2,
		Dsr = 4,
		Dtr = 8,
		Rts = 0x10
	}
}
namespace System.ComponentModel
{
	public interface ISite : IServiceProvider
	{
		IComponent Component { get; }

		IContainer Container { get; }

		bool DesignMode { get; }

		string Name { get; set; }
	}
}
