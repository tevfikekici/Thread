
namespace Threads2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_StartWithDelegate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Suspend = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Start2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Pause2 = new System.Windows.Forms.Button();
            this.button_Finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(21, 91);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 33);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_StartWithDelegate
            // 
            this.button_StartWithDelegate.Location = new System.Drawing.Point(169, 91);
            this.button_StartWithDelegate.Name = "button_StartWithDelegate";
            this.button_StartWithDelegate.Size = new System.Drawing.Size(162, 33);
            this.button_StartWithDelegate.TabIndex = 5;
            this.button_StartWithDelegate.Text = "Start with delegate";
            this.button_StartWithDelegate.UseVisualStyleBackColor = true;
            this.button_StartWithDelegate.Click += new System.EventHandler(this.button_StartWithDelegate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // button_Suspend
            // 
            this.button_Suspend.Location = new System.Drawing.Point(169, 130);
            this.button_Suspend.Name = "button_Suspend";
            this.button_Suspend.Size = new System.Drawing.Size(162, 33);
            this.button_Suspend.TabIndex = 6;
            this.button_Suspend.Text = "Pause";
            this.button_Suspend.UseVisualStyleBackColor = true;
            this.button_Suspend.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(169, 169);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(162, 33);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Start2
            // 
            this.button_Start2.Location = new System.Drawing.Point(415, 91);
            this.button_Start2.Name = "button_Start2";
            this.button_Start2.Size = new System.Drawing.Size(162, 33);
            this.button_Start2.TabIndex = 10;
            this.button_Start2.Text = "Start";
            this.button_Start2.UseVisualStyleBackColor = true;
            this.button_Start2.Click += new System.EventHandler(this.button_Start2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // button_Pause2
            // 
            this.button_Pause2.Location = new System.Drawing.Point(415, 130);
            this.button_Pause2.Name = "button_Pause2";
            this.button_Pause2.Size = new System.Drawing.Size(162, 33);
            this.button_Pause2.TabIndex = 11;
            this.button_Pause2.Text = "Pause";
            this.button_Pause2.UseVisualStyleBackColor = true;
            this.button_Pause2.Click += new System.EventHandler(this.button_Pause2_Click);
            // 
            // button_Finish
            // 
            this.button_Finish.Location = new System.Drawing.Point(415, 169);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(162, 33);
            this.button_Finish.TabIndex = 12;
            this.button_Finish.Text = "Finish";
            this.button_Finish.UseVisualStyleBackColor = true;
            this.button_Finish.Click += new System.EventHandler(this.button_Finish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Finish);
            this.Controls.Add(this.button_Pause2);
            this.Controls.Add(this.button_Start2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Suspend);
            this.Controls.Add(this.button_StartWithDelegate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_StartWithDelegate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Suspend;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Start2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Pause2;
        private System.Windows.Forms.Button button_Finish;
    }
}

