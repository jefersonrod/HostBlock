namespace HostBlock
{
    partial class Form1
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
            this.tbURLBlockHosts = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.rtbHosts = new System.Windows.Forms.RichTextBox();
            this.lbPathHosts = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUnlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbURLBlockHosts
            // 
            this.tbURLBlockHosts.Location = new System.Drawing.Point(13, 13);
            this.tbURLBlockHosts.Name = "tbURLBlockHosts";
            this.tbURLBlockHosts.Size = new System.Drawing.Size(430, 20);
            this.tbURLBlockHosts.TabIndex = 0;
            this.tbURLBlockHosts.Text = "type your url here to add to block list";
            this.tbURLBlockHosts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbURLBlockHosts_MouseClick);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 39);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Open Hosts";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(368, 39);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save Hosts";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // rtbHosts
            // 
            this.rtbHosts.Location = new System.Drawing.Point(12, 103);
            this.rtbHosts.Name = "rtbHosts";
            this.rtbHosts.ReadOnly = true;
            this.rtbHosts.Size = new System.Drawing.Size(431, 211);
            this.rtbHosts.TabIndex = 3;
            this.rtbHosts.Text = "";
            // 
            // lbPathHosts
            // 
            this.lbPathHosts.AutoSize = true;
            this.lbPathHosts.Location = new System.Drawing.Point(12, 78);
            this.lbPathHosts.Name = "lbPathHosts";
            this.lbPathHosts.Size = new System.Drawing.Size(35, 13);
            this.lbPathHosts.TabIndex = 4;
            this.lbPathHosts.Text = "label1";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(132, 39);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(84, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "+Include URL";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUnlock
            // 
            this.btUnlock.Location = new System.Drawing.Point(258, 40);
            this.btUnlock.Name = "btUnlock";
            this.btUnlock.Size = new System.Drawing.Size(75, 23);
            this.btUnlock.TabIndex = 6;
            this.btUnlock.Text = "Unlock Edit";
            this.btUnlock.UseVisualStyleBackColor = true;
            this.btUnlock.Click += new System.EventHandler(this.btUnlock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 326);
            this.Controls.Add(this.btUnlock);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbPathHosts);
            this.Controls.Add(this.rtbHosts);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbURLBlockHosts);
            this.Name = "Form1";
            this.Text = "HostBlock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURLBlockHosts;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.RichTextBox rtbHosts;
        private System.Windows.Forms.Label lbPathHosts;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUnlock;
    }
}

