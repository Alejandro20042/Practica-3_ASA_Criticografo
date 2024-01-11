using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica_3_ASA_Criticografo
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Boton_Clicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            string genero = RadioGeneroHombre.IsChecked ? "Hombre" : "Mujer";
            

            string caracteristicas = "";

            if (RadioGeneroHombre.IsChecked)
            {
                if (Alto.IsChecked)
                {
                    caracteristicas += " Alto,";
                }
                if (Feo.IsChecked)
                {
                    caracteristicas += " Feo,";

                }
                if (Hermoso.IsChecked)
                {
                    caracteristicas += " Hermoso,";
                }
                if (Extravagante.IsChecked)
                {
                    caracteristicas += " Extravagante,";
                }
                if (Guapo.IsChecked)
                {
                    caracteristicas += " Guapo,";
                }
                if (Listo.IsChecked)
                {
                    caracteristicas += " Listo,";
                }
            }
            else
            {
                if (Alto.IsChecked)
                {
                    caracteristicas += " Alta,";
                }
                if (Feo.IsChecked)
                {
                    caracteristicas += " Fea,";

                }
                if (Hermoso.IsChecked)
                {
                    caracteristicas += " Hermosa,";
                }
               
                if (Guapo.IsChecked)
                {
                    caracteristicas += " Guapa,";
                }

                if (Listo.IsChecked)
                {
                    caracteristicas += " Lista,";
                }
                if (Extravagante.IsChecked)
                {
                    caracteristicas += " Extravagante,";
                }

            }

            string resultado = $"{nombre} es {genero}, ";

            if (!string.IsNullOrWhiteSpace(caracteristicas))
            {
                //LastIndexOf busca el ultimo caracter asignado
                int ultimaComa = caracteristicas.TrimEnd(',').LastIndexOf(',');

                if (ultimaComa >= 0)
                {
                    resultado += $"es {caracteristicas.Substring(0, ultimaComa)} y{caracteristicas.Substring(ultimaComa + 1)}";
                }
                else
                {
                    resultado += $"es {caracteristicas.TrimEnd(',')}";
                }

                resultado += ".";
            }
            else
            {
                resultado += "y.";
            }

            entryResultado.Text = resultado;

        }

    }
    
}
