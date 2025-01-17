﻿namespace dnd.Controls
{
    partial class CharacterInterface
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterInterface));
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.checksSavesBtn = new System.Windows.Forms.Button();
            this.ProficencyBtn = new System.Windows.Forms.Button();
            this.FeatsBtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            this.SkillsBtn = new System.Windows.Forms.Button();
            this.AbilitiesBtn = new System.Windows.Forms.Button();
            this.SpellsBtn = new System.Windows.Forms.Button();
            this.WeaponsBtn = new System.Windows.Forms.Button();
            this.CharacterSheetBtn = new System.Windows.Forms.Button();
            this.ControlsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChracterTxtBx = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.CharacterLbl = new System.Windows.Forms.Label();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main_Panel.BackgroundImage = global::dnd.Properties.Resources.Interface;
            this.Main_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Panel.Controls.Add(this.checksSavesBtn);
            this.Main_Panel.Controls.Add(this.ProficencyBtn);
            this.Main_Panel.Controls.Add(this.FeatsBtn);
            this.Main_Panel.Controls.Add(this.statsBtn);
            this.Main_Panel.Controls.Add(this.SkillsBtn);
            this.Main_Panel.Controls.Add(this.AbilitiesBtn);
            this.Main_Panel.Controls.Add(this.SpellsBtn);
            this.Main_Panel.Controls.Add(this.WeaponsBtn);
            this.Main_Panel.Controls.Add(this.CharacterSheetBtn);
            this.Main_Panel.Controls.Add(this.ControlsPanel);
            this.Main_Panel.Location = new System.Drawing.Point(0, 24);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(298, 400);
            this.Main_Panel.TabIndex = 0;
            // 
            // checksSavesBtn
            // 
            this.checksSavesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checksSavesBtn.BackColor = System.Drawing.Color.Transparent;
            this.checksSavesBtn.BackgroundImage = global::dnd.Properties.Resources.Volume;
            this.checksSavesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checksSavesBtn.FlatAppearance.BorderSize = 0;
            this.checksSavesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checksSavesBtn.Location = new System.Drawing.Point(55, 364);
            this.checksSavesBtn.Name = "checksSavesBtn";
            this.checksSavesBtn.Size = new System.Drawing.Size(29, 28);
            this.checksSavesBtn.TabIndex = 37;
            this.checksSavesBtn.UseVisualStyleBackColor = false;
            this.checksSavesBtn.Click += new System.EventHandler(this.PerceptionBtn_Click);
            // 
            // ProficencyBtn
            // 
            this.ProficencyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProficencyBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProficencyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProficencyBtn.BackgroundImage")));
            this.ProficencyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProficencyBtn.FlatAppearance.BorderSize = 0;
            this.ProficencyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProficencyBtn.Location = new System.Drawing.Point(12, 364);
            this.ProficencyBtn.Name = "ProficencyBtn";
            this.ProficencyBtn.Size = new System.Drawing.Size(29, 28);
            this.ProficencyBtn.TabIndex = 36;
            this.ProficencyBtn.UseVisualStyleBackColor = false;
            this.ProficencyBtn.Click += new System.EventHandler(this.CheckSaveBtn_Click);
            // 
            // FeatsBtn
            // 
            this.FeatsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FeatsBtn.BackColor = System.Drawing.Color.Transparent;
            this.FeatsBtn.BackgroundImage = global::dnd.Properties.Resources.Thieving1;
            this.FeatsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FeatsBtn.FlatAppearance.BorderSize = 0;
            this.FeatsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeatsBtn.Location = new System.Drawing.Point(257, 8);
            this.FeatsBtn.Name = "FeatsBtn";
            this.FeatsBtn.Size = new System.Drawing.Size(29, 28);
            this.FeatsBtn.TabIndex = 35;
            this.FeatsBtn.UseVisualStyleBackColor = false;
            this.FeatsBtn.Click += new System.EventHandler(this.FeatsBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statsBtn.BackColor = System.Drawing.Color.Transparent;
            this.statsBtn.BackgroundImage = global::dnd.Properties.Resources.Worn_equipment;
            this.statsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statsBtn.FlatAppearance.BorderSize = 0;
            this.statsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsBtn.Location = new System.Drawing.Point(216, 6);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(29, 28);
            this.statsBtn.TabIndex = 34;
            this.statsBtn.UseVisualStyleBackColor = false;
            this.statsBtn.Click += new System.EventHandler(this.EquipmentBtn_Click);
            // 
            // SkillsBtn
            // 
            this.SkillsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SkillsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SkillsBtn.FlatAppearance.BorderSize = 0;
            this.SkillsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkillsBtn.Image = global::dnd.Properties.Resources.Stats_icon;
            this.SkillsBtn.Location = new System.Drawing.Point(176, 6);
            this.SkillsBtn.Name = "SkillsBtn";
            this.SkillsBtn.Size = new System.Drawing.Size(29, 28);
            this.SkillsBtn.TabIndex = 33;
            this.SkillsBtn.UseVisualStyleBackColor = false;
            this.SkillsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // AbilitiesBtn
            // 
            this.AbilitiesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiesBtn.BackColor = System.Drawing.Color.Transparent;
            this.AbilitiesBtn.BackgroundImage = global::dnd.Properties.Resources.Quests_icon;
            this.AbilitiesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AbilitiesBtn.FlatAppearance.BorderSize = 0;
            this.AbilitiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbilitiesBtn.Location = new System.Drawing.Point(136, 7);
            this.AbilitiesBtn.Name = "AbilitiesBtn";
            this.AbilitiesBtn.Size = new System.Drawing.Size(29, 28);
            this.AbilitiesBtn.TabIndex = 32;
            this.AbilitiesBtn.UseVisualStyleBackColor = false;
            this.AbilitiesBtn.Click += new System.EventHandler(this.AbilitiesBtn_Click);
            // 
            // SpellsBtn
            // 
            this.SpellsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SpellsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SpellsBtn.BackgroundImage = global::dnd.Properties.Resources.Lunar_spellbook;
            this.SpellsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpellsBtn.FlatAppearance.BorderSize = 0;
            this.SpellsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpellsBtn.Location = new System.Drawing.Point(95, 6);
            this.SpellsBtn.Name = "SpellsBtn";
            this.SpellsBtn.Size = new System.Drawing.Size(29, 28);
            this.SpellsBtn.TabIndex = 31;
            this.SpellsBtn.UseVisualStyleBackColor = false;
            this.SpellsBtn.Click += new System.EventHandler(this.SpellsBtn_Click);
            // 
            // WeaponsBtn
            // 
            this.WeaponsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeaponsBtn.BackColor = System.Drawing.Color.Transparent;
            this.WeaponsBtn.BackgroundImage = global::dnd.Properties.Resources.Combat_icon;
            this.WeaponsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WeaponsBtn.FlatAppearance.BorderSize = 0;
            this.WeaponsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeaponsBtn.Location = new System.Drawing.Point(56, 7);
            this.WeaponsBtn.Name = "WeaponsBtn";
            this.WeaponsBtn.Size = new System.Drawing.Size(29, 28);
            this.WeaponsBtn.TabIndex = 30;
            this.WeaponsBtn.UseVisualStyleBackColor = false;
            this.WeaponsBtn.Click += new System.EventHandler(this.WeaponsBtn_Click);
            // 
            // CharacterSheetBtn
            // 
            this.CharacterSheetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterSheetBtn.BackColor = System.Drawing.Color.Transparent;
            this.CharacterSheetBtn.BackgroundImage = global::dnd.Properties.Resources.Notes_button;
            this.CharacterSheetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterSheetBtn.FlatAppearance.BorderSize = 0;
            this.CharacterSheetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacterSheetBtn.Location = new System.Drawing.Point(13, 10);
            this.CharacterSheetBtn.Name = "CharacterSheetBtn";
            this.CharacterSheetBtn.Size = new System.Drawing.Size(29, 28);
            this.CharacterSheetBtn.TabIndex = 29;
            this.CharacterSheetBtn.UseVisualStyleBackColor = false;
            this.CharacterSheetBtn.Click += new System.EventHandler(this.CharacterSheetBtn_Click);
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(100)))), ((int)(((byte)(96)))));
            this.ControlsPanel.BackgroundImage = global::dnd.Properties.Resources.InterfaceBG;
            this.ControlsPanel.Location = new System.Drawing.Point(34, 48);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(231, 309);
            this.ControlsPanel.TabIndex = 28;
            this.ControlsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlsPanel_Paint);
            // 
            // ChracterTxtBx
            // 
            this.ChracterTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChracterTxtBx.Location = new System.Drawing.Point(67, 1);
            this.ChracterTxtBx.Multiline = true;
            this.ChracterTxtBx.Name = "ChracterTxtBx";
            this.ChracterTxtBx.Size = new System.Drawing.Size(128, 21);
            this.ChracterTxtBx.TabIndex = 1;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.BackColor = System.Drawing.Color.White;
            this.BrowseBtn.FlatAppearance.BorderSize = 0;
            this.BrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBtn.Location = new System.Drawing.Point(196, 1);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(50, 21);
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = false;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(247, 1);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(50, 21);
            this.Save.TabIndex = 3;
            this.Save.Text = "save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CharacterLbl
            // 
            this.CharacterLbl.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterLbl.Location = new System.Drawing.Point(1, 1);
            this.CharacterLbl.Name = "CharacterLbl";
            this.CharacterLbl.Size = new System.Drawing.Size(65, 21);
            this.CharacterLbl.TabIndex = 38;
            this.CharacterLbl.Text = "Character:";
            // 
            // CharacterInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::dnd.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.CharacterLbl);
            this.Controls.Add(this.ChracterTxtBx);
            this.Controls.Add(this.Main_Panel);
            this.DoubleBuffered = true;
            this.Name = "CharacterInterface";
            this.Size = new System.Drawing.Size(298, 424);
            this.Load += new System.EventHandler(this.CharacterInterface_Load);
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Button checksSavesBtn;
        private System.Windows.Forms.Button ProficencyBtn;
        private System.Windows.Forms.Button FeatsBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button SkillsBtn;
        private System.Windows.Forms.Button SpellsBtn;
        private System.Windows.Forms.Button WeaponsBtn;
        private System.Windows.Forms.Button CharacterSheetBtn;
        private System.Windows.Forms.FlowLayoutPanel ControlsPanel;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label CharacterLbl;
        public System.Windows.Forms.TextBox ChracterTxtBx;
        private System.Windows.Forms.Button AbilitiesBtn;
    }
}
