using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadedApp
{
    public partial class Form1 : Form
    {

        private ManualResetEvent canGo = new ManualResetEvent(false);       //jelzés, hogy a bicilik mozoghatnak-e
        private AutoResetEvent afterRest = new AutoResetEvent(false);           //pihenéshez jelzés

        delegate void BikeAction(Button bike);          //delegate típus az Invoke függvényhez

        private long pixelCounter = 0;
        private object sync = new object();

        public void increasePixels(long step)
        {
            lock (sync)                 //kölcsönös kizárás
            {
                pixelCounter += step;
            }
        }

        public long getPixels()
        {
            lock (sync)             //kölcsönös kizárás
            {
                return pixelCounter;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        //feldolgozó szál belépési pontja
        public void BikeThreadFunction(object param)
        {

            try                     ////A thread.Interrupt hívás kivételt fog dobni
            {
                Button bike = (Button)param;
                bike.Tag = Thread.CurrentThread;
                while (bike.Left < pStart.Left)        //a startpanelig léptetjük a biciklit
                {

                    MoveBike(bike);
                    Thread.Sleep(100);

                }
                canGo.Reset();      //ha elérte a startot, várakozni kell
                if (canGo.WaitOne())        //ha mehet
                {
                    while (bike.Left < pDepo.Left)        //pihenőig mozog
                    {
                        MoveBike(bike);
                        Thread.Sleep(100);
                    }
                }

                if (afterRest.WaitOne())        //ha step2-re kattintva jelzés érkezik
                {
                    while (bike.Left < pTarget.Left)            //biciklit mozgatja a célig
                    {
                        MoveBike(bike);
                        Thread.Sleep(100);
                    }
                }
            }
            catch (ThreadInterruptedException)
            {
            }


        }

        Random random = new Random();
        public void MoveBike(Button bike)
        {
            if (InvokeRequired)         //ha nem a saját szálán hívjuk meg
            {
                Invoke(new BikeAction(MoveBike), bike);         //akkor megadjuk, hogy a műveletet a saját szálán hajtsa végre
            }
            else
            {
                int temp = random.Next(3, 9);
                bike.Left += temp;     //3 és 9 közötti véletlenszerű számmal mozog
                increasePixels(temp);           //pixelek számát növeljük a lépésben megtett mennyiséggel
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            //bicikllik elindítása
            StartBike(bBike1);
            StartBike(bBike2);
            StartBike(bBike3);
            canGo.Set();            //a biciklik mehetnek
        }

        //szálak futása és a szinkronizációja
        private void StartBike(Button bBike)
        {
            Thread t = new Thread(BikeThreadFunction);      //új szál
            bBike.Tag = t;
            t.IsBackground = true; // Ne blokkolja a szál a processz megszűnését
            t.Start(bBike);
        }

        private void bStep1_Click(object sender, EventArgs e)
        {
            canGo.Set();            //ha a stepre kattint, akkor mehetnek
        }

        private void bStep2_Click(object sender, EventArgs e)
        {
            afterRest.Set();            //ha step2-re kattint, akkor egy bicikli elindulhat a pihenőből
        }

        private void bPixels_Click(object sender, EventArgs e)
        {
            bPixels.Text = getPixels().ToString();
        }

        private void bike_Click(object sender, EventArgs e)
        {
            Button bike = (Button)sender;
            Thread thread = (Thread)bike.Tag; 
            
            // Ha még nem indítottuk ezt a szálat, ez null.
            if (thread == null)
                return;

            // Megszakítjuk a szál várakozását, ez az adott szálban egy
            // ThreadInterruptedException-t fog kiváltani
            thread.Interrupt();
            // Megvárjuk, amíg a szál leáll
            thread.Join();

            bike.Left = 0;                          //pálya elejére állítjuk

        }
    }
}
