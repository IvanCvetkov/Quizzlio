using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Programming_Quizes.Database
{
    public class BtnToDb
    {
        [Key]
        public int Id { get; set; }
        public bool DoneBefore { get; set; } = false;
        public bool Passed { get; set; } = false;
    }
}
