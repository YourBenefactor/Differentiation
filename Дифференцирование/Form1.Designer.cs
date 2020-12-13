
namespace Дифференцирование
{
    partial class FunctionGraphic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionGraphic));
            this.Calculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.TextBox();
            this.FunctionBox = new System.Windows.Forms.ComboBox();
            this.ImageOfFunction = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FunctionsIMG = new System.Windows.Forms.ImageList(this.components);
            this.Table = new System.Windows.Forms.DataGridView();
            this.xValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k0Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k1Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k3Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Graphic = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 184);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(278, 40);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.FunctionBox);
            this.panel1.Controls.Add(this.ImageOfFunction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 166);
            this.panel1.TabIndex = 1;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(27, 89);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(219, 63);
            this.Info.TabIndex = 3;
            // 
            // FunctionBox
            // 
            this.FunctionBox.FormattingEnabled = true;
            this.FunctionBox.Items.AddRange(new object[] {
            "Функция №1",
            "Функция №2",
            "Функция №3",
            "Функция №4",
            "Функция №5"});
            this.FunctionBox.Location = new System.Drawing.Point(122, 8);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(143, 21);
            this.FunctionBox.TabIndex = 0;
            this.FunctionBox.SelectedIndexChanged += new System.EventHandler(this.FunctionBox_SelectedIndexChanged);
            // 
            // ImageOfFunction
            // 
            this.ImageOfFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImageOfFunction.Location = new System.Drawing.Point(63, 35);
            this.ImageOfFunction.MaximumSize = new System.Drawing.Size(151, 48);
            this.ImageOfFunction.MinimumSize = new System.Drawing.Size(151, 48);
            this.ImageOfFunction.Name = "ImageOfFunction";
            this.ImageOfFunction.Size = new System.Drawing.Size(151, 48);
            this.ImageOfFunction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageOfFunction.TabIndex = 2;
            this.ImageOfFunction.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбирете функцию:";
            // 
            // FunctionsIMG
            // 
            this.FunctionsIMG.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FunctionsIMG.ImageStream")));
            this.FunctionsIMG.TransparentColor = System.Drawing.Color.Transparent;
            this.FunctionsIMG.Images.SetKeyName(0, "Function1.png");
            this.FunctionsIMG.Images.SetKeyName(1, "Function2.PNG");
            this.FunctionsIMG.Images.SetKeyName(2, "Function3.PNG");
            this.FunctionsIMG.Images.SetKeyName(3, "Function4.PNG");
            this.FunctionsIMG.Images.SetKeyName(4, "Function5.PNG");
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xValue,
            this.k0Value,
            this.k1Value,
            this.k2Value,
            this.k3Value,
            this.yValue});
            this.Table.Location = new System.Drawing.Point(296, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(380, 212);
            this.Table.TabIndex = 2;
            // 
            // xValue
            // 
            this.xValue.HeaderText = "X";
            this.xValue.Name = "xValue";
            // 
            // k0Value
            // 
            this.k0Value.HeaderText = "k0";
            this.k0Value.Name = "k0Value";
            // 
            // k1Value
            // 
            this.k1Value.HeaderText = "k1";
            this.k1Value.Name = "k1Value";
            // 
            // k2Value
            // 
            this.k2Value.HeaderText = "k2";
            this.k2Value.Name = "k2Value";
            // 
            // k3Value
            // 
            this.k3Value.HeaderText = "k3";
            this.k3Value.Name = "k3Value";
            // 
            // yValue
            // 
            this.yValue.HeaderText = "Y";
            this.yValue.Name = "yValue";
            // 
            // Graphic
            // 
            this.Graphic.Location = new System.Drawing.Point(12, 230);
            this.Graphic.Name = "Graphic";
            this.Graphic.Size = new System.Drawing.Size(664, 202);
            this.Graphic.TabIndex = 3;
            // 
            // FunctionGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 436);
            this.Controls.Add(this.Graphic);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FunctionGraphic";
            this.Text = "Дифференцирование";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.PictureBox ImageOfFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FunctionBox;
        private System.Windows.Forms.ImageList FunctionsIMG;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn xValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn k0Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn k1Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn k3Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn yValue;
        private LiveCharts.WinForms.CartesianChart Graphic;
    }
}

