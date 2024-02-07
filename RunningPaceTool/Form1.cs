using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningPaceTool
{
    public partial class Form1 : Form
    {
        private double distance;
        private int hours;
        private int minutes;
        private int seconds = 0;
        private int paceMinutes;
        private int paceSeconds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 輸入查詢條件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                distance = double.Parse(txt_TotalDistances.Text); //距離
                hours = int.TryParse(txt_TotalHours.Text, out int parseHours) ? parseHours : 0; //時
                minutes = int.TryParse(txt_TotalMinutes.Text, out int parseMinutes) ? parseMinutes : 0; //分
                seconds = int.TryParse(txt_TotalSeconds.Text, out int parsedSeconds) ? parsedSeconds : 0; //秒
                if (string.IsNullOrEmpty(txt_TotalSeconds.Text))
                //{
                //    seconds = 0;
                //}
                // 計算配速
                UpdatePace();
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤");
            }
        }

        /// <summary>
        /// 計算配速
        /// </summary>
        private void UpdatePace()
        {
            try
            {
                var totalDistance = distance;

                var totalTime = (hours * 3600) + (minutes * 60) + seconds;

                var paceMinutes = totalTime / 60 / totalDistance; //分
                var paceSeconds = Math.Round(seconds / totalDistance);//秒
                txt_TotalPaceMin.Text = paceMinutes.ToString().Substring(0, 1); //配速-分
                txt_TotalPaceKM.Text = paceSeconds.ToString(); //配速-秒  
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤");
            }
        }

        /// <summary>
        /// 清除欄位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // 清除結果框中的內容
            txt_TotalDistances.Text = "";
            txt_TotalHours.Text = "";
            txt_TotalMinutes.Text = "";
            txt_TotalSeconds.Text = "";
            txt_TotalPaceMin.Text = "";
            txt_TotalPaceKM.Text = "";
        }
    }
}
