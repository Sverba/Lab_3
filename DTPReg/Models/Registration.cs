using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTPReg.Models
{
    public class Registration
    {
        //Id офрмлення ДТП
        public int Id { get; set; }
        //ПІП порушника
        public string PIP { get; set; }
        //Номер водійського посвідчення порушника
        public string NPos { get; set; }
        //Дата народження порушника
        public string Date_Birth { get; set; }
        //Марка автомобіля
        public string Marka_Auto { get; set; }
        //Номерний знак автомобіля
        public string Nomer_Auto { get; set; }
        //Адреса порушення
        public string Address { get; set; }
        // ID типу правопорушення 
        public int TypeId { get; set; }
        //Дата порушення
        public string Date_Por { get; set; }
    }
}