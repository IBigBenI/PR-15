using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PR_15
{
    public partial class MainPage : ContentPage
    {
        bool alive = false;
        public MainPage()
        {
            InitializeComponent();
            entry.Text = "";
            DispalyTime();
        }
        private void StartStopTimer(object sender, EventArgs e)
        {
            if (entry.Text == "")
            {
                entry.Placeholder = "Вы не ввели заголовок записи";
            }
            else
            {
                if (alive == true)
                {
                    alive = false;
                    PageRecord record = new PageRecord();
                    record.callcells(entry.Text);
                    entry.Text = "";
                }
                else
                {
                    alive = true;
                    DispalyTime();
                }
            }         
        }
        private async void DispalyTime()
        {
            DateTime Datetime = new DateTime();
            while (alive) 
            {
                LabelTimer.Text = Datetime.ToString("HH:mm:ss.f");
                Datetime = Datetime.AddSeconds(0.1);
                await Task.Delay(100);
            }
        }
        private void RecordClick(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PageRecord());
        }
        private void EntryChanged(object sender, EventArgs e)
        {
            entry.Placeholder = "Введите заголовок записи";
        }
    }
}
