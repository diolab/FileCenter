﻿namespace FileCenter0
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compSize = new System.Windows.Forms.NumericUpDown();
            this.run = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォルダ作成CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testbtn = new System.Windows.Forms.Button();
            this.topText = new System.Windows.Forms.ComboBox();
            this.dirSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.minSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "クオータ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ファイル先頭無視：";
            // 
            // compSize
            // 
            this.compSize.Location = new System.Drawing.Point(105, 58);
            this.compSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.compSize.Name = "compSize";
            this.compSize.Size = new System.Drawing.Size(47, 19);
            this.compSize.TabIndex = 3;
            this.compSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(494, 57);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(70, 23);
            this.run.TabIndex = 4;
            this.run.Text = "振り分け";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "対象フォルダ：";
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path.Location = new System.Drawing.Point(88, 32);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(358, 19);
            this.path.TabIndex = 6;
            // 
            // resultView
            // 
            this.resultView.AllowUserToAddRows = false;
            this.resultView.AllowUserToDeleteRows = false;
            this.resultView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.resultView.Location = new System.Drawing.Point(12, 84);
            this.resultView.Name = "resultView";
            this.resultView.RowHeadersVisible = false;
            this.resultView.RowTemplate.Height = 21;
            this.resultView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultView.Size = new System.Drawing.Size(554, 311);
            this.resultView.TabIndex = 7;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 33.46902F;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 218.744F;
            this.Column1.HeaderText = "移動先フォルダ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 218.744F;
            this.Column2.HeaderText = "移動ファイル名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 16.35267F;
            this.Column4.HeaderText = "From";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 12.69036F;
            this.Column5.HeaderText = "To";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ツールTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォルダ作成CToolStripMenuItem});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ツールTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // フォルダ作成CToolStripMenuItem
            // 
            this.フォルダ作成CToolStripMenuItem.Name = "フォルダ作成CToolStripMenuItem";
            this.フォルダ作成CToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.フォルダ作成CToolStripMenuItem.Text = "フォルダ作成(&C)";
            this.フォルダ作成CToolStripMenuItem.Click += new System.EventHandler(this.フォルダ作成CToolStripMenuItem_Click);
            // 
            // testbtn
            // 
            this.testbtn.Location = new System.Drawing.Point(418, 57);
            this.testbtn.Name = "testbtn";
            this.testbtn.Size = new System.Drawing.Size(70, 23);
            this.testbtn.TabIndex = 9;
            this.testbtn.Text = "テスト";
            this.testbtn.UseVisualStyleBackColor = true;
            this.testbtn.Click += new System.EventHandler(this.testbtn_Click);
            // 
            // topText
            // 
            this.topText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topText.FormattingEnabled = true;
            this.topText.Location = new System.Drawing.Point(504, 31);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(60, 20);
            this.topText.TabIndex = 10;
            // 
            // dirSize
            // 
            this.dirSize.Location = new System.Drawing.Point(252, 58);
            this.dirSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dirSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dirSize.Name = "dirSize";
            this.dirSize.Size = new System.Drawing.Size(47, 19);
            this.dirSize.TabIndex = 12;
            this.dirSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "フォルダ先頭無視：";
            // 
            // minSize
            // 
            this.minSize.Location = new System.Drawing.Point(365, 58);
            this.minSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.minSize.Name = "minSize";
            this.minSize.Size = new System.Drawing.Size(47, 19);
            this.minSize.TabIndex = 14;
            this.minSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "最小一致：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 407);
            this.Controls.Add(this.minSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dirSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.topText);
            this.Controls.Add(this.testbtn);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.run);
            this.Controls.Add(this.compSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ファイル振り分けツール";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown compSize;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.DataGridView resultView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォルダ作成CToolStripMenuItem;
        private System.Windows.Forms.Button testbtn;
        private System.Windows.Forms.ComboBox topText;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown dirSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minSize;
        private System.Windows.Forms.Label label5;
    }
}

