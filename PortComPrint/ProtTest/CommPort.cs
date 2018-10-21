﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace NewPortTest
{
    public class CommPort
    {
        ///<summary>
        ///端口名称(COM1,COM2...COM4...)COM2:
        ///</summary>
        public string Port = "COM1";
        ///<summary>
        ///波特率9600
        ///</summary>
        public int BaudRate = 115200;
        ///<summary>
        ///数据位4-8
        ///</summary>
        public byte ByteSize = 8; //4-8
        ///<summary>
        ///奇偶校验0-4=no,odd,even,mark,space
        ///</summary>
        public byte Parity = 0;   //0-4=no,odd,even,mark,space
        ///<summary>
        ///停止位
        ///</summary>
        public byte StopBits = 0;   //0,1,2 = 1, 1.5, 2
        ///<summary>
        ///超时长
        ///</summary>
        public int ReadTimeout = 200;
        ///<summary>
        ///串口是否已经打开
        ///</summary>
        public bool Opened = false;
        ///<summary>
        /// COM口句柄
        ///</summary>
        private int hComm = -1;
        #region "API相关定义"
        private const string DLLPATH = "//windows//CoreDll.dll"; ////windows//coredll.dll "kernel32";
        ///<summary>
        /// WINAPI常量,写标志
        ///</summary>
        private const uint GENERIC_READ = 0x80000000;
        ///<summary>
        /// WINAPI常量,读标志
        ///</summary>
        private const uint GENERIC_WRITE = 0x40000000;
        ///<summary>
        /// WINAPI常量,打开已存在
        ///</summary>
        private const int OPEN_EXISTING = 3;
        ///<summary>
        /// WINAPI常量,无效句柄
        ///</summary>
        private const int INVALID_HANDLE_VALUE = -1;
        private const int PURGE_RXABORT = 0x2;
        private const int PURGE_RXCLEAR = 0x8;
        private const int PURGE_TXABORT = 0x1;
        private const int PURGE_TXCLEAR = 0x4;
        ///<summary>
        ///设备控制块结构体类型
        ///</summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct DCB
        {
            ///<summary>
            /// DCB长度
            ///</summary>
            public int DCBlength;
            ///<summary>
            ///指定当前波特率
            ///</summary>
            public int BaudRate;
            ///<summary>
            ///标志位
            ///</summary>
            public uint flags;
            ///<summary>
            ///未使用,必须为0
            ///</summary>
            public ushort wReserved;
            ///<summary>
            ///指定在XON字符发送这前接收缓冲区中可允许的最小字节数
            ///</summary>
            public ushort XonLim;
            ///<summary>
            ///指定在XOFF字符发送这前接收缓冲区中可允许的最小字节数
            ///</summary>
            public ushort XoffLim;
            ///<summary>
            ///指定端口当前使用的数据位
            ///</summary>
            public byte ByteSize;
            ///<summary>
            ///指定端口当前使用的奇偶校验方法,可能为:EVENPARITY,MARKPARITY,NOPARITY,ODDPARITY 0-4=no,odd,even,mark,space
            ///</summary>
            public byte Parity;
            ///<summary>
            ///指定端口当前使用的停止位数,可能为:ONESTOPBIT,ONE5STOPBITS,TWOSTOPBITS 0,1,2 = 1, 1.5, 2
            ///</summary>
            public byte StopBits;
            ///<summary>
            ///指定用于发送和接收字符XON的值 Tx and Rx XON character
            ///</summary>
            public byte XonChar;
            ///<summary>
            ///指定用于发送和接收字符XOFF值 Tx and Rx XOFF character
            ///</summary>
            public byte XoffChar;
            ///<summary>
            ///本字符用来代替接收到的奇偶校验发生错误时的值
            ///</summary>
            public byte ErrorChar;
            ///<summary>
            ///当没有使用二进制模式时,本字符可用来指示数据的结束
            ///</summary>
            public byte EofChar;
            ///<summary>
            ///当接收到此字符时,会产生一个事件
            ///</summary>
            public byte EvtChar;
            ///<summary>
            ///未使用
            ///</summary>
            public ushort wReserved1;
        }
        ///<summary>
        ///串口超时时间结构体类型
        ///</summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct COMMTIMEOUTS
        {
            public int ReadIntervalTimeout;
            public int ReadTotalTimeoutMultiplier;
            public int ReadTotalTimeoutConstant;
            public int WriteTotalTimeoutMultiplier;
            public int WriteTotalTimeoutConstant;
        }
        ///<summary>
        ///溢出缓冲区结构体类型
        ///</summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct OVERLAPPED
        {
            public int Internal;
            public int InternalHigh;
            public int Offset;
            public int OffsetHigh;
            public int hEvent;
        }
        ///<summary>
        ///打开串口
        ///</summary>
        ///<param name="lpFileName">要打开的串口名称</param>
        ///<param name="dwDesiredAccess">指定串口的访问方式，一般设置为可读可写方式</param>
        ///<param name="dwShareMode">指定串口的共享模式，串口不能共享，所以设置为0</param>
        ///<param name="lpSecurityAttributes">设置串口的安全属性，WIN9X下不支持，应设为NULL</param>
        ///<param name="dwCreationDisposition">对于串口通信，创建方式只能为OPEN_EXISTING</param>
        ///<param name="dwFlagsAndAttributes">指定串口属性与标志，设置为FILE_FLAG_OVERLAPPED(重叠I/O操作)，指定串口以异步方式通信</param>
        ///<param name="hTemplateFile">对于串口通信必须设置为NULL</param>
        [DllImport(DLLPATH)]
        private static extern int CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode,
        int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);
        ///<summary>
        ///得到串口状态
        ///</summary>
        ///<param name="hFile">通信设备句柄</param>
        ///<param name="lpDCB">设备控制块DCB</param>
        [DllImport(DLLPATH)]
        private static extern bool GetCommState(int hFile, ref DCB lpDCB);
        ///<summary>
        ///建立串口设备控制块(嵌入版没有)
        ///</summary>
        ///<param name="lpDef">设备控制字符串</param>
        ///<param name="lpDCB">设备控制块</param>
        //[DllImport(DLLPATH)]
        //private static extern bool BuildCommDCB(string lpDef, ref DCB lpDCB);
        ///<summary>
        ///设置串口状态
        ///</summary>
        ///<param name="hFile">通信设备句柄</param>
        ///<param name="lpDCB">设备控制块</param>
        [DllImport(DLLPATH)]
        private static extern bool SetCommState(int hFile, ref DCB lpDCB);
        ///<summary>
        ///读取串口超时时间
        ///</summary>
        ///<param name="hFile">通信设备句柄</param>
        ///<param name="lpCommTimeouts">超时时间</param>
        [DllImport(DLLPATH)]
        private static extern bool GetCommTimeouts(int hFile, ref COMMTIMEOUTS lpCommTimeouts);
        ///<summary>
        ///设置串口超时时间
        ///</summary>
        ///<param name="hFile">通信设备句柄</param>
        ///<param name="lpCommTimeouts">超时时间</param>
        [DllImport(DLLPATH)]
        private static extern bool SetCommTimeouts(int hFile, ref COMMTIMEOUTS lpCommTimeouts);
        ///<summary>
        ///读取串口数据
        ///</summary>
        ///<param name="hFile">通信设备句柄</param>
        ///<param name="lpBuffer">数据缓冲区</param>
        ///<param name="nNumberOfBytesToRead">多少字节等待读取</param>
        ///<param name="lpNumberOfBytesRead">读取多少字节</param>
        ///<param name="lpOverlapped">溢出缓冲区</param>
        [DllImport(DLLPATH)]
        private static extern bool ReadFile(int hFile, byte[] lpBuffer, int nNumberOfBytesToRead,
        ref int lpNumberOfBytesRead, ref OVERLAPPED lpOverlapped);
        ///<summary>
        ///写串口数据
        ///</summary>
        ///<param name="hFile">通信设备句柄</param>
        ///<param name="lpBuffer">数据缓冲区</param>
        ///<param name="nNumberOfBytesToWrite">多少字节等待写入</param>
        ///<param name="lpNumberOfBytesWritten">已经写入多少字节</param>
        ///<param name="lpOverlapped">溢出缓冲区</param>
        [DllImport(DLLPATH)]
        private static extern bool WriteFile(int hFile, byte[] lpBuffer, int nNumberOfBytesToWrite,
        ref int lpNumberOfBytesWritten, ref OVERLAPPED lpOverlapped);
        [DllImport(DLLPATH, SetLastError = true)]
        private static extern bool FlushFileBuffers(int hFile);
        [DllImport(DLLPATH, SetLastError = true)]
        private static extern bool PurgeComm(int hFile, uint dwFlags);
        ///<summary>
        ///关闭串口
        ///</summary>
        ///<param name="hObject">通信设备句柄</param>
        [DllImport(DLLPATH)]
        private static extern bool CloseHandle(int hObject);
        ///<summary>
        ///得到串口最后一次返回的错误
        ///</summary>
        [DllImport(DLLPATH)]
        private static extern uint GetLastError();
        #endregion
        ///<summary>
        ///设置DCB标志位
        ///</summary>
        ///<param name="whichFlag"></param>
        ///<param name="setting"></param>
        ///<param name="dcb"></param>
        internal void SetDcbFlag(int whichFlag, int setting, DCB dcb)
        {
            uint num;
            setting = setting << whichFlag;
            if ((whichFlag == 4) || (whichFlag == 12))
            {
                num = 3;
            }
            else if (whichFlag == 15)
            {
                num = 0x1ffff;
            }
            else
            {
                num = 1;
            }
            dcb.flags &= ~(num << whichFlag);
            dcb.flags |= (uint)setting;
        }
        ///<summary>
        ///建立与串口的连接
        ///</summary>
        public int Open(string portName)
        {
            Port = portName;
            DCB dcb = new DCB();
            COMMTIMEOUTS ctoCommPort = new COMMTIMEOUTS();
            // 打开串口
            hComm = CreateFile(Port, GENERIC_READ | GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0);
            if (hComm == INVALID_HANDLE_VALUE)
            {
                return -1;
            }
            // 设置通信超时时间
            GetCommTimeouts(hComm, ref ctoCommPort);
            ctoCommPort.ReadTotalTimeoutConstant = ReadTimeout;
            ctoCommPort.ReadTotalTimeoutMultiplier = 0;
            ctoCommPort.WriteTotalTimeoutMultiplier = 0;
            ctoCommPort.WriteTotalTimeoutConstant = 0;
            SetCommTimeouts(hComm, ref ctoCommPort);
            //设置串口参数
            GetCommState(hComm, ref dcb);
            dcb.DCBlength = Marshal.SizeOf(dcb);
            dcb.BaudRate = BaudRate;
            dcb.flags = 0;
            dcb.ByteSize = (byte)ByteSize;
            dcb.StopBits = StopBits;
            dcb.Parity = (byte)Parity;
            //------------------------------
            SetDcbFlag(0, 1, dcb);            //二进制方式
            SetDcbFlag(1, (Parity == 0) ? 0 : 1, dcb);
            SetDcbFlag(2, 0, dcb);            //不用CTS检测发送流控制
            SetDcbFlag(3, 0, dcb);            //不用DSR检测发送流控制
            SetDcbFlag(4, 0, dcb);            //禁止DTR流量控制
            SetDcbFlag(6, 0, dcb);            //对DTR信号线不敏感
            SetDcbFlag(9, 1, dcb);            //检测接收缓冲区
            SetDcbFlag(8, 0, dcb);            //不做发送字符控制
            SetDcbFlag(10, 0, dcb);           //是否用指定字符替换校验错的字符
            SetDcbFlag(11, 0, dcb);           //保留NULL字符
            SetDcbFlag(12, 0, dcb);           //允许RTS流量控制
            SetDcbFlag(14, 0, dcb);           //发送错误后，继续进行下面的读写操作
            //--------------------------------
            dcb.wReserved = 0;                       //没有使用，必须为0      
            dcb.XonLim = 0;                          //指定在XOFF字符发送之前接收到缓冲区中可允许的最小字节数
            dcb.XoffLim = 0;                         //指定在XOFF字符发送之前缓冲区中可允许的最小可用字节数
            dcb.XonChar = 0;                         //发送和接收的XON字符
            dcb.XoffChar = 0;                        //发送和接收的XOFF字符
            dcb.ErrorChar = 0;                       //代替接收到奇偶校验错误的字符
            dcb.EofChar = 0;                         //用来表示数据的结束     
            dcb.EvtChar = 0;                         //事件字符，接收到此字符时，会产生一个事件       
            dcb.wReserved1 = 0;                      //没有使用
            if (!SetCommState(hComm, ref dcb))
            {
                return -2;
            }
            Opened = true;
            return 0;
        }
        ///<summary>
        ///关闭串口,结束通讯
        ///</summary>
        public void Close()
        {
            if (hComm != INVALID_HANDLE_VALUE)
            {
                CloseHandle(hComm);
            }
        }
        ///<summary>
        ///读取串口返回的数据
        ///</summary>
        ///<param name="NumBytes">数据长度</param>
        public int Read(ref byte[] bytData, int NumBytes)
        {
            if (hComm != INVALID_HANDLE_VALUE)
            {
                OVERLAPPED ovlCommPort = new OVERLAPPED();
                int BytesRead = 0;
                ReadFile(hComm, bytData, NumBytes, ref BytesRead, ref ovlCommPort);
                return BytesRead;
            }
            else
            {
                return -1;
            }
        }
        public byte[] Readport(int NumBytes)
        {
            byte[] BufBytes;
            byte[] OutBytes;
            BufBytes = new byte[NumBytes];
            if (hComm != INVALID_HANDLE_VALUE)
            {
                OVERLAPPED ovlCommPort = new OVERLAPPED();
                int BytesRead = 0;
                ReadFile(hComm, BufBytes, NumBytes, ref BytesRead, ref ovlCommPort);
                OutBytes = new byte[BytesRead];
                Array.Copy(BufBytes, OutBytes, BytesRead);
            }
            else
            {
                throw (new ApplicationException("串口未打开！"));
            }
            return OutBytes;
        }
        ///<summary>
        ///向串口写数据
        ///</summary>
        ///<param name="WriteBytes">数据数组</param>
        public int Write(byte[] WriteBytes, int intSize)
        {
            if (hComm != INVALID_HANDLE_VALUE)
            {
                OVERLAPPED ovlCommPort = new OVERLAPPED();
                int BytesWritten = 0;
                WriteFile(hComm, WriteBytes, intSize, ref BytesWritten, ref ovlCommPort);
                return BytesWritten;
            }
            else
            {
                return -1;
            }
        }
        ///<summary>
        ///清除接收缓冲区
        ///</summary>
        ///<returns></returns>
        public void ClearReceiveBuf()
        {
            if (hComm != INVALID_HANDLE_VALUE)
            {
                PurgeComm(hComm, PURGE_RXABORT | PURGE_RXCLEAR);
            }
        }
        ///<summary>
        ///清除发送缓冲区
        ///</summary>
        public void ClearSendBuf()
        {
            if (hComm != INVALID_HANDLE_VALUE)
            {
                PurgeComm(hComm, PURGE_TXABORT | PURGE_TXCLEAR);
            }
        }
    }
}
