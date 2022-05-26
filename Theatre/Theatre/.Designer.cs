
namespace Theatre
{
    partial class Add_event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_event));
            this.typeEvent = new System.Windows.Forms.ComboBox();
            this.nameEvent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.actorEvent = new System.Windows.Forms.TextBox();
            this.numberPlaces = new System.Windows.Forms.TextBox();
            this.ticket = new System.Windows.Forms.TextBox();
            this.button_event_add = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.raiting = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // typeEvent
            // 
            this.typeEvent.AutoCompleteCustomSource.AddRange(new string[] {
            "спектакль",
            "концерт"});
            this.typeEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.typeEvent.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeEvent.FormattingEnabled = true;
            this.typeEvent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.typeEvent.Items.AddRange(new object[] {
            "спектакль",
            "концерт"});
            this.typeEvent.Location = new System.Drawing.Point(258, 169);
            this.typeEvent.MaxDropDownItems = 2;
            this.typeEvent.Name = "typeEvent";
            this.typeEvent.Size = new System.Drawing.Size(232, 28);
            this.typeEvent.TabIndex = 22;
            this.typeEvent.Click += new System.EventHandler(this.Control_Click);
            // 
            // nameEvent
            // 
            this.nameEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameEvent.Location = new System.Drawing.Point(258, 114);
            this.nameEvent.Name = "nameEvent";
            this.nameEvent.Size = new System.Drawing.Size(232, 26);
            this.nameEvent.TabIndex = 20;
            this.nameEvent.Click += new System.EventHandler(this.Control_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название мероприятия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Тип мероприятия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Количество актёров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Количество мест";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Цена билета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Рейтинг";
            // 
            // actorEvent
            // 
            this.actorEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.actorEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actorEvent.Location = new System.Drawing.Point(258, 228);
            this.actorEvent.Name = "actorEvent";
            this.actorEvent.Size = new System.Drawing.Size(232, 26);
            this.actorEvent.TabIndex = 31;
            this.actorEvent.Click += new System.EventHandler(this.Control_Click);
            // 
            // numberPlaces
            // 
            this.numberPlaces.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numberPlaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberPlaces.Location = new System.Drawing.Point(258, 294);
            this.numberPlaces.Name = "numberPlaces";
            this.numberPlaces.Size = new System.Drawing.Size(232, 26);
            this.numberPlaces.TabIndex = 32;
            this.numberPlaces.Click += new System.EventHandler(this.Control_Click);
            // 
            // ticket
            // 
            this.ticket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ticket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticket.Location = new System.Drawing.Point(258, 354);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(232, 26);
            this.ticket.TabIndex = 33;
            this.ticket.Click += new System.EventHandler(this.Control_Click);
            // 
            // button_event_add
            // 
            this.button_event_add.BackColor = System.Drawing.Color.Gold;
            this.button_event_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_add.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_event_add.Location = new System.Drawing.Point(87, 491);
            this.button_event_add.Name = "button_event_add";
            this.button_event_add.Size = new System.Drawing.Size(137, 38);
            this.button_event_add.TabIndex = 35;
            this.button_event_add.Text = "Добавить";
            this.button_event_add.UseVisualStyleBackColor = false;
            this.button_event_add.Click += new System.EventHandler(this.button_event_add_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Gold;
            this.button_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(284, 491);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(137, 38);
            this.button_back.TabIndex = 36;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(153, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 32);
            this.label6.TabIndex = 42;
            this.label6.Text = "Добавление мероприятия";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // raiting
            // 
            this.raiting.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.raiting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.raiting.Cursor = System.Windows.Forms.Cursors.Default;
            this.raiting.DropDownHeight = 40;
            this.raiting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raiting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.raiting.FormattingEnabled = true;
            this.raiting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.raiting.IntegralHeight = false;
            this.raiting.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.raiting.Location = new System.Drawing.Point(258, 414);
            this.raiting.MaxDropDownItems = 2;
            this.raiting.Name = "raiting";
            this.raiting.Size = new System.Drawing.Size(232, 28);
            this.raiting.TabIndex = 54;
            this.raiting.Click += new System.EventHandler(this.Control_Click);
            // 
            // Add_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.button_back;
            this.ClientSize = new System.Drawing.Size(527, 593);
            this.ControlBox = false;
            this.Controls.Add(this.raiting);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_event_add);
            this.Controls.Add(this.ticket);
            this.Controls.Add(this.numberPlaces);
            this.Controls.Add(this.actorEvent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeEvent);
            this.Controls.Add(this.nameEvent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление мероприятия";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox typeEvent;
        public System.Windows.Forms.TextBox nameEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox actorEvent;
        public System.Windows.Forms.TextBox numberPlaces;
        public System.Windows.Forms.TextBox ticket;
        private System.Windows.Forms.Button button_event_add;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox raiting;
    }
}