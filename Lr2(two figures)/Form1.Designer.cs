namespace GrapphicsPartOfLr2_graphics_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lengthReader = new System.Windows.Forms.TextBox();
            this.cordMatrixReader = new System.Windows.Forms.DataGridView();
            this.lengthApplyButton = new System.Windows.Forms.Button();
            this.rotationCoefReader = new System.Windows.Forms.TextBox();
            this.OxCoefreader = new System.Windows.Forms.TextBox();
            this.xyReader = new System.Windows.Forms.TextBox();
            this.oyCoefReader = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.drawArea = new System.Windows.Forms.PictureBox();
            this.cordMatrixReader2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthReader2 = new System.Windows.Forms.TextBox();
            this.lengthApplyButton2 = new System.Windows.Forms.Button();
            this.rotationCoefReader2 = new System.Windows.Forms.TextBox();
            this.OxCoefreader2 = new System.Windows.Forms.TextBox();
            this.xyReader2 = new System.Windows.Forms.TextBox();
            this.oyCoefReader2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sceneXReader = new System.Windows.Forms.TextBox();
            this.sceneYReader = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cordMatrixReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cordMatrixReader2)).BeginInit();
            this.SuspendLayout();
            // 
            // lengthReader
            // 
            this.lengthReader.Location = new System.Drawing.Point(3, 26);
            this.lengthReader.Name = "lengthReader";
            this.lengthReader.Size = new System.Drawing.Size(100, 20);
            this.lengthReader.TabIndex = 0;
            this.lengthReader.Text = "Input rows count";
            // 
            // cordMatrixReader
            // 
            this.cordMatrixReader.AllowUserToAddRows = false;
            this.cordMatrixReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cordMatrixReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.cordMatrixReader.Location = new System.Drawing.Point(3, 81);
            this.cordMatrixReader.Name = "cordMatrixReader";
            this.cordMatrixReader.Size = new System.Drawing.Size(109, 467);
            this.cordMatrixReader.TabIndex = 1;
            this.cordMatrixReader.Visible = false;
            this.cordMatrixReader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cordMatrixReader_CellContentClick);
            // 
            // lengthApplyButton
            // 
            this.lengthApplyButton.Location = new System.Drawing.Point(3, 52);
            this.lengthApplyButton.Name = "lengthApplyButton";
            this.lengthApplyButton.Size = new System.Drawing.Size(100, 23);
            this.lengthApplyButton.TabIndex = 2;
            this.lengthApplyButton.Text = "Done";
            this.lengthApplyButton.UseVisualStyleBackColor = true;
            this.lengthApplyButton.Click += new System.EventHandler(this.lengthApplyButton_Click);
            // 
            // rotationCoefReader
            // 
            this.rotationCoefReader.Location = new System.Drawing.Point(3, 554);
            this.rotationCoefReader.Name = "rotationCoefReader";
            this.rotationCoefReader.Size = new System.Drawing.Size(90, 20);
            this.rotationCoefReader.TabIndex = 3;
            this.rotationCoefReader.Text = "Input discret rotation angle";
            // 
            // OxCoefreader
            // 
            this.OxCoefreader.Location = new System.Drawing.Point(3, 582);
            this.OxCoefreader.Name = "OxCoefreader";
            this.OxCoefreader.Size = new System.Drawing.Size(90, 20);
            this.OxCoefreader.TabIndex = 4;
            this.OxCoefreader.Text = "Imput ox coef";
            // 
            // xyReader
            // 
            this.xyReader.Location = new System.Drawing.Point(3, 608);
            this.xyReader.Name = "xyReader";
            this.xyReader.Size = new System.Drawing.Size(90, 20);
            this.xyReader.TabIndex = 5;
            this.xyReader.Text = "Input xy coef ";
            // 
            // oyCoefReader
            // 
            this.oyCoefReader.Location = new System.Drawing.Point(3, 634);
            this.oyCoefReader.Name = "oyCoefReader";
            this.oyCoefReader.Size = new System.Drawing.Size(90, 20);
            this.oyCoefReader.TabIndex = 6;
            this.oyCoefReader.Text = "Input oy coef ";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(235, 3);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(99, 34);
            this.drawButton.TabIndex = 7;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // drawArea
            // 
            this.drawArea.Enabled = false;
            this.drawArea.Location = new System.Drawing.Point(235, 43);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(918, 611);
            this.drawArea.TabIndex = 8;
            this.drawArea.TabStop = false;
            this.drawArea.Visible = false;
            this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawArea_Paint);
            // 
            // cordMatrixReader2
            // 
            this.cordMatrixReader2.AllowUserToAddRows = false;
            this.cordMatrixReader2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cordMatrixReader2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cordMatrixReader2.Location = new System.Drawing.Point(118, 81);
            this.cordMatrixReader2.Name = "cordMatrixReader2";
            this.cordMatrixReader2.Size = new System.Drawing.Size(110, 467);
            this.cordMatrixReader2.TabIndex = 9;
            this.cordMatrixReader2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 35;
            // 
            // lengthReader2
            // 
            this.lengthReader2.Location = new System.Drawing.Point(118, 26);
            this.lengthReader2.Name = "lengthReader2";
            this.lengthReader2.Size = new System.Drawing.Size(100, 20);
            this.lengthReader2.TabIndex = 10;
            this.lengthReader2.Text = "Input rows count";
            // 
            // lengthApplyButton2
            // 
            this.lengthApplyButton2.Location = new System.Drawing.Point(118, 52);
            this.lengthApplyButton2.Name = "lengthApplyButton2";
            this.lengthApplyButton2.Size = new System.Drawing.Size(100, 23);
            this.lengthApplyButton2.TabIndex = 11;
            this.lengthApplyButton2.Text = "Done";
            this.lengthApplyButton2.UseVisualStyleBackColor = true;
            // 
            // rotationCoefReader2
            // 
            this.rotationCoefReader2.Location = new System.Drawing.Point(118, 554);
            this.rotationCoefReader2.Name = "rotationCoefReader2";
            this.rotationCoefReader2.Size = new System.Drawing.Size(90, 20);
            this.rotationCoefReader2.TabIndex = 12;
            this.rotationCoefReader2.Text = "Input discret rotation angle";
            // 
            // OxCoefreader2
            // 
            this.OxCoefreader2.Location = new System.Drawing.Point(118, 582);
            this.OxCoefreader2.Name = "OxCoefreader2";
            this.OxCoefreader2.Size = new System.Drawing.Size(90, 20);
            this.OxCoefreader2.TabIndex = 13;
            this.OxCoefreader2.Text = "Imput ox coef";
            // 
            // xyReader2
            // 
            this.xyReader2.Location = new System.Drawing.Point(118, 608);
            this.xyReader2.Name = "xyReader2";
            this.xyReader2.Size = new System.Drawing.Size(90, 20);
            this.xyReader2.TabIndex = 14;
            this.xyReader2.Text = "Input xy coef ";
            // 
            // oyCoefReader2
            // 
            this.oyCoefReader2.Location = new System.Drawing.Point(118, 634);
            this.oyCoefReader2.Name = "oyCoefReader2";
            this.oyCoefReader2.Size = new System.Drawing.Size(90, 20);
            this.oyCoefReader2.TabIndex = 15;
            this.oyCoefReader2.Text = "Input oy coef ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите смещение сцены ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sceneXReader
            // 
            this.sceneXReader.Location = new System.Drawing.Point(520, 11);
            this.sceneXReader.Name = "sceneXReader";
            this.sceneXReader.Size = new System.Drawing.Size(100, 20);
            this.sceneXReader.TabIndex = 17;
            this.sceneXReader.Text = "X";
            // 
            // sceneYReader
            // 
            this.sceneYReader.Location = new System.Drawing.Point(626, 11);
            this.sceneYReader.Name = "sceneYReader";
            this.sceneYReader.Size = new System.Drawing.Size(100, 20);
            this.sceneYReader.TabIndex = 18;
            this.sceneYReader.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 658);
            this.Controls.Add(this.sceneYReader);
            this.Controls.Add(this.sceneXReader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oyCoefReader2);
            this.Controls.Add(this.xyReader2);
            this.Controls.Add(this.OxCoefreader2);
            this.Controls.Add(this.rotationCoefReader2);
            this.Controls.Add(this.lengthApplyButton2);
            this.Controls.Add(this.lengthReader2);
            this.Controls.Add(this.cordMatrixReader2);
            this.Controls.Add(this.drawArea);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.oyCoefReader);
            this.Controls.Add(this.xyReader);
            this.Controls.Add(this.OxCoefreader);
            this.Controls.Add(this.rotationCoefReader);
            this.Controls.Add(this.lengthApplyButton);
            this.Controls.Add(this.cordMatrixReader);
            this.Controls.Add(this.lengthReader);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cordMatrixReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cordMatrixReader2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lengthReader;
        private System.Windows.Forms.DataGridView cordMatrixReader;
        private System.Windows.Forms.Button lengthApplyButton;
        private System.Windows.Forms.TextBox rotationCoefReader;
        private System.Windows.Forms.TextBox OxCoefreader;
        private System.Windows.Forms.TextBox xyReader;
        private System.Windows.Forms.TextBox oyCoefReader;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.PictureBox drawArea;
        private System.Windows.Forms.DataGridView cordMatrixReader2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox lengthReader2;
        private System.Windows.Forms.Button lengthApplyButton2;
        private System.Windows.Forms.TextBox rotationCoefReader2;
        private System.Windows.Forms.TextBox OxCoefreader2;
        private System.Windows.Forms.TextBox xyReader2;
        private System.Windows.Forms.TextBox oyCoefReader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sceneXReader;
        private System.Windows.Forms.TextBox sceneYReader;
    }
}

