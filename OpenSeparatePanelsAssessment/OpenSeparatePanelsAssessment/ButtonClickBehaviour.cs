using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;
using OpenSeparatePanelsAssessment.ViewModels;
using System.Windows.Input;

namespace OpenSeparatePanelsAssessment
{
    public class ButtonClickBehaviour:Behavior<Button>
    {
     
        protected override void OnChanged()
        {
            AssociatedObject.Click += AssociatedObject_Click;
        }

        private void AssociatedObject_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b.Name == "purpletalk")
            {
                b.DataContext = (new PurPleTalkViewModel());
            }
            if (b.Name == "xcubelabs")
            {
                b.DataContext = (new XcubeLabsViewModel());
            }
            if (b.Name == "yesgnome")
            {
                b.DataContext = (new YesGnomeViewModel());
            }
        }
    }
}
