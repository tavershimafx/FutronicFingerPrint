
namespace FutronicFingerPrint
{
    partial class MainForm
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
            this.scannerPicture = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.comparedPicture = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPercentageMatch = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scannerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // scannerPicture
            // 
            this.scannerPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scannerPicture.Location = new System.Drawing.Point(12, 12);
            this.scannerPicture.Name = "scannerPicture";
            this.scannerPicture.Size = new System.Drawing.Size(208, 231);
            this.scannerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scannerPicture.TabIndex = 0;
            this.scannerPicture.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(12, 260);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // comparedPicture
            // 
            this.comparedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comparedPicture.Location = new System.Drawing.Point(247, 12);
            this.comparedPicture.Name = "comparedPicture";
            this.comparedPicture.Size = new System.Drawing.Size(208, 231);
            this.comparedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comparedPicture.TabIndex = 0;
            this.comparedPicture.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(256, 260);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select File";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(363, 260);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Percentage match:";
            // 
            // lblPercentageMatch
            // 
            this.lblPercentageMatch.AutoSize = true;
            this.lblPercentageMatch.Location = new System.Drawing.Point(122, 299);
            this.lblPercentageMatch.Name = "lblPercentageMatch";
            this.lblPercentageMatch.Size = new System.Drawing.Size(38, 15);
            this.lblPercentageMatch.TabIndex = 3;
            this.lblPercentageMatch.Text = "label2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(0, 353);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 15);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 371);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblPercentageMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.comparedPicture);
            this.Controls.Add(this.scannerPicture);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scannerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox scannerPicture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox comparedPicture;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPercentageMatch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblStatus;
    }
}

