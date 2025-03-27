using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using potrawy.View;
using potrawy.Model;
using System.Collections.ObjectModel;

namespace potrawy.Service
{
  public  class DataService
    {
        public ObservableCollection<dania> dania{ get; set; }
        public dania SelectedDish { get; set; }
        public DataService()
        {
            dania = new()
            {
               new dania
{
    Name = "Pizza Margherita",
    Price = 34.50,
    Description = "Klasyczna pizza z pomidorami, mozzarellą i bazylią.",
    Type = "Pizza",
    Ingredients = new ObservableCollection<string> { "Ciasto", "Sos pomidorowy", "Mozzarella", "Bazylia" },
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a3/Eq_it-na_pizza-margherita_sep2005_sml.jpg"
},
new dania
{
    Name = "Spaghetti Carbonara",
    Price = 18.00,
    Description = "Pyszne spaghetti z sosem jajecznym, boczkiem i parmezanem.",
    Type = "Pasta",
    Ingredients = new ObservableCollection<string> { "Spaghetti", "Boczek", "Jajka", "Parmezan" },
    ImageUrl = "https://static01.nyt.com/images/2021/02/14/dining/carbonara-horizontal/carbonara-horizontal-mediumSquareAt3X-v2.jpg"
},
new dania
{
    Name = "Lasagne",
    Price = 32.00,
    Description = "Lasagne z mięsem mielonym, serem i sosem pomidorowym.",
    Type = "Pasta",
    Ingredients = new ObservableCollection<string> { "Makaron", "Mięso mielone", "Ser", "Sos pomidorowy" },
    ImageUrl = "https://staticsmaker.iplsc.com/smaker_production_2023_01_25/f7ecd17cbc17b7234143fa5b3a293872-content.jpg"
},

new dania
{
    Name = "Zupa Pomidorowa",
    Price = 10.50,
    Description = "Tradycyjna polska zupa pomidorowa z ryżem.",
    Type = "Zupa",
    Ingredients = new ObservableCollection<string> { "Pomidor", "Ryż", "Bulion", "Śmietana" },
    ImageUrl = "https://img.wprost.pl/img/wysmienita-zupa-pomidorowa-ze-swiezych-pomidorow-z-tego-przepisu-przygotowywala-ja-moja-babcia/1f/1a/c69122a80c37084cbe83608f4120.webp"
},
new dania
    {
        Name = "Zurek",
        Price = 12.00,
        Description = "Tradycyjna polska zupa na zakwasie, podawana z białą kiełbasą i jajkiem.",
        Type = "Zupa",
        Ingredients = new ObservableCollection<string> { "Zakwas", "Biała kiełbasa", "Jajko", "Chrzan", "Bulion" },
        ImageUrl = "zurek.jpg"
    },
new dania
    {
        Name = "Pizza Pepperoni",
        Price = 28.00,
        Description = "Klasyczna pizza na cienkim cieście z sosem pomidorowym, mozzarellą i pikantnym pepperoni.",
        Type = "Pizza",
        Ingredients = new ObservableCollection<string> { "Ciasto", "Sos pomidorowy", "Mozzarella", "Pepperoni", "Oregano" },
        ImageUrl = "pizza.jpg"
    }
            };
        }
    }

}
