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
    /// Implementation of YouTube_DetailVideos ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class YouTube_DetailVideosViewModel : ViewModelsBase.VMBase, IViewModels.IYouTube_DetailVideosViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.YouTube_YouTube _youTube_YouTube;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="YouTube_DetailVideosViewModel" /> class.
        /// </summary>
        /// <param name="youTube_YouTube">The You Tube_ You Tube.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public YouTube_DetailVideosViewModel(Repositories.YouTube_YouTube youTube_YouTube, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_youTube_YouTube = youTube_YouTube;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private EntitiesBase.YouTubeVideo _currentYouTubeVideo;

        /// <summary>
        /// CurrentYouTubeVideo property.
        /// </summary>		
        public EntitiesBase.YouTubeVideo CurrentYouTubeVideo
        {
            get
            {
				return _currentYouTubeVideo;
            }
            set
            {
                SetProperty(ref _currentYouTubeVideo, value);
            }
        }
	
		private bool _hasNextpanoramaYouTube_DetailVideos0;

        /// <summary>
        /// HasNextpanoramaYouTube_DetailVideos0 property.
        /// </summary>		
        public bool HasNextpanoramaYouTube_DetailVideos0
        {
            get
            {
				return _hasNextpanoramaYouTube_DetailVideos0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaYouTube_DetailVideos0, value);
            }
        }
	
		private bool _hasPreviouspanoramaYouTube_DetailVideos0;

        /// <summary>
        /// HasPreviouspanoramaYouTube_DetailVideos0 property.
        /// </summary>		
        public bool HasPreviouspanoramaYouTube_DetailVideos0
        {
            get
            {
				return _hasPreviouspanoramaYouTube_DetailVideos0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaYouTube_DetailVideos0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechYouTube_DetailVideosStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechYouTube_DetailVideosStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentYouTubeVideo.Title);
        }
		

        private ICommand _textToSpeechYouTube_DetailVideosStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechYouTube_DetailVideosStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechYouTube_DetailVideosStaticControlCommand
        {
            get { return _textToSpeechYouTube_DetailVideosStaticControlCommand = _textToSpeechYouTube_DetailVideosStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechYouTube_DetailVideosStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareYouTube_DetailVideosStaticControlCommand command.
        /// </summary>
        public  void ShareYouTube_DetailVideosStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentYouTubeVideo.Title, "", CurrentYouTubeVideo.ExternalUrl, CurrentYouTubeVideo.VideoId);
        }
		

        private ICommand _shareYouTube_DetailVideosStaticControlCommand;

        /// <summary>
        /// Gets the ShareYouTube_DetailVideosStaticControlCommand command.
        /// </summary>
        public ICommand ShareYouTube_DetailVideosStaticControlCommand
        {
            get { return _shareYouTube_DetailVideosStaticControlCommand = _shareYouTube_DetailVideosStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareYouTube_DetailVideosStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartYouTube_DetailVideosStaticControlCommand command.
        /// </summary>
        public  void PinToStartYouTube_DetailVideosStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IYouTube_DetailVideosViewModel), CreateTileInfoYouTube_DetailVideosStaticControl());
        }
		

        private ICommand _pinToStartYouTube_DetailVideosStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartYouTube_DetailVideosStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartYouTube_DetailVideosStaticControlCommand
        {
            get { return _pinToStartYouTube_DetailVideosStaticControlCommand = _pinToStartYouTube_DetailVideosStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartYouTube_DetailVideosStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceYouTube_DetailVideosStaticControlCommand command.
        /// </summary>
        public  void GoToSourceYouTube_DetailVideosStaticControlCommandDelegate() 
        {
				_navigationService.NavigateTo(string.IsNullOrEmpty(CurrentYouTubeVideo.ExternalUrl) ? null : new Uri(CurrentYouTubeVideo.ExternalUrl));
        }
		

        private ICommand _goToSourceYouTube_DetailVideosStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceYouTube_DetailVideosStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceYouTube_DetailVideosStaticControlCommand
        {
            get { return _goToSourceYouTube_DetailVideosStaticControlCommand = _goToSourceYouTube_DetailVideosStaticControlCommand ?? new ViewModelsBase.DelegateCommand(GoToSourceYouTube_DetailVideosStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaYouTube_DetailVideos0 command.
        /// </summary>
        public async void NextpanoramaYouTube_DetailVideos0Delegate() 
        {
				LoadingCurrentYouTubeVideo = true;
			var next = await  _youTube_YouTube.Next(CurrentYouTubeVideo);

			if(next != null)
				CurrentYouTubeVideo = next;

			RefreshHasPrevNext();
        }
		
		
        private bool _loadingCurrentYouTubeVideo;
		
        public bool LoadingCurrentYouTubeVideo
        {
            get { return _loadingCurrentYouTubeVideo; }
            set { SetProperty(ref _loadingCurrentYouTubeVideo, value); }
        }

        private ICommand _nextpanoramaYouTube_DetailVideos0;

        /// <summary>
        /// Gets the NextpanoramaYouTube_DetailVideos0 command.
        /// </summary>
        public ICommand NextpanoramaYouTube_DetailVideos0
        {
            get { return _nextpanoramaYouTube_DetailVideos0 = _nextpanoramaYouTube_DetailVideos0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaYouTube_DetailVideos0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaYouTube_DetailVideos0 command.
        /// </summary>
        public  void PreviouspanoramaYouTube_DetailVideos0Delegate() 
        {
			var prev =  _youTube_YouTube.Previous(CurrentYouTubeVideo);

			if(prev != null)
				CurrentYouTubeVideo = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaYouTube_DetailVideos0;

        /// <summary>
        /// Gets the PreviouspanoramaYouTube_DetailVideos0 command.
        /// </summary>
        public ICommand PreviouspanoramaYouTube_DetailVideos0
        {
            get { return _previouspanoramaYouTube_DetailVideos0 = _previouspanoramaYouTube_DetailVideos0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaYouTube_DetailVideos0Delegate); }
        }

        private async void RefreshHasPrevNext()
        {
            HasPreviouspanoramaYouTube_DetailVideos0 = _youTube_YouTube.HasPrevious(CurrentYouTubeVideo);
			HasNextpanoramaYouTube_DetailVideos0 = await _youTube_YouTube.HasNext(CurrentYouTubeVideo);
			LoadingCurrentYouTubeVideo = false;
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is EntitiesBase.YouTubeVideo)) { return; }
                
                CurrentYouTubeVideo = value as EntitiesBase.YouTubeVideo;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the YouTube_DetailVideosStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoYouTube_DetailVideosStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentYouTubeVideo.VideoId,
                Title = CurrentYouTubeVideo.Title,
                BackTitle = CurrentYouTubeVideo.Title,
                BackContent = string.Empty,
                Count = 0,
                BackgroundImagePath = CurrentYouTubeVideo.VideoImageUrl,
                BackBackgroundImagePath = CurrentYouTubeVideo.VideoImageUrl,
                LogoPath = "Logo-e5fdb3ff-dfbe-482b-8e55-b7902363885e.png"
            };
            return tileInfo;
        }
    }
}