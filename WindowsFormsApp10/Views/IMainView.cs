using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp10.Models;

namespace WindowsFormsApp10.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClicked { get; set; }
        EventHandler<EventArgs> LoadButtonClicked { get; set; }
        string ModelText { get; set; }
        List<Car> Cars {  set; }
        string VendorText { get; set; }
        string ColorText { get; set; }
        string TransmissionText { get; set; }
        string YearText { get; set; }

    }
}
