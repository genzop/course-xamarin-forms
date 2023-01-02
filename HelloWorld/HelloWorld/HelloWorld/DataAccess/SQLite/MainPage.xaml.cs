using SQLite;
using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.DataAccess.SQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;

		public MainPage ()
		{
			InitializeComponent ();

            //Carga la conexión a la base de datos, similar al DbContext            
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();        
        }

        protected override async void OnAppearing()
        {
            //Sino existe, crea la tabla Recipe
            await _connection.CreateTableAsync<Recipe>();                 
            
            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);

            lvRecipes.ItemsSource = _recipes;

            base.OnAppearing();
        }

        private async void OnAdd(object sender, EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe" + DateTime.Now.Ticks };
            await _connection.InsertAsync(recipe);
            _recipes.Add(recipe);
        }

        private async void OnUpdate(object sender, EventArgs e)
        {
            var recipe = _recipes[0];
            recipe.Name += " UPDATED";
            await _connection.UpdateAsync(recipe);
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            var recipe = _recipes[0];
            await _connection.DeleteAsync(recipe);
            _recipes.Remove(recipe);
        }
    }
}