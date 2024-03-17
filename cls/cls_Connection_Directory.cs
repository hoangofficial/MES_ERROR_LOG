using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PID_Converter.SQL_Class
{
    class cls_Connection_Directory
    {
        public string HN = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.121.61.111)(PORT=3521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=HNMESP1)));User Id=HNMES_APP;Password=ppa_hnmes_123!;";
        public string HW = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.121.61.99)(PORT=3521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=HWMESP1)));User Id=HWMES_APP;Password=app_hwmes_2021!;";
        public string H9 = "Data Source=(DESCRIPTION =(ENABLE=BROKEN)(ADDRESS_LIST =(LOAD_BALANCE = OFF)(FAILOVER = ON)(ADDRESS = (PROTOCOL=TCP)(HOST = 10.122.8.50)(PORT=3521))(ADDRESS = (PROTOCOL=TCP)(HOST = 10.122.8.51)(PORT=3521)))(CONNECT_DATA = (SERVICE_NAME = H9MESP1)(FAILOVER_MODE = (TYPE = select) (METHOD = basic) (RETRIES = 20) (DELAY = 3))));User Id=H9MES_APP;Password=ppa_h9mes_123!;";
        public string HB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.119.211.199)(PORT=3521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=HTMESP2)));User Id=HBMES_APP;Password=app_2018!;";
        public string HT = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.119.211.199)(PORT=3521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=HTMESP2)));User Id=HTMES_APP;Password=app_pass00!;";
    }
}
