using System;
using System.Linq;

using System.Net.Sockets;
using System.Net;

using System.IO;
using System.Threading;
using wgd.Utils;
using HslCommunication.Core;

namespace ModbusTCPLib
{
    public class ModbusTCP
    {
        #region 全局字段和属性
        public int SendTimeOut { get; set; } = 2000;
        public int ReceiveTimeOut { get; set; } = 2000;
        private Socket socket;
        //简单锁对象
        SimpleHybirdLock simpleHybird = new SimpleHybirdLock();
        //每次接收时间
        private int SleepTime { get; set; } = 1;
        //最大等待次数
        public int MaxWaitTime { get; set; } = 10;

        private byte SlavId { get; set; } = 0x01;
        #endregion
        #region 连接和断开连接方法
        /// <summary>
        /// 建立连接
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <param name="port">端口号</param>
        /// <returns></returns>
        public bool Connect(string ip, int port)
        {
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.socket.SendTimeout = SendTimeOut;
            this.socket.ReceiveTimeout = ReceiveTimeOut;

            try
            {
                if (IPAddress.TryParse(ip, out IPAddress iPAddress))
                {
                    this.socket.Connect(iPAddress, port);
                }
                else
                {
                    this.socket.Connect(ip, port);
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        /// <summary>
        /// 断开连接
        /// </summary>
        public void disConnect()
        {
            if (this.socket != null)
            {
                this.socket.Close();
            }
        }
        #endregion


        #region 01H功能码输出线圈
        //发送报文格式:事务标识符（2字节）+协议标识（2字节）+长度（2字节）+单元标识+功能码+起始线圈地址+线圈长度
        //接收报文格式 事务标识符（2字节）+协议标识（2字节）+长度（2字节）+单元标识+功能码+字节计数+具体数据
        public byte[] ReadOutputColls(ushort start, ushort length)
        {
            //字节集合
            //拼接报文
            ByteArray SendCommand = new ByteArray();
            //事务标识符+协议标识
            SendCommand.Add(0x00, 0x00, 0x00, 0x00);
            //长度+单元标识+功能码
            SendCommand.Add(0x00, 0x06, SlavId, 0x01);
            //起始线圈地址+线圈长度
            SendCommand.Add(start);
            SendCommand.Add(length);

            byte[] receive = null;
            int byteLength = length == 8 ? length / 8 : length / 8 + 1;
            //发送和接收报文
            if (SendAndReceive(SendCommand.Array, ref receive))
            {
                if (receive[6] == SlavId && receive[7] == 0x01 && receive[8] == byteLength)
                {
                    //解析报文
                    byte[] result = new byte[byteLength];
                    Array.Copy(receive, 9, result, 0, byteLength);
                    return result;
                }
            }
            return null;
        }

        public bool Connect(string text1, string text2)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region 02H功能码输入线圈
        //发送报文格式:事务标识符（2字节）+协议标识（2字节）+长度（2字节）+单元标识+功能码+起始线圈地址(2字节)+线圈长度（2字节）
        //接收报文格式 事务标识符（2字节）+协议标识（2字节）+长度（2字节）+单元标识+功能码+字节计数（2字节）+具体数据
        public byte[] ReadInputColls(ushort start, ushort length)
        {
            ByteArray SendCommand = new ByteArray();
            //事务标识符（2字节）+协议标识（2字节）
            SendCommand.Add(0x00, 0x00, 0x00, 0x00);
            //长度+单元标识+功能码
            SendCommand.Add(0x00, 0x06, SlavId, 0x02);
            //起始线圈地址+线圈长度
            SendCommand.Add(start);
            SendCommand.Add(length);


            byte[] receive = null;
            int byteLength = length == 8 ? length / 8 : length / 8 + 1;
            if (SendAndReceive(SendCommand.Array, ref receive))
            {
                if (receive[6] == SlavId && receive[7] == 0x02 && receive[8] == byteLength)
                {
                    byte[] result = new byte[1024];
                    Array.Copy(receive, 9, result, 0, byteLength);
                    return result;
                }
            }
            return null;
        }
        #endregion
        #region 03H功能码输出寄存器
        //发送报文格式:事务标识符（2字节）+协议标识（2字节）+长度（2字节）+单元标识+功能码+起始寄存器地址+寄存器长度
        //接收报文格式 事务标识符（2字节）+协议标识（2字节）+长度（2字节）+单元标识+功能码+字节计数+具体数据
        public byte[] ReadOutputRegister(ushort start, ushort length)
        {
            ByteArray SendCommand = new ByteArray();
            //事务标识符（2字节）+协议标识（2字节）
            SendCommand.Add(0x00, 0x00, 0x00, 0x00);
            //长度+单元标识+功能码
            SendCommand.Add(0x00, 0x06, SlavId, 0x03);
            //起始线圈地址+线圈长度
            SendCommand.Add(start);
            SendCommand.Add(length);

            byte[] receive = null;
            int byteLength = length * 2;//一个寄存器占两个字节，类型为short，表示范围为-325125 到 325124
            if (SendAndReceive(SendCommand.Array, ref receive))
            {
                if (receive[6] == SlavId && receive[7] == 0x03 && receive[8] == byteLength)
                {
                    byte[] result = new byte[byteLength];
                    Array.Copy(receive, 9, result, 0, byteLength);
                    return result;
                }
            }
            return null;
        }
        #endregion
        #region 04H功能码输入寄存器
        //发送报文格式:事务标识符（2字节）+协议标识（2字节）+长度（2字节）+单元标识+功能码+起始寄存器地址+寄存器长度
        //接收报文格式 事务标识符（2字节）+协议标识（2字节）+长度（2字节）+单元标识+功能码+字节计数+具体数据
        public byte[] ReadInputRegister(ushort start, ushort length)
        {
            ByteArray SendCommand = new ByteArray();
            //事务标识符（2字节）+协议标识（2字节）
            SendCommand.Add(0x00, 0x00, 0x00, 0x00);
            //长度+单元标识+功能码
            SendCommand.Add(0x00, 0x06, SlavId, 0x04);
            //起始线圈地址+线圈长度
            SendCommand.Add(start);
            SendCommand.Add(length);

            byte[] receive = null;
            int byteLength = length * 2;//一个寄存器占两个字节，类型为short，表示范围为-325125 到 325124
            if (SendAndReceive(SendCommand.Array, ref receive))
            {
                if (receive[6] == SlavId && receive[7] == 0x03 && receive[8] == byteLength)
                {
                    byte[] result = new byte[byteLength];
                    Array.Copy(receive, 9, result, 0, byteLength);
                    return result;
                }
            }
            return null;

        }
        #endregion
        #region 05功能码预制单线圈
        public bool PreSetSingleColls(ushort start, bool value)
        {
            ByteArray SendCommand = new ByteArray();
            SendCommand.Add(0x00, 0x00, 0x00, 0x00);
            SendCommand.Add(0x00, 0x06, SlavId, 0x05);
            SendCommand.Add(start);
            SendCommand.Add(value ? (byte)0xFF : (byte)0x00, 0x00);
            byte[] receive = null;
            if (SendAndReceive(SendCommand.Array, ref receive))
            {
                if (receive.Length == 12)
                {
                    //判断两个字节数组是否相同
                    return ByteArrayEquals(receive, SendCommand.Array);
                }
            }
            return false;
        }
        #endregion
        #region 06功能码预制单寄存器
        public bool PreSetSingleRegister(ushort start, byte[] value)
        {
            ByteArray SendCommand = new ByteArray();
            SendCommand.Add(0x00, 0x00, 0x00, 0x00);
            SendCommand.Add(0x00, 0x06, SlavId, 0x06);
            SendCommand.Add(start);
            SendCommand.Add(value);
            byte[] receive = null;
            if (SendAndReceive(SendCommand.Array, ref receive))
            {
                if (receive.Length == 12)
                {
                    //判断两个字节数组是否相同
                    return ByteArrayEquals(receive, SendCommand.Array);
                }
            }
            return false;
        }
        //方法重载
        public bool PreSetSingleRegister(ushort start, ushort value)
        {
            return PreSetSingleRegister(start, BitConverter.GetBytes(value).Reverse().ToArray());
        }
        public bool PreSetSingleRegister(ushort start, short value)
        {
            return PreSetSingleRegister(start, BitConverter.GetBytes(value).Reverse().ToArray());
        }
        public bool PreSetSingleRegister(ushort start, float value)
        {
            return PreSetSingleRegister(start, BitConverter.GetBytes(value).Reverse().ToArray());
        }
        public bool PreSetSingleRegister(ushort start, double value)
        {
            return PreSetSingleRegister(start, BitConverter.GetBytes(value).Reverse().ToArray());
        }
        #endregion
        #region 0FH功能码预制多寄存器
        public bool PreSetMultiColls(ushort start, bool[] values)
        {
            ByteArray SendCommand = new ByteArray();
            byte[] sendLength = GetByteArrayFromBootArray(values);
            SendCommand.Add(0x00, 0x00, 0x00, 0x00);
            SendCommand.Add((short)(7 + sendLength.Length));
            SendCommand.Add(SlavId, 0x0F);
            SendCommand.Add(start);
            //线圈数量
            SendCommand.Add((short)values.Length);
            //字节计算
            SendCommand.Add((short)sendLength.Length);
            byte[] receive = null;

            if (SendAndReceive(SendCommand.Array, ref receive))
            {
                byte[] send = new byte[1024];
                Array.Copy(SendCommand.Array, 0, send, 0, 12);
                send[4] = 0x00;
                send[5] = 0x06;
                return ByteArrayEquals(send, receive);
            }
            return false;
        }

        #endregion
        #region 10H预制多寄存器
        public bool PreSetMultiRegister(ushort start, byte[] values)
        {
            if (values == null || values.Length == 0 || values.Length % 2 == 1)
            {
                return false;
            }
            ByteArray SendCommand = new ByteArray();
            SendCommand.Add(0x00, 0x00, 0x00, 0x00);
            SendCommand.Add((ushort)(7 + values.Length));
            SendCommand.Add(SlavId, 0x10);
            SendCommand.Add(start);
            //寄存器数量
            SendCommand.Add((short)(values.Length / 2));
            //字节计算
            SendCommand.Add((byte)(values.Length));
            //字节数据
            SendCommand.Add(values);
            byte[] receive = null;

            if (SendAndReceive(SendCommand.Array, ref receive))
            {
                byte[] send = new byte[12];
                Array.Copy(SendCommand.Array, 0, send, 0, 12);
                send[4] = 0x00;
                send[5] = 0x06;
                return ByteArrayEquals(send, receive);
            }
            return false;
        }
        #region 判断两字节数组是否相等
        //判断两个数组是否相等
        private bool ByteArrayEquals(byte[] a1, byte[] a2)
        {
            return BitConverter.ToString(a1) == BitConverter.ToString(a2);
        }
        #endregion
        #endregion
        #region 布尔数组转字节数组
        private byte[] GetByteArrayFromBootArray(bool[] value)
        {
            int byteLength = value.Length == 8 ? value.Length / 8 : value.Length / 8 + 1;
            byte[] result = new byte[byteLength];
            for (int i = 0; i < result.Length; i++)
            {
                int total = value.Length < 8 * (i + 1) ? value.Length - 8 * i : 8;
                for (int j = 0; j < total; j++)
                {
                    result[i] = SetBitValue(result[i], j, value[8 * i + j]);
                }
            }
            return result;
        }
        private byte SetBitValue(byte src, int bit, bool value)
        {
            return value ? (byte)(src | (byte)Math.Pow(2, bit)) : (byte)(src & ~(byte)Math.Pow(2, bit));
        }
        #endregion
        #region 接收和发送方法
        private bool SendAndReceive(byte[] send, ref byte[] receive)
        {
            //加锁
            simpleHybird.Enter();
            byte[] buffer = new byte[1024];
            //定义一个存储区
            MemoryStream stream = new MemoryStream();

            try
            {
                //发送报文
                socket.Send(send, send.Length, SocketFlags.None);
                int timer = 0;
                while (true)
                {
                    Thread.Sleep(SleepTime);
                    //判断缓冲区是否有数据
                    if (socket.Available > 0)
                    {
                        int count = socket.Receive(buffer, SocketFlags.None);
                        stream.Write(buffer, 0, count);//写入存储区
                    }
                    else
                    {
                        timer++;
                        if (stream.Length > 0)
                        {
                            break;
                        }
                        else if (timer > MaxWaitTime)//超过读取次数
                        {
                            return false;
                        }
                    }
                }
                receive = stream.ToArray();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                //解锁
                simpleHybird.Leave();
            }
        }
        #endregion

    }
}
