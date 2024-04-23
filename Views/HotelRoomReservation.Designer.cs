namespace HotelSelect
{
    partial class HotelRoomReservation
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
            this.ComBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.ComBoxCity = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.ComBoxNameHotel = new System.Windows.Forms.ComboBox();
            this.labelNameHotel = new System.Windows.Forms.Label();
            this.numericRoom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPriceBefore = new System.Windows.Forms.TextBox();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.labelPriceFrom = new System.Windows.Forms.Label();
            this.labelPriceBofore = new System.Windows.Forms.Label();
            this.buttonSearh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBefore = new System.Windows.Forms.DateTimePicker();
            this.labelDataFrom = new System.Windows.Forms.Label();
            this.labelDataBefore = new System.Windows.Forms.Label();
            this.dataGridBoardInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBoardInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // ComBoxCountry
            // 
            this.ComBoxCountry.FormattingEnabled = true;
            this.ComBoxCountry.Location = new System.Drawing.Point(12, 26);
            this.ComBoxCountry.Name = "ComBoxCountry";
            this.ComBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.ComBoxCountry.TabIndex = 0;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(158, 31);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 1;
            this.labelCountry.Text = "Страна";
            // 
            // ComBoxCity
            // 
            this.ComBoxCity.FormattingEnabled = true;
            this.ComBoxCity.Location = new System.Drawing.Point(12, 67);
            this.ComBoxCity.Name = "ComBoxCity";
            this.ComBoxCity.Size = new System.Drawing.Size(121, 21);
            this.ComBoxCity.TabIndex = 2;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(158, 72);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(37, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "Город";
            // 
            // ComBoxNameHotel
            // 
            this.ComBoxNameHotel.FormattingEnabled = true;
            this.ComBoxNameHotel.Location = new System.Drawing.Point(12, 107);
            this.ComBoxNameHotel.Name = "ComBoxNameHotel";
            this.ComBoxNameHotel.Size = new System.Drawing.Size(121, 21);
            this.ComBoxNameHotel.TabIndex = 4;
            // 
            // labelNameHotel
            // 
            this.labelNameHotel.AutoSize = true;
            this.labelNameHotel.Location = new System.Drawing.Point(158, 110);
            this.labelNameHotel.Name = "labelNameHotel";
            this.labelNameHotel.Size = new System.Drawing.Size(89, 13);
            this.labelNameHotel.TabIndex = 5;
            this.labelNameHotel.Text = "Название отеля";
            // 
            // numericRoom
            // 
            this.numericRoom.Location = new System.Drawing.Point(13, 145);
            this.numericRoom.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRoom.Name = "numericRoom";
            this.numericRoom.Size = new System.Drawing.Size(120, 20);
            this.numericRoom.TabIndex = 6;
            this.numericRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество комнат";
            // 
            // textBoxPriceBefore
            // 
            this.textBoxPriceBefore.Location = new System.Drawing.Point(12, 303);
            this.textBoxPriceBefore.Name = "textBoxPriceBefore";
            this.textBoxPriceBefore.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceBefore.TabIndex = 8;
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.Location = new System.Drawing.Point(12, 263);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceFrom.TabIndex = 9;
            // 
            // labelPriceFrom
            // 
            this.labelPriceFrom.AutoSize = true;
            this.labelPriceFrom.Location = new System.Drawing.Point(160, 266);
            this.labelPriceFrom.Name = "labelPriceFrom";
            this.labelPriceFrom.Size = new System.Drawing.Size(47, 13);
            this.labelPriceFrom.TabIndex = 10;
            this.labelPriceFrom.Text = "Цена от";
            // 
            // labelPriceBofore
            // 
            this.labelPriceBofore.AutoSize = true;
            this.labelPriceBofore.Location = new System.Drawing.Point(161, 303);
            this.labelPriceBofore.Name = "labelPriceBofore";
            this.labelPriceBofore.Size = new System.Drawing.Size(48, 13);
            this.labelPriceBofore.TabIndex = 11;
            this.labelPriceBofore.Text = "Цена до";
            // 
            // buttonSearh
            // 
            this.buttonSearh.Location = new System.Drawing.Point(12, 344);
            this.buttonSearh.Name = "buttonSearh";
            this.buttonSearh.Size = new System.Drawing.Size(92, 40);
            this.buttonSearh.TabIndex = 12;
            this.buttonSearh.Text = "Поиск номеров";
            this.buttonSearh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Бронировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(13, 184);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(120, 20);
            this.dateTimeFrom.TabIndex = 14;
            // 
            // dateTimeBefore
            // 
            this.dateTimeBefore.Location = new System.Drawing.Point(12, 222);
            this.dateTimeBefore.Name = "dateTimeBefore";
            this.dateTimeBefore.Size = new System.Drawing.Size(120, 20);
            this.dateTimeBefore.TabIndex = 15;
            // 
            // labelDataFrom
            // 
            this.labelDataFrom.AutoSize = true;
            this.labelDataFrom.Location = new System.Drawing.Point(161, 191);
            this.labelDataFrom.Name = "labelDataFrom";
            this.labelDataFrom.Size = new System.Drawing.Size(47, 13);
            this.labelDataFrom.TabIndex = 16;
            this.labelDataFrom.Text = "Дата от";
            // 
            // labelDataBefore
            // 
            this.labelDataBefore.AutoSize = true;
            this.labelDataBefore.Location = new System.Drawing.Point(161, 228);
            this.labelDataBefore.Name = "labelDataBefore";
            this.labelDataBefore.Size = new System.Drawing.Size(48, 13);
            this.labelDataBefore.TabIndex = 17;
            this.labelDataBefore.Text = "Дата до";
            // 
            // dataGridBoardInfo
            // 
            this.dataGridBoardInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBoardInfo.Location = new System.Drawing.Point(424, 15);
            this.dataGridBoardInfo.Name = "dataGridBoardInfo";
            this.dataGridBoardInfo.Size = new System.Drawing.Size(332, 178);
            this.dataGridBoardInfo.TabIndex = 18;
            // 
            // Reserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridBoardInfo);
            this.Controls.Add(this.labelDataBefore);
            this.Controls.Add(this.labelDataFrom);
            this.Controls.Add(this.dateTimeBefore);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSearh);
            this.Controls.Add(this.labelPriceBofore);
            this.Controls.Add(this.labelPriceFrom);
            this.Controls.Add(this.textBoxPriceFrom);
            this.Controls.Add(this.textBoxPriceBefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericRoom);
            this.Controls.Add(this.labelNameHotel);
            this.Controls.Add(this.ComBoxNameHotel);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.ComBoxCity);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.ComBoxCountry);
            this.Name = "Reserv";
            this.Text = "Бронирование номера";
            ((System.ComponentModel.ISupportInitialize)(this.numericRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBoardInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox ComBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.ComboBox ComBoxNameHotel;
        private System.Windows.Forms.Label labelNameHotel;
        private System.Windows.Forms.NumericUpDown numericRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPriceBefore;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.Label labelPriceFrom;
        private System.Windows.Forms.Label labelPriceBofore;
        private System.Windows.Forms.Button buttonSearh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimeBefore;
        private System.Windows.Forms.Label labelDataFrom;
        private System.Windows.Forms.Label labelDataBefore;
        private System.Windows.Forms.DataGridView dataGridBoardInfo;
    }
}