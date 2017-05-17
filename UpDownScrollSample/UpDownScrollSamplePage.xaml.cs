using System.Collections.Generic;
using Xamarin.Forms;

namespace UpDownScrollSample
{
    public partial class UpDownScrollSamplePage : ContentPage
    {
        private int _lastItemAppearedIdx;

        public List<string> Items { get; set; } = new List<string> ();

        public UpDownScrollSamplePage ()
        {
            InitializeComponent ();

            Items.Add ("A");
            Items.Add ("B");
            Items.Add ("C");
            Items.Add ("D");
            Items.Add ("E");
            Items.Add ("F");
            Items.Add ("G");
            Items.Add ("H");
            Items.Add ("I");
            Items.Add ("J");
            Items.Add ("K");
            Items.Add ("L");
            Items.Add ("M");
            Items.Add ("Foo");
            Items.Add ("Unicorn");
            Items.Add ("Apple");
            Items.Add ("Red");
            Items.Add ("Blah");
            Items.Add ("Ding");
            Items.Add ("Kermit");
            Items.Add ("Bag");
            Items.Add ("PS4");
            Items.Add ("Android");
            Items.Add ("Pea");

            BindingContext = this;
        }

        private void Handle_ItemAppearing (object sender, Xamarin.Forms.ItemVisibilityEventArgs e)
        {
            var currentIdx = Items.IndexOf ((string)e.Item);

            if (currentIdx > _lastItemAppearedIdx)
                Direction.Text = "Up";
            else
                Direction.Text = "Down";

            _lastItemAppearedIdx = Items.IndexOf ((string)e.Item);

        }
    }
}
