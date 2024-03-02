using AppListaDeCompras.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AppListaDeCompras.ViewModels;

public partial class ListToBuyViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<ListToBuy> _listToBuy;

    public ListToBuyViewModel() 
    {
        ListToBuy = new ObservableCollection<ListToBuy>()
        {
            new ListToBuy()
            {
                Name = "Minha lista 1",
                Users = new List<User>()
                {
                    new User(){ Name = "Luiz Eduardo", Email = "luiz@gmail.com" },
                    new User(){ Name = "Anna Cláudia", Email = "anna@hotmail.com" },
                },
                Products = new List<Product>()
                {
                    new Product(){},
                    new Product(){},
                    new Product(){},
                }
            },      
            new ListToBuy()
            {
                Name = "Minha lista 2",
                Users = new List<User>()
                {
                    new User(){ Name = "João Marcello", Email = "jm9@outlook.com" }
                },
                 Products = new List<Product>()
                {
                    new Product(){},
                    new Product(){},
                }
            },
        };
    }
}
