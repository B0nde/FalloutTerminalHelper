using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalloutTerminalHelper
{
    public class Helper
    {
        private const float FONT_SIZE = 12f;
        private static readonly Brush NO_MATCH = new SolidBrush(Color.Black);
        private static readonly Brush MATCH = new SolidBrush(Color.Red);
        private static readonly Font FONT = new Font("Times New Roman", FONT_SIZE);

        private List<Entry> entries;
        private Graphics graphics;

        public Helper(Graphics graphics)
        {
            this.graphics = graphics;

            entries = new List<Entry>();
            Draw();
        }

        public void Draw()
        {
            graphics.Clear(Color.Beige);

            for (int i = 0; i < entries.Count; i++)
            {
                var entry = entries[i];

                for(int j = 0; j < entry.Word.Length; j++)
                    graphics.DrawString("" + entry.Word[j], FONT, !entry.Fits.Contains(j) ? MATCH : NO_MATCH, j * FONT_SIZE, i * FONT_SIZE);
            }
        }

        private void FillFits(string word)
        {
            if (entries.Count == 0)
                return;

            foreach (var entry in entries)
            {
                entry.Fits.Clear();

                for (int i = 0; i < entry.Word.Length; i++)
                {
                    if (entry.Word.Length < word.Length)
                        continue;

                    if (word[i] == entry.Word[i])
                        entry.Fits.Add(i);
                }
            }
        }

        public bool Fits(string word)
        {
            if (entries.Count == 0)
                return true;

            FillFits(word);

            foreach (var entry in entries)
            {
                var matches = 0;

                for (int i = 0; i < entry.Word.Length; i++)
                {
                    if (entry.Word.Length < word.Length)
                        return false;

                    if (word.ToLower()[i] == entry.Word.ToLower()[i])
                        matches++;

                    if (matches > entry.NumRight)
                        return false;
                }

                if (matches != entry.NumRight)
                    return false;
            }

            return true;
        }

        public void AddEntry(Entry e)
        {
            entries.Add(e);
        }
    }
}
