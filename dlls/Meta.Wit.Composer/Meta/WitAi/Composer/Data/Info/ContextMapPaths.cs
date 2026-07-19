using System;
using UnityEngine;
using System;
using UnityEngine;

namespace Meta.WitAi.Composer.Data.Info
{
	[Serializable]
	public struct ContextMapPaths
	{
		[Tooltip("The path names and values which are written by the Composer graph for the client to read. Composer does not read these values.")]
		public ComposerGraphValues[] server;

		[Tooltip("The path names which the Composer graph references but does not modify. The values of these must be supplied by the client.")]
		public string[] client;

		[Tooltip("The paths which the Composer graph both modifies and references. The client read or modify these.")]
		public ComposerGraphValues[] shared;
	}
}
namespace Meta.WitAi.Composer.Data.Info
{
	[Serializable]
	public struct ComposerGraph
	{
		[HideInInspector]
		public string canvasName;

		[Tooltip("The Context Map is a JSON object passed between the the server and the client. \nThese are the JSON paths and values present in the Context Map on the server")]
		public ContextMapPaths contextMap;

		[Tooltip("A listing of all the actions sent by the Responses in this canvas.")]
		public string[] actions;
	}
}
