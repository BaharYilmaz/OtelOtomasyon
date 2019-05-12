using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu
{
   public class HashMapChain
    {
        public HashEntry[] table;
        Heap h;

        public HashMapChain()
        {
            table = new HashEntry[10];
            for (int i = 0; i < 10; i++)
            {
                table[i] = null;
            }
        }
        public void Add(string key, OtelBilgi value)
        {
            int hash = hashFonksiyonu(key, 10);
            if (table[hash] == null)
            {
                table[hash] = new HashEntry(key);
                //table[hash].h = new Heap(100);
                //table[hash].h.Insert(value);
            }
            else
            {
               // table[hash].h.Insert(value);
            }

        }

        private int hashFonksiyonu(string key, int tabloBoyutu)
        {
            int sonuc = 0;

            int hashDeger = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hashDeger += key[i];

            }
            sonuc = hashDeger % tabloBoyutu; //tablo boyutuna göre mo alma
            return sonuc;
        }
        public void OtelBilgiGuncelle(Heap h, OtelBilgi otel)
        {
            //for (int i = 0; i < h.currentSize; i++)
            //{
            //    if (h.heapArray[i].otel. == ogr.ogrenciNo)
            //        h.heapArray[i].ogr = ogr;
            //}
        }
    }
}
