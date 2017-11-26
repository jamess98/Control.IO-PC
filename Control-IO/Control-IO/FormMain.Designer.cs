namespace Control_IO
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageMouse = new System.Windows.Forms.TabPage();
            this.tabPageKeyboard = new System.Windows.Forms.TabPage();
            this.tabPageVoice = new System.Windows.Forms.TabPage();
            this.tabPageGesture = new System.Windows.Forms.TabPage();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabPageCamera = new System.Windows.Forms.TabPage();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCamera = new System.Windows.Forms.Button();
            this.lblCamera = new System.Windows.Forms.Label();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.btnGesture = new System.Windows.Forms.Button();
            this.lblGesture = new System.Windows.Forms.Label();
            this.pictureBoxGesture = new System.Windows.Forms.PictureBox();
            this.btnVoice = new System.Windows.Forms.Button();
            this.lblVoice = new System.Windows.Forms.Label();
            this.pictureBoxVoice = new System.Windows.Forms.PictureBox();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.lblKeyboard = new System.Windows.Forms.Label();
            this.pictureBoxKeyboard = new System.Windows.Forms.PictureBox();
            this.btnMouse = new System.Windows.Forms.Button();
            this.lblMouse = new System.Windows.Forms.Label();
            this.pictureBoxMouse = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageGesture.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGesture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1,
            this.testToolStripMenuItem2,
            this.optionsToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.testToolStripMenuItem.Text = "File";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.testToolStripMenuItem1.Text = "Import Settings";
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.testToolStripMenuItem2.Text = "Export Settings";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControlSettings);
            this.groupBox2.Location = new System.Drawing.Point(283, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 492);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageMouse);
            this.tabControlSettings.Controls.Add(this.tabPageKeyboard);
            this.tabControlSettings.Controls.Add(this.tabPageVoice);
            this.tabControlSettings.Controls.Add(this.tabPageGesture);
            this.tabControlSettings.Controls.Add(this.tabPageCamera);
            this.tabControlSettings.Location = new System.Drawing.Point(6, 19);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(522, 467);
            this.tabControlSettings.TabIndex = 0;
            // 
            // tabPageMouse
            // 
            this.tabPageMouse.Location = new System.Drawing.Point(4, 22);
            this.tabPageMouse.Name = "tabPageMouse";
            this.tabPageMouse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMouse.Size = new System.Drawing.Size(514, 441);
            this.tabPageMouse.TabIndex = 0;
            this.tabPageMouse.Text = "Mouse";
            this.tabPageMouse.UseVisualStyleBackColor = true;
            // 
            // tabPageKeyboard
            // 
            this.tabPageKeyboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageKeyboard.Name = "tabPageKeyboard";
            this.tabPageKeyboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeyboard.Size = new System.Drawing.Size(514, 441);
            this.tabPageKeyboard.TabIndex = 1;
            this.tabPageKeyboard.Text = "Keyboard";
            this.tabPageKeyboard.UseVisualStyleBackColor = true;
            // 
            // tabPageVoice
            // 
            this.tabPageVoice.Location = new System.Drawing.Point(4, 22);
            this.tabPageVoice.Name = "tabPageVoice";
            this.tabPageVoice.Size = new System.Drawing.Size(514, 441);
            this.tabPageVoice.TabIndex = 2;
            this.tabPageVoice.Text = "Voice";
            this.tabPageVoice.UseVisualStyleBackColor = true;
            // 
            // tabPageGesture
            // 
            this.tabPageGesture.Controls.Add(this.btnRun);
            this.tabPageGesture.Controls.Add(this.txtBrowse);
            this.tabPageGesture.Controls.Add(this.btnTest);
            this.tabPageGesture.Location = new System.Drawing.Point(4, 22);
            this.tabPageGesture.Name = "tabPageGesture";
            this.tabPageGesture.Size = new System.Drawing.Size(514, 441);
            this.tabPageGesture.TabIndex = 3;
            this.tabPageGesture.Text = "Gesture";
            this.tabPageGesture.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(117, 99);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(35, 73);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(272, 20);
            this.txtBrowse.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(35, 99);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "browse";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTest.UseMnemonic = false;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabPageCamera
            // 
            this.tabPageCamera.Location = new System.Drawing.Point(4, 22);
            this.tabPageCamera.Name = "tabPageCamera";
            this.tabPageCamera.Size = new System.Drawing.Size(514, 441);
            this.tabPageCamera.TabIndex = 4;
            this.tabPageCamera.Text = "Camera";
            this.tabPageCamera.UseVisualStyleBackColor = true;
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(7, 20);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(521, 94);
            this.txtDebug.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDebug);
            this.groupBox1.Location = new System.Drawing.Point(283, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 120);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCamera);
            this.groupBox3.Controls.Add(this.lblCamera);
            this.groupBox3.Controls.Add(this.pictureBoxCamera);
            this.groupBox3.Controls.Add(this.btnGesture);
            this.groupBox3.Controls.Add(this.lblGesture);
            this.groupBox3.Controls.Add(this.pictureBoxGesture);
            this.groupBox3.Controls.Add(this.btnVoice);
            this.groupBox3.Controls.Add(this.lblVoice);
            this.groupBox3.Controls.Add(this.pictureBoxVoice);
            this.groupBox3.Controls.Add(this.btnKeyboard);
            this.groupBox3.Controls.Add(this.lblKeyboard);
            this.groupBox3.Controls.Add(this.pictureBoxKeyboard);
            this.groupBox3.Controls.Add(this.btnMouse);
            this.groupBox3.Controls.Add(this.lblMouse);
            this.groupBox3.Controls.Add(this.pictureBoxMouse);
            this.groupBox3.Location = new System.Drawing.Point(13, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 491);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toggle";
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(172, 394);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(75, 23);
            this.btnCamera.TabIndex = 35;
            this.btnCamera.Text = "Toggle";
            this.btnCamera.UseVisualStyleBackColor = true;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera.Location = new System.Drawing.Point(92, 397);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(57, 17);
            this.lblCamera.TabIndex = 34;
            this.lblCamera.Text = "Camera";
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamera.Location = new System.Drawing.Point(6, 363);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxCamera.TabIndex = 33;
            this.pictureBoxCamera.TabStop = false;
            // 
            // btnGesture
            // 
            this.btnGesture.Location = new System.Drawing.Point(172, 308);
            this.btnGesture.Name = "btnGesture";
            this.btnGesture.Size = new System.Drawing.Size(75, 23);
            this.btnGesture.TabIndex = 32;
            this.btnGesture.Text = "Toggle";
            this.btnGesture.UseVisualStyleBackColor = true;
            // 
            // lblGesture
            // 
            this.lblGesture.AutoSize = true;
            this.lblGesture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGesture.Location = new System.Drawing.Point(92, 311);
            this.lblGesture.Name = "lblGesture";
            this.lblGesture.Size = new System.Drawing.Size(59, 17);
            this.lblGesture.TabIndex = 31;
            this.lblGesture.Text = "Gesture";
            // 
            // pictureBoxGesture
            // 
            this.pictureBoxGesture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGesture.Location = new System.Drawing.Point(6, 277);
            this.pictureBoxGesture.Name = "pictureBoxGesture";
            this.pictureBoxGesture.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxGesture.TabIndex = 30;
            this.pictureBoxGesture.TabStop = false;
            // 
            // btnVoice
            // 
            this.btnVoice.Location = new System.Drawing.Point(172, 222);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(75, 23);
            this.btnVoice.TabIndex = 29;
            this.btnVoice.Text = "Toggle";
            this.btnVoice.UseVisualStyleBackColor = true;
            // 
            // lblVoice
            // 
            this.lblVoice.AutoSize = true;
            this.lblVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoice.Location = new System.Drawing.Point(92, 225);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(43, 17);
            this.lblVoice.TabIndex = 28;
            this.lblVoice.Text = "Voice";
            // 
            // pictureBoxVoice
            // 
            this.pictureBoxVoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVoice.Location = new System.Drawing.Point(6, 191);
            this.pictureBoxVoice.Name = "pictureBoxVoice";
            this.pictureBoxVoice.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxVoice.TabIndex = 27;
            this.pictureBoxVoice.TabStop = false;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.Location = new System.Drawing.Point(172, 136);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(75, 23);
            this.btnKeyboard.TabIndex = 26;
            this.btnKeyboard.Text = "Toggle";
            this.btnKeyboard.UseVisualStyleBackColor = true;
            // 
            // lblKeyboard
            // 
            this.lblKeyboard.AutoSize = true;
            this.lblKeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyboard.Location = new System.Drawing.Point(92, 139);
            this.lblKeyboard.Name = "lblKeyboard";
            this.lblKeyboard.Size = new System.Drawing.Size(69, 17);
            this.lblKeyboard.TabIndex = 25;
            this.lblKeyboard.Text = "Keyboard";
            // 
            // pictureBoxKeyboard
            // 
            this.pictureBoxKeyboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKeyboard.Location = new System.Drawing.Point(6, 105);
            this.pictureBoxKeyboard.Name = "pictureBoxKeyboard";
            this.pictureBoxKeyboard.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxKeyboard.TabIndex = 24;
            this.pictureBoxKeyboard.TabStop = false;
            // 
            // btnMouse
            // 
            this.btnMouse.Location = new System.Drawing.Point(172, 50);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(75, 23);
            this.btnMouse.TabIndex = 23;
            this.btnMouse.Text = "Toggle";
            this.btnMouse.UseVisualStyleBackColor = true;
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouse.Location = new System.Drawing.Point(92, 53);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(50, 17);
            this.lblMouse.TabIndex = 22;
            this.lblMouse.Text = "Mouse";
            // 
            // pictureBoxMouse
            // 
            this.pictureBoxMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMouse.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxMouse.Name = "pictureBoxMouse";
            this.pictureBoxMouse.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxMouse.TabIndex = 21;
            this.pictureBoxMouse.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtStatus);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.txtIP);
            this.groupBox4.Controls.Add(this.txtStrength);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(13, 526);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 119);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(64, 17);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(183, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(64, 69);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(183, 20);
            this.txtIP.TabIndex = 5;
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(64, 43);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(183, 20);
            this.txtStrength.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strength:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 670);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Control.IO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageGesture.ResumeLayout(false);
            this.tabPageGesture.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGesture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageMouse;
        private System.Windows.Forms.TabPage tabPageKeyboard;
        private System.Windows.Forms.TabPage tabPageVoice;
        private System.Windows.Forms.TabPage tabPageGesture;
        private System.Windows.Forms.TabPage tabPageCamera;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Button btnGesture;
        private System.Windows.Forms.Label lblGesture;
        private System.Windows.Forms.PictureBox pictureBoxGesture;
        private System.Windows.Forms.Button btnVoice;
        private System.Windows.Forms.Label lblVoice;
        private System.Windows.Forms.PictureBox pictureBoxVoice;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Label lblKeyboard;
        private System.Windows.Forms.PictureBox pictureBoxKeyboard;
        private System.Windows.Forms.Button btnMouse;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.PictureBox pictureBoxMouse;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

