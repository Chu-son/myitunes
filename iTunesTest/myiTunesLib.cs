using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTunesLib;
using System.Runtime.InteropServices;

/*
 *参考
 *Windows版のiTunesで現在聴いてる曲の情報を取得する(C#編)
 * http://d.hatena.ne.jp/IIJIMAS/20101107/1289136381
 *iTunesの歌詞に歌詞を追加
 * http://qiita.com/maple0705/items/b322b9d1bb39876ea65f
 *iTunesLibで遊ぶ in C#
 * http://zecl.hatenablog.com/entry/20081019/p1
 */


namespace iTunesTest
{
    class MyiTunesLib
    {
        public event _IiTunesEvents_OnPlayerPlayEventEventHandler OnPlayerPlayEvent;

        private iTunesApp iTunes = new iTunesApp();
        private Form _w;

        public MyiTunesLib(Form w)
        {
            _w = w;
            iTunes.OnPlayerPlayEvent += new _IiTunesEvents_OnPlayerPlayEventEventHandler(iTunesApp_OnPlayerPlayEvent);
        }

        private void iTunesApp_OnPlayerPlayEvent(object iTrack)
        {
            _w.Invoke(OnPlayerPlayEvent, new object[] { iTrack });
        }

        public static string GetCurrentMusic()
        {
            string text = "";
            iTunesApp app = new iTunesLib.iTunesApp();
            IITTrack track = app.CurrentTrack;
            if (track != null && track.Enabled)
            {
                text = string.Format("{0} - {1} by {2}", track.Name, track.Album, track.Artist);
            }
            Marshal.ReleaseComObject(app);
            return text;
        }
        public static string GetCurrentMusicLyrics()
        {
            string text = "";
            iTunesApp app = new iTunesLib.iTunesApp();
            IITTrack track = app.CurrentTrack;
            if (track != null && track.Enabled)
            {
                text = ((IITFileOrCDTrack)track).Lyrics;
            }
            Marshal.ReleaseComObject(app);
            return text;
        }
    }
}
