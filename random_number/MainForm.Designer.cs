namespace random_number
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpShow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.btnShowList);
            this.panel1.Controls.Add(this.btnAddToList);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.tbxQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxFrom);
            this.panel1.Controls.Add(this.lbFrom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 90);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Courier Prime", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(365, 45);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 42);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowList.Font = new System.Drawing.Font("Courier Prime", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(234, 45);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(125, 42);
            this.btnShowList.TabIndex = 11;
            this.btnShowList.Text = "show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.White;
            this.btnAddToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToList.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddToList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddToList.Font = new System.Drawing.Font("Courier Prime", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.Location = new System.Drawing.Point(85, 45);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(143, 42);
            this.btnAddToList.TabIndex = 10;
            this.btnAddToList.Text = "Add to list";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Courier Prime", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(3, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 42);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("Courier Prime", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(436, 10);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(48, 29);
            this.tbxQuantity.TabIndex = 7;
            this.tbxQuantity.Text = "1";
            this.tbxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // tbxTo
            // 
            this.tbxTo.Font = new System.Drawing.Font("Courier Prime", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTo.Location = new System.Drawing.Point(233, 10);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(100, 29);
            this.tbxTo.TabIndex = 5;
            this.tbxTo.Text = "1";
            this.tbxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "To";
            // 
            // tbxFrom
            // 
            this.tbxFrom.Font = new System.Drawing.Font("Courier Prime", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFrom.Location = new System.Drawing.Point(82, 10);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(100, 29);
            this.tbxFrom.TabIndex = 3;
            this.tbxFrom.Text = "0";
            this.tbxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Courier Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(17, 15);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(50, 21);
            this.lbFrom.TabIndex = 2;
            this.lbFrom.Text = "From";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(71, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // flpShow
            // 
            this.flpShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpShow.AutoScroll = true;
            this.flpShow.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.flpShow.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.flpShow.BackColor = System.Drawing.Color.White;
            this.flpShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flpShow.Location = new System.Drawing.Point(15, 96);
            this.flpShow.Name = "flpShow";
            this.flpShow.Padding = new System.Windows.Forms.Padding(10);
            this.flpShow.Size = new System.Drawing.Size(469, 226);
            this.flpShow.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 334);
            this.Controls.Add(this.flpShow);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(513, 700);
            this.MinimumSize = new System.Drawing.Size(513, 311);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.FlowLayoutPanel flpShow;
        private System.Windows.Forms.Button btnShowList;
    }
}

