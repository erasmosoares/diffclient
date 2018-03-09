namespace JSONDiff
{
    partial class Tool
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.btnGetStoredFiles = new System.Windows.Forms.Button();
            this.btnSingleFile = new System.Windows.Forms.Button();
            this.btnAddLeft = new System.Windows.Forms.Button();
            this.btnAddToTheRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 85);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.Size = new System.Drawing.Size(988, 284);
            this.dgvDados.TabIndex = 0;
            // 
            // txtURI
            // 
            this.txtURI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURI.Location = new System.Drawing.Point(57, 37);
            this.txtURI.Margin = new System.Windows.Forms.Padding(4);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(885, 26);
            this.txtURI.TabIndex = 12;
            this.txtURI.Text = "http://localhost:49783/v1/diff/data";
            // 
            // btnGetStoredFiles
            // 
            this.btnGetStoredFiles.BackColor = System.Drawing.Color.LightGray;
            this.btnGetStoredFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStoredFiles.Location = new System.Drawing.Point(13, 376);
            this.btnGetStoredFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetStoredFiles.Name = "btnGetStoredFiles";
            this.btnGetStoredFiles.Size = new System.Drawing.Size(199, 54);
            this.btnGetStoredFiles.TabIndex = 13;
            this.btnGetStoredFiles.Text = "Files";
            this.btnGetStoredFiles.UseVisualStyleBackColor = false;
            this.btnGetStoredFiles.Click += new System.EventHandler(this.btnGetStoredFiles_Click);
            // 
            // btnSingleFile
            // 
            this.btnSingleFile.BackColor = System.Drawing.Color.LightGray;
            this.btnSingleFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleFile.Location = new System.Drawing.Point(220, 376);
            this.btnSingleFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSingleFile.Name = "btnSingleFile";
            this.btnSingleFile.Size = new System.Drawing.Size(199, 54);
            this.btnSingleFile.TabIndex = 14;
            this.btnSingleFile.Text = "Single file";
            this.btnSingleFile.UseVisualStyleBackColor = false;
            // 
            // btnAddLeft
            // 
            this.btnAddLeft.BackColor = System.Drawing.Color.LightGray;
            this.btnAddLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLeft.Location = new System.Drawing.Point(584, 376);
            this.btnAddLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLeft.Name = "btnAddLeft";
            this.btnAddLeft.Size = new System.Drawing.Size(199, 54);
            this.btnAddLeft.TabIndex = 15;
            this.btnAddLeft.Text = "<-";
            this.btnAddLeft.UseVisualStyleBackColor = false;
            // 
            // btnAddToTheRight
            // 
            this.btnAddToTheRight.BackColor = System.Drawing.Color.LightGray;
            this.btnAddToTheRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToTheRight.Location = new System.Drawing.Point(791, 376);
            this.btnAddToTheRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToTheRight.Name = "btnAddToTheRight";
            this.btnAddToTheRight.Size = new System.Drawing.Size(199, 54);
            this.btnAddToTheRight.TabIndex = 16;
            this.btnAddToTheRight.Text = "->";
            this.btnAddToTheRight.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 488);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "DIFF";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddToTheRight);
            this.Controls.Add(this.btnAddLeft);
            this.Controls.Add(this.btnSingleFile);
            this.Controls.Add(this.btnGetStoredFiles);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.dgvDados);
            this.Name = "btnDiff";
            this.Text = "JSON Diff";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Button btnGetStoredFiles;
        private System.Windows.Forms.Button btnSingleFile;
        private System.Windows.Forms.Button btnAddLeft;
        private System.Windows.Forms.Button btnAddToTheRight;
        private System.Windows.Forms.Button button1;
    }
}

