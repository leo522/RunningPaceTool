
namespace RunningPaceTool
{
    partial class Form1
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_Distance = new System.Windows.Forms.Label();
            this.txt_TotalDistances = new System.Windows.Forms.TextBox();
            this.txt_KM = new System.Windows.Forms.Label();
            this.txt_TotalHours = new System.Windows.Forms.TextBox();
            this.txt_TotalMinutes = new System.Windows.Forms.TextBox();
            this.txt_TotalSeconds = new System.Windows.Forms.TextBox();
            this.txt_Time = new System.Windows.Forms.Label();
            this.txt_Hour = new System.Windows.Forms.Label();
            this.txt_Minute = new System.Windows.Forms.Label();
            this.txt_Second = new System.Windows.Forms.Label();
            this.txt_Pace = new System.Windows.Forms.Label();
            this.txt_TotalPaceMin = new System.Windows.Forms.TextBox();
            this.txt_TotalPaceKM = new System.Windows.Forms.TextBox();
            this.txt_PaceMinute = new System.Windows.Forms.Label();
            this.txt_SecondKM = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.Location = new System.Drawing.Point(159, 404);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 53);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_Distance
            // 
            this.txt_Distance.AutoSize = true;
            this.txt_Distance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Distance.Location = new System.Drawing.Point(94, 129);
            this.txt_Distance.Name = "txt_Distance";
            this.txt_Distance.Size = new System.Drawing.Size(56, 28);
            this.txt_Distance.TabIndex = 2;
            this.txt_Distance.Text = "距離";
            // 
            // txt_TotalDistances
            // 
            this.txt_TotalDistances.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalDistances.Location = new System.Drawing.Point(204, 126);
            this.txt_TotalDistances.Name = "txt_TotalDistances";
            this.txt_TotalDistances.Size = new System.Drawing.Size(100, 31);
            this.txt_TotalDistances.TabIndex = 3;
            // 
            // txt_KM
            // 
            this.txt_KM.AutoSize = true;
            this.txt_KM.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KM.Location = new System.Drawing.Point(299, 129);
            this.txt_KM.Name = "txt_KM";
            this.txt_KM.Size = new System.Drawing.Size(56, 28);
            this.txt_KM.TabIndex = 4;
            this.txt_KM.Text = "公里";
            // 
            // txt_TotalHours
            // 
            this.txt_TotalHours.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalHours.Location = new System.Drawing.Point(204, 206);
            this.txt_TotalHours.Name = "txt_TotalHours";
            this.txt_TotalHours.Size = new System.Drawing.Size(100, 31);
            this.txt_TotalHours.TabIndex = 5;
            // 
            // txt_TotalMinutes
            // 
            this.txt_TotalMinutes.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalMinutes.Location = new System.Drawing.Point(364, 204);
            this.txt_TotalMinutes.Name = "txt_TotalMinutes";
            this.txt_TotalMinutes.Size = new System.Drawing.Size(100, 31);
            this.txt_TotalMinutes.TabIndex = 6;
            // 
            // txt_TotalSeconds
            // 
            this.txt_TotalSeconds.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalSeconds.Location = new System.Drawing.Point(522, 207);
            this.txt_TotalSeconds.Name = "txt_TotalSeconds";
            this.txt_TotalSeconds.Size = new System.Drawing.Size(100, 31);
            this.txt_TotalSeconds.TabIndex = 7;
            // 
            // txt_Time
            // 
            this.txt_Time.AutoSize = true;
            this.txt_Time.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Time.Location = new System.Drawing.Point(94, 205);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(56, 28);
            this.txt_Time.TabIndex = 8;
            this.txt_Time.Text = "時間";
            // 
            // txt_Hour
            // 
            this.txt_Hour.AutoSize = true;
            this.txt_Hour.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Hour.Location = new System.Drawing.Point(310, 209);
            this.txt_Hour.Name = "txt_Hour";
            this.txt_Hour.Size = new System.Drawing.Size(34, 28);
            this.txt_Hour.TabIndex = 9;
            this.txt_Hour.Text = "時";
            // 
            // txt_Minute
            // 
            this.txt_Minute.AutoSize = true;
            this.txt_Minute.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Minute.Location = new System.Drawing.Point(470, 208);
            this.txt_Minute.Name = "txt_Minute";
            this.txt_Minute.Size = new System.Drawing.Size(34, 28);
            this.txt_Minute.TabIndex = 10;
            this.txt_Minute.Text = "分";
            // 
            // txt_Second
            // 
            this.txt_Second.AutoSize = true;
            this.txt_Second.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Second.Location = new System.Drawing.Point(628, 210);
            this.txt_Second.Name = "txt_Second";
            this.txt_Second.Size = new System.Drawing.Size(34, 28);
            this.txt_Second.TabIndex = 11;
            this.txt_Second.Text = "秒";
            // 
            // txt_Pace
            // 
            this.txt_Pace.AutoSize = true;
            this.txt_Pace.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Pace.Location = new System.Drawing.Point(94, 283);
            this.txt_Pace.Name = "txt_Pace";
            this.txt_Pace.Size = new System.Drawing.Size(56, 28);
            this.txt_Pace.TabIndex = 12;
            this.txt_Pace.Text = "配速";
            // 
            // txt_TotalPaceMin
            // 
            this.txt_TotalPaceMin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalPaceMin.Location = new System.Drawing.Point(204, 283);
            this.txt_TotalPaceMin.Name = "txt_TotalPaceMin";
            this.txt_TotalPaceMin.Size = new System.Drawing.Size(100, 31);
            this.txt_TotalPaceMin.TabIndex = 13;
            // 
            // txt_TotalPaceKM
            // 
            this.txt_TotalPaceKM.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalPaceKM.Location = new System.Drawing.Point(364, 282);
            this.txt_TotalPaceKM.Name = "txt_TotalPaceKM";
            this.txt_TotalPaceKM.Size = new System.Drawing.Size(100, 31);
            this.txt_TotalPaceKM.TabIndex = 14;
            // 
            // txt_PaceMinute
            // 
            this.txt_PaceMinute.AutoSize = true;
            this.txt_PaceMinute.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PaceMinute.Location = new System.Drawing.Point(310, 285);
            this.txt_PaceMinute.Name = "txt_PaceMinute";
            this.txt_PaceMinute.Size = new System.Drawing.Size(34, 28);
            this.txt_PaceMinute.TabIndex = 15;
            this.txt_PaceMinute.Text = "分";
            // 
            // txt_SecondKM
            // 
            this.txt_SecondKM.AutoSize = true;
            this.txt_SecondKM.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SecondKM.Location = new System.Drawing.Point(470, 282);
            this.txt_SecondKM.Name = "txt_SecondKM";
            this.txt_SecondKM.Size = new System.Drawing.Size(109, 28);
            this.txt_SecondKM.TabIndex = 16;
            this.txt_SecondKM.Text = "秒/每公里";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.Violet;
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Calculate.Location = new System.Drawing.Point(346, 404);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(100, 53);
            this.btn_Calculate.TabIndex = 17;
            this.btn_Calculate.Text = "計算";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1399, 784);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txt_SecondKM);
            this.Controls.Add(this.txt_PaceMinute);
            this.Controls.Add(this.txt_TotalPaceKM);
            this.Controls.Add(this.txt_TotalPaceMin);
            this.Controls.Add(this.txt_Pace);
            this.Controls.Add(this.txt_Second);
            this.Controls.Add(this.txt_Minute);
            this.Controls.Add(this.txt_Hour);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.txt_TotalSeconds);
            this.Controls.Add(this.txt_TotalMinutes);
            this.Controls.Add(this.txt_TotalHours);
            this.Controls.Add(this.txt_KM);
            this.Controls.Add(this.txt_TotalDistances);
            this.Controls.Add(this.txt_Distance);
            this.Controls.Add(this.btn_Clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label txt_Distance;
        private System.Windows.Forms.TextBox txt_TotalDistances;
        private System.Windows.Forms.Label txt_KM;
        private System.Windows.Forms.TextBox txt_TotalHours;
        private System.Windows.Forms.TextBox txt_TotalMinutes;
        private System.Windows.Forms.TextBox txt_TotalSeconds;
        private System.Windows.Forms.Label txt_Time;
        private System.Windows.Forms.Label txt_Hour;
        private System.Windows.Forms.Label txt_Minute;
        private System.Windows.Forms.Label txt_Second;
        private System.Windows.Forms.Label txt_Pace;
        private System.Windows.Forms.TextBox txt_TotalPaceMin;
        private System.Windows.Forms.TextBox txt_TotalPaceKM;
        private System.Windows.Forms.Label txt_PaceMinute;
        private System.Windows.Forms.Label txt_SecondKM;
        private System.Windows.Forms.Button btn_Calculate;
    }
}

