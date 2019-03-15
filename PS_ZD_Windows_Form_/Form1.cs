using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.Mail;
using System.Net;



namespace PS_ZD_Windows_Form_
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher _watcher;

        public Form1()
        {

            InitializeComponent();
            InitializeWatcher();
            // text_path.Text = Properties.Settings.Default.path; 
            MailStatus.BackColor = Color.Green;

        }


        private void InitializeWatcher()
        {
            _watcher = new FileSystemWatcher();
            _watcher.Changed += _watcher_ChangedAsync;
            _watcher.Created += _watcher_ChangedAsync;
            _watcher.Deleted += _watcher_ChangedAsync;
            _watcher.Renamed += _watcher_ChangedAsync;
            _watcher.Path = text_path.Text;
            _watcher.EnableRaisingEvents = true;  // event to monitorowania statusu sciezki dostepu
        }



        public async void _watcher_ChangedAsync(object sender, FileSystemEventArgs e)
        {

            string log = "";

            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
                    //       MessageBox.Show($"Stworzono w folderze: {textBox_Path.Text}");
                    log = $"Utworzono plik: {e.FullPath}";
                    break;
                case WatcherChangeTypes.Deleted:
                    //MessageBox.Show($"Skasowano w folderze: {textBox_Path.Text}");
                    log = $"Skasowano plik: {e.FullPath}";
                    break;
                case WatcherChangeTypes.Changed:
                    //   MessageBox.Show($"Zmiana w folderze: {textBox_Path.Text}");
                    log = $"Zmieniono plik: {e.FullPath}";
                    break;
                case WatcherChangeTypes.Renamed:
                    //   MessageBox.Show($"Zmieniono nazwę w folderze: {textBox_Path.Text}");
                    log = $"Zmieniono nazwe pliku: {e.FullPath}";
                    break;
                case WatcherChangeTypes.All:
                    break;
                default:
                    break;
            }

            if (InvokeRequired)     // dodanie wyjatku do watku monitorowania folderu
            {
                BeginInvoke((Action)(() =>
                {
                    Listbox.Items.Insert(0, log);

                }));
            }

            MailStatus.BackColor = Color.Red;


            EmailSender email = new EmailSender();

            await email.EmailSendAsync(e.FullPath, e.Name);

            MailStatus.BackColor = Color.Green;


        }

        private void T1_Tick(object sender, EventArgs e)
        {

            UpdateTimer();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                text_path.Text = folderBrowserDialog1.SelectedPath;
                
                _watcher.Path = text_path.Text;

                //Properties.Settings.Default.path = text_path.Text;
            }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();  //zapisanie zmian do zamykaniu okna
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            UpdateTimer();

        }

        private void UpdateTimer()
        {
            DateTime date = DateTime.Now;
            // label1.Text = $"Actual date : {date.ToString("HH:mm:ss")}";
            label1.Text = $"Actual date : {date:HH:mm:ss}";
            //  label1.Text = $"Actual date : {date.ToShortTimeString()}";
        }
    }

}
