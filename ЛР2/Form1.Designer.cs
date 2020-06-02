namespace ЛР2
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
            this.FieldTB = new System.Windows.Forms.TextBox();
            this.FieldRTB = new System.Windows.Forms.RichTextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.ReplaceTB = new System.Windows.Forms.TextBox();
            this.ReplaceBTN = new System.Windows.Forms.Button();
            this.ReplaceAnswerTB = new System.Windows.Forms.TextBox();
            this.ReversBTN = new System.Windows.Forms.Button();
            this.EditorRTB = new System.Windows.Forms.RichTextBox();
            this.ReversTB = new System.Windows.Forms.TextBox();
            this.ReplaceFromEditorTB = new System.Windows.Forms.TextBox();
            this.ReplaceEditorBTN = new System.Windows.Forms.Button();
            this.ReplaceToEditorTB = new System.Windows.Forms.TextBox();
            this.FindEditorTB = new System.Windows.Forms.TextBox();
            this.FindEditorBTN = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ReplaceEditorFirstTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FieldTB
            // 
            this.FieldTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FieldTB.Location = new System.Drawing.Point(12, 12);
            this.FieldTB.Name = "FieldTB";
            this.FieldTB.Size = new System.Drawing.Size(323, 26);
            this.FieldTB.TabIndex = 0;
            this.FieldTB.Text = "5D0";
            // 
            // FieldRTB
            // 
            this.FieldRTB.Location = new System.Drawing.Point(12, 44);
            this.FieldRTB.Name = "FieldRTB";
            this.FieldRTB.Size = new System.Drawing.Size(323, 125);
            this.FieldRTB.TabIndex = 1;
            this.FieldRTB.Text = "";
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(341, 12);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(130, 77);
            this.SearchBTN.TabIndex = 2;
            this.SearchBTN.Text = "Найти";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Location = new System.Drawing.Point(341, 95);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(130, 77);
            this.ClearBTN.TabIndex = 3;
            this.ClearBTN.Text = "Очистить";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // ReplaceTB
            // 
            this.ReplaceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceTB.Location = new System.Drawing.Point(12, 175);
            this.ReplaceTB.Name = "ReplaceTB";
            this.ReplaceTB.Size = new System.Drawing.Size(323, 26);
            this.ReplaceTB.TabIndex = 4;
            this.ReplaceTB.Text = "Defg";
            // 
            // ReplaceBTN
            // 
            this.ReplaceBTN.Location = new System.Drawing.Point(341, 175);
            this.ReplaceBTN.Name = "ReplaceBTN";
            this.ReplaceBTN.Size = new System.Drawing.Size(130, 26);
            this.ReplaceBTN.TabIndex = 5;
            this.ReplaceBTN.Text = "Заменить";
            this.ReplaceBTN.UseVisualStyleBackColor = true;
            this.ReplaceBTN.Click += new System.EventHandler(this.ReplaceBTN_Click);
            // 
            // ReplaceAnswerTB
            // 
            this.ReplaceAnswerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceAnswerTB.Location = new System.Drawing.Point(12, 207);
            this.ReplaceAnswerTB.Name = "ReplaceAnswerTB";
            this.ReplaceAnswerTB.Size = new System.Drawing.Size(323, 26);
            this.ReplaceAnswerTB.TabIndex = 6;
            // 
            // ReversBTN
            // 
            this.ReversBTN.Location = new System.Drawing.Point(341, 240);
            this.ReversBTN.Name = "ReversBTN";
            this.ReversBTN.Size = new System.Drawing.Size(130, 39);
            this.ReversBTN.TabIndex = 8;
            this.ReversBTN.Text = "Заменить порядок слов";
            this.ReversBTN.UseVisualStyleBackColor = true;
            this.ReversBTN.Click += new System.EventHandler(this.ReversBTN_Click);
            // 
            // EditorRTB
            // 
            this.EditorRTB.Location = new System.Drawing.Point(12, 287);
            this.EditorRTB.Name = "EditorRTB";
            this.EditorRTB.Size = new System.Drawing.Size(191, 90);
            this.EditorRTB.TabIndex = 9;
            this.EditorRTB.Text = "";
            // 
            // ReversTB
            // 
            this.ReversTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReversTB.Location = new System.Drawing.Point(12, 245);
            this.ReversTB.Name = "ReversTB";
            this.ReversTB.Size = new System.Drawing.Size(323, 26);
            this.ReversTB.TabIndex = 10;
            // 
            // ReplaceFromEditorTB
            // 
            this.ReplaceFromEditorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceFromEditorTB.Location = new System.Drawing.Point(209, 287);
            this.ReplaceFromEditorTB.Name = "ReplaceFromEditorTB";
            this.ReplaceFromEditorTB.Size = new System.Drawing.Size(126, 26);
            this.ReplaceFromEditorTB.TabIndex = 11;
            // 
            // ReplaceEditorBTN
            // 
            this.ReplaceEditorBTN.Location = new System.Drawing.Point(418, 305);
            this.ReplaceEditorBTN.Name = "ReplaceEditorBTN";
            this.ReplaceEditorBTN.Size = new System.Drawing.Size(53, 26);
            this.ReplaceEditorBTN.TabIndex = 12;
            this.ReplaceEditorBTN.Text = "Все";
            this.ReplaceEditorBTN.UseVisualStyleBackColor = true;
            this.ReplaceEditorBTN.Click += new System.EventHandler(this.ReplaceEditorBTN_Click);
            // 
            // ReplaceToEditorTB
            // 
            this.ReplaceToEditorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceToEditorTB.Location = new System.Drawing.Point(209, 319);
            this.ReplaceToEditorTB.Name = "ReplaceToEditorTB";
            this.ReplaceToEditorTB.Size = new System.Drawing.Size(126, 26);
            this.ReplaceToEditorTB.TabIndex = 13;
            // 
            // FindEditorTB
            // 
            this.FindEditorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindEditorTB.Location = new System.Drawing.Point(209, 351);
            this.FindEditorTB.Name = "FindEditorTB";
            this.FindEditorTB.Size = new System.Drawing.Size(126, 26);
            this.FindEditorTB.TabIndex = 15;
            this.FindEditorTB.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // FindEditorBTN
            // 
            this.FindEditorBTN.Location = new System.Drawing.Point(341, 351);
            this.FindEditorBTN.Name = "FindEditorBTN";
            this.FindEditorBTN.Size = new System.Drawing.Size(130, 26);
            this.FindEditorBTN.TabIndex = 14;
            this.FindEditorBTN.Text = "Найти";
            this.FindEditorBTN.UseVisualStyleBackColor = true;
            this.FindEditorBTN.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ReplaceEditorFirstTB
            // 
            this.ReplaceEditorFirstTB.Location = new System.Drawing.Point(341, 305);
            this.ReplaceEditorFirstTB.Name = "ReplaceEditorFirstTB";
            this.ReplaceEditorFirstTB.Size = new System.Drawing.Size(71, 26);
            this.ReplaceEditorFirstTB.TabIndex = 19;
            this.ReplaceEditorFirstTB.Text = "Заменить";
            this.ReplaceEditorFirstTB.UseVisualStyleBackColor = true;
            this.ReplaceEditorFirstTB.Click += new System.EventHandler(this.ReplaceEditorFirstTB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 384);
            this.Controls.Add(this.ReplaceEditorFirstTB);
            this.Controls.Add(this.FindEditorTB);
            this.Controls.Add(this.FindEditorBTN);
            this.Controls.Add(this.ReplaceToEditorTB);
            this.Controls.Add(this.ReplaceEditorBTN);
            this.Controls.Add(this.ReplaceFromEditorTB);
            this.Controls.Add(this.ReversTB);
            this.Controls.Add(this.EditorRTB);
            this.Controls.Add(this.ReversBTN);
            this.Controls.Add(this.ReplaceAnswerTB);
            this.Controls.Add(this.ReplaceBTN);
            this.Controls.Add(this.ReplaceTB);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.FieldRTB);
            this.Controls.Add(this.FieldTB);
            this.Name = "Form1";
            this.Text = "ЛР2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FieldTB;
        private System.Windows.Forms.RichTextBox FieldRTB;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.TextBox ReplaceTB;
        private System.Windows.Forms.Button ReplaceBTN;
        private System.Windows.Forms.TextBox ReplaceAnswerTB;
        private System.Windows.Forms.Button ReversBTN;
        private System.Windows.Forms.RichTextBox EditorRTB;
        private System.Windows.Forms.TextBox ReversTB;
        private System.Windows.Forms.TextBox ReplaceFromEditorTB;
        private System.Windows.Forms.Button ReplaceEditorBTN;
        private System.Windows.Forms.TextBox ReplaceToEditorTB;
        private System.Windows.Forms.TextBox FindEditorTB;
        private System.Windows.Forms.Button FindEditorBTN;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ReplaceEditorFirstTB;
    }
}

