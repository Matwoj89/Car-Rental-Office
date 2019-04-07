using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wypozyczalnia.Widok.Formatki
{
    public partial class Okno3 : Form
    {
        static Okno3 okienko;

        public Okno3()
        {
            InitializeComponent();
        }

        public static Okno3 pobierzInstancjeOkna()
        {
            if (okienko == null || okienko.IsDisposed) okienko = new Okno3();

            return okienko;
        }
    }
}
