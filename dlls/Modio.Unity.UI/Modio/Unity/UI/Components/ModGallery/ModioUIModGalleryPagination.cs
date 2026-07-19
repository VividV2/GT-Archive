using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

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
namespace Modio.Unity.UI.Components.ModGallery
{
	public class ModioUIModGalleryPagination : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		internal ModioUIModGallery Gallery;

		internal int Index;

		[SerializeField]
		private GameObject _inactiveGameObject;

		[SerializeField]
		private GameObject _activeGameObject;

		public void OnPointerClick(PointerEventData eventData)
		{
			if ((bool)Gallery)
			{
				Gallery.GoTo(Index);
			}
		}

		public void SetState(bool active)
		{
			if (_inactiveGameObject != null)
			{
				_inactiveGameObject.SetActive(!active);
			}
			if (_activeGameObject != null)
			{
				_activeGameObject.SetActive(active);
			}
		}
	}
}
