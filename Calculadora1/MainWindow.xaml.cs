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

namespace Calculadora1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtCalcular_Click(object sender, RoutedEventArgs e)
        {
            
            //Circunferencia
            if ((bool)rbCircunferencia.IsChecked)
            {
                try
                {
                    MessageBox.Show("Circunferencia regresa la circunferencia de un círculo dado su radio");
                    double radio, resp;
                    radio = Convert.ToDouble(tbRadio.Text);
                    resp = radio * 2 * Math.PI;
                    tbResultado.Text = Convert.ToString(resp);
                }
                catch (FormatException)
                {
                    tbResultado.Text = "Error. No hay Datos";
                }
            }

            else
            {
                //Área de un Círculo
                if ((bool)rbAreaCirculo.IsChecked)
                {
                    try
                    {
                        MessageBox.Show("Área Círculo regresa el área de un círculo dado su radio");
                        double radio, resp;
                        radio = Convert.ToDouble(tbRadio.Text);
                        resp = radio * radio * Math.PI;
                        tbResultado.Text = Convert.ToString(resp);
                    }
                    catch (FormatException)
                    {
                        tbResultado.Text = "Error. No hay Datos";
                    }
                }
                else
                {
                    //Perimetro de un Cuadrilátero
                    if ((bool)rbPerimetroCuadrilatero.IsChecked)
                    {
                        try
                        {
                            MessageBox.Show("Perimetro Cuadrilátero regresa el perímetro de un cuadrilátero dadas sus proporciones");
                            double b, a, resp;
                            b = Convert.ToDouble(tbBase.Text);
                            a = Convert.ToDouble(tbAltura.Text);
                            resp = (a + b) * 2;
                            tbResultado.Text = Convert.ToString(resp);
                        }
                        catch (FormatException)
                        {
                            tbResultado.Text = "Error. No hay Datos";
                        }
                    }
                    else
                    {
                        //Área de un Cuadrilátero
                        if ((bool)rbAreaCuadrilatero.IsChecked)
                        {
                            try
                            {
                                MessageBox.Show("Área Cuadrilátero regresa el área de un cuadrilátero dadas sus proporciones");
                                double b, a, resp;
                                b = Convert.ToDouble(tbBase.Text);
                                a = Convert.ToDouble(tbAltura.Text);
                                resp = a * b;
                                tbResultado.Text = Convert.ToString(resp);
                            }
                            catch (FormatException)
                            {
                                tbResultado.Text = "Error. No hay Datos";
                            }
                        }
                        else
                        {
                            //Área de un Triángulo
                            if ((bool)rbAreaTriangulo.IsChecked)
                            {
                                try
                                {
                                    MessageBox.Show("Área Triángulo regresa el área de un triángulo dadas sus proporciones");
                                    double b, a, resp;
                                    b = Convert.ToDouble(tbBase.Text);
                                    a = Convert.ToDouble(tbAltura.Text);
                                    resp = a * b / 2;
                                    tbResultado.Text = Convert.ToString(resp);
                                }
                                catch (FormatException)
                                {
                                    tbResultado.Text = "Error. No hay Datos";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void RbCircunferencia_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RbAreaCirculo_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RbPerimetroCuadrilatero_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RbAreaCuadrilatero_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RbAreaTriangulo_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
