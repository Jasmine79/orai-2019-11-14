using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filter = "Minden fájl (*.*)|*.*|Szövegfájl (*.txt)|" +
            "*.txt|Struktúrált szövegfájl (*.xml)|*.xml";
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker_Szuletesi_Datum.MaxDate = DateTime.Today.
                AddYears(-18);
            dateTimePicker_Szuletesi_Datum.MinDate = DateTime.Today.
                AddYears(-150);
            dateTimePicker_Szuletesi_Datum.Value = DateTime.Today.
                AddYears(-35);
            this.AcceptButton = button_Hozzaad;
        }

        private void Csak_betuket_enged(object sender, EventArgs e)
        {
            Textbox_nev.Text = string.Concat(Textbox_nev.Text.
                Where(c => char.IsLetter(c)||char.IsWhiteSpace(c)||
                c.Equals('.')));
            Textbox_nev.SelectionStart = Textbox_nev.Text.Length + 1;
        }
    }
}
