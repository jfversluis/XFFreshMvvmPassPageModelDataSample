using System;
using FreshMvvm;
using Xamarin.Forms;

namespace XFFreshMvvmNavigationSample.PageModels
{
    public class YouTuber
    {
        public string Author { get; set; }
        public bool Subscribed { get; set; }
    }

    public class MainPageModel : FreshBasePageModel
    {
        public Command GoToPageCommand { get; set; }
        public Command GoToPageModalCommand { get; set; }

        public MainPageModel()
        {
            var youtuber = new YouTuber
            {
                Author = "GeraldVersluis",
                Subscribed = false
            };

            GoToPageCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<FirstPageModel>(youtuber);
            });

            GoToPageModalCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<FirstPageModel>(youtuber, true);
            });
        }

        public override void ReverseInit(object returnedData)
        {
            var youtuber = returnedData as YouTuber;

            CoreMethods.DisplayAlert(youtuber.Author, $"Subscribed {youtuber.Subscribed}", "OK");
        }
    }
}
