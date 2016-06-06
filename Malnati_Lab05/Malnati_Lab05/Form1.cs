using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malnati_Lab05
{
    public partial class Form1 : Form
    {
        DataManager dataManager;
        GMapOverlay markersOverlay;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Torino, Piemonte");
            gmap.Zoom = 10;
            dataManager = new DataManager("immobili.csv");
        }

        private void buttonCerca_Click(object sender, EventArgs e)
        {
            
            string indirizzo = textBoxIndirizzo.Text;
            string contratto = "";
            if (radioButtonContrattoAffitto.Checked)
            {
                contratto = "affitto";
            }
            else if (radioButtonContrattoVendita.Checked)
            {
                contratto = "vendita";
            }
            string tipologia = "";
            int prezzo = 0;
            int.TryParse(textBoxPrezzo.Text, out prezzo);
            int superficieMinima = 0;
            int.TryParse(textBoxSuperficieMinima.Text, out superficieMinima);
            int piano = 0;

            markersOverlay = new GMapOverlay("markers");


            dataManager.filter(indirizzo, contratto, tipologia, prezzo, superficieMinima, piano).ForEach(immobile =>
            {
                gmap.SetPositionByKeywords(immobile.Indirizzo);
                // TODO should find a way to add a marker from address
                //string s = immobile.Indirizzo;
                GMarkerGoogle marker = new GMarkerGoogle(gmap.Position, GMarkerGoogleType.green);
                markersOverlay.Markers.Add(marker);
            });
            gmap.Overlays.Add(markersOverlay);

            gmap.SetPositionByKeywords(textBoxIndirizzo.Text);
        }
    }
}
