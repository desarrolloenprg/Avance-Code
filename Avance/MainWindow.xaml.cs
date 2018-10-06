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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Interop;
using Avance;


namespace Avance
{
    [Flags]
    public enum LevelAdvance
    {
        Completed,
        CompletedPair,
        Passed,
        PassedPair,
        Attempted,
        AttemptedPair,
        NotTried,
        NotAssigned
    }

        /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            resultado.Text = "NOTHING";
            using (StreamReader reader = new StreamReader(@"C:\temp\html.html"))
            {
                String line = String.Empty;
                //using (StreamReader sr = new StreamReader(path))
                while ((line = reader.ReadToEnd()) != null)
                {
                    Console.WriteLine(line);
                    Analizador analizador = new Analizador(line);
                    Dictionary<string, Persona> alumnos;
                    alumnos = analizador.BuscaNombres(seccion.Text);
                    analizador.ConstruyeAvance(alumnos);

                    CreaCsv csv = new CreaCsv(seccion.Text);
                    csv.CreaFileCsv(analizador.grupo);
                    break;
                }
                resultado.Text = "ök";  
            }

        }
    }


}
