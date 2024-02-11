using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wgd.MTHModels
{
    /// <summary>
    /// 所有窗体的枚举,小于临界窗体为固定窗体
    /// </summary>
    public enum FormNames
    {
        集中监控,
        临界窗体,
        配方管理,
        报警追溯,
        参数设置,
        历史趋势,
        用户管理,
    }
    //
    // 摘要:
    //     常规数据类型
    [Description("常规数据类型")]
    public enum DataType
    {
        //
        // 摘要:
        //     布尔类型
        Bool = 0,
        //
        // 摘要:
        //     字节类型
        Byte = 1,
        //
        // 摘要:
        //     有符号16位短整型
        Short = 2,
        //
        // 摘要:
        //     无符号16位短整型
        UShort = 3,
        //
        // 摘要:
        //     有符号32位短整型
        Int = 4,
        //
        // 摘要:
        //     无符号32位短整型
        UInt = 5,
        //
        // 摘要:
        //     32位单精度浮点数
        Float = 6,
        //
        // 摘要:
        //     64位双精度浮点数
        Double = 7,
        //
        // 摘要:
        //     有符号64位长整型
        Long = 8,
        //
        // 摘要:
        //     无符号64位长整型
        ULong = 9,
        //
        // 摘要:
        //     字符串类型
        String = 10,
        //
        // 摘要:
        //     字节数组
        ByteArray = 11,
        //
        // 摘要:
        //     16进制字符串
        HexString = 12
    }
}
