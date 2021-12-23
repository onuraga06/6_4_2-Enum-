using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_2_Enum_
{
    public class Bisiklet
    {
        public Fren_Tipi Fren { get; set; }
        public KadroTipi Kadro { get; set; }
        int _modelYil;
        public int ModelYil {
            get { return _modelYil; }
            set {
                if (value > 1990 && value <= DateTime.Today.Year)
                {
                    _modelYil = value;
                }
                else
                {
                    throw new Exception("1990-2022 Arasında Tarih Giriniz");   
                }
                }
        }
        //Aracın Yasini Bulmak Icın Bugunun yılından Kullanıcın verdıgı degerı Cıkarıyıoruz.
        public int Yas { get {return DateTime.Today.Year-ModelYil; }  private set {; } }
        public override string ToString()
        {
            return $"Bisiklet Freni={this.Fren}- Kadrosu ={this.Kadro}- Yaşı={this.Yas}";
        }

    }
}
