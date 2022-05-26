
namespace Theatre
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button_delete_all = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_no_filtr = new System.Windows.Forms.Button();
            this.button_filtr = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textFiltr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.count_of_events = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.NameEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountActors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gold;
            this.panelMenu.Controls.Add(this.button_delete_all);
            this.panelMenu.Controls.Add(this.button_delete);
            this.panelMenu.Controls.Add(this.button_no_filtr);
            this.panelMenu.Controls.Add(this.button_filtr);
            this.panelMenu.Controls.Add(this.button_add);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.textFiltr);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 402);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1217, 155);
            this.panelMenu.TabIndex = 1;
            // 
            // button_delete_all
            // 
            this.button_delete_all.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete_all.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_all.Location = new System.Drawing.Point(997, 21);
            this.button_delete_all.Name = "button_delete_all";
            this.button_delete_all.Size = new System.Drawing.Size(182, 94);
            this.button_delete_all.TabIndex = 24;
            this.button_delete_all.Text = "Удалить все мероприятия";
            this.button_delete_all.UseVisualStyleBackColor = false;
            this.button_delete_all.Click += new System.EventHandler(this.button_delete_all_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(795, 21);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(177, 94);
            this.button_delete.TabIndex = 22;
            this.button_delete.Text = "Удалить одно мероприятие";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_no_filtr
            // 
            this.button_no_filtr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_no_filtr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_no_filtr.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_no_filtr.Location = new System.Drawing.Point(246, 21);
            this.button_no_filtr.Name = "button_no_filtr";
            this.button_no_filtr.Size = new System.Drawing.Size(207, 94);
            this.button_no_filtr.TabIndex = 21;
            this.button_no_filtr.Text = "Сбросить фильтрацию";
            this.button_no_filtr.UseVisualStyleBackColor = false;
            this.button_no_filtr.Click += new System.EventHandler(this.button_no_filtr_Click);
            // 
            // button_filtr
            // 
            this.button_filtr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_filtr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_filtr.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_filtr.Location = new System.Drawing.Point(472, 67);
            this.button_filtr.Name = "button_filtr";
            this.button_filtr.Size = new System.Drawing.Size(300, 48);
            this.button_filtr.TabIndex = 20;
            this.button_filtr.Text = "Фильтровать по рейтингу";
            this.button_filtr.UseVisualStyleBackColor = false;
            this.button_filtr.Click += new System.EventHandler(this.button_filtr_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(35, 21);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(187, 94);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "Добавить мероприятие";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(30, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 14;
            // 
            // textFiltr
            // 
            this.textFiltr.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFiltr.ForeColor = System.Drawing.Color.Black;
            this.textFiltr.Location = new System.Drawing.Point(472, 21);
            this.textFiltr.Name = "textFiltr";
            this.textFiltr.Size = new System.Drawing.Size(300, 34);
            this.textFiltr.TabIndex = 13;
            this.textFiltr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textFiltr.Click += new System.EventHandler(this.Control_Click);
            this.textFiltr.TextChanged += new System.EventHandler(this.textFiltr_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameEvent,
            this.TypeEvent,
            this.CountActors,
            this.CountTickets,
            this.Price,
            this.Raiting});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(35, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 257);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Мероприятия театра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Количество мероприятий:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // count_of_events
            // 
            this.count_of_events.AutoSize = true;
            this.count_of_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count_of_events.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_of_events.Location = new System.Drawing.Point(265, 358);
            this.count_of_events.Name = "count_of_events";
            this.count_of_events.Size = new System.Drawing.Size(18, 22);
            this.count_of_events.TabIndex = 15;
            this.count_of_events.Text = "0";
            this.count_of_events.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Gold;
            this.button_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Palatino Linotype", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(1093, 351);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(86, 34);
            this.button_back.TabIndex = 20;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // NameEvent
            // 
            this.NameEvent.HeaderText = "Название";
            this.NameEvent.MinimumWidth = 8;
            this.NameEvent.Name = "NameEvent";
            this.NameEvent.ReadOnly = true;
            this.NameEvent.Width = 148;
            // 
            // TypeEvent
            // 
            this.TypeEvent.HeaderText = "Тип мероприятия";
            this.TypeEvent.MinimumWidth = 8;
            this.TypeEvent.Name = "TypeEvent";
            this.TypeEvent.ReadOnly = true;
            this.TypeEvent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeEvent.Width = 130;
            // 
            // CountActors
            // 
            this.CountActors.HeaderText = "Количество актёров";
            this.CountActors.MinimumWidth = 8;
            this.CountActors.Name = "CountActors";
            this.CountActors.ReadOnly = true;
            this.CountActors.Width = 140;
            // 
            // CountTickets
            // 
            this.CountTickets.HeaderText = "Количество мест";
            this.CountTickets.MinimumWidth = 8;
            this.CountTickets.Name = "CountTickets";
            this.CountTickets.ReadOnly = true;
            this.CountTickets.Width = 120;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена билета";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 101;
            // 
            // Raiting
            // 
            this.Raiting.HeaderText = "Рейтинг";
            this.Raiting.MinimumWidth = 8;
            this.Raiting.Name = "Raiting";
            this.Raiting.ReadOnly = true;
            this.Raiting.Width = 60;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.button_back;
            this.ClientSize = new System.Drawing.Size(1217, 557);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.count_of_events);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Театр";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFiltr;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_no_filtr;
        private System.Windows.Forms.Button button_filtr;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete_all;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label count_of_events;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountActors;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raiting;
    }
}