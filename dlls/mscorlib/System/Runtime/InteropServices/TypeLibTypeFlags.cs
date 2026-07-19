namespace System.Security.Cryptography.X509Certificates
{
	public enum X509ContentType
	{
		Unknown = 0,
		Cert = 1,
		SerializedCert = 2,
		Pfx = 3,
		Pkcs12 = 3,
		SerializedStore = 4,
		Pkcs7 = 5,
		Authenticode = 6
	}
}
namespace Internal.Runtime.Augments
{
	internal abstract class TaskTraceCallbacks
	{
		public abstract bool Enabled { get; }

		public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);

		public abstract void TaskStarted(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		public abstract void TaskCompleted(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, bool IsExceptional);
	}
}
