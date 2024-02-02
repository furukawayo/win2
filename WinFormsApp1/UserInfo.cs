using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public sealed class UserInfo
    {

        public UserInfo(
        string id,
        string mail,
        string adress,
        string plan)
        {
            ID = id;
            Mail = mail;
            Adress = adress;
            Plan = plan;
        }
        
        public string ID { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Plan { get; set; }
    }
}
