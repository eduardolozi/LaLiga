using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Conversores
{
    public class ConversorDeImagem
    {
        public static string ConverterPathParaBase64(string path)
        {
            var bytes = File.ReadAllBytes(path);
            string fotoEmBase64 = Convert.ToBase64String(bytes);
            return fotoEmBase64;

        }

        public static Image ConverterBase64ParaImagem(string base64)
        {
            Image foto;
            byte[] bytes = Convert.FromBase64String(base64);
            using (var ms = new MemoryStream(bytes, 0, bytes.Length))
            {
                foto = Image.FromStream(ms, true);
            }
            return foto;
        }
    }
}
