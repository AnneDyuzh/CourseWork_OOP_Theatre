
namespace Theatre
{
    partial class Actors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actors));
            this.count_of_actors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_delete_all_actor = new System.Windows.Forms.Button();
            this.button_delete_actor = new System.Windows.Forms.Button();
            this.button_add_actor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // count_of_actors
            // 
            this.count_of_actors.AutoSize = true;
            this.count_of_actors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count_of_actors.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_of_actors.Location = new System.Drawing.Point(215, 495);
            this.count_of_actors.Name = "count_of_actors";
            this.count_of_actors.Size = new System.Drawing.Size(18, 22);
            this.count_of_actors.TabIndex = 20;
            this.count_of_actors.Text = "0";
            this.count_of_actors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.count_of_actors.Click += new System.EventHandler(this.count_of_actors_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Количество актёров:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Актёры театра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Teacher,
            this.TitleLesson,
            this.TypeLesson,
            this.Group});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(35, 85);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(855, 383);
            this.dataGridView2.TabIndex = 17;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "ФИО";
            this.Teacher.MinimumWidth = 8;
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            this.Teacher.Width = 175;
            // 
            // TitleLesson
            // 
            this.TitleLesson.HeaderText = "Возраст";
            this.TitleLesson.MinimumWidth = 8;
            this.TitleLesson.Name = "TitleLesson";
            this.TitleLesson.ReadOnly = true;
            this.TitleLesson.Width = 110;
            // 
            // TypeLesson
            // 
            this.TypeLesson.HeaderText = "Стаж";
            this.TypeLesson.MinimumWidth = 8;
            this.TypeLesson.Name = "TypeLesson";
            this.TypeLesson.ReadOnly = true;
            this.TypeLesson.Width = 110;
            // 
            // Group
            // 
            this.Group.HeaderText = "Рейтинг";
            this.Group.MinimumWidth = 8;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 110;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gold;
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.button_delete_all_actor);
            this.panelMenu.Controls.Add(this.button_delete_actor);
            this.panelMenu.Controls.Add(this.button_add_actor);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(930, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(287, 557);
            this.panelMenu.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button_delete_all_actor
            // 
            this.button_delete_all_actor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete_all_actor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete_all_actor.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_all_actor.Location = new System.Drawing.Point(30, 429);
            this.button_delete_all_actor.Name = "button_delete_all_actor";
            this.button_delete_all_actor.Size = new System.Drawing.Size(228, 74);
            this.button_delete_all_actor.TabIndex = 24;
            this.button_delete_all_actor.Text = "Удалить всех актёров";
            this.button_delete_all_actor.UseVisualStyleBackColor = false;
            this.button_delete_all_actor.Click += new System.EventHandler(this.button_delete_all_actor_Click);
            // 
            // button_delete_actor
            // 
            this.button_delete_actor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete_actor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete_actor.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_actor.Location = new System.Drawing.Point(30, 329);
            this.button_delete_actor.Name = "button_delete_actor";
            this.button_delete_actor.Size = new System.Drawing.Size(228, 74);
            this.button_delete_actor.TabIndex = 22;
            this.button_delete_actor.Text = "Удалить одного актёра";
            this.button_delete_actor.UseVisualStyleBackColor = false;
            this.button_delete_actor.Click += new System.EventHandler(this.button_delete_actor_Click);
            // 
            // button_add_actor
            // 
            this.button_add_actor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_add_actor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add_actor.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_actor.Location = new System.Drawing.Point(30, 225);
            this.button_add_actor.Name = "button_add_actor";
            this.button_add_actor.Size = new System.Drawing.Size(228, 75);
            this.button_add_actor.TabIndex = 19;
            this.button_add_actor.Text = "Добавить актёра";
            this.button_add_actor.UseVisualStyleBackColor = false;
            this.button_add_actor.Click += new System.EventHandler(this.button_add_actor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 14;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Gold;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Palatino Linotype", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(804, 488);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(86, 34);
            this.button_back.TabIndex = 21;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1217, 557);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.count_of_actors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Actors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Театр";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count_of_actors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button_delete_all_actor;
        private System.Windows.Forms.Button button_delete_actor;
        private System.Windows.Forms.Button button_add_actor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}