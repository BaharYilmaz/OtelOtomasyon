﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu
{
   public class IkiliAramaAgaci
    {
        private IkiliAramaAgaciDugumu kok;
        private string dugumler;
        public string tempOrtalama = "";
        public string advancedTemp = " ";
        public bool kilit = false;
        public int Yukseklik = -1;
        
        public IkiliAramaAgaci(IkiliAramaAgaciDugumu kok)
        {
            this.kok = kok;
        }

        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(IkiliAramaAgaciDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(IkiliAramaAgaciDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        private void Ziyaret(IkiliAramaAgaciDugumu dugum)
        {
            dugumler += "Adı"  + dugum.veri.OtelAdi + " " + "Otel Yorumları--> " + dugum.veri.OtelYorumList.DisplayElements() + Environment.NewLine + Environment.NewLine;
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(IkiliAramaAgaciDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(IkiliAramaAgaciDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(OtelBilgi deger)
        {

            IkiliAramaAgaciDugumu tempParent = new IkiliAramaAgaciDugumu();

            IkiliAramaAgaciDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;

                if (deger.OtelID == tempSearch.veri.OtelID)
                    return;
                else if (deger.OtelID < tempSearch.veri.OtelID)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            IkiliAramaAgaciDugumu eklenecek = new IkiliAramaAgaciDugumu(deger);

            if (kok == null)
                kok = eklenecek;
            else if (deger.OtelID < tempParent.veri.OtelID)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }


        private IkiliAramaAgaciDugumu Successor(IkiliAramaAgaciDugumu silDugum)
        {
            IkiliAramaAgaciDugumu successorParent = silDugum;
            IkiliAramaAgaciDugumu successor = silDugum;
            IkiliAramaAgaciDugumu current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(int deger)
        {
            IkiliAramaAgaciDugumu current = kok;
            IkiliAramaAgaciDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while ((int)current.veri.OtelID != deger)
            {
                parent = current;
                if (deger < (int)current.veri.OtelID)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                IkiliAramaAgaciDugumu successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;
        }

        public IkiliAramaAgaciDugumu OtelBilgiGuncelle(OtelBilgi otel)
        {
            return OtelBilgiGuncelle(kok, otel);
        }
        private IkiliAramaAgaciDugumu OtelBilgiGuncelle(IkiliAramaAgaciDugumu dugum,OtelBilgi otel)
        {

            if ((int)dugum.veri.OtelID == otel.OtelID)
            {
                dugum.veri = otel;
                return dugum;
            }
            else if ((int)dugum.veri.OtelID > otel.OtelID)
                return (OtelBilgiGuncelle(dugum.sol, otel));
            else
                return (OtelBilgiGuncelle(dugum.sag, otel));
        }


        public void PreOrderAdvanced(OtelBilgi otel)
        {
            ZiyaretAdvanced(kok,otel);
        }


        private void ZiyaretAdvanced(IkiliAramaAgaciDugumu dugum,OtelBilgi otel)
        {

            if (dugum == null)
                return;

            if (dugum.veri.YildizSayisi == otel.YildizSayisi)
            {
                advancedTemp += "Otel Adı:" + dugum.veri.OtelAdi + Environment.NewLine;
            }

            ZiyaretAdvanced(dugum.sol,otel);
            ZiyaretAdvanced(dugum.sag,otel);

        }

        private void DerinlikBulInt(IkiliAramaAgaciDugumu dugum)
        {
            if (dugum == null)
                return;
            else
            {
                Yukseklik++;
                DerinlikBulInt(dugum.sol); //Düğümün solu oldukça sola git


            }
        }

        public void DerinlikBul()
        {
            Yukseklik = -1;
            DerinlikBulInt(kok);
        }

    }
}
