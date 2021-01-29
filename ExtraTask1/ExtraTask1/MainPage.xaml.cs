using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace ExtraTask1
{
    public class Colors
    {
        public string NameColor { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public List<Colors> allcolors { get; set; }
        public MainPage()
        {
            InitializeComponent();
            allcolors = new List<Colors>();
            foreach (System.Drawing.Color color in AllColors.Getallcolors())
            {
                allcolors.Add(new Colors()
                {
                    NameColor = color.Name
                });
            }
            BindingContext = this;
        }
    }
}
