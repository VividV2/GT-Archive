using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using UnityEngine;
using ExitGames.Client.Photon;
using UnityEngine;
using ExitGames.Client.Photon;
using UnityEngine;

namespace Photon.Realtime
{
	public class WebRpcResponse
	{
		public string Name { get; private set; }

		public int ResultCode { get; private set; }

		[Obsolete("Use ResultCode instead")]
		public int ReturnCode => ResultCode;

		public string Message { get; private set; }

		[Obsolete("Use Message instead")]
		public string DebugMessage => Message;

		public Dictionary<string, object> Parameters { get; private set; }

		public WebRpcResponse(OperationResponse response)
		{
			if (response.Parameters.TryGetValue(209, out var value))
			{
				Name = value as string;
			}
			ResultCode = -1;
			if (response.Parameters.TryGetValue(207, out value))
			{
				ResultCode = (byte)value;
			}
			if (response.Parameters.TryGetValue(208, out value))
			{
				Parameters = value as Dictionary<string, object>;
			}
			if (response.Parameters.TryGetValue(206, out value))
			{
				Message = value as string;
			}
		}

		public string ToStringFull()
		{
			return string.Format("{0}={2}: {1} \"{3}\"", Name, SupportClass.DictionaryToString(Parameters), ResultCode, Message);
		}
	}
}
namespace Photon.Realtime
{
	internal static class CustomTypesUnity
	{
		private const int SizeV2 = 8;

		private const int SizeV3 = 12;

		private const int SizeQuat = 16;

		public static readonly byte[] memVector3 = new byte[12];

		public static readonly byte[] memVector2 = new byte[8];

		public static readonly byte[] memQuarternion = new byte[16];

		internal static void Register()
		{
			PhotonPeer.RegisterType(typeof(Vector2), 87, SerializeVector2, DeserializeVector2);
			PhotonPeer.RegisterType(typeof(Vector3), 86, SerializeVector3, DeserializeVector3);
			PhotonPeer.RegisterType(typeof(Quaternion), 81, SerializeQuaternion, DeserializeQuaternion);
		}

		private static short SerializeVector3(StreamBuffer outStream, object customobject)
		{
			Vector3 vector = (Vector3)customobject;
			int targetOffset = 0;
			lock (memVector3)
			{
				byte[] array = memVector3;
				Vector3 vector;
				byte[] array;
				int targetOffset;
				Vector3 vector;
				byte[] array;
				int targetOffset;
				Protocol.Serialize(vector.x, array, ref targetOffset);
				Protocol.Serialize(vector.y, array, ref targetOffset);
				Protocol.Serialize(vector.z, array, ref targetOffset);
				outStream.Write(array, 0, 12);
			}
			return 12;
		}

		private static object DeserializeVector3(StreamBuffer inStream, short length)
		{
			Vector3 vector = default(Vector3);
			Vector3 vector;
			Vector3 vector;
			if (length != 12)
			{
				return vector;
			}
			lock (memVector3)
			{
				inStream.Read(memVector3, 0, 12);
				int offset = 0;
				int offset;
				int offset;
				Protocol.Deserialize(out vector.x, memVector3, ref offset);
				Protocol.Deserialize(out vector.y, memVector3, ref offset);
				Protocol.Deserialize(out vector.z, memVector3, ref offset);
			}
			return vector;
		}

		private static short SerializeVector2(StreamBuffer outStream, object customobject)
		{
			Vector2 vector = (Vector2)customobject;
			lock (memVector2)
			{
				byte[] array = memVector2;
				int targetOffset = 0;
				Vector2 vector;
				byte[] array;
				int targetOffset;
				Vector2 vector;
				byte[] array;
				int targetOffset;
				Protocol.Serialize(vector.x, array, ref targetOffset);
				Protocol.Serialize(vector.y, array, ref targetOffset);
				outStream.Write(array, 0, 8);
			}
			return 8;
		}

		private static object DeserializeVector2(StreamBuffer inStream, short length)
		{
			Vector2 vector = default(Vector2);
			Vector2 vector;
			Vector2 vector;
			if (length != 8)
			{
				return vector;
			}
			lock (memVector2)
			{
				inStream.Read(memVector2, 0, 8);
				int offset = 0;
				int offset;
				int offset;
				Protocol.Deserialize(out vector.x, memVector2, ref offset);
				Protocol.Deserialize(out vector.y, memVector2, ref offset);
			}
			return vector;
		}

		private static short SerializeQuaternion(StreamBuffer outStream, object customobject)
		{
			Quaternion quaternion = (Quaternion)customobject;
			lock (memQuarternion)
			{
				byte[] array = memQuarternion;
				int targetOffset = 0;
				Quaternion quaternion;
				byte[] array;
				int targetOffset;
				Quaternion quaternion;
				byte[] array;
				int targetOffset;
				Protocol.Serialize(quaternion.w, array, ref targetOffset);
				Protocol.Serialize(quaternion.x, array, ref targetOffset);
				Protocol.Serialize(quaternion.y, array, ref targetOffset);
				Protocol.Serialize(quaternion.z, array, ref targetOffset);
				outStream.Write(array, 0, 16);
			}
			return 16;
		}

		private static object DeserializeQuaternion(StreamBuffer inStream, short length)
		{
			Quaternion identity = Quaternion.identity;
			Quaternion identity;
			Quaternion identity;
			if (length != 16)
			{
				return identity;
			}
			lock (memQuarternion)
			{
				inStream.Read(memQuarternion, 0, 16);
				int offset = 0;
				int offset;
				int offset;
				Protocol.Deserialize(out identity.w, memQuarternion, ref offset);
				Protocol.Deserialize(out identity.x, memQuarternion, ref offset);
				Protocol.Deserialize(out identity.y, memQuarternion, ref offset);
				Protocol.Deserialize(out identity.z, memQuarternion, ref offset);
			}
			return identity;
		}
	}
}
