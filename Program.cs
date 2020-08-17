using System;

namespace Deneme25_Throw
{
    class Numbers
    {
        private int mDeger;
        public Numbers(int deger)
        {
            if (mDeger > 100)
                throw new OverflowException("Değer 100'den büyük olamaz!");
            else
                this.mDeger = deger;
        }
        public int Deger
        {
            get { return mDeger; }
            set
            {
                if (value > 100)
                    throw new OverflowException("Değer 100'den büyük olamaz!");
                mDeger = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Numbers num = new Numbers(200);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                //throw;
            }
        }
    }
}
