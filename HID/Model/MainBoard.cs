namespace HID.Model
{
    public class MainBoard
    {
        private string _id;
        private string _number;
        private string _companyName;

        public MainBoard()
        {
            _id = @"";
            _number = @"";
            _companyName = @"";
        }

        public MainBoard(string id, string number, string companyName)
        {
            _id = id;
            _number = number;
            _companyName = companyName;
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
