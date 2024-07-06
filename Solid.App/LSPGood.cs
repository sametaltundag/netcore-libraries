using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPGood
{
    // Alt seviye sınıflardan oluşan nesnelerin/sınıfların, ana(üst) sınıfın nesneleri ile yer değiştirdikleri zaman, aynı davranışı sergilemesi

    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı");
        }
    }


    public class IPhone : BasePhone,ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi.");
        }
    }

    public class Nokia3310 : BasePhone
    {

    }

}
