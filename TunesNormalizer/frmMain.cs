using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TunesNormalizer
{
    public partial class frmMain : Form
    {
        #region Constants

        private const int COUNT_SENTINEL = -1;
        private readonly char[] INVALID_FILE_CHARS = Path.GetInvalidFileNameChars();
        private readonly char[] INVALID_PATH_CHARS = Path.GetInvalidPathChars();

        #endregion

        #region Data Members

        private int _iTotalSongs, _iNormalizedSongs;
        private Thread _threadNormalizer;

        #endregion

        #region Construction

        public frmMain()
        {
            InitializeComponent();

            _iTotalSongs = COUNT_SENTINEL;
            _threadNormalizer = new Thread(new ThreadStart(OnThreadNormalize));
        }

        #endregion

        #region Event Handling

        private void buttonSelectDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    this.textTunesDirectory.Text = fbd.SelectedPath;
            }
        }

        private void buttonBeginNormalization_Click(object sender, EventArgs e)
        {
            if (_threadNormalizer != null && _threadNormalizer.IsAlive)
                _threadNormalizer.Abort();

            _threadNormalizer = new Thread(new ThreadStart(OnThreadNormalize));
            _threadNormalizer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_iTotalSongs == COUNT_SENTINEL)
                this.labelProgress.Visible = false;
            else
            {
                this.labelProgress.Visible = true;
                this.labelProgress.Text = String.Format("{0} / {1} Songs Normalized", _iNormalizedSongs, _iTotalSongs);
            }
        }

        private void textTunesDirectory_TextChanged(object sender, EventArgs e)
        {
            this.buttonBeginNormalization.Enabled = Directory.Exists(this.textTunesDirectory.Text);
        }

        #endregion

        #region Helper Methods

        protected virtual void OnThreadNormalize ()
        {
            string sDirectory = this.textTunesDirectory.Text;
            string sNormalizedDirectory = sDirectory + "\\NormalizedTunes";

            // Begin by making a "Normalized" folder within the selected directory.
            GenerateDirectory(sNormalizedDirectory);

            // Next, retrieve the number of MP3 files to normalize.
            string[] mp3Files = Directory.GetFiles(sDirectory, "*.mp3");
            _iTotalSongs = mp3Files.Length;
            _iNormalizedSongs = 0;

            // Finally, iterate through the list and apply normalization.
            foreach (var sOriginalFile in mp3Files)
            {
                var tagFile = TagLib.File.Create(sOriginalFile);
                uint iTrack = tagFile.Tag.Track;
                string sTitle = SanitizeFile (String.Format("[{0}] - {1}", iTrack.ToString ("00"), tagFile.Tag.Title)).Trim ();
                string sArtist = tagFile.Tag.AlbumArtists.Length > 0 ? tagFile.Tag.AlbumArtists [0].Trim () : "Unknown Artist";
                string sAlbum = string.IsNullOrEmpty(tagFile.Tag.Album) ? "Unknown Album" : tagFile.Tag.Album.Trim();
                string sNormalizedPath = SanitizePath(sNormalizedDirectory + "\\" + sArtist + "\\" + sAlbum);

                sTitle = GenerateDirectory(sNormalizedPath) ?
                    sNormalizedPath + "\\" + sTitle :
                    sNormalizedDirectory + "\\" + Path.GetFileName(sOriginalFile);

                if (!sTitle.EndsWith(".mp3"))
                    sTitle += ".mp3";

                if (!File.Exists (sTitle))
                    File.Copy(sOriginalFile, sTitle);
                _iNormalizedSongs++;
            }
        }

        protected virtual bool GenerateDirectory (string sDirectory)
        {
            try
            {
                if (!Directory.Exists(sDirectory))
                    Directory.CreateDirectory(sDirectory);
            }
            catch (Exception)
            {
               return false;
            }

            return true;
        }

        protected virtual string SanitizeFile (string sTitle)
        {
            foreach (var invalidChar in INVALID_FILE_CHARS)
                sTitle = sTitle.Replace(invalidChar, '_');

            return sTitle;
        }

        protected virtual string SanitizePath (string sPath)
        {
            foreach (var invalidChar in INVALID_PATH_CHARS)
                sPath = sPath.Replace(invalidChar, '_');

            return sPath;
        }

        #endregion
    }
}
