
namespace gggg
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.redakted = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(21, 389);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(120, 61);
            this.add1.TabIndex = 1;
            this.add1.Text = "Добавить(1)";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(387, 389);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 61);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить(1)";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(182, 389);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(111, 61);
            this.del.TabIndex = 2;
            this.del.Text = "Удалить(1)";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.delete_Click);
            // 
            // redakted
            // 
            this.redakted.Location = new System.Drawing.Point(217, 389);
            this.redakted.Name = "redakted";
            this.redakted.Size = new System.Drawing.Size(107, 61);
            this.redakted.TabIndex = 3;
            this.redakted.Text = "Редактировать(1)";
            this.redakted.UseVisualStyleBackColor = true;
            this.redakted.Click += new System.EventHandler(this.redakted_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redakted);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button redakted;
    }
}

