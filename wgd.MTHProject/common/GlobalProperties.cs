using ModbusTCPLib;
using System;
using System.Text;
using thinger.DataConvertLib;


using wgd.MTHModels;

namespace wgd.MTHProject.common
{
    public class GlobalProperties
    {
        public static Device Device { set; get; }

        public static Action<int, string> AddLog;

        public static ModbusTCP Modbus { get; set; }
        ///<summary>
        ///确定大小端
        ///</summary>
        public static DataFormat dataFormat = DataFormat.ABCD;


        /// <summary>
        ///通过标签名称找对应的Variable对象
        ///</summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        private static Variable FindVariable(string varName)
        {
            foreach (var item in Device.GroupList)
            {
                var res = item.VarList.Find(c => c.VarName == varName);
                if (res != null)
                {
                    return res;
                }
            }
            return null;
        }

        public static bool CommonWrite(string varName, string varValue)
        {
            var variable = FindVariable(varName);

            //第一步：先找到变量对象
            if (variable != null)
            {
                // 第二步: 获取变量类型
                DataType dataType = (DataType)Enum.Parse(typeof(DataType), variable.DataType, true);
                // 第三步: 获取写入数据
                var result = MigrationLib.SetMigrationValue(varValue, dataType, variable.Scale.ToString(), variable.Offset.ToString());
                if (result.IsSuccess)
                {
                    // 第四步:写入数据
                    switch (dataType)
                    {
                        case DataType.Bool:
                            return Modbus.PreSetSingleColls(variable.Start, Convert.ToBoolean(result.Content));
                        case DataType.Short:
                            return Modbus.PreSetSingleRegister(variable.Start, Convert.ToInt16(result.Content));
                        case DataType.UShort:
                            return Modbus.PreSetSingleRegister(variable.Start, Convert.ToUInt16(result.Content));
                        case DataType.Int:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromInt(Convert.ToInt32(result.Content), dataFormat));
                        case DataType.UInt:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromUInt(Convert.ToUInt32(result.Content), dataFormat));
                        case DataType.Float:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromFloat(Convert.ToSingle(result.Content), dataFormat));
                        case DataType.Double:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromDouble(Convert.ToDouble(result.Content), dataFormat));
                        case DataType.Long:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromLong(Convert.ToInt64(result.Content), dataFormat));
                        case DataType.ULong:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromULong(Convert.ToUInt64(result.Content), dataFormat));
                        case DataType.String:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromString(result.Content, Encoding.ASCII));
                        case DataType.ByteArray:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromHexString(result.Content));
                        case DataType.HexString:
                            return Modbus.PreSetMultiRegister(variable.Start, ByteArrayLib.GetByteArrayFromHexString(result.Content));
                        default:
                            break;

                    }
                }

            }

            return false;
        }
    }
}
