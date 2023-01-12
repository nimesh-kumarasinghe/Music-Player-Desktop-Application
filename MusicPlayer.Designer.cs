
namespace Music_Player
{
    partial class FlashMusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashMusicPlayer));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ProgressBar_duration = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.TrackBar_sound = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lbl_sound = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_start = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sort = new Guna.UI2.WinForms.Guna2Button();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_duration = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ContextMenuStrip_add = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.addASongInTheBeginningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addASongInTheEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip_delete = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.deleteASongInTheBeginningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteASongInTheEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_remove = new Guna.UI2.WinForms.Guna2Button();
            this.btn_play = new Guna.UI2.WinForms.Guna2Button();
            this.btn_pause = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sound = new Guna.UI2.WinForms.Guna2Button();
            this.pic_art = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_stop = new Guna.UI2.WinForms.Guna2Button();
            this.btn_previous = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next = new Guna.UI2.WinForms.Guna2Button();
            this.ContextMenuStrip_sort = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ascendingOrderAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingOrderZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagebox = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.text_song_name = new System.Windows.Forms.Label();
            this.ContextMenuStrip_add.SuspendLayout();
            this.ContextMenuStrip_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            this.ContextMenuStrip_sort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ProgressBar_duration
            // 
            this.ProgressBar_duration.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar_duration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBar_duration.Location = new System.Drawing.Point(55, 295);
            this.ProgressBar_duration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgressBar_duration.Name = "ProgressBar_duration";
            this.ProgressBar_duration.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.ProgressBar_duration.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.ProgressBar_duration.Size = new System.Drawing.Size(857, 7);
            this.ProgressBar_duration.TabIndex = 6;
            this.ProgressBar_duration.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBar_duration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_duration_MouseDown);
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playlist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.ItemHeight = 23;
            this.Playlist.Location = new System.Drawing.Point(217, 87);
            this.Playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(740, 138);
            this.Playlist.TabIndex = 7;
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.Playlist_SelectedIndexChanged);
            // 
            // TrackBar_sound
            // 
            this.TrackBar_sound.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.TrackBar_sound.Location = new System.Drawing.Point(220, 310);
            this.TrackBar_sound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrackBar_sound.Name = "TrackBar_sound";
            this.TrackBar_sound.Size = new System.Drawing.Size(157, 33);
            this.TrackBar_sound.TabIndex = 11;
            this.TrackBar_sound.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.TrackBar_sound.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar_sound_Scroll);
            // 
            // lbl_sound
            // 
            this.lbl_sound.AutoSize = false;
            this.lbl_sound.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sound.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_sound.Location = new System.Drawing.Point(384, 318);
            this.lbl_sound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_sound.Name = "lbl_sound";
            this.lbl_sound.Size = new System.Drawing.Size(51, 18);
            this.lbl_sound.TabIndex = 13;
            this.lbl_sound.Text = "100%";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = false;
            this.lbl_start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_start.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.lbl_start.Location = new System.Drawing.Point(12, 290);
            this.lbl_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(45, 22);
            this.lbl_start.TabIndex = 14;
            this.lbl_start.Text = "00:00";
            // 
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.DefaultAutoSize = true;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 7.2F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(499, 313);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 27);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "ADD";
            this.btn_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Animated = true;
            this.btn_del.DefaultAutoSize = true;
            this.btn_del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_del.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_del.Font = new System.Drawing.Font("Segoe UI", 7.2F);
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(576, 313);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(50, 27);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "DEL";
            this.btn_del.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Animated = true;
            this.btn_sort.DefaultAutoSize = true;
            this.btn_sort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sort.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort.ForeColor = System.Drawing.Color.White;
            this.btn_sort.Location = new System.Drawing.Point(648, 313);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(59, 27);
            this.btn_sort.TabIndex = 16;
            this.btn_sort.Text = "SORT";
            this.btn_sort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // txt_search
            // 
            this.txt_search.AutoRoundedCorners = true;
            this.txt_search.BorderRadius = 12;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(731, 314);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search ";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(196, 26);
            this.txt_search.TabIndex = 17;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = false;
            this.lbl_duration.BackColor = System.Drawing.Color.Transparent;
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.lbl_duration.Location = new System.Drawing.Point(917, 290);
            this.lbl_duration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(59, 22);
            this.lbl_duration.TabIndex = 21;
            this.lbl_duration.Text = "00:00";
            // 
            // ContextMenuStrip_add
            // 
            this.ContextMenuStrip_add.BackColor = System.Drawing.Color.Silver;
            this.ContextMenuStrip_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuStrip_add.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ContextMenuStrip_add.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addASongInTheBeginningToolStripMenuItem,
            this.addASongInTheEndToolStripMenuItem});
            this.ContextMenuStrip_add.Name = "ContextMenuStrip_add";
            this.ContextMenuStrip_add.RenderStyle.ArrowColor = System.Drawing.Color.RoyalBlue;
            this.ContextMenuStrip_add.RenderStyle.BorderColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip_add.RenderStyle.ColorTable = null;
            this.ContextMenuStrip_add.RenderStyle.RoundedEdges = true;
            this.ContextMenuStrip_add.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStrip_add.RenderStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.ContextMenuStrip_add.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStrip_add.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip_add.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ContextMenuStrip_add.Size = new System.Drawing.Size(267, 52);
            // 
            // addASongInTheBeginningToolStripMenuItem
            // 
            this.addASongInTheBeginningToolStripMenuItem.Name = "addASongInTheBeginningToolStripMenuItem";
            this.addASongInTheBeginningToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.addASongInTheBeginningToolStripMenuItem.Text = "Add a song in the beginning";
            this.addASongInTheBeginningToolStripMenuItem.Click += new System.EventHandler(this.addASongInTheBeginningToolStripMenuItem_Click);
            // 
            // addASongInTheEndToolStripMenuItem
            // 
            this.addASongInTheEndToolStripMenuItem.Name = "addASongInTheEndToolStripMenuItem";
            this.addASongInTheEndToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.addASongInTheEndToolStripMenuItem.Text = "Add a song in the end";
            this.addASongInTheEndToolStripMenuItem.Click += new System.EventHandler(this.addASongInTheEndToolStripMenuItem_Click);
            // 
            // ContextMenuStrip_delete
            // 
            this.ContextMenuStrip_delete.BackColor = System.Drawing.Color.Silver;
            this.ContextMenuStrip_delete.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ContextMenuStrip_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteASongInTheBeginningToolStripMenuItem,
            this.deleteASongInTheEndToolStripMenuItem,
            this.deleteAllSongsToolStripMenuItem});
            this.ContextMenuStrip_delete.Name = "ContextMenuStrip_delete";
            this.ContextMenuStrip_delete.RenderStyle.ArrowColor = System.Drawing.Color.RoyalBlue;
            this.ContextMenuStrip_delete.RenderStyle.BorderColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip_delete.RenderStyle.ColorTable = null;
            this.ContextMenuStrip_delete.RenderStyle.RoundedEdges = true;
            this.ContextMenuStrip_delete.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStrip_delete.RenderStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.ContextMenuStrip_delete.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStrip_delete.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip_delete.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuStrip_delete.Size = new System.Drawing.Size(283, 76);
            // 
            // deleteASongInTheBeginningToolStripMenuItem
            // 
            this.deleteASongInTheBeginningToolStripMenuItem.Name = "deleteASongInTheBeginningToolStripMenuItem";
            this.deleteASongInTheBeginningToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.deleteASongInTheBeginningToolStripMenuItem.Text = "Delete a song in the beginning";
            this.deleteASongInTheBeginningToolStripMenuItem.Click += new System.EventHandler(this.deleteASongInTheBeginningToolStripMenuItem_Click);
            // 
            // deleteASongInTheEndToolStripMenuItem
            // 
            this.deleteASongInTheEndToolStripMenuItem.Name = "deleteASongInTheEndToolStripMenuItem";
            this.deleteASongInTheEndToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.deleteASongInTheEndToolStripMenuItem.Text = "Delete a song in the end";
            this.deleteASongInTheEndToolStripMenuItem.Click += new System.EventHandler(this.deleteASongInTheEndToolStripMenuItem_Click);
            // 
            // deleteAllSongsToolStripMenuItem
            // 
            this.deleteAllSongsToolStripMenuItem.Name = "deleteAllSongsToolStripMenuItem";
            this.deleteAllSongsToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.deleteAllSongsToolStripMenuItem.Text = "Delete all songs";
            this.deleteAllSongsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllSongsToolStripMenuItem_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Animated = true;
            this.btn_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.HoverState.Image = global::Music_Player.Properties.Resources.multiply_24px3;
            this.btn_remove.Image = global::Music_Player.Properties.Resources.multiply_24px1;
            this.btn_remove.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_remove.Location = new System.Drawing.Point(899, 318);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(20, 20);
            this.btn_remove.TabIndex = 22;
            this.btn_remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_play.FillColor = System.Drawing.Color.Transparent;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.HoverState.Image = global::Music_Player.Properties.Resources.ply_h;
            this.btn_play.Image = global::Music_Player.Properties.Resources.play_24px;
            this.btn_play.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_play.Location = new System.Drawing.Point(44, 316);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(25, 25);
            this.btn_play.TabIndex = 19;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_pause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pause.FillColor = System.Drawing.Color.Transparent;
            this.btn_pause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_pause.ForeColor = System.Drawing.Color.White;
            this.btn_pause.HoverState.Image = global::Music_Player.Properties.Resources.pause_24px1;
            this.btn_pause.Image = global::Music_Player.Properties.Resources.pause_24px2;
            this.btn_pause.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_pause.Location = new System.Drawing.Point(75, 316);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(25, 25);
            this.btn_pause.TabIndex = 18;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_search
            // 
            this.btn_search.Animated = true;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.Image = global::Music_Player.Properties.Resources.search_24px;
            this.btn_search.Image = global::Music_Player.Properties.Resources.search_24px2;
            this.btn_search.Location = new System.Drawing.Point(932, 316);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(25, 25);
            this.btn_search.TabIndex = 16;
            this.btn_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_sound
            // 
            this.btn_sound.BackColor = System.Drawing.Color.Transparent;
            this.btn_sound.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sound.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sound.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sound.FillColor = System.Drawing.Color.Transparent;
            this.btn_sound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sound.ForeColor = System.Drawing.Color.White;
            this.btn_sound.HoverState.Image = global::Music_Player.Properties.Resources.mute_24px3;
            this.btn_sound.Image = global::Music_Player.Properties.Resources.voice_24px;
            this.btn_sound.Location = new System.Drawing.Point(198, 314);
            this.btn_sound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_sound.Size = new System.Drawing.Size(25, 25);
            this.btn_sound.TabIndex = 12;
            this.btn_sound.Click += new System.EventHandler(this.btn_sound_Click);
            // 
            // pic_art
            // 
            this.pic_art.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_art.FillColor = System.Drawing.Color.Transparent;
            this.pic_art.Image = global::Music_Player.Properties.Resources.cd1;
            this.pic_art.ImageRotate = 0F;
            this.pic_art.Location = new System.Drawing.Point(12, 79);
            this.pic_art.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(189, 190);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_stop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_stop.FillColor = System.Drawing.Color.Transparent;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.HoverState.Image = global::Music_Player.Properties.Resources.stop_24px;
            this.btn_stop.Image = global::Music_Player.Properties.Resources.stop_24px2;
            this.btn_stop.Location = new System.Drawing.Point(149, 318);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(20, 20);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_previous.FillColor = System.Drawing.Color.Transparent;
            this.btn_previous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.HoverState.Image = global::Music_Player.Properties.Resources.skip_to_start_24px;
            this.btn_previous.Image = global::Music_Player.Properties.Resources.skip_to_start_24px2;
            this.btn_previous.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_previous.Location = new System.Drawing.Point(13, 314);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(25, 25);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_next.FillColor = System.Drawing.Color.Transparent;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.HoverState.Image = global::Music_Player.Properties.Resources.end_24px;
            this.btn_next.Image = global::Music_Player.Properties.Resources.end_24px2;
            this.btn_next.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_next.Location = new System.Drawing.Point(111, 314);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(25, 25);
            this.btn_next.TabIndex = 1;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // ContextMenuStrip_sort
            // 
            this.ContextMenuStrip_sort.BackColor = System.Drawing.Color.Silver;
            this.ContextMenuStrip_sort.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip_sort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingOrderAZToolStripMenuItem,
            this.descendingOrderZAToolStripMenuItem});
            this.ContextMenuStrip_sort.Name = "ContextMenuStrip_sort";
            this.ContextMenuStrip_sort.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip_sort.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip_sort.RenderStyle.ColorTable = null;
            this.ContextMenuStrip_sort.RenderStyle.RoundedEdges = true;
            this.ContextMenuStrip_sort.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStrip_sort.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip_sort.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStrip_sort.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip_sort.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuStrip_sort.Size = new System.Drawing.Size(254, 52);
            // 
            // ascendingOrderAZToolStripMenuItem
            // 
            this.ascendingOrderAZToolStripMenuItem.Name = "ascendingOrderAZToolStripMenuItem";
            this.ascendingOrderAZToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.ascendingOrderAZToolStripMenuItem.Text = "Ascending Order ( A - Z )";
            this.ascendingOrderAZToolStripMenuItem.Click += new System.EventHandler(this.ascendingOrderAZToolStripMenuItem_Click);
            // 
            // descendingOrderZAToolStripMenuItem
            // 
            this.descendingOrderZAToolStripMenuItem.Name = "descendingOrderZAToolStripMenuItem";
            this.descendingOrderZAToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.descendingOrderZAToolStripMenuItem.Text = "Descending Order ( Z - A )";
            this.descendingOrderZAToolStripMenuItem.Click += new System.EventHandler(this.descendingOrderZAToolStripMenuItem_Click);
            // 
            // messagebox
            // 
            this.messagebox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messagebox.Caption = null;
            this.messagebox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.messagebox.Parent = null;
            this.messagebox.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.messagebox.Text = null;
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(-7, -6);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(739, 69);
            this.player.TabIndex = 9;
            // 
            // text_song_name
            // 
            this.text_song_name.AutoSize = true;
            this.text_song_name.Location = new System.Drawing.Point(16, 271);
            this.text_song_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text_song_name.Name = "text_song_name";
            this.text_song_name.Size = new System.Drawing.Size(0, 17);
            this.text_song_name.TabIndex = 23;
            // 
            // FlashMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(969, 351);
            this.Controls.Add(this.text_song_name);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_sound);
            this.Controls.Add(this.btn_sound);
            this.Controls.Add(this.TrackBar_sound);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.ProgressBar_duration);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.player);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FlashMusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alpha Music Player";
            this.Load += new System.EventHandler(this.FlashMusicPlayer_Load);
            this.ContextMenuStrip_add.ResumeLayout(false);
            this.ContextMenuStrip_delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            this.ContextMenuStrip_sort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_previous;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Guna.UI2.WinForms.Guna2Button btn_stop;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar_duration;
        private Guna.UI2.WinForms.Guna2PictureBox pic_art;
        private System.Windows.Forms.ListBox Playlist;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar_sound;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Guna.UI2.WinForms.Guna2Button btn_sound;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_start;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_sound;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2Button btn_sort;
        private Guna.UI2.WinForms.Guna2Button btn_del;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2Button btn_pause;
        private Guna.UI2.WinForms.Guna2Button btn_play;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_duration;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStrip_add;
        private System.Windows.Forms.ToolStripMenuItem addASongInTheBeginningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addASongInTheEndToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStrip_delete;
        private System.Windows.Forms.ToolStripMenuItem deleteASongInTheBeginningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteASongInTheEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllSongsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btn_remove;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStrip_sort;
        private System.Windows.Forms.ToolStripMenuItem ascendingOrderAZToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2MessageDialog messagebox;
        private System.Windows.Forms.ToolStripMenuItem descendingOrderZAToolStripMenuItem;
        private System.Windows.Forms.Label text_song_name;
    }
}

