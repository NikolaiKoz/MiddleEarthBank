using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleEarthBank
{
    public partial class Loan : Form
    {
        string clientName;
        string[] races = { "Hobbit", "Elfo", "Enano", "Humano", "Mago", "Orco", "Ent", "Eladrin" };
        int[] installmentCounts = { 6, 12, 18, 24, 36 };

        public Loan(string name)
        {
            InitializeComponent();
            clientName = name;
        }

    }
}
