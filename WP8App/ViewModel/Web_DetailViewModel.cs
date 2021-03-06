// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	ViewModel.tt
// Version:		2.0
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls = WPAppStudio.Controls;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;
using IServices = WPAppStudio.Services.Interfaces;
using IViewModels = WPAppStudio.ViewModel.Interfaces;
using Localization = WPAppStudio.Localization;
using Repositories = WPAppStudio.Repositories;
using Services = WPAppStudio.Services;
using ViewModelsBase = WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of Web_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Web_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IWeb_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.Web_RSS _web_RSS;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Web_DetailViewModel" /> class.
        /// </summary>
        /// <param name="web_RSS">The Web_ R S S.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public Web_DetailViewModel(Repositories.Web_RSS web_RSS, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_web_RSS = web_RSS;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private EntitiesBase.RssSearchResult _currentRssSearchResult;

        /// <summary>
        /// CurrentRssSearchResult property.
        /// </summary>		
        public EntitiesBase.RssSearchResult CurrentRssSearchResult
        {
            get
            {
				return _currentRssSearchResult;
            }
            set
            {
                SetProperty(ref _currentRssSearchResult, value);
            }
        }
	
		private bool _hasNextpanoramaWeb_Detail0;

        /// <summary>
        /// HasNextpanoramaWeb_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaWeb_Detail0
        {
            get
            {
				return _hasNextpanoramaWeb_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaWeb_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaWeb_Detail0;

        /// <summary>
        /// HasPreviouspanoramaWeb_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaWeb_Detail0
        {
            get
            {
				return _hasPreviouspanoramaWeb_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaWeb_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the ShareWeb_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareWeb_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentRssSearchResult.Title, CurrentRssSearchResult.Content, CurrentRssSearchResult.FeedUrl, CurrentRssSearchResult.ImageUrl);
        }
		

        private ICommand _shareWeb_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareWeb_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareWeb_DetailStaticControlCommand
        {
            get { return _shareWeb_DetailStaticControlCommand = _shareWeb_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareWeb_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartWeb_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartWeb_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IWeb_DetailViewModel), CreateTileInfoWeb_DetailStaticControl());
        }
		

        private ICommand _pinToStartWeb_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartWeb_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartWeb_DetailStaticControlCommand
        {
            get { return _pinToStartWeb_DetailStaticControlCommand = _pinToStartWeb_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartWeb_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceWeb_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceWeb_DetailStaticControlCommandDelegate() 
        {
				_navigationService.NavigateTo(string.IsNullOrEmpty(CurrentRssSearchResult.FeedUrl) ? null : new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceWeb_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceWeb_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceWeb_DetailStaticControlCommand
        {
            get { return _goToSourceWeb_DetailStaticControlCommand = _goToSourceWeb_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(GoToSourceWeb_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaWeb_Detail0 command.
        /// </summary>
        public async void NextpanoramaWeb_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var next = await  _web_RSS.Next(CurrentRssSearchResult);

			if(next != null)
				CurrentRssSearchResult = next;

			RefreshHasPrevNext();
        }
		
		
        private bool _loadingCurrentRssSearchResult;
		
        public bool LoadingCurrentRssSearchResult
        {
            get { return _loadingCurrentRssSearchResult; }
            set { SetProperty(ref _loadingCurrentRssSearchResult, value); }
        }

        private ICommand _nextpanoramaWeb_Detail0;

        /// <summary>
        /// Gets the NextpanoramaWeb_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaWeb_Detail0
        {
            get { return _nextpanoramaWeb_Detail0 = _nextpanoramaWeb_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaWeb_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaWeb_Detail0 command.
        /// </summary>
        public async void PreviouspanoramaWeb_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var prev = await  _web_RSS.Previous(CurrentRssSearchResult);

			if(prev != null)
				CurrentRssSearchResult = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaWeb_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaWeb_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaWeb_Detail0
        {
            get { return _previouspanoramaWeb_Detail0 = _previouspanoramaWeb_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaWeb_Detail0Delegate); }
        }

        private async void RefreshHasPrevNext()
        {
            HasPreviouspanoramaWeb_Detail0 = await _web_RSS.HasPrevious(CurrentRssSearchResult);
			HasNextpanoramaWeb_Detail0 = await _web_RSS.HasNext(CurrentRssSearchResult);
			LoadingCurrentRssSearchResult = false;
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is EntitiesBase.RssSearchResult)) { return; }
                
                CurrentRssSearchResult = value as EntitiesBase.RssSearchResult;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the Web_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoWeb_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentRssSearchResult.Title,
                Title = CurrentRssSearchResult.Title,
                BackTitle = CurrentRssSearchResult.Title,
                BackContent = CurrentRssSearchResult.Content,
                Count = 0,
                BackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                BackBackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                LogoPath = "Logo-e5fdb3ff-dfbe-482b-8e55-b7902363885e.png"
            };
            return tileInfo;
        }
    }
}
