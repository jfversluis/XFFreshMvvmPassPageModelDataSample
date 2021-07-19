using System;
using FreshMvvm;
using Xamarin.Forms;

namespace XFFreshMvvmNavigationSample.PageModels
{
    public class FirstPageModel : FreshBasePageModel
    {
        public string FirstPageMessage { get; set; } = "Have you subscribed to my channel yet? ;)";

        public Command ClosePageCommand { get; set; }

        public YouTuber YouTuber { get; set; }

        public FirstPageModel()
        {
            ClosePageCommand = new Command(() =>
            {
                CoreMethods.PopPageModel(YouTuber, modal: true);
            });
        }

        public override void Init(object initData)
        {
            YouTuber = initData as YouTuber;
        }
    }
}
