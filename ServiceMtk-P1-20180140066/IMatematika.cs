using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20180140066
{
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        [FaultContract(typeof(Mathfault))]
        int Tambah(int a, int b);
        [OperationContract]
        [FaultContract(typeof(Mathfault))]
        int Kurang(int a, int b);
        [OperationContract]
        [FaultContract(typeof(Mathfault))]
        int Kali(int a, int b);
        [OperationContract]
        [FaultContract(typeof(Mathfault))]
        int Bagi(int a, int b);
        [OperationContract]
        [FaultContract(typeof(Mathfault))]
        Koordinat TKoordinat(Koordinat a, Koordinat b);

    }

    [DataContract]
    public class Koordinat
    {
        private int _x, _y;
        [DataMember]
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }

    [DataContract]
    class Mathfault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }

}
