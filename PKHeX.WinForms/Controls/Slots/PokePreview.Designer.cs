namespace PKHeX.WinForms.Controls
{
    partial class PokePreview
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
            PAN_All = new System.Windows.Forms.Panel();
            FLP_List = new System.Windows.Forms.FlowLayoutPanel();
            L_Stats = new System.Windows.Forms.Label();
            FLP_Moves = new System.Windows.Forms.FlowLayoutPanel();
            Move1 = new MoveDisplay();
            Move2 = new MoveDisplay();
            Move3 = new MoveDisplay();
            Move4 = new MoveDisplay();
            L_Etc = new System.Windows.Forms.Label();
            PAN_Top = new System.Windows.Forms.Panel();
            L_Name = new System.Windows.Forms.Label();
            PB_Ball = new System.Windows.Forms.PictureBox();
            PB_Gender = new System.Windows.Forms.PictureBox();
            PAN_All.SuspendLayout();
            FLP_List.SuspendLayout();
            FLP_Moves.SuspendLayout();
            PAN_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_Gender).BeginInit();
            SuspendLayout();
            // 
            // PAN_All
            // 
            PAN_All.BackColor = System.Drawing.SystemColors.Window;
            PAN_All.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PAN_All.Controls.Add(FLP_List);
            PAN_All.Controls.Add(PAN_Top);
            PAN_All.Dock = System.Windows.Forms.DockStyle.Fill;
            PAN_All.Location = new System.Drawing.Point(0, 0);
            PAN_All.Margin = new System.Windows.Forms.Padding(0);
            PAN_All.Name = "PAN_All";
            PAN_All.Size = new System.Drawing.Size(148, 348);
            PAN_All.TabIndex = 19;
            // 
            // FLP_List
            // 
            FLP_List.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            FLP_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FLP_List.Controls.Add(L_Stats);
            FLP_List.Controls.Add(FLP_Moves);
            FLP_List.Controls.Add(L_Etc);
            FLP_List.Location = new System.Drawing.Point(0, 34);
            FLP_List.Name = "FLP_List";
            FLP_List.Size = new System.Drawing.Size(146, 312);
            FLP_List.TabIndex = 1;
            // 
            // L_Stats
            // 
            FLP_List.SetFlowBreak(L_Stats, true);
            L_Stats.Location = new System.Drawing.Point(2, 4);
            L_Stats.Margin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            L_Stats.Name = "L_Stats";
            L_Stats.Size = new System.Drawing.Size(32, 15);
            L_Stats.TabIndex = 5;
            L_Stats.Text = "Stats";
            // 
            // FLP_Moves
            // 
            FLP_Moves.AutoSize = true;
            FLP_Moves.Controls.Add(Move1);
            FLP_Moves.Controls.Add(Move2);
            FLP_Moves.Controls.Add(Move3);
            FLP_Moves.Controls.Add(Move4);
            FLP_Moves.Location = new System.Drawing.Point(4, 23);
            FLP_Moves.Margin = new System.Windows.Forms.Padding(4);
            FLP_Moves.Name = "FLP_Moves";
            FLP_Moves.Size = new System.Drawing.Size(138, 96);
            FLP_Moves.TabIndex = 7;
            // 
            // Move1
            // 
            FLP_Moves.SetFlowBreak(Move1, true);
            Move1.Location = new System.Drawing.Point(0, 0);
            Move1.Margin = new System.Windows.Forms.Padding(0);
            Move1.Name = "Move1";
            Move1.Size = new System.Drawing.Size(138, 24);
            Move1.TabIndex = 1;
            // 
            // Move2
            // 
            FLP_Moves.SetFlowBreak(Move2, true);
            Move2.Location = new System.Drawing.Point(0, 24);
            Move2.Margin = new System.Windows.Forms.Padding(0);
            Move2.Name = "Move2";
            Move2.Size = new System.Drawing.Size(138, 24);
            Move2.TabIndex = 2;
            // 
            // Move3
            // 
            FLP_Moves.SetFlowBreak(Move3, true);
            Move3.Location = new System.Drawing.Point(0, 48);
            Move3.Margin = new System.Windows.Forms.Padding(0);
            Move3.Name = "Move3";
            Move3.Size = new System.Drawing.Size(138, 24);
            Move3.TabIndex = 3;
            // 
            // Move4
            // 
            FLP_Moves.SetFlowBreak(Move4, true);
            Move4.Location = new System.Drawing.Point(0, 72);
            Move4.Margin = new System.Windows.Forms.Padding(0);
            Move4.Name = "Move4";
            Move4.Size = new System.Drawing.Size(138, 24);
            Move4.TabIndex = 4;
            // 
            // L_Etc
            // 
            FLP_List.SetFlowBreak(L_Etc, true);
            L_Etc.Location = new System.Drawing.Point(2, 123);
            L_Etc.Margin = new System.Windows.Forms.Padding(2, 0, 0, 4);
            L_Etc.Name = "L_Etc";
            L_Etc.Size = new System.Drawing.Size(28, 15);
            L_Etc.TabIndex = 6;
            L_Etc.Text = "Info";
            // 
            // PAN_Top
            // 
            PAN_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PAN_Top.Controls.Add(L_Name);
            PAN_Top.Controls.Add(PB_Ball);
            PAN_Top.Controls.Add(PB_Gender);
            PAN_Top.Dock = System.Windows.Forms.DockStyle.Top;
            PAN_Top.Location = new System.Drawing.Point(0, 0);
            PAN_Top.Name = "PAN_Top";
            PAN_Top.Size = new System.Drawing.Size(146, 34);
            PAN_Top.TabIndex = 0;
            // 
            // L_Name
            // 
            L_Name.Location = new System.Drawing.Point(30, 4);
            L_Name.Name = "L_Name";
            L_Name.Size = new System.Drawing.Size(80, 24);
            L_Name.TabIndex = 0;
            L_Name.Text = "Species";
            L_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PB_Ball
            // 
            PB_Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            PB_Ball.Location = new System.Drawing.Point(4, 4);
            PB_Ball.Margin = new System.Windows.Forms.Padding(0);
            PB_Ball.Name = "PB_Ball";
            PB_Ball.Size = new System.Drawing.Size(24, 24);
            PB_Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            PB_Ball.TabIndex = 68;
            PB_Ball.TabStop = false;
            // 
            // PB_Gender
            // 
            PB_Gender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            PB_Gender.Location = new System.Drawing.Point(115, 4);
            PB_Gender.Margin = new System.Windows.Forms.Padding(0);
            PB_Gender.Name = "PB_Gender";
            PB_Gender.Size = new System.Drawing.Size(24, 24);
            PB_Gender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            PB_Gender.TabIndex = 70;
            PB_Gender.TabStop = false;
            // 
            // PokePreview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(148, 348);
            Controls.Add(PAN_All);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PokePreview";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "PokePreview";
            TopMost = true;
            PAN_All.ResumeLayout(false);
            FLP_List.ResumeLayout(false);
            FLP_List.PerformLayout();
            FLP_Moves.ResumeLayout(false);
            PAN_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_Ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_Gender).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PAN_All;
        private System.Windows.Forms.FlowLayoutPanel FLP_List;
        private System.Windows.Forms.Label L_Stats;
        private System.Windows.Forms.Panel PAN_Top;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.PictureBox PB_Ball;
        private System.Windows.Forms.PictureBox PB_Gender;
        private MoveDisplay Move1;
        private MoveDisplay Move2;
        private MoveDisplay Move3;
        private MoveDisplay Move4;
        private System.Windows.Forms.Label L_Etc;
        private System.Windows.Forms.FlowLayoutPanel FLP_Moves;
    }
}
