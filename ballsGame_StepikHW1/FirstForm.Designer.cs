
namespace ballsGame_StepikHW1
{
    partial class FirstForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Create.Location = new System.Drawing.Point(673, 12);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 0;
            this.button_Create.Text = "создать";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(673, 70);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 1;
            this.button_Stop.Text = "Стоп";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(673, 41);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Create);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Clear;
    }
}

