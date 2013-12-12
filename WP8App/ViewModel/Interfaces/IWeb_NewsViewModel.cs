// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	IViewModel.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// Web_News ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IWeb_NewsViewModel
    {		
        /// <summary>
        /// Gets/Sets the Web_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Web_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedWeb_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedWeb_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the YouTube_VideosListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.YouTubeVideo> YouTube_VideosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the YouTube_VideosListControlCollectionPageNumber property.
        /// </summary>
		int YouTube_VideosListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedYouTube_VideosListControlCollection property.
        /// </summary>
		EntitiesBase.YouTubeVideo SelectedYouTube_VideosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Facebook_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Facebook_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedFacebook_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedFacebook_NewsListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshWeb_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshWeb_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetWeb_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetWeb_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshYouTube_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshYouTube_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetYouTube_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand GetYouTube_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshFacebook_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshFacebook_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetFacebook_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetFacebook_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

        
        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
		ICommand AboutCommand { get; }

	}
}