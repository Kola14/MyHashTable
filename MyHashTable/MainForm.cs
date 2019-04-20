using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHashTable
{
    public partial class MainForm : Form
    {
        HashTable hashTable;


        Bitmap bitmap;

        int panelWidth;
        int panelHeight;

        public MainForm()
        {
            InitializeComponent();

            rbSimpleHash.Select();

            panelHeight = pnlResult.Height;
            panelWidth = pnlResult.Width;

            bitmap = new Bitmap(panelWidth, panelHeight);
        }

        private void pnlResult_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
            base.OnPaint(e);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            hashTable = new HashTable();

            if (rbSimpleHash.Checked)
            {
                hashTable.HashType = HashTable.hashFunctionType.Standart;
            }

            if (rbParametersHash.Checked)
            {
                hashTable.HashType = HashTable.hashFunctionType.WithParameters;

                hashTable.A = (int)nudA.Value;
                hashTable.B = (int)nudB.Value;
                hashTable.C = (int)nudC.Value;
            }

            hashTable.LoadFromFile();

            RefreshGraphics();
            Refresh();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int number = (int)nudPhoneNumber.Value;

            Subscriber sub = hashTable.Find(number);

            if (sub != null)
            {
                tbFoundSubsciber.Text = sub.Name + " " + sub.Adress;
            }
        }

        private void RefreshGraphics()
        {
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, panelWidth, panelHeight);

                HashTableVisualizer visualizer = new HashTableVisualizer(hashTable, graphics, panelWidth, panelHeight);

                visualizer.Draw();
            }
        }
    }
}
