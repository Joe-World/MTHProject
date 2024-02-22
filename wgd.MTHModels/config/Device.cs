using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wgd.MTHModels
{
    public class Device
    {
        /// <summary>
        /// ip地址
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
        public int ReConnectTime { get; set; } = 2000;
        /// <summary>
        /// 重连标志
        /// </summary>
        public bool ReConnect { get; set; }

        /// <summary>
        /// slave实时读取数据
        /// </summary>
        public Dictionary<string, object> CurrentValue = new Dictionary<string, object>();

        /// <summary>
        /// 定义报警触发事件和消除事件
        /// </summary>
        public event Action<bool, Variable> AlarmTrigEvent;


        public void UpdateVariable(Variable variable)
        {
            if (CurrentValue.ContainsKey(variable.VarName))
            {
                CurrentValue[variable.VarName] = variable.VarValue;
            }
            else
            {
                CurrentValue.Add(variable.VarName, variable.VarValue);
            }

            // 报警检测
            CheckAlarm(variable);
        }

        private void CheckAlarm(Variable variable)
        {
            // 上升沿报警检测  只有相关报警变量才为T
            if (variable.PosAlarm)
            {
                bool currentValue = variable.VarValue.ToString() == "1"?true:false;

                if (variable.PosCacheValue == false && currentValue == true)
                {
                    // 检测到了报警触发 
                    AlarmTrigEvent?.Invoke(true, variable);
                }


                if (variable.PosCacheValue == true && currentValue == false)
                {
                    // 检测到了报警消除  
                    AlarmTrigEvent?.Invoke(false, variable);
                }
                variable.PosCacheValue = currentValue;
            }

            // 下降沿报警检测
            if (variable.NegAlarm)
            {
                bool currentValue = variable.VarValue.ToString() == "True";
                if (variable.NegCacheValue == true & currentValue == false)
                {
                    // 检测到了报警触发
                    AlarmTrigEvent?.Invoke(true, variable);
                }
                if (variable.NegCacheValue == false & currentValue == true)
                {
                    // 检测到了报警消除
                    AlarmTrigEvent?.Invoke(false, variable);
                }
                variable.NegCacheValue = currentValue;
            }
        }



        public object this[string key]
        {
            get
            {
                if (CurrentValue.ContainsKey(key))
                {
                    return CurrentValue[key];
                }
                else { return null; }

            }
        }


    }
}
