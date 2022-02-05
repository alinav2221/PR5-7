
namespace PractWork5
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.crButton = new System.Windows.Forms.Button();
            this.uncrButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите текст";
            // 
            // textTextBox
            // 
            this.textTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTextBox.Location = new System.Drawing.Point(188, 17);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(687, 204);
            this.textTextBox.TabIndex = 1;
            // 
            // crButton
            // 
            this.crButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crButton.Location = new System.Drawing.Point(376, 227);
            this.crButton.Name = "crButton";
            this.crButton.Size = new System.Drawing.Size(144, 28);
            this.crButton.TabIndex = 2;
            this.crButton.Text = "Зашифровать";
            this.crButton.UseVisualStyleBackColor = true;
            this.crButton.Click += new System.EventHandler(this.CrButtonOnClick);
            // 
            // uncrButton
            // 
            this.uncrButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uncrButton.Location = new System.Drawing.Point(535, 227);
            this.uncrButton.Name = "uncrButton";
            this.uncrButton.Size = new System.Drawing.Size(144, 28);
            this.uncrButton.TabIndex = 3;
            this.uncrButton.Text = "Расшифровать";
            this.uncrButton.UseVisualStyleBackColor = true;
            this.uncrButton.Click += new System.EventHandler(this.UncrButtonOnClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Загрузить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderButton
            // 
            this.folderButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderButton.Location = new System.Drawing.Point(12, 103);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(170, 51);
            this.folderButton.TabIndex = 5;
            this.folderButton.Text = "Загрузить файлы \r\nиз папки";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.FolderButtonOnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результат \r\nшифрования:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resTextBox
            // 
            this.resTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resTextBox.Location = new System.Drawing.Point(188, 289);
            this.resTextBox.Multiline = true;
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.ReadOnly = true;
            this.resTextBox.Size = new System.Drawing.Size(687, 292);
            this.resTextBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 593);
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uncrButton);
            this.Controls.Add(this.crButton);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование RSA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Button crButton;
        private System.Windows.Forms.Button uncrButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resTextBox;
    }
}

