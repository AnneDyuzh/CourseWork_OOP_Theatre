
namespace Theatre
{
    partial class Add_actor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_actor));
            this.age = new System.Windows.Forms.TextBox();
            this.raiting = new System.Windows.Forms.ComboBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_event_add = new System.Windows.Forms.Button();
            this.work = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.actor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age.Location = new System.Drawing.Point(222, 197);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(254, 26);
            this.age.TabIndex = 82;
            this.age.Click += new System.EventHandler(this.Control_Click);
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
            this.raiting.Location = new System.Drawing.Point(222, 348);
            this.raiting.MaxDropDownItems = 2;
            this.raiting.Name = "raiting";
            this.raiting.Size = new System.Drawing.Size(254, 28);
            this.raiting.TabIndex = 81;
            this.raiting.Click += new System.EventHandler(this.Control_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Gold;
            this.button_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(289, 426);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(137, 38);
            this.button_back.TabIndex = 80;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_event_add
            // 
            this.button_event_add.BackColor = System.Drawing.Color.Gold;
            this.button_event_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_add.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_event_add.Location = new System.Drawing.Point(92, 426);
            this.button_event_add.Name = "button_event_add";
            this.button_event_add.Size = new System.Drawing.Size(137, 38);
            this.button_event_add.TabIndex = 79;
            this.button_event_add.Text = "Добавить";
            this.button_event_add.UseVisualStyleBackColor = false;
            this.button_event_add.Click += new System.EventHandler(this.button_event_change_Click);
            // 
            // work
            // 
            this.work.BackColor = System.Drawing.Color.WhiteSmoke;
            this.work.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.work.Location = new System.Drawing.Point(222, 273);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(254, 26);
            this.work.TabIndex = 78;
            this.work.Click += new System.EventHandler(this.Control_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "Рейтинг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "Стаж";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "Возраст";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(102, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(195, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 29);
            this.label6.TabIndex = 73;
            this.label6.Text = "Добавление актёра";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // actor
            // 
            this.actor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.actor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actor.Location = new System.Drawing.Point(222, 120);
            this.actor.Name = "actor";
            this.actor.Size = new System.Drawing.Size(254, 26);
            this.actor.TabIndex = 72;
            this.actor.Click += new System.EventHandler(this.Control_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "ФИО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(34, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.LightCoral;
            this.label7.Location = new System.Drawing.Point(34, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.Location = new System.Drawing.Point(37, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 85;
            // 
            // Add_actor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.button_back;
            this.ClientSize = new System.Drawing.Size(527, 523);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.age);
            this.Controls.Add(this.raiting);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_event_add);
            this.Controls.Add(this.work);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.actor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_actor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление актёра";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox age;
        public System.Windows.Forms.ComboBox raiting;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_event_add;
        public System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox actor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}