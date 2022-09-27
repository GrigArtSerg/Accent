namespace Accent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label = new System.Windows.Forms.Label();
            this.QWord = new System.Windows.Forms.Label();
            this.AccentAns = new System.Windows.Forms.NumericUpDown();
            this.Add = new System.Windows.Forms.Button();
            this.NeWord = new System.Windows.Forms.TextBox();
            this.NewAccent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Button();
            this.React = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AnsText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccentAns)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(110, -1);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(281, 46);
            this.label.TabIndex = 0;
            this.label.Text = "Ударения 1.0";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // QWord
            // 
            this.QWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QWord.Location = new System.Drawing.Point(41, 55);
            this.QWord.Name = "QWord";
            this.QWord.Size = new System.Drawing.Size(412, 31);
            this.QWord.TabIndex = 1;
            this.QWord.Text = "слово";
            this.QWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QWord.Click += new System.EventHandler(this.QWord_Click);
            // 
            // AccentAns
            // 
            this.AccentAns.BackColor = System.Drawing.Color.White;
            this.AccentAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccentAns.Location = new System.Drawing.Point(47, 154);
            this.AccentAns.Name = "AccentAns";
            this.AccentAns.Size = new System.Drawing.Size(171, 23);
            this.AccentAns.TabIndex = 9;
            this.AccentAns.ValueChanged += new System.EventHandler(this.AccentAns_ValueChanged);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(300, 359);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(135, 28);
            this.Add.TabIndex = 3;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NeWord
            // 
            this.NeWord.BackColor = System.Drawing.Color.White;
            this.NeWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NeWord.Location = new System.Drawing.Point(47, 327);
            this.NeWord.Name = "NeWord";
            this.NeWord.Size = new System.Drawing.Size(171, 26);
            this.NeWord.TabIndex = 1;
            this.NeWord.TextChanged += new System.EventHandler(this.NeWord_TextChanged);
            // 
            // NewAccent
            // 
            this.NewAccent.BackColor = System.Drawing.Color.White;
            this.NewAccent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewAccent.Location = new System.Drawing.Point(300, 327);
            this.NewAccent.Name = "NewAccent";
            this.NewAccent.Size = new System.Drawing.Size(135, 26);
            this.NewAccent.TabIndex = 2;
            this.NewAccent.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.NewAccent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Добавление нового слова";
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.Location = new System.Drawing.Point(300, 150);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(135, 28);
            this.Answer.TabIndex = 10;
            this.Answer.Text = "Начать";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // React
            // 
            this.React.AutoSize = true;
            this.React.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.React.Location = new System.Drawing.Point(44, 184);
            this.React.Name = "React";
            this.React.Size = new System.Drawing.Size(107, 17);
            this.React.TabIndex = 9;
            this.React.Text = "Оценка ответа";
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(48, 356);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(0, 17);
            this.enter.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Напишите слово";
            this.label1.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Напишите номер ударения";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(137, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Закончить тренировку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(137, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Открыть список слов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(300, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Показать ответ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AnsText
            // 
            this.AnsText.AutoSize = true;
            this.AnsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnsText.Location = new System.Drawing.Point(297, 215);
            this.AnsText.Name = "AnsText";
            this.AnsText.Size = new System.Drawing.Size(0, 17);
            this.AnsText.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "__?_?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(137, 469);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(232, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "Очистить результаты";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(137, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "Посмотреть статистику";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(224, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "clean";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(441, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "clean";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(137, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Мои данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 641);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AnsText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.React);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewAccent);
            this.Controls.Add(this.NeWord);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AccentAns);
            this.Controls.Add(this.QWord);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Accent 1.0";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccentAns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label QWord;
        private System.Windows.Forms.NumericUpDown AccentAns;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox NeWord;
        private System.Windows.Forms.TextBox NewAccent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Label React;
        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label AnsText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

