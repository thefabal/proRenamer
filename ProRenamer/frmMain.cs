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

            pnlFiles.BringToFront();
            tsbFiles.BackColor = SystemColors.Highlight;
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
            FileInfo file_info;
            double audio_duration = -1;
            string audio_artist = string.Empty;
            string audio_title = string.Empty;

            foreach (string file in files) {
                file_info = new FileInfo( file );

                if( getAudioInfo( file_info.FullName, file_info.Length, ref audio_duration, ref audio_artist, ref audio_title ) == false ) {
                    audio_duration = -1;
                    audio_artist = string.Empty;
                    audio_title = string.Empty;
                }

                lvFiles.Items.Add( new ListViewItem( new string[] {
                    file_info.Directory.ToString(),
                    file_info.Name,
                    file,
                    file_info.Extension,
                    "",
                    MyLibrary.coolFileSize( file_info.Length ).ToString(),
                    file_info.CreationTime.ToString( "yyyy.MM.dd HH:ss" ),
                    file_info.LastWriteTime.ToString( "yyyy.MM.dd HH:ss" ),
                    MyLibrary.coolDuration( audio_duration ),
                    audio_artist,
                    audio_title
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

        private void tsbFiles_Click( object sender, EventArgs e ) {
            pnlFiles.BringToFront();
            tsbCheckState( sender );
        }

        private void tsbAction_Click( object sender, EventArgs e ) {
            pnlAction.BringToFront();
            if( lbAction.SelectedIndex == -1 ) {
                lbAction.SelectedIndex = 0;
                pnlActionExtension.BringToFront();
            }
            tsbCheckState( sender );
        }

        private void tsbLog_Click( object sender, EventArgs e ) {
            pnlLog.BringToFront();
            tsbCheckState( sender );
        }

        private void tsbCheckState( object sender ) {
            foreach( ToolStripItem item in toolStrip2.Items ) {
                if( item.Name == ( (ToolStripButton)sender ).Name ) {
                    item.BackColor = SystemColors.Highlight;
                } else {
                    item.BackColor = SystemColors.Control;
                }
            }
        }

        private void btnPreview_Click( object sender, EventArgs e ) {
            for(int i = 0; i < lvFiles.Items.Count; i++ ) {
                lvFiles.Items[ i ].SubItems[ 4 ].Text = getNewFileName( lvFiles.Items[ i ].SubItems[ 2 ].Text );
            }

            tsbFiles_Click( (object)tsbFiles, null );
        }

        private string getNewFileName( string full_name ) {
            string file_name = Path.GetFileNameWithoutExtension( full_name );
            string file_ext = Path.GetExtension( full_name );

            switch( lbAction.SelectedIndex ) {
                case 0:
                    if( cbNewExtensionAppend.Checked ) {
                        file_name = file_name + file_ext + "." + tbActionExtension.Text;
                    } else {
                        file_name = file_name + "." + tbActionExtension.Text;
                    }
                    break;

                case 1:
                    string insert = string.Empty;

                    if( cbActionInsert.SelectedIndex == -1 ) {
                        insert = cbActionInsert.Text;
                    } else if( cbActionInsert.SelectedIndex == 0 ) {
                        double audio_duration = -1;
                        string audio_artist = string.Empty;
                        string audio_title = string.Empty;

                        if( getAudioInfo( full_name, (new FileInfo(full_name)).Length, ref audio_duration, ref audio_artist, ref audio_title ) ) {
                            insert = ( TimeSpan.FromSeconds( audio_duration ) ).ToString( @"hh\.mm\.ss" );
                        }
                    }

                    if( rbActionInsertFromBegin.Checked ) {
                        if( nudActionInsertPosition.Value == 0 ) {
                            file_name = insert + file_name + file_ext;
                        } else if( nudActionInsertPosition.Value > file_name.Length ) {
                            file_name += insert + file_ext;
                        } else {
                            file_name = file_name.Substring( 0, Convert.ToInt32( nudActionInsertPosition.Value ) ) + insert + file_name.Substring( Convert.ToInt32( nudActionInsertPosition.Value ) + 1 ) + file_ext;
                        }
                    } else {
                        if( nudActionInsertPosition.Value == 0 ) {
                            file_name += insert + file_ext;
                        } else if( nudActionInsertPosition.Value > file_name.Length ) {
                            file_name = insert + file_name + file_ext;
                        } else {
                            file_name = file_name.Substring( 0, file_name.Length - Convert.ToInt32( nudActionInsertPosition.Value ) ) + insert + file_name.Substring( file_name.Length - Convert.ToInt32( nudActionInsertPosition.Value ) + 1 ) + file_ext;
                        }
                    }
                    break;
            }

            return file_name;
        }

        private bool getAudioInfo( string file_name, long file_size, ref double audio_duration, ref string audio_artist, ref string audio_title ) {
            int[ ] sizes = new int[ ] { 12, 13, 15, 17, 19, 20, 26, 31, 5, 6, 5, 5, 0, 0, 0, 0 };

            StreamReader sr = new StreamReader( file_name );
            int n = fread( out byte[ ] header, 1, 6, sr );
            if( n == 6 && Encoding.UTF8.GetString( header ) == "#!AMR\n" ) {
                fread( out byte[ ] x, 1, 1, sr );
                fread( out byte[ ] y, 1, sizes[ ( x[ 0 ] >> 3 ) & 0x0f ], sr );

                header = new byte[ x.Length + y.Length ];
                x.CopyTo( header, 0 );
                y.CopyTo( header, x.Length );

                double bit_rate = 0;
                switch( BitConverter.GetBytes( ( header[ 0 ] >> 3 ) & 0x0f )[ 0 ] ) {
                    case 0: bit_rate = 4.75; break;
                    case 1: bit_rate = 5.15; break;
                    case 2: bit_rate = 5.9; break;
                    case 3: bit_rate = 6.7; break;
                    case 4: bit_rate = 7.4; break;
                    case 5: bit_rate = 7.95; break;
                    case 6: bit_rate = 10.2; break;
                    case 7: bit_rate = 12.2; break;
                    default: return false;
                }

                audio_duration = Math.Round( ( file_size - ( 6 + header.Length ) ) / ( bit_rate * 1024 ) * 8, 3 );

                return true;
            } else {
                try {
                    TagLib.File tfile = TagLib.File.Create( file_name );

                    audio_duration = tfile.Properties.Duration.TotalSeconds;
                    audio_artist = tfile.Tag.AlbumArtists[ 0 ];
                    audio_title = tfile.Tag.Title;

                    return true;
                } catch {
                    return false;
                }
            }
        }

        private static int fread( out byte[ ] header, int pos_str, int char_to_read, StreamReader sr ) {
            int i;
            for( i = 1; i < pos_str; i++ ) {
                sr.Read();
            }

            header = new byte[ char_to_read ];
            for( i = 0; i < char_to_read; i++ ) {
                header[ i ] = BitConverter.GetBytes( sr.Read() )[ 0 ];
            }

            return i;
        }

        private static T[ ] SubArray<T>( T[ ] data, int index, int length ) {
            T[ ] result = new T[ length ];
            Array.Copy( data, index, result, 0, length );
            return result;
        }

        private void lbAction_SelectedIndexChanged( object sender, EventArgs e ) {
            switch( ( (ListBox)sender ).SelectedIndex ) {
                case 0: pnlActionExtension.BringToFront(); break;
                case 1: pnlActionInsert.BringToFront(); break;
            }
        }
    }

    public static class MyLibrary {
        private static readonly string[] filesizename = { " Bytes", " KB", " MB", " GB", " TB", " PB", " EB", " ZB", " YB" };

        public static string coolFileSize(long size) {
            if( size == 0 ) {
                return "";
            }

            int i = (int)Math.Floor( (double)Math.Log(size, 1024 ) );

            return Math.Round(size / Math.Pow( 1024, i ), 2) + filesizename[ i ];
        }

        public static string coolDuration( double size ) {
            return (size != -1) ? ( TimeSpan.FromSeconds( size ) ).ToString( @"hh\:mm\:ss" ) : ("");
        }
    }
}
