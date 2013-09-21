namespace HID.Model
{
    /// <summary>
    /// 定义 IC_Card_Data 数据结构
    /// </summary>
    public class cIC_Card_Data
    {
        private string ic_id = "";
        private string ic_fun = "";
        private string floor_data = "";
        private string ic_funa = "";
        private int _ic_num;
        private string _持卡人 = "";
        private string _电梯ID = "";
        private byte[] block_8 = new byte[16];
        private byte[] block_9 = new byte[16];
        private byte[] block_10 = new byte[16];
        //private byte[] block_9;
        //private byte[] block_10;

        public string 持卡人
        {
            get { return _持卡人; }
            set { _持卡人 = value; }
        }

        public string 电梯ID
        {
            get { return _电梯ID; }
            set { _电梯ID = value; }
        }

        public string IC_ID
        {
            get { return ic_id; }
            set { ic_id = value; }
        }
        /// <summary>
        /// 单位全称
        /// </summary>
        public string IC_Fun
        {
            get { return ic_fun; }
            set { ic_fun = value; }
        }
        /// <summary>
        /// 单位税号
        /// </summary>
        public string Floor_Data
        {
            get { return floor_data; }
            set { floor_data = value; }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string IC_FunA
        {
            get { return ic_funa; }
            set { ic_funa = value; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public int ic_num
        {
            get { return _ic_num; }
            set { _ic_num = value; }
        }

        public byte[] Block_8
        {
            get { return block_8; }
            set { block_8 = value; }
        }

        public byte[] Block_9
        {
            get { return block_9; }
            set { block_9 = value; }
        }

        public byte[] Block_10
        {
            get { return block_10; }
            set { block_10 = value; }
        }
    }
}
