using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace QTCSharpTool
{
    /// <summary>
    /// 简单提示音，可将wav格式的声音文件存放到snd目录下
    /// </summary>
    public static class snd
    {
        public static void begin()
        {
            play("begin.wav");
        }
            public static void exit()
        {
            play("exit.wav");
        }

        public static void notify()
        {
            play("notify.wav");
        }
        public static void success()
        {
            play("success.wav");
        }
        public static void wrong()
        {
            play("wrong.wav");
        }
        public static void play(string soundname)
        {
            //string file = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\zdsr\\zdcloud\\sound\\" + soundname;
            string file = "snd\\" + soundname;
            if (File.Exists(file))
            {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(file);
                snd.Play();
            }
        }

    }
}
