using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace webTRON_Management_Software.Utils
{
    class MedicineRow
    {
        public Guna2TextBox MedicineName { get; set; }
        public Guna2DateTimePicker StartDate { get; set; }
        public Guna2TextBox EndDay { get; set; }
        public Guna2TextBox Remarks { get; set; }
    }
}
