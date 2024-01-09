using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{
    class ThiSinh
    {
        private int sobaodanh;
        private string hoten;
        private string diachi;
        private int mucuutien;

        public ThiSinh()
        {

        }
        public ThiSinh(int sobaodanh,string hoten,string diachi,int mucuutien)
        {
            this.sobaodanh = sobaodanh;
            this.hoten = hoten;
            this.diachi = diachi;
            this.mucuutien = mucuutien;
        }
        public int Sobaodanh
        {
            get { return sobaodanh; }
            set { sobaodanh = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public int Mucuutien
        {
            get { return mucuutien; }
            set { mucuutien = value; }
        }
    }
}
