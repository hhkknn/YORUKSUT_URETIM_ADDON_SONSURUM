﻿using AIF.ObjectsDLL;
using AIF.ObjectsDLL.Events;
using AIF.ObjectsDLL.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIF.UVT.SAPB1.DataTables
{
    public class CreateTables
    {
        public static void CreateAndCheckFields()
        {
            //string mKod = System.Configuration.ConfigurationManager.AppSettings["MusteriKodu"];

            Dictionary<string, string> fields = new Dictionary<string, string>();

            if (Program.mKod != "")
            {
                #region GEÇERLİ DEĞERLER

                List<ComboList> Istasyonlar = new List<ComboList>();

                if (Program.mKod == "10B1C4")
                {
                    Istasyonlar.Add(new ComboList { Value = "IST001", Desc = "Ayran İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "IST002", Desc = "Yoğurt İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "IST003", Desc = "Teleme İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "IST004", Desc = "Kaşar Peynir İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "IST005", Desc = "Kaymak Peynir İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "IST006", Desc = "Lor Peynir İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "IST007", Desc = "Tereyağ İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "IST008", Desc = "Dondurma İstasyonu" });
                }
                else if (Program.mKod == "20R5DB")
                {
                    Istasyonlar.Add(new ComboList { Value = "20-IST-STKBL", Desc = "Süt Kabul" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-PASTR", Desc = "Pastörizasyon İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-AYRAN", Desc = "Ayran İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-YOGRT", Desc = "Yoğurt İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-YGRPK", Desc = "Yoğurt Paketleme İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-BEYPY", Desc = "Beyaz Peynir İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-TELEM", Desc = "Teleme İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-KASAR", Desc = "Kaşar Peynir İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-TRVKM", Desc = "Termoform Vakum İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-LORIS", Desc = "Lor İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-LORPK", Desc = "Lor Paketleme İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-UFIST", Desc = "UF İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-UFPKT", Desc = "UF Paketleme İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-KREMP", Desc = "Krem Peynir İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-KRMPK", Desc = "Krem Peynir Paketleme İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-TERYG", Desc = "Tereyağ İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-KYMAK", Desc = "Kaymak İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-KYMDL", Desc = "Kaymak Dolum ve Paketleme İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-UHTDL", Desc = "UHT Dolum İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-OPPIS", Desc = "OPP İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-ANPIS", Desc = "Antep Peynir İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-KUPIS", Desc = "Künefe Peynir İstasyonu" });
                    Istasyonlar.Add(new ComboList { Value = "20-IST-OPPKT", Desc = "OPP Paketleme İstasyonu" });
                }

                List<ComboList> AnalizEkranlari = new List<ComboList>();
                AnalizEkranlari.Add(new ComboList { Value = "1", Desc = "Ayran Analiz Ekranı" });
                AnalizEkranlari.Add(new ComboList { Value = "2", Desc = "Yoğurt Analiz Ekranı" });
                AnalizEkranlari.Add(new ComboList { Value = "3", Desc = "Teleme Analiz Ekranı" });
                AnalizEkranlari.Add(new ComboList { Value = "4", Desc = "Kaşar Peynir Analiz Ekranı" });
                AnalizEkranlari.Add(new ComboList { Value = "5", Desc = "Kaymak Peynir Analiz Ekranı" });
                AnalizEkranlari.Add(new ComboList { Value = "6", Desc = "Lor Peynir Analiz Ekranı" });
                AnalizEkranlari.Add(new ComboList { Value = "7", Desc = "Tereyağ Analiz Ekranı" });
                AnalizEkranlari.Add(new ComboList { Value = "8", Desc = "Dondurma Analiz Ekranı" });
                AnalizEkranlari.Add(new ComboList { Value = "9", Desc = "Ayran Paketleme Analiz Ekranı" });

                List<ComboList> BaseDiscountType = new List<ComboList>();
                BaseDiscountType.Add(new ComboList { Value = "1", Desc = "Brüt Toplamdan Yüzde" });
                BaseDiscountType.Add(new ComboList { Value = "2", Desc = "Ara Toplamdan Yüzde" });
                BaseDiscountType.Add(new ComboList { Value = "3", Desc = "Toplam Tutar" });

                List<ComboList> TemplateBaseDiscountType = new List<ComboList>();
                TemplateBaseDiscountType.Add(new ComboList { Value = "1", Desc = "Brüt Toplamdan Yüzde" });
                TemplateBaseDiscountType.Add(new ComboList { Value = "2", Desc = "Ara Toplamdan Yüzde" });

                List<ComboList> SutTuru = new List<ComboList>();
                SutTuru.Add(new ComboList { Value = "1", Desc = "Yağlı Süt" });
                SutTuru.Add(new ComboList { Value = "2", Desc = "Yağsız Süt" });

                List<ComboList> Alkol = new List<ComboList>();
                Alkol.Add(new ComboList { Value = "1", Desc = "Kesiyor" });
                Alkol.Add(new ComboList { Value = "2", Desc = "Kesmiyor" });

                List<ComboList> Temizlik = new List<ComboList>();
                Temizlik.Add(new ComboList { Value = "1", Desc = "İyi" });
                Temizlik.Add(new ComboList { Value = "2", Desc = "Kötü" });
                Temizlik.Add(new ComboList { Value = "3", Desc = "Orta" });

                List<ComboList> Soda = new List<ComboList>();
                Soda.Add(new ComboList { Value = "1", Desc = "Var" });
                Soda.Add(new ComboList { Value = "2", Desc = "Yok" });

                List<ComboList> Antibiyotik = new List<ComboList>();
                Antibiyotik.Add(new ComboList { Value = "1", Desc = "Var" });
                Antibiyotik.Add(new ComboList { Value = "2", Desc = "Yok" });

                List<ComboList> Koku = new List<ComboList>();
                Koku.Add(new ComboList { Value = "1", Desc = "İyi" });
                Koku.Add(new ComboList { Value = "2", Desc = "Kötü" });
                Koku.Add(new ComboList { Value = "3", Desc = "Orta" });

                List<ComboList> BelgeDurumu = new List<ComboList>();
                BelgeDurumu.Add(new ComboList { Value = "O", Desc = "Açık" });
                BelgeDurumu.Add(new ComboList { Value = "C", Desc = "Kapalı" });
                BelgeDurumu.Add(new ComboList { Value = "A", Desc = "Onaylandı" });

                List<ComboList> VarYok = new List<ComboList>();
                VarYok.Add(new ComboList { Value = "1", Desc = "Var" });
                VarYok.Add(new ComboList { Value = "2", Desc = "Yok" });

                List<ComboList> TatKokuKivam = new List<ComboList>();
                TatKokuKivam.Add(new ComboList { Value = "0", Desc = "-" });
                TatKokuKivam.Add(new ComboList { Value = "1", Desc = "İyi" });
                TatKokuKivam.Add(new ComboList { Value = "2", Desc = "Kötü" });

                List<ComboList> TelemeTuru = new List<ComboList>();
                TelemeTuru.Add(new ComboList { Value = "0", Desc = "-" });
                TelemeTuru.Add(new ComboList { Value = "1", Desc = "Yağlı" });
                TelemeTuru.Add(new ComboList { Value = "2", Desc = "Yarım Yağlı" });
                TelemeTuru.Add(new ComboList { Value = "3", Desc = "Yağsız" });
                TelemeTuru.Add(new ComboList { Value = "4", Desc = "Sürsene Kültür" });

                List<ComboList> DegerList = new List<ComboList>();
                DegerList.Add(new ComboList { Value = "0", Desc = "-" });
                DegerList.Add(new ComboList { Value = "1", Desc = "Personel Seçimi" });
                DegerList.Add(new ComboList { Value = "2", Desc = "Sayı Girişi" });

                List<ComboList> Aylar = new List<ComboList>();
                Aylar.Add(new ComboList { Value = "01", Desc = "Ocak" });
                Aylar.Add(new ComboList { Value = "02", Desc = "Şubat" });
                Aylar.Add(new ComboList { Value = "03", Desc = "Mart" });
                Aylar.Add(new ComboList { Value = "04", Desc = "Nisan" });
                Aylar.Add(new ComboList { Value = "05", Desc = "Mayıs" });
                Aylar.Add(new ComboList { Value = "06", Desc = "Haziran" });
                Aylar.Add(new ComboList { Value = "07", Desc = "Temmuz" });
                Aylar.Add(new ComboList { Value = "08", Desc = "Ağustos" });
                Aylar.Add(new ComboList { Value = "09", Desc = "Eylül" });
                Aylar.Add(new ComboList { Value = "10", Desc = "Ekim" });
                Aylar.Add(new ComboList { Value = "11", Desc = "Kasım" });
                Aylar.Add(new ComboList { Value = "12", Desc = "Aralık" });

                List<ComboList> EvetHayir = new List<ComboList>();
                EvetHayir.Add(new ComboList { Value = "Evet", Desc = "Evet" });
                EvetHayir.Add(new ComboList { Value = "Hayır", Desc = "Hayır" });

                List<ComboList> DepoTipi = new List<ComboList>();
                DepoTipi.Add(new ComboList { Value = "-", Desc = "-" });
                DepoTipi.Add(new ComboList { Value = "01", Desc = "Süt Depo" });

                List<ComboList> IslemTuru = new List<ComboList>();
                IslemTuru.Add(new ComboList { Value = "Gelecek Havale", Desc = "Gelecek Havale" });
                IslemTuru.Add(new ComboList { Value = "Çek Tahsilatı", Desc = "Çek Tahsilatı" });
                IslemTuru.Add(new ComboList { Value = "Senet Tahsilatı", Desc = "Senet Tahsilatı" });
                IslemTuru.Add(new ComboList { Value = "Ulusallar Tahsilatı-1", Desc = "Ulusallar Tahsilatı-1" });
                IslemTuru.Add(new ComboList { Value = "Ulusallar Tahsilatı-2", Desc = "Ulusallar Tahsilatı-2" });
                IslemTuru.Add(new ComboList { Value = "Bayiler Tahsilat", Desc = "Bayiler Tahsilat" });
                IslemTuru.Add(new ComboList { Value = "Bölgeler Tahsilat", Desc = "Bölgeler Tahsilat" });
                IslemTuru.Add(new ComboList { Value = "End. Ürün Tahsilatı", Desc = "End. Ürün Tahsilatı" });
                IslemTuru.Add(new ComboList { Value = "İhale Tahsilatları (Hastaneler)", Desc = "İhale Tahsilatları (Hastaneler)" });
                IslemTuru.Add(new ComboList { Value = "Yem Tahsilatı", Desc = "Yem Tahsilatı" });
                IslemTuru.Add(new ComboList { Value = "Diğer Tahsilat", Desc = "Diğer Tahsilat" });
                IslemTuru.Add(new ComboList { Value = "Çek Ödemesi", Desc = "Çek Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Havale Ödemesi", Desc = "Havale Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Süt Ödemesi (Faturalı)", Desc = "Süt Ödemesi (Faturalı)" });
                IslemTuru.Add(new ComboList { Value = "Süt Ödemesi (Müstahsil)", Desc = "Süt Ödemesi (Müstahsil)" });
                IslemTuru.Add(new ComboList { Value = "Fatura Ödemesi", Desc = "Fatura Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Vergi Ödemesi", Desc = "Vergi Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "SGK Ödemesi", Desc = "SGK Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Maaş Ödemesi", Desc = "Maaş Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Krd.Kartı", Desc = "Krd.Kartı" });
                IslemTuru.Add(new ComboList { Value = "BCH Geri Ödemesi", Desc = "BCH Geri Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Kredi Ödemesi", Desc = "Kredi Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "DBS Ödemesi", Desc = "DBS Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Kredileşen DBS Ödemesi", Desc = "Kredileşen DBS Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Ödenmesi Gereken DBS", Desc = "Ödenmesi Gereken DBS" });
                IslemTuru.Add(new ComboList { Value = "Devre Faizi", Desc = "Devre Faizi" });
                IslemTuru.Add(new ComboList { Value = "Kredi Taksit Ödemesi", Desc = "Kredi Taksit Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Yem Ödemesi", Desc = "Yem Ödemesi" });
                IslemTuru.Add(new ComboList { Value = "Diğer Ödemeler", Desc = "Diğer Ödemeler" });

                List<ComboList> Nitelik = new List<ComboList>();
                Nitelik.Add(new ComboList { Value = "1", Desc = "Çiftlik - 1" });
                Nitelik.Add(new ComboList { Value = "2", Desc = "Çiftlik - 2" });
                Nitelik.Add(new ComboList { Value = "3", Desc = "Kooperatif ve Birlik" });
                Nitelik.Add(new ComboList { Value = "4", Desc = "Müstahsil" });
                Nitelik.Add(new ComboList { Value = "5", Desc = "Mütahit ve Firma" });

                List<ComboList> TeminatTuru = new List<ComboList>();
                TeminatTuru.Add(new ComboList { Value = "Arac", Desc = "Araç" });
                TeminatTuru.Add(new ComboList { Value = "Teminat", Desc = "Teminat" });
                TeminatTuru.Add(new ComboList { Value = "Diğer", Desc = "Diğer" });

                List<ComboList> TakipTuru = new List<ComboList>();
                TakipTuru.Add(new ComboList { Value = "Icra", Desc = "İcra" });
                TakipTuru.Add(new ComboList { Value = "Ihtar", Desc = "İhtar" });

                List<ComboList> AracTipi = new List<ComboList>();
                AracTipi.Add(new ComboList { Value = "1", Desc = "Kendi Aracımız" });
                AracTipi.Add(new ComboList { Value = "2", Desc = "Dışardan Araç" });

                List<ComboList> urunCap = new List<ComboList>();
                urunCap.Add(new ComboList { Value = "75", Desc = "75" });
                urunCap.Add(new ComboList { Value = "95", Desc = "95" });

                List<ComboList> urunTipleri = new List<ComboList>();
                urunTipleri.Add(new ComboList { Value = "1", Desc = "Kültür" });
                urunTipleri.Add(new ComboList { Value = "2", Desc = "Tuz" });

                List<ComboList> IndirimTipi = new List<ComboList>();
                IndirimTipi.Add(new ComboList { Value = "1", Desc = "Dönemsel İndirim" });
                IndirimTipi.Add(new ComboList { Value = "2", Desc = "Genel İndirim" });

                List<ComboList> etkinEtkinDegil = new List<ComboList>();
                etkinEtkinDegil.Add(new ComboList { Value = "1", Desc = "Etkin" });
                etkinEtkinDegil.Add(new ComboList { Value = "2", Desc = "Etkin Değil" });

                List<ComboList> Oncelik = new List<ComboList>();
                Oncelik.Add(new ComboList { Value = "1", Desc = "1" });
                Oncelik.Add(new ComboList { Value = "2", Desc = "2" });
                Oncelik.Add(new ComboList { Value = "3", Desc = "3" });
                Oncelik.Add(new ComboList { Value = "4", Desc = "4" });
                Oncelik.Add(new ComboList { Value = "5", Desc = "5" });

                List<ComboList> SASOnayRed = new List<ComboList>();
                SASOnayRed.Add(new ComboList { Value = "B", Desc = "Onay Bekliyor" });
                SASOnayRed.Add(new ComboList { Value = "O", Desc = "Onaylandı" });
                SASOnayRed.Add(new ComboList { Value = "R", Desc = "Reddedildi" });

                List<ComboList> SatisIndirimTipi = new List<ComboList>();
                SatisIndirimTipi.Add(new ComboList { Value = "0", Desc = "" });
                SatisIndirimTipi.Add(new ComboList { Value = "1", Desc = "Iskonto Tablosuna Göre" });
                SatisIndirimTipi.Add(new ComboList { Value = "2", Desc = "Ekrandaki Verilere Göre" });
                SatisIndirimTipi.Add(new ComboList { Value = "3", Desc = "Iskonto Uygulama" });

                List<ComboList> GorselKontroller = new List<ComboList>();
                GorselKontroller.Add(new ComboList { Value = "0", Desc = "" });
                GorselKontroller.Add(new ComboList { Value = "1", Desc = "Uygun" });
                GorselKontroller.Add(new ComboList { Value = "2", Desc = "Uygun Değil" });

                List<ComboList> KaliteKontrolu = new List<ComboList>();
                KaliteKontrolu.Add(new ComboList { Value = "0", Desc = "" });
                KaliteKontrolu.Add(new ComboList { Value = "1", Desc = "Laboratuvara Analiz İçin Numune Gönderilmiştir" });
                KaliteKontrolu.Add(new ComboList { Value = "2", Desc = "Laboratuvara Analiz İçin Numune Gönderilmemiştir" });
                KaliteKontrolu.Add(new ComboList { Value = "3", Desc = "Tedarikçi Deklarasyonu / Analiz Sertifikası İle Kabul Edilmiştir" });

                List<ComboList> MalzemeKabul = new List<ComboList>();
                MalzemeKabul.Add(new ComboList { Value = "0", Desc = "" });
                MalzemeKabul.Add(new ComboList { Value = "1", Desc = "Kabul" });
                MalzemeKabul.Add(new ComboList { Value = "2", Desc = "Red" });

                List<ComboList> KaliteSonuc = new List<ComboList>();
                KaliteSonuc.Add(new ComboList { Value = "0", Desc = "" });
                KaliteSonuc.Add(new ComboList { Value = "1", Desc = "Bekliyor" });
                KaliteSonuc.Add(new ComboList { Value = "2", Desc = "Tamamlandı" });
                KaliteSonuc.Add(new ComboList { Value = "3", Desc = "Tamamlanmadı" });

                List<ComboList> SerDurumu = new List<ComboList>();
                SerDurumu.Add(new ComboList { Value = "0", Desc = "" });
                SerDurumu.Add(new ComboList { Value = "1", Desc = "Var" });
                SerDurumu.Add(new ComboList { Value = "2", Desc = "Yok" });

                List<ComboList> DepoGrubu = new List<ComboList>();
                DepoGrubu.Add(new ComboList { Value = "-", Desc = "-" });
                DepoGrubu.Add(new ComboList { Value = "01", Desc = "Endüstriyel" });

                List<ComboList> DepoAltGrubu = new List<ComboList>();
                DepoAltGrubu.Add(new ComboList { Value = "-", Desc = "-" });
                DepoAltGrubu.Add(new ComboList { Value = "01", Desc = "Cep Depo" });

                List<ComboList> BelgeTipi = new List<ComboList>();
                BelgeTipi.Add(new ComboList { Value = "T", Desc = "Taslak" });
                BelgeTipi.Add(new ComboList { Value = "G", Desc = "Gerçek" });

                #endregion GEÇERLİ DEĞERLER 

                #region 10B1C4 TABLO VE ALANLARI

                if (Program.mKod == "10B1C4")
                {
                    if (!TableCreation.TableExists("AIF_UVT_ACTPARAM"))
                    {
                        TableCreation.CreateTable("AIF_UVT_ACTPARAM", "Aktivite Parametre Ekranı", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFieldsForDefaultForm("@AIF_UVT_ACTPARAM", "Hour", "Saat", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFieldsForDefaultForm("@AIF_UVT_ACTPARAM", "Minute", "Dakika", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_UVT_ACTPARAM"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "DocEntry");
                        fields.Add("U_Hour", "Saat");
                        fields.Add("U_Minute", "Dakika");

                        UdoCreation.RegisterUDO("AIF_UVT_ACTPARAM", "Aktivite Parametre Ekranı", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_UVT_ACTPARAM", "", SAPbobsCOM.BoYesNoEnum.tNO);
                    }

                    if (!TableCreation.TableExists("AIF_SALES_DISC"))

                    {
                        TableCreation.CreateTable("AIF_SALES_DISC", "indirimSihirbazi", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SALES_DISC1", "indirimSihirbaziDetaylari", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SALES_DISC", "PriceBefDisc", "İndirim Öncesi Toplam", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SALES_DISC", "TotalDisc", "Toplam İndirim", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SALES_DISC", "DiscRate", "Toplam İndirim Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SALES_DISC", "PriceAfterDisc", "İndirim Sonrası Toplam", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_SALES_DISC1", "SubTotal", "Ara Toplam 1", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SALES_DISC1", "DiscType", "İndirim Baz Fiyat", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: BaseDiscountType);
                        TableCreation.CreateUserFields("@AIF_SALES_DISC1", "DiscRate", "İndirim Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SALES_DISC1", "DiscTotal", "İndirim Tutarı", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SALES_DISC1", "SubTotal2", "Ara Toplam 2", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SALES_DISC"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "DocEntry");
                        fields.Add("U_PriceBefDisc", "İndirim Öncesi Toplam");
                        fields.Add("U_TotalDisc", "Toplam İndirim");
                        fields.Add("U_DiscRate", "Toplam İndirim Oranı");
                        fields.Add("U_PriceAfterDisc", "İndirim Sonrası Toplam");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SALES_DISC1";


                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SubTotal", FormColumnDescription = "Ara Toplam 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DiscType", FormColumnDescription = "İndirim Baz Fiyat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DiscRate", FormColumnDescription = "İndirim Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DiscTotal", FormColumnDescription = "İndirim Tutarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SubTotal2", FormColumnDescription = "Ara Toplam 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SALES_DISC", "indirimSihirbazi", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SALES_DISC", "", SAPbobsCOM.BoYesNoEnum.tNO, chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TMP_SLS_DISC"))
                    {
                        TableCreation.CreateTable("AIF_TMP_SLS_DISC", "indirimSablonu", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TMP_SLS_DISC1", "indirimSablonuDetaylari", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC", "PriceBefDisc", "İndirim Öncesi Toplam", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC", "TotalDisc", "Toplam İndirim", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC", "DiscRate", "Toplam İndirim Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC", "PriceAfterDisc", "İndirim Sonrası Toplam", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC", "TemplateName", "Şablon Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC1", "SubTotal", "Ara Toplam 1", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC1", "DiscType", "İndirim Baz Fiyat", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: TemplateBaseDiscountType);
                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC1", "DiscRate", "İndirim Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC1", "DiscTotal", "İndirim Tutarı", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TMP_SLS_DISC1", "SubTotal2", "Ara Toplam 2", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);

                    }

                    if (!UdoCreation.UDOExists("AIF_TMP_SLS_DISC"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "DocEntry");
                        fields.Add("U_TemplateName", "Şablon Adı");
                        fields.Add("U_PriceBefDisc", "İndirim Öncesi Toplam");
                        fields.Add("U_TotalDisc", "Toplam İndirim");
                        fields.Add("U_DiscRate", "Toplam İndirim Oranı");
                        fields.Add("U_PriceAfterDisc", "İndirim Sonrası Toplam");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TMP_SLS_DISC1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SubTotal", FormColumnDescription = "Ara Toplam 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DiscType", FormColumnDescription = "İndirim Baz Fiyat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DiscRate", FormColumnDescription = "İndirim Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DiscTotal", FormColumnDescription = "İndirim Tutarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SubTotal2", FormColumnDescription = "Ara Toplam 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TMP_SLS_DISC", "indirimSablonu", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TMP_SLS_DISC", "", SAPbobsCOM.BoYesNoEnum.tNO, chList: chList);
                    }

                    #region AIF_PHASEPLANNING otat excell de yok.uvt kodda yok.kapatıldı 20211229
                    //if (!TableCreation.TableExists("AIF_PHASEPLANNING"))
                    //{
                    //    TableCreation.CreateTable("AIF_PHASEPLANNING", "KaynakPlanlama", SAPbobsCOM.BoUTBTableType.bott_Document);
                    //    TableCreation.CreateTable("AIF_PHASEPLANNING1", "KaynakPlanlamaDetay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "RotaCode", "Rota Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "RotaName", "Rota Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period1", "0000_0030", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period2", "0030_0100", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period3", "0100_0130", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period4", "0130_0200", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period5", "0200_0230", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period6", "0230_0300", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period7", "0300_0330", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period8", "0330_0400", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period9", "0400_0430", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period10", "0430_0500", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period11", "0500_0530", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period12", "0530_0600", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period13", "0600_0630", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period14", "0630_0700", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period15", "0700_0730", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period16", "0730_0800", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period17", "0800_0830", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period18", "0830_0900", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period19", "0900_0930", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period20", "0930_1000", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period21", "1000_1030", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period22", "1030_1100", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period23", "1100_1130", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period24", "1130_1200", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period25", "1200_1230", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period26", "1230_1300", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period27", "1300_1330", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period28", "1330_1400", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period29", "1400_1430", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period30", "1430_1500", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period31", "1500_1530", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period32", "1530_1600", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period33", "1600_1630", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period34", "1630_1700", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period35", "1700_1730", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period36", "1730_1800", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period37", "1800_1830", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period38", "1830_1900", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period39", "1900_1930", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period40", "1930_2000", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period41", "2000_2030", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period42", "2030_2100", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period43", "2100_2130", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period44", "2130_2200", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period45", "2200_2230", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period46", "2230_2300", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period47", "2300_2330", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_PHASEPLANNING1", "Period48", "2330_0000", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //}

                    //if (!UdoCreation.UDOExists("AIF_PHASEPLANNING"))
                    //{
                    //    fields.Clear();
                    //    fields.Add("DocEntry", "DocEntry");
                    //    //fields.Add("U_TemplateName", "Şablon Adı");
                    //    //fields.Add("U_PriceBefDisc", "İndirim Öncesi Toplam");
                    //    //fields.Add("U_TotalDisc", "Toplam İndirim");
                    //    //fields.Add("U_DiscRate", "Toplam İndirim Oranı");

                    //    List<FormColumn> fc = new List<FormColumn>();
                    //    List<ChildTable> chList = new List<ChildTable>();

                    //    ChildTable ch = new ChildTable();
                    //    ch.TableName = "AIF_PHASEPLANNING1";

                    //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    //    fc.Add(new FormColumn { FormColumnAlias = "U_RotaCode", FormColumnDescription = "Rota Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_RotaName", FormColumnDescription = "Rota Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period1", FormColumnDescription = "0000_0030", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period2", FormColumnDescription = "0030_0100", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period3", FormColumnDescription = "0100_0130", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period4", FormColumnDescription = "0130_0200", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period5", FormColumnDescription = "0200_0230", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period6", FormColumnDescription = "0230_0300", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period7", FormColumnDescription = "0300_0330", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period8", FormColumnDescription = "0330_0400", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period9", FormColumnDescription = "0400_0430 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period10", FormColumnDescription = "0430_0500", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period11", FormColumnDescription = "0500_0530", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period12", FormColumnDescription = "0530_0600", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period13", FormColumnDescription = "0600_0630", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period14", FormColumnDescription = "0630_0700", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period15", FormColumnDescription = "0700_0730", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period16", FormColumnDescription = "0730_0800", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period17", FormColumnDescription = "0800_0830", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period18", FormColumnDescription = "0830_0900", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period19", FormColumnDescription = "0900_0930", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period20", FormColumnDescription = "0930_1000", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period21", FormColumnDescription = "1000_1030", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period22", FormColumnDescription = "1030_1100", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period23", FormColumnDescription = "1100_1130", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period24", FormColumnDescription = "1130_1200", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period25", FormColumnDescription = "1200_1230", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period26", FormColumnDescription = "1230_1300", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period27", FormColumnDescription = "1300_1330", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period28", FormColumnDescription = "1330_1400", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period29", FormColumnDescription = "1400_1430", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period30", FormColumnDescription = "1430_1500", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period31", FormColumnDescription = "1500_1530", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period32", FormColumnDescription = "1530_1600", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period33", FormColumnDescription = "1600_1630", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period34", FormColumnDescription = "1630_1700", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period35", FormColumnDescription = "1700_1730", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period36", FormColumnDescription = "1730_1800", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period37", FormColumnDescription = "1800_1830", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period38", FormColumnDescription = "1830_1900", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period39", FormColumnDescription = "1900_1930", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period40", FormColumnDescription = "1930_2000", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period41", FormColumnDescription = "2000_2030", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period42", FormColumnDescription = "2030_2100", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period43", FormColumnDescription = "2100_2130", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period44", FormColumnDescription = "2130_2200", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period45", FormColumnDescription = "2200_2230", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period46", FormColumnDescription = "2230_2300", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period47", FormColumnDescription = "2300_2330", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Period48", FormColumnDescription = "2330_0000", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                    //    ch.FormColumn = fc;
                    //    chList.Add(ch);


                    //    UdoCreation.RegisterUDOWithChildTable("AIF_PHASEPLANNING", "KaynakPlanlama", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_PHASEPLANNING", "", SAPbobsCOM.BoYesNoEnum.tNO, chList: chList);
                    //} 
                    #endregion

                    if (!TableCreation.TableExists("AIF_PROD_PLAN"))
                    {
                        TableCreation.CreateTable("AIF_PROD_PLAN", "OperasyonPlani", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFields("@AIF_PROD_PLAN", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN", "DevirSut", "Devir Süt", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN", "GelecekSut", "Gelecek Süt", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN", "ToplamSut", "Toplam Süt", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN", "YagliSut", "Yağlı Süt", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN", "AzYagliSut", "Az Yağlı Süt", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN", "YagsizSut", "Yağsız Süt", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN", "ErtesiGunDevirSut", "Ertesi Gün Devir Süt", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateTable("AIF_PROD_PLAN1", "OperasyonPlaniDetay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        #region AIF_PROD_PLAN1

                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "Grup", "Grup", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "Tur", "Tür", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "Kod", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "Adi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "Palet", "Palet", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "Adet", "Adet", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "KG", "Kilogram", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "Seviye", "Seviye", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "UstSeviye", "Üst Seviye", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "KokSeviye", "Kök Seviye", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PROD_PLAN1", "Sira", "Sıra", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        #endregion AIF_PROD_PLAN1
                    }

                    if (!UdoCreation.UDOExists("AIF_PROD_PLAN"))
                    {
                        //
                        fields.Clear();
                        fields.Add("DocEntry", "DocEntry");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_DevirSut", "Devir Süt");
                        fields.Add("U_GelecekSut", "Gelecek Süt");
                        fields.Add("U_ToplamSut", "Toplam Süt");
                        fields.Add("U_YagliSut", "Yağlı Süt");
                        fields.Add("U_AzYagliSut", "Az Yağlı Süt");
                        fields.Add("U_YagsizSut", "Yağsız Süt");
                        fields.Add("U_ErtesiGunDevirSut", "Ertesi Gün Devir Süt");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_PROD_PLAN1";

                        #region AIF_PHASEPLANNING1

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Grup", FormColumnDescription = "Grup", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Tur", FormColumnDescription = "Tür", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Kod", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Adi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Palet", FormColumnDescription = "Palet", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Adet", FormColumnDescription = "Adet", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KG", FormColumnDescription = "Kilogram", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Seviye", FormColumnDescription = "Seviye", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UstSeviye", FormColumnDescription = "Üst Seviye", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KokSeviye", FormColumnDescription = "Kök Seviye", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sira", FormColumnDescription = "Sıra", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        #endregion AIF_PHASEPLANNING1

                        UdoCreation.RegisterUDOWithChildTable("AIF_PROD_PLAN", "OperasyonPlani", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_PROD_PLAN", "", SAPbobsCOM.BoYesNoEnum.tNO, chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTKABUL"))
                    {
                        TableCreation.CreateTable("AIF_SUTKABUL", "SUTKABUL", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTKABUL1", "SUTKABUL1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_SUTKABUL2", "SUTKABUL2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_SUTKABUL3", "SUTKABUL3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTKABUL", "BelgeTarihi", "Belge Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL", "BelgeDurumu", "Belge Durumu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, clist: BelgeDurumu);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL", "SutKabulTarihi", "Süt Kabul Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL", "SutKabulSaati", "Süt Kabul Saati", SAPbobsCOM.BoFieldTypes.db_Date, 10, SAPbobsCOM.BoFldSubTypes.st_Time);

                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "AracPlakasi", "Araç Plakası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "Surucu", "Sürücü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "FisNo", "Fiş numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "DolKantarMik", "Dolu Kantar Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Quantity);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "BosKantarMik", "Boş Kantar Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Quantity);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "NetMikTon", "Net Süt Miktarı Ton", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Quantity);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "NetMikLtr1", "Net Mik Litre 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Quantity);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "NetMikLtr2", "Net Mik Litre 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Quantity);

                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "KantaraGore", "Kantara Göre", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "BelgeTipineGore", "Belge Tipine Göre", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "SayacaGore", "Sayaca Göre", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "IrsaliyeliGiris", "İrsaliye Girişi", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "BelgesizGiris", "Belgesiz Giriş", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "SaticiKodu", "Satıcı Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "SaticiAdi", "Satıcı Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "BelgeNo", "Belge No", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "TekilGiris", "Tekil Giriş", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "CokluGiris", "Çoklu Giriş", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL1", "Aciklamalar", "Açıklamalar", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "KayitNo", "Kayıt No", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Tedarikci", "Tedarikçi", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "TedarikciAdi", "Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Sicaklik", "Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Briks", "Briks", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Yogunluk", "Yoğunluk", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "pH", "pH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "SutTuru", "Süt Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Nitelik", "Nitelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, clist: Nitelik);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "TemizlikKoku", "Temizlik Koku", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Temizlik);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Soda", "Soda", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Soda);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Antibiyotik", "Antibiyotik", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Antibiyotik);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Ykm", "Ykm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Alkol", "Alkol", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: Alkol);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "KaynatSh", "KaynatSh", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Depo", "Depo", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Laktoz", "Laktoz", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "KatilanSu", "Katılan Su", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "SomatikHucre", "Somatik Hücre", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "MetilenMavisi", "Metilen Mavisi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "DocEntry", "Belge No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Koku", "Koku", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Temizlik);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "DonNok", "Don Nok", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "Tkm", "Tkm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "SutTemizligi", "Süt Temizliği", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "TankTemizligi", "Tank Temizliği", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "EkipmanTemizligi", "Ekipman Temizliği", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "AracKasasiTem", "Araç Kasası Temizliği", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "AgirlikliPuan", "Ağırlıklı Puan", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL2", "SutKabulIrsNo", "Süt Kabul Irsaliye No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "KayitNo", "Kayıt No", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Tedarikci", "Tedarikçi", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "TedarikciAdi", "Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "TankNumarasi", "Kaynak Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "LabMiktar", "Lab Miktarı LT", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Derece", "Derece", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "KMBRIX", "KMBRIX", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Dans", "Dans", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "pH", "pH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "KYNMSSH", "KYNMSSH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "ANT", "ANT", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Antibiyotik);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Alkol", "Alkol", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Alkol);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Yag1", "Yağ 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "YagsizKm", "Yağsız Km", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "DonNok", "Don Nok", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Laktoz", "Laktoz", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Su", "Su", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Koku", "Koku", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Koku);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Tkm", "Tkm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "SomHucre", "SomHucre", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "MetMavi", "Met Mavi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "TemizlikDurumu", "Temizlik Durumu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Temizlik);
                        TableCreation.CreateUserFields("@AIF_SUTKABUL3", "Soda", "Soda", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: Soda);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTKABUL"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_BelgeTarihi", "Belge Tarihi");
                        fields.Add("U_BelgeDurumu", "Belge Durumu");
                        fields.Add("U_SutKabulTarihi", "Süt Kabul Tarihi");
                        fields.Add("U_SutKabulSaati", "Süt Kabul Saati");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTKABUL1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_AracPlakasi", FormColumnDescription = "Araç Plakası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Surucu", FormColumnDescription = "Sürücü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_FisNo", FormColumnDescription = "Fiş Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolKantarMik", FormColumnDescription = "Dolu Kantar Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BosKantarMik", FormColumnDescription = "Boş Kantar Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NetSutMikTon", FormColumnDescription = "Net Süt Miktarı Ton", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NetMikLtr1", FormColumnDescription = "Net Mik Litre 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NetMikLtr2", FormColumnDescription = "Net Mik Litre 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KantaraGore", FormColumnDescription = "Kantara Göre", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BelgeTipineGore", FormColumnDescription = "Belge Tipine Göre", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SayacaGore", FormColumnDescription = "Sayaca Göre", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IrsaliyeliGiris", FormColumnDescription = "İrsaliye Girişi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BelgesizGiris", FormColumnDescription = "Belgesiz Giriş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SaticiKodu", FormColumnDescription = "Satıcı Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SaticiAdi", FormColumnDescription = "Satıcı Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_BelgeNo", FormColumnDescription = "Belge No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TekilGiris", FormColumnDescription = "Tekil Giriş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CokluGiris", FormColumnDescription = "Çoklu Giriş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Aciklamalar", FormColumnDescription = "Açıklamalar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        fc = new List<FormColumn>();
                        ch.TableName = "AIF_SUTKABUL2";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KayitNo", FormColumnDescription = "Kayıt No", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Tedarikci", FormColumnDescription = "Tedarikçi", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciAdi", FormColumnDescription = "Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sicaklik", FormColumnDescription = "Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Briks", FormColumnDescription = "Briks", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yogunluk", FormColumnDescription = "Yoğunluk", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pH", FormColumnDescription = "pH", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutTuru", FormColumnDescription = "Süt Türü", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Nitelik", FormColumnDescription = "Nitelik", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TemizlikKoku", FormColumnDescription = "Temizlik Koku", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Soda", FormColumnDescription = "Soda", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Antibiyotik", FormColumnDescription = "Antibiyotik", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ykm", FormColumnDescription = "Ykm", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Alkol", FormColumnDescription = "Alkol", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KaynatSh", FormColumnDescription = "KaynatSh", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Depo", FormColumnDescription = "Depo", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Protein", FormColumnDescription = "Protein", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Laktoz", FormColumnDescription = "Laktoz", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KatilanSu", FormColumnDescription = "Katılan Su", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SomatikHucre", FormColumnDescription = "Somatik Hücre", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MetilenMavisi", FormColumnDescription = "Metilen Mavisi", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DocEntry", FormColumnDescription = "Belge No", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Koku", FormColumnDescription = "Koku", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DonNok", FormColumnDescription = "Donma Noktası", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TKM", FormColumnDescription = "TKM", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutTemizligi", FormColumnDescription = "Süt Temizliği", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TankTemizligi", FormColumnDescription = "Tank Temizliği", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EkipmanTemizligi", FormColumnDescription = "Ekipman Temizliği", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AracKasasiTem", FormColumnDescription = "Araç Kasası Temizliği", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AgirlikliPuan", FormColumnDescription = "Ağırlıklı Puan", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutKabulIrsNo", FormColumnDescription = "Süt Kabul Irsaliye No", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        fc = new List<FormColumn>();
                        ch.TableName = "AIF_SUTKABUL3";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KayitNo", FormColumnDescription = "Kayıt No", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Tedarikci", FormColumnDescription = "Tedarikçi", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciAdi", FormColumnDescription = "Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNumarasi", FormColumnDescription = "Tank Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabMiktar", FormColumnDescription = "Lab Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Derece", FormColumnDescription = "Derece", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KMBRIX", FormColumnDescription = "KMBRIX", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Dans", FormColumnDescription = "Dans", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pH", FormColumnDescription = "pH", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KYNMSSH", FormColumnDescription = "KYNMSSH", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ANT", FormColumnDescription = "ANT", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Alkol", FormColumnDescription = "Soda", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag1", FormColumnDescription = "Yağ 1", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagsizKm", FormColumnDescription = "Yağsız Km", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Protein", FormColumnDescription = "Protein", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DonNok", FormColumnDescription = "Don Nok", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Laktoz", FormColumnDescription = "Laktoz", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Su", FormColumnDescription = "Su", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Koku", FormColumnDescription = "Koku", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Tkm", FormColumnDescription = "Tkm", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SomHucre", FormColumnDescription = "SomHucre", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MetMavi", FormColumnDescription = "Met Mavi", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TemizlikDurumu", FormColumnDescription = "Temizlik Durumu", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Soda", FormColumnDescription = "Soda", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTKABUL", "SUTKABUL", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTKABUL", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SEVIYE1"))
                    {
                        TableCreation.CreateTable("AIF_SEVIYE1", "SEVIYE1", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFields("@AIF_SEVIYE1", "Code", "Seviye Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SEVIYE1", "Name", "Seviye Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }
                    if (!UdoCreation.UDOExists("AIF_SEVIYE1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Code", "Seviye Kodu");
                        fields.Add("U_Name", "Seviye Adı");

                        UdoCreation.RegisterUDOForDefaultForm("AIF_SEVIYE1", "SEVIYE1", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SEVIYE1", "");
                    }

                    if (!TableCreation.TableExists("AIF_SEVIYE2"))
                    {
                        TableCreation.CreateTable("AIF_SEVIYE2", "SEVIYE2", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFields("@AIF_SEVIYE2", "Code", "Seviye Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SEVIYE2", "Name", "Seviye Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }
                    if (!UdoCreation.UDOExists("AIF_SEVIYE2"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Code", "Seviye Kodu");
                        fields.Add("U_Name", "Seviye Adı");

                        UdoCreation.RegisterUDOForDefaultForm("AIF_SEVIYE2", "SEVIYE2", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SEVIYE2", "");
                    }

                    if (!TableCreation.TableExists("AIF_SUTKABULUYR"))
                    {
                        TableCreation.CreateTable("AIF_SUTKABULUYR", "Süt Kabul Uyarlama", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTKABULUYR1", "Süt Kabul Uyarlama Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR", "SutTuru", "Süt Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: SutTuru);

                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "SicaklikMin", "Sıcaklık Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "SicaklikMax", "Sıcaklık Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "BriksMin", "Briks Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "BriksMax", "Briks Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "YagMin", "Yağ Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "YagMax", "Yağ Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "YogunlukMin", "Yoğunluk Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "YogunlukMax", "Yoğunluk Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "pHMin", "pH Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "pHMax", "pH Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "sHMin", "sH Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "sHMax", "sH Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "KaynatsHMin", "KaynatsH Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "KaynatsHMax", "KaynatsH Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "AlkolMin", "Alkol Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "AlkolMax", "Alkol Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "TemizlikKokuMin", "Temizlik Koku Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "TemizlikKokuMax", "Temizlik Koku Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "SodaMin", "Soda Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "SodaMax", "Soda Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "AntibiyotikMin", "Antibiyotik Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "AntibiyotikMax", "Antibiyotik Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "YkmMin", "Ykm Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "YkmMax", "Ykm Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "ProteinMin", "Protein Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "ProteinMax", "Protein Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "LaktozMin", "Laktoz Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "LaktozMax", "Laktoz Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "KatilanSuMin", "Katılan Su Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "KatilanSuMax", "Katılan Su Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "SomatikHucreMin", "Somatik Hücre Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "SomatikHucreMax", "Somatik Hücre Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "MetilenMaviMin", "Metilen Mavi Minimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTKABULUYR1", "MetilenMaviMax", "Metilen Mavi Maksimum", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_SUTKABULUYR"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_SutTuru", "Süt Türü");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTKABULUYR1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SicaklikMin", FormColumnDescription = "Sıcaklık Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SicaklikMax", FormColumnDescription = "Sıcaklık Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BriksMin", FormColumnDescription = "Briks Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BriksMax", FormColumnDescription = "Briks Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagMin", FormColumnDescription = "Yağ Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagMax", FormColumnDescription = "Yağ Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YogunlukMin", FormColumnDescription = "Yoğunluk Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YogunlukMax", FormColumnDescription = "Yoğunluk Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMin", FormColumnDescription = "pH Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMax", FormColumnDescription = "pH Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_sHMin", FormColumnDescription = "sH Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_sHMax", FormColumnDescription = "sH Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KaynatsHMin", FormColumnDescription = "KaynatsH Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KaynatsHMax", FormColumnDescription = "KaynatsH Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlkolMin", FormColumnDescription = "Alkol Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlkolMax", FormColumnDescription = "Alkol Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TemizlikKokuMin", FormColumnDescription = "Temizlik Koku Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TemizlikKokuMax", FormColumnDescription = "Temizlik Koku Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SodaMin", FormColumnDescription = "Soda Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SodaMax", FormColumnDescription = "Soda Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AntibiyotikMin", FormColumnDescription = "Antibiyotik Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AntibiyotikMax", FormColumnDescription = "Antibiyotik Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YkmMin", FormColumnDescription = "Ykm Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YkmMax", FormColumnDescription = "Ykm Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ProteinMin", FormColumnDescription = "Protein Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ProteinMax", FormColumnDescription = "Protein Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LaktozMin", FormColumnDescription = "Laktoz Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LaktozMax", FormColumnDescription = "Laktoz Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KatilanSuMin", FormColumnDescription = "Katılan Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KatilanSuMax", FormColumnDescription = "Katılan Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SomatikHucreMin", FormColumnDescription = "Somatik Hücre Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SomatikHucreMax", FormColumnDescription = "Somatik Hücre Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MetilenMaviMin", FormColumnDescription = "Metilen Mavi Minimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MetilenMaviMax", FormColumnDescription = "Metilen Mavi Maksimum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTKABULUYR", "AIF_SUTKABULUYR", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTKABULUYR", "", chList: chList);
                    }

                    #region AIF_GUNPERSPLAN kapatıldı
                    //if (!TableCreation.TableExists("AIF_GUNPERSPLAN"))
                    //{
                    //    TableCreation.CreateTable("AIF_GUNPERSPLAN", "Günlük Personel Planlama", SAPbobsCOM.BoUTBTableType.bott_Document);
                    //    TableCreation.CreateTable("AIF_GUNPERSPLAN1", "Günlük Pers.Plan Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "PersonelNo", "Personel No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "PersonelAdi", "Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "IST001", "Ayran İstasyonu", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "IST002", "Yoğurt İstasyonu", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "IST003", "Teleme İstasyonu", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "IST004", "Kasar Peynir İstasyonu", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "IST005", "Kaymak Peynir İstasyonu", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "IST006", "Lor Peynir İstasyonu", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "IST007", "Tereyağ İstasyonu", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "IST008", "Dondurma İstasyonu", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "Kolileme", "Kolileme", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "SutAlim", "Süt Alım", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "BulasikHane", "Bulaşıkhane", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "SevkiyatDepo", "Sevkiyat Depo", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "AmbalajDepo", "Ambalaj Depo", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "Tarihleme", "Tarihleme", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "GenelTemizlik", "Genel Temizlik", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "Mutfak", "Mutfak", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "KazanDairesi", "Kazan Dairesi", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_GUNPERSPLAN1", "BakimOnarim", "Bakım Onarım", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //}
                    //if (!UdoCreation.UDOExists("AIF_GUNPERSPLAN"))
                    //{
                    //    fields.Clear();
                    //    fields.Add("DocEntry", "Kod");
                    //    fields.Add("U_Tarih", "Tarih");

                    //    List<FormColumn> fc = new List<FormColumn>();
                    //    List<ChildTable> chList = new List<ChildTable>();

                    //    ChildTable ch = new ChildTable();
                    //    ch.TableName = "AIF_GUNPERSPLAN1";

                    //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    //    fc.Add(new FormColumn { FormColumnAlias = "U_PersonelNo", FormColumnDescription = "Personel No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_PersonelAdi", FormColumnDescription = "Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_IST001", FormColumnDescription = "Ayran İstasyonu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_IST002", FormColumnDescription = "Yoğurt İstasyonu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_IST003", FormColumnDescription = "Teleme İstasyonu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_IST004", FormColumnDescription = "Kasar Peynir İstasyonu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_IST005", FormColumnDescription = "Kaymak Peynir İstasyonu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_IST006", FormColumnDescription = "Lor Peynir İstasyonu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_IST007", FormColumnDescription = "Tereyağ İstasyonu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_IST008", FormColumnDescription = "Dondurma İstasyonu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Kolileme", FormColumnDescription = "Kolileme", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_SutAlim", FormColumnDescription = "Süt Alım", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_BulasikHane", FormColumnDescription = "Bulaşıkhane", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_SevkiyatDepo", FormColumnDescription = "Sevkiyat Depo", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_AmbalajDepo", FormColumnDescription = "Ambalaj Depo", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Tarihleme", FormColumnDescription = "Tarihleme", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_GenelTemizlik", FormColumnDescription = "Genel Temizlik", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_Mutfak", FormColumnDescription = "Mutfak", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_KazanDairesi", FormColumnDescription = "Kazan Dairesi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_BakimOnarim", FormColumnDescription = "Bakım Onarım", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    ch.FormColumn = fc;
                    //    chList.Add(ch);

                    //    UdoCreation.RegisterUDOWithChildTable("AIF_GUNPERSPLAN", "AIF_GUNPERSPLAN", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_GUNPERSPLAN", "", chList: chList);
                    //} 
                    #endregion

                    if (!TableCreation.TableExists("AIF_SUT_TANK"))
                    {
                        TableCreation.CreateTable("AIF_SUT_TANK", "Süt Tankı Analiz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUT_TANK1", "Süt Tankı Analiz Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUT_TANK", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "TankAdi", "Tank Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "SutTuru", "Süt Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, clist: SutTuru);
                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "Derece", "Derece", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "KM", "KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUT_TANK1", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_SUT_TANK"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUT_TANK1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankAdi", FormColumnDescription = "Tank Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutTuru", FormColumnDescription = "Süt Türü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Derece", FormColumnDescription = "Derece", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KM", FormColumnDescription = "KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Protein", FormColumnDescription = "Protein", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUT_TANK", "AIF_SUT_TANK", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUT_TANK", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_AYR_ANALIZ"))
                    {
                        TableCreation.CreateTable("AIF_AYR_ANALIZ", "Ayran Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_AYR_ANALIZ1", "Mayalanacak Süt Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYR_ANALIZ2", "Inkubasyon Kont.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "Sicaklik", "Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "SicaklikSure", "Sıcaklık Süre", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "SutSicakligi", "Süt Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "OnAktifSure", "Ön Aktif Süre", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "OnAktifPH", "Ön Aktif PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "SutVakum", "Süt Vakum", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None, clist: VarYok);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "TankAdi", "Tank Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "MayalamaSicaklik", "Mayalama Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "Sorumlu", "Sorumlu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "SorumluAdi", "Sorumlu Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "PompaBasinci", "Pompa Basıncı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "BaslangicSaati", "Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_Time);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "BitisSaati", "Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_Time);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "TKM", "TKM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "Tuz", "Tuz", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "Brix", "Brix", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ", "TatKokuKivam", "Tat Koku Kıvam", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: TatKokuKivam);

                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ1", "Kaynak", "Kaynak", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ1", "KaynakAdi", "Kaynak Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ1", "Brix", "Brix", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ1", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ1", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ1", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ2", "InkubasyonNo", "Inkübasyon No", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ2", "Saat", "Saat", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_Time);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ2", "Sicaklik", "Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ2", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ2", "KontrolEden", "Kontrol Eden", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYR_ANALIZ2", "KontrolEdenAdi", "Kontrol Eden Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    }
                    if (!UdoCreation.UDOExists("AIF_AYR_ANALIZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_Sicaklik", "Sıcaklık");
                        fields.Add("U_SicaklikSure", "Sıcaklık Süre");
                        fields.Add("U_SutSicakligi", "Süt Sıcaklığı");
                        fields.Add("U_OnAktifSure", "Ön Aktif Süre");
                        fields.Add("U_OnAktifPH", "Ön Aktif PH");
                        fields.Add("U_SutVakum", "Süt Vakum");
                        fields.Add("U_TankAdi", "Tank Adı");
                        fields.Add("U_MayalamaSicaklik", "Mayalama Sıcaklık");
                        fields.Add("U_Sorumlu", "Sorumlu");
                        fields.Add("U_SorumluAdi", "Sorumlu Adı");
                        fields.Add("U_PompaBasinci", "Pompa Basıncı");
                        fields.Add("U_BaslangicSaati", "Başlangıç Saati");
                        fields.Add("U_BitisSaati", "Bitiş Saati");
                        fields.Add("U_TKM", "TKM");
                        fields.Add("U_Protein", "Protein");
                        fields.Add("U_Tuz", "Tuz");
                        fields.Add("U_Brix", "Brix");
                        fields.Add("U_PH", "PH");
                        fields.Add("U_SH", "SH");
                        fields.Add("U_Yag", "Yağ");
                        fields.Add("U_TatKokuKivam", "Tat Koku Kıvam");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_AYR_ANALIZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Kaynak", FormColumnDescription = "Kaynak", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KaynakAdi", FormColumnDescription = "Kaynak Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Brix", FormColumnDescription = "Brix", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYR_ANALIZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_InkubasyonNo", FormColumnDescription = "Inkübasyon No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Saat", FormColumnDescription = "Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sicaklik", FormColumnDescription = "Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolEden", FormColumnDescription = "Kontrol Eden", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolEdenAdi", FormColumnDescription = "Kontrol Eden Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_AYR_ANALIZ", "AIF_AYR_ANALIZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_AYR_ANALIZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TLM_ANALIZ"))
                    {
                        TableCreation.CreateTable("AIF_TLM_ANALIZ", "Teleme Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TLM_ANALIZ1", "Teleme Süt Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TLM_ANALIZ2", "Teleme Proses Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TLM_ANALIZ3", "Teleme Son Ürün Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "TelemeTuru", "Teleme Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: TelemeTuru);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "GorevliOperator", "Görevli Operatör", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "GorevliOperatorAdi", "Görevli Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "NetSutMiktar", "Net Süt Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "SutKaynagi", "Süt Kaynağı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "SutBicSevFark", "Sütün Bıçak Sev.Farkı(CM)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "PastorSicakligi", "Pastörize Sıcaklığı (C)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "KuruMadde", "Kuru Madde (Etüv)(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ1", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ2", "MayalamaSicakligi", "Mayalama Sıcaklığı (C)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ2", "MayalamaSuresi", "Mayalama Süresi (DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ2", "CedarlamaSicakligi", "Çedarlama Sıcaklığı (C)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ2", "CedarlamaSuresi", "Çedarlama Süresi (DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ2", "TelemeIndPH", "Teleme İndirildiğindeki PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ3", "KuruMadde", "Kuru Madde (Etüv)(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ3", "Yag", "Yağ (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ3", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ3", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ3", "PasBrix", "Pas Brix Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ3", "TelemeMiktari", "Üretilen Teleme Miktarı (KG)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLM_ANALIZ3", "RandimanDegeri", "Randıman Değeri (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TLM_ANALIZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TLM_ANALIZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeTuru", FormColumnDescription = "Teleme Türü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperator", FormColumnDescription = "Görevli Operatör", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperatorAdi", FormColumnDescription = "Görevli Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_NetSutMiktar", FormColumnDescription = "Net Süt Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutKaynagi", FormColumnDescription = "Süt Kaynağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutBicSevFark", FormColumnDescription = "Sütün Bıçak Sev.Farkı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastorSicakligi", FormColumnDescription = "Pastörize Sıcaklığı(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(Etüv)(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Protein", FormColumnDescription = "Protein", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TLM_ANALIZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSicakligi", FormColumnDescription = "Mayalama Sıcaklığı(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSuresi", FormColumnDescription = "Mayalama Süresi(DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CedarlamaSicakligi", FormColumnDescription = "Çedarlama Sıcaklığı(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CedarlamaSuresi", FormColumnDescription = "Çedarlama Süresi(DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeIndPH", FormColumnDescription = "Teleme İndirildiğindeki PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TLM_ANALIZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Mayalama Sıcaklığı(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasBrix", FormColumnDescription = "Pas Brix Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeMiktari", FormColumnDescription = "Pas Brix Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_RandimanDegeri", FormColumnDescription = "Randıman Değeri (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TLM_ANALIZ", "AIF_TLM_ANALIZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TLM_ANALIZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUT_DEPO"))
                    {
                        TableCreation.CreateTable("AIF_SUT_DEPO", "Süt Depo Seçimi", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUT_DEPO1", "Süt Depo Seçim Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUT_DEPO", "SutMiktari", "Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUT_DEPO", "SutKabulNo", "Süt Kabul No", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUT_DEPO1", "Tank", "Tank", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUT_DEPO1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_SUT_DEPO"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_SutMiktari", "Süt Miktarı");
                        fields.Add("U_SutKabulNo", "Süt Kabul No");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUT_DEPO1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Tank", FormColumnDescription = "Tank", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUT_DEPO", "AIF_SUT_DEPO", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUT_DEPO", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TLMPRSS_ANALIZ"))
                    {
                        TableCreation.CreateTable("AIF_TLMPRSS_ANALIZ", "Teleme Proses Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TLMPRSS_ANALIZ1", "Proses Özellikleri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TLMPRSS_ANALIZ2", "Sütün Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TLMPRSS_ANALIZ3", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TLMPRSS_ANALIZ4", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TLMPRSS_ANALIZ5", "Saf Malzeme Kullanım", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        //TableCreation.CreateTable("AIF_TLMPRSS_ANALIZ6", "Mamul Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        //TableCreation.CreateTable("AIF_TLMPRSS_ANALIZ7", "Mamul Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "TelemeTuru", "Teleme Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "TelemeTuruKod", "Teleme Türü Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "GorevliOperator", "Görevli Operatör", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "GorevliOperatorAdi", "Görevli Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "SutGonBaslangicSaati", "Süt Gönderim Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "SutGonBitisSaati", "Süt Gönderim Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "NetSutMiktari", "Net Süt Miktarı LT", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "SutPastSicakligi", "Sütün Pastorizasyon Sicak", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "EsanjorTankFiltre", "Esanjör ve Tank Filtre Kont.", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ1", "TanktakiSuSeviyesi", "Tanktaki Su Seviyesi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ2", "KuruMadde", "Kuru Madde", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ2", "YagOrani", "Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ2", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ2", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ2", "SuOrani", "Su Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ2", "ProteinOrani", "Protein Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "MayalamaSaati", "Mayalama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "MayalamaSicakligi", "Mayalama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "KirimVeCedarBasSaat", "Kırım ve Çedarlama Baş.Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "CedarlamaSicakligi", "Çedarlama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "KirimVeCedarBitSaat", "Kırım ve Çedarlama Bit.Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "IndirmeBitisSaati", "İndirme Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "BaskiBaslangicSaati", "Baskı Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "BaskiBitisSaati", "Baskı Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ3", "UretimDepoSicakligi", "Üretim Depo Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ4", "SutGonderimSuresiDk", "Süt Gönderim Süresi (DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ4", "MayalamaSuresiDk", "Mayalama Süresi (DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ4", "KirimVeCedarSure", "Kırım ve Çedarlama Suresi(DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ4", "IndirmeSuresi", "Indirme Süresi (DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ4", "BaskiSuresi", "Baskı Süresi (DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ4", "ToplamGecenSure", "Toplam Geçen Süre (DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ5", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ5", "MalMarkaTedarikci", "Malzeme Marka ve Tedarikçi", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ5", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ5", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ5", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);

                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ6", "UrtmSonrasiTelemeMik", "Üretim Sonrası Teleme Miktarı(KG)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ6", "UrtmSonrasiTelemeMik1", "1 Gün Sonra Teleme Miktarı(KG)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ6", "UretimRandimani", "Üretim Randımanı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ6", "PersonelKodu", "Personel Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ6", "PersonelAdi", "Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);

                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ7", "KuruMadde", "Kuru Madde(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ7", "YagOrani", "Yağ Oranı(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ7", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ7", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TLMPRSS_ANALIZ7", "TuzOrani", "Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TLMPRSS_ANALIZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TLMPRSS_ANALIZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeTuru", FormColumnDescription = "Teleme Türü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeTuruKod", FormColumnDescription = "Teleme Türü Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperator", FormColumnDescription = "Görevli Operatör", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperatorAdi", FormColumnDescription = "Görevli Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SutGonBaslangicSaati", FormColumnDescription = "Süt Gönderim Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SutGonBitisSaati", FormColumnDescription = "Süt Gönderim Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_NetSutMiktar", FormColumnDescription = "Net Süt Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutPastSicakligi", FormColumnDescription = "Sütün Pastorizasyon Sicak", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_PastorSicakligi", FormColumnDescription = "Sütün Pastorizasyon Sicak", Editable = SAPbobsCOM.BoYesNoEnum.tYES }); //??
                        fc.Add(new FormColumn { FormColumnAlias = "U_EsanjorTankFiltre", FormColumnDescription = "Esanjör ve Tank Filtre Kont.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TanktakiSuSeviyesi", FormColumnDescription = "Tanktaki Su Seviyesi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TLMPRSS_ANALIZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SuOrani", FormColumnDescription = "Su Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ProteinOrani", FormColumnDescription = "Protein Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TLMPRSS_ANALIZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSaati", FormColumnDescription = "Mayalama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSicakligi", FormColumnDescription = "Mayalama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimVeCedarBasSaat", FormColumnDescription = "Kırım ve Çedarlama Baş.Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CedarlamaSicakligi", FormColumnDescription = "Çedarlama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimVeCedarBitSaat", FormColumnDescription = "Kırım ve Çedarlama Bit.Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IndirmeBitisSaati", FormColumnDescription = "İndirme Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskiBaslangicSaati", FormColumnDescription = "Baskı Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskiBitisSaati", FormColumnDescription = "Baskı Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimDepoSicakligi", FormColumnDescription = "Üretim Depo Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TLMPRSS_ANALIZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SutGonderimSuresiDk", FormColumnDescription = "Süt Gönderim Süresi (DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSuresiDk", FormColumnDescription = "Mayalama Süresi (DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimVeCedarSure", FormColumnDescription = "Kırım ve Çedarlama Suresi(DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IndirmeSuresi", FormColumnDescription = "Indirme Süresi (DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskiSuresi", FormColumnDescription = "Baskı Süresi (DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamGecenSure", FormColumnDescription = "Toplam Geçen Süre (DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TLMPRSS_ANALIZ5";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalMarkaTedarikci", FormColumnDescription = "Malzeme Marka ve Tedarikçi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        //ch = new ChildTable();
                        //ch.TableName = "AIF_TLMPRSS_ANALIZ6";
                        //fc = new List<FormColumn>();

                        //fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        //fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        //fc.Add(new FormColumn { FormColumnAlias = "U_UrtmSonrasiTelemeMik", FormColumnDescription = "Üretim Sonrası Teleme Miktarı(KG)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_UrtmSonrasiTelemeMik1", FormColumnDescription = "1 Gün Sonra Teleme Miktarı(KG)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_UretimRandimani", FormColumnDescription = "Üretim Randımanı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_PersonelKodu", FormColumnDescription = "Personel Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_PersonelAdi", FormColumnDescription = "Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        //ch.FormColumn = fc;
                        //chList.Add(ch);

                        //ch = new ChildTable();
                        //ch.TableName = "AIF_TLMPRSS_ANALIZ7";
                        //fc = new List<FormColumn>();

                        //fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        //fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        //fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oranı(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_TuzOrani", FormColumnDescription = "Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        //ch.FormColumn = fc;
                        //chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TLMPRSS_ANALIZ", "AIF_TLMPRSS_ANALIZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TLMPRSS_ANALIZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TRYGPRSS_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_TRYGPRSS_ANLZ", "Tereyağ Proses Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TRYGPRSS_ANLZ1", "Proses Özellikleri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TRYGPRSS_ANLZ2", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TRYGPRSS_ANLZ3", "Hammade Miktar ve Özellik", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TRYGPRSS_ANLZ4", "Saf Malzeme Kullanım", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TRYGPRSS_ANLZ5", "Mamul Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YagTuru", "Yağ Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YagTuruKod", "Yağ Türü Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "GorevliOperator", "Görevli Operatör", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "GorevliOperatorAdi", "Görevli Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "KremaPastorizasyonSicak", "Krema Pastörizasyon Sıcak", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YayigaKremaYukBasSaat", "Yayığa Krema Yük. Baş. Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YayigaKremaYukBitSaat", "Yayığa Krema Yük. Bit. Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YagOlusmaSaati", "Yağ Oluşma Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YikamaSayisi", "Yıkama Sayısı", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YikamaBitisSaati", "Yıkama Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YaginYayiktanIndSaat", "Yağın Yayıktan İndirilme Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YaginGramajlamaBasSaat", "Yağın Gramajlama Baş. Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ1", "YaginGramajlamaBitSaat", "Yağın Gramajlama Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ2", "KremaYuklemeSuresiDk", "Krema Yükleme Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ2", "YayiklamaSuresiDk", "Yayıklama Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ2", "YikamaSuresiDk", "Yıkama Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ2", "YaginGramajlamaSuresiDk", "Yağın Gramajlama Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ2", "ToplamGecenSureDk", "Toplam Geçen Süre DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ3", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ3", "KuruMadde", "Kuru Madde (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ3", "YagOrani", "Yağ Oranı (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ3", "PH", "PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ3", "SH", "SH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ3", "HammaddePartiNo", "Hammade Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ3", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ3", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ4", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ4", "MalMarkaTedarikci", "Mal Markası ve Tedarikçisi", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ4", "SarfMalzemePartiNo", "Sarf Malzeme Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ4", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ4", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ5", "HammaddeSarfMalzTop", "Hammadde ve Sarf Malzeme Top.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ5", "UretilenUrunMik", "Üretilen Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ5", "UretilenUrunAdi", "Üretilen Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ5", "KuruMadde", "Kuru Madde(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ5", "YagOrani", "Yağ Oranı(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ5", "YayikAltiSuyuOran", "Yayık Altı Suyu Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS_ANLZ5", "YaginPH", "Yağın PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TRYGPRSS_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagTuru", FormColumnDescription = "Yağ Türü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagTuruKod", FormColumnDescription = "Yağ Türü Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperator", FormColumnDescription = "Görevli Operatör", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperatorAdi", FormColumnDescription = "Görevli Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaPastorizasyonSicak", FormColumnDescription = "Krema Pastörizasyon Sıcak", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YayigaKremaYukBasSaat", FormColumnDescription = "Yayığa Krema Yük. Baş. Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YayigaKremaYukBitSaat", FormColumnDescription = "Yayığa Krema Yük. Bit. Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOlusmaSaati", FormColumnDescription = "Yağ Oluşma Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YikamaSayisi", FormColumnDescription = "Yıkama Sayısı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YikamaBitisSaati", FormColumnDescription = "Yıkama Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YaginYayiktanIndSaat", FormColumnDescription = "Yağın Yayıktan İndirilme Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YaginGramajlamaBasSaat", FormColumnDescription = "Yağın Gramajlama Baş. Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YaginGramajlamaBitSaat", FormColumnDescription = "Yağın Gramajlama Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaYuklemeSuresiDk", FormColumnDescription = "Krema Yükleme Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YayiklamaSuresiDk", FormColumnDescription = "Yayıklama Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YikamaSuresiDk", FormColumnDescription = "Yıkama Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YaginGramajlamaSuresiDk", FormColumnDescription = "Yağın Gramajlama Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamGecenSureDk", FormColumnDescription = "Toplam Geçen Süre DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oranı (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddePartiNo", FormColumnDescription = "Hammade Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalMarkaTedarikci", FormColumnDescription = "Mal Markası ve Tedarikçisi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SarfMalzemePartiNo", FormColumnDescription = "Sarf Malzeme Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS_ANLZ5";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeSarfMalzTop", FormColumnDescription = "Hammadde ve Sarf Malzeme Top.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunMik", FormColumnDescription = "Üretilen Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunAdi", FormColumnDescription = "Üretilen Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oranı(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YayikAltiSuyuOran", FormColumnDescription = "Yayık Altı Suyu Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YaginPH", FormColumnDescription = "Yağın PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TRYGPRSS_ANLZ", "AIF_TRYGPRSS_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TRYGPRSS_ANLZ", "", chList: chList);
                    }

                    #region otat excelde yok.uvt de yok.buradan da kapatıldı.20211229

                    //if (!TableCreation.TableExists("AIF_TLMPMML_ANALIZ"))
                    //{
                    //    TableCreation.CreateTable("AIF_TLMMML_ANALIZ", "Teleme Mamül Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                    //    TableCreation.CreateTable("AIF_TLMMML_ANALIZ1", "Mamül-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                    //    TableCreation.CreateTable("AIF_TLMMML_ANALIZ2", "Mamül-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ1", "UrtmSonrasiTelemeMik", "Üretim Sonrası Teleme Miktarı(KG)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ1", "UrtmSonrasiTelemeMik1", "1 Gün Sonra Teleme Miktarı(KG)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ1", "UretimRandimani", "Üretim Randımanı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ1", "PersonelKodu", "Personel Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ1", "PersonelAdi", "Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);

                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ2", "KuruMadde", "Kuru Madde(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ2", "YagOrani", "Yağ Oranı(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ2", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ2", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    //    TableCreation.CreateUserFields("@AIF_TLMMML_ANALIZ2", "TuzOrani", "Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    //}

                    //if (!UdoCreation.UDOExists("AIF_TLMMML_ANALIZ"))
                    //{
                    //    fields.Clear();
                    //    fields.Add("DocEntry", "Kod");
                    //    fields.Add("U_PartiNo", "Parti No");
                    //    fields.Add("U_Aciklama", "Açıklama");
                    //    fields.Add("U_UretimTarihi", "Üretim Tarihi");

                    //    List<FormColumn> fc = new List<FormColumn>();
                    //    List<ChildTable> chList = new List<ChildTable>();

                    //    ChildTable ch = new ChildTable();
                    //    ch.TableName = "AIF_TLMMML_ANALIZ1";

                    //    fc = new List<FormColumn>();

                    //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    //    fc.Add(new FormColumn { FormColumnAlias = "U_UrtmSonrasiTelemeMik", FormColumnDescription = "Üretim Sonrası Teleme Miktarı(KG)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_UrtmSonrasiTelemeMik1", FormColumnDescription = "1 Gün Sonra Teleme Miktarı(KG)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_UretimRandimani", FormColumnDescription = "Üretim Randımanı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_PersonelKodu", FormColumnDescription = "Personel Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_PersonelAdi", FormColumnDescription = "Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                    //    ch.FormColumn = fc;
                    //    chList.Add(ch);

                    //    ch = new ChildTable();
                    //    ch.TableName = "AIF_TLMMML_ANALIZ2";
                    //    fc = new List<FormColumn>();

                    //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    //    fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oranı(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //    fc.Add(new FormColumn { FormColumnAlias = "U_TuzOrani", FormColumnDescription = "Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                    //    ch.FormColumn = fc;
                    //    chList.Add(ch);

                    //    UdoCreation.RegisterUDOWithChildTable("AIF_TLMMML_ANALIZ", "AIF_TLMMML_ANALIZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TLMMML_ANALIZ", "", chList: chList);
                    //} 
                    #endregion

                    if (!TableCreation.TableExists("AIF_TZPPRSS_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_TZPPRSS_ANLZ", "Taze Peynir Proses Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TZPPRSS_ANLZ1", "Proses Özellikleri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TZPPRSS_ANLZ2", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TZPPRSS_ANLZ3", "Hammade Miktar ve Özellik", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TZPPRSS_ANLZ4", "Saf Malzeme Kullanım", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TZPPRSS_ANLZ5", "Mamul Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "HamurTuru", "Hamur Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "YagTuruKod", "Yağ Türü Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "GorevliOperator", "Görevli Operatör", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "GorevliOperatorAdi", "Görevli Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "HammaddeYukBasSaat", "Hammadde Yükleme Baş. Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "HammaddeYukBitSaat", "Hammadde Yükleme Bit. Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "KarisimPastorSicak", "Karışım Past. Sıcakligi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "FiltreKontrolu", "Filtre Kontrolü", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "PisirmeMakIndSaati", "Pişirme Mak. Indirilme Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "HamurGramajlamaBasSaat", "Hamurun Gramajlama Baş. Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "HamurGramajlamaBitSaat", "Hamurun Gramajlama Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ2", "HammaddeYukSureDk", "Hammadde Yükleme Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ2", "HamurPismeSuresiDk", "Hamur Pişme Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ2", "HamurGramajSureDk", "Hamurun Gramajlanma Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ2", "ToplamGecenSureDk", "Toplam Geçen Süre DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ3", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ3", "KuruMadde", "Kuru Madde (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ3", "YagOrani", "Yağ Oranı (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ3", "PH", "PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ3", "SH", "SH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ3", "HammaddePartiNo", "Hammade Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ3", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ3", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ4", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ4", "MalMarkaTedarikci", "Mal Markası ve Tedarikçisi", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ4", "SarfMalzemePartiNo", "Sarf Malzeme Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ4", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ4", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ5", "HammaddeSarfMalzTop", "Hammadde ve Sarf Malzeme Top.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ5", "UretilenUrunMik", "Üretilen Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ5", "UretilenUrunAdi", "Üretilen Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ5", "KuruMadde", "Kuru Madde(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ5", "HamurYagOrani", "Hamur Yağ Oranı(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ5", "HamurPH", "Hamurun PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TZPPRSS_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TZPPRSS_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurTuru", FormColumnDescription = "Hamur Türü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_YagTuruKod", FormColumnDescription = "Yağ Türü Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperator", FormColumnDescription = "Görevli Operatör", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperatorAdi", FormColumnDescription = "Görevli Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeYukBasSaat", FormColumnDescription = "Hammadde Yükleme Baş. Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeYukBitSaat", FormColumnDescription = "Hammadde Yükleme Bit. Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KarisimPastorSicak", FormColumnDescription = "Karışım Past. Sıcakligi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_FiltreKontrolu", FormColumnDescription = "Filtre Kontrolü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PisirmeMakIndSaati", FormColumnDescription = "Pişirme Mak. Indirilme Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurGramajlamaBasSaat", FormColumnDescription = "Hamurun Gramajlama Baş. Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurGramajlamaBitSaat", FormColumnDescription = "Hamurun Gramajlama Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TZPPRSS_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeYukSureDk", FormColumnDescription = "Hammadde Yükleme Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurPismeSuresiDk", FormColumnDescription = "Hamur Pişme Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurGramajSureDk", FormColumnDescription = "Hamurun Gramajlanma Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamGecenSureDk", FormColumnDescription = "Toplam Geçen Süre DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TZPPRSS_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oranı (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddePartiNo", FormColumnDescription = "Hammade Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TZPPRSS_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalMarkaTedarikci", FormColumnDescription = "Mal Markası ve Tedarikçisi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SarfMalzemePartiNo", FormColumnDescription = "Sarf Malzeme Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TZPPRSS_ANLZ5";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeSarfMalzTop", FormColumnDescription = "Hammadde ve Sarf Malzeme Top.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunMik", FormColumnDescription = "Üretilen Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunAdi", FormColumnDescription = "Üretilen Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurYagOrani", FormColumnDescription = "Hamur Yağ Oranı(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurPH", FormColumnDescription = "Hamurun PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TZPPRSS_ANLZ", "AIF_TZPPRSS_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TZPPRSS_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TSTPRSS_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_TSTPRSS_ANLZ", "TostPeyniri Proses Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TSTPRSS_ANLZ1", "Proses Özellikleri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TSTPRSS_ANLZ2", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TSTPRSS_ANLZ3", "Hammade Miktar ve Özellik", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TSTPRSS_ANLZ4", "Saf Malzeme Kullanım", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TSTPRSS_ANLZ5", "Mamul Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "HamurTuru", "Hamur Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_TZPPRSS_ANLZ1", "YagTuruKod", "Yağ Türü Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "GorevliOperator", "Görevli Operatör", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "GorevliOperatorAdi", "Görevli Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "HammaddeYukBasSaat", "Hammadde Yükleme Baş. Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "HammaddeYukBitSaat", "Hammadde Yükleme Bit. Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "HamurPastorSicakligi", "Hamur Pastor. Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "VakumSuresi", "Vakum Süresi (DK)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "PisirmeMakIndSaati", "Pişirme Mak. Indirilme Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ1", "HamurGramajlamaBitSaat", "Hamurun Gramajlama Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ2", "HammaddeYukSureDk", "Hammadde Yükleme Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ2", "HamurPismeSuresiDk", "Hamur Pişme Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ2", "VakumSuresiDk", "Vakum Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ2", "HamurGramajSureDk", "Hamurun Gramajlanma Süresi DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ2", "ToplamGecenSureDk", "Toplam Geçen Süre DK", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ3", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ3", "KuruMadde", "Kuru Madde (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ3", "YagOrani", "Yağ Oranı (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ3", "PH", "PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ3", "SH", "SH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ3", "HammaddePartiNo", "Hammade Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ3", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ3", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ4", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ4", "MalMarkaTedarikci", "Mal Markası ve Tedarikçisi", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ4", "SarfMalzemePartiNo", "Sarf Malzeme Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ4", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ4", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ5", "HammaddeSarfMalzTop", "Hammadde ve Sarf Malzeme Top.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ5", "UretilenUrunMik", "Üretilen Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ5", "UretilenUrunAdi", "Üretilen Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ5", "KuruMadde", "Kuru Madde(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ5", "HamurYagOrani", "Hamur Yağ Oranı(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS_ANLZ5", "HamurPH", "Hamurun PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_TSTPRSS_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurTuru", FormColumnDescription = "Hamur Türü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_YagTuruKod", FormColumnDescription = "Yağ Türü Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperator", FormColumnDescription = "Görevli Operatör", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GorevliOperatorAdi", FormColumnDescription = "Görevli Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeYukBasSaat", FormColumnDescription = "Hammadde Yükleme Baş. Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeYukBitSaat", FormColumnDescription = "Hammadde Yükleme Bit. Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurPastorSicakligi", FormColumnDescription = "Hamur Pastor. Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_VakumSuresi", FormColumnDescription = "Vakum Süresi (DK)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PisirmeMakIndSaati", FormColumnDescription = "Pişirme Mak. Indirilme Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurGramajlamaBitSaat", FormColumnDescription = "Hamurun Gramajlama Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeYukSureDk", FormColumnDescription = "Hammadde Yükleme Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurPismeSuresiDk", FormColumnDescription = "Hamur Pişme Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_VakumSuresiDk", FormColumnDescription = "Vakum Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurGramajSureDk", FormColumnDescription = "Hamurun Gramajlanma Süresi DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamGecenSureDk", FormColumnDescription = "Toplam Geçen Süre DK", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oranı (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddePartiNo", FormColumnDescription = "Hammade Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalMarkaTedarikci", FormColumnDescription = "Mal Markası ve Tedarikçisi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SarfMalzemePartiNo", FormColumnDescription = "Sarf Malzeme Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS_ANLZ5";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_HammaddeSarfMalzTop", FormColumnDescription = "Hammadde ve Sarf Malzeme Top.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunMik", FormColumnDescription = "Üretilen Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunAdi", FormColumnDescription = "Üretilen Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurYagOrani", FormColumnDescription = "Hamur Yağ Oranı(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HamurPH", FormColumnDescription = "Hamurun PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TSTPRSS_ANLZ", "AIF_TSTPRSS_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TSTPRSS_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TRYGPRSS2_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_TRYGPRSS2_ANLZ", "Tereyağ Proses Anlz Takip 2", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TRYGPRSS2_ANLZ1", "Mamul Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        //TableCreation.CreateTable("AIF_TRYGPRSS2_ANLZ2", "Dinlendirme Paketleme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TRYGPRSS2_ANLZ2", "Paketleme Saf Malzeme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TRYGPRSS2_ANLZ3", "Dedetörden Geçirme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TRYGPRSS2_ANLZ4", "Gramajlama Kontrol", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ", "PaketlemeTarihi", "Paketleme Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "UretilenUrunler", "Üretilen Ürünler", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "PaketlemeOncesiSicakik", "Paketleme Öncesi Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "UretimMiktari", "Üretim Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "PaketlenenUrunMiktari", "Paketlenen Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "FireUrunMiktari", "Fire Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "NumuneUrunMiktari", "Numune Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "DepoyaGirenUrunMik", "Depoya Giren Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "KuruMadde", "Kuru Madde(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "YagOrani", "Yağ Oran(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "PH", "PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "SH", "SH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ1", "TuzOrani", "Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "SifirSekizSicaklik", "08:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "SifirSekizNem", "08:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnikiSicaklik", "12:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnikiNem", "12:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnBesSicaklik", "15:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnBesNem", "15:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnSekizSicaklik", "18:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnSekizNem", "18:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "MalMarkaTedarikci", "Mal Markası ve Tedarikçisi", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "SarfMalzemePartiNo", "Sarf Malzeme Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ3", "DedektorGecirilmeKontrol", "Dedektörden Geçirilme Kontrolü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "UrunCesidi", "Ürün Çeşidi", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "BirinciOrnek", "1.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "IkinciOrnek", "2.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "UcuncuOrnek", "3.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "DorduncuOrnek", "4.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "BesinciOrnek", "5.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "AltinciOrnek", "6.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ4", "YedinciOrnek", "7.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TRYGPRSS2_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS2_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunler", FormColumnDescription = "Üretilen Ürünler", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketlemeOncesiSicakik", FormColumnDescription = "Paketleme Öncesi Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimMiktari", FormColumnDescription = "Üretim Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketlenenUrunMiktari", FormColumnDescription = "Paketlenen Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_FireUrunMiktari", FormColumnDescription = "Fire Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NumuneUrunMiktari", FormColumnDescription = "Numune Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DepoyaGirenUrunMik", FormColumnDescription = "Depoya Giren Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oran(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TuzOrani", FormColumnDescription = "Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        //ch = new ChildTable();
                        //ch.TableName = "AIF_TRYGPRSS2_ANLZ2";
                        //fc = new List<FormColumn>();

                        //fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        //fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        //fc.Add(new FormColumn { FormColumnAlias = "U_SifirSekizSicaklik", FormColumnDescription = "08:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_SifirSekizNem", FormColumnDescription = "08:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnikiSicaklik", FormColumnDescription = "12:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnikiNem", FormColumnDescription = "12:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnBesSicaklik", FormColumnDescription = "15:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnBesNem", FormColumnDescription = "15:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnSekizSicaklik", FormColumnDescription = "18:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnSekizNem", FormColumnDescription = "18:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        //ch.FormColumn = fc;
                        //chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS2_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalMarkaTedarikci", FormColumnDescription = "Mal Markası ve Tedarikçisi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SarfMalzemePartiNo", FormColumnDescription = "Sarf Malzeme Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS2_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_DedektorGecirilmeKontrol", FormColumnDescription = "Dedektörden Geçirilme Kontrolü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TRYGPRSS2_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunCesidi", FormColumnDescription = "Ürün Çeşidi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirinciOrnek", FormColumnDescription = "1.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IkinciOrnek", FormColumnDescription = "2.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UcuncuOrnek", FormColumnDescription = "3.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DorduncuOrnek", FormColumnDescription = "4.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BesinciOrnek", FormColumnDescription = "5.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AltinciOrnek", FormColumnDescription = "6.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YedinciOrnek", FormColumnDescription = "7.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TRYGPRSS2_ANLZ", "AIF_TRYGPRSS2_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TRYGPRSS2_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TRYGDNPKT"))
                    {
                        TableCreation.CreateTable("AIF_TRYGDNPKT", "Dinlendirme ve Paketleme Odası", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "AlanAdi", "Alan Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "SifirSekizSicaklik", "08:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "SifirSekizNem", "08:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "OnikiSicaklik", "12:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "OnikiNem", "12:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "OnBesSicaklik", "15:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "OnBesNem", "15:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "OnSekizSicaklik", "18:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TRYGDNPKT", "OnSekizNem", "18:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TRYGDNPKT"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_AlanAdi", "Alan Adı");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_SifirSekizSicaklik", "08:00 Sıcaklık");
                        fields.Add("U_SifirSekizNem", "08:00 Nem");
                        fields.Add("U_OnikiSicaklik", "12:00 Sıcaklık");
                        fields.Add("U_OnikiNem", "12:00 Nem");
                        fields.Add("U_OnBesSicaklik", "15:00 Sıcaklık");
                        fields.Add("U_OnBesNem", "15:00 Nem");
                        fields.Add("U_OnSekizSicaklik", "18:00 Sıcaklık");
                        fields.Add("U_OnSekizNem", "18:00 Nem");

                        UdoCreation.RegisterUDOForDefaultForm("AIF_TRYGDNPKT", "AIF_TRYGDNPKT", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TRYGDNPKT", "");
                    }

                    if (!TableCreation.TableExists("AIF_TSTPRSS2_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_TSTPRSS2_ANLZ", "Tost Proses Anlz Takip 2", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TSTPRSS2_ANLZ1", "Mamul Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        //TableCreation.CreateTable("AIF_TRYGPRSS2_ANLZ2", "Dinlendirme Paketleme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TSTPRSS2_ANLZ2", "Paketleme Saf Malzeme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TSTPRSS2_ANLZ3", "Dedetörden Geçirme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TSTPRSS2_ANLZ4", "Gramajlama Kontrol", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ", "PaketlemeTarihi", "Paketleme Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ", "SislemeYapanPrsnl", "Sisleme Yapan Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ", "SislemeKntrlEdnPrsnl", "Sisleme Kontrol Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "UretilenUrunler", "Üretilen Ürünler", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "PaketlemeOncesiSicakik", "Paketleme Öncesi Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "UretimMiktari", "Üretim Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "PaketlenenUrunMiktari", "Paketlenen Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "FireUrunMiktari", "Fire Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "NumuneUrunMiktari", "Numune Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "DepoyaGirenUrunMik", "Depoya Giren Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "KuruMadde", "Kuru Madde(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "YagOrani", "Yağ Oran(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "PH", "PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "SH", "SH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ1", "TuzOrani", "Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "SifirSekizSicaklik", "08:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "SifirSekizNem", "08:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnikiSicaklik", "12:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnikiNem", "12:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnBesSicaklik", "15:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnBesNem", "15:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnSekizSicaklik", "18:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_TRYGPRSS2_ANLZ2", "OnSekizNem", "18:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ2", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ2", "MalMarkaTedarikci", "Mal Markası ve Tedarikçisi", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ2", "SarfMalzemePartiNo", "Sarf Malzeme Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ2", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ2", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ3", "DedektorGecirilmeKontrol", "Dedektörden Geçirilme Kontrolü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "UrunCesidi", "Ürün Çeşidi", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "BirinciOrnek", "1.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "IkinciOrnek", "2.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "UcuncuOrnek", "3.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "DorduncuOrnek", "4.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "BesinciOrnek", "5.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "AltinciOrnek", "6.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ4", "YedinciOrnek", "7.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TSTPRSS2_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_PaketlemeTarihi", "Paketleme Tarihi");
                        fields.Add("U_SislemeYapanPrsnl", "Sisleme Yapan Personel");
                        fields.Add("U_SislemeKntrlEdnPrsnl", "Sisleme Kontrol Personel");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS2_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunler", FormColumnDescription = "Üretilen Ürünler", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketlemeOncesiSicakik", FormColumnDescription = "Paketleme Öncesi Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimMiktari", FormColumnDescription = "Üretim Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketlenenUrunMiktari", FormColumnDescription = "Paketlenen Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_FireUrunMiktari", FormColumnDescription = "Fire Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NumuneUrunMiktari", FormColumnDescription = "Numune Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DepoyaGirenUrunMik", FormColumnDescription = "Depoya Giren Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oran(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TuzOrani", FormColumnDescription = "Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        //ch = new ChildTable();
                        //ch.TableName = "AIF_TRYGPRSS2_ANLZ2";
                        //fc = new List<FormColumn>();

                        //fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        //fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        //fc.Add(new FormColumn { FormColumnAlias = "U_SifirSekizSicaklik", FormColumnDescription = "08:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_SifirSekizNem", FormColumnDescription = "08:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnikiSicaklik", FormColumnDescription = "12:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnikiNem", FormColumnDescription = "12:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnBesSicaklik", FormColumnDescription = "15:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnBesNem", FormColumnDescription = "15:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnSekizSicaklik", FormColumnDescription = "18:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnSekizNem", FormColumnDescription = "18:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        //ch.FormColumn = fc;
                        //chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS2_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalMarkaTedarikci", FormColumnDescription = "Mal Markası ve Tedarikçisi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SarfMalzemePartiNo", FormColumnDescription = "Sarf Malzeme Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS2_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_DedektorGecirilmeKontrol", FormColumnDescription = "Dedektörden Geçirilme Kontrolü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TSTPRSS2_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunCesidi", FormColumnDescription = "Ürün Çeşidi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirinciOrnek", FormColumnDescription = "1.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IkinciOrnek", FormColumnDescription = "2.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UcuncuOrnek", FormColumnDescription = "3.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DorduncuOrnek", FormColumnDescription = "4.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BesinciOrnek", FormColumnDescription = "5.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AltinciOrnek", FormColumnDescription = "6.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YedinciOrnek", FormColumnDescription = "7.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TSTPRSS2_ANLZ", "AIF_TSTPRSS2_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TSTPRSS2_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TSTDNPKT"))
                    {
                        TableCreation.CreateTable("AIF_TSTDNPKT", "Kurutma ve Paketleme Odası", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "AlanAdi", "Alan Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "SifirSekizSicaklik", "08:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "SifirSekizNem", "08:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "OnikiSicaklik", "12:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "OnikiNem", "12:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "OnBesSicaklik", "15:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "OnBesNem", "15:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "OnSekizSicaklik", "18:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TSTDNPKT", "OnSekizNem", "18:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TSTDNPKT"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_AlanAdi", "Alan Adı");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_SifirSekizSicaklik", "08:00 Sıcaklık");
                        fields.Add("U_SifirSekizNem", "08:00 Nem");
                        fields.Add("U_OnikiSicaklik", "12:00 Sıcaklık");
                        fields.Add("U_OnikiNem", "12:00 Nem");
                        fields.Add("U_OnBesSicaklik", "15:00 Sıcaklık");
                        fields.Add("U_OnBesNem", "15:00 Nem");
                        fields.Add("U_OnSekizSicaklik", "18:00 Sıcaklık");
                        fields.Add("U_OnSekizNem", "18:00 Nem");

                        UdoCreation.RegisterUDOForDefaultForm("AIF_TSTDNPKT", "AIF_TSTDNPKT", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TSTDNPKT", "");
                    }

                    if (!TableCreation.TableExists("AIF_TZPRSS2_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_TZPRSS2_ANLZ", "TazeP Proses Anlz Takip 2", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_TZPRSS2_ANLZ1", "Mamul Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        //TableCreation.CreateTable("AIF_TRYGPRSS2_ANLZ2", "Dinlendirme Paketleme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TZPRSS2_ANLZ2", "Paketleme Saf Malzeme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        //TableCreation.CreateTable("AIF_TSTPRSS2_ANLZ3", "Dedetörden Geçirme", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TZPRSS2_ANLZ3", "Gramajlama Kontrol", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ", "PaketlemeTarihi", "Paketleme Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        //TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ", "SislemeYapanPrsnl", "Sisleme Yapan Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ", "SislemeKntrlEdnPrsnl", "Sisleme Kontrol Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "UretilenUrunler", "Üretilen Ürünler", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "PaketlemeOncesiSicakik", "Paketleme Öncesi Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "UretimMiktari", "Üretim Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "PaketlenenUrunMiktari", "Paketlenen Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "FireUrunMiktari", "Fire Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "NumuneUrunMiktari", "Numune Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "DepoyaGirenUrunMik", "Depoya Giren Ürün Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "KuruMadde", "Kuru Madde(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "YagOrani", "Yağ Oran(%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "PH", "PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "SH", "SH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ1", "TuzOrani", "Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ2", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ2", "MalMarkaTedarikci", "Mal Markası ve Tedarikçisi", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ2", "SarfMalzemePartiNo", "Sarf Malzeme Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ2", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ2", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        //TableCreation.CreateUserFields("@AIF_TSTPRSS2_ANLZ3", "DedektorGecirilmeKontrol", "Dedektörden Geçirilme Kontrolü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "UrunCesidi", "Ürün Çeşidi", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "BirinciOrnek", "1.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "IkinciOrnek", "2.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "UcuncuOrnek", "3.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "DorduncuOrnek", "4.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "BesinciOrnek", "5.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "AltinciOrnek", "6.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPRSS2_ANLZ3", "YedinciOrnek", "7.Örnek", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TZPRSS2_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_PaketlemeTarihi", "Paketleme Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_TZPRSS2_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenUrunler", FormColumnDescription = "Üretilen Ürünler", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketlemeOncesiSicakik", FormColumnDescription = "Paketleme Öncesi Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimMiktari", FormColumnDescription = "Üretim Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketlenenUrunMiktari", FormColumnDescription = "Paketlenen Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_FireUrunMiktari", FormColumnDescription = "Fire Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NumuneUrunMiktari", FormColumnDescription = "Numune Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DepoyaGirenUrunMik", FormColumnDescription = "Depoya Giren Ürün Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oran(%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TuzOrani", FormColumnDescription = "Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        //ch = new ChildTable();
                        //ch.TableName = "AIF_TRYGPRSS2_ANLZ2";
                        //fc = new List<FormColumn>();

                        //fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        //fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        //fc.Add(new FormColumn { FormColumnAlias = "U_SifirSekizSicaklik", FormColumnDescription = "08:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_SifirSekizNem", FormColumnDescription = "08:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnikiSicaklik", FormColumnDescription = "12:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnikiNem", FormColumnDescription = "12:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnBesSicaklik", FormColumnDescription = "15:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnBesNem", FormColumnDescription = "15:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnSekizSicaklik", FormColumnDescription = "18:00 Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OnSekizNem", FormColumnDescription = "18:00 Nem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        //ch.FormColumn = fc;
                        //chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TZPRSS2_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalMarkaTedarikci", FormColumnDescription = "Mal Markası ve Tedarikçisi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SarfMalzemePartiNo", FormColumnDescription = "Sarf Malzeme Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TZPRSS2_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunCesidi", FormColumnDescription = "Ürün Çeşidi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirinciOrnek", FormColumnDescription = "1.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IkinciOrnek", FormColumnDescription = "2.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UcuncuOrnek", FormColumnDescription = "3.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DorduncuOrnek", FormColumnDescription = "4.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BesinciOrnek", FormColumnDescription = "5.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AltinciOrnek", FormColumnDescription = "6.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YedinciOrnek", FormColumnDescription = "7.Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TZPRSS2_ANLZ", "AIF_TZPRSS2_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TZPRSS2_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_TZPDNPKT"))
                    {
                        TableCreation.CreateTable("AIF_TZPDNPKT", "Dinlendirme ve Paketleme Odası", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "AlanAdi", "Alan Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "SifirSekizSicaklik", "08:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "SifirSekizNem", "08:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "OnikiSicaklik", "12:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "OnikiNem", "12:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "OnBesSicaklik", "15:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "OnBesNem", "15:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "OnSekizSicaklik", "18:00 Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TZPDNPKT", "OnSekizNem", "18:00 Nem", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }
                    if (!UdoCreation.UDOExists("AIF_TZPDNPKT"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_AlanAdi", "Alan Adı");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_SifirSekizSicaklik", "08:00 Sıcaklık");
                        fields.Add("U_SifirSekizNem", "08:00 Nem");
                        fields.Add("U_OnikiSicaklik", "12:00 Sıcaklık");
                        fields.Add("U_OnikiNem", "12:00 Nem");
                        fields.Add("U_OnBesSicaklik", "15:00 Sıcaklık");
                        fields.Add("U_OnBesNem", "15:00 Nem");
                        fields.Add("U_OnSekizSicaklik", "18:00 Sıcaklık");
                        fields.Add("U_OnSekizNem", "18:00 Nem");

                        UdoCreation.RegisterUDOForDefaultForm("AIF_TZPDNPKT", "AIF_TZPDNPKT", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TZPDNPKT", "");
                    }

                    if (!TableCreation.TableExists("AIF_TEMIZLIK"))
                    {
                        TableCreation.CreateTable("AIF_TEMIZLIK", "Temizlik Ekranları", SAPbobsCOM.BoUTBTableType.bott_Document);
                        //TableCreation.CreateTable("AIF_TEMIZLIK1", "CIP Temizlik 1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TEMIZLIK2", "CIP Temizlik 2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_TEMIZLIK3", "Alet Ekipman Temizlik", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_TEMIZLIK", "IstasyonKodu", "İstasyon Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK", "IstasyonTanimi", "İstasyon Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        //TableCreation.CreateUserFields("@AIF_TEMIZLIK1", "KontrolAdi", "Kontrol Adı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_TEMIZLIK1", "DegerKod", "Değer Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_TEMIZLIK1", "Deger", "Değer", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "KontrolAdi", "Kontrol Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AlkaliBasSaat", "Alkali Başlangıç Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AlkaliSc", "Alkali SC", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AlkaliKonMs", "Alkali Kontrol Ms", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AlkaliKonYuzde", "Alkali Kontrol Yüzde", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AlkaliBitSaat", "Alkali Bitiş Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AsitBasSaat", "Asit Başlangıç Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AsitSc", "Asit Sc", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AsitKonMs", "Asit Kon Ms", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AsitKonYuzde", "Asit Kontrol Yüzde", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "AsitBitSaat", "Asit Bitiş Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "TemizlikPers", "Temizlik Personeli", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "OzonitKontrol", "Ozonit Kontrol", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "DurulamaPh", "Durulama PH", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "DezenPrsnl", "Dezenfekte Eden Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "HaslamaSc", "Haşlama Sc", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "HaslamaPrsnl", "Haşlama Yapan Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "KontrolPersonel", "Kontrol Eden Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "Yapildi", "Yapıldı", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK2", "Yapilmadi", "Yapılmadı", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_TEMIZLIK3", "AlanMakine", "Temizlenen Alan Makine", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK3", "YapilmaSikligi", "Temizlik Yapılma Sıklığı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK3", "KimyasalAdi", "Kullanılan Kimyasal Adı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK3", "KimyasalMiktari", "Kullanılan Kimyasal Miktarı", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK3", "KontrolYapildi", "Temizlik Kontrol Yapıldı", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK3", "KontrolYapilmadi", "Temizlik Kontrol Yapılmadı", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK3", "TemizlikYapanPrsnl", "Temizlik Yapan Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_TEMIZLIK3", "TemizlikKontPrsnl", "Temizlik Yapan Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }
                    if (!UdoCreation.UDOExists("AIF_TEMIZLIK"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_IstasyonKodu", "Istasyon Kodu");
                        fields.Add("U_IstasyonTanimi", "İstasyon Tanımı");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        //ch.TableName = "AIF_TEMIZLIK1";
                        //fc = new List<FormColumn>();

                        //fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        //fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        //fc.Add(new FormColumn { FormColumnAlias = "U_KontrolAdi", FormColumnDescription = "Kontrol Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_DegerKod", FormColumnDescription = "Değer Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_Deger", FormColumnDescription = "Değer", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        //ch.FormColumn = fc;
                        //chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_TEMIZLIK2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolAdi", FormColumnDescription = "Kontrol Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlkaliBasSaat", FormColumnDescription = "Alkali Başlangıç Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlkaliSc", FormColumnDescription = "Alkali SC", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlkaliKonMs", FormColumnDescription = "Alkali Kontrol Ms", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlkaliKonYuzde", FormColumnDescription = "Alkali Kontrol Yüzde", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlkaliBitSaat", FormColumnDescription = "Alkali Bitiş Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AsitBasSaat", FormColumnDescription = "Asit Başlangıç Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AsitSc", FormColumnDescription = "Asit Sc", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AsitKonMs", FormColumnDescription = "Asit Kon Ms", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlkaliKonYuzde", FormColumnDescription = "Asit Kontrol Yüzde", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AsitBitSaat", FormColumnDescription = "Asit Bitiş Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TemizlikPers", FormColumnDescription = "Temizlik Personeli", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OzonitKontrol", FormColumnDescription = "Ozonit Kontrol", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DurulamaPh", FormColumnDescription = "Durulama PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AsitKonYuzde", FormColumnDescription = "Asit Kontrol Yüzde", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DezenPrsnl", FormColumnDescription = "Dezenfekte Eden Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HaslamaSc", FormColumnDescription = "Haşlama Yapan Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HaslamaPrsnl", FormColumnDescription = "Kontrol Eden Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolPersonel", FormColumnDescription = "Asit Kontrol Yüzde", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolAdi", FormColumnDescription = "Kontrol Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yapildi", FormColumnDescription = "Yapıldı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yapilmadi", FormColumnDescription = "Yapılmadı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);
                        //commit

                        ch = new ChildTable();
                        ch.TableName = "AIF_TEMIZLIK3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_AlanMakine", FormColumnDescription = "Temizlenen Alan Makine", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YapilmaSikligi", FormColumnDescription = "Temizlik Yapılma Sıklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KimyasalAdi", FormColumnDescription = "Kullanılan Kimyasal Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KimyasalMiktari", FormColumnDescription = "Kullanılan Kimyasal Mıktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolYapildi", FormColumnDescription = "Temizlik Kontrol Yapıldı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolYapilmadi", FormColumnDescription = "Temizlik Kontrol Yapılmadı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TemizlikYapanPrsnl", FormColumnDescription = "Temizlik Yapan Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TemizlikKontPrsnl", FormColumnDescription = "Temizlik Yapan Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_TEMIZLIK", "AIF_TEMIZLIK", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_TEMIZLIK", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_AYRPRSS_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ", "Ayran Proses Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ1", "Proses Özellikleri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ2", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ3", "Pıhtı Kırım Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ4", "1.Kültür Bilgileri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ5", "2.Kültür Bilgileri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ6", "Tuz Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ7", "Sütün Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ8", "Yarı Mamül Kalite Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRPRSS_ANLZ9", "Inkübasyon Takip Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ1", "UrunGrubu", "Ürün Grubu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ1", "ProsesBasSaat", "Proses Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ1", "YagliSutMik", "Yağlı Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ1", "YagsizSutMik", "Yağsız Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ1", "ToplamSuMik", "Toplam Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ1", "TuzMiktari", "Tuz Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ1", "AyranTuzOrani", "Ayran Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ1", "TopAyranYarMamulMik", "Top.Ayran.Yar.Mamul.Mik", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ2", "PastorizasyonSicak", "Pastörizasyon Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ2", "PastorizasyonSuresi", "Pastörizasyon Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ2", "SutVakum", "Süt Vakum", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ2", "MayalamaSaati", "Mayalama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ2", "MayalamaSicakligi", "Mayalama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ2", "SorumluPersonel", "Sorumlu Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ3", "PompaBasinci", "Pompa Basıncı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ3", "BaslamaSaati", "Başlama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ3", "BitisSaati", "Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ3", "ToplamGecenSure", "Toplam Geçen Süre", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ4", "KullanilanMik", "Kullanılan Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ4", "TedAdiVeKultKod", "Tedarikçi Adı ve Kultur Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ4", "LotNo", "Lot Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ5", "KullanilanMik", "Kullanılan Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ5", "TedAdiVeKultKod", "Tedarikçi Adı ve Kultur Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ5", "LotNo", "Lot Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ6", "TedarikciAdi", "Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ6", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ7", "YagliSutunKaynagi", "Yağlı Sütün Kaynağı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ7", "YagsizSutunKaynagi", "Yağsız Sütün Kaynağı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ7", "SutunKaynagi", "Sütün Kaynağı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ7", "SutTuru", "Süt Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ7", "Brix", "Briks", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ7", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ7", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ7", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "TKM", "TKM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "Tuz", "Tuz", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "Brix", "Briks", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ8", "TatKokuKivam", "Tat Koku Kıvam", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ9", "KontrolNo", "Kontrol No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ9", "Saat", "Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ9", "Sicaklik", "Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ9", "UrunSicakligi", "Ürün Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ9", "OdaSicakligi", "Oda Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ9", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ9", "KontrolEdenPers", "Kontrol Eden Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRPRSS_ANLZ9", "Sicaklik", "Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_AYRPRSS_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunGrubu", FormColumnDescription = "Ürün Grubu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ProsesBasSaat", FormColumnDescription = "Proses Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagliSutMik", FormColumnDescription = "Yağlı Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagsizSutMik", FormColumnDescription = "Yağsız Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamSuMik", FormColumnDescription = "Toplam Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TuzMiktari", FormColumnDescription = "Tuz Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AyranTuzOrani", FormColumnDescription = "Ayran Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TopAyranYarMamulMik", FormColumnDescription = "Top.Ayran.Yar.Mamul.Mik", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PastorizasyonSicak", FormColumnDescription = "Pastörizasyon Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastorizasyonSuresi", FormColumnDescription = "Pastörizasyon Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutVakum", FormColumnDescription = "Süt Vakum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSaati", FormColumnDescription = "Mayalama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSicakligi", FormColumnDescription = "Mayalama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SorumluPersonel", FormColumnDescription = "Sorumlu Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PompaBasinci", FormColumnDescription = "Pompa Basıncı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaslamaSaati", FormColumnDescription = "Başlama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BitisSaati", FormColumnDescription = "Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamGecenSure", FormColumnDescription = "Toplam Geçen Süre", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KullanilanMik", FormColumnDescription = "Kullanılan Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedAdiVeKultKod", FormColumnDescription = "Tedarikçi Adı ve Kultur Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LotNo", FormColumnDescription = "Lot Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ5";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KullanilanMik", FormColumnDescription = "Kullanılan Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedAdiVeKultKod", FormColumnDescription = "Tedarikçi Adı ve Kultur Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LotNo", FormColumnDescription = "Lot Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ6";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciAdi", FormColumnDescription = "Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "PartiNo", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ7";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        //fc.Add(new FormColumn { FormColumnAlias = "U_YagliSutunKaynagi", FormColumnDescription = "Yağlı Sütün Kaynağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_YagsizSutunKaynagi", FormColumnDescription = "Yağsız Sütün Kaynağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutunKaynagi", FormColumnDescription = "Sütün Kaynağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Brix", FormColumnDescription = "Briks", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ8";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TKM", FormColumnDescription = "TKM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Protein", FormColumnDescription = "Protein", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Tuz", FormColumnDescription = "Tuz", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Brix", FormColumnDescription = "Briks", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TatKokuKivam", FormColumnDescription = "Tat Koku Kıvam", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRPRSS_ANLZ9";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolNo", FormColumnDescription = "Kontrol No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Saat", FormColumnDescription = "Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunSicakligi", FormColumnDescription = "Ürün Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OdaSicakligi", FormColumnDescription = "Oda Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolEdenPers", FormColumnDescription = "Kontrol Eden Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sicaklik", FormColumnDescription = "Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_AYRPRSS_ANLZ", "AIF_AYRPRSS_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_AYRPRSS_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_YGRPRSS_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ", "Yoğurt Proses Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ1", "Proses Özellikleri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ2", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ3", "Proses Özellikleri-3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ4", "1.Kültür Bilgileri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ5", "2.Kültür Bilgileri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ6", "Sütün Özellikleri", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ7", "Yarı Mamül Kalite Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRPRSS_ANLZ8", "Inkübasyon Takip Öz.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ1", "UrunGrubu", "Ürün Grubu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ1", "InkubasyonOdaNo", "İnkübasyon Oda No", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ1", "ProsesBasSaat", "Proses Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ1", "YagliSutMik", "Yağlı Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ1", "YagsizSutMik", "Yağsız Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ1", "KremaMik", "Krema Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ2", "VakumBasSaat", "Vakum Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ2", "VakumBitSaat", "Vakum Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ2", "Brix", "Vakum Sonu Süt Brix", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ2", "PastorizasyonSicak", "Pastörizasyon Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ2", "PastorizasyonSure", "Pastörizasyon Suresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ2", "MayalamaSaati", "Mayalama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ2", "MayalamaPH", "Mayalama PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ2", "MayalamaSicakligi", "Mayalama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ3", "DolumBasSaat", "Dolum Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ3", "DolumBasPH", "Dolum Başlangıç PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ3", "DolumBasSicak", "Dolum Başlangıç Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ3", "DolumBitSaat", "Dolum Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ3", "DolumBitPH", "Dolum Bitiş PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ3", "DolumBitSicak", "Dolum Bitiş Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ3", "SorumluPersonel", "Sorumlu Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ3", "ToplamGecenSure", "Toplam Geçen Süre", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ4", "KullanilanMik", "Kullanılan Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ4", "TedAdiVeKultKod", "Tedarikçi Adı ve Kultur Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ4", "LotNo", "Lot Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ5", "KullanilanMik", "Kullanılan Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ5", "TedAdiVeKultKod", "Tedarikçi Adı ve Kultur Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ5", "LotNo", "Lot Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ6", "YagliSutunKaynagi", "Yağlı Sütün Kaynağı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ6", "YagsizSutunKaynagi", "Yağsız Sütün Kaynağı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ6", "Brix", "Briks", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ6", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ6", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ6", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ6", "SutTuru", "Süt Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ6", "SutunKaynagi", "Sütün Kaynağı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "TKM", "TKM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "Tuz", "Tuz", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "Brix", "Briks", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ7", "TatKokuKivam", "Tat Koku Kıvam", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ8", "KontrolNo", "Kontrol No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ8", "Saat", "Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ8", "Sicaklik", "Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ8", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_YGRPRSS_ANLZ8", "KontrolEdenPers", "Kontrol Eden Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_YGRPRSS_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_YGRPRSS_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunGrubu", FormColumnDescription = "Ürün Grubu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_InkubasyonOdaNo", FormColumnDescription = "İnkübasyon Oda No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ProsesBasSaat", FormColumnDescription = "Proses Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagliSutMik", FormColumnDescription = "Yağlı Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagsizSutMik", FormColumnDescription = "Yağsız Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaMik", FormColumnDescription = "Krema Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRPRSS_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_VakumBasSaat", FormColumnDescription = "Vakum Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_VakumBitSaat", FormColumnDescription = "Vakum Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Brix", FormColumnDescription = "Vakum Sonu Süt Brix", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastorizasyonSicak", FormColumnDescription = "Pastörizasyon Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastorizasyonSure", FormColumnDescription = "Pastörizasyon Suresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSaati", FormColumnDescription = "Mayalama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaPH", FormColumnDescription = "Mayalama PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSicakligi", FormColumnDescription = "Mayalama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRPRSS_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_DolumBasSaat", FormColumnDescription = "Dolum Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolumBasPH", FormColumnDescription = "Dolum Başlangıç PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolumBasSicak", FormColumnDescription = "Dolum Başlangıç Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolumBitSaat", FormColumnDescription = "Dolum Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolumBitPH", FormColumnDescription = "Dolum Bitiş PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolumBitSicak", FormColumnDescription = "Dolum Bitiş Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SorumluPersonel", FormColumnDescription = "Sorumlu Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamGecenSure", FormColumnDescription = "Toplam Geçen Süre", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRPRSS_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KullanilanMik", FormColumnDescription = "Kullanılan Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedAdiVeKultKod", FormColumnDescription = "Tedarikçi Adı ve Kultur Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LotNo", FormColumnDescription = "Lot Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRPRSS_ANLZ5";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KullanilanMik", FormColumnDescription = "Kullanılan Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedAdiVeKultKod", FormColumnDescription = "Tedarikçi Adı ve Kultur Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LotNo", FormColumnDescription = "Lot Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRPRSS_ANLZ6";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_YagliSutunKaynagi", FormColumnDescription = "Yağlı Sütün Kaynağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagsizSutunKaynagi", FormColumnDescription = "Yağsız Sütün Kaynağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Brix", FormColumnDescription = "Briks", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SutTuru", FormColumnDescription = "Süt Türü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutunKaynagi", FormColumnDescription = "Sütün Kaynağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRPRSS_ANLZ7";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TKM", FormColumnDescription = "TKM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Protein", FormColumnDescription = "Protein", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Tuz", FormColumnDescription = "Tuz", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Brix", FormColumnDescription = "Briks", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TatKokuKivam", FormColumnDescription = "Tat Koku Kıvam", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRPRSS_ANLZ8";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolNo", FormColumnDescription = "Kontrol No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Saat", FormColumnDescription = "Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sicaklik", FormColumnDescription = "Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolEdenPers", FormColumnDescription = "Kontrol Eden Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_YGRPRSS_ANLZ", "AIF_YGRPRSS_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_YGRPRSS_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_LORPRSS_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_LORPRSS_ANLZ", "Lor Proses Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_LORPRSS_ANLZ1", "Proses Özellikleri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_LORPRSS_ANLZ2", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_LORPRSS_ANLZ3", "Sarf Malzeme Kullanım", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_LORPRSS_ANLZ4", "Mamul Özellikleri1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_LORPRSS_ANLZ5", "Mamul Özellikleri2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ", "KalemTanimi", "Kalem Tanımı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "LorTuru", "Lor Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "OperatörAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);//kldrldı
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasGonderimBasSaat", "Pas Gönd. Baş.Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasGonderimBitSaat", "Pas Gönd. Bit.Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "NetPasMiktari", "Net Pas Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasPastSicak", "Pas Pastörizasyon Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "EsanjorTankFiltre", "Esanjör ve Tank Filtre Kont.", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasTankGelSicak", "Pasın Tanka Geliş Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasPH", "Pasın PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasinSeksenDereceSaati", "Pasın 80 Der.Gelme Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasSeksenSekizDerece", "Pas 88 Der.Gelme Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasinBosaltmaBasSaat", "Pasın Boşaltma Baş.Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "PasinBosaltmaBitSaat", "Pasın Boşaltma Bit.Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "BaskiBasSaat", "Baskı Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ1", "BaskiBitSaat", "Baskı Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ2", "PasGonderimSuresi", "Pas Gönderim Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ2", "PasSeksenSekizDerece", "Pas 88 Der.Gelme Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ2", "PeynirIndirilmeSuresi", "Peynirin İndirilme Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ2", "BaskiSuresi", "Baskı Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ2", "ToplamGecenSure", "Toplam Geçen Süre", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ3", "MalzemeAdi", "Malzeme Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ3", "MalMarkaTedarikci", "Malzeme Marka ve Tedarikçi", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ3", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ3", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ3", "Birim", "Birim", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ4", "UretilenMik", "Üretilen Lor Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ4", "UretimRandimani", "Üretim Randımanı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ4", "KontrolEdenPers", "Kontrol Eden Personel", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ5", "KuruMadde", "Kuru Madde", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ5", "YagOrani", "Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ5", "PH", "PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ5", "SH", "SH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ5", "TuzOrani", "Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_LORPRSS_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_KalemKodu", "Kalem Kodu");
                        fields.Add("U_KalemTanimi", "Kalem Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");

                        fields.Add("U_UretimTarihi", "Üretim Tarihi");


                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_LORPRSS_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LorTuru", FormColumnDescription = "Lor Türü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_OperatörAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasGonderimBasSaat", FormColumnDescription = "Pas Gönd. Baş.Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasGonderimBitSaat", FormColumnDescription = "Pas Gönd. Bit.Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NetPasMiktari", FormColumnDescription = "Net Pas Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasPastSicak", FormColumnDescription = "Pas Pastörizasyon Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EsanjorTankFiltre", FormColumnDescription = "Esanjör ve Tank Filtre Kont.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasTankGelSicak", FormColumnDescription = "Pasın Tanka Geliş Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasPH", FormColumnDescription = "Pasın PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasinSeksenDereceSaati", FormColumnDescription = "Pasın 80 Der.Gelme Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasSeksenSekizDerece", FormColumnDescription = "Pasın 80 Der.Gelme Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasinBosaltmaBasSaat", FormColumnDescription = "Pasın Boşaltma Baş.Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasinBosaltmaBitSaat", FormColumnDescription = "Pasın Boşaltma Bit.Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskiBasSaat", FormColumnDescription = "Baskı Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskiBitSaat", FormColumnDescription = "Baskı Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_LORPRSS_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PasGonderimSuresi", FormColumnDescription = "Pas Gönderim Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasSeksenSekizDerece", FormColumnDescription = "Pas 88 Der.Gelme Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PeynirIndirilmeSuresi", FormColumnDescription = "Peynirin İndirilme Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskiSuresi", FormColumnDescription = "Baskı Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamGecenSure", FormColumnDescription = "Toplam Geçen Süre", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_LORPRSS_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzemeAdi", FormColumnDescription = "Malzeme Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalMarkaTedarikci", FormColumnDescription = "Malzeme Marka ve Tedarikçi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Birim", FormColumnDescription = "Birim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_LORPRSS_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenMik", FormColumnDescription = "Üretilen Lor Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimRandimani", FormColumnDescription = "Üretim Randımanı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolEdenPers", FormColumnDescription = "Kontrol Eden Personel", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_LORPRSS_ANLZ5";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TuzOrani", FormColumnDescription = "Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_LORPRSS_ANLZ", "AIF_LORPRSS_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_LORPRSS_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_PASPRSS_ANLZ"))
                    {
                        TableCreation.CreateTable("AIF_PASPRSS_ANLZ", "Pastör. Proses Anlz Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_PASPRSS_ANLZ1", "Proses Özellikleri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_PASPRSS_ANLZ2", "Proses Özellikleri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_PASPRSS_ANLZ3", "Proses Özellikleri-3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_PASPRSS_ANLZ4", "Günlük Proses Özeti-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_PASPRSS_ANLZ5", "Günlük Proses Özeti-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ", "UretimSiparisNo", "Üretim Sipariş No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ", "UretilenUrunTanimi", "Üretilen Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_LORPRSS_ANLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "SutunAlinanTankAdi", "Sütün Alındığı Tank Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "AlinanSutunPartiNo", "Alınan Sütün Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "YagCekilecekSutMik", "Yağ Çekilecek Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "SutYagOrani", "Süt Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "SutunPh", "Sütün PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "KremaYogunlugu", "Krema Yoğunluğu", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "KremaPh", "Krema PH Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "KremaYagOrani", "Krema Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "CekilenKremaMikKG", "Çekilen Krema Miktarı KG", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "CekilenKremaMikLT", "Çekilen Krema Miktarı LT", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "KalanSutMik", "Kalan Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "YagAlnmsSutYagOr", "Yağı Alınmış Sütün Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "YagAlnmsSutPH", "Yağı Alınmış Sütün PH Değ.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ1", "SutunGondTankAdi", "Sütün Gönderildiği Tank Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "UretilenKremaParti", "Üretilen Kremanaın Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaPastBasSaat", "Krema Past.Baş.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaPastSicakligi", "Krema Past. Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaPastBitSaat", "Krema Pas.Bit.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaMayalamaSaati", "Krema Mayalama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaMayalamaSicak", "Krema Mayalama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaMayalamaPh", "Krema Mayalama PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "MayalamaKazanFiltTem", "Mayalama Kaz.Filt.Tem", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaDolumBasSaat", "Krema Dolum Baş.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaDolumBitSaat", "Krema Dolum Bit.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KremaDolumYapan", "Krema Dolum Yapan Pers.", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "DolumSicakligi", "Dolum Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "UretimYapan", "Üretimi Yapan Operatör", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ2", "KontrolEdenMuh", "Kontrol Eden Mühendis", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "UretilenKremaParti", "Üretilen Krema Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "KulKulturAdiVeKodu", "Kul.Kültür Adı Ve Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "KulturMiktari", "Kültür Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "UretilenKremaMik", "Üretilen Krema Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "KremaYagOrani", "Krema Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "DolumYapilanAmbalaj", "Dolum Yapılan Ambalaj", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "KulAmbalajMik", "Kullanılan Ambalaj Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "BirAmbOrtMiktar", "Bir Ambalaj Ort Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "KremaDepoPh", "Krema Depoya Atıldığında PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "KremaninDepoSicakligi", "Kremanın Depo Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "UretimYapan", "Üretimi Yapan Operatör", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ3", "KontrolEdenMuh", "Kontrol Eden Mühendis", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ4", "VeriAdi", "Veri Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ4", "Kova", "Kova", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ4", "Teneke", "Teneke", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ4", "ToplamveyaOrt", "Toplam veya Ortalama", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ5", "VeriAdi", "Veri Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_PASPRSS_ANLZ5", "Deger", "Değer", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_PASPRSS_ANLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UretimSiparisNo", "Üretim Sipariş No");
                        fields.Add("U_UretilenUrunTanimi", "Üretilen Ürün Tanımı");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_PASPRSS_ANLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SutunAlinanTankAdi", FormColumnDescription = "Sütün Alındığı Tank Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlinanSutunPartiNo", FormColumnDescription = "Alınan Sütün Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagCekilecekSutMik", FormColumnDescription = "Yağ Çekilecek Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutYagOrani", FormColumnDescription = "Süt Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutunPh", FormColumnDescription = "Sütün PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaYogunlugu", FormColumnDescription = "Krema Yoğunluğu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaYagOrani", FormColumnDescription = "Krema Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaPh", FormColumnDescription = "Krema PH Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CekilenKremaMikKG", FormColumnDescription = "Çekilen Krema Miktarı KG", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CekilenKremaMikLT", FormColumnDescription = "Çekilen Krema Miktarı LT", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KalanSutMik", FormColumnDescription = "Kalan Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagAlnmsSutYagOr", FormColumnDescription = "Yağı Alınmış Sütün Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SutunGondTankAdi", FormColumnDescription = "Sütün Gönderildiği Tank Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_PasinBosaltmaBasSaat", FormColumnDescription = "Sütün Gönderildiği Tank Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_PASPRSS_ANLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenKremaParti", FormColumnDescription = "Üretilen Kremanaın Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaPastBasSaat", FormColumnDescription = "Krema Past.Baş.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaPastSicakligi", FormColumnDescription = "Krema Past. Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaPastBitSaat", FormColumnDescription = "Krema Pas.Bit.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaMayalamaSaati", FormColumnDescription = "Krema Mayalama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaMayalamaSicak", FormColumnDescription = "Krema Mayalama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaMayalamaPh", FormColumnDescription = "Krema Mayalama PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaKazanFiltTem", FormColumnDescription = "Mayalama Kaz.Filt.Tem", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaDolumBasSaat", FormColumnDescription = "Krema Dolum Baş.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaDolumBitSaat", FormColumnDescription = "Krema Dolum Bit.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaDolumYapan", FormColumnDescription = "Krema Dolum Yapan Pers.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolumSicakligi", FormColumnDescription = "Dolum Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimYapan", FormColumnDescription = "Üretimi Yapan Operatör", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolEdenMuh", FormColumnDescription = "Kontrol Eden Mühendis", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_PASPRSS_ANLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenKremaParti", FormColumnDescription = "Üretilen Krema Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulKulturAdiVeKodu", FormColumnDescription = "Kul.Kültür Adı Ve Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulturMiktari", FormColumnDescription = "Kültür Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretilenKremaMik", FormColumnDescription = "Üretilen Krema Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaYagOrani", FormColumnDescription = "Krema Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolumYapilanAmbalaj", FormColumnDescription = "Dolum Yapılan Ambalaj", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulAmbalajMik", FormColumnDescription = "Kullanılan Ambalaj Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirAmbOrtMiktar", FormColumnDescription = "Bir Ambalaj Ort Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaDepoPh", FormColumnDescription = "Krema Depoya Atıldığında PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaninDepoSicakligi", FormColumnDescription = "Kremanın Depo Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimYapan", FormColumnDescription = "Üretimi Yapan Operatör", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolEdenMuh", FormColumnDescription = "Kontrol Eden Mühendis", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_PASPRSS_ANLZ4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_VeriAdi", FormColumnDescription = "Veri Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Kova", FormColumnDescription = "Kova", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Teneke", FormColumnDescription = "Teneke", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamveyaOrt", FormColumnDescription = "Toplam veya Ortalama", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_PASPRSS_ANLZ5";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_VeriAdi", FormColumnDescription = "Veri Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Deger", FormColumnDescription = "Değer", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_PASPRSS_ANLZ", "AIF_PASPRSS_ANLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_PASPRSS_ANLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("m"))
                    {
                        TableCreation.CreateTable("AIF_AYRNOZTTMYGL", "Tam Yağlı Ayran Üretim", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_AYRNOZTTMYGL1", "Paketleme Bilgileri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRNOZTTMYGL2", "Paketleme Bilgileri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRNOZTTMYGL3", "Gün Sonu Özeti", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL", "UretimVardiyasi", "Üretim Vardiyası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL1", "PaketAyranMikAd", "Paketlenen Ayran Mik.Ad.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL1", "PaketAyranMikLt", "Paketlenen Ayran Mik.Lt.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL2", "ToplamSutMik", "Toplam Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL2", "ToplamSuMik", "Toplam Su Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL2", "TuzMiktari", "Tuz Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL2", "AyranTuzOrani", "Ayran Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL2", "ToplamAyranMik", "Toplam Ayran Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL3", "MayalananAyranMik", "Mayalanan Ayran Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL3", "OncekiGundenDevMik", "Önceki Günden Devreden Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL3", "TanktakiToplamMik", "Tanktaki Toplam Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL3", "PaketTankFarki", "Paketlenen-Tank Fark Mik.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL3", "SonrakiGuneDevMik", "Sonraki Güne Devreden Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL3", "GunSonuAyranFarki", "Gün Sonu Ayran Farkı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL3", "StandartRandiman", "Standart Randıman Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTTMYGL3", "GerceklesenRandiman", "Gerçekleşen Randıman Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_AYRNOZTTMYGL"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_UretimVardiyasi", "Üretim Vardiyası");
                        fields.Add("U_Aciklama", "Açıklama");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_AYRNOZTTMYGL1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketAyranMikAd", FormColumnDescription = "Paketlenen Ayran Mik.Ad.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketAyranMikLt", FormColumnDescription = "Paketlenen Ayran Mik.Lt.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRNOZTTMYGL2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamSutMik", FormColumnDescription = "Toplam Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamSuMik", FormColumnDescription = "Toplam Su Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TuzMiktari", FormColumnDescription = "Tuz Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AyranTuzOrani", FormColumnDescription = "Ayran Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamAyranMik", FormColumnDescription = "Toplam Ayran Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRNOZTTMYGL3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalananAyranMik", FormColumnDescription = "Mayalanan Ayran Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OncekiGundenDevMik", FormColumnDescription = "Önceki Günden Devreden Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TanktakiToplamMik", FormColumnDescription = "Tanktaki Toplam Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketTankFarki", FormColumnDescription = "Paketlenen-Tank Fark Mik.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonrakiGuneDevMik", FormColumnDescription = "Sonraki Güne Devreden Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GunSonuAyranFarki", FormColumnDescription = "Gün Sonu Ayran Farkı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StandartRandiman", FormColumnDescription = "Standart Randıman Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GerceklesenRandiman", FormColumnDescription = "Gerçekleşen Randıman Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_AYRNOZTTMYGL", "AIF_AYRNOZTTMYGL", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_AYRNOZTTMYGL", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_AYRNOZTYRMYGL"))
                    {
                        TableCreation.CreateTable("AIF_AYRNOZTYRMYGL", "Yarım Yağlı Ayran Üretim", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_AYRNOZTYRMYGL1", "Paketleme Bilgileri-1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRNOZTYRMYGL2", "Paketleme Bilgileri-2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_AYRNOZTYRMYGL3", "Gün Sonu Özeti", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL", "UretimVardiyasi", "Üretim Vardiyası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL1", "PaketAyranMikAd", "Paketlenen Ayran Mik.Ad.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL1", "PaketAyranMikLt", "Paketlenen Ayran Mik.Lt.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL2", "ToplamSutMik", "Toplam Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL2", "ToplamSuMik", "Toplam Su Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL2", "TuzMiktari", "Tuz Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL2", "AyranTuzOrani", "Ayran Tuz Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL2", "ToplamAyranMik", "Toplam Ayran Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL3", "MayalananAyranMik", "Mayalanan Ayran Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL3", "OncekiGundenDevMik", "Önceki Günden Devreden Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL3", "TanktakiToplamMik", "Tanktaki Toplam Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL3", "PaketTankFarki", "Paketlenen-Tank Fark Mik.", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL3", "SonrakiGuneDevMik", "Sonraki Güne Devreden Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL3", "GunSonuAyranFarki", "Gün Sonu Ayran Farkı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL3", "StandartRandiman", "Standart Randıman Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRMYGL3", "GerceklesenRandiman", "Gerçekleşen Randıman Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_AYRNOZTYRMYGL"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_UretimVardiyasi", "Üretim Vardiyası");
                        fields.Add("U_Aciklama", "Açıklama");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_AYRNOZTYRMYGL1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketAyranMikAd", FormColumnDescription = "Paketlenen Ayran Mik.Ad.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketAyranMikLt", FormColumnDescription = "Paketlenen Ayran Mik.Lt.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRNOZTYRMYGL2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamSutMik", FormColumnDescription = "Toplam Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamSuMik", FormColumnDescription = "Toplam Su Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TuzMiktari", FormColumnDescription = "Tuz Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AyranTuzOrani", FormColumnDescription = "Ayran Tuz Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamAyranMik", FormColumnDescription = "Toplam Ayran Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_AYRNOZTYRMYGL3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalananAyranMik", FormColumnDescription = "Mayalanan Ayran Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OncekiGundenDevMik", FormColumnDescription = "Önceki Günden Devreden Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TanktakiToplamMik", FormColumnDescription = "Tanktaki Toplam Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketTankFarki", FormColumnDescription = "Paketlenen-Tank Fark Mik.", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonrakiGuneDevMik", FormColumnDescription = "Sonraki Güne Devreden Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GunSonuAyranFarki", FormColumnDescription = "Gün Sonu Ayran Farkı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StandartRandiman", FormColumnDescription = "Standart Randıman Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GerceklesenRandiman", FormColumnDescription = "Gerçekleşen Randıman Değeri", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_AYRNOZTYRMYGL", "AIF_AYRNOZTYRMYGL", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_AYRNOZTYRMYGL", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_AYRNOZTYRDMLZ"))
                    {
                        TableCreation.CreateTable("AIF_AYRNOZTYRDMLZ", "Yardımcı Malzeme Kontrolü", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_AYRNOZTYRDMLZ1", "Yardımcı Malz. Kont. Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ", "UretimVardiyasi", "Üretim Vardiyası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ1", "BardakTedAdi", "Bardak Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ1", "BardakPartiNo", "Bardak Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ1", "FolyoTedAdi", "Folyo Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ1", "FolyoPartiNo", "Folyo Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ1", "ViyolTedAdi", "Viyol Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNOZTYRDMLZ1", "ViyolPartiNo", "Viyol Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_AYRNOZTYRDMLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_UretimVardiyasi", "Üretim Vardiyası");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_AYRNOZTYRDMLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BardakTedAdi", FormColumnDescription = "Bardak Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BardakPartiNo", FormColumnDescription = "Bardak Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_FolyoTedAdi", FormColumnDescription = "Folyo Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_FolyoPartiNo", FormColumnDescription = "Folyo Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ViyolTedAdi", FormColumnDescription = "Viyol Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ViyolPartiNo", FormColumnDescription = "Viyol Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_AYRNOZTYRDMLZ", "AIF_AYRNOZTYRDMLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_AYRNOZTYRDMLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_AYRNPKTPRSS"))
                    {
                        TableCreation.CreateTable("AIF_AYRNPKTPRSS", "Paketlenen Ayranın Proses Öz.", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_AYRNPKTPRSS1", "Paketlenen Ay.Proses Öz. Dty", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS", "Tarih", "Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "KontrolNo", "Kontrol No", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "1", "Değer 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "2", "Değer 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "3", "Değer 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "4", "Değer 4", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "5", "Değer 5", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "6", "Değer 6", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "7", "Değer 7", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "8", "Değer 8", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "9", "Değer 9", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "10", "Değer 10", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "11", "Değer 11", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "12", "Değer 12", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "13", "Değer 13", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "14", "Değer 14", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "15", "Değer 15", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_AYRNPKTPRSS1", "16", "Değer 16", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_AYRNPKTPRSS"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Aciklama", "Açıklama");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_AYRNPKTPRSS1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KontrolNo", FormColumnDescription = "Kontrol No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_1", FormColumnDescription = "Değer 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_2", FormColumnDescription = "Değer 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_3", FormColumnDescription = "Değer 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_4", FormColumnDescription = "Değer 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_5", FormColumnDescription = "Değer 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_6", FormColumnDescription = "Değer 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_7", FormColumnDescription = "Değer 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_8", FormColumnDescription = "Değer 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_9", FormColumnDescription = "Değer 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_10", FormColumnDescription = "Değer 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_11", FormColumnDescription = "Değer 11", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_12", FormColumnDescription = "Değer 12", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_13", FormColumnDescription = "Değer 13", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_14", FormColumnDescription = "Değer 14", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_15", FormColumnDescription = "Değer 15", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_16", FormColumnDescription = "Değer 16", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_AYRNPKTPRSS", "AIF_AYRNPKTPRSS", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_AYRNPKTPRSS", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_YGRTYRDMLZ"))
                    {
                        TableCreation.CreateTable("AIF_YGRTYRDMLZ", "Yoğurt Yard.Malz.Kontrolü", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_YGRTYRDMLZ1", "Yoğurt Yard.Malz.Kont.Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRTYRDMLZ2", "Yoğurt Görevli Personel", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_YGRTYRDMLZ3", "Yoğurt Gramaj", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ1", "KovaKaseTedAdi", "Kova Kase Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ1", "KovaKasePartiNo", "Kova Kase Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ1", "KapakFolyoTedAdi", "Folyo Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ1", "KapakFolyoPartiNo", "Folyo Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ1", "ViyolTedAdi", "Viyol Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ1", "ViyolPartiNo", "Viyol Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ2", "Deger", "Değer", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ3", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_YGRTYRDMLZ3", "Deger", "Değer", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_YGRTYRDMLZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_UretimTarihi", "Üretim Tarihi");
                        fields.Add("U_Aciklama", "Açıklama");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_YGRTYRDMLZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KovaKaseTedAdi", FormColumnDescription = "Kova Kase Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KovaKasePartiNo", FormColumnDescription = "Kova Kase Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KapakFolyoTedAdi", FormColumnDescription = "Folyo Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KapakFolyoPartiNo", FormColumnDescription = "Folyo Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ViyolTedAdi", FormColumnDescription = "Viyol Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ViyolPartiNo", FormColumnDescription = "Viyol Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRTYRDMLZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Aciklama", FormColumnDescription = "Açıklama", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Deger", FormColumnDescription = "Değer", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_YGRTYRDMLZ3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Aciklama", FormColumnDescription = "Açıklama", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Deger", FormColumnDescription = "Değer", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_YGRTYRDMLZ", "AIF_YGRTYRDMLZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_YGRTYRDMLZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTPLANLAMA"))
                    {
                        TableCreation.CreateTable("AIF_SUTPLANLAMA", "Süt Planlama", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTPLANLAMA1", "Süt Planlama Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_SUTPLANLAMA2", "Süt Planlama Detay 2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA", "ToplamSutMiktari", "Toplam Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA1", "SaticiKodu", "Satıcı Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA1", "SaticiAdi", "Satıcı Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA2", "SaticiKodu", "Satıcı Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA2", "SaticiAdi", "Satıcı Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA2", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Quantity);
                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA2", "GelisSaati", "Geliş Saati", SAPbobsCOM.BoFieldTypes.db_Date, 10, SAPbobsCOM.BoFldSubTypes.st_Time);
                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA2", "Arac", "Araç", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTPLANLAMA2", "Sofor", "Şoför", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTPLANLAMA"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_ToplamSutMiktari", "Toplam Süt Miktarı");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTPLANLAMA1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SaticiKodu", FormColumnDescription = "Satıcı Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SaticiAdi", FormColumnDescription = "Satıcı Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_SUTPLANLAMA2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SaticiKodu", FormColumnDescription = "Satıcı Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SaticiAdi", FormColumnDescription = "Satıcı Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GelisSaati", FormColumnDescription = "Geliş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Arac", FormColumnDescription = "Araç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sofor", FormColumnDescription = "Şoför", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTPLANLAMA", "AIF_SUTPLANLAMA", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTPLANLAMA", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYI_PHCZ"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYI_PHCZ", "PH Ceza Başlık", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTIYI_PHCZ1", "PH Ceza Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ", "GecerlilikBas", "Geçerlilik Başlangıç", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ", "GecerlilikBit", "Geçerlilik Bitiş", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ", "SicaklikMin", "Sıcaklık Min", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ", "SicaklikMax", "Sıcaklık Max", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ", "Soda", "Soda", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ", "SodaDeger", "Soda Değeri", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ", "Nitelik", "Sütün Niteliği", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ1", "OranBas", "Oran Başlangıç", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ1", "OranBit", "Oran Bitiş", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_PHCZ1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYI_PHCZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_GecerlilikBas", "Geçerlilik Başlangıç");
                        fields.Add("U_GecerlilikBit", "Geçerlilik Bitiş");
                        fields.Add("U_SicaklikMin", "Sıcaklık Min");
                        fields.Add("U_SicaklikMax", "Sıcaklık Max");
                        fields.Add("U_Soda", "Soda");
                        fields.Add("U_SodaDeger", "Soda Değeri");
                        fields.Add("U_Nitelik", "Sütün Niteliği");
                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_PHCZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBas", FormColumnDescription = "Oran Başlangıç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBit", FormColumnDescription = "Oran Bitiş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTIYI_PHCZ", "AIF_SUTIYI_PHCZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYI_PHCZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYI_ANTCZ"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYI_ANTCZ", "Antibiyotik Ceza", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_ANTCZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_ANTCZ", "GecerlilikBas", "Geçerlilik Başlangıç", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_ANTCZ", "GecerlilikBit", "Geçerlilik Bitiş", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_ANTCZ", "Antibiyotikvar", "Antibiyotik var", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_ANTCZ", "Antibiyotikyok", "Antibiyotik yok", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_ANTCZ", "Nitelik", "Sütün Niteliği", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYI_ANTCZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_GecerlilikBas", "Geçerlilik Başlangıç");
                        fields.Add("U_GecerlilikBit", "Geçerlilik Bitiş");
                        fields.Add("U_Antibiyotikvar", "Antibiyotik var");
                        fields.Add("U_Antibiyotikyok", "Antibiyotik yok");
                        fields.Add("U_Nitelik", "Sütün Niteliği");

                        UdoCreation.RegisterUDOForDefaultForm("AIF_SUTIYI_ANTCZ", "AIF_SUTIYI_ANTCZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYI_ANTCZ");
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYI_TEMCZ"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYI_TEMCZ", "Temizlik Ceza", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTIYI_TEMCZ1", "Temizlik Ceza Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ", "GecerlilikBas", "Geçerlilik Başlangıç", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ", "GecerlilikBit", "Geçerlilik Bitiş", SAPbobsCOM.BoFieldTypes.db_Date);
                        //TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ", "Orta", "Orta", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ", "Kotu", "Kötü", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        //TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ", "CokKotu", "Çok Kötü", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ", "Nitelik", "Sütün Niteliği", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ", "AracTipi", "Araç Tipi", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: AracTipi);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ1", "PuanBas", "Puan Aralığı Başlangıç", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ1", "PuanBit", "Puan Aralığı Bitiş", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_TEMCZ1", "Ceza", "Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYI_TEMCZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_GecerlilikBas", "Geçerlilik Başlangıç");
                        fields.Add("U_GecerlilikBit", "Geçerlilik Bitiş");
                        fields.Add("U_AracTipi", "Araç Tipi");
                        fields.Add("U_Nitelik", "Sütün Niteliği");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_TEMCZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PuanBas", FormColumnDescription = "Puan Aralığı Başlangıç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PuanBit", FormColumnDescription = "Puan Aralığı Bitiş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ceza", FormColumnDescription = "Ceza", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTIYI_TEMCZ", "AIF_SUTIYI_TEMCZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYI_TEMCZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYI_BRIXCZ"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYI_BRIXCZ", "Brix Ceza Başlık", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTIYI_BRIXCZ1", "Brix Ceza Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXCZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXCZ", "GecerlilikBas", "Geçerlilik Başlangıç", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXCZ", "GecerlilikBit", "Geçerlilik Bitiş", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXCZ", "SutTuru", "Süt Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXCZ", "Nitelik", "Nitelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXCZ1", "OranBas", "Oran Başlangıç", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXCZ1", "OranBit", "Oran Bitiş", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXCZ1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYI_BRIXCZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_GecerlilikBas", "Geçerlilik Başlangıç");
                        fields.Add("U_GecerlilikBit", "Geçerlilik Bitiş");
                        fields.Add("U_SutTuru", "Süt Türü");
                        fields.Add("U_Nitelik", "Nitelik");
                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_BRIXCZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBas", FormColumnDescription = "Oran Başlangıç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBit", FormColumnDescription = "Oran Bitiş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTIYI_BRIXCZ", "AIF_SUTIYI_BRIXCZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYI_BRIXCZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYI_BRIXPR"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYI_BRIXPR", "Brix Prim Başlık", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTIYI_BRIXPR1", "Brix Prim Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXPR", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXPR", "GecerlilikBas", "Geçerlilik Başlangıç", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXPR", "GecerlilikBit", "Geçerlilik Bitiş", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXPR", "SutTuru", "Süt Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXPR", "Nitelik", "Nitelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXPR1", "OranBas", "Oran Başlangıç", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXPR1", "OranBit", "Oran Bitiş", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_BRIXPR1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYI_BRIXPR"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_GecerlilikBas", "Geçerlilik Başlangıç");
                        fields.Add("U_GecerlilikBit", "Geçerlilik Bitiş");
                        fields.Add("U_SutTuru", "Süt Türü");
                        fields.Add("U_Nitelik", "Nitelik");
                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_BRIXPR1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBas", FormColumnDescription = "Oran Başlangıç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBit", FormColumnDescription = "Oran Bitiş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTIYI_BRIXPR", "AIF_SUTIYI_BRIXPR", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYI_BRIXPR", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYI_YAGCZ"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYI_YAGCZ", "Yağ Ceza", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTIYI_YAGCZ1", "Yağ Ceza Tedarikçiler", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_SUTIYI_YAGCZ2", "Yağ Ceza Oranlar", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ", "GecerlilikBas", "Geçerlilik Başlangıç", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ", "GecerlilikBit", "Geçerlilik Bitiş", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ", "Nitelik", "Nitelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ1", "TedarikciKodu", "Tedarikçi Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ1", "TedarikciAdi", "Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ2", "OranBas", "Oran Başlangıç", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ2", "OranBit", "Oran Bitiş", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGCZ2", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYI_YAGCZ"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_GecerlilikBas", "Geçerlilik Başlangıç");
                        fields.Add("U_GecerlilikBit", "Geçerlilik Bitiş");
                        fields.Add("U_Nitelik", "Nitelik");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_YAGCZ1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciKodu", FormColumnDescription = "Tedarikçi Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciAdi", FormColumnDescription = "Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_YAGCZ2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBas", FormColumnDescription = "Oran Başlangıç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBit", FormColumnDescription = "Oran Bitiş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTIYI_YAGCZ", "AIF_SUTIYI_YAGCZ", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYI_YAGCZ", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYI_YAGPR"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYI_YAGPR", "Yağ Prim", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTIYI_YAGPR1", "Yağ Prim Tedarikçiler", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_SUTIYI_YAGPR2", "Yağ Prim Oranlar", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR", "GecerlilikBas", "Geçerlilik Başlangıç", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR", "GecerlilikBit", "Geçerlilik Bitiş", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR", "Nitelik", "Nitelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR1", "TedarikciKodu", "Tedarikçi Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR1", "TedarikciAdi", "Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR2", "OranBas", "Oran Başlangıç", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR2", "OranBit", "Oran Bitiş", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_YAGPR2", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYI_YAGPR"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_GecerlilikBas", "Geçerlilik Başlangıç");
                        fields.Add("U_GecerlilikBit", "Geçerlilik Bitiş");
                        fields.Add("U_Nitelik", "Nitelik");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_YAGPR1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciKodu", FormColumnDescription = "Tedarikçi Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciAdi", FormColumnDescription = "Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_YAGPR2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBas", FormColumnDescription = "Oran Başlangıç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBit", FormColumnDescription = "Oran Bitiş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTIYI_YAGPR", "AIF_SUTIYI_YAGPR", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYI_YAGPR", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYI_SODA"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYI_SODA", "Soda Ceza Başlık", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTIYI_SODA1", "Soda Ceza Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_SODA", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_SODA", "GecerlilikBas", "Geçerlilik Başlangıç", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_SODA", "GecerlilikBit", "Geçerlilik Bitiş", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_SODA", "SutTuru", "Süt Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_SODA", "Nitelik", "Nitelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYI_SODA1", "OranBas", "Oran Başlangıç", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_SODA1", "OranBit", "Oran Bitiş", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYI_SODA1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYI_SODA"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_GecerlilikBas", "Geçerlilik Başlangıç");
                        fields.Add("U_GecerlilikBit", "Geçerlilik Bitiş");
                        fields.Add("U_SutTuru", "Süt Türü");
                        fields.Add("U_Nitelik", "Nitelik");
                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYI_SODA1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBas", FormColumnDescription = "Oran Başlangıç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OranBit", FormColumnDescription = "Oran Bitiş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTIYI_SODA", "AIF_SUTIYI_SODA", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYI_SODA", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SUTIYLSTR"))
                    {
                        TableCreation.CreateTable("AIF_SUTIYLSTR", "Süt İyileştirme", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SUTIYLSTR1", "Süt İyileştirme Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR", "Ay", "Ay", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR", "Yil", "Yıl", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "TedarikciAdi", "Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "TedarikciKodu", "Tedarikçi Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "Nitelik", "Nitelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "Sicaklik", "Sıcaklık", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "Brix", "Brix", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "YogurtPL", "Yoğurt PL", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "KaynatSH", "Kaynat PH", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "Laktoz", "Lakoz", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "KatilanSu", "Katılan Su", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "Somatik", "Somatik", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "MetilenMavisi", "Metilen Mavisi", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "DonmaNoktasi", "Donma Noktası", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "TKM", "TKM", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "YKM", "YKM", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "AntibiyotikCeza", "Antibiyotik Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "SodaCeza", "Soda Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "TemizlikCeza", "Temizlik Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "AgirlikPuan", "Ağırlık Puan", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "YagCeza", "Yağ Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "BrixCeza", "Brix Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "SuCeza", "Su Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "AsitCeza", "Asit Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "YagPrim", "Yağ Prim", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "BrixPrim", "Brix Prim", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "ToplamCeza", "Toplam Ceza", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "ToplamPrim", "Toplam Prim", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "IyilestirmeOncesiMik", "İyileştirme Öncesi Net Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "Deger", "Değer", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SUTIYLSTR1", "IyilestirmeSonrasiMik", "İyileştirme Sonrası Net Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SUTIYLSTR"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Ay", "Ay");
                        fields.Add("U_Yil", "Yıl");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SUTIYLSTR1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciAdi", FormColumnDescription = "Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciKodu", FormColumnDescription = "Tedarikçi Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Nitelik", FormColumnDescription = "Nitelik", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sicaklik", FormColumnDescription = "Sıcaklık", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Brix", FormColumnDescription = "Brix", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YogurtPL", FormColumnDescription = "Yoğurt PL", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KaynatSH", FormColumnDescription = "Kaynat SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Protein", FormColumnDescription = "Protein", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Laktoz", FormColumnDescription = "Laktoz", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KatilanSu", FormColumnDescription = "Katılan Su", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Somatik", FormColumnDescription = "Somatik", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MetilenMavisi", FormColumnDescription = "Metilen Mavisi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DonmaNoktasi", FormColumnDescription = "Donma Noktası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TKM", FormColumnDescription = "TKM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YKM", FormColumnDescription = "YKM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AntibiyotikCeza", FormColumnDescription = "Antibiyotik Ceza", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SodaCeza", FormColumnDescription = "Soda Ceza", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AgirlikPuan", FormColumnDescription = "Ağırlık Puan", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagCeza", FormColumnDescription = "Yağ Ceza", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BrixCeza", FormColumnDescription = "Brix Ceza", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SuCeza", FormColumnDescription = "Su Ceza", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AsitCeza", FormColumnDescription = "Asit Ceza", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagPrim", FormColumnDescription = "Yağ Prim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BrixPrim", FormColumnDescription = "Brix Prim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamCeza", FormColumnDescription = "Toplam Ceza", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamPrim", FormColumnDescription = "Toplam Prim", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IyilestirmeOncesiMik", FormColumnDescription = "İyileştirme Öncesi Net Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Deger", FormColumnDescription = "Değer", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IyilestirmeSonrasiMik", FormColumnDescription = "İyileştirme Sonrası Net Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SUTIYLSTR", "AIF_SUTIYLSTR", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SUTIYLSTR", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_COMMARCH"))
                    {
                        TableCreation.CreateTable("AIF_COMMARCH", "Commarch Verileri", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_COMMARCH1", "Commarch Verileri Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_COMMARCH", "MusteriKodu", "Müşteri Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_COMMARCH", "MusteriTanimi", "Müşteri Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_COMMARCH", "TaslakOlustur", "Taslak Oluştur", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_COMMARCH1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_COMMARCH1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_COMMARCH1", "Carpan", "Çarpan", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_COMMARCH"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_MusteriKodu", "Müşteri Kodu");
                        fields.Add("U_MusteriTanimi", "Müşteri Tanımı");
                        fields.Add("U_TaslakOlustur", "Taslak Oluştur");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_COMMARCH1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunTanimi", FormColumnDescription = "Ürün Tanımı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Carpan", FormColumnDescription = "Çarpan", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_COMMARCH", "AIF_COMMARCH", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_COMMARCH", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_INDIRIMLER"))
                    {
                        TableCreation.CreateTable("AIF_INDIRIMLER", "İndirimler", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_INDIRIMLER1", "İndirimler Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        //TableCreation.CreateTable("AIF_INDIRIMLER2", "İndirimler Bölge", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_INDIRIMLER2", "İndirimler Müşteriler", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "Bolge", "Bölge seçimi", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "Musteri", "Müşteri seçimi", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "Baslangic", "Başlangıç Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "Bitis", "Bitiş Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "Oncelik", "Öncelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: Oncelik);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "IndirimTipi", "İndirim Tipi", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: IndirimTipi);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "Durum", "Durum", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: etkinEtkinDegil);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER", "FiyatListesi", "Fiyat Listesi", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "BirinciIsk", "Birinci İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "IkinciIsk", "Ikinci İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "UcuncuIsk", "Üçüncü İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "DorduncuIsk", "Dördüncü İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "BesinciIsk", "Beşinci İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "ToplamIsk", "Toplam İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "BirimFiyat", "Birim Fiyat", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER1", "Fiyat", "Fiyat", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);

                        //TableCreation.CreateUserFields("@AIF_INDIRIMLER2", "BolgeKodu", "Bölge Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        //TableCreation.CreateUserFields("@AIF_INDIRIMLER2", "BolgeAdi", "Bölge Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_INDIRIMLER2", "MusteriKodu", "Müşteri Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_INDIRIMLER2", "MusteriAdi", "Müşteri Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_INDIRIMLER"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_Bolge", "Bölge seçimi");
                        fields.Add("U_Musteri", "Müşteri seçimi");
                        fields.Add("U_Baslangic", "Başlangıç Tarihi");
                        fields.Add("U_Bitis", "Bitiş Tarihi");
                        fields.Add("U_Oncelik", "Öncelik");
                        fields.Add("U_IndirimTipi", "İndirim Tipi");
                        fields.Add("U_Durum", "Durum");

                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_FiyatListesi", "Fiyat Listesi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_INDIRIMLER1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunTanimi", FormColumnDescription = "Ürün Tanımı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirinciIsk", FormColumnDescription = "Birinci İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IkinciIsk", FormColumnDescription = "İkinci İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UcuncuIsk", FormColumnDescription = "Üçüncü İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DorduncuIsk", FormColumnDescription = "Dördüncü İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BesinciIsk", FormColumnDescription = "Beşinci İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamIsk", FormColumnDescription = "Toplam İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_BirimFiyat", FormColumnDescription = "Birim Fiyat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Fiyat", FormColumnDescription = "Fiyat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        //fc = new List<FormColumn>();
                        //ch = new ChildTable();
                        //ch.TableName = "AIF_INDIRIMLER2";

                        //fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        //fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        //fc.Add(new FormColumn { FormColumnAlias = "U_BolgeKodu", FormColumnDescription = "Bölge Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        //fc.Add(new FormColumn { FormColumnAlias = "U_BolgeAdi", FormColumnDescription = "Bölge Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        //ch.FormColumn = fc;
                        //chList.Add(ch);

                        fc = new List<FormColumn>();
                        ch = new ChildTable();
                        ch.TableName = "AIF_INDIRIMLER2";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MusteriKodu", FormColumnDescription = "Müşteri Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MusteriAdi", FormColumnDescription = "Müşteri Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_INDIRIMLER", "İndirimler", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_INDIRIMLER", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_SATINALMAISK"))
                    {
                        TableCreation.CreateTable("AIF_SATINALMAISK", "SATINALMAISK", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_SATINALMAISK1", "SATINALMAISK Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_SATINALMAISK", "SaticiKodu", "Satıcı Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK", "SaticiTanimi", "Satıcı Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK", "BaslangicTarihi", "Geçerlilik Baş.Tar.", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK", "BitisTarihi", "Gerçelilik Bit.Tar.", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK", "Durum", "Durum", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: etkinEtkinDegil);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK", "FiyatListesi", "Fiyat Listesi", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "MiktarOlcegi", "Miktar Ölçeği", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "BirinciIsk", "Birinci İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "IkinciIsk", "Ikinci İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "UcuncuIsk", "Üçüncü İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "DorduncuIsk", "Dördüncü İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "BesinciIsk", "Beşinci İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "ToplamIsk", "Toplam İskonto", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "BirimFiyat", "Birim Fiyat", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_SATINALMAISK1", "Fiyat", "Fiyat", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    }

                    if (!UdoCreation.UDOExists("AIF_SATINALMAISK"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_SaticiKodu", "Satıcı Kodu");
                        fields.Add("U_SaticiTanimi", "Satıcı Tanımı");
                        fields.Add("U_BaslangicTarihi", "Geçerlilik Baş.Tar.");
                        fields.Add("U_BitisTarihi", "Geçerlilik Bit.Tar.");
                        fields.Add("U_Durum", "Durum");
                        fields.Add("U_FiyatListesi", "Fiyat Listesi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_SATINALMAISK1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunTanimi", FormColumnDescription = "Ürün Tanımı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MiktarOlcegi", FormColumnDescription = "Miktar Ölçeği", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirinciIsk", FormColumnDescription = "Birinci İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IkinciIsk", FormColumnDescription = "İkinci İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UcuncuIsk", FormColumnDescription = "Üçüncü İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DorduncuIsk", FormColumnDescription = "Dördüncü İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BesinciIsk", FormColumnDescription = "Beşinci İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamIsk", FormColumnDescription = "Toplam İskonto", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirimFiyat", FormColumnDescription = "Birim Fiyat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Fiyat", FormColumnDescription = "Fiyat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_SATINALMAISK", "AIF_SATINALMAISK", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_SATINALMAISK", "", chList: chList);
                    }

                    #region otat excel de yok.kapatıldı 20211229
                    //if (!TableCreation.TableExists("AIF_BNKENKTAKS"))
                    //{
                    //    TableCreation.CreateTable("AIF_BNKENKTAKS", "NakitAkis", SAPbobsCOM.BoUTBTableType.bott_NoObject);
                    //}

                    #endregion
                    if (!TableCreation.TableExists("AIF_DOLAPTAYIN"))
                    {
                        TableCreation.CreateTable("AIF_DOLAPTAYIN", "Dolap Tayin", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_DOLAPTAYIN1", "Dolap Tayin Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_DOLAPTAYIN", "KalemKodu", "Kalem Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_DOLAPTAYIN1", "MuhatapKodu", "Muhatap Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_DOLAPTAYIN1", "MuhatapAdi", "Muhatap Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_DOLAPTAYIN1", "Lokasyon", "Lokasyon", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_DOLAPTAYIN1", "BaslaTar", "Baslangıç Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_DOLAPTAYIN1", "BitisTar", "Bitiş Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                    }

                    if (!UdoCreation.UDOExists("AIF_DOLAPTAYIN"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_KalemKodu", "Kalem Kodu");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_DOLAPTAYIN1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_MuhatapKodu", FormColumnDescription = "Muhatap Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MuhatapAdi", FormColumnDescription = "Muhatap Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Lokasyon", FormColumnDescription = "Lokasyon", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaslaTar", FormColumnDescription = "Baslangıç Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BitisTar", FormColumnDescription = "Bitiş Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_DOLAPTAYIN", "AIF_DOLAPTAYIN", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_DOLAPTAYIN", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_ANALIZGIRIS"))
                    {
                        TableCreation.CreateTable("AIF_ANALIZGIRIS", "AnalizGirişi", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_ANALIZGIRIS1", "AnalizGirişi Kimyasal", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_ANALIZGIRIS2", "AnalizGirişi Duyusal", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_ANALIZGIRIS3", "AnalizGirişi Mikrobiy.", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 200, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "Dara", "Dara", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "Ornek", "Örnek", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "SonTartim", "Son Tartım", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "Tkm", "TKM (E)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "Brix", "Brix", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "IlkYag", "İlk Yağ (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "Protein", "Protein", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "Tuz", "Tuz (%)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS1", "AnalizYapan", "Analiz Yapan Kişi", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "PanelistAdi", "Panelist Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "TatLezzet", "Tat ve Lezzet", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "Koku", "Koku", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "RenkGorunus", "Renk ve Görünüş", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "AgizHissi", "Ağız Hissi", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "YapiKivam", "Yapı ve Kıvam", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "Dilimlenme", "Dilimlenme", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "Uzama", "Uzama", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "Yanma", "Yanma", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "Erime", "Erime", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "TortuOlusumu", "Tortu Oluşumu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "EritilKoku", "Eriğildiğindeki Koku", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS2", "Yorum", "Yorum", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "AnalizTarihi", "Analiz Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "SonTukTarihi", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "NumuneCinsi", "Numune Cinsi", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "NumuneAdi", "Numune Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "Coliform", "Coliform", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "E_Coli", "E.Coli", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "GramNgtf", "Gram Negatif", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "Maya", "Maya", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "ToplamCanli", "Toplam Canlı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "YuzeyMaya", "Yüzey Maya", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "Kuf", "Küf", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "KacMl", "Kaç Ml", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_ANALIZGIRIS3", "SeyreltFaktor", "Seyreltme Faktörü", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_ANALIZGIRIS"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunAdi", "Ürün Adı");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_ANALIZGIRIS1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTarihi", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Dara", FormColumnDescription = "Dara", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek", FormColumnDescription = "Örnek", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonTartim", FormColumnDescription = "Son Tartım", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Tkm", FormColumnDescription = "TKM (E)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Brix", FormColumnDescription = "Brix", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IlkYag", FormColumnDescription = "İlk Yağ (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Protein", FormColumnDescription = "Protein", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Tuz", FormColumnDescription = "Tuz (%)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnalizYapan", FormColumnDescription = "Analiz Yapan Kişi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_ANALIZGIRIS2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTarihi", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PanelistAdi", FormColumnDescription = "Panelist Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TatLezzet", FormColumnDescription = "Tat ve Lezzet", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Koku", FormColumnDescription = "Koku", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_RenkGorunus", FormColumnDescription = "Renk ve Görünüş", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AgizHissi", FormColumnDescription = "Ağız Hissi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YapiKivam", FormColumnDescription = "Yapı ve Kıvam", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Dilimlenme", FormColumnDescription = "Dilimlenme", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Uzama", FormColumnDescription = "Uzama", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yanma", FormColumnDescription = "Yanma", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Erime", FormColumnDescription = "Erime", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TortuOlusumu", FormColumnDescription = "Tortu Oluşumu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EritilKoku", FormColumnDescription = "Eriğildiğindeki Koku", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yorum", FormColumnDescription = "Yorum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_ANALIZGIRIS3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnalizTarihi", FormColumnDescription = "Analiz Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTarihi", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTarihi", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NumuneCinsi", FormColumnDescription = "Numune Cinsi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_NumuneAdi", FormColumnDescription = "Numune Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Coliform", FormColumnDescription = "Coliform", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_E_Coli", FormColumnDescription = "E.Coli", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GramNgtf", FormColumnDescription = "Gram Negatif", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Maya", FormColumnDescription = "Maya", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamCanli", FormColumnDescription = "Toplam Canlı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YuzeyMaya", FormColumnDescription = "Yüzey Maya", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Kuf", FormColumnDescription = "Küf", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KacMl", FormColumnDescription = "Kaç Ml", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SeyreltFaktor", FormColumnDescription = "Seyreltme Faktörü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_ANALIZGIRIS", "Analiz Girişi", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_ANALIZGIRIS", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_GIRDIKONTROL"))
                    {
                        TableCreation.CreateTable("AIF_GIRDIKONTROL", "GirdiKontrolFormu", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_GIRDIKONTROL1", "GirdiKontrolFormuDetay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL", "GercekSipNo", "Gerçek Satınalma Sipariş Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL", "TaslakSipNo", "Taslak Satınalma Sipariş Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL", "BelgeTipi", "Belge Tipi", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: BelgeTipi);

                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "GirdiKodu", "Girdi Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "GirdiAdi", "Girdi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "TedarikciKodu", "Tedarikçi Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "TedarikciAdi", "Tedarikçi Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "IrsaliyeNo", "İrsaliye Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "UretimTarihi", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "SonKulTarihi", "Son Kullanma Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "DepoKodu", "Depo Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "DepoAdi", "Depo Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "Irsaliye", "İrsaliye (Gör.Knt)", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: GorselKontroller);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "AmbljTmzlk", "Ambalaj Temizliği (Gör.Knt)", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: GorselKontroller);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "Etiketleme", "Etiketleme (Gör.Knt)", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: GorselKontroller);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "AracUygun", "Araç Uygunluğu (Gör.Knt)", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: GorselKontroller);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "KaliteKnt", "Kalite Kontrolü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None, clist: KaliteKontrolu);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "LabSonuc", "Laboratuvar Sonucu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: GorselKontroller);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "MalzKabul", "Malzeme Kabul", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: MalzemeKabul);
                        TableCreation.CreateUserFields("@AIF_GIRDIKONTROL1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_GIRDIKONTROL"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_GercekSipNo", "Gerçek Satınalma Sipariş Numarası");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_TaslakSipNo", "Taslak Satınalma Sipariş Numarası");
                        fields.Add("U_BelgeTipi", "Belge Tipi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_GIRDIKONTROL1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_GirdiKodu", FormColumnDescription = "Girdi Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GirdiAdi", FormColumnDescription = "Girdi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciKodu", FormColumnDescription = "Tedarikçi Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TedarikciAdi", FormColumnDescription = "Tedarikçi Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IrsaliyeNo", FormColumnDescription = "İrsaliye Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTarihi", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonKulTarihi", FormColumnDescription = "Son Kullanma Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DepoKodu", FormColumnDescription = "Depo Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DepoAdi", FormColumnDescription = "Depo Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Irsaliye", FormColumnDescription = "İrsaliye (Gör.Knt)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AmbljTmzlk", FormColumnDescription = "Ambalaj Temizliği (Gör.Knt)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Etiketleme", FormColumnDescription = "Etiketleme (Gör.Knt)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AracUygun", FormColumnDescription = "Araç Uygunluğu (Gör.Knt)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KaliteKnt", FormColumnDescription = "Kalite Kontrolü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabSonuc", FormColumnDescription = "Laboratuvar Sonucu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MalzKabul", FormColumnDescription = "Malzeme Kabul", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Aciklama", FormColumnDescription = "Açıklama", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_GIRDIKONTROL", "GirdiKontrolFormu", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_GIRDIKONTROL", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_URUNIADE"))
                    {
                        TableCreation.CreateTable("AIF_URUNIADE", "Ürün İade", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_URUNIADE1", "Ürün İade Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_URUNIADE", "IadeBelgeNo", "İade Belge Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "IadeGlsTar", "İade Geliş Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "IadeBlgTar", "İade Belge Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "CariKodu", "Cari Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "CariAdi", "Cari Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "CariDetay", "Cari Detayı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "UrunGrubu", "Ürün Grubu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "UretimTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "SonKulTar", "Son Kullanma Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "DepoKodu", "Depo Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "DepoAdi", "Depo Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "IadeAdet", "İade (Adet)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "BirimKg", "Birim (Kg)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "IadeKg", "İade (Kg)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "IadeGrubu", "İade Grubu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "IadeNeden", "İade Nedeni", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_URUNIADE1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_URUNIADE"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_IadeBelgeNo", "İade Belge Numarası");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_URUNIADE1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_IadeGlsTar", FormColumnDescription = "İade Geliş Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IadeBlgTar", FormColumnDescription = "İade Belge Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CariKodu", FormColumnDescription = "Cari Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CariAdi", FormColumnDescription = "Cari Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CariDetay", FormColumnDescription = "Cari Detayı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunGrubu", FormColumnDescription = "Ürün Grubu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonKulTar", FormColumnDescription = "Son Kullanma Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DepoKodu", FormColumnDescription = "Depo Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DepoAdi", FormColumnDescription = "Depo Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IadeAdet", FormColumnDescription = "İade (Adet)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirimKg", FormColumnDescription = "Birim (Kg)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IadeKg", FormColumnDescription = "İade (Kg)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IadeGrubu", FormColumnDescription = "İade Grubu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IadeNeden", FormColumnDescription = "İade Nedeni", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Aciklama", FormColumnDescription = "Açıklama", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_URUNIADE", "Ürün İade", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_URUNIADE", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_UYGUNSUZURUN"))
                    {
                        TableCreation.CreateTable("AIF_UYGUNSUZURUN", "Uygunsuz Ürünler", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_UYGUNSUZURUN1", "Uygunsuz Ürünler Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_UYGUNSUZURUN2", "Uygunsuz Ürünler Ekler", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN", "BslngcTarihi", "Başlangıç Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN", "BitisTarihi", "Bitiş Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "DofTarihi", "Döf Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "BolumSorId", "Bölüm Sorumlusu Id", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "BolumSrmlu", "Bölüm Sorumlusu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "UrunGrubu", "Ürün Grubu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "Adet", "Adet", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "UygnszNdn", "Uygunsuzluk Nedeni", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "UygnszAcik", "Uygunsuzluk Açıklaması", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "Sonuc", "Sonuç", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None, clist: KaliteSonuc);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN1", "SerDurumu", "Şer Durumu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: SerDurumu);

                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN2", "KaynakYol", "Kaynak Yol", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN2", "HedefYol", "Hedef Yol", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN2", "DosyaAdi", "Dosya Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN2", "EklenmeTrh", "Eklenme Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_UYGUNSUZURUN2", "Aciklama", "Açıklaması", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_UYGUNSUZURUN"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_BslngcTarihi", "Başlangıç Tarihi");
                        fields.Add("U_BitisTarihi", "Bitiş Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_UYGUNSUZURUN1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_DofTarihi", FormColumnDescription = "Döf Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BolumSorId", FormColumnDescription = "Bölüm Sorumlusu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BolumSrmlu", FormColumnDescription = "Bölüm Sorumlusu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunGrubu", FormColumnDescription = "Ürün Grubu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Adet", FormColumnDescription = "Adet", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UygnszNdn", FormColumnDescription = "Uygunsuzluk Nedeni", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UygnszAcik", FormColumnDescription = "Uygunsuzluk Açıklaması", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sonuc", FormColumnDescription = "Sonuç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SerDurumu", FormColumnDescription = "Şer Durumu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_UYGUNSUZURUN2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KaynakYol", FormColumnDescription = "Kaynak Yol", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HedefYol", FormColumnDescription = "Hedef Yol", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DosyaAdi", FormColumnDescription = "Dosya Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EklenmeTrh", FormColumnDescription = "Eklenme Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Aciklama", FormColumnDescription = "Açıklaması", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_UYGUNSUZURUN", "Uygunsuz Ürünler", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_UYGUNSUZURUN", "", chList: chList);
                    }

                    if (!TableCreation.TableExists("AIF_MUSTERISIKAYET"))
                    {
                        TableCreation.CreateTable("AIF_MUSTERISIKAYET", "Müşteri Şikayetleri", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_MUSTERISIKAYET1", "Müşteri Şikayetleri Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_MUSTERISIKAYET2", "Müşteri Şikayetleri Ekler", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET", "BslngcTarihi", "Başlangıç Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET", "BitisTarihi", "Bitiş Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "SikayetTar", "Şikayet Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "CariKodu", "Cari Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "CariAdi", "Cari Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "CariDetay", "Cari Detayı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "UrunGrubu", "Ürün Grubu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "UretimTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "SonKulTar", "Son Kullanma Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "Adet", "Adet", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "BirimKg", "Birim (Kg)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "IadeKg", "İade (Kg)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "SikayetGrb", "Şikayet Grubu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "SikayetNdn", "Şikayet Nedeni", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Alpha, 250, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET1", "Sonuc", "Sonuç", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None, clist: KaliteSonuc);

                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET2", "KaynakYol", "Kaynak Yol", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET2", "HedefYol", "Hedef Yol", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET2", "DosyaAdi", "Dosya Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET2", "EklenmeTrh", "Eklenme Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_MUSTERISIKAYET2", "Aciklama", "Açıklaması", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                    }

                    if (!UdoCreation.UDOExists("AIF_MUSTERISIKAYET"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_BslngcTarihi", "Başlangıç Tarihi");
                        fields.Add("U_BitisTarihi", "Bitiş Tarihi");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_MUSTERISIKAYET1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_SikayetTar", FormColumnDescription = "Şikayet Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CariKodu", FormColumnDescription = "Cari Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CariAdi", FormColumnDescription = "Cari Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CariDetay", FormColumnDescription = "Cari Detayı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunGrubu", FormColumnDescription = "Ürün Grubu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonKulTar", FormColumnDescription = "Son Kullanma Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Adet", FormColumnDescription = "Adet", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirimKg", FormColumnDescription = "Birim Kg", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IadeKg", FormColumnDescription = "İade Kg", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SikayetGrb", FormColumnDescription = "Şikayet Grubu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SikayetNdn", FormColumnDescription = "Şikayet Nedeni", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Aciklama", FormColumnDescription = "Açıklama", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sonuc", FormColumnDescription = "Sonuç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_MUSTERISIKAYET2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KaynakYol", FormColumnDescription = "Kaynak Yol", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HedefYol", FormColumnDescription = "Hedef Yol", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DosyaAdi", FormColumnDescription = "Dosya Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EklenmeTrh", FormColumnDescription = "Eklenme Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Aciklama", FormColumnDescription = "Açıklaması", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_MUSTERISIKAYET", "Müşteri Şikayetleri", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_MUSTERISIKAYET", "", chList: chList);
                    }

                    #region 10B1C4 SİSTEM TABLO VE ALANLARI

                    TableCreation.CreateUserFields("OBTN", "SerDurumu", "Şer Durumu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: SerDurumu);

                    TableCreation.CreateUserFields("OCRD", "TakipTuru", "Takip Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, clist: TakipTuru);
                    TableCreation.CreateUserFields("OCRD", "Avukat", "Avukat", SAPbobsCOM.BoFieldTypes.db_Alpha, 15, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("OCRD", "Nitelik", "Nitelik", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None, clist: Nitelik);
                    TableCreation.CreateUserFields("OCRD", "CommarchKod", "Commarch Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("OCRD", "CommarchAltKod", "Commarch Alt Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("CRD1", "CommarchAdresKod", "Commarch Adres Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("OITM", "EskiKod", "Logo Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("OJDT", "TeminatTuru", "Teminat Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, clist: TeminatTuru);
                    TableCreation.CreateUserFields("OJDT", "TeminatBasTar", "Teminat Başlangıç Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                    TableCreation.CreateUserFields("OJDT", "TeminatBitTar", "Teminat Bitiş Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                    TableCreation.CreateUserFields("OJDT", "BankaSecim", "Banka Seçimi", SAPbobsCOM.BoFieldTypes.db_Numeric, 11, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("OPDN", "TopSutMiktari", "Toplam Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Quantity);
                    TableCreation.CreateUserFields("OPDN", "SutKabulIrsNo", "Süt Kabul İrsaliye No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("OPDN", "KantarNo", "Kantar No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("OPDN", "SutKabulId", "Süt Kabul Id", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("OPOR", "SSDocEntry", "Satış Siparişi No", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("OPOR", "OnayRed", "Yönetici Onay Red", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: SASOnayRed, DefaultValue: "B");
                    TableCreation.CreateUserFields("OPOR", "YonIslmSaat", "Yönetici İşlem Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("OPOR", "YonIslmTar", "Yönetici İşlem Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                    TableCreation.CreateUserFields("OPOR", "OnaylayanYon", "Onaylayan Yönetici", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("POR1", "SSDocEntry", "Satış Siparişi No", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("POR1", "SSLineNum", "Satış Siparişi Sira", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("POR1", "SSDocType", "Satış Sipariş Tipi", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("ORDR", "IndirimTipi", "İndirim Tipi", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: SatisIndirimTipi, DefaultValue: "0");
                    TableCreation.CreateUserFields("ORDR", "YemDueDate", "Yem Valör Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                    TableCreation.CreateUserFields("RDR1", "DueRate", "Vade Oran", SAPbobsCOM.BoFieldTypes.db_Float, 2, SAPbobsCOM.BoFldSubTypes.st_Percentage);
                    TableCreation.CreateUserFields("RDR1", "AIF_DiscountNo", "Indirim No", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("RDR1", "NavlunBirim", "Navlun Birim", SAPbobsCOM.BoFieldTypes.db_Float, 3, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("RDR1", "Iskonto1", "İskonto 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("RDR1", "Iskonto2", "İskonto 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("RDR1", "Iskonto3", "İskonto 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("RDR1", "Iskonto4", "İskonto 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("RDR1", "Iskonto5", "İskonto 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                    TableCreation.CreateUserFields("OSPP", "TemplateCode", "Şablon Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("OVPM", "IslemTuru", "İşlem Türü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None, clist: IslemTuru);
                    TableCreation.CreateUserFields("OVPM", "RapordaGorunecek", "Raporda Görünecek", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: EvetHayir, DefaultValue: "Evet");
                    TableCreation.CreateUserFields("OVPM", "ValorTarihi", "Valör Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                    TableCreation.CreateUserFields("OVPM", "OdemeDetay", "Ödeme Detayı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("OWHS", "DepoTipi", "Depo Tipi", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, clist: DepoTipi);
                    TableCreation.CreateUserFields("OWHS", "WhsGroup", "Depo Grubu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: DepoGrubu);
                    TableCreation.CreateUserFields("OWHS", "WhsSecGroup", "Depo Alt Group", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: DepoAltGrubu);

                    #endregion 10B1C4  SİSTEM TABLO VE ALANLARI
                }

                #endregion 10B1C4 TABLO VE ALANLARI

                #region 20R5DB TABLO VE ALANLARI
                if (Program.mKod == "20R5DB")
                {
                    #region F SAP KY 001 - PASTÖRİZASYON ANALİZ
                    if (!TableCreation.TableExists("AIF_FSAPKY001"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY001", "PastorizasyonAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY001_1", "PastorizasyonAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY001_2", "PastorizasyonAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY001", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "BasSaati", "Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "PasSicaklik", "Pastorizasyon Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "PasCikis", "Pastorizasyon Çıkış", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "HolderSuresi", "Holder Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "HmjBasinc", "Homojenizasyon Basınç", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "CigSutMik", "Çiğ Süt Müktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "CekilenKrema", "Çekilen Krema", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "EklnKrema", "Eklenen Krema", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "StandSutMik", "Stand. Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "BitSaat", "Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY001_2", "CigSutDepTnk", "Çiğ Süt Alındığı Dep.Tankı", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_2", "CigSutMik", "Alınan Çiğ Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_2", "CigSutPH", "Çiğ Süt PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_2", "CigSutSH", "Çiğ Süt SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_2", "CigSutKM", "Çiğ Süt KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_2", "CigSutYag", "Çiğ Süt Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY001_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY001"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY001_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_BasSaati", FormColumnDescription = "Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasSicaklik", FormColumnDescription = "Pastorizasyon Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasCikis", FormColumnDescription = "Pastorizasyon Çıkış", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HolderSuresi", FormColumnDescription = "Holder Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HmjBasinc", FormColumnDescription = "Homojenizasyon Basınç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutMik", FormColumnDescription = "Çiğ Süt Müktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CekilenKrema", FormColumnDescription = "Çekilen Krema", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EklnKrema", FormColumnDescription = "Eklenen Krema", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StandSutMik", FormColumnDescription = "Stand. Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BitSaat", FormColumnDescription = "Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY001_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutDepTnk", FormColumnDescription = "Çiğ Süt Alındığı Dep.Tankı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutMik", FormColumnDescription = "Alınan Çiğ Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutPH", FormColumnDescription = "Çiğ Süt PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutSH", FormColumnDescription = "Çiğ Süt SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutKM", FormColumnDescription = "Çiğ Süt KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutYag", FormColumnDescription = "Çiğ Süt Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY001", "PastorizasyonAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY001", "", chList: chList);
                    }
                    #endregion F SAP KY 001 - YOĞURT PASTÖRİZASYON ANALİZ

                    #region F SAP KY 002-1 KAŞAR TELEME ANALİZ  						
                    if (!TableCreation.TableExists("AIF_FSAPKY002_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY002_1", "KasarTelemeAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY002_1_1", "KasarTelemeAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY002_1_2", "KasarTelemeAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY002_1_3", "KasarTelemeAnaliz3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY002_1_4", "KasarTelemeAnaliz4", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1", "Kontrol", "Kontrol", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_1", "ProsTnkNo", "Proses Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_1", "TelemeSutMik", "Teleme Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_1", "MayaSicaklik", "Mayalama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_1", "MayalamaSaati", "Mayalama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_1", "KirimSaati", "Kırım Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_1", "KirimPH", "Kırım PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_1", "ProsPersAdi", "Kaşar Prosesi Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_2", "TelemeSutPH", "Teleme Süt PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_2", "TelemeSutSH", "Teleme Süt SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_2", "TelemeSutKM", "Teleme Süt KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_2", "TelemeSutYag", "Teleme Süt Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_2", "TelemeYag", "Teleme Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_2", "TelemeKurMad", "Teleme Kuru Madde", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_2", "TelemePH", "Teleme PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_2", "LabPersAdi", "Laboratuvar Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_3", "CedarSicaklik", "Çedarlama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_3", "CedarBasSaat", "Çedarlama Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_3", "CedarBitSaat", "Çedarlama Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_3", "IndrmeBasSaat", "İndirme Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_3", "IndrmeBitSaat", "İndirme Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_3", "IndirmePH", "İndirme PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_4", "PihtiSuresi", "Pıhtı Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_4", "CedarSuresi", "Çedarlama Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_4", "IndrmeSuresi", "İndirme Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_4", "ToplamSure", "Toplam Süre", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_1_4", "TelemeRand", "Teleme Randımanı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);




                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY002_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol", "Kontrol");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_ProsTnkNo", FormColumnDescription = "Proses Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeSutMik", FormColumnDescription = "Teleme Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayaSicaklik", FormColumnDescription = "Mayalama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayalamaSaati", FormColumnDescription = "Mayalama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimSaati", FormColumnDescription = "Kırım Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimPH", FormColumnDescription = "Kırım PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ProsPersAdi", FormColumnDescription = "Kaşar Prosesi Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeSutPH", FormColumnDescription = "Teleme Süt PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeSutSH", FormColumnDescription = "Teleme Süt SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeSutKM", FormColumnDescription = "Teleme Süt KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeSutYag", FormColumnDescription = "Teleme Süt Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeYag", FormColumnDescription = "Teleme Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeKurMad", FormColumnDescription = "Teleme Kuru Madde", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemePH", FormColumnDescription = "Teleme PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_1_3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_CedarSicaklik", FormColumnDescription = "Çedarlama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CedarBasSaat", FormColumnDescription = "Çedarlama Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CedarBitSaat", FormColumnDescription = "Çedarlama Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IndrmeBasSaat", FormColumnDescription = "İndirme Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IndrmeBitSaat", FormColumnDescription = "İndirme Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IndirmePH", FormColumnDescription = "İndirme PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_1_4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PihtiSuresi", FormColumnDescription = "Pıhtı Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CedarSuresi", FormColumnDescription = "Çedarlama Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IndrmeSuresi", FormColumnDescription = "İndirme Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ToplamSure", FormColumnDescription = "Toplam Süre", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeRand", FormColumnDescription = "Teleme Randımanı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY002_1", "KasarTelemeAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY002_1", "", chList: chList);
                    }
                    #endregion F SAP KY 002-1 KAŞAR TELEME ANALİZ & 002-2  KAŞAR HAŞLAMA & 002-3 - KAŞAR PAKETLEME	

                    #region F SAP KY 002-2  Kaşar Haşlama Analiz 
                    if (!TableCreation.TableExists("AIF_FSAPKY002_2"))
                    {

                        TableCreation.CreateTable("AIF_FSAPKY002_2", "KasarHaslamaAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY002_2_1", "KasarHaslamaAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY002_2_2", "KasarHaslamaAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2", "Kontrol2", "Kontrol 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);


                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_1", "TelemePros", "Teleme Prosesi", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_1", "TelemeMik", "Teleme Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_1", "TelemePros2", "Teleme Prosesi 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_1", "TelemeMik2", "Teleme Miktarı 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_1", "HaslamaBasPH", "Haşlama Başlangıç PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_1", "BaslangicSaat", "Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_1", "BitisSaati", "Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_1", "HaslamaOprt", "Haşlama Operatörü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "UrunKodu", "Yapılan Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "UrunAdi", "Yapılan Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_2_2", "GramOlcOprt", "Gramaj Ölçümü Operatörü", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }

                    if (!UdoCreation.UDOExists("AIF_FSAPKY002_2"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");
                        fields.Add("U_Kontrol2", "Kontrol 2");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_2_1";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemePros", FormColumnDescription = "Teleme Prosesi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeMik", FormColumnDescription = "Teleme Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemePros2", FormColumnDescription = "Teleme Prosesi 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TelemeMik2", FormColumnDescription = "Teleme Miktarı 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HaslamaBasPH", FormColumnDescription = "Haşlama Başlangıç PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaslangicSaat", FormColumnDescription = "Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BitisSaati", FormColumnDescription = "Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HaslamaOprt", FormColumnDescription = "Haşlama Operatörü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Yapılan Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Yapılan Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_GramOlcOprt", FormColumnDescription = "Gramaj Ölçümü Operatörü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY002_2", "KasarHaslamaAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY002_2", "", chList: chList);

                    }
                    #endregion

                    #region F SAP KY 002-3 Kaşar Paketleme

                    if (!TableCreation.TableExists("AIF_FSAPKY002_3"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY002_3", "KasarPaketlemeAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY002_3_1", "KasarPaketlemeAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY002_3_2", "KasarPaketlemeAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY002_3_3", "KasarPaketlemeAnaliz3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY002_3_4", "KasarPaketlemeAnaliz4", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3", "Kontrol2", "Kontrol 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3", "Kontrol3", "Kontrol 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_1", "PaketSicak", "Paketleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_1", "UretimTarih", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_1", "SonTukTarih", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "Saat", "Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "BirGozCO2", "1.Göz CO2 %", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "BirGozO2", "1.Göz O2 %", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "IkiGozCO2", "2.Göz CO2 %", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "IkiGozO2", "2.Göz O2 %", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "UcGozCO2", "3.Göz CO2 %", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "UcGozO2", "3.Göz O2 %", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek8", "Örnek 8", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek9", "Örnek 9", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "Ornek10", "Örnek 10", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_3", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_4", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_4", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_4", "DuyAnlzOny", "Duyusal Analiz Onayı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY002_3_4", "SorumluMuh", "Sorumlu Mühendis", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }



                    if (!UdoCreation.UDOExists("AIF_FSAPKY002_3"))
                    {

                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");
                        fields.Add("U_Kontrol2", "Kontrol 2");
                        fields.Add("U_Kontrol3", "Kontrol 3");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();
                        ChildTable ch = new ChildTable();

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_3_1";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketSicak", FormColumnDescription = "Paketleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTarih", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTarih", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_3_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Saat", FormColumnDescription = "Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirGozCO2", FormColumnDescription = "1.Göz CO2 %", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BirGozO2", FormColumnDescription = "1.Göz O2 %", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IkiGozCO2", FormColumnDescription = "2.Göz CO2 %", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IkiGozO2", FormColumnDescription = "2.Göz O2 %", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UcGozCO2", FormColumnDescription = "3.Göz CO2 %", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UcGozO2", FormColumnDescription = "3.Göz O2 %", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_3_3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek8", FormColumnDescription = "Örnek 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek9", FormColumnDescription = "Örnek 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek10", FormColumnDescription = "Örnek 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY002_3_4";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DuyAnlzOny", FormColumnDescription = "Duyusal Analiz Onayı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SorumluMuh", FormColumnDescription = "Sorumlu Mühendis", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY002_3", "KaşarPaketlemeAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY002_3", "", chList: chList);

                    }
                    #endregion

                    #region F SAP KY 003-1 - BEYAZ PEYNİR TELEME ANALİZ								
                    if (!TableCreation.TableExists("AIF_FSAPKY003_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY003_1", "BeyazPeynirTelemeAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY003_1_1", "BeyazPeynirTelemeAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY003_1_2", "BeyazPeynirTelemeAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY003_1_3", "BeyazPeynirTelemeAnaliz3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);


                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1", "Kontrol2", "Kontrol 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "UniteSic", "Ünite Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "TekneNo", "Tekne No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "UrtUrunAdi", "Üretilen Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "AlSutMik", "Alınan Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "TekSutSic", "Tekne Sütü Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "MayaSaat", "Mayalama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "KirimSaat", "Kırım Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "BaskBasSaat", "Baskılama Baş. Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "BaskSonSaat", "Baskılama Sonu Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "KesmeSaat", "Kesme Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "KesmePH", "Kesme PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "SalIlvSaat", "Salamura İlave Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "PeyTopSaat", "Peynir Top. Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "PeyTopPH", "Peynir Top. PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_2", "TekneSalPH", "Tekne Salamura PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_2", "TekneSalBol", "Tekne Salmura Bölme", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_2", "TekneSalSic", "Tekne Salamura Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_3", "NumuneNo", "Numune No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_3", "BeyPeySutPH", "Beyaz Peynir Süt PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_3", "BeyPeySutSH", "Beyaz Peynir Süt SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_3", "BeyPeySutKM", "Beyaz Peynir Süt KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_3", "BeyPeySutYag", "Beyaz Peynir Süt Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_1_3", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY003_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");
                        fields.Add("U_Kontrol2", "Kontrol 2");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY003_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UniteSic", FormColumnDescription = "Ünite Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TekneNo", FormColumnDescription = "Tekne No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrtUrunAdi", FormColumnDescription = "Üretilen Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AlSutMik", FormColumnDescription = "Alınan Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TekSutSic", FormColumnDescription = "Tekne Sütü Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayaSaat", FormColumnDescription = "Mayalama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimSaat", FormColumnDescription = "Kırım Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskBasSaat", FormColumnDescription = "Baskılama Baş. Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskSonSaat", FormColumnDescription = "Baskılama Son. Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KesmeSaat", FormColumnDescription = "Kesme Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KesmePH", FormColumnDescription = "Kesme PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SalIlvSaat", FormColumnDescription = "Salamura İlave Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PeyTopSaat", FormColumnDescription = "Peynir Top. Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PeyTopPH", FormColumnDescription = "Peynir Top. PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY003_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TekneSalPH", FormColumnDescription = "Tekne Salamura PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TekneSalBol", FormColumnDescription = "Tekne Salmura Bölme", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TekneSalSic", FormColumnDescription = "Tekne Salamura Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY003_1_3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_NumuneNo", FormColumnDescription = "Numune No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BeyPeySutPH", FormColumnDescription = "Beyaz Peynir Süt PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BeyPeySutSH", FormColumnDescription = "Beyaz Peynir Süt SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BeyPeySutKM", FormColumnDescription = "Beyaz Peynir Süt KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BeyPeySutYag", FormColumnDescription = "Beyaz Peynir Süt Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY003_1", "BeyazPeynirTelemeAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY003_1", "", chList: chList);
                    }
                    #endregion F SAP KY 003-1 - BEYAZ PEYNİR TELEME ANALİZ

                    #region F SAP KY 003-2 - BEYAZ PEYNİR PAKETLEME	
                    if (!TableCreation.TableExists("AIF_FSAPKY003_2"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY003_2", "BeyazPeynirPaketlemeAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY003_2_1", "BeyazPeynirPaketlemeAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY003_2_2", "BeyazPeynirPaketlemeAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2", "Kontrol2", "Kontrol 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);


                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_1", "KapatmaPH", "Kapatma PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_1", "UretimTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_1", "SonTukTar", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_1", "DolSalPH", "Dolum Salamura PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_1", "DolSalBol", "Dolum Salamura Bölme", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY003_2_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                    }

                    if (!UdoCreation.UDOExists("AIF_FSAPKY003_2"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");
                        fields.Add("U_Kontrol2", "Kontrol 2");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();

                        ch.TableName = "AIF_FSAPKY003_2_1";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KapatmaPH", FormColumnDescription = "Kapatma PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTar", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolSalPH", FormColumnDescription = "Dolum Salamura PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolSalBol", FormColumnDescription = "Dolum Salamura Bölme", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY003_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY003_2", "BeyazPeynirPaketlemeAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY003_2", "", chList: chList);

                    }
                    #endregion F SAP KY 003-2 - BEYAZ PEYNİR PAKETLEME

                    #region F SAP KY 004-1-1 - Konsantre Ürün UF Analiz 1 &004-1-2 Konsantre Ürün UF Analiz 2						
                    if (!TableCreation.TableExists("AIF_FSAPKY004_1_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY004_1_1", "KonsantreUrunUFAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY004_1_1_1", "KonsantreUrunUFAnaliz1_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY004_1_1_2", "KonsantreUrunUFAnaliz1_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY004_1_2_1", "KonsantreUrunUFAnaliz2_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY004_1_2_2", "KonsantreUrunUFAnaliz2_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY004_1_2_3", "KonsantreUrunUFAnaliz2_3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1", "Kontrol2", "Kontrol 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_1", "ProsTnkNo", "Proses Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_1", "UFSutMik", "UF Sütü Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_1", "ReworkMik", "Rework Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_1", "MayaSicaklik", "Mayalama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_1", "MayaSaat", "Mayalama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_1", "KirimSaat", "Kırım Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_1", "UFOprtAdi", "UF Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_2", "UFSutPH", "UF Sütü PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_2", "UFSutSH", "UF Sütü SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_2", "UFSutKM", "UF Sütü KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_2", "UFSutYag", "UF Sütü Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_2", "KirimPH", "Kırım PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_2", "KirimSH", "Kırım SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_1_2", "LabPersAdi", "Laboratuvar Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_1", "UFGirisSic", "UF Giriş Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_1", "UFGirisSaat", "UF Giriş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_1", "UFFaktor", "UF Faktörü", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_1", "UFCikisSic", "UF Çıkış Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_1", "UFBitSaat", "UF Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_1", "UFOprtAdi", "UF Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_2", "ReworkPH", "Rework PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_2", "ReworkKM", "Rework KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_2", "ReworkYag", "Rework Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_2", "LabPersAdi", "Laboratuvar Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_3", "KnsUrunPH", "Konsantre Ürün PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_3", "KnsUrunSH", "Konsantre Ürün SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_3", "KnsUrunKM", "Konsantre Ürün KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_3", "KnsUrunYag", "Konsantre Ürün Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_1_2_3", "LabPersAdi", "Laboratuvar Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY004_1_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY004_1_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_ProsTnkNo", FormColumnDescription = "Proses Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFSutMik", FormColumnDescription = "UF Sütü Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ReworkMik", FormColumnDescription = "Rework Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayaSicaklik", FormColumnDescription = "Mayalama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayaSaat", FormColumnDescription = "Mayalama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimSaat", FormColumnDescription = "Kırım Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFOprtAdi", FormColumnDescription = "UF Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY004_1_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UFSutPH", FormColumnDescription = "UF Sütü PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFSutSH", FormColumnDescription = "UF Sütü SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFSutKM", FormColumnDescription = "UF Sütü KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFSutYag", FormColumnDescription = "UF Sütü Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimPH", FormColumnDescription = "Kırım PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimSH", FormColumnDescription = "Kırım SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY004_1_2_1";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UFGirisSic", FormColumnDescription = "UF Giriş Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFGirisSaat", FormColumnDescription = "UF Giriş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFFaktor", FormColumnDescription = "UF Faktörü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFCikisSic", FormColumnDescription = "UF Çıkış Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFBitSaat", FormColumnDescription = "UF Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFOprtAdi", FormColumnDescription = "UF Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY004_1_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_ReworkPH", FormColumnDescription = "Rework PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ReworkKM", FormColumnDescription = "Rework KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_ReworkYag", FormColumnDescription = "Rework Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY004_1_2_3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KnsUrunPH", FormColumnDescription = "Konsantre Ürün PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KnsUrunSH", FormColumnDescription = "Konsantre Ürün SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KnsUrunKM", FormColumnDescription = "Konsantre Ürün KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KnsUrunYag", FormColumnDescription = "Konsantre Ürün Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY004_1_1", "KonsantreUrunUFAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY004_1_1", "", chList: chList);
                    }
                    #endregion F SAP KY 004-1-1 - Konsantre Ürün UF Analiz 1 &004-1-2 Konsantre Ürün UF Analiz 2		

                    #region F SAP KY 004-2 UF Proses Üretim Analiz
                    if (!TableCreation.TableExists("AIF_FSAPKY004_2"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY004_2", "UFProsesUretimAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY004_2_1", "UFProsesUretimAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY004_2_2", "UFProsesUretimAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY004_2_3", "UFProsesUretimAnaliz3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "ProsesNo", "Proses No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "YariMamMik", "Yarı Mamül Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "EkLorMik", "Eklenen Lor Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "HmjBasinc", "Homojen Basıncı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "PastSic", "Pastorizasyon Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "UFOprtAdi", "UF Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "YariMamPH", "Yarı Mamül PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "YariMamSH", "Yarı Mamül SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "YariMamKM", "Yarı Mamül KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "YariMamYag", "Yarı Mamül Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "LorKM", "Lor KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "LorYagi", "Lor Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "LabPersAdi", "Laboratuvar Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_3", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_3", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_3", "DuyAnlzOny", "Duyusal Analiz Onayı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY004_2_3", "SorumluMuh", "Sorumlu Mühendis", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY004_2"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY004_2_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_ProsesNo", FormColumnDescription = "Proses No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YariMamMik", FormColumnDescription = "Yarı Mamül Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EkLorMik", FormColumnDescription = "Eklenen Lor Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HmjBasinc", FormColumnDescription = "Homojen Basıncı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastSic", FormColumnDescription = "Pastorizasyon Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFOprtAdi", FormColumnDescription = "UF Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY004_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_YariMamPH", FormColumnDescription = "Yarı Mamül PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YariMamSH", FormColumnDescription = "Yarı Mamül SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YariMamKM", FormColumnDescription = "Yarı Mamül KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YariMamYag", FormColumnDescription = "Yarı Mamül Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LorKM", FormColumnDescription = "Lor KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LorYagi", FormColumnDescription = "Lor Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY004_2_3";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DuyAnlzOny", FormColumnDescription = "Duyusal Analiz Onayı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SorumluMuh", FormColumnDescription = "Sorumlu Mühendis", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY004_2", "UFProsesUretimAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY004_2", "", chList: chList);
                    }
                    #endregion F SAP KY 004-2 UF Proses Üretim Analiz

                    #region F SAP KY 005-2 Homojen Yoğurt Sütü Analiz
                    if (!TableCreation.TableExists("AIF_FSAPKY005_2"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY005_2", "HomojenYogurtSutuAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY005_2_1", "HomojenYogurtSutuAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY005_2_2", "HomojenYogurtSutuAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "StanSutMik", "Stand. Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "StanSutSic", "Stand. Süt Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "KulturSic", "Kültürleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "StanSutPH", "Stand. Süt PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "StanSutSH", "Stand. Süt SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "StanSutKM", "Stand. Süt KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_1", "TekPersAdi", "Teknik Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_2", "DolBasOny", "Doluma Başlama Onayı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_2_2", "SorumluMuh", "Sorumlu Mühendis", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY005_2"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY005_2_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StanSutMik", FormColumnDescription = "Stand. Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StanSutSic", FormColumnDescription = "Stand. Süt Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulturSic", FormColumnDescription = "Kültürleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StanSutPH", FormColumnDescription = "Stand. Süt PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StanSutSH", FormColumnDescription = "Stand. Süt SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StanSutKM", FormColumnDescription = "Stand. Süt KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TekPersAdi", FormColumnDescription = "Teknik Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY005_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasOny", FormColumnDescription = "Doluma Başlama Onayı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SorumluMuh", FormColumnDescription = "Sorumlu Mühendis", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY005_2", "HomojenYogurtSutuAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY005_2", "", chList: chList);
                    }
                    #endregion F SAP KY 005-2 Homojen Yoğurt Sütü Analiz

                    #region F SAP KY 005-3-1 Homojenize Yoğurt Dolum İnkübasyon 1 & 005-3-2 Homojenize Yoğurt Dolum İnkübasyon 2						
                    if (!TableCreation.TableExists("AIF_FSAPKY005_3_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY005_3_1", "HomojYogurtDolumInkubasyon", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY005_3_1_1", "HomojYogurtDolumInkubasyon1_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY005_3_1_2", "HomojYogurtDolumInkubasyon1_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY005_3_2_1", "HomojYogurtDolumInkubasyon_2_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY005_3_2_2", "HomojYogurtDolumInkubasyon2_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1", "Kontrol2", "Kontrol 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "DolBasPH1", "Dolum Başlama PH 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "DolBasPH2", "Dolum Başlama PH 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "DolBasPH3", "Dolum Başlama PH 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "DolBasPH4", "Dolum Başlama PH 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "DolBasPH5", "Dolum Başlama PH 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "DolBasPH6", "Dolum Başlama PH 6", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "DolBasPH7", "Dolum Başlama PH 7", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "DolBasPH8", "Dolum Başlama PH 8", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek8", "Örnek 8", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek9", "Örnek 9", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "Ornek10", "Örnek 10", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_1_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "PaletNo", "Palet No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSaat1", "1.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSaat2", "2.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSaat3", "3.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSaat4", "4.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSaat5", "5.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzPH1", "1.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzPH2", "2.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzPH3", "3.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzPH4", "4.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzPH5", "5.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSic1", "1.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSic2", "2.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSic3", "3.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSic4", "4.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "AnlzSic5", "5.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_2", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_2", "PaletNo", "Palet No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_2", "Saat", "Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_2", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_2", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY005_3_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY005_3_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");
                        fields.Add("U_Kontrol2", "Kontrol 2");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY005_3_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasPH1", FormColumnDescription = "Dolum Başlama PH 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasPH2", FormColumnDescription = "Dolum Başlama PH 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasPH3", FormColumnDescription = "Dolum Başlama PH 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasPH4", FormColumnDescription = "Dolum Başlama PH 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasPH5", FormColumnDescription = "Dolum Başlama PH 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasPH6", FormColumnDescription = "Dolum Başlama PH 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasPH7", FormColumnDescription = "Dolum Başlama PH 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DolBasPH8", FormColumnDescription = "Dolum Başlama PH 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY005_3_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek8", FormColumnDescription = "Örnek 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek9", FormColumnDescription = "Örnek 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek10", FormColumnDescription = "Örnek 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY005_3_2_1";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaletNo", FormColumnDescription = "Palet No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat1", FormColumnDescription = "1.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat2", FormColumnDescription = "2.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat3", FormColumnDescription = "3.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat4", FormColumnDescription = "4.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat5", FormColumnDescription = "5.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH1", FormColumnDescription = "1.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH2", FormColumnDescription = "2.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH3", FormColumnDescription = "3.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH4", FormColumnDescription = "4.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH5", FormColumnDescription = "5.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic1", FormColumnDescription = "1.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic2", FormColumnDescription = "2.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic3", FormColumnDescription = "3.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic4", FormColumnDescription = "4.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic5", FormColumnDescription = "5.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY005_3_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaletNo", FormColumnDescription = "Palet No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Saat", FormColumnDescription = "Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY005_3_1", "HomojYogurtDolumInkubasyon", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY005_3_1", "", chList: chList);
                    }
                    #endregion F SAP KY 005-3-1 Homojenize Yoğurt Dolum İnkübasyon 1 & 005-3-2 Homojenize Yoğurt Dolum İnkübasyon 2		

                    #region F SAP KY 006-1-1 Stand.Kaymaklı Yoğurt Analiz 1 & 006-1-2 Stand.Kaymaklı Yoğurt Analiz 2 
                    if (!TableCreation.TableExists("AIF_FSAPKY006_1_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY006_1_1", "StandKaymakliYogurtAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY006_1_1_1", "StandKaymakliYogurtAnaliz1_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY006_1_1_2", "StandKaymakliYogurtAnaliz1_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY006_1_2_1", "StandKaymakliYogurtAnaliz2_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY006_1_2_2", "StandKaymakliYogurtAnaliz2_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 200, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1", "Kontrol2", "Kontrol 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1", "Kontrol3", "Kontrol 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "StanSutMik", "Stand. Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "EklnKrema", "Eklenen Krema", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "EklnKremaPH", "Eklenen Krema PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "FirinSuresi", "Fırınlama Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "KulturSic", "Kültürleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "KulturSaat", "Kültürleme Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "KullKultPH", "Kullanılan Kültür PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "KullKultOr", "Kullanılan Kültür Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_1", "OprtPersAdi", "Operatör Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "CigKreYagOr", "Standart Süt Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "CigKrePH", "Çiğ Krema PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "PasKreYagOr", "Pastörize Kremanın Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "PasKrePH", "Pastörize Krema PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "LabPersAdi", "Laboratuvar Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "PaletNo", "Palet No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSaat1", "1.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSaat2", "2.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSaat3", "3.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSaat4", "4.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSaat5", "5.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzPH1", "1.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzPH2", "2.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzPH3", "3.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzPH4", "4.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzPH5", "5.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSic1", "1.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSic2", "2.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSic3", "3.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSic4", "4.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "AnlzSic5", "5.Analiz(Sıc(C))", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "SogOdGrSaat", "Soğuk Oda G.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_2", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_2", "InkOdaNo", "İnkübasyon Oda No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_2", "Saat", "Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_2", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_2", "Sicaklik", "Sıcaklık(C)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_2", "SogOdGrSaat", "Soğuk Oda G.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY006_1_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }


                    TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "StandSutYag", "Standart Süt Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "StandSutPH", "Standart Süt PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "PastSutYag", "Pastörize Süt Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY006_1_1_2", "PastSutPH", "Pastörize Süt PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                    if (!UdoCreation.UDOExists("AIF_FSAPKY006_1_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");
                        fields.Add("U_Kontrol2", "Kontrol 2");
                        fields.Add("U_Kontrol3", "Kontrol 3");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY006_1_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StanSutMik", FormColumnDescription = "Stand. Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EklnKrema", FormColumnDescription = "Eklenen Krema", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_EklnKremaPH", FormColumnDescription = "Eklenen Krema PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_FirinSuresi", FormColumnDescription = "Fırınlama Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulturSic", FormColumnDescription = "Kültürleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulturSaat", FormColumnDescription = "Kültürleme Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KullKultPH", FormColumnDescription = "Kullanılan Kültür PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KullKultOr", FormColumnDescription = "Kullanılan Kültür Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtPersAdi", FormColumnDescription = "Operatör Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY006_1_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_CigKreYagOr", FormColumnDescription = "Çiğ Kremanın Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigKrePH", FormColumnDescription = "Çiğ Krema PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasKreYagOr", FormColumnDescription = "Pastörize Kremanın Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasKrePH", FormColumnDescription = "Pastörize Krema PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_StandSutYag", FormColumnDescription = "Standart Süt Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StandSutPH", FormColumnDescription = "Standart Süt PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastSutYag", FormColumnDescription = "Pastörize Süt Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastSutPH", FormColumnDescription = "Pastörize Süt PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY006_1_2_1";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaletNo", FormColumnDescription = "Palet No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat1", FormColumnDescription = "1.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat2", FormColumnDescription = "2.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat3", FormColumnDescription = "3.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat4", FormColumnDescription = "4.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat5", FormColumnDescription = "5.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH1", FormColumnDescription = "1.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH2", FormColumnDescription = "2.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH3", FormColumnDescription = "3.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH4", FormColumnDescription = "4.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH5", FormColumnDescription = "5.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic1", FormColumnDescription = "1.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic2", FormColumnDescription = "2.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic3", FormColumnDescription = "3.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic4", FormColumnDescription = "4.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSic5", FormColumnDescription = "5.Analiz(Sıc(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SogOdGrSaat", FormColumnDescription = "Soğuk Oda G.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY006_1_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_InkOdaNo", FormColumnDescription = "İnkübasyon Oda No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Saat", FormColumnDescription = "Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Sicaklik", FormColumnDescription = "Sıcaklık(C)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SogOdGrSaat", FormColumnDescription = "Soğuk Oda G.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);


                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY006_1_1", "StandKaymakliYogurtAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY006_1_1", "", chList: chList);
                    }
                    #endregion F SAP KY 006-1-1 Stand.Kaymaklı Yoğurt Analiz 1 & 006-1-2 Stand.Kaymaklı Yoğurt Analiz 2	

                    #region F SAP KY 007-1 Ayran Sütü Hazırlık Analiz
                    if (!TableCreation.TableExists("AIF_FSAPKY007_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY007_1", "AyranSutuHazirlikAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY007_1_1", "AyranSutuHazirlikAnali1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY007_1_2", "AyranSutuHazirlikAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1_1", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1_1", "KullCigSut", "Kullanılan Çiğ Süt", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1_1", "CigSutCekSa", "Kullanılan Çiğ Sütün Çekildiği Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1_1", "KullSu", "Kullanılan Su", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1_1", "SuEkSaat", "Suyun Eklenme Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1_1", "TopAyrSut", "Toplam Ayran Sütü", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_1_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "CigSutPH", "Çiğ Süt PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "CigSutSH", "Çiğ Süt SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "CigSutKM", "Çiğ Süt KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "CigSutYag", "Çiğ Süt Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "AyrSutPH", "Ayran Sütü PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "AyrSutSH", "Ayran Sütü SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "AyrSutKM", "Ayran Sütü KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "AyrSutYag", "Ayran Sütü Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("AIF_FSAPKY007_1_2", "TekPersAdi", "Teknik Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY007_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY007_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KullCigSut", FormColumnDescription = "Kullanılan Çiğ Süt", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutCekSa", FormColumnDescription = "Kullanılan Çiğ Sütün Çekildiği Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KullSu", FormColumnDescription = "Kullanılan Su", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SuEkSaat", FormColumnDescription = "Suyun Eklenme Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TopAyrSut", FormColumnDescription = "Toplam Ayran Sütü", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY007_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutPH", FormColumnDescription = "Çiğ Süt PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutSH", FormColumnDescription = "Çiğ Süt SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutKM", FormColumnDescription = "Çiğ Süt KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigSutYag", FormColumnDescription = "Çiğ Süt Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AyrSutPH", FormColumnDescription = "Ayran Sütü PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AyrSutSH", FormColumnDescription = "Ayran Sütü SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AyrSutKM", FormColumnDescription = "Ayran Sütü KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AyrSutYag", FormColumnDescription = "Ayran Sütü Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TekPersAdi", FormColumnDescription = "Teknik Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY007_1", "AyranSutuHazirlikAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY007_1", "", chList: chList);
                    }
                    #endregion F SAP KY 007-1 Ayran Sütü Hazırlık Analiz

                    #region F SAP KY 007-2-1 Ayran Pastörizasyon Hazırlık 1 & 007-2-2 Ayran Pastörizasyon Hazırlık 2							
                    if (!TableCreation.TableExists("AIF_FSAPKY007_2_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY007_2_1", "AyranPastorizasyonHazirlik", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY007_2_1_1", "AyranPastorizasyonHazirlik1_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY007_2_1_2", "AyranPastorizasyonHazirlik1_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY007_2_2_1", "AyranPastorizasyonHazirlik2_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY007_2_2_2", "AyranPastorizasyonHazirlik2_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1", "DgrKltKontrol", "Diğer Kalite Kontrolleri", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "BasSaati", "Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "PastSic", "Pastorizasyon Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "PastCikis", "Pastorizasyon Çıkış", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "HolderSur", "Holder Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "HmjBasinc", "Homojenizasyon Basınç", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "SuluSutMik", "Sulu Ayran Sütü Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "CekKreMik", "Çekilen Krema Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "StanSutMik", "Stand. Ayran Sütü Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "BitisSaat", "Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "ProsTnkNo", "Ayran Proses Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "AyrSutMik", "Stand. Ayran Sütü Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "KulturSic", "Kültürleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "KulturSaat", "Kültürleme Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "KulturPH", "Kültürleme PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "KirimSaat", "Kırım Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "KirimPH", "Kırım PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "KirimSH", "Kırım SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "SogCikSic", "Soğutma Eşanjörü Çıkış Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_1_2", "LabPersAdi", "Laboratuvar Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "PaletNo", "Palet No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSaat1", "1.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSaat2", "2.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSaat3", "3.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSaat4", "4.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSaat5", "5.Analiz(Saat)", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzPH1", "1.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzPH2", "2.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzPH3", "3.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzPH4", "4.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzPH5", "5.Analiz(PH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSic1", "1.Analiz(SH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSic2", "2.Analiz(SH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSic3", "3.Analiz(SH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSic4", "4.Analiz(SH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "AnlzSic5", "5.Analiz(SH)", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_2", "TankNo", "Tank No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_2", "Saat", "Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_2", "PH", "PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_2", "SH", "SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_2_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY007_2_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_DgrKltKontrol", "Diğer Kalite Kontrolleri");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY007_2_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_BasSaati", FormColumnDescription = "Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastSic", FormColumnDescription = "Pastorizasyon Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastCikis", FormColumnDescription = "Pastorizasyon Çıkış", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HolderSur", FormColumnDescription = "Holder Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_HmjBasinc", FormColumnDescription = "Homojenizasyon Basınç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SuluSutMik", FormColumnDescription = "Sulu Ayran Sütü Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CekKreMik", FormColumnDescription = "Çekilen Krema Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_StanSutMik", FormColumnDescription = "Stand. Ayran Sütü Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BitisSaat", FormColumnDescription = "Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY007_2_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_ProsTnkNo", FormColumnDescription = "Ayran Proses Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AyrSutMik", FormColumnDescription = "Stand. Ayran Sütü Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulturSic", FormColumnDescription = "Kültürleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulturSaat", FormColumnDescription = "Kültürleme Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KulturPH", FormColumnDescription = "Kültürleme PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimSaat", FormColumnDescription = "Kırım Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimPH", FormColumnDescription = "Kırım PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KirimSH", FormColumnDescription = "Kırım SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SogCikSic", FormColumnDescription = "Soğutma Eşanjörü Çıkış Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY007_2_2_1";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaletNo", FormColumnDescription = "Palet No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat1", FormColumnDescription = "1.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat2", FormColumnDescription = "2.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat3", FormColumnDescription = "3.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat4", FormColumnDescription = "4.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSaat5", FormColumnDescription = "5.Analiz(Saat)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH1", FormColumnDescription = "1.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH2", FormColumnDescription = "2.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH3", FormColumnDescription = "3.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH4", FormColumnDescription = "4.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzPH5", FormColumnDescription = "5.Analiz(PH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSH1", FormColumnDescription = "1.Analiz(SH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSH2", FormColumnDescription = "2.Analiz(SH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSH3", FormColumnDescription = "3.Analiz(SH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSH4", FormColumnDescription = "4.Analiz(SH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_AnlzSH5", FormColumnDescription = "5.Analiz(SH)", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SogOdGrSaat", FormColumnDescription = "Soğuk Oda G.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY007_2_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_TankNo", FormColumnDescription = "Tank No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Saat", FormColumnDescription = "Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PH", FormColumnDescription = "PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SH", FormColumnDescription = "SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY007_2_1", "AyranPastorizasyonHazirlik", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY007_2_1", "", chList: chList);
                    }
                    #endregion F SAP KY 007-2-1 Ayran Pastörizasyon Hazırlık 1 & 007-2-2 Ayran Pastörizasyon Hazırlık 2		

                    #region F SAP KY 007-3 Homojen Yoğurt Sütü
                    if (!TableCreation.TableExists("AIF_FSAPKY007_3"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY007_3", "HomojenYoğurtSütü", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY007_3_1", "HomojenYoğurtSütü1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY007_3_2", "HomojenYoğurtSütü2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3", "Kontrol2", "Kontrol 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_1", "PaketSicak", "Paketleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_1", "UretimTarih", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_1", "SonTukTarih", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek8", "Örnek 8", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek9", "Örnek 9", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "Ornek10", "Örnek 10", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY007_3_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY007_3"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");
                        fields.Add("U_Kontrol2", "Kontrol 2");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY007_3_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketSicak", FormColumnDescription = "Paketleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTarih", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTarih", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY007_3_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek8", FormColumnDescription = "Örnek 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek9", FormColumnDescription = "Örnek 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Ornek10", FormColumnDescription = "Örnek 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY007_3", "HomojenYoğurtSütü", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY007_3", "", chList: chList);
                    }
                    #endregion F SAP KY 007-3 Homojen Yoğurt Sütü

                    #region F SAP KY 008-1 Lor Pişirim
                    if (!TableCreation.TableExists("AIF_FSAPKY008_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY008_1", "LorPisirim", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY008_1_1", "LorPisirim1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "PasMiktar", "Pas Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "BasSaati", "Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "PisSicak", "Pişirim Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "IndirSaat", "İndirme Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "BaskSure", "Baskılama Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "PasYagi", "Pas Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "PasPH", "Pas PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY008_1_1", "TeknikAdi", "Tekniker Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY008_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY008_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PasMiktar", FormColumnDescription = "Pas Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BasSaati", FormColumnDescription = "Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PisSicak", FormColumnDescription = "Pişirim Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_IndirSaat", FormColumnDescription = "İndirme Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BaskSure", FormColumnDescription = "Baskılama Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasYagi", FormColumnDescription = "Pas Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasPH", FormColumnDescription = "Pas PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TeknikAdi", FormColumnDescription = "Tekniker Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY008_1", "LorPisirim", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY008_1", "", chList: chList);
                    }
                    #endregion F SAP KY 008-1 Lor Pişirim

                    #region F SAP KY 009-1 Krem Peynir Üretim Analizi
                    if (!TableCreation.TableExists("AIF_FSAPKY009_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY009_1", "KremPeynirÜretimAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY009_1_1", "KremPeynirÜretimAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY009_1_2", "KremPeynirÜretimAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "PisirNo", "Pişirim No", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "BasSaat", "Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "PisirSic", "Pişirim Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "BitSaat", "Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "UFOprtAdi", "UF Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "PisOnYrmPH", "Pişirim Öncesi Yarımamül PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "PisSonYrmPH", "Pişirim Sonrası Yarımamül PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "KuruMadde", "Kuru Madde", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "Yag", "Yağ", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_1", "LabPersAdi", "Laboratuvar Pers. Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_2", "DuyAnOrn", "Duyusal Analiz Onayı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY009_1_2", "SorumluMuh", "Sorumlu Mühendis", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY009_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY009_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_PisirNo", FormColumnDescription = "Pişirim No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BasSaat", FormColumnDescription = "Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PisirSic", FormColumnDescription = "Pişirim Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_BitSaat", FormColumnDescription = "Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UFOprtAdi", FormColumnDescription = "UF Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PisOnYrmPH", FormColumnDescription = "Pişirim Öncesi Yarımamül PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PisSonYrmPH", FormColumnDescription = "Pişirim Sonrası Yarımamül PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KuruMadde", FormColumnDescription = "Kuru Madde", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_Yag", FormColumnDescription = "Yağ", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Pers. Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY009_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunKodu", FormColumnDescription = "Ürün Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_DuyAnOrn", FormColumnDescription = "Duyusal Analiz Onayı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SorumluMuh", FormColumnDescription = "Sorumlu Mühendis", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY009_1", "KremPeynirÜretimAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY009_1", "", chList: chList);
                    }
                    #endregion F SAP KY 009-1 Krem Peynir Üretim Analizi

                    #region F SAP KY 010-1 Tereyağı Ürün Analizi
                    if (!TableCreation.TableExists("AIF_FSAPKY010_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY010_1", "TereyagiUrunAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY010_1_1", "TereyagiUrunAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1_1", "KullKrema", "Kullanılan Krema", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1_1", "KreYagOr", "Krema Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1_1", "KreSicak", "Krema Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1_1", "YayBasSaat", "Yayıklama Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1_1", "YayBitSaat", "Yayıklama Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1_1", "TrygRand", "Tereyağı Randımanı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY010_1_1", "OprtAdi", "Opreatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY010_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY010_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KullKrema", FormColumnDescription = "Kullanılan Krema", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KreYagOr", FormColumnDescription = "Krema Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KreSicak", FormColumnDescription = "Krema Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YayBasSaat", FormColumnDescription = "Yayıklama Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YayBitSaat", FormColumnDescription = "Yayıklama Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TrygRand", FormColumnDescription = "Tereyağı Randımanı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Opreatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY010_1", "TereyagiUrunAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY010_1", "", chList: chList);
                    }
                    #endregion F SAP KY 010-1 Tereyağı Ürün Analizi

                    #region F SAP KY 011-1 Kaymak Ürün Analiz
                    if (!TableCreation.TableExists("AIF_FSAPKY011_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY011_1", "KaymakÜrünAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY011_1_1", "KaymakÜrünAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY011_1_2", "KaymakÜrünAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_1", "KullKrema", "Kullanılan Krema", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_1", "KullSutMik", "Kullanılan Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_1", "KreSonYag", "Kremanın Son Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_1", "PastBasSa", "Pastörizasyona Başlama Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_1", "PastSicak", "Pastörizasyon Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_1", "PastBitSa", "Pastörizasyon Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_2", "KremaPH", "Krema PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_2", "YagOrani", "Krema Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_2", "SonYagOr", "Krema Son Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY011_1_2", "LabPersAdi", "Laboratuvar Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY011_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY011_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KullKrema", FormColumnDescription = "Kullanılan Krema", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KullSutMik", FormColumnDescription = "Kullanılan Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KreSonYag", FormColumnDescription = "Kremanın Son Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastBasSa", FormColumnDescription = "Pastörizasyona Başlama Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastSicak", FormColumnDescription = "Pastörizasyon Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastBitSa", FormColumnDescription = "Pastörizasyon Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY011_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaPH", FormColumnDescription = "Krema PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_YagOrani", FormColumnDescription = "Krema Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonYagOr", FormColumnDescription = "Krema Son Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY011_1", "KaymakÜrünAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY011_1", "", chList: chList);
                    }
                    #endregion F SAP KY 011-1 Kaymak Ürün Analiz           

                     #region F SAP KY 012-1 Krema Ürün Analizi
                    if (!TableCreation.TableExists("AIF_FSAPKY012_1"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY012_1", "KremaÜrünAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY012_1_1", "KremaÜrünAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY012_1_2", "KremaÜrünAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1", "DigerKontrol", "Diğer Kontrol", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_1", "CigKreMik", "Çiğ Krema Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_1", "KremaPast", "Krema Pastörizasyon", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_1", "PastBasSa", "Pastörizasyon Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_1", "PastBitSa", "Pastörizasyon Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_1", "MayaSicak", "Mayalama Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_1", "KultrEkOr", "Kültür Ekleme Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_1", "TrygOprtAdi", "Tereyağı Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_2", "CigKreYagOr", "Çiğ Kremanın Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_2", "CigKremaPH", "Çiğ Krema PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_2", "PasKreYagOr", "Pastörize Kremanın Yağ Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_2", "PasKrePH", "Pastörize Krema PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_1_2", "LabPersAdi", "Laboratuvar Personelinin Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }
                    if (!UdoCreation.UDOExists("AIF_FSAPKY012_1"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_DigerKontrol", "Diğer Kontrol");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY012_1_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_CigKreMik", FormColumnDescription = "Çiğ Krema Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KremaPast", FormColumnDescription = "Krema Pastörizasyon", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastBasSa", FormColumnDescription = "Pastörizasyon Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PastBitSa", FormColumnDescription = "Pastörizasyon Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_MayaSicak", FormColumnDescription = "Mayalama Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_KultrEkOr", FormColumnDescription = "Kültür Ekleme Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_TrygOprtAdi", FormColumnDescription = "Tereyağı Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY012_1_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_CigKreYagOr", FormColumnDescription = "Çiğ Kremanın Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_CigKremaPH", FormColumnDescription = "Çiğ Krema PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasKreYagOr", FormColumnDescription = "Pastörize Kremanın Yağ Oranı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PasKrePH", FormColumnDescription = "Pastörize Krema PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_LabPersAdi", FormColumnDescription = "Laboratuvar Personelinin Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY012_1", "KremaÜrünAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY012_1", "", chList: chList);
                    }
                    #endregion F SAP KY 012-1 Krema Ürün Analizi

                    #region F SAP KY 012-2 Krema Ürün Paketleme Analizi
                    if (!TableCreation.TableExists("AIF_FSAPKY012_2"))
                    {
                        TableCreation.CreateTable("AIF_FSAPKY012_2", "KremaÜrünPaketleme", SAPbobsCOM.BoUTBTableType.bott_Document);
                        TableCreation.CreateTable("AIF_FSAPKY012_2_1", "KremaÜrünPaketleme1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                        TableCreation.CreateTable("AIF_FSAPKY012_2_2", "KremaÜrünPaketleme2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 200, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2", "Kontrol1", "Kontrol 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 200, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_1", "PaketSic", "Paketleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_1", "UretimTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_1", "SonTukTar", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 200, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum1", "pH 1.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum2", "pH 2.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum3", "pH 3.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum4", "pH 4.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum5", "pH 5.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum6", "pH 6.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum7", "pH 7.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum8", "pH 8.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum9", "pH 9.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHOlcum10", "pH 10.Ölçüm", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price); 
                        TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    }
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar1", "pH 1.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar2", "pH 2.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar3", "pH 3.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar4", "pH 4.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar5", "pH 5.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar6", "pH 6.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar7", "pH 7.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar8", "pH 8.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar9", "pH 9.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHMiktar10", "pH 10.Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat1", "pH 1.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat2", "pH 2.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat3", "pH 3.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat4", "pH 4.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat5", "pH 5.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat6", "pH 6.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat7", "pH 7.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat8", "pH 8.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat9", "pH 9.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_FSAPKY012_2_2", "pHSaat10", "pH 10.Saat", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);

                  
                    if (!UdoCreation.UDOExists("AIF_FSAPKY012_2"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_PartiNo", "Parti No");
                        fields.Add("U_UrunKodu", "Ürün Kodu");
                        fields.Add("U_UrunTanimi", "Ürün Tanımı");
                        fields.Add("U_Aciklama", "Açıklama");
                        fields.Add("U_Tarih", "Tarih");
                        fields.Add("U_Kontrol1", "Kontrol 1");

                        List<FormColumn> fc = new List<FormColumn>();
                        List<ChildTable> chList = new List<ChildTable>();

                        ChildTable ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY012_2_1";

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PaketSic", FormColumnDescription = "Paketleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_UretimTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTar", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        ch = new ChildTable();
                        ch.TableName = "AIF_FSAPKY012_2_2";
                        fc = new List<FormColumn>();

                        fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                        fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                        fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum1", FormColumnDescription = "pH 1.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum2", FormColumnDescription = "pH 2.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum3", FormColumnDescription = "pH 3.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum4", FormColumnDescription = "pH 4.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum5", FormColumnDescription = "pH 5.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum6", FormColumnDescription = "pH 6.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum7", FormColumnDescription = "pH 7.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum8", FormColumnDescription = "pH 8.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum9", FormColumnDescription = "pH 9.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHOlcum10", FormColumnDescription = "pH 10.Ölçüm", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar1", FormColumnDescription = "pH 1.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar2", FormColumnDescription = "pH 2.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar3", FormColumnDescription = "pH 3.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar4", FormColumnDescription = "pH 4.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar5", FormColumnDescription = "pH 5.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar6", FormColumnDescription = "pH 6.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar7", FormColumnDescription = "pH 7.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar8", FormColumnDescription = "pH 8.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar9", FormColumnDescription = "pH 9.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHMiktar10", FormColumnDescription = "pH 10.Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat1", FormColumnDescription = "pH 1.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat2", FormColumnDescription = "pH 2.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat3", FormColumnDescription = "pH 3.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat4", FormColumnDescription = "pH 4.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat5", FormColumnDescription = "pH 5.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat6", FormColumnDescription = "pH 6.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat7", FormColumnDescription = "pH 7.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat8", FormColumnDescription = "pH 8.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat9", FormColumnDescription = "pH 9.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                        fc.Add(new FormColumn { FormColumnAlias = "U_pHSaat10", FormColumnDescription = "pH 10.Saat", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                        ch.FormColumn = fc;
                        chList.Add(ch);

                        UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY012_2", "KremaÜrünPaketleme", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY012_2", "", chList: chList);
                    }
                    #endregion F SAP KY 012-2 Krema Ürün Paketleme Analizi
                }

                #endregion 20R5DB TABLO VE ALANLARI

                #region ORTAK USER TABLOLAR

                if (!TableCreation.TableExists("AIF_AET"))
                {
                    TableCreation.CreateTable("AIF_AET", "Alet Ekipman Temizlik Takip", SAPbobsCOM.BoUTBTableType.bott_Document);
                    TableCreation.CreateTable("AIF_AET1", "Alet Ekipman Tem. Tkp Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                    TableCreation.CreateUserFields("@AIF_AET", "IstasyonKodu", "İstasyon Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_AET", "Istasyon", "İstasyon", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("@AIF_AET1", "AlanMakine", "Alan/Makine", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_AET1", "TemizlikSikligi", "Temizlik Sıklığı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_AET1", "KimyasalAdi", "Kimyasal Adı", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_AET1", "KimyasalMiktar", "Kimyasal Miktarı", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                }
                if (!UdoCreation.UDOExists("AIF_AET"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_IstasyonKodu", "Istasyon Kodu");
                    fields.Add("U_Istasyon", "Istasyon");

                    List<FormColumn> fc = new List<FormColumn>();
                    List<ChildTable> chList = new List<ChildTable>();

                    ChildTable ch = new ChildTable();
                    ch.TableName = "AIF_AET1";

                    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    fc.Add(new FormColumn { FormColumnAlias = "U_AlanMakine", FormColumnDescription = "Alan/Makine", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_TemizlikSikligi", FormColumnDescription = "Temizlik Sıklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_KimyasalAdi", FormColumnDescription = "Kimyasal Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_KimyasalMiktar", FormColumnDescription = "Kimyasal Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                    ch.FormColumn = fc;
                    chList.Add(ch);

                    UdoCreation.RegisterUDOWithChildTable("AIF_AET", "AIF_AET", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_AET", "", chList: chList);
                }

                if (!TableCreation.TableExists("AIF_ANALYSISPARAM"))
                {
                    TableCreation.CreateTable("AIF_ANALYSISPARAM", "Analiz Parametre Ekranı", SAPbobsCOM.BoUTBTableType.bott_Document);

                    TableCreation.CreateUserFieldsForDefaultForm("@AIF_ANALYSISPARAM", "StationCode", "İstasyon Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFieldsForDefaultForm("@AIF_ANALYSISPARAM", "StationName", "İstayon Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFieldsForDefaultForm("@AIF_ANALYSISPARAM", "RotaCode", "Rota Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFieldsForDefaultForm("@AIF_ANALYSISPARAM", "RotaName", "Rota Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFieldsForDefaultForm("@AIF_ANALYSISPARAM", "AnalysisCode", "Analiz Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: AnalizEkranlari);
                    TableCreation.CreateUserFieldsForDefaultForm("@AIF_ANALYSISPARAM", "AnalysisName", "Analiz Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFieldsForDefaultForm("@AIF_ANALYSISPARAM", "Active", "Aktif/Pasif", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                }

                if (!UdoCreation.UDOExists("AIF_ANALYSISPARAM"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "DocEntry");
                    fields.Add("U_StationCode", "İstasyon Kodu");
                    fields.Add("U_StationName", "İstayon Adı");
                    fields.Add("U_RotaCode", "Rota Kodu");
                    fields.Add("U_RotaName", "Rota Adı");
                    fields.Add("U_AnalysisCode", "Analiz Kodu");
                    fields.Add("U_AnalysisName", "Analiz Adı");
                    fields.Add("U_Active", "Aktif/Pasif");

                    UdoCreation.RegisterUDO("AIF_ANALYSISPARAM", "Analiz Parametre Ekranı", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_ANALYSISPARAM", "", SAPbobsCOM.BoYesNoEnum.tNO);
                }

                if (!TableCreation.TableExists("AIF_BOLUMLER"))
                {
                    TableCreation.CreateTable("AIF_BOLUMLER", "Bölümler", SAPbobsCOM.BoUTBTableType.bott_Document);
                    //TableCreation.CreateTable("AIF_BOLUMLER1", "Bölümler Detaylar", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                    TableCreation.CreateUserFields("@AIF_BOLUMLER", "BolumKodu", "Bölüm Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_BOLUMLER", "BolumAdi", "Bölüm Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                }
                if (!UdoCreation.UDOExists("AIF_BOLUMLER"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_BolumKodu", "Bölüm Kodu");
                    fields.Add("U_BolumAdi", "Bölüm Adı");

                    //List<FormColumn> fc = new List<FormColumn>();
                    //List<ChildTable> chList = new List<ChildTable>();

                    //ChildTable ch = new ChildTable();
                    //ch.TableName = "AIF_BOLUMLER1";

                    //fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    //fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    //fc.Add(new FormColumn { FormColumnAlias = "U_BolumKodu", FormColumnDescription = "Bölüm Kodu", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    //fc.Add(new FormColumn { FormColumnAlias = "U_BolumAdi", FormColumnDescription = "Bölüm Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                    //ch.FormColumn = fc;
                    //chList.Add(ch);

                    UdoCreation.RegisterUDOForDefaultForm("AIF_BOLUMLER", "AIF_BOLUMLER", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_BOLUMLER", "");
                }

                #region CIP1 kapatıldı
                //if (!TableCreation.TableExists("AIF_CIP1"))
                //{
                //    TableCreation.CreateTable("AIF_CIP1", "CIP Temizlik Tablosu 1", SAPbobsCOM.BoUTBTableType.bott_Document);
                //    TableCreation.CreateTable("AIF_CIP1_1", "CIP Tem.Tab. 1 Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                //    TableCreation.CreateUserFields("@AIF_CIP1", "IstasyonKodu", "İstasyon Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_CIP1", "Istasyon", "İstasyon", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                //    TableCreation.CreateUserFields("@AIF_CIP1_1", "KontrolAdi", "Kontrol Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_CIP1_1", "Deger", "Değer", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None, clist: DegerList);
                //}
                //if (!UdoCreation.UDOExists("AIF_CIP1"))
                //{
                //    fields.Clear();
                //    fields.Add("DocEntry", "Kod");
                //    fields.Add("U_IstasyonKodu", "Istasyon Kodu");
                //    fields.Add("U_Istasyon", "Istasyon");

                //    List<FormColumn> fc = new List<FormColumn>();
                //    List<ChildTable> chList = new List<ChildTable>();

                //    ChildTable ch = new ChildTable();
                //    ch.TableName = "AIF_CIP1_1";

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_KontrolAdi", FormColumnDescription = "Kontrol Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Deger", FormColumnDescription = "Değer", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    UdoCreation.RegisterUDOWithChildTable("AIF_CIP1", "AIF_CIP1", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_CIP1", "", chList: chList);
                //} 
                #endregion

                if (!TableCreation.TableExists("AIF_CIP2"))
                {
                    TableCreation.CreateTable("AIF_CIP2", "CIP Temizlik Tablosu 2", SAPbobsCOM.BoUTBTableType.bott_Document);
                    TableCreation.CreateTable("AIF_CIP2_1", "CIP Tem.Tab. 1 Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                    TableCreation.CreateUserFields("@AIF_CIP2", "IstasyonKodu", "İstasyon Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_CIP2", "Istasyon", "İstasyon", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("@AIF_CIP2_1", "KontrolAdi", "Kontrol Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                }
                if (!UdoCreation.UDOExists("AIF_CIP2"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_IstasyonKodu", "Istasyon Kodu");
                    fields.Add("U_Istasyon", "Istasyon");

                    List<FormColumn> fc = new List<FormColumn>();
                    List<ChildTable> chList = new List<ChildTable>();

                    ChildTable ch = new ChildTable();
                    ch.TableName = "AIF_CIP2_1";

                    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    fc.Add(new FormColumn { FormColumnAlias = "U_KontrolAdi", FormColumnDescription = "Kontrol Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                    ch.FormColumn = fc;
                    chList.Add(ch);

                    UdoCreation.RegisterUDOWithChildTable("AIF_CIP2", "AIF_CIP2", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_CIP2", "", chList: chList);
                }

                if (!TableCreation.TableExists("AIF_GUNLUKPERSPLAN"))
                {
                    TableCreation.CreateTable("AIF_GUNLUKPERSPLAN", "Günlük Personel Planlama", SAPbobsCOM.BoUTBTableType.bott_Document);
                    TableCreation.CreateTable("AIF_GUNLUKPERSPLAN1", "Günlük Pers.Plan Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN", "Aylar", "Aylar", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: Aylar);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN", "Yil", "Yıl", SAPbobsCOM.BoFieldTypes.db_Alpha, 4, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "PersonelNo", "Personel No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "PersonelAdi", "Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Bolum1", "Bölüm 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Bolum2", "Bölüm 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Bolum3", "Bölüm 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 254, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun1", "1.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun2", "2.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun3", "3.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun4", "4.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun5", "5.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun6", "6.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun7", "7.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun8", "8.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun9", "9.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun10", "10.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun11", "11.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun12", "12.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun13", "13.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun14", "14.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun15", "15.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun16", "16.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun17", "17.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun18", "18.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun19", "19.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun20", "20.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun21", "21.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun22", "22.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun23", "23.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun24", "24.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun25", "25.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun26", "26.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun27", "27.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun28", "28.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun29", "29.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun30", "30.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPERSPLAN1", "Gun31", "31.Gün", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                }
                if (!UdoCreation.UDOExists("AIF_GUNLUKPERSPLAN"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_Aylar", "Aylar");
                    fields.Add("U_Yil", "Yıl");

                    List<FormColumn> fc = new List<FormColumn>();
                    List<ChildTable> chList = new List<ChildTable>();

                    ChildTable ch = new ChildTable();
                    ch.TableName = "AIF_GUNLUKPERSPLAN1";

                    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    fc.Add(new FormColumn { FormColumnAlias = "U_PersonelNo", FormColumnDescription = "Personel No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_PersonelAdi", FormColumnDescription = "Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Bolum1", FormColumnDescription = "Bölüm 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Bolum2", FormColumnDescription = "Bölüm 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Bolum3", FormColumnDescription = "Bölüm 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun1", FormColumnDescription = "1.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun2", FormColumnDescription = "2.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun3", FormColumnDescription = "3.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun4", FormColumnDescription = "4.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun5", FormColumnDescription = "5.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun6", FormColumnDescription = "6.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun7", FormColumnDescription = "7.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun8", FormColumnDescription = "8.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun9", FormColumnDescription = "9.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun10", FormColumnDescription = "10.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun11", FormColumnDescription = "11.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun12", FormColumnDescription = "12.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun13", FormColumnDescription = "13.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun14", FormColumnDescription = "14.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun15", FormColumnDescription = "15.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun16", FormColumnDescription = "16.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun17", FormColumnDescription = "17.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun18", FormColumnDescription = "18.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun19", FormColumnDescription = "19.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun20", FormColumnDescription = "20.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun21", FormColumnDescription = "21.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun22", FormColumnDescription = "22.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun23", FormColumnDescription = "23.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun24", FormColumnDescription = "24.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun25", FormColumnDescription = "25.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun26", FormColumnDescription = "26.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun27", FormColumnDescription = "27.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun28", FormColumnDescription = "28.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun29", FormColumnDescription = "29.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun30", FormColumnDescription = "30.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Gun31", FormColumnDescription = "31.Gün", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    ch.FormColumn = fc;
                    chList.Add(ch);

                    UdoCreation.RegisterUDOWithChildTable("AIF_GUNLUKPERSPLAN", "AIF_GUNLUKPERSPLAN", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_GUNLUKPERSPLAN", "", chList: chList);
                }

                if (!TableCreation.TableExists("AIF_GNLKANLZPRM"))
                {
                    TableCreation.CreateTable("AIF_GNLKANLZPRM", "Günlük Analiz Parametre", SAPbobsCOM.BoUTBTableType.bott_Document);

                    TableCreation.CreateUserFields("@AIF_GNLKANLZPRM", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GNLKANLZPRM", "Kod", "Kod", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GNLKANLZPRM", "Deger1", "Değer 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GNLKANLZPRM", "Deger2", "Değer 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GNLKANLZPRM", "Deger3", "Değer 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                }

                if (!UdoCreation.UDOExists("AIF_GNLKANLZPRM"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_Aciklama", "Açıklama");
                    fields.Add("U_Kod", "Kod");
                    fields.Add("U_Deger1", "Değer 1");
                    fields.Add("U_Deger2", "Değer 2");
                    fields.Add("U_Deger3", "Değer 3");

                    UdoCreation.RegisterUDOForDefaultForm("AIF_GNLKANLZPRM", "AIF_GNLKANLZPRM", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_GNLKANLZPRM");
                }

                if (!TableCreation.TableExists("AIF_ROTA_DURUM"))
                {
                    TableCreation.CreateTable("AIF_ROTA_DURUM", "Rota Durum Takibi", SAPbobsCOM.BoUTBTableType.bott_Document);

                    TableCreation.CreateUserFields("@AIF_ROTA_DURUM", "UretimFisNo", "Üretim Fiş No", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_ROTA_DURUM", "RotaKodu", "Rota Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_ROTA_DURUM", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_ROTA_DURUM", "DurumKodu", "Durum Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_ROTA_DURUM", "DurunAciklama", "Durum Açıklaması", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                }

                if (!UdoCreation.UDOExists("AIF_ROTA_DURUM"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_UretimFisNo", "Üretim Fiş No");
                    fields.Add("U_RotaKodu", "Rota Kodu");
                    fields.Add("U_PartiNo", "Parti No");
                    fields.Add("U_DurumKodu", "Durum Kodu");
                    fields.Add("U_DurunAciklama", "Durum Açıklaması");

                    UdoCreation.RegisterUDOForDefaultForm("AIF_ROTA_DURUM", "AIF_ROTA_DURUM", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_ROTA_DURUM", "");
                }

                if (!TableCreation.TableExists("AIF_GUNLUKPLAN"))
                {
                    TableCreation.CreateTable("AIF_GUNLUKPLAN", "Günlük Pers.Planlama", SAPbobsCOM.BoUTBTableType.bott_Document);
                    TableCreation.CreateTable("AIF_GUNLUKPLAN1", "Günlük Pers.Plan.Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                    TableCreation.CreateUserFields("@AIF_GUNLUKPLAN", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                    TableCreation.CreateUserFields("@AIF_GUNLUKPLAN1", "PersonelNo", "Personel No", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPLAN1", "PersonelAdi", "Personel Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPLAN1", "Bolum1", "Bölüm 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPLAN1", "Bolum2", "Bölüm 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPLAN1", "Bolum3", "Bölüm 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_GUNLUKPLAN1", "Durum", "Durum", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                }

                if (!UdoCreation.UDOExists("AIF_GUNLUKPLAN"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_Tarih", "Tarih");

                    List<FormColumn> fc = new List<FormColumn>();
                    List<ChildTable> chList = new List<ChildTable>();

                    ChildTable ch = new ChildTable();
                    ch.TableName = "AIF_GUNLUKPLAN1";

                    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    fc.Add(new FormColumn { FormColumnAlias = "U_PersonelNo", FormColumnDescription = "Personel No", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_PersonelAdi", FormColumnDescription = "Personel Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Bolum1", FormColumnDescription = "Bölüm 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Bolum2", FormColumnDescription = "Bölüm 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Bolum3", FormColumnDescription = "Bölüm 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Durum", FormColumnDescription = "Durum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                    ch.FormColumn = fc;
                    chList.Add(ch);

                    UdoCreation.RegisterUDOWithChildTable("AIF_GUNLUKPLAN", "AIF_GUNLUKPLAN", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_GUNLUKPLAN", "", chList: chList);
                }

                if (!TableCreation.TableExists("AIF_URT_PART"))
                {
                    TableCreation.CreateTable("AIF_URT_PART", "Üretim Parti Uretme", SAPbobsCOM.BoUTBTableType.bott_Document);
                    TableCreation.CreateTable("AIF_URT_PART1", "Üretim Parti Uretme Detay", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                    TableCreation.CreateUserFields("@AIF_URT_PART", "UretimSipNo", "Üretim Sipariş No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_URT_PART", "UretimSipTar", "Üretim Sipariş Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                    TableCreation.CreateUserFields("@AIF_URT_PART", "UretimSipMik", "Üretim Sipariş Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_URT_PART", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_URT_PART", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);

                    TableCreation.CreateUserFields("@AIF_URT_PART1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_URT_PART1", "Miktar", "Miktar", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                    TableCreation.CreateUserFields("@AIF_URT_PART1", "PartiKatSayi", "Parti Kat Sayı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Rate);
                    //TableCreation.CreateUserFields("@AIF_URT_PART1", "U_PartiBasSaati", "Parti Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Date, 10, SAPbobsCOM.BoFldSubTypes.st_Time);
                    //TableCreation.CreateUserFields("@AIF_URT_PART1", "U_PartiBitSaati", "Parti Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Date, 10, SAPbobsCOM.BoFldSubTypes.st_Time);
                    TableCreation.CreateUserFields("@AIF_URT_PART1", "PartiBasSaati", "Parti Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_URT_PART1", "PartiBitSaati", "Parti Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                    TableCreation.CreateUserFields("@AIF_URT_PART1", "Durum", "Durum", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);

                }

                if (!UdoCreation.UDOExists("AIF_URT_PART"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_UretimSipNo", "Üretim Sipariş No");
                    fields.Add("U_UretimSipTar", "Üretim Sipariş Tarihi");
                    fields.Add("U_UretimSipMik", "Üretim Sipariş Miktarı");
                    fields.Add("U_UrunKodu", "Ürün Kodu");
                    fields.Add("U_UrunTanimi", "Ürün Tanımı");

                    List<FormColumn> fc = new List<FormColumn>();
                    List<ChildTable> chList = new List<ChildTable>();

                    ChildTable ch = new ChildTable();
                    ch.TableName = "AIF_URT_PART1";

                    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                    fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Miktar", FormColumnDescription = "Miktar", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_PartiKatSayi", FormColumnDescription = "Parti Kat Sayı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_PartiBasSaati", FormColumnDescription = "Parti Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_PartiBitSaati", FormColumnDescription = "Parti Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                    fc.Add(new FormColumn { FormColumnAlias = "U_Durum", FormColumnDescription = "Durum", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                    ch.FormColumn = fc;
                    chList.Add(ch);

                    UdoCreation.RegisterUDOWithChildTable("AIF_URT_PART", "AIF_URT_PART", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_URT_PART", "", chList: chList);
                }

                if (!TableCreation.TableExists("AIF_UVT_PARAM"))
                {
                    TableCreation.CreateTable("AIF_UVT_PARAM", "Genel Parametreler", SAPbobsCOM.BoUTBTableType.bott_Document);

                    TableCreation.CreateUserFields("@AIF_UVT_PARAM", "UrtPrtSekli", "Üretim Partilendirme Şekli", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                }
                if (!UdoCreation.UDOExists("AIF_UVT_PARAM"))
                {
                    fields.Clear();
                    fields.Add("DocEntry", "Kod");
                    fields.Add("U_UrtPrtSekli", "Üretim Partilendirme Şekli");

                    UdoCreation.RegisterUDOForDefaultForm("AIF_UVT_PARAM", "Genel Parametreler", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_UVT_PARAM", "");
                }

                #endregion ORTAK USER TABLOLAR

                #region SİSTEM ORTAK TABLOLAR 

                TableCreation.CreateUserFields("OCLG", "RotaCode", "Rota Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OCLG", "LaborCode", "İşçilik Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OCLG", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OCLG", "KullaniciId", "Kullanıcı Id", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);

                TableCreation.CreateUserFields("OHEM", "UretimCalisani", "Üretim Çalışanı mı?", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None, clist: EvetHayir);

                TableCreation.CreateUserFields("OIGE", "RotaCode", "Rota Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OIGE", "BatchNumber", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);

                TableCreation.CreateUserFields("OITM", "PaletKoli", "Palet İçi Koli", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OITM", "KoliMiktari", "Koli Miktarı", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OITM", "PALET", "Palet Miktarı", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OITM", "UrnCap", "Ürün Çap", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None, clist: urunCap);
                TableCreation.CreateUserFields("OITM", "UVTUrunTipi", "UVT Ürün Tipi", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None, clist: urunTipleri);
                TableCreation.CreateUserFields("OITM", "UVTVarsayilanDepo", "Üretimden Varsayılan Depo", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OITM", "UVTFireDepo", "Üretim Fire Depo", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OITM", "UVTNumuneDepo", "Üretimden Numune Depo", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OITM", "SarfOran", "Sarf Oranı", SAPbobsCOM.BoFieldTypes.db_Float, 2, SAPbobsCOM.BoFldSubTypes.st_Percentage);
                TableCreation.CreateUserFields("OITM", "SKTGun", "Son Kullanma Tarihi(Gün)", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OITM", "RayicBedel", "Rayiç Bedel", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);

                TableCreation.CreateUserFields("OITT", "PartiMiktari", "Bir Parti Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Quantity);
                TableCreation.CreateUserFields("OITT", "ISTASYON", "İstasyon", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None, clist: Istasyonlar);

                TableCreation.CreateUserFields("OPDN", "KullaniciId", "Kullanıcı Id", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);

                TableCreation.CreateUserFields("OWHS", "DepoTipi", "Depo Tipi", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, clist: DepoTipi);

                TableCreation.CreateUserFields("OWOR", "PartiBelgeNo", "Parti Belge No", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OWOR", "ISTASYON", "İstasyon", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None, clist: Istasyonlar);
                TableCreation.CreateUserFields("OWOR", "GrupSipNo", "Grup Sipariş No", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_None);
                TableCreation.CreateUserFields("OWOR", "PartDahilEtme", "Partilendirmeye Dahil Etme", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, clist: EvetHayir, DefaultValue: "Hayır");

                TableCreation.CreateUserFields("OWTQ", "UretimdenGonderildi", "Üretimden Gönderildi", SAPbobsCOM.BoFieldTypes.db_Alpha, 1, SAPbobsCOM.BoFldSubTypes.st_None);

                #endregion SİSTEM ORTAK TABLOLAR

                #region 20R5DB - ÇIKARILAN EKRANLAR

                #region F SAP KY 004-3 UF Ürün Dolum Analiz
                //if (!TableCreation.TableExists("AIF_FSAPKY004_3"))
                //{
                //    TableCreation.CreateTable("AIF_FSAPKY004_3", "UFUrunDolumAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                //    TableCreation.CreateTable("AIF_FSAPKY004_2_1", "UFUrunDolumAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                //    TableCreation.CreateTable("AIF_FSAPKY004_2_2", "UFUrunDolumAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                //    TableCreation.CreateTable("AIF_FSAPKY004_2_3", "UFUrunDolumAnaliz3", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "PaketSic", "Paketleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "UretTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "SonTukTar", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek8", "Örnek 8", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek9", "Örnek 9", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "Ornek10", "Örnek 10", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY004_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //}
                //if (!UdoCreation.UDOExists("AIF_FSAPKY004_2"))
                //{
                //    fields.Clear();
                //    fields.Add("DocEntry", "Kod");
                //    fields.Add("U_PartiNo", "Parti No");
                //    fields.Add("U_UrunKodu", "Ürün Kodu");
                //    fields.Add("U_UrunTanimi", "Ürün Tanımı");
                //    fields.Add("U_Aciklama", "Açıklama");
                //    fields.Add("U_Tarih", "Tarih");

                //    List<FormColumn> fc = new List<FormColumn>();
                //    List<ChildTable> chList = new List<ChildTable>();

                //    ChildTable ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY004_2_1";

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PaketSic", FormColumnDescription = "Paketleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_UretTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTar", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY004_2_2";
                //    fc = new List<FormColumn>();

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek8", FormColumnDescription = "Örnek 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek9", FormColumnDescription = "Örnek 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek10", FormColumnDescription = "Örnek 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY004_2", "UFUrunDolumAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY004_2", "", chList: chList);
                //}
                #endregion F SAP KY 004-3 UF Ürün Dolum Analiz

                #region F SAP KY 005-1 - YOĞURT PASTÖRİZASYON ANALİZ
                //if (!TableCreation.TableExists("AIF_FSAPKY005_1"))
                //{
                //    TableCreation.CreateTable("AIF_FSAPKY005_1", "YogurtPastorizasyonAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                //    TableCreation.CreateTable("AIF_FSAPKY005_1_1", "YogurtPastorizasyonAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                //    TableCreation.CreateTable("AIF_FSAPKY005_1_2", "YogurtPastorizasyonAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "BasSaati", "Başlangıç Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "PasSicaklik", "Pastorizasyon Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "PasCikis", "Pastorizasyon Çıkış", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "HolderSuresi", "Holder Süresi", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "HmjBasinc", "Homojenizasyon Basınç", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "CigSutMik", "Çiğ Süt Müktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "CekilenKrema", "Çekilen Krema", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "EklnKrema", "Eklenen Krema", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "StandSutMik", "Stand. Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "SutTozMik", "Süt Tozu Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "BitSaat", "Bitiş Saati", SAPbobsCOM.BoFieldTypes.db_Alpha, 5, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_2", "CigSutDepTnk", "Çiğ Süt Alındığı Dep.Tankı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_2", "AlCigSutMik", "Alınan Çiğ Süt Miktarı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_2", "CigSutPH", "Çiğ Süt PH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_2", "CigSutSH", "Çiğ Süt SH", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_2", "CigSutKM", "Çiğ Süt KM", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_2", "CigSutYag", "Çiğ Süt Yağı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY005_1_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //}
                //if (!UdoCreation.UDOExists("AIF_FSAPKY005_1"))
                //{
                //    fields.Clear();
                //    fields.Add("DocEntry", "Kod");
                //    fields.Add("U_PartiNo", "Parti No");
                //    fields.Add("U_UrunKodu", "Ürün Kodu");
                //    fields.Add("U_UrunTanimi", "Ürün Tanımı");
                //    fields.Add("U_Aciklama", "Açıklama");
                //    fields.Add("U_Tarih", "Tarih");

                //    List<FormColumn> fc = new List<FormColumn>();
                //    List<ChildTable> chList = new List<ChildTable>();

                //    ChildTable ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY005_1_1";

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_BasSaati", FormColumnDescription = "Başlangıç Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PasSicaklik", FormColumnDescription = "Pastorizasyon Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PasCikis", FormColumnDescription = "Pastorizasyon Çıkış", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_HolderSuresi", FormColumnDescription = "Holder Süresi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_HmjBasinc", FormColumnDescription = "Homojenizasyon Basınç", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_CigSutMik", FormColumnDescription = "Çiğ Süt Müktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_CekilenKrema", FormColumnDescription = "Çekilen Krema", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_EklnKrema", FormColumnDescription = "Eklenen Krema", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_StandSutMik", FormColumnDescription = "Stand. Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_SutTozMik", FormColumnDescription = "Süt Tozu Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_BitSaat", FormColumnDescription = "Bitiş Saati", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY005_1_2";
                //    fc = new List<FormColumn>();

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_CigSutDepTnk", FormColumnDescription = "Çiğ Süt Alındığı Dep.Tankı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_AlCigSutMik", FormColumnDescription = "Alınan Çiğ Süt Miktarı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_CigSutPH", FormColumnDescription = "Çiğ Süt PH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_CigSutSH", FormColumnDescription = "Çiğ Süt SH", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_CigSutKM", FormColumnDescription = "Çiğ Süt KM", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_CigSutYag", FormColumnDescription = "Çiğ Süt Yağı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY005_1", "YogurtPastorizasyonAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY005_1", "", chList: chList);
                //}
                #endregion F SAP KY 005-1 - YOĞURT PASTÖRİZASYON ANALİZ

                #region F SAP KY 006-2 Kaymalı Yoğurt Paketmele Analiz
                //if (!TableCreation.TableExists("AIF_FSAPKY006_2"))
                //{
                //    TableCreation.CreateTable("AIF_FSAPKY006_2", "KaymaliYogurtPaketmeleAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                //    TableCreation.CreateTable("AIF_FSAPKY006_2_1", "KaymaliYogurtPaketmeleAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                //    TableCreation.CreateTable("AIF_FSAPKY006_2_2", "KaymaliYogurtPaketmeleAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_1", "PaketSic", "Paketleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_1", "UretimTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_1", "SonTukTar", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek8", "Örnek 8", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek9", "Örnek 9", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "Ornek10", "Örnek 10", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY006_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //}
                //if (!UdoCreation.UDOExists("AIF_FSAPKY006_2"))
                //{
                //    fields.Clear();
                //    fields.Add("DocEntry", "Kod");
                //    fields.Add("U_PartiNo", "Parti No");
                //    fields.Add("U_UrunKodu", "Ürün Kodu");
                //    fields.Add("U_UrunTanimi", "Ürün Tanımı");
                //    fields.Add("U_Aciklama", "Açıklama");
                //    fields.Add("U_Tarih", "Tarih");

                //    List<FormColumn> fc = new List<FormColumn>();
                //    List<ChildTable> chList = new List<ChildTable>();

                //    ChildTable ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY006_2_1";

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PaketSic", FormColumnDescription = "Paketleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_UretimTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTar", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY006_2_2";
                //    fc = new List<FormColumn>();

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek8", FormColumnDescription = "Örnek 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek9", FormColumnDescription = "Örnek 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek10", FormColumnDescription = "Örnek 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY006_2", "AIF_FSAPKY006_2", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY006_2", "", chList: chList);
                //}
                #endregion F SAP KY 006-2 Kaymalı Yoğurt Paketmele Analiz

                #region F SAP KY 008-2 Lor Paketleme
                //if (!TableCreation.TableExists("AIF_FSAPKY008_2"))
                //{
                //    TableCreation.CreateTable("AIF_FSAPKY008_2", "AIF_FSAPKY008_2", SAPbobsCOM.BoUTBTableType.bott_Document);
                //    TableCreation.CreateTable("AIF_FSAPKY008_2_1", "AIF_FSAPKY008_2_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                //    TableCreation.CreateTable("AIF_FSAPKY008_2_2", "AIF_FSAPKY008_2_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2_1", "PaketSic", "Paketleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2_1", "UretimTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2_1", "SonTukTar", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2_1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY008_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek8", "Örnek 8", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek9", "Örnek 9", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "Ornek10", "Örnek 10", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //TableCreation.CreateUserFields("@AIF_FSAPKY008_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //}
                //if (!UdoCreation.UDOExists("AIF_FSAPKY008_2"))
                //{
                //    fields.Clear();
                //    fields.Add("DocEntry", "Kod");
                //    fields.Add("U_PartiNo", "Parti No");
                //    fields.Add("U_UrunKodu", "Ürün Kodu");
                //    fields.Add("U_UrunTanimi", "Ürün Tanımı");
                //    fields.Add("U_Aciklama", "Açıklama");
                //    fields.Add("U_Tarih", "Tarih");

                //    List<FormColumn> fc = new List<FormColumn>();
                //    List<ChildTable> chList = new List<ChildTable>();

                //    ChildTable ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY008_2_1";

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PaketSic", FormColumnDescription = "Paketleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_UretimTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTar", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY008_2_2";
                //    fc = new List<FormColumn>();

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek8", FormColumnDescription = "Örnek 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek9", FormColumnDescription = "Örnek 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek10", FormColumnDescription = "Örnek 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY008_2", "AIF_FSAPKY008_2", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY008_2", "", chList: chList);
                //}
                #endregion F SAP KY 008-2 Lor Paketleme

                #region F SAP KY 010-2 Tereyağı Ürün Paketleme Analizi
                //if (!TableCreation.TableExists("AIF_FSAPKY010_2"))
                //{
                //    TableCreation.CreateTable("AIF_FSAPKY010_2", "TereyagiUrunPaketlemeAnaliz", SAPbobsCOM.BoUTBTableType.bott_Document);
                //    TableCreation.CreateTable("AIF_FSAPKY010_2_1", "TereyagiUrunPaketlemeAnaliz1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                //    TableCreation.CreateTable("AIF_FSAPKY010_2_2", "TereyagiUrunPaketlemeAnaliz2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 200, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_1", "PaketSic", "Paketleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_1", "UretimTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_1", "SonTukTar", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek8", "Örnek 8", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek9", "Örnek 9", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "Ornek10", "Örnek 10", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY010_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //}
                //if (!UdoCreation.UDOExists("AIF_FSAPKY010_2"))
                //{
                //    fields.Clear();
                //    fields.Add("DocEntry", "Kod");
                //    fields.Add("U_PartiNo", "Parti No");
                //    fields.Add("U_UrunKodu", "Ürün Kodu");
                //    fields.Add("U_UrunTanimi", "Ürün Tanımı");
                //    fields.Add("U_Aciklama", "Açıklama");
                //    fields.Add("U_Tarih", "Tarih");

                //    List<FormColumn> fc = new List<FormColumn>();
                //    List<ChildTable> chList = new List<ChildTable>();

                //    ChildTable ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY010_2_1";

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PaketSic", FormColumnDescription = "Paketleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_UretimTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTar", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY010_2_2";
                //    fc = new List<FormColumn>();

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek8", FormColumnDescription = "Örnek 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek9", FormColumnDescription = "Örnek 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek10", FormColumnDescription = "Örnek 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY010_2", "TereyagiUrunPaketlemeAnaliz", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY010_2", "", chList: chList);
                //}
                #endregion F SAP KY 010-2 F SAP KY 010-2 Tereyağı Ürün Paketleme Analizi

                #region F SAP KY 011-2 Kaymak Ürün Paketleme
                //if (!TableCreation.TableExists("AIF_FSAPKY011_2"))
                //{
                //    TableCreation.CreateTable("AIF_FSAPKY011_2", "AIF_FSAPKY011_2", SAPbobsCOM.BoUTBTableType.bott_Document);
                //    TableCreation.CreateTable("AIF_FSAPKY011_2_1", "AIF_FSAPKY011_2_1", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);
                //    TableCreation.CreateTable("AIF_FSAPKY011_2_2", "AIF_FSAPKY011_2_2", SAPbobsCOM.BoUTBTableType.bott_DocumentLines);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2", "PartiNo", "Parti No", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2", "UrunKodu", "Ürün Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2", "UrunTanimi", "Ürün Tanımı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2", "Aciklama", "Açıklama", SAPbobsCOM.BoFieldTypes.db_Memo, 1, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2", "Tarih", "Tarih", SAPbobsCOM.BoFieldTypes.db_Date);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_1", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_1", "PaketSic", "Paketleme Sıcaklığı", SAPbobsCOM.BoFieldTypes.db_Float, 10, SAPbobsCOM.BoFldSubTypes.st_Price);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_1", "UretimTar", "Üretim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_1", "SonTukTar", "Son Tüketim Tarihi", SAPbobsCOM.BoFieldTypes.db_Date);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_1", "PartiNo", "Parti Numarası", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_1", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "UrunAdi", "Ürün Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 150, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek1", "Örnek 1", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek2", "Örnek 2", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek3", "Örnek 3", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek4", "Örnek 4", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek5", "Örnek 5", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek6", "Örnek 6", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek7", "Örnek 7", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek8", "Örnek 8", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek9", "Örnek 9", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "Ornek10", "Örnek 10", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);
                //    TableCreation.CreateUserFields("@AIF_FSAPKY011_2_2", "OprtAdi", "Operatör Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 100, SAPbobsCOM.BoFldSubTypes.st_None);

                //}
                //if (!UdoCreation.UDOExists("AIF_FSAPKY011_2"))
                //{
                //    fields.Clear();
                //    fields.Add("DocEntry", "Kod");
                //    fields.Add("U_PartiNo", "Parti No");
                //    fields.Add("U_UrunKodu", "Ürün Kodu");
                //    fields.Add("U_UrunTanimi", "Ürün Tanımı");
                //    fields.Add("U_Aciklama", "Açıklama");
                //    fields.Add("U_Tarih", "Tarih");

                //    List<FormColumn> fc = new List<FormColumn>();
                //    List<ChildTable> chList = new List<ChildTable>();

                //    ChildTable ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY011_2_1";

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PaketSic", FormColumnDescription = "Paketleme Sıcaklığı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_UretimTar", FormColumnDescription = "Üretim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_SonTukTar", FormColumnDescription = "Son Tüketim Tarihi", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_PartiNo", FormColumnDescription = "Parti Numarası", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    ch = new ChildTable();
                //    ch.TableName = "AIF_FSAPKY011_2_2";
                //    fc = new List<FormColumn>();

                //    fc.Add(new FormColumn { FormColumnAlias = "DocEntry", FormColumnDescription = "DocEntry", Editable = SAPbobsCOM.BoYesNoEnum.tNO });
                //    fc.Add(new FormColumn { FormColumnAlias = "LineId", FormColumnDescription = "LineId", Editable = SAPbobsCOM.BoYesNoEnum.tNO });

                //    fc.Add(new FormColumn { FormColumnAlias = "U_UrunAdi", FormColumnDescription = "Ürün Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek1", FormColumnDescription = "Örnek 1", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek2", FormColumnDescription = "Örnek 2", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek3", FormColumnDescription = "Örnek 3", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek4", FormColumnDescription = "Örnek 4", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek5", FormColumnDescription = "Örnek 5", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek6", FormColumnDescription = "Örnek 6", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek7", FormColumnDescription = "Örnek 7", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek8", FormColumnDescription = "Örnek 8", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek9", FormColumnDescription = "Örnek 9", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_Ornek10", FormColumnDescription = "Örnek 10", Editable = SAPbobsCOM.BoYesNoEnum.tYES });
                //    fc.Add(new FormColumn { FormColumnAlias = "U_OprtAdi", FormColumnDescription = "Operatör Adı", Editable = SAPbobsCOM.BoYesNoEnum.tYES });

                //    ch.FormColumn = fc;
                //    chList.Add(ch);

                //    UdoCreation.RegisterUDOWithChildTable("AIF_FSAPKY011_2", "AIF_FSAPKY011_2", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_FSAPKY011_2", "", chList: chList);
                //}
                #endregion F SAP KY 011-2 Kaymak Ürün Paketleme

                #endregion 20R5DB - ÇIKARILAN EKRANLAR
            }
        }
    }
}