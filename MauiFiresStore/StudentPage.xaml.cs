using System.Diagnostics;
using MauiFiresStore.Services;
using MauiFiresStore.ViewModels;


namespace MauiFiresStore;
public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}