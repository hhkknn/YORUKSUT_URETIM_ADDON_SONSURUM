﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Xml;
using AIF.ObjectsDLL;
using AIF.ObjectsDLL.Events;
using AIF.ObjectsDLL.Lib;
using AIF.UVT.SAPB1.ClassLayer;
using SAPbouiCOM.Framework;

namespace AIF.UVT.SAPB1
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback +=
    (se, cert, chain, sslerror) =>
    {
        return true;
    };
                ConstVariables.oFnc.SetApplication();

                if (!(ConstVariables.oFnc.CookieConnect() == 0))
                {
                    Handler.SAPApplication.MessageBox("DI Api Conection Failed");
                    System.Environment.Exit(0);
                }
                if (!(ConstVariables.oFnc.ConnectionContext() == 0))
                {
                    Handler.SAPApplication.MessageBox("Failed to Connect Company");
                    System.Environment.Exit(0);
                }

                //try
                //{
                //    XmlDocument XmlDoc = null;

                //    mKod = System.Configuration.ConfigurationManager.AppSettings["MusteriKodu"];
                //    if (mKod == "10B1C4")
                //    {
                //        XmlDoc = ConstVariables.oFnc.getXMLDocument(Assembly.GetExecutingAssembly().GetManifestResourceStream("AIF.UVT.SAPB1.FormsView.Menu.xml"));
                //    }
                //    else if (mKod == "20R5DB")
                //    {
                //        XmlDoc = ConstVariables.oFnc.getXMLDocument(Assembly.GetExecutingAssembly().GetManifestResourceStream("AIF.UVT.SAPB1.FormsView.Menu2.xml"));
                //    }

                //    ConstVariables.oFnc.XmlMenuImport(XmlDoc);
                //    Handler.SAPApplication.LoadBatchActions(XmlDoc.InnerXml);

                //    //Handler.SAPApplication.Menus.RemoveEx("");
                //}
                //catch (Exception ex)
                //{
                //    System.Windows.Forms.MessageBox.Show(ex.ToString() + Environment.NewLine + "ExitThread");
                //    System.Windows.Forms.Application.ExitThread();
                //}

                #region CONSTRNG TABLOSU - ŞİRKET BİLGİLERİ - SİSTEMDE İLK KURULACAK VE DOLDURULACAK TABLODUR.MÜŞTERİ KODU ALANI BOŞ OLURSA ALAN VE TABLO AÇILMAZ.
                try
                {
                    Dictionary<string, string> fields = new Dictionary<string, string>();

                    List<ComboList> MusteriKodlari = new List<ComboList>();
                    MusteriKodlari.Add(new ComboList { Value = "10", Desc = "10B1C4" });
                    MusteriKodlari.Add(new ComboList { Value = "20", Desc = "20R5DB" });

                    if (!TableCreation.TableExists("AIF_UVT_CONSTRNG"))
                    {
                        TableCreation.CreateTable("AIF_UVT_CONSTRNG", "Database Bağlantı Bilgileri", SAPbobsCOM.BoUTBTableType.bott_Document);

                        TableCreation.CreateUserFields("@AIF_UVT_CONSTRNG", "CompanyDB", "Şirket Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UVT_CONSTRNG", "CompanyDBCode", "Şirket Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UVT_CONSTRNG", "LicenseServer", "Lisans Server", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UVT_CONSTRNG", "Server", "Server", SAPbobsCOM.BoFieldTypes.db_Alpha, 30, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UVT_CONSTRNG", "UserName", "Kullanıcı Adı", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UVT_CONSTRNG", "Password", "Şifre", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UVT_CONSTRNG", "DbServerType", "Veritabanı Tipi", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None);
                        TableCreation.CreateUserFields("@AIF_UVT_CONSTRNG", "MusteriKodu", "Müşteri Kodu", SAPbobsCOM.BoFieldTypes.db_Alpha, 20, SAPbobsCOM.BoFldSubTypes.st_None, clist: MusteriKodlari);
                    }

                    if (!UdoCreation.UDOExists("AIF_UVT_CONSTRNG"))
                    {
                        fields.Clear();
                        fields.Add("DocEntry", "Kod");
                        fields.Add("U_CompanyDB", "Şirket Adı");
                        fields.Add("U_CompanyDBCode", "Şirket Kodu");
                        fields.Add("U_LicenseServer", "Lisans Server");
                        fields.Add("U_Server", "Server");
                        fields.Add("U_UserName", "Kullanıcı Adı");
                        fields.Add("U_Password", "Şifre");
                        fields.Add("U_DbServerType", "Veritabanı Tipi");
                        fields.Add("U_MusteriKodu", "Müşteri Kodu"); //10B1C4 = OTAT KODU   //20R5DB = YÖRÜK KODU

                        UdoCreation.RegisterUDOForDefaultForm("AIF_UVT_CONSTRNG", "AIF_UVT_CONSTRNG", SAPbobsCOM.BoUDOObjType.boud_Document, fields, "AIF_UVT_CONSTRNG", "");
                    }

                    #region AIF_UVT_CONSTRNG TABLOSUNDAKİ MÜŞTERİ KODU SORGUSU

                    ConstVariables.oRecordset = (SAPbobsCOM.Recordset)ConstVariables.oCompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                    string sql = "SELECT \"U_MusteriKodu\" FROM \"@AIF_UVT_CONSTRNG\" ";

                    ConstVariables.oRecordset.DoQuery(sql);

                    if (ConstVariables.oRecordset.RecordCount > 0)
                    {
                        mKod = ConstVariables.oRecordset.Fields.Item("U_MusteriKodu").Value.ToString();

                        if (mKod == "10")
                        {
                            mKod = "10B1C4";
                        }

                        if (mKod == "20")
                        {
                            mKod = "20R5DB";
                        }
                    }
                    #endregion AIF_UVT_CONSTRNG TABLOSUNDAKİ MÜŞTERİ KODU SORGUSU

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ConstVariables.oRecordset);
                    ConstVariables.oRecordset = null;
                    GC.Collect();


                    //ConstVariables.oRecordset = (SAPbobsCOM.Recordset)ConstVariables.oCompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString() + Environment.NewLine + "ExitThread");
                    System.Windows.Forms.Application.ExitThread();
                }
                #endregion CONSTRNG TABLOSU - ŞİRKET BİLGİLERİ - SİSTEMDE İLK KURULACAK VE DOLDURULACAK TABLODUR.MÜŞTERİ KODU ALANI BOŞ OLURSA ALAN VE TABLO AÇILMAZ.

                #region MKOD İLE MENÜ SEÇİMİ
                try
                {
                    XmlDocument XmlDoc = null;

                    if (mKod == "" || mKod == null)
                    {
                        XmlDoc = ConstVariables.oFnc.getXMLDocument(Assembly.GetExecutingAssembly().GetManifestResourceStream("AIF.UVT.SAPB1.FormsView.MenuSirket.xml"));
                        //Handler.SAPApplication.MessageBox("AIF_UVT_CONSTRNG tablosunda müşteri kodu eksik olduğundan işleme devam edilemez.");
                    }

                    if (mKod == "10B1C4")
                    {
                        XmlDoc = ConstVariables.oFnc.getXMLDocument(Assembly.GetExecutingAssembly().GetManifestResourceStream("AIF.UVT.SAPB1.FormsView.Menu_10B1C4.xml"));
                    }
                    else if (mKod == "20R5DB")
                    {
                        XmlDoc = ConstVariables.oFnc.getXMLDocument(Assembly.GetExecutingAssembly().GetManifestResourceStream("AIF.UVT.SAPB1.FormsView.Menu_20R5DB.xml"));
                    }

                    ConstVariables.oFnc.XmlMenuImport(XmlDoc);
                    Handler.SAPApplication.LoadBatchActions(XmlDoc.InnerXml);

                    //Handler.SAPApplication.Menus.RemoveEx("");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString() + Environment.NewLine + "ExitThread");
                    System.Windows.Forms.Application.ExitThread();
                }
                #endregion MKOD İLE MENÜ SEÇİMİ

                #region CREATETABLE
                try
                {
                    if (mKod != "" && mKod != null)
                    {
                        DataTables.CreateTables.CreateAndCheckFields();
                    }
                }
                catch (Exception)
                {
                }
                #endregion CREATETABLE

                //SAPbouiCOM.Form form = Handler.SAPApplication.Forms.ActiveForm;
                //string xml = form.GetAsXML();

                //SAPbouiCOM.Form aaa = Handler.SAPApplication.Forms.GetForm("0", 0);
                //aaa.Visible = false;
                nfi.NumberDecimalSeparator = ".";

                ConstVariables.oRecordset = (SAPbobsCOM.Recordset)ConstVariables.oCompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                ConstVariables.oRecordset.DoQuery("Select \"DecSep\" from \"OADM\"");

                SAPnfi = ConstVariables.oRecordset.Fields.Item(0).Value.ToString();

                //UVTServiceSoapClient UVTServiceSoapClient = new UVTServiceSoapClient();
                //var connectresp = UVTServiceSoapClient.Login("", "", ConstVariables.oCompanyObject.CompanyDB);

                //Application.SBO_Application.AppEvent += new SAPbouiCOM._IApplicationEvents_AppEventEventHandler(SBO_Application_AppEvent);
                Handler.SAPApplication.AppEvent += new SAPbouiCOM._IApplicationEvents_AppEventEventHandler(SBO_Application_AppEvent);

                #region sistem ayracı için eklenmiştir
                Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");

                ConstVariables.oRecordset = (SAPbobsCOM.Recordset)ConstVariables.oCompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                ConstVariables.oRecordset1 = (SAPbobsCOM.Recordset)ConstVariables.oCompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                ConstVariables.oRecordset.DoQuery("Select \"DecSep\",\"ThousSep\" from \"OADM\" ");

                decimalSeperator = ConstVariables.oRecordset.Fields.Item("DecSep").Value.ToString();
                thousandsSeperator = ConstVariables.oRecordset.Fields.Item("ThousSep").Value.ToString(); 
                #endregion
                System.Windows.Forms.Application.Run();


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static NumberFormatInfo nfi = new NumberFormatInfo();
        public static string SAPnfi = "";
        public static string mKod;
        public static string decimalSeperator = "";
        public static string thousandsSeperator = "";
        private static void SBO_Application_AppEvent(SAPbouiCOM.BoAppEventTypes EventType)
        {
            switch (EventType)
            {
                case SAPbouiCOM.BoAppEventTypes.aet_ShutDown:
                    //Exit Add-On
                    System.Windows.Forms.Application.Exit();
                    break;

                case SAPbouiCOM.BoAppEventTypes.aet_CompanyChanged:
                    System.Windows.Forms.Application.Exit();
                    break;

                case SAPbouiCOM.BoAppEventTypes.aet_FontChanged:
                    break;

                case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged:
                    break;

                case SAPbouiCOM.BoAppEventTypes.aet_ServerTerminition:
                    System.Windows.Forms.Application.Exit();
                    break;

                default:
                    break;
            }
        }
    }
}