using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Controllers
{
    public class Table
    {
        private string iD;
        private string tenBan;
        private string khuVuc;
        private string trangThai;

        public Table(string iD, string tenBan, string khuVuc, string trangThai)
        {
            this.ID = iD;
            this.TenBan = tenBan;
            this.KhuVuc = khuVuc;
            this.TrangThai = trangThai;
        }
        public Table(DataRow row)
        {
            this.ID = row["maBan"].ToString();
            this.TenBan = row["tenBan"].ToString();
            this. KhuVuc = row["khuVuc"].ToString();
            this.TrangThai = row["trangThai"].ToString();
        }
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }

        public string KhuVuc
        {
            get { return khuVuc; }
            set { khuVuc = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public string Name { get; internal set; }
    }
}
