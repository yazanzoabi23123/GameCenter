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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace gameCenter.Projects
{
    /// <summary>
    /// Interaction logic for ProjectPresentationPage.xaml
    /// </summary>
    public partial class ProjectPresentationPage : Window
    {
        private Window cuttentProject;

        public ProjectPresentationPage()
        {

            InitializeComponent();

        }
        public void OnStart(string title, string projectDescription, ImageSource imageSoursce, Window project)
        {

            TitleLabel.Content = title;
            ProjectText.Text = projectDescription;
            ProjectImage.Source = imageSoursce;
            cuttentProject = project;

        }
      

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Hide();
            cuttentProject.ShowDialog();
            ShowDialog();
            cuttentProject.Close();
        }
        //private void ProjectImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    Close();
        //    currentProject!.ShowDialog();
        //    currentProject!.Close();
        //}
    }
}
