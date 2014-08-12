using System;
using System.Collections.Generic;
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
        private int _horizResolution;
        private int _vertResolution;
        private bool _imageReady;
        private bool _charactersReady;
        private Bitmap _inputBitmap;

        public Generator()
        {
            //
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
    }
}
