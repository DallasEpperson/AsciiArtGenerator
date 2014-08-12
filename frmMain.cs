using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiArtGenerator
{
    public partial class frmMain : Form
    {
        private Generator _generator;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblFontName.Text = "";
            lblFontSize.Text = "";
            lblFontWeight.Text = "";
            fontDialog1.FixedPitchOnly = true;
            //TODO set openFileDialog file extension filter thing

            _generator = new Generator();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!_generator.IsReady)
            {
                //How'd you get here?
                return;
            }

            try
            {
                var output = _generator.Generate();
                System.IO.File.WriteAllText(@"output.txt", output);
                //TODO create a save file dialog
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void tmrGuiUpdate_Tick(object sender, EventArgs e)
        {
            btnGenerate.Enabled = (_generator.IsReady);

            //TODO replace stupid yellow/green squares with actual icons
            picPreparedImage.BackColor = (_generator.ImageIsReady) ? Color.Green : Color.Yellow;
            picPreparedChars.BackColor = (_generator.CharactersReady) ? Color.Green : Color.Yellow;
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            //TODO ensure a monospace font was chosen
            // - even though .FixedPitchOnly is set, user can still 'cancel' which picks a default, often non monospaced font

            lblFontName.Text = fontDialog1.Font.Name;
            lblFontSize.Text = fontDialog1.Font.SizeInPoints.ToString();
            lblFontWeight.Text = ((fontDialog1.Font.Bold ? "Bold" : "") +
                (fontDialog1.Font.Italic ? " Italic" : "")).Trim();
            if (lblFontWeight.Text == string.Empty)
                lblFontWeight.Text = "Normal";

            _generator.ChooseFont(fontDialog1.Font);
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //TODO did the user even pick anything?
            // - temporarily assuming they did

            try
            {
                var tempImage = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                tempImage = tempImage.ConvertToGrayscale();
                _generator.SetImage(tempImage);
                picInput.Image = tempImage;
            }
            catch
            {
                MessageBox.Show("Could not open image!");
            }
        }

    }
}
