using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private List<string> audioFiles;
        private int currentTrackIndex = 0;
        private bool isPlaying = false;
        private bool isRepeatMode = false;
        private bool isShuffleMode = false;
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null && waveOut != null)
            {
                TimeSpan currentTime = audioFileReader.CurrentTime;
                TimeSpan totalTime = audioFileReader.TotalTime;
                currentPositionLabel.Content = $"{currentTime:mm\\:ss} / {totalTime:mm\\:ss}";
                positionSlider.Value = currentTime.TotalSeconds;

                if (currentTime >= totalTime && !isRepeatMode)
                {
                    PlayNextTrack();
                }
            }
        }

        private void SelectFolderButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string selectedPath = dialog.SelectedPath;
                LoadAudioFiles(selectedPath);
                PlayTrack(0);
            }
        }

        private void LoadAudioFiles(string folderPath)
        {
            audioFiles = Directory.GetFiles(folderPath, "*.mp3")
                .Union(Directory.GetFiles(folderPath, "*.wav"))
                .ToList();

            if (audioFiles.Count == 0)
            {
                MessageBox.Show("В выбранной папке не найдено нужного аудиофайла");
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (audioFiles != null && audioFiles.Count > 0)
            {
                if (isPlaying)
                {
                    PauseTrack();
                }
                else
                {
                    if (waveOut != null && waveOut.PlaybackState == PlaybackState.Paused)
                    {
                        waveOut.Play();
                    }
                    else
                    {
                        PlayTrack(currentTrackIndex);
                    }
                }
            }
        }

        private void PlayTrack(int index)
        {
            if (audioFiles != null && audioFiles.Count > 0 && index >= 0 && index < audioFiles.Count)
            {
                string selectedFile = audioFiles[index];
                waveOut = new WaveOutEvent();
                audioFileReader = new AudioFileReader(selectedFile);
                waveOut.Init(audioFileReader);
                waveOut.Play();
                isPlaying = true;
                playButton.Content = "Пауза";
                currentPositionLabel.Visibility = Visibility.Visible;
                positionSlider.Visibility = Visibility.Visible;
                timer.Start();
            }
        }

        private void PauseTrack()
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();
            }
            isPlaying = false;
            playButton.Content = "Играть";
            timer.Stop();
        }

        private void StopTrack()
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            isPlaying = false;
            playButton.Content = "Играть";
            currentPositionLabel.Visibility = Visibility.Hidden;
            positionSlider.Visibility = Visibility.Hidden;
            timer.Stop();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (audioFiles != null && audioFiles.Count > 0)
            {
                int newIndex = currentTrackIndex - 1;
                if (newIndex < 0)
                {
                    newIndex = audioFiles.Count - 1;
                }
                PlayTrack(newIndex);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (audioFiles != null && audioFiles.Count > 0)
            {
                PlayNextTrack();
            }
        }

        private void PlayNextTrack()
        {
            int newIndex;
            if (isShuffleMode)
            {
                newIndex = GetRandomTrackIndex();
            }
            else
            {
                newIndex = currentTrackIndex + 1;
                if (newIndex >= audioFiles.Count)
                {
                    newIndex = 0;
                }
            }
            PlayTrack(newIndex);
        }

        private int GetRandomTrackIndex()
        {
            Random random = new Random();
            int randomIndex = currentTrackIndex;
            while (randomIndex == currentTrackIndex)
            {
                randomIndex = random.Next(audioFiles.Count);
            }
            return randomIndex;
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            isRepeatMode = !isRepeatMode;
            repeatButton.Content = isRepeatMode ? "Повторение вкл." : "Повторение выкл.";
        }

        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {
            isShuffleMode = !isShuffleMode;
            shuffleButton.Content = isShuffleMode ? "Не попорядку вкл." : "Не попорядку выклю.";
        }

        private void PositionSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (audioFileReader != null && waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                TimeSpan newPosition = TimeSpan.FromSeconds(positionSlider.Value);
                audioFileReader.CurrentTime = newPosition;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StopTrack();
        }
    }
}
