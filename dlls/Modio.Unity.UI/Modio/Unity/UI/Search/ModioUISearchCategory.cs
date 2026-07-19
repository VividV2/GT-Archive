using System;
using System.Collections.Generic;
using Modio.Mods;
using TMPro;
using UnityEngine;
using System;
using Modio.Mods;
using TMPro;
using UnityEngine;

namespace Modio.Unity.UI.Components.ModProperties
{
	[Serializable]
	public class ModPropertyVersion : IModProperty
	{
		[SerializeField]
		private TMP_Text _text;

		[SerializeField]
		private GameObject _disableIfNoVersionInfo;

		public void OnModUpdate(Mod mod)
		{
			if (_disableIfNoVersionInfo != null)
			{
				_disableIfNoVersionInfo.SetActive(!string.IsNullOrEmpty(mod.File.Version));
			}
			if (_text != null)
			{
				_text.text = mod.File.Version;
			}
		}
	}
}
namespace Modio.Unity.UI.Search
{
	public class ModioUISearchCategory : MonoBehaviour
	{
		[SerializeField]
		private string _categoryLabel;

		[SerializeField]
		private string _categoryLabelLocalized;

		[SerializeField]
		private List<ModioUISearchSettings> _tabs;

		[SerializeField]
		private ModioUISearchSettings _customSearchBase;

		public string CategoryLabel => _categoryLabel;

		public string CategoryLabelLocalized => _categoryLabelLocalized;

		public IEnumerable<ModioUISearchSettings> Tabs => _tabs;

		public ModioUISearchSettings CustomSearchBase => _customSearchBase;
	}
}
