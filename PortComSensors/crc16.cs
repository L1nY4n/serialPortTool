using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenserProj
{
    class crc16
    {

        public static byte[] getCrc16Code(String crcString)
        {
            string[] arr = crcString.Split(' ');
            string s = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            crcString = s;
            // 转换成字节数组  
            byte[] creBytes = HexString2Bytes(crcString);

            // 开始crc16校验码计算  
            CRC16Util crc16 = new CRC16Util();
            crc16.reset();
            crc16.update(creBytes);
            int crc = crc16.getCrcValue();
            // 16进制的CRC码  
            String crcCode = Convert.ToString(crc, 16).ToUpper();
            // 补足到4位  
            if (crcCode.Length < 4)
            {
                // crcCode = StringUtil.lefgPadding(crcCode, '0', 4);  
                crcCode = crcCode.PadLeft(4, '0');
            }
            return HexString2Bytes(crcString + crcCode);
        }


        public static String RealHexToStr(String str)
        {
            String hText = "0123456789ABCDEF";
            StringBuilder bin = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                bin.Append(hText[str[i] / 16]).Append(hText[str[i] % 16]).Append(' ');
            }
            return bin.ToString();
        }
        /** 
        * 十六进制字符串转换成字节数组 
        *  
        * @param hexstr 
        * @return 
        */
        public static byte[] HexString2Bytes(String hexstr)
        {
            byte[] b = new byte[hexstr.Length / 2];
            int j = 0;
            for (int i = 0; i < b.Length; i++)
            {
                char c0 = hexstr[j++];
                char c1 = hexstr[j++];
                b[i] = (byte)((parse(c0) << 4) | parse(c1));
            }
            return b;
        }


        /** 
        * 16进制char转换成整型 
        *  
        * @param c 
        * @return 
        */
        public static int parse(char c)
        {
            if (c >= 'a')
                return (c - 'a' + 10) & 0x0f;
            if (c >= 'A')
                return (c - 'A' + 10) & 0x0f;
            return (c - '0') & 0x0f;
        }




        public static string ByteArrayToHexString(byte[] data)//字节数组转为十六进制字符串  
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

    }




    public class CRC16Util
    {

        /**CRC值*/
        private int value = 0xffff;

        private static int[] CRC16_TABLE = {
    0x0000, 0xC0C1, 0xC181, 0x0140, 0xC301, 0x03C0, 0x0280, 0xC241,
    0xC601, 0x06C0, 0x0780, 0xC741, 0x0500, 0xC5C1, 0xC481, 0x0440,
    0xCC01, 0x0CC0, 0x0D80, 0xCD41, 0x0F00, 0xCFC1, 0xCE81, 0x0E40,
    0x0A00, 0xCAC1, 0xCB81, 0x0B40, 0xC901, 0x09C0, 0x0880, 0xC841,
    0xD801, 0x18C0, 0x1980, 0xD941, 0x1B00, 0xDBC1, 0xDA81, 0x1A40,
    0x1E00, 0xDEC1, 0xDF81, 0x1F40, 0xDD01, 0x1DC0, 0x1C80, 0xDC41,
    0x1400, 0xD4C1, 0xD581, 0x1540, 0xD701, 0x17C0, 0x1680, 0xD641,
    0xD201, 0x12C0, 0x1380, 0xD341, 0x1100, 0xD1C1, 0xD081, 0x1040,
    0xF001, 0x30C0, 0x3180, 0xF141, 0x3300, 0xF3C1, 0xF281, 0x3240,
    0x3600, 0xF6C1, 0xF781, 0x3740, 0xF501, 0x35C0, 0x3480, 0xF441,
    0x3C00, 0xFCC1, 0xFD81, 0x3D40, 0xFF01, 0x3FC0, 0x3E80, 0xFE41,
    0xFA01, 0x3AC0, 0x3B80, 0xFB41, 0x3900, 0xF9C1, 0xF881, 0x3840,
    0x2800, 0xE8C1, 0xE981, 0x2940, 0xEB01, 0x2BC0, 0x2A80, 0xEA41,
    0xEE01, 0x2EC0, 0x2F80, 0xEF41, 0x2D00, 0xEDC1, 0xEC81, 0x2C40,
    0xE401, 0x24C0, 0x2580, 0xE541, 0x2700, 0xE7C1, 0xE681, 0x2640,
    0x2200, 0xE2C1, 0xE381, 0x2340, 0xE101, 0x21C0, 0x2080, 0xE041,
    0xA001, 0x60C0, 0x6180, 0xA141, 0x6300, 0xA3C1, 0xA281, 0x6240,
    0x6600, 0xA6C1, 0xA781, 0x6740, 0xA501, 0x65C0, 0x6480, 0xA441,
    0x6C00, 0xACC1, 0xAD81, 0x6D40, 0xAF01, 0x6FC0, 0x6E80, 0xAE41,
    0xAA01, 0x6AC0, 0x6B80, 0xAB41, 0x6900, 0xA9C1, 0xA881, 0x6840,
    0x7800, 0xB8C1, 0xB981, 0x7940, 0xBB01, 0x7BC0, 0x7A80, 0xBA41,
    0xBE01, 0x7EC0, 0x7F80, 0xBF41, 0x7D00, 0xBDC1, 0xBC81, 0x7C40,
    0xB401, 0x74C0, 0x7580, 0xB541, 0x7700, 0xB7C1, 0xB681, 0x7640,
    0x7200, 0xB2C1, 0xB381, 0x7340, 0xB101, 0x71C0, 0x7080, 0xB041,
    0x5000, 0x90C1, 0x9181, 0x5140, 0x9301, 0x53C0, 0x5280, 0x9241,
    0x9601, 0x56C0, 0x5780, 0x9741, 0x5500, 0x95C1, 0x9481, 0x5440,
    0x9C01, 0x5CC0, 0x5D80, 0x9D41, 0x5F00, 0x9FC1, 0x9E81, 0x5E40,
    0x5A00, 0x9AC1, 0x9B81, 0x5B40, 0x9901, 0x59C0, 0x5880, 0x9841,
    0x8801, 0x48C0, 0x4980, 0x8941, 0x4B00, 0x8BC1, 0x8A81, 0x4A40,
    0x4E00, 0x8EC1, 0x8F81, 0x4F40, 0x8D01, 0x4DC0, 0x4C80, 0x8C41,
    0x4400, 0x84C1, 0x8581, 0x4540, 0x8701, 0x47C0, 0x4680, 0x8641,
    0x8201, 0x42C0, 0x4380, 0x8341, 0x4100, 0x81C1, 0x8081, 0x4040
    };

        /** 
         * 计算一个字节数组的CRC值 
         * @param data 
         */
        public void update(byte[] data)
        {

            for (int i = 0; i < data.Length; i++)
            {
                // 1.value 右移8位(相当于除以256)  
                // 2.value与进来的数据进行异或运算后再与0xFF进行与运算  
                //    得到一个索引index，然后查找CRC16_TABLE表相应索引的数据  
                // 1和2得到的数据再进行异或运算。  
                value = (value >> 8) ^ CRC16_TABLE[(value ^ data[i]) & 0xff];
            }

        }

        /** 
         * 计算一个byte的CRC值 
         *  
         * @param aByte 
         */
        public void update(byte aByte)
        {
            value = (value >> 8) ^ CRC16_TABLE[(value ^ aByte) & 0xff];
        }

        /** 
         * 重新设定CRC初始值 
         */
        public void reset()
        {
            value = 0xffff;
        }

        /** 
         * 获取计算好的CRC值 
         *  
         * @return 
         */
        public int getCrcValue()
        {
            //return ~value & 0xffff;
            return value;

        }

        /// <summary>  
        /// 生成FCS校验值  
        /// </summary>  
        /// <param name="ccc"></param>  
        /// <returns></returns>  
        public static byte[] makeCrc16(byte[] ccc)
        {

            CRC16Util crc16 = new CRC16Util();
            crc16.reset();
            crc16.update(ccc);
            //Console.WriteLine(RealHexToStr(crc16.getCrcValue().ToString()));  
            byte[] test = intToByte(crc16.getCrcValue());
            //log(RealHexToStr(crc16.getCrcValue().ToString()));  
            return test;

        }

        private static int[] copy(byte[] aa)
        {
            int[] cc = new int[aa.Length];
            for (int i = 0; i < aa.Length; i++)
            {
                cc[i] = aa[i];
            }
            return cc;
        }

        public static byte[] intToByte(int i)
        {
            byte[] abyte0 = new byte[4];
            abyte0[0] = (byte)(0xff & i);
            abyte0[1] = (byte)((0xff00 & i) >> 8);
            abyte0[2] = (byte)((0xff0000 & i) >> 16);
            abyte0[3] = (byte)((0xff000000 & i) >> 24);
            return abyte0;
        }

        private static void log(Object obj)
        {
            //(obj);  
        }

        private static void printBytes(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                //System.out.print(bytes[i]+ "-");  
            }
        }

        public static String RealHexToStr(String str)
        {
            String hText = "0123456789ABCDEF";
            StringBuilder bin = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                bin.Append(hText[str[i] / 16]).Append(hText[str[i] % 16]).Append(' ');
            }
            return bin.ToString();
        }

    }

    /// <summary>
    /// byte[]转为16进制字符串
    /// </summary>
    /// <param name="bytes"></param>
    /// <returns></returns>

}
