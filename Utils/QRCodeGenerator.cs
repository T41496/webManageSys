using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using webTRON_Management_Software.Views.Accountant;

namespace webTRON_Management_Software.Utils
{
    class QRCodeGenerator
    {
        public static QRCoder.QRCode generateQRCode(string refId)
        {
            string s = refId;
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var info = QG.CreateQrCode(refId, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(info);
            return code;
        }
    }
}