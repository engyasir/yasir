//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectricPro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_2
    {
        public int Information_ID { get; set; }
        public string Full_Name { get; set; }
        public Nullable<System.DateTime> Birth_Date { get; set; }
        public string Birth_Place { get; set; }
        public string Name_of_presonal_card_Office { get; set; }
        public string Number_Of_File_Card { get; set; }
        public string Number_Of_Page_Card { get; set; }
        public string Card_Number { get; set; }
        public Nullable<System.DateTime> Card_Issuse_Date { get; set; }
        public string Sertificate_Number { get; set; }
        public Nullable<System.DateTime> Sertificate_Issuse_Date { get; set; }
        public string Marride_State { get; set; }
        public string Wife_Name { get; set; }
        public Nullable<int> boys_Number { get; set; }
        public Nullable<int> Daughter_Number { get; set; }
        public Nullable<int> Total_Children { get; set; }
        public string Food_Card_Number { get; set; }
        public Nullable<System.DateTime> Food_Card_Issuse { get; set; }
        public string Gavernatore { get; set; }
        public string Relajon { get; set; }
        public string Street { get; set; }
        public Nullable<int> House { get; set; }
        public string Mobile_Number { get; set; }
        public string E_Mail { get; set; }
    
        public virtual Table_1 Table_1 { get; set; }
        public virtual Table_2 Table_21 { get; set; }
        public virtual Table_2 Table_22 { get; set; }
    }
}
