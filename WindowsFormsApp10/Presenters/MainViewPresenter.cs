using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp10.Data;
using WindowsFormsApp10.Models;
using WindowsFormsApp10.Views;

namespace WindowsFormsApp10.Presenters
{
    public class MainViewPresenter
    {
        private readonly CarContext _db;
        private IMainView _view;

        public MainViewPresenter(IMainView view)
        {
            _view = view;
            _view.AddButtonClicked += ViewAddButtonClicked;
            _view.LoadButtonClicked += ViewLoadButtonClicked;
            _db = new CarContext();
        }
        private void ViewAddButtonClicked(object sender,EventArgs e)        
        {
            Car car = new Car {  
            Model = _view.ModelText,
            Vendor = _view.VendorText,
            Year = int.Parse(_view.YearText),
            Color = _view.ColorText,
            Transmission = _view.TransmissionText
            };
            _db.Cars.Add(car);
            _db.SaveChanges();
        }
        private void ViewLoadButtonClicked(object sender,EventArgs e)
        {
            var list = _db.Cars.ToList();
            _view.Cars = list;

        }
    }
}
