// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	PageCS.tt
// Version:		2.0
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Entities=WPAppStudio.Entities;
using Ioc=WPAppStudio.Ioc;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Repositories=WPAppStudio.Repositories;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for YouTube_DetailVideos.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class YouTube_DetailVideos : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for YouTube_DetailVideos and all its components.
        /// </summary>
        public YouTube_DetailVideos()
        {
            InitializeComponent();        
			if (Resources.Contains("PanoramaYouTube_DetailVideos0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["PanoramaYouTube_DetailVideos0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramaYouTube_DetailVideos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramaYouTube_DetailVideos(PanoramaYouTube_DetailVideos.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramaYouTube_DetailVideos(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
		    else if(ApplicationBar != null)
		        ApplicationBar.IsVisible = false;
        }

		protected override void OnBackKeyPress(CancelEventArgs e)
		{
			if (MyToolkit.Multimedia.YouTube.CancelPlay())
				e.Cancel = true;

			base.OnBackKeyPress(e);
		}
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string currentId;
			
            if (NavigationContext.QueryString.TryGetValue("currentID", out currentId))
            {
				var dataSource = new Ioc.Container().Resolve<Repositories.IYouTube_YouTube>();
				AddHomeAppBarButton();
				var pinnedItemSpec = new FilterSpecification().AddPredicate("VideoId", ColumnOperatorEnum.Equals, currentId);
				var pinnedItem  = (await dataSource.Search(pinnedItemSpec)).FirstOrDefault();
				if(pinnedItem==null)
					MessageBox.Show(Localization.AppResources.PinError);
				((IViewModels.IYouTube_DetailVideosViewModel)DataContext).CurrentYouTubeVideo = pinnedItem;				
			}
			MyToolkit.Multimedia.YouTube.CancelPlay();
		}

        private void AddHomeAppBarButton()
        {
            if (ApplicationBar.Buttons.Count >= 4 ||
                ApplicationBar.Buttons.Cast<ApplicationBarIconButton>().Any(button => button.Text == "Home")) 
                return;
						
			var homeIcon = new ApplicationBarIconButton() {IconUri = new Uri("/Images/Icons/Light/Home.png", UriKind.Relative), IsEnabled = true, Text = "Home"};
            homeIcon.Click += delegate 
			{ 
				new Ioc.Container().Resolve<IServices.INavigationService>().NavigateTo<IViewModels.IWeb_NewsViewModel>(); 
				while (NavigationService.RemoveBackEntry() != null);
			};
            ApplicationBar.Buttons.Add(homeIcon);
        }
    }
}