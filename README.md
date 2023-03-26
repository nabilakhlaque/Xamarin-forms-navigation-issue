# Xamarin-forms-navigation-issue



I am building an Xamarin Forms app for iOS and Android. I registered my routes in AppShell.xaml.cs globally like this:

**-AppShell.xaml.cs-**
Routes.Add(nameof(HousingFolderPage), typeof(HousingFolderPage));
Routes.Add(nameof(HousingFolderDetailsPage), typeof(HousingFolderDetailsPage));

In my tabbar I have a tab "MoreServicePage" which shows a list of items. So far so good.

**-MoreServicePage.cs-**
private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
{
    await Shell.Current.GoToAsync($"HousingFolderPage");
}

Now when HousingFolderPage is showing, I have no problem navigating back from here. HousingFolderPage also shows another list, but when I push to next page, I'm not able to come back.

**-HousingFolderPage.xaml.cs-**
private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
{
    await Shell.Current.GoToAsync("HousingFolderDetailsPage");
}

Error message:

    [0:] Shell: Failed to Navigate Back: System.ArgumentException: Ambiguous routes matched for: //D_FAULT_TabBar2/IMPL_MoreServicePage/MoreServicePage/HousingFolderPage matches found: //D_FAULT_TabBar2/IMPL_MoreServicePage/MoreServicePage/HousingFolderPage,//D_FAULT_TabBar2/IMPL_MoreServicePage/MoreServicePage/HousingFolderPage Parameter name: uri

I have only registered the routs in AppShell programmaticly (AppShell.xaml.cs) and no other places not even in the AppShell.xaml.

PS. this seems to happen everywhere where I navigate 2 pages deep, while 1 page deep works without a problem

I have created a simple Xamarin Forms Application to reproduce this issue. As you will see, you are able to navigate back from page 2, but not from page 3 to page 4 nor from page 4 to page 3.
