using System.Runtime.InteropServices;
using System; 
using System.IO ;
using System.Reflection  ;
using System.Windows.Forms ;
//此示例演示如何使用平台调用来播放两个WAV文件：一个为嵌入的资源，另一个为内容。 
//此示例定义了一个Sound类，该类通过WinCE的CoreDll.dll提供下面的本机代码功能： 
//1、使用文件名或流播放声音的平台调用方法声明。 
//2、用于在平台调用方法调用中传递参数的位值枚举。 
//3、Play方法，用于调用正确的平台调用方法来播放单独的文件或嵌入的资源。 
//第一步：将 Sound 类添加到项目中。 
public class Sound 
{ 
    private byte[] m_soundBytes; 
    private string m_fileName; 
    private enum Flags { 
        SND_SYNC = 0x0000,  /* play synchronously (default) */ 
        SND_ASYNC = 0x0001,  /* play asynchronously */ 
        SND_NODEFAULT = 0x0002,  /* silence (!default) if sound not found */ 
        SND_MEMORY = 0x0004,  /* pszSound points to a memory file */ 
        SND_LOOP = 0x0008,  /* loop the sound until next sndPlaySound */ 
        SND_NOSTOP = 0x0010,  /* don't stop any currently playing sound */ 
        SND_NOWAIT = 0x00002000, /* don't wait if the driver is busy */ 
        SND_ALIAS = 0x00010000, /* name is a registry alias */ 
        SND_ALIAS_ID = 0x00110000, /* alias is a predefined ID */ 
        SND_FILENAME = 0x00020000, /* name is file name */ 
        SND_RESOURCE = 0x00040004  /* name is resource name or atom */ 
    } 
    [DllImport("CoreDll.dll", EntryPoint="PlaySound", SetLastError=true)] 
    private extern static int WCE_PlaySound(string szSound, IntPtr hMod, int flags);
    [DllImport("CoreDll.dll", EntryPoint = "PlaySound", SetLastError = true)] 
    private extern static int WCE_PlaySoundBytes (byte[] szSound, IntPtr hMod, int flags); 
    /// <summary> 
    /// Construct the Sound object to play sound data from the specified file. 
    /// </summary> 
    public Sound (string fileName) { 
        m_fileName = fileName; 
    } 
    /// <summary> 
    /// Construct the Sound object to play sound data from the specified stream. 
    /// </summary> 
    public Sound(Stream stream)    { 
        // read the data from the stream 
        m_soundBytes = new byte [stream.Length]; 
        stream.Read(m_soundBytes, 0,(int)stream.Length); 
    } 
    /// <summary> 
    /// Play the sound 
    /// </summary> 
    public void Play () { 
        // if a file name has been registered, call WCE_PlaySound, 
        //  otherwise call WCE_PlaySoundBytes 
        if (m_fileName != null) 
            WCE_PlaySound(m_fileName, IntPtr.Zero, (int) (Flags.SND_ASYNC | Flags.SND_FILENAME)); 
        else 
            WCE_PlaySoundBytes (m_soundBytes, IntPtr.Zero, (int) (Flags.SND_ASYNC | Flags.SND_MEMORY)); 
    } 
} 