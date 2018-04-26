using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using SpeechLib;
using System.Media;
using PPT = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace cmcc_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int time_total = 300;
        long time_count_total;
        long timestamp_mini;
        long timer_diff;
        List<string> list_conf;
        int beep_count = 0;

        public PPT.Application pa;
        public PPT.Presentation pp;
        PPT.Shape clock_s;
        PPT.Shape clock_minis;

        private void Form1_Load(object sender, EventArgs e)
        {

            list_conf = new List<string>();
            StreamReader br = new StreamReader("conf.ini");
            try
            {
                time_total = Convert.ToInt32(br.ReadLine());
                time_count_total = time_total * 1000;
                tb_time_remain.Text = time_total + "";
                time_remain.Text = tb_time_remain.Text;
                for (int i = 0; i < 100; i++)
                {
                    string tmp = br.ReadLine();
                    if (tmp == "---")
                    {
                        break;
                    }
                    list_conf.Add(tmp);
                }
            }
            catch
            {

            }
            finally
            {
                br.Close();
                br.Dispose();
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            time_remain.Text = tb_time_remain.Text;
            time_total = Convert.ToInt32(time_remain.Text);
            time_remain_mini.Text = ".000";
            if (clock_s != null && clock_minis != null)
            {
                clock_s.TextFrame.TextRange.Text = time_remain.Text;
                clock_minis.TextFrame.TextRange.Text = time_remain_mini.Text;
            }
            time_count_total = time_total * 1000;
            beep_count = 0;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                time_count_total = time_count_total - timer_diff;
                btn_start.Text = "继续";
                btn_reset.Enabled = true;
            }
            else
            {
                btn_reset.Enabled = false;
                TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                timestamp_mini = Convert.ToInt64(ts.TotalMilliseconds);
                timer1.Enabled = true;
                btn_start.Text = "暂停";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            long timer_mini = Convert.ToInt64(ts.TotalMilliseconds);
            timer_diff = timer_mini - timestamp_mini;
            long reamin = (time_count_total - timer_diff) / 1000;
            long reamin_mini = (time_count_total - timer_diff) % 1000;
            if (reamin <= 0)
            {
                reamin = 0;
            }
            if (reamin_mini <= 0)
            {
                reamin_mini = 0;
            }
            time_remain.Text = reamin + "";
            time_remain_mini.Text = "." + reamin_mini;
            if (clock_s != null && clock_minis != null)
            {
                clock_s.TextFrame.TextRange.Text = "" + reamin;
                clock_minis.TextFrame.TextRange.Text = "." + reamin_mini;
            }
            //    sound((time_count_total - timer_diff)/1000);
            sound(Convert.ToInt64(time_remain.Text) + 1);
            if (reamin == 0 && reamin_mini == 0)
            {
                sound(0);
                btn_start_Click(null, e);
            }
        }

        public void sound(long remain)
        {

            if (beep_count == -1)
            {
                return;
            }
            string[] tmp_arr = list_conf[beep_count].Split(',');
            if (remain <= Convert.ToInt64(tmp_arr[0].Trim()))
            {
                /*              SpVoice voice = new SpVoice();
                              SpeechVoiceSpeakFlags flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
                          //    voice.Speak(tmp_arr[0].Trim(), flag);
                              System.Media.SystemSounds.Beep.Play();
                 */
                System.Media.SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = tmp_arr[1];      //音频文件路径 
                sp.Play();
                sp.Dispose();
                if (beep_count == list_conf.Count - 1)
                {
                    beep_count = -1;
                    return;
                }
                beep_count++;
            }
            return;
        }

        private void btn_open_ppt_Click(object sender, EventArgs e)
        {
            pa = new PPT.ApplicationClass();
            pp = pa.Presentations.Open(Application.StartupPath + @".\ppt.ppt", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoTrue);

            PPT.Slide slide = (PPT.Slide)pp.Slides._Index(1);

            foreach (PPT.Shape shape in slide.Shapes)
            {

                if (shape.Type == Microsoft.Office.Core.MsoShapeType.msoTextBox)
                {

                    if (shape.TextFrame.TextRange.Find("000") != null)
                    {
                        clock_s = shape;
                    }
                    else if (shape.TextFrame.TextRange.Find("00") != null)
                    {
                        clock_minis = shape;
                    }
                }
            }
        }

        private void btn_close_ppt_Click(object sender, EventArgs e)
        {
            if (pa != null)
            {
                pa.Quit();
                pa = null;
                pp = null;
                clock_s = null;
                clock_minis = null;
            }
            GC.Collect();

        }
    }
}
