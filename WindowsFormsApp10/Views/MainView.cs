using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp10.Models;

namespace WindowsFormsApp10.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> AddButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get; set; }
        public string ModelText { get => ModelTxtB.Text; set => ModelTxtB.Text = value; }
        public List<Car> Cars
        {
            set
            {
                dataListBx.DataSource = null;
                dataListBx.DataSource = value;
            }
        }
        public string VendorText { get => VendorTxtB.Text; set => VendorTxtB.Text = value; }
        public string ColorText { get => ColorTxtb.Text; set => ColorTxtb.Text = value; }
        public string TransmissionText { get => TransmissionTxtBx.Text; set => TransmissionTxtBx.Text = value; }
        public string YearText { get => YearTxtB.Text; set => YearTxtB.Text = value; }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddButtonClicked.Invoke(sender, e);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadButtonClicked.Invoke(sender, e);
        }
    }
}
