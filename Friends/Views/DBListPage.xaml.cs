using Friends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Friends.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DBListPage : ContentPage
	{
		public DBListPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
			friendsList.ItemSource = App.Database.GetItems();
            base.OnAppearing();
        }
		private async void OnItemsSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Friend selecetedFriend = (Friend)e.SelectedItem;
			DBFriendPage friendPage = new DBFriendPage();
			friendPage.BindingContext = selecetedFriend;
			await Navigation.PushAsync(friendPage);
		}
		private async void CreateFriend(object sender, EventArgs e)
		{
			Friend friend = new Friend();
            DBFriendPage friendPage = new DBFriendPage();
            friendPage.BindingContext = selecetedFriend;
            await Navigation.PushAsync(friendPage);
        }
    }
}