// using Models;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Windows;
// using System.Windows.Controls;
// using System.Windows.Data;
// using System.Windows.Documents;
// using System.Windows.Input;
// using System.Windows.Media;
// using System.Windows.Media.Imaging;
// using System.Windows.Shapes;

// namespace GUI
// {
//     /// <summary>
//     /// Interaction logic for MHXemLichLamViec.xaml
//     /// </summary>
//     public partial class MHXemLichLamViec : Window
//     {
//         private List<string> lichLamViec;
//         private List<PhieuDangKy> registrationForms;
//         public MHXemLichLamViec()
//         {
//             InitializeComponent();
//             lichLamViec = new List<string>()
//             {
//                 "Tất cả",
//                 "Đã duyệt",
//                 "Chưa duyệt"
//             };
//             RegistrationFormStatusComboBox.ItemsSource = lichLamViec;

//             registrationForms = new List<PhieuDangKy>()
//             {
//                 new Lich()
//                 {
//                     MaNv = "01",
//                     Ngay = new DateTime(),
//                     Ca = 1,
//                     LoaiLich = "Lịch làm việc"
                    
                    
//                 }
//             };
//             RegistrationFormDataGrid.ItemsSource = registrationForms;
//         }
//     }
// }
