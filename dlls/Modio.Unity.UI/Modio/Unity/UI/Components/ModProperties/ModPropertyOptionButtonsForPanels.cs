using System;
using System.Threading.Tasks;
using Modio.Images;
using Modio.Mods;
using Modio.Unity.UI.Panels;
using Modio.Unity.UI.Panels.Report;
using Modio.Unity.UI.Search;
using Modio.Users;
using UnityEngine;
using UnityEngine.UI;
using System;
using Modio.Images;
using Modio.Mods;
using Modio.Users;
using UnityEngine;
using UnityEngine.UI;

namespace Modio.Unity.UI.Components.ModProperties
{
	[Serializable]
	public class ModPropertyCreatorAvatar : IModProperty
	{
		[SerializeField]
		private RawImage _image;

		[SerializeField]
		private UserProfile.AvatarResolution _resolution;

		private LazyImage<Texture2D> _lazyImage;

		public void OnModUpdate(Mod mod)
		{
			if (_lazyImage == null)
			{
				_lazyImage = new LazyImage<Texture2D>(ImageCacheTexture2D.Instance, delegate(Texture2D texture2D)
				{
					if (_image != null)
					{
						_image.texture = texture2D;
					}
				});
			}
			_lazyImage.SetImage(mod.Creator.Avatar, _resolution);
		}
	}
}
namespace Modio.Unity.UI.Components.ModProperties
{
	[Serializable]
	public class ModPropertyOptionButtonsForPanels : IModProperty
	{
		[SerializeField]
		private Button _viewModButton;

		[SerializeField]
		private Button _moreFromCreatorButton;

		[SerializeField]
		private Button _reportModButton;

		[SerializeField]
		private Button _retryDownloadButton;

		[SerializeField]
		private Button _uninstallButton;

		private Mod _mod;

		public void OnModUpdate(Mod mod)
		{
			_mod = mod;
			SetupButton(_viewModButton, ViewModButtonClicked);
			SetupButton(_moreFromCreatorButton, MoreFromCreatorButtonClicked);
			SetupButton(_reportModButton, ReportModButtonClicked);
			SetupButton(_retryDownloadButton, RetryDownloadButtonClicked);
			SetupButton(_uninstallButton, UninstallModButtonClicked);
		}

		private void ViewModButtonClicked()
		{
			ModioPanelManager.GetPanelOfType<ModDisplayPanel>().OpenPanel(_mod);
		}

		private void MoreFromCreatorButtonClicked()
		{
			ModioUISearch.Default.SetSearchForUser(_mod.Creator);
		}

		private void ReportModButtonClicked()
		{
			ModioPanelManager.GetPanelOfType<ModioReportPanel>().OpenReportFlow(_mod);
		}

		private void RetryDownloadButtonClicked()
		{
			Task<Error> task = ModInstallationManagement.RetryInstallingMod(_mod);
			ModioPanelManager.GetPanelOfType<ModioErrorPanelGeneric>()?.MonitorTaskThenOpenPanelIfError(task);
		}

		private void UninstallModButtonClicked()
		{
			_mod.UninstallOtherUserMod();
		}
	}
}
