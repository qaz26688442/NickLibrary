using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickLibrary.MVC.Interfaces
{
    /// <summary>
    /// 實作Log紀錄的儲存機制Ex:資料庫,txt,email 等等
    /// </summary>
    public interface LogRepository
    {
        void Save();
    }
}
