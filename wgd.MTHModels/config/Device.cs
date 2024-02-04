﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.MTHModels
{
    public class Device
    {
        /// <summary>
        /// id地址
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 通信类集合
        /// </summary>
        public List<Group> GroupList { get; set; }

        /// <summary>
        /// 通信状态
        /// </summary>
        public bool IsConnected { get; set; }
        /// <summary>
        /// 重连时间
        /// </summary>
        public int ReCinnectTime { get; set; } = 2000;
        /// <summary>
        /// 重连标志
        /// </summary>
        public bool ReConnectAttempts { get; set; }
    }
}
