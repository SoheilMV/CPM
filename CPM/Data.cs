using System;
using System.Text;

namespace CPM
{
    internal class Data
    {
        private string _key = string.Empty;

        /// <summary>The unix timestamp of the check completion.</summary>
        public int UnixDate { get; set; }

        /// <summary>The timestamp of the check completion as a formatted date.</summary>
        public string Timestamp { get { return (new DateTime(1970, 1, 1)).AddSeconds(UnixDate).ToShortDateString(); } }

        /// <summary>The timestamp of the check completion as a DateTime object.</summary>
        public DateTime Time { get { return (new DateTime(1970, 1, 1)).AddSeconds(UnixDate); } }

        public Data()
        {
            UnixDate = (int)Math.Round((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds);
            _key = KeyGenerator(10);
        }

        private string KeyGenerator(int length, string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890")
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            StringBuilder res = new StringBuilder();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
