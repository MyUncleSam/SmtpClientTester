namespace SmtpClientTester
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHost = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.NumericUpDown();
            this.cbSsl = new System.Windows.Forms.CheckBox();
            this.tbTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAuthType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReplyDisp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbReplyMail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbFromDisplay = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbMessageId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbDeliveryNotify = new System.Windows.Forms.ComboBox();
            this.cbOwnMessageId = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBcc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMailTesterGuid = new System.Windows.Forms.TextBox();
            this.llGithub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeout)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(9, 22);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host:";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(86, 18);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(185, 20);
            this.tbHost.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(284, 19);
            this.tbPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tbPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(56, 20);
            this.tbPort.TabIndex = 2;
            this.tbPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // cbSsl
            // 
            this.cbSsl.AutoSize = true;
            this.cbSsl.Location = new System.Drawing.Point(361, 20);
            this.cbSsl.Name = "cbSsl";
            this.cbSsl.Size = new System.Drawing.Size(66, 17);
            this.cbSsl.TabIndex = 3;
            this.cbSsl.Text = "use SSL";
            this.cbSsl.UseVisualStyleBackColor = true;
            // 
            // tbTimeout
            // 
            this.tbTimeout.Location = new System.Drawing.Point(552, 19);
            this.tbTimeout.Name = "tbTimeout";
            this.tbTimeout.Size = new System.Drawing.Size(50, 20);
            this.tbTimeout.TabIndex = 5;
            this.tbTimeout.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(441, 21);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(105, 13);
            this.lblTimeout.TabIndex = 4;
            this.lblTimeout.Text = "(Timeout in seconds:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = ")";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(361, 19);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(185, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(361, 45);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(185, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.cbAuthType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "AuthType:";
            // 
            // cbAuthType
            // 
            this.cbAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthType.FormattingEnabled = true;
            this.cbAuthType.Location = new System.Drawing.Point(86, 19);
            this.cbAuthType.Name = "cbAuthType";
            this.cbAuthType.Size = new System.Drawing.Size(185, 21);
            this.cbAuthType.TabIndex = 1;
            this.cbAuthType.SelectedValueChanged += new System.EventHandler(this.cbAuthType_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbReplyDisp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbReplyMail);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reply to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Display:";
            // 
            // tbReplyDisp
            // 
            this.tbReplyDisp.Location = new System.Drawing.Point(361, 19);
            this.tbReplyDisp.Name = "tbReplyDisp";
            this.tbReplyDisp.Size = new System.Drawing.Size(185, 20);
            this.tbReplyDisp.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "E-Mail:";
            // 
            // tbReplyMail
            // 
            this.tbReplyMail.Location = new System.Drawing.Point(86, 19);
            this.tbReplyMail.Name = "tbReplyMail";
            this.tbReplyMail.Size = new System.Drawing.Size(185, 20);
            this.tbReplyMail.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbHost);
            this.groupBox3.Controls.Add(this.lblHost);
            this.groupBox3.Controls.Add(this.tbPort);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbSsl);
            this.groupBox3.Controls.Add(this.lblTimeout);
            this.groupBox3.Controls.Add(this.tbTimeout);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 59);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbFromDisplay);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tbFrom);
            this.groupBox4.Controls.Add(this.tbMessageId);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cbDeliveryNotify);
            this.groupBox4.Controls.Add(this.cbOwnMessageId);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tbMessage);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tbBcc);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbCc);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbTo);
            this.groupBox4.Controls.Add(this.tbSubject);
            this.groupBox4.Location = new System.Drawing.Point(12, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(630, 235);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Display:";
            // 
            // tbFromDisplay
            // 
            this.tbFromDisplay.Location = new System.Drawing.Point(361, 19);
            this.tbFromDisplay.Name = "tbFromDisplay";
            this.tbFromDisplay.Size = new System.Drawing.Size(185, 20);
            this.tbFromDisplay.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "From:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(86, 19);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(185, 20);
            this.tbFrom.TabIndex = 1;
            // 
            // tbMessageId
            // 
            this.tbMessageId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessageId.Location = new System.Drawing.Point(409, 71);
            this.tbMessageId.Name = "tbMessageId";
            this.tbMessageId.ReadOnly = true;
            this.tbMessageId.Size = new System.Drawing.Size(196, 20);
            this.tbMessageId.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "DeliveryNotify:";
            // 
            // cbDeliveryNotify
            // 
            this.cbDeliveryNotify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeliveryNotify.FormattingEnabled = true;
            this.cbDeliveryNotify.Location = new System.Drawing.Point(361, 44);
            this.cbDeliveryNotify.Name = "cbDeliveryNotify";
            this.cbDeliveryNotify.Size = new System.Drawing.Size(185, 21);
            this.cbDeliveryNotify.TabIndex = 15;
            // 
            // cbOwnMessageId
            // 
            this.cbOwnMessageId.AutoSize = true;
            this.cbOwnMessageId.Location = new System.Drawing.Point(284, 74);
            this.cbOwnMessageId.Name = "cbOwnMessageId";
            this.cbOwnMessageId.Size = new System.Drawing.Size(128, 17);
            this.cbOwnMessageId.TabIndex = 16;
            this.cbOwnMessageId.Text = "generate Message-ID";
            this.cbOwnMessageId.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Message:";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(86, 149);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(519, 67);
            this.tbMessage.TabIndex = 13;
            this.tbMessage.Text = "This is a test email.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "BCC:";
            // 
            // tbBcc
            // 
            this.tbBcc.Location = new System.Drawing.Point(86, 97);
            this.tbBcc.Name = "tbBcc";
            this.tbBcc.Size = new System.Drawing.Size(185, 20);
            this.tbBcc.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "CC:";
            // 
            // tbCc
            // 
            this.tbCc.Location = new System.Drawing.Point(86, 71);
            this.tbCc.Name = "tbCc";
            this.tbCc.Size = new System.Drawing.Size(185, 20);
            this.tbCc.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Subject:";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(86, 45);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(185, 20);
            this.tbTo.TabIndex = 5;
            // 
            // tbSubject
            // 
            this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubject.Location = new System.Drawing.Point(86, 123);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(519, 20);
            this.tbSubject.TabIndex = 11;
            this.tbSubject.Text = "Testmail";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.tbResult);
            this.groupBox5.Location = new System.Drawing.Point(12, 469);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(630, 111);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result";
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Location = new System.Drawing.Point(9, 19);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(596, 86);
            this.tbResult.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(512, 592);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "send message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MailTesterGuid:";
            // 
            // tbMailTesterGuid
            // 
            this.tbMailTesterGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailTesterGuid.Location = new System.Drawing.Point(105, 594);
            this.tbMailTesterGuid.Name = "tbMailTesterGuid";
            this.tbMailTesterGuid.ReadOnly = true;
            this.tbMailTesterGuid.Size = new System.Drawing.Size(401, 20);
            this.tbMailTesterGuid.TabIndex = 7;
            // 
            // llGithub
            // 
            this.llGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llGithub.AutoSize = true;
            this.llGithub.Location = new System.Drawing.Point(601, 1);
            this.llGithub.Name = "llGithub";
            this.llGithub.Size = new System.Drawing.Size(38, 13);
            this.llGithub.TabIndex = 8;
            this.llGithub.TabStop = true;
            this.llGithub.Text = "Github";
            this.llGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGithub_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 627);
            this.Controls.Add(this.llGithub);
            this.Controls.Add(this.tbMailTesterGuid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(666, 666);
            this.Name = "FormMain";
            this.Text = ".Net SmtpClient MailTester";
            ((System.ComponentModel.ISupportInitialize)(this.tbPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.NumericUpDown tbPort;
        private System.Windows.Forms.CheckBox cbSsl;
        private System.Windows.Forms.NumericUpDown tbTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAuthType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReplyDisp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbReplyMail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBcc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.CheckBox cbOwnMessageId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbDeliveryNotify;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbMessageId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbFromDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMailTesterGuid;
        private System.Windows.Forms.LinkLabel llGithub;
    }
}

