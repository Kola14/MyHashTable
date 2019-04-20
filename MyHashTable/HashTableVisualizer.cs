using System.Drawing;

namespace MyHashTable
{
    class HashTableVisualizer
    {
        private HashTable table;
        private Graphics graphics;

        private int panelWidth;
        private int panelHeight;

        public HashTableVisualizer(HashTable table, Graphics graphics, int panelWidth, int panelHeight)
        {
            this.table = table;
            this.graphics = graphics;
            this.panelWidth = panelWidth;
            this.panelHeight = panelHeight;
        }

        public void Draw()
        {
            int maxLength = 0;

            for (int i = 0; i < 256; i++)
            {
                if (maxLength < table.Table[i].Count)
                {
                    maxLength = table.Table[i].Count;
                }
            }

            int blockWidth = panelWidth / maxLength;
            int blockHeight = panelHeight / 256;

            for (int i = 0; i < 256; i++)
            {
                graphics.FillRectangle(Brushes.Black, 0, (blockHeight) * i, blockWidth * table.Table[i].Count, blockHeight);
            }
        }
    }
}
