namespace MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonCreateCurve = new System.Windows.Forms.Button();
            this.buttonTransformation = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRemoveLast = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(940, 549);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonCreateCurve
            // 
            this.buttonCreateCurve.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateCurve.Name = "buttonCreateCurve";
            this.buttonCreateCurve.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateCurve.TabIndex = 1;
            this.buttonCreateCurve.Text = "CreateCurve";
            this.buttonCreateCurve.UseVisualStyleBackColor = true;
            this.buttonCreateCurve.Click += new System.EventHandler(this.buttonCreateCurve_Click);
            // 
            // buttonTransformation
            // 
            this.buttonTransformation.Location = new System.Drawing.Point(135, 12);
            this.buttonTransformation.Name = "buttonTransformation";
            this.buttonTransformation.Size = new System.Drawing.Size(75, 23);
            this.buttonTransformation.TabIndex = 2;
            this.buttonTransformation.Text = "Magic";
            this.buttonTransformation.UseVisualStyleBackColor = true;
            this.buttonTransformation.Click += new System.EventHandler(this.buttonTransformation_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(216, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Stop";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRemoveLast
            // 
            this.buttonRemoveLast.Location = new System.Drawing.Point(397, 12);
            this.buttonRemoveLast.Name = "buttonRemoveLast";
            this.buttonRemoveLast.Size = new System.Drawing.Size(79, 23);
            this.buttonRemoveLast.TabIndex = 4;
            this.buttonRemoveLast.Text = "Remove Last";
            this.buttonRemoveLast.UseVisualStyleBackColor = true;
            this.buttonRemoveLast.Click += new System.EventHandler(this.buttonRemoveLast_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(877, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(482, 12);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAll.TabIndex = 6;
            this.buttonRemoveAll.Text = "Remove All";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 602);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRemoveLast);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonTransformation);
            this.Controls.Add(this.buttonCreateCurve);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonCreateCurve;
        private System.Windows.Forms.Button buttonTransformation;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRemoveLast;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRemoveAll;
    }
}

