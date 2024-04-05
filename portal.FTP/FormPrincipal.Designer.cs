namespace FTP24CP
{
    partial class FormPrincipal
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.grpBoxUpload = new System.Windows.Forms.GroupBox();
            this.btnFileSize = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewFilename = new System.Windows.Forms.TextBox();
            this.txtCurrentFilename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNewDir = new System.Windows.Forms.TextBox();
            this.btnewDir = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnFTPSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFileDetailList = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnLstFiles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBoxUpload.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(6, 45);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(128, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Enviar";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtUpload
            // 
            this.txtUpload.Location = new System.Drawing.Point(6, 19);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(539, 20);
            this.txtUpload.TabIndex = 1;
            // 
            // grpBoxUpload
            // 
            this.grpBoxUpload.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxUpload.Controls.Add(this.txtUpload);
            this.grpBoxUpload.Controls.Add(this.btnFileSize);
            this.grpBoxUpload.Controls.Add(this.btnUpload);
            this.grpBoxUpload.Controls.Add(this.btndelete);
            this.grpBoxUpload.Controls.Add(this.btnDownload);
            this.grpBoxUpload.Location = new System.Drawing.Point(18, 97);
            this.grpBoxUpload.Name = "grpBoxUpload";
            this.grpBoxUpload.Size = new System.Drawing.Size(551, 79);
            this.grpBoxUpload.TabIndex = 2;
            this.grpBoxUpload.TabStop = false;
            this.grpBoxUpload.Text = "Operações Comuns de FTP";
            // 
            // btnFileSize
            // 
            this.btnFileSize.Location = new System.Drawing.Point(417, 45);
            this.btnFileSize.Name = "btnFileSize";
            this.btnFileSize.Size = new System.Drawing.Size(128, 23);
            this.btnFileSize.TabIndex = 0;
            this.btnFileSize.Text = "Tamanho";
            this.btnFileSize.UseVisualStyleBackColor = true;
            this.btnFileSize.Click += new System.EventHandler(this.btnFileSize_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(280, 45);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 23);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Apagar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(143, 45);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(128, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Baixar";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtNewFilename);
            this.groupBox5.Controls.Add(this.txtCurrentFilename);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(13, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(550, 104);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Renomear Arquivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome do novo arquivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do arquivo antigo";
            // 
            // txtNewFilename
            // 
            this.txtNewFilename.Location = new System.Drawing.Point(135, 45);
            this.txtNewFilename.Name = "txtNewFilename";
            this.txtNewFilename.Size = new System.Drawing.Size(409, 20);
            this.txtNewFilename.TabIndex = 2;
            // 
            // txtCurrentFilename
            // 
            this.txtCurrentFilename.Location = new System.Drawing.Point(135, 19);
            this.txtCurrentFilename.Name = "txtCurrentFilename";
            this.txtCurrentFilename.Size = new System.Drawing.Size(409, 20);
            this.txtCurrentFilename.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Renomear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.txtNewDir);
            this.groupBox6.Controls.Add(this.btnewDir);
            this.groupBox6.Location = new System.Drawing.Point(12, 301);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(551, 79);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Novo Diretório";
            // 
            // txtNewDir
            // 
            this.txtNewDir.Location = new System.Drawing.Point(6, 19);
            this.txtNewDir.Name = "txtNewDir";
            this.txtNewDir.Size = new System.Drawing.Size(539, 20);
            this.txtNewDir.TabIndex = 1;
            // 
            // btnewDir
            // 
            this.btnewDir.Location = new System.Drawing.Point(6, 45);
            this.btnewDir.Name = "btnewDir";
            this.btnewDir.Size = new System.Drawing.Size(134, 23);
            this.btnewDir.TabIndex = 0;
            this.btnewDir.Text = "Criar Diretório";
            this.btnewDir.UseVisualStyleBackColor = true;
            this.btnewDir.Click += new System.EventHandler(this.btnewDir_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.txtPassword);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txtUsername);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txtServerIP);
            this.groupBox7.Controls.Add(this.btnFTPSave);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(18, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(550, 88);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "FTP Configurações";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(381, 28);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(193, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 20);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(5, 28);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(163, 20);
            this.txtServerIP.TabIndex = 1;
            this.txtServerIP.TextChanged += new System.EventHandler(this.txtServerIP_TextChanged);
            // 
            // btnFTPSave
            // 
            this.btnFTPSave.Enabled = false;
            this.btnFTPSave.Location = new System.Drawing.Point(5, 54);
            this.btnFTPSave.Name = "btnFTPSave";
            this.btnFTPSave.Size = new System.Drawing.Size(163, 23);
            this.btnFTPSave.TabIndex = 0;
            this.btnFTPSave.Text = "Confirmar";
            this.btnFTPSave.UseVisualStyleBackColor = true;
            this.btnFTPSave.Click += new System.EventHandler(this.btnFTPSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servidor";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnFileDetailList);
            this.groupBox2.Controls.Add(this.lstFiles);
            this.groupBox2.Controls.Add(this.btnLstFiles);
            this.groupBox2.Location = new System.Drawing.Point(13, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 167);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listando Arquivos:";
            // 
            // btnFileDetailList
            // 
            this.btnFileDetailList.Location = new System.Drawing.Point(7, 133);
            this.btnFileDetailList.Name = "btnFileDetailList";
            this.btnFileDetailList.Size = new System.Drawing.Size(132, 23);
            this.btnFileDetailList.TabIndex = 2;
            this.btnFileDetailList.Text = "Listar Arquivos Detalhadamente";
            this.btnFileDetailList.UseVisualStyleBackColor = true;
            this.btnFileDetailList.Click += new System.EventHandler(this.btnFileDetailList_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(7, 45);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(537, 82);
            this.lstFiles.TabIndex = 1;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // btnLstFiles
            // 
            this.btnLstFiles.Location = new System.Drawing.Point(6, 19);
            this.btnLstFiles.Name = "btnLstFiles";
            this.btnLstFiles.Size = new System.Drawing.Size(133, 23);
            this.btnLstFiles.TabIndex = 0;
            this.btnLstFiles.Text = "Listar Arquivos";
            this.btnLstFiles.UseVisualStyleBackColor = true;
            this.btnLstFiles.Click += new System.EventHandler(this.btnLstFiles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::portal.FTP.Properties.Resources.LOGO_FTC;
            this.pictureBox1.Location = new System.Drawing.Point(574, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Créditos:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpBoxUpload);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FTP Aplicativo : Servidor - ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxUpload.ResumeLayout(false);
            this.grpBoxUpload.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtUpload;
        private System.Windows.Forms.GroupBox grpBoxUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnFileSize;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNewFilename;
        private System.Windows.Forms.TextBox txtCurrentFilename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNewDir;
        private System.Windows.Forms.Button btnewDir;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnFTPSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFileDetailList;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnLstFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

