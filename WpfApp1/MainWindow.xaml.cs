using HelixToolkit.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        

        Model3DGroup skeleton;

        Model3D rest;
        Model3D humerus_sinister;
        Model3D humerus_dexter;
        Model3D antebrachium_sinister;
        Model3D antebrachium_dexter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "obj|*.obj";
            if ((bool)openFileDialog.ShowDialog())
            {
                #region 產生XAML
                //var model3DGroup = new ObjReader().Read(openFileDialog.FileName);
                //XamlExporter exporter = new XamlExporter();

                //FileStream fs = new FileStream(openFileDialog.FileName.Replace(".obj", ".xaml"), FileMode.Create);
                //StreamWriter sw = new StreamWriter(fs);
                //exporter.Export(model3DGroup, fs);
                //MessageBox.Show(openFileDialog.FileName); 
                #endregion 產生XAML
                #region 開啟OBJ
                ObjReader CurrentHelixObjReader = new ObjReader();
                #region 修改顏色
                Model3DGroup MyModel = CurrentHelixObjReader.Read(openFileDialog.FileName);
                System.Windows.Media.Media3D.Material mat = MaterialHelper.CreateMaterial(
                       new SolidColorBrush(Color.FromRgb(0, 255, 0)));

                foreach (System.Windows.Media.Media3D.GeometryModel3D geometryModel in MyModel.Children)
                {
                    geometryModel.Material = mat;
                    // geometryModel.BackMaterial = matred;
                }
                #endregion 修改顏色
                // Display the model
                foo.Content = MyModel;
                #endregion 修改顏色
                
            }


        }
    }
}
