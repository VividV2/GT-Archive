using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace g3
{
	public class OFFFormatReader : MeshFormatReader
	{
		public List<string> SupportedExtensions => new List<string> { "off" };

		public IOReadResult ReadFile(string sFilename, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			try
			{
				using FileStream stream = File.Open(sFilename, FileMode.Open, FileAccess.Read, FileShare.Read);
				return ReadFile(stream, builder, options, messages);
			}
			catch (Exception ex)
			{
				return new IOReadResult(IOCode.FileAccessError, "Could not open file " + sFilename + " for reading : " + ex.Message);
			}
		}

		public IOReadResult ReadFile(Stream stream, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			OFFReader oFFReader = new OFFReader();
			OFFReader oFFReader;
			OFFReader oFFReader;
			oFFReader.warningEvent += messages;
			return oFFReader.Read(new StreamReader(stream), options, builder);
		}
	}
}
namespace g3
{
}
namespace g3
{
}
namespace g3
{
}
namespace g3
{
}
namespace g3
{
	public interface IMeshBuilder
	{
		bool SupportsMetaData { get; }

		int AppendNewMesh(bool bHaveVtxNormals, bool bHaveVtxColors, bool bHaveVtxUVs, bool bHaveFaceGroups);

		int AppendNewMesh(DMesh3 existingMesh);

		void SetActiveMesh(int id);

		int AppendVertex(double x, double y, double z);

		int AppendVertex(NewVertexInfo info);

		int AppendTriangle(int i, int j, int k);

		int AppendTriangle(int i, int j, int k, int g);

		void SetVertexUV(int vID, Vector2f Uvs);

		int BuildMaterial(GenericMaterial m);

		void AssignMaterial(int materialID, int meshID);

		void AppendMetaData(string identifier, object data);
	}
}
