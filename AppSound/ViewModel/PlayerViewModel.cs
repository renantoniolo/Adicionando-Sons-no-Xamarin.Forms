using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Input;
using Plugin.SimpleAudioPlayer.Abstractions;
using Xamarin.Forms;

namespace AppSound.ViewModel
{
    public class PlayerViewModel : ViewModelBase
    {

        private Stream audioStreamAlarm;
        private Stream audioStreamWood;
        private Stream audioStreamF1;
        private ISimpleAudioPlayer playerAlarm;
        private ISimpleAudioPlayer playerWood;
        private ISimpleAudioPlayer playerF1;

        public PlayerViewModel()
        {

            var assembly = typeof(App).GetTypeInfo().Assembly; 
            audioStreamAlarm = assembly.GetManifestResourceStream("AppSound.analog-alarm.mp3"); 
            audioStreamWood = assembly.GetManifestResourceStream("AppSound.sawing-wood.mp3"); 
            audioStreamF1 = assembly.GetManifestResourceStream("AppSound.formula-1.mp3"); 

            // comands
            this.Sound01PlayCommand = new Command(this.SoundPlay01);
            this.Sound01StopCommand = new Command(this.SoundStop01);
            this.Sound02PlayCommand = new Command(this.SoundPlay02);
            this.Sound02StopCommand = new Command(this.SoundStop02);
            this.Sound03PlayCommand = new Command(this.SoundPlay03);
            this.Sound03StopCommand = new Command(this.SoundStop03);
        }

        internal void ThisOppearing()
        {
            // carrega o player
            playerAlarm = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            playerAlarm.Load(audioStreamAlarm);

            playerWood = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            playerWood.Load(audioStreamWood);

            playerF1 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            playerF1.Load(audioStreamF1);

        }

        public ICommand Sound01PlayCommand
        {
            get;
            set;
        }

        private  void SoundPlay01()
        {
            
            if (!playerAlarm.IsPlaying)
            {
                playerAlarm.Play();
            }
        }

        public ICommand Sound01StopCommand
        {
            get;
            set;
        }

        private void SoundStop01()
        {
            if(playerAlarm.IsPlaying) playerAlarm.Stop();

        }


        public ICommand Sound02PlayCommand
        {
            get;
            set;
        }

        private void SoundPlay02()
        {

            if (!playerWood.IsPlaying)
            {
                playerWood.Play();
            }
        }

        public ICommand Sound02StopCommand
        {
            get;
            set;
        }

        private void SoundStop02()
        {
            if (playerWood.IsPlaying) playerWood.Stop();

        }


        public ICommand Sound03PlayCommand
        {
            get;
            set;
        }

        private void SoundPlay03()
        {

            if (!playerF1.IsPlaying)
            {
                playerF1.Play();
            }
        }

        public ICommand Sound03StopCommand
        {
            get;
            set;
        }

        private void SoundStop03()
        {
            if (playerF1.IsPlaying) playerF1.Stop();

        }


    }
}
