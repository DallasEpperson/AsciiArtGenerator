using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiArtGenerator
{
    public class Generator
    {
        private Font _chosenFont;
        private bool _fontIsDirty;
        private List<CharacterDarknessMap> _characterDarknessMaps;
        private int _textColumns;
        private int _textRows;
        private int _horizResolution;
        private int _vertResolution;
        private bool _imageReady;
        private bool _charactersReady;
        private Bitmap _inputBitmap;
        private List<char> _characterPool;

        public Generator()
        {
            _characterPool = generateCharacterPool();
        }

        public Generator(List<char> characterPool)
        {
            _characterPool = characterPool;
        }

        public bool IsReady{
            get { return _imageReady && _charactersReady; }
        }

        public bool ImageIsReady
        {
            get { return _imageReady; }
        }

        public void ChooseFont(Font chosenFont)
        {
            _chosenFont = new Font(chosenFont.FontFamily, 72);
            _fontIsDirty = true;
            //TODO generate character darkness maps
        }

        public void SetImage(Bitmap incomingBitmap)
        {
            //TODO some form of error checking
            _inputBitmap = incomingBitmap;
            _imageReady = true;
        }

        private List<char> generateCharacterPool()
        {
            var ret = new List<char>();

            //TODO Generate default character list intelligently
            // - this is just standard ASCII. We can do more.
            for (int i = 32; i < 127; i++)
            {
                ret.Add((char)i);
            }

            return ret;
        }

        public String Generate()
        {
            if (!IsReady)
            {
                throw new Exception("ASCII Art Generator is not ready!");
                //TODO Seriously? That error message sucks.
            }

            string ret = "";

            int sectionWidth = _inputBitmap.Width / _textColumns;
            int sectionHeight = _inputBitmap.Height / _textRows;

            Bitmap section = new Bitmap(sectionWidth, sectionHeight);
            Rectangle sectionFullRect = new Rectangle(0, 0, sectionWidth, sectionHeight);
            Graphics g = Graphics.FromImage(section);

            for (int y = 0; y < _textRows; y++)
            {
                for (int x = 0; x < _textColumns; x++)
                {
                    Debug.WriteLine("Analyzing input image section " + x + "," + y);
                    Rectangle sourceRect = new Rectangle(x * sectionWidth, y * sectionHeight, sectionWidth, sectionHeight);
                    g.DrawImage(_inputBitmap, sectionFullRect, sourceRect, GraphicsUnit.Pixel);
                    g.Flush();
                    ret += getBestCharForSection(section);
                }
                ret += "\r\n";
            }
            g.Dispose();
            return ret;
        }

        private char getBestCharForSection(Bitmap section)
        {
            char ret = new char();
            Bitmap quadrant = new Bitmap(section.Width / _horizResolution, section.Height / _vertResolution);
            Rectangle fullQuadrant = new Rectangle(0, 0, quadrant.Width, quadrant.Height);
            Graphics g = Graphics.FromImage(quadrant);
            byte[] sectionDarknessMap = new byte[_horizResolution * _vertResolution];
            int d = 0;
            Debug.Write("Darkness map:");
            for (int y = 0; y < _vertResolution; y++)
            {
                for (int x = 0; x < _horizResolution; x++)
                {
                    Rectangle srcRect = new Rectangle((section.Width * x) / _horizResolution, (section.Height * y) / _vertResolution, quadrant.Width, quadrant.Height);
                    g.FillRectangle(Brushes.White, fullQuadrant);
                    g.DrawImage(section, fullQuadrant, srcRect, GraphicsUnit.Pixel);
                    g.Flush();
                    sectionDarknessMap[d] = quadrant.GetDarkness();
                    Debug.Write(" " + sectionDarknessMap[d]);
                    d++;
                }
            }
            Debug.WriteLine("");

            Debug.Write("Closest character - '");

            char leastWrong = ' ';
            int leastWrongness = int.MaxValue;
            foreach (var charDarknessMap in _characterDarknessMaps)
            {
                var thisWrongness = mapWrongness(sectionDarknessMap, charDarknessMap.Darknesses);
                if (thisWrongness < leastWrongness)
                {
                    leastWrong = charDarknessMap.Character;
                    leastWrongness = thisWrongness;
                }
            }

            ret = leastWrong;

            Debug.WriteLine(ret + "'");
            return ret;
        }

        private int mapWrongness(byte[] map1, byte[] map2)
        {
            if (map1.Length != map2.Length)
                throw new ArgumentException("Byte arrays are not the same length!");

            int wrongness = 0;
            for (int i = 0; i < map1.Length; i++)
            {
                wrongness += Math.Abs((int)map1[i] - (int)map2[i]);
            }
            return wrongness;
        }
    }

    public class CharacterDarknessMap
    {
        public Char Character;
        public byte[] Darknesses;
    }

    public static class Helpers
    {
        public static Bitmap ConvertToGrayscale(this Bitmap original)
        {
            // Credit - http://social.msdn.microsoft.com/Forums/sqlserver/en-US/a9f0cda8-9d1d-4236-a737-2e8061180af8/converting-jpg-images?forum=csharpgeneral 
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            Graphics g = Graphics.FromImage(newBitmap);

            ColorMatrix bwColorMatrix = new ColorMatrix(
                new float[][]
                {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0,0,0,1,0},
                    new float[] {0,0,0,0,1},
                });

            ImageAttributes attrs = new ImageAttributes();
            attrs.SetColorMatrix(bwColorMatrix);

            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attrs);
            g.Dispose();
            return newBitmap;
        }

        public static byte GetDarkness(this Bitmap bitmap)
        {
            //TODO this is inefficient

            int cumulativeBrightness = 0;
            int totalPixels = 0;

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    // TODO this assumes grayscale, and therefore only bothers to check red value
                    byte redVal = bitmap.GetPixel(x, y).R;
                    cumulativeBrightness += redVal;
                    totalPixels++;
                }
            }
            return (byte)(255 - ((cumulativeBrightness / totalPixels)));
        }
    }
}
