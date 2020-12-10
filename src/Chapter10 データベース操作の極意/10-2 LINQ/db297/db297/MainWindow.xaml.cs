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

namespace db297
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ent = new sampledbEntities();
            var q = from b in ent.Book
                    join au in ent.Author on b.AuthorId equals au.ID into temp
                    from t in temp.DefaultIfEmpty()
                    select new Result { ID = b.ID, Title = b.Title, Author = t.Name };
            dg.ItemsSource = q.ToList();
        }

        /// GridDataに表示するクラス
        class Result
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
        }

    }
}
