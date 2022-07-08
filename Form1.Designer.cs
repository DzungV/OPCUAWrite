namespace OPCUAWrite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSensorValue = new System.Windows.Forms.TextBox();
            this.txtTimeStamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPos = new System.Windows.Forms.TextBox();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnOperate = new System.Windows.Forms.Button();
            this.txtOperStt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSensorValue
            // 
            this.txtSensorValue.Location = new System.Drawing.Point(161, 76);
            this.txtSensorValue.Name = "txtSensorValue";
            this.txtSensorValue.Size = new System.Drawing.Size(196, 27);
            this.txtSensorValue.TabIndex = 0;
            // 
            // txtTimeStamp
            // 
            this.txtTimeStamp.Location = new System.Drawing.Point(161, 21);
            this.txtTimeStamp.Name = "txtTimeStamp";
            this.txtTimeStamp.Size = new System.Drawing.Size(196, 27);
            this.txtTimeStamp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TimeStamp";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(481, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(481, 95);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 29);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.AutoSize = true;
            this.lblStatusMessage.Location = new System.Drawing.Point(131, 348);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(107, 20);
            this.lblStatusMessage.TabIndex = 5;
            this.lblStatusMessage.Text = "StatusMessage";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operating Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mode";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(161, 153);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(125, 27);
            this.txtPos.TabIndex = 8;
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(161, 213);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(125, 27);
            this.txtMode.TabIndex = 8;
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(329, 153);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(127, 29);
            this.btnPos.TabIndex = 10;
            this.btnPos.Text = "Change Position";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(329, 211);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(127, 29);
            this.btnMode.TabIndex = 10;
            this.btnMode.Text = "Change Mode";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnOperate
            // 
            this.btnOperate.Location = new System.Drawing.Point(329, 273);
            this.btnOperate.Name = "btnOperate";
            this.btnOperate.Size = new System.Drawing.Size(127, 29);
            this.btnOperate.TabIndex = 10;
            this.btnOperate.Text = "Change Status";
            this.btnOperate.UseVisualStyleBackColor = true;
            this.btnOperate.Click += new System.EventHandler(this.btnOperate_Click);
            // 
            // txtOperStt
            // 
            this.txtOperStt.Location = new System.Drawing.Point(161, 270);
            this.txtOperStt.Name = "txtOperStt";
            this.txtOperStt.Size = new System.Drawing.Size(125, 27);
            this.txtOperStt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 387);
            this.Controls.Add(this.btnOperate);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.txtOperStt);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatusMessage);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeStamp);
            this.Controls.Add(this.txtSensorValue);
            this.Name = "Form1";
            this.Text = "OPC UA Write Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSensorValue;
        private TextBox txtTimeStamp;
        private Label label1;
        private Label label2;
        private Button btnStart;
        private Button btnStop;
        private Label lblStatusMessage;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtPos;
        private TextBox txtMode;
        private Button btnPos;
        private Button btnMode;
        private Button btnOperate;
        private TextBox txtOperStt;
    }
}