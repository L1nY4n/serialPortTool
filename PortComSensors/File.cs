using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SenserProj
{
    class Output
    {
        /// <summary>
        /// 输出指定信息到文本文件
        /// </summary>
        /// <param name="msg">输出信息</param>
        public static void WriteMessage(string msg)
        {
            using (FileStream fs = new FileStream(@"d:\test.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.WriteLine("{0}\n", msg, DateTime.Now);
                    sw.Flush();
                }
            }
        }

        /// <summary>
        /// 输出指定信息到文本文件
        /// </summary>
        /// <param name="path">文本文件路径</param>
        /// <param name="msg">输出信息</param>
        public static void WriteMessage(string path, string msg)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                using (fs)
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.BaseStream.Seek(0, SeekOrigin.End);
                        sw.WriteLine("{0}\n", msg, DateTime.Now);
                        sw.Flush();
                    }
                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }

          
        }
    }
}
