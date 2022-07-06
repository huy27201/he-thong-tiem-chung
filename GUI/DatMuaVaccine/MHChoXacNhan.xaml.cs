using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI.OrderVaccine
{
    /// <summary>
    /// Interaction logic for WaitForApprove.xaml
    /// </summary>
    public partial class WaitForApprove : Window
    {
        private PhieuMua phieuMua;
        public WaitForApprove()
        {
            InitializeComponent();

        }
        public WaitForApprove(PhieuMua message)
        {
            phieuMua = message;
        }

    }
}
