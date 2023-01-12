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
using Music_Player;

namespace Music_Player
{
    public partial class FlashMusicPlayer : Form
    {
        public FlashMusicPlayer()
        {
            InitializeComponent();
            TrackBar_sound.Value = 50;
            lbl_sound.Text = "50%";
            
        }
        Music_Player.CircularDoublyLinkedList.CDLinkedList cdll = new CircularDoublyLinkedList.CDLinkedList();
        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                player.URL = cdll.getLocation(Playlist.SelectedIndex);
                player.Ctlcontrols.play();
                try
                {
                    var file = TagLib.File.Create(cdll.getLocation(Playlist.SelectedIndex));
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    pic_art.Image = Image.FromStream(new MemoryStream(bin));

                    text_song_name.Text = Playlist.Items[Playlist.SelectedIndex].ToString();
                }
                catch
                {

                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message,"Error");
            }
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playlist.Items.Count == 0)
                {
                    messagebox.Show("Playlist is empty !! ", "Information");
                }
                else
                {
                    player.Ctlcontrols.stop();
                    ProgressBar_duration.Value = 0;
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playlist.Items.Count == 0)
                {
                    messagebox.Show("Playlist is empty !! ", "Information");
                }
                else
                {
                    player.Ctlcontrols.play();
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playlist.Items.Count == 0)
                {
                    messagebox.Show("Playlist is empty !! ", "Information");
                }
                else
                {
                    player.Ctlcontrols.pause();
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }
        public double cal_time(String song_duration_x)
        {
            int c = 0;
            while (true)
            {
                if (song_duration_x[c].Equals(':'))
                {
                    break;
                }
                c++;
            }
            String song_min = song_duration_x.Substring(0, c);
            String song_sec = song_duration_x.Substring(c + 1, 2);
            double time_tot = Convert.ToDouble(song_min + '.' + song_sec);
            return time_tot;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                ProgressBar_duration.Value = (int)player.Ctlcontrols.currentItem.duration;
                ProgressBar_duration.Value = (int)player.Ctlcontrols.currentPosition;

                try
                {
                    lbl_start.Text = player.Ctlcontrols.currentPositionString;
                    lbl_duration.Text = player.Ctlcontrols.currentItem.durationString.ToString();

                    String song_duration_x = player.Ctlcontrols.currentItem.durationString.ToString();
                    String song_current_duration = player.Ctlcontrols.currentPositionString;

                    double song_time = cal_time(song_duration_x);
                    double current_song_time = cal_time(song_current_duration);

                    if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        if (song_time <= (current_song_time + 0.1) )
                        {
                            btn_next.PerformClick();
                        }
                    }
                }
                catch
                {

                }
                
            }
        }

        private void TrackBar_sound_Scroll(object sender, ScrollEventArgs e)
        {
            player.settings.volume = TrackBar_sound.Value;
            lbl_sound.Text = TrackBar_sound.Value.ToString() + "%";
        }

        private void ProgressBar_duration_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / ProgressBar_duration.Width;
        }

        private void btn_sound_Click(object sender, EventArgs e)
        {
            try
            {
                TrackBar_sound.Value = 0;
                player.settings.volume = TrackBar_sound.Value;
                lbl_sound.Text = "0%";
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void addASongInTheBeginningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] paths, files;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    files = ofd.SafeFileNames;
                    paths = ofd.FileNames;

                    for (int x = 0; x < files.Length; x++)
                    {
                        cdll.insertFirst((files[x]), (paths[x]));
                    }
                    //Playlist.Items.Clear();
                    getData();
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void addASongInTheEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] paths, files;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    files = ofd.SafeFileNames;
                    paths = ofd.FileNames;

                    for (int x = 0; x < files.Length; x++)
                    {
                        cdll.insertLast((files[x]), (paths[x]));
                    }
                    getData();
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playlist.Items.Count == 0)
                {
                    messagebox.Show("Playlist is empty !! ", "Information");
                }
                else
                {
                    ContextMenuStrip_delete.Show(btn_del, 0, btn_add.Height);
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenuStrip_add.Show(btn_add, 0, btn_add.Height);
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }
        public void clearSongsData()
        {
            text_song_name.Text = "";
            lbl_duration.Text = "00:00";
            lbl_start.Text = "00:00";
            player.Ctlcontrols.stop();
            ProgressBar_duration.Value = 0;
        }
        private void deleteASongInTheBeginningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                clearSongsData();
                cdll.deleteFirst();
                getData();
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void deleteASongInTheEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                clearSongsData();
                cdll.deleteLast();
                getData();
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void deleteAllSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                clearSongsData();
                cdll.deleteAllNodes();
                getData();
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        public void getData()
        {
            Playlist.Items.Clear();
            int xx = 0;
            while (true)
            {
                String data = cdll.getSongName(xx);
                if (data.Equals("0"))
                {
                    break;
                }
                else if (data.Equals("-1"))
                {
                    break;
                }
                else
                {
                    Playlist.Items.Add(data);
                }
                xx++;
            }
        }
        public void getData(int song_number)
        {
            Playlist.Items.Clear();
            String data = cdll.getSongName(song_number);
            if (data.Equals("0"))
            {
                MessageBox.Show("No data");
            }
            else if (data.Equals("-1"))
            {
                MessageBox.Show("No data");
            }
            else
            {
                Playlist.Items.Add(data);
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playlist.Items.Count == 0)
                {
                    messagebox.Show("Playlist is empty !! ", "Information");
                }
                else
                {
                    ContextMenuStrip_sort.Show(btn_add, 0, btn_add.Height);
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length >= 1)
                {
                    btn_search.Visible = true;
                }
                else
                {
                    btn_search.Visible = false;
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playlist.Items.Count == 0)
                {
                    messagebox.Show("Playlist is empty !! ", "Information");
                }
                else
                {
                    int index = cdll.getSongIndex(txt_search.Text);
                    if (index == -1)
                    {
                        messagebox.Show("List is empty", "Error");
                    }
                    else if (index == -2)
                    {
                        messagebox.Show("Result not found", "Error");
                    }
                    else
                    {
                        getData(index);
                    }
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void ascendingOrderAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cdll.sort(0);
                getData();
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                txt_search.Clear();
                getData();
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void descendingOrderZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cdll.sort(1);
                getData();
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void FlashMusicPlayer_Load(object sender, EventArgs e)
        {
            btn_search.Visible = false;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playlist.Items.Count == 0)
                {
                    messagebox.Show("Playlist is empty !! ", "Information");
                }
                else
                {
                    int next_index = cdll.getNextIndex(Playlist.SelectedIndex);
                    player.URL = cdll.getLocation(next_index);
                    Playlist.SelectedIndex = next_index;
                    player.Ctlcontrols.play();
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playlist.Items.Count == 0)
                {
                    messagebox.Show("Playlist is empty !! ", "Information");
                }
                else
                {
                    System.Console.WriteLine(cdll.getPreIndex(Playlist.SelectedIndex));
                    int pre_index = cdll.getPreIndex(Playlist.SelectedIndex);
                    player.URL = cdll.getLocation(pre_index);
                    Playlist.SelectedIndex = pre_index;
                    player.Ctlcontrols.play();
                }
            }
            catch (Exception ex)
            {
                messagebox.Show(ex.Message, "Error");
            }
        }
    }
}
