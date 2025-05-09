using Microsoft.VisualBasic;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using TodoTimer;
using System.Text.Json;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;
using System.Globalization;

namespace TodoTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = false;
            RefreshTagList();
        }
        struct TimerInfo
        {
            public int Tick;
            public int TodoCount;
            public string StartTime;
            public string Tag;

            public TimerInfo(int tick, int todocount, string startime, string tag)
            {
                Tick = tick;
                TodoCount = todocount;
                StartTime = startime;
                Tag = tag;
            }
        }
        private bool timer_enabled = false;
        private TimerInfo _timerInfo;


        private void itemAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox(
                   "Please enter tags : ",
                   "TodoTimer",
                   "Programming Study"
             ).Trim();
            if (string.IsNullOrEmpty(input)) { return; }

            var setting = SettingService.Load();
            if (!setting.Tags.Contains(input, StringComparer.OrdinalIgnoreCase))
            {
                setting.Tags.Add(input);
                SettingService.Save(setting);
                RefreshTagList();
            }
            else
            {
                MessageBox.Show($"이미 태그 목록에 '{input}' 이(가) 있습니다.", "TodoTimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _timerInfo = new TimerInfo(
                tick: 1,
                todocount: 0,
                startime: "",
                tag: ""
                );
        }

        private void RefreshTagList()
        {
            var setting = SettingService.Load();
            list_Tag.Items.Clear();

            if (setting.Tags.Any())
                list_Tag.Items.AddRange(setting.Tags.ToArray());
            else
                list_Tag.Items.Add("(No Tags)");
        }

        private void itemDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list_Tag.SelectedItem is not string tag)
            {
                MessageBox.Show($"선택된 태그가 없습니다.", "TodoTimer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var setting = SettingService.Load();
            if (setting.Tags.Remove(tag))
            {
                SettingService.Save(setting);
                RefreshTagList();
            }
            else
            {
                MessageBox.Show($"'{tag}'를 찾을 수 없습니다.", "TodoTimer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_timer_Click(object sender, EventArgs e)
        {
            //태그 선택 여부 확인
            if (list_Tag.SelectedItem is not string tag)
            {
                MessageBox.Show($"선택된 태그가 없습니다.", "TodoTimer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tag == "(No Tags)") { MessageBox.Show($"선택된 태그가 없습니다.", "TodoTimer", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (timer_enabled == false)
            {
                timer_enabled = true;
                timer.Enabled = true;
                _timerInfo.Tag = tag;
                _timerInfo.StartTime = DateTime.Now.ToString("HH:mm:ss");
                btn_timer.Text = "Stop";
            }
            else
            {
                _timerInfo.Tick = 1;
                timer.Enabled = false;
                timer_enabled = false;

                ListViewItem item = new ListViewItem();
                _timerInfo.TodoCount++;
                string nowTime = DateTime.Now.ToString("HH:mm:ss");
                item.Text = _timerInfo.TodoCount.ToString();
                item.SubItems.Add(_timerInfo.Tag);
                item.SubItems.Add(_timerInfo.StartTime);
                item.SubItems.Add(nowTime);
                item.SubItems.Add(work_timeChekced(_timerInfo.StartTime, nowTime));
                listView_Todo.Items.Add(item);
                totalWorkTime();
                SaveDailyJson();
                btn_timer.Text = "Start";
            }
        }
        private void totalWorkTime()
        {
            TimeSpan total_time = TimeSpan.Zero;

            foreach (ListViewItem item in listView_Todo.Items)
            {
                string time_item = item.SubItems[4].Text.Trim();

                if (time_item.Length != 8) continue;
                if (TimeSpan.TryParseExact(
                    time_item,
                    @"hh\:mm\:ss",
                    CultureInfo.InvariantCulture,
                    out TimeSpan ts
                    ))
                {
                    total_time += ts;
                }
            }
            txt_totalWorkTime.Text = "Total Worktime : " + total_time;
        }
        private string work_timeChekced(string startTime, string endTime)
        {
            var format = @"hh\:mm\:ss";
            TimeSpan start = TimeSpan.ParseExact(startTime, format, null);
            TimeSpan end = TimeSpan.ParseExact(endTime, format, null);
            TimeSpan duration = end - start;
            return duration.ToString(format);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(_timerInfo.Tick);
            txt_nowTimer.Text = ts.ToString(@"hh\:mm\:ss");
            _timerInfo.Tick++;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            listView_Todo.Items.Clear();
            timer.Enabled = false;
            timer_enabled = false;
            btn_timer.Text = "Start";
            txt_totalWorkTime.Text = "Total worktime : 00:00:00";
            txt_nowTimer.Text = "00:00:00";
            _timerInfo = new TimerInfo(
                tick: 1,
                todocount: 0,
                startime: "",
                tag: ""
                );
        }

        private  void SaveDailyJson()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            var log = new DailyLog { Date = today };

            foreach (ListViewItem item in listView_Todo.Items)
            {
                if (!int.TryParse(item.SubItems[0].Text, out int idx))
                    continue;

                var entry = new WorkEntry
                {
                    Index = idx,
                    Tag = item.SubItems[1].Text,
                    StartTime = item.SubItems[2].Text,
                    EndTime = item.SubItems[3].Text,
                    WorkTime = item.SubItems[4].Text
                };
                log.Entries.Add(entry);

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                string json = JsonSerializer.Serialize(log, options);

                string dataDir = Path.Combine(Application.StartupPath, "Data");
                if (!Directory.Exists(dataDir))
                {
                    Directory.CreateDirectory(dataDir);
                }
                string fileName = $"log_{today}.json";
                string path = Path.Combine(dataDir, fileName);
                File.WriteAllText(path, json);
            }
        }
    }
    public class WorkEntry
    {
        public int Index { get; set; }
        public string Tag { get; set; } = "";
        public string StartTime { get; set; } = "";
        public string EndTime { get; set; } = "";
        public string WorkTime { get; set; } = "";
    }
    public class DailyLog
    {
        public string Date { get; set; } = "";
        public List<WorkEntry> Entries { get; set; } = new();
    }
}
