using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTunesLib;

namespace iTunesTest
{
    public partial class iTunesForm : Form
    {
        public iTunesForm()
        {
            InitializeComponent();
        }

        private void nowBtn_Click(object sender, EventArgs e)
        {
            currentTxt.Text = MyiTunesLib.GetCurrentMusic();
            lyricTxt.Text = MyiTunesLib.GetCurrentMusicLyrics();
        }

        private void iTunesApp_OnPlayerPlayEvent(object iTrack)
        {
            //曲名とか設定
            currentTxt.Text = MyiTunesLib.GetCurrentMusic();
            lyricTxt.Text = MyiTunesLib.GetCurrentMusicLyrics();

            //アートワークの設定
            //SetArtWork(track);

            
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {
            MyiTunesLib myiTunes = new MyiTunesLib(this);
        }
    }
}
