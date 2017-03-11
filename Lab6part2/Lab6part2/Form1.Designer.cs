namespace Lab6part2
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
            this.GenerationObjects = new System.Windows.Forms.Button();
            this.MyCollectionListBox = new System.Windows.Forms.ListBox();
            this.SortCollectionASC = new System.Windows.Forms.Button();
            this.SortCollectionDESC = new System.Windows.Forms.Button();
            this.ResultSortingAndQueries = new System.Windows.Forms.ListBox();
            this.GenerationObjectHowMany = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerationObjects
            // 
            this.GenerationObjects.Location = new System.Drawing.Point(12, 13);
            this.GenerationObjects.Name = "GenerationObjects";
            this.GenerationObjects.Size = new System.Drawing.Size(179, 59);
            this.GenerationObjects.TabIndex = 0;
            this.GenerationObjects.Text = "GenerationObjects";
            this.GenerationObjects.UseVisualStyleBackColor = true;
            // 
            // MyCollectionListBox
            // 
            this.MyCollectionListBox.FormattingEnabled = true;
            this.MyCollectionListBox.ItemHeight = 16;
            this.MyCollectionListBox.Location = new System.Drawing.Point(235, 12);
            this.MyCollectionListBox.Name = "MyCollectionListBox";
            this.MyCollectionListBox.Size = new System.Drawing.Size(253, 500);
            this.MyCollectionListBox.TabIndex = 1;
            // 
            // SortCollectionASC
            // 
            this.SortCollectionASC.Location = new System.Drawing.Point(235, 518);
            this.SortCollectionASC.Name = "SortCollectionASC";
            this.SortCollectionASC.Size = new System.Drawing.Size(128, 23);
            this.SortCollectionASC.TabIndex = 3;
            this.SortCollectionASC.Text = "Asc";
            this.SortCollectionASC.UseVisualStyleBackColor = true;
            // 
            // SortCollectionDESC
            // 
            this.SortCollectionDESC.Location = new System.Drawing.Point(369, 518);
            this.SortCollectionDESC.Name = "SortCollectionDESC";
            this.SortCollectionDESC.Size = new System.Drawing.Size(119, 23);
            this.SortCollectionDESC.TabIndex = 4;
            this.SortCollectionDESC.Text = "Desc";
            this.SortCollectionDESC.UseVisualStyleBackColor = true;
            // 
            // ResultSortingAndQueries
            // 
            this.ResultSortingAndQueries.FormattingEnabled = true;
            this.ResultSortingAndQueries.ItemHeight = 16;
            this.ResultSortingAndQueries.Location = new System.Drawing.Point(618, 13);
            this.ResultSortingAndQueries.Name = "ResultSortingAndQueries";
            this.ResultSortingAndQueries.Size = new System.Drawing.Size(253, 500);
            this.ResultSortingAndQueries.TabIndex = 5;
            // 
            // GenerationObjectHowMany
            // 
            this.GenerationObjectHowMany.Location = new System.Drawing.Point(12, 97);
            this.GenerationObjectHowMany.Name = "GenerationObjectHowMany";
            this.GenerationObjectHowMany.Size = new System.Drawing.Size(179, 22);
            this.GenerationObjectHowMany.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "линк 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Линк2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Линк3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 542);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenerationObjectHowMany);
            this.Controls.Add(this.ResultSortingAndQueries);
            this.Controls.Add(this.SortCollectionDESC);
            this.Controls.Add(this.SortCollectionASC);
            this.Controls.Add(this.MyCollectionListBox);
            this.Controls.Add(this.GenerationObjects);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerationObjects;
        private System.Windows.Forms.ListBox MyCollectionListBox;
        private System.Windows.Forms.Button SortCollectionASC;
        private System.Windows.Forms.Button SortCollectionDESC;
        private System.Windows.Forms.ListBox ResultSortingAndQueries;
        private System.Windows.Forms.TextBox GenerationObjectHowMany;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

