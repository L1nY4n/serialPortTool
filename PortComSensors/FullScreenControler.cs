using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace SenserProj
{
    /// <summary>
    /// ȫ����ʾ��
    /// </summary>
    public class FullScreenControler
    {
        public const int SPI_SETWORKAREA = 47;
        public const int SPI_GETWORKAREA = 48;
        public const int SW_HIDE = 0x00;
        public const int SW_SHOW = 0x0001;
        public const int SPIF_UPDATEINIFILE = 0x01;
        [DllImport("coredll.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpWindowName, string lpClassName);
        [DllImport("coredll.dll", EntryPoint = "ShowWindow")]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
        [DllImport("coredll.dll", EntryPoint = "SystemParametersInfo")]
        private static extern int SystemParametersInfo(int uAction, int uParam, ref Rectangle lpvParam, int fuWinIni);

        /// <summary>
        /// ����ȫ����ȡ��ȫ��
        /// </summary>
        /// <param name="fullscreen">true:ȫ�� false:�ָ�</param>
        /// <param name="rectOld">���õ�ʱ�򣬴˲�������ԭʼ�ߴ磬�ָ�ʱ�ô˲������ûָ�</param>
        /// <returns>���ý��</returns>
        public static bool SetFullScreen(bool fullscreen, ref Rectangle rectOld)
        {
            IntPtr Hwnd = FindWindow("HHTaskBar", null);
            if (Hwnd == IntPtr.Zero) return false;
            if (fullscreen)
            {
                ShowWindow(Hwnd, SW_HIDE);
                Rectangle rectFull = Screen.PrimaryScreen.Bounds;
                SystemParametersInfo(SPI_GETWORKAREA, 0, ref rectOld, SPIF_UPDATEINIFILE);//get
                SystemParametersInfo(SPI_SETWORKAREA, 0, ref rectFull, SPIF_UPDATEINIFILE);//set
            }
            else
            {
                ShowWindow(Hwnd, SW_SHOW);
                SystemParametersInfo(SPI_SETWORKAREA, 0, ref rectOld, SPIF_UPDATEINIFILE);
            }
            return true;
        }

    }
}