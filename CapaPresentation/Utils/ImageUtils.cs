using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentation.Utils
{
    internal class ImageUtils
    {
        // MemoryStream crea un flujo de datos en la memoria RAM.
        // Convierte la informacion almacenada como un array de bytes para luego
        // ser accesada
        public static string imageToData(Image img, ImageFormat format)
        {

            MemoryStream ms = new MemoryStream();
            img.Save(ms, format);

            byte[] data = ms.ToArray(); //Aca se puede ver como se transforma la informacion a bytes

            string imgData = Convert.ToBase64String(data);
            return imgData;
        }

        public static Image dataToImage(string data)
        {
            byte[] byteData = Convert.FromBase64String(data);

            MemoryStream ms = new MemoryStream(byteData, 0, byteData.Length);
            Image img = Image.FromStream(ms, true);
            return img;
        }
    }
}
