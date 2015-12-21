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
        private iTunesApp iTunes = new iTunesApp();
        private bool isSync = false;

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
            IITTrack track = (IITTrack)iTrack;
            BeginInvoke((MethodInvoker)delegate
            {
                //曲名とか設定 
                if (track != null && track.Enabled)
                {
                    currentTxt.Text = string.Format("\"{0}\" - {1} by {2}", track.Name, track.Album, track.Artist);
                    lyricTxt.Text = ((IITFileOrCDTrack)track).Lyrics;
                }
            });        
        }


        private void syncBtn_Click(object sender, EventArgs e)
        {
            if(isSync)
            {
                iTunes.OnPlayerPlayEvent -= new _IiTunesEvents_OnPlayerPlayEventEventHandler(iTunesApp_OnPlayerPlayEvent);
                syncBtn.Text = "Sync";
                isSync = false;
            }
            else
            {
                iTunes.OnPlayerPlayEvent += new _IiTunesEvents_OnPlayerPlayEventEventHandler(iTunesApp_OnPlayerPlayEvent);
                syncBtn.Text = "Async";
                isSync = true;
            }
        }

    }
}
