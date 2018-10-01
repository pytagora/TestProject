using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddressBookUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var gridView = new GridView();
            this.addressBookList.View = gridView;

            var metaData = Abook.AddressBookEntry.Descriptor.Fields.InFieldNumberOrder();
            var addressBookColumns = new List<string>();
            foreach (var data in metaData)
            {
                addressBookColumns.Add(data.Name);
            }

            foreach (var column in addressBookColumns)
            {
                gridView.Columns.Add(new GridViewColumn
                {
                    Header = column, DisplayMemberBinding = new Binding(UpperCaseFirst(column))
                });
            }

            foreach(var entry in AddressBook.getAddressBook().Entry)
            {
                this.addressBookList.Items.Add(entry);

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var book = AddressBook.getAddressBook();
        }

        static string UpperCaseFirst(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }
            char[] a = word.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
