using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Consulta_Rest_Api
{
    public partial class MainPage : ContentPage
    {
        public IList <PaisesModel> Paises { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            Paises = new List<PaisesModel>();
            Paises.Add(new PaisesModel
            {
                Name = "Honduras",
                Ubicacion = "Situada en el centro del istmo centroamericano",
                url = "https://img.freepik.com/foto-gratis/bandera-honduras_1401-128.jpg?w=2000"


            } ) ;
            Paises.Add(new PaisesModel
            {
                Name = "Guatemala",
                Ubicacion = "Está ubicada en América Central y limita con México",
                url = "https://flagshub.com/images/flag-of-guatemala.png"


            });
            Paises.Add(new PaisesModel
            {
                Name = "El Salvador",
                Ubicacion = "al Norte y al Este con Honduras, al Oeste con Guatemala y al Sur con el Océano Pacífico",
                url = "https://cdn.pixabay.com/photo/2012/04/10/23/26/el-salvador-27001_960_720.png"


            });
            Paises.Add(new PaisesModel
            {
                Name = "Costa Rica",
                Ubicacion = "8° y 11°15', de latitud norte, y 82° y 86°, de longitud oeste",
                url = "https://static.vecteezy.com/system/resources/previews/015/309/531/original/costa-rica-waving-flag-realistic-transparent-background-free-png.png"


            });
            Paises.Add(new PaisesModel
            {
                Name = "Panama",
                Ubicacion = "Situada oeste – este",
                url = "https://w0.peakpx.com/wallpaper/976/593/HD-wallpaper-panama-flag-panama-silk-flag-national-symbols-central-america.jpg"


            });
            Paises.Add(new PaisesModel
            {
                Name = "Belice",
                Ubicacion = "Limita al norte con México y al oeste y sur con Guatemala.",
                url = "https://www.sitographics.com/enciclog/banderas/america/image_2012/Belice.gif"


            });
            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PaisesModel selectedItem = e.SelectedItem as PaisesModel;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            PaisesModel tappedItem = e.Item as PaisesModel;
        }
    }



    }
