namespace ColoursOfTheRainbow
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRead = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblconnection = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.labelsearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.AnyColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(31, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(144, 34);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read Colours";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(50, 64);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 13);
            this.labelOutput.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(359, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 34);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblconnection
            // 
            this.lblconnection.AutoSize = true;
            this.lblconnection.Location = new System.Drawing.Point(225, 230);
            this.lblconnection.Name = "lblconnection";
            this.lblconnection.Size = new System.Drawing.Size(0, 13);
            this.lblconnection.TabIndex = 3;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(366, 77);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(121, 30);
            this.btnsend.TabIndex = 4;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Enabled = false;
            this.Searchbtn.Location = new System.Drawing.Point(213, 13);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(91, 33);
            this.Searchbtn.TabIndex = 5;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(213, 77);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 20);
            this.txtsearch.TabIndex = 6;
            this.txtsearch.Visible = false;
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Location = new System.Drawing.Point(213, 126);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(0, 13);
            this.labelsearch.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lblconnection);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblconnection;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label labelsearch;
    }
}

