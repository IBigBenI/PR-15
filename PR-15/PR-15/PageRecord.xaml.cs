using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR_15
{
    public partial class PageRecord : ContentPage
    {
        public PageRecord()
        {
            InitializeComponent();           
        }
        private void BackClick(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        public void callcells(string cell)
        {      
            TextCell cellText = new TextCell() { Text = cell };
            Table.Add(cellText);       
        }
    }
}
	
