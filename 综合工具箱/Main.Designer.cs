
namespace 综合工具箱
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.extList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSel = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtExif = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnXZ = new System.Windows.Forms.Button();
            this.checkXZJson = new System.Windows.Forms.CheckBox();
            this.btnXZSelJsonDIr = new System.Windows.Forms.Button();
            this.btnXZSelDIr = new System.Windows.Forms.Button();
            this.textXZJson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textXZImg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.renameDirSel = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 220);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.extList);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnRename);
            this.tabPage1.Controls.Add(this.numStart);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtQz);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSel);
            this.tabPage1.Controls.Add(this.txtDir);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "重命名";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // extList
            // 
            this.extList.ColumnWidth = 70;
            this.extList.FormattingEnabled = true;
            this.extList.Items.AddRange(new object[] {
            ".JPG",
            ".PNG",
            ".JPEG",
            ".GIF",
            ".BMP",
            ".TXT",
            ".HTML",
            ".HTM",
            ".JS",
            ".CSS",
            ".PDF",
            ".DOC",
            ".DOCX",
            ".PPT",
            ".PPTX",
            ".MP4",
            ".MP3",
            ".AVI",
            ".FLV",
            ".ZIP"});
            this.extList.Location = new System.Drawing.Point(65, 91);
            this.extList.MultiColumn = true;
            this.extList.Name = "extList";
            this.extList.Size = new System.Drawing.Size(293, 84);
            this.extList.TabIndex = 10;
            this.extList.SelectedIndexChanged += new System.EventHandler(this.extList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "类型";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(378, 117);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(93, 58);
            this.btnRename.TabIndex = 8;
            this.btnRename.Text = "进行重命名";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(238, 48);
            this.numStart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(120, 21);
            this.numStart.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "起始值";
            // 
            // txtQz
            // 
            this.txtQz.Location = new System.Drawing.Point(65, 48);
            this.txtQz.Name = "txtQz";
            this.txtQz.Size = new System.Drawing.Size(101, 21);
            this.txtQz.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "前缀";
            // 
            // btnSel
            // 
            this.btnSel.Location = new System.Drawing.Point(378, 10);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(93, 23);
            this.btnSel.TabIndex = 2;
            this.btnSel.Text = "选择文件夹";
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(65, 12);
            this.txtDir.Name = "txtDir";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(293, 21);
            this.txtDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBase64);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文件Base64";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBase64
            // 
            this.txtBase64.AllowDrop = true;
            this.txtBase64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase64.Location = new System.Drawing.Point(3, 3);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.ReadOnly = true;
            this.txtBase64.Size = new System.Drawing.Size(494, 188);
            this.txtBase64.TabIndex = 0;
            this.txtBase64.Click += new System.EventHandler(this.txtBase64_Click);
            this.txtBase64.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtBase64_DragDrop);
            this.txtBase64.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbox_DragEnter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtExif);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(500, 194);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图片元数据";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtExif
            // 
            this.txtExif.AllowDrop = true;
            this.txtExif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExif.Location = new System.Drawing.Point(3, 3);
            this.txtExif.Multiline = true;
            this.txtExif.Name = "txtExif";
            this.txtExif.ReadOnly = true;
            this.txtExif.Size = new System.Drawing.Size(494, 188);
            this.txtExif.TabIndex = 1;
            this.txtExif.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtExif_DragDrop);
            this.txtExif.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbox_DragEnter);
            this.txtExif.DoubleClick += new System.EventHandler(this.exifFileSel_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnXZ);
            this.tabPage4.Controls.Add(this.checkXZJson);
            this.tabPage4.Controls.Add(this.btnXZSelJsonDIr);
            this.tabPage4.Controls.Add(this.btnXZSelDIr);
            this.tabPage4.Controls.Add(this.textXZJson);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.textXZImg);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(500, 194);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "标记图片旋转";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnXZ
            // 
            this.btnXZ.Location = new System.Drawing.Point(202, 130);
            this.btnXZ.Name = "btnXZ";
            this.btnXZ.Size = new System.Drawing.Size(93, 40);
            this.btnXZ.TabIndex = 10;
            this.btnXZ.Text = "开始处理";
            this.btnXZ.UseVisualStyleBackColor = true;
            this.btnXZ.Click += new System.EventHandler(this.btnXZ_Click);
            // 
            // checkXZJson
            // 
            this.checkXZJson.AutoSize = true;
            this.checkXZJson.Location = new System.Drawing.Point(323, 95);
            this.checkXZJson.Name = "checkXZJson";
            this.checkXZJson.Size = new System.Drawing.Size(48, 16);
            this.checkXZJson.TabIndex = 9;
            this.checkXZJson.Text = "启用";
            this.checkXZJson.UseVisualStyleBackColor = true;
            // 
            // btnXZSelJsonDIr
            // 
            this.btnXZSelJsonDIr.Location = new System.Drawing.Point(380, 90);
            this.btnXZSelJsonDIr.Name = "btnXZSelJsonDIr";
            this.btnXZSelJsonDIr.Size = new System.Drawing.Size(93, 23);
            this.btnXZSelJsonDIr.TabIndex = 8;
            this.btnXZSelJsonDIr.Text = "选择文件夹";
            this.btnXZSelJsonDIr.UseVisualStyleBackColor = true;
            this.btnXZSelJsonDIr.Click += new System.EventHandler(this.btnXZSelJsonDIr_Click);
            // 
            // btnXZSelDIr
            // 
            this.btnXZSelDIr.Location = new System.Drawing.Point(380, 54);
            this.btnXZSelDIr.Name = "btnXZSelDIr";
            this.btnXZSelDIr.Size = new System.Drawing.Size(93, 23);
            this.btnXZSelDIr.TabIndex = 7;
            this.btnXZSelDIr.Text = "选择文件夹";
            this.btnXZSelDIr.UseVisualStyleBackColor = true;
            this.btnXZSelDIr.Click += new System.EventHandler(this.btnXZSelDIr_Click);
            // 
            // textXZJson
            // 
            this.textXZJson.Location = new System.Drawing.Point(96, 92);
            this.textXZJson.Name = "textXZJson";
            this.textXZJson.ReadOnly = true;
            this.textXZJson.Size = new System.Drawing.Size(212, 21);
            this.textXZJson.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "标记文件夹";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(24, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(439, 35);
            this.label6.TabIndex = 4;
            this.label6.Text = "   将精灵标注助手的异常方向图片修改为正常显示，若需更改标记时的数据记得选择json的导出数据信息。";
            // 
            // textXZImg
            // 
            this.textXZImg.Location = new System.Drawing.Point(96, 56);
            this.textXZImg.Name = "textXZImg";
            this.textXZImg.ReadOnly = true;
            this.textXZImg.Size = new System.Drawing.Size(269, 21);
            this.textXZImg.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "图片文件夹";
            // 
            // renameDirSel
            // 
            this.renameDirSel.Description = "请选择文件夹";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(508, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "就绪";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(500, 194);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "截图和取色";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 241);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(524, 280);
            this.MinimumSize = new System.Drawing.Size(524, 280);
            this.Name = "Main";
            this.Text = "工具箱";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSel;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FolderBrowserDialog renameDirSel;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.CheckedListBox extList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtExif;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textXZImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textXZJson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXZ;
        private System.Windows.Forms.CheckBox checkXZJson;
        private System.Windows.Forms.Button btnXZSelJsonDIr;
        private System.Windows.Forms.Button btnXZSelDIr;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

