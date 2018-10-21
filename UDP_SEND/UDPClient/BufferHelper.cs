using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UDPClient
{
  public class BufferHelper
    {
    
    /// <summary>
    /// 转换为字节数组
    /// </summary>
    /// <param name="filename">文件名</param>
    /// <returns>字节数组</returns>
    public  byte[] GetBinaryFile(string filename)
    {
        if (File.Exists(filename))
        {
            FileStream Fsm = null;
            try
            {
                Fsm = File.OpenRead(filename);
                return this.ConvertStreamToByteBuffer(Fsm);
            }
            catch
            {
                return new byte[0];
            }
            finally
            {
                Fsm.Close();
            }
        }
        else
        {
            return new byte[0];
        }
    }

    /// <summary>
    /// 流转化为字节数组
    /// </summary>
    /// <param name="theStream">流</param>
    /// <returns>字节数组</returns>
    public byte[] ConvertStreamToByteBuffer(System.IO.Stream theStream)
    {
        int bi;
        MemoryStream tempStream = new System.IO.MemoryStream();
        try
        {
            while ((bi = theStream.ReadByte()) != -1)
            {
                tempStream.WriteByte(((byte)bi));
            }
            return tempStream.ToArray();
        }
        catch
        {
            return new byte[0];
        }
        finally
        {
            tempStream.Close();
        }
    }
    }
}
