using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProRenamer {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load( object sender, EventArgs e ) {
            this.MinimumSize = this.Size;
        }

        private void tsbAddFile_Click( object sender, EventArgs e ) {
            OpenFileDialog ofd = new OpenFileDialog() {
                Multiselect = true,
                Filter = "Audio Files|*.mp3;*.wav;*.amr|Office Files|*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx|Text Files|*.txt;*.csv|Video Files|*.avi;*.mkv;*.mp4;*.mov|All files (*.*)|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK) {
                List<string> files = new List<string>();
                foreach (string file in ofd.FileNames) {
                    if (File.Exists( file )) {
                        files.Add( file );
                    }
                }

                if (files.Count > 0) {
                    addFiles( files );
                }
            }
        }

        private void tsbAddFolder_Click( object sender, EventArgs e ) {
            FolderBrowserDialog fbd = new FolderBrowserDialog() {
                ShowNewFolderButton = false
            };

            if (fbd.ShowDialog() == DialogResult.OK) {
                List<string> files = new List<string>();

                string[] folder_content = Directory.GetFiles( fbd.SelectedPath, "*.*", SearchOption.AllDirectories );
                foreach (string file in folder_content) {
                    files.Add( file );
                }

                if (files.Count > 0) {
                    addFiles( files );
                }
            }
        }

        private void tsbDeleteFile_Click( object sender, EventArgs e ) {
            foreach (ListViewItem item in lvFiles.SelectedItems) {
                lvFiles.Items.Remove( item );
            }
        }

        private void tsbDeleteAll_Click( object sender, EventArgs e ) {
            lvFiles.Items.Clear();
        }

        private bool addFiles( List<string> files ) {
            foreach (string file in files) {
                FileInfo info = new FileInfo( file );
                if( info.Extension == ".amr" ) {

                }


                lvFiles.Items.Add( new ListViewItem( new string[] {
                    info.Directory.ToString(),
                    info.Name,
                    file,
                    info.Extension,
                    "",
                    MyLibrary.coolSize( info.Length ).ToString(),
                    info.CreationTime.ToString( "yyyy.MM.dd HH:ss" ),
                    info.LastWriteTime.ToString( "yyyy.MM.dd HH:ss" )
                } ) );                
            }

            return true;
        }

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData ) {
            if( keyData == Keys.F2 ) {
                tsbAddFile_Click(null, null);

                return true;
            } else if(keyData == Keys.F3 ) {
                tsbAddFolder_Click( null, null );

                return true;
            } else if (keyData == Keys.F6) {
                tsbDeleteFile_Click( null, null );

                return true;
            } else if (keyData == Keys.F7) {
                tsbDeleteAll_Click( null, null );

                return true;
            }

            return base.ProcessCmdKey( ref msg, keyData );
        }
    }

    public static class MyLibrary {
        private static readonly string[] filesizename = { " Bytes", " KB", " MB", " GB", " TB", " PB", " EB", " ZB", " YB" };

        public static string coolSize(long size) {
            if( size == 0 ) {
                return "";
            }

            int i = (int)Math.Floor( (double)Math.Log(size, 1024 ) );

            return Math.Round(size / Math.Pow( 1024, i ), 2) + filesizename[ i ];
        }
    }
}
