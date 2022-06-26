using System.Collections.Generic;
using System.Windows;

namespace ProjetWPFAout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
             * 1
             * 
             * AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Bike> bikeDAO = adf.GetBikeDAO();
            Member m = new Member(1, "Martens", "Rémi", 0492821292, "remi", "1234", 0);
            List<Bike> bikes = bikeDAO.Find(m);
            */

            /*
             * 2
             * 
             * BikeDAO bikeDAO = new BikeDAO();
            Member m = new Member(1, "Martens", "Rémi", 0492821292, "remi", "1234", 0);

            List<Bike> bikes = bikeDAO.FindAll(m);

            System.Diagnostics.Debug.WriteLine(bikes[0].IdBike);
            */

            /*
             * 3
             * 
             * Member m = new Member(1, "martens", "rémi", 0492821292, "remi", "1234", 0);
            Bike bike = new Bike();
            List<Bike> bikes = bike.GetAllBikes();
            foreach (Bike b in bikes)
            {
                System.Diagnostics.Debug.WriteLine(b.IdBike);
            }
            */

            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Bike> bikeDAO = adf.GetBikeDAO();
            Member m = new Member(1, "Martens", "Rémi", 0492821292, "remi", "1234", 0);
            List<Bike> bikes = bikeDAO.FindAll();
        }
    }
}