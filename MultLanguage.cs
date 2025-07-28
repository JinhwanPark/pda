using System;

using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Text;

using System.Xml;
using System.IO;
using System.Data;
using System.Windows.Forms;


namespace DYPI_WMS_PDA
{
        public class MultLanguage
        {
            public string sFullFailName = @"/Program Files/DYPI_WMS_PDA_CAB/Language.xml";
            public string sDefaultContryType = "us";            //현재 선택된 언어의 종류
            public string sContryType = "kr";                   //프로그램에서 사용하고 있는 다국어

            public string sWord = "word";

            private string sKorea = "kr";
            private string sUSA = "us";
            private string sJapan = "ja";
            private string sIndia = "id";
            private string sChina = "ch";
            private string sGermany = "gm";
            private string sSpanish = "es";


            private Dictionary<string, string> dicLanguage = new Dictionary<string, string>();
            private Dictionary<string, string> dicDefaultLanguage = new Dictionary<string, string>();

            public enum ContryType
            {

                USA = 0,
                Korea= 1,
                Japan = 2,
                India = 3,
                China = 4,
                Germany = 5,
                Spanish = 6
            }

            public MultLanguage(ContryType ct, string DB)
            {
                SetLanguageList(ct);
            }

            public MultLanguage(ContryType ct)
            {
                SetLanguageList(ct);
            }

            public void SetLanguageList(ContryType ct)
            {
                sContryType = GetStringType(ct);

                if (sDefaultContryType != sContryType)
                {
                    dicLanguage.Clear();
                    dicDefaultLanguage.Clear();
                    ReadToXml("");
                    sDefaultContryType = sContryType;
                }
            }

            private string GetStringType(ContryType ct)
            {
                string sReturn = "";
                switch (ct)
                {
                    case ContryType.Korea:
                        sReturn = sKorea;
                        break;
                    case ContryType.USA:
                        sReturn = sUSA;
                        break;
                    case ContryType.Japan:
                        sReturn = sJapan;
                        break;
                    case ContryType.India:
                        sReturn = sIndia;
                        break;
                    case ContryType.China:
                        sReturn = sChina;
                        break;
                    case ContryType.Germany:
                        sReturn = sGermany;
                        break;
                    case ContryType.Spanish:
                        sReturn = sSpanish;
                        break;
                }
                return sReturn;
            }

            public void ReadToXml(string DB)
            {
              //  StreamReader streamReader = new StreamReader(sFullFailName);
                using (XmlReader xR = XmlReader.Create(sFullFailName))
                {
                    while (xR.Read())
                    {
                        if (xR.NodeType == XmlNodeType.Element && xR.LocalName.ToLower() == sWord)
                        {
                            if (!xR.GetAttribute(sContryType).Equals("") && !dicLanguage.ContainsKey(xR.GetAttribute(sDefaultContryType)))
                            {
                                dicLanguage.Add(xR.GetAttribute(sDefaultContryType), xR.GetAttribute(sContryType));
                            }

                            if (!xR.GetAttribute(sContryType).Equals("") && !dicDefaultLanguage.ContainsKey(xR.GetAttribute(sUSA)))
                            {
                                dicDefaultLanguage.Add(xR.GetAttribute(sUSA), xR.GetAttribute(sContryType));
                            }
                        }
                    }
                }

                //DataTable DT = service.get_다국어목록("", "kr", DB).Tables[0];

                //for (int i = 0; i < DT.Rows.Count; i++)
                //{

                //    try
                //    {
                //        dicLanguage.Add(DT.Rows[i][sDefaultContryType].ToString(), DT.Rows[i][sContryType].ToString());
                //        dicDefaultLanguage.Add(DT.Rows[i][sDefaultContryType].ToString(), DT.Rows[i][sContryType].ToString());
                //    }
                //    catch (Exception ex)
                //    { }

                //}
            }

            public void DefaultChangLanguage(Form fData)
            {
                if (dicDefaultLanguage.Count > 0)
                {
                    Dictionary<string, string> dicBank = dicLanguage;
                    dicLanguage = dicDefaultLanguage;
                    ChangLanguage(fData);
                    dicLanguage = dicBank;
                }
            }

            public void ChangLanguage(Form fData)
            {
                if (dicLanguage.Count > 0)
                {
                    if (fData != null)
                    {
                        fData.Text = GetLanguage(fData.Text);
                        foreach (Control ct in fData.Controls)
                        {
                            try
                            {
                                ControlChang(ct);
                            }
                            catch
                            {

                            }
                        }

                        //if (fData.MdiChildren.Length > 0)
                        //{
                        //    foreach (Form fDataSub in fData.MdiChildren)
                        //    {
                        //        ChangLanguage(fDataSub);
                        //    }
                        //}
                    }
                }
            }

            private void ChangLanguageSub(Control ctdata)
            {
                foreach (Control ct in ctdata.Controls)
                {
                    ControlChang(ct);
                }
            }

            private void ControlChang(Control ct)
            {
                try
                {
                    if (ct.Controls.Count <= 0 && ct.Name.ToString() != "lblLocid")
                    {
                        if (sDefaultContryType.ToUpper() == "KR")
                        {
                            ct.Font = new System.Drawing.Font("Gulim", 9F, FontStyle.Regular);
                        }
                        else if (sDefaultContryType.ToUpper() == "JA")
                        {
                            ct.Font = new System.Drawing.Font("MS PGothic", 9F, FontStyle.Regular);
                        }
                        else if (sDefaultContryType.ToUpper() == "US")
                        {
                            ct.Font = new System.Drawing.Font("Tahoma", 9F, FontStyle.Regular);
                        }
                        else
                            ;
                            //ct.Font = new System.Drawing.Font("Tahoma", 9F, FontStyle.Regular);
                    }
                    /*
                    if (ct is DataGridView)
                    {
                        foreach (DataGridViewColumn dvc in ((DataGridView)ct).Columns)
                        {
                            try
                            {
                                dvc.HeaderText = GetLanguage(dvc.HeaderText);
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }
                        }
                    }
                    else if (ct is MenuStrip)
                    {
                        foreach (ToolStripMenuItem tsmData in ((MenuStrip)ct).Items)
                        {
                            tsmData.Text = GetLanguage(tsmData.Text);
                            foreach (ToolStripItem tsmDataSub in tsmData.DropDown.Items)
                            {
                                tsmDataSub.Text = GetLanguage(tsmDataSub.Text);
                            }
                        }
                    }
                    else if (ct is StatusStrip)
                    {
                        foreach (ToolStripItem tsmData in ((StatusStrip)ct).Items)
                        {
                            tsmData.Text = GetLanguage(tsmData.Text);
                        }
                    }
                    else if (ct is ToolStrip)
                    {
                        foreach (ToolStripItem tsmData in ((ToolStrip)ct).Items)
                        {
                            //tsmData.ToolTipText = GetLanguage(tsmData.ToolTipText);
                            tsmData.Text = GetLanguage(tsmData.Text);
                        }
                    }
                    else 
                    if (ct is ComboBox)
                    {

                        for (int i = 0; i < ((ComboBox)ct).Items.Count; i++)
                        {
                            try
                            {
                                ((ComboBox)ct).Items[i] = GetLanguage(((ComboBox)ct).Items[i].ToString());
                            }
                            catch { }
                        }
                    }
                    else*/
                    if (ct is TextBox /*|| ct is RichTextBox*/)
                    {
                        if (!ct.Enabled || ((TextBox)ct).ReadOnly)
                        {
                            ct.Text = GetLanguage(ct.Text);
                        }
                    }
                    //else if (ct is ColumnHeader)
                    //{
                    //    ct.Text = GetLanguage(ct.Text);
                    //}
                    else if (ct is ListView)
                    {
                        foreach (ColumnHeader ch in ((ListView)ct).Columns)
                        {
                            //tsmData.ToolTipText = GetLanguage(tsmData.ToolTipText);
                            ch.Text = GetLanguage(ch.Text);
                        }
                    }
                    //else if (ct.Name.ToString() == "lblLocid")
                    //{
                    //    MessageBox.Show("ok");
                    //}
                    else
                    {
                        ct.Text = GetLanguage(ct.Text);
                    }
                    if (ct.Controls.Count > 0) ChangLanguageSub(ct);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }

            public string GetLanguage(string sData)
            {
                string sReturn = "";
                if (sData == null) sData = "";
                if (dicLanguage.ContainsKey(sData))
                {
                    sReturn = dicLanguage[sData];
                }
                else
                {
                    sReturn = sData;
                }

                return sReturn;
            }

            //정종수 추가. 2012.07.24.
            public string GetLanguage(string[] sData)
            {
                StringBuilder sb = new StringBuilder(300);
                foreach (string token in sData)
                {
                    sb.Append(GetLanguage(token + " "));
                }
                return sb.ToString();
            }
        }

        public class MultLanguageUtil
        {
            List<string> liNew = new List<string>();
            List<string> liOld = new List<string>();

            public void CreateXml(string sNewFile, Form fData)
            {
                GetWord(fData);
                WriteToXml(sNewFile);
            }

            public void CompareCreateXml(string sNewFile, string sOldFile, Form fData)
            {
                ReadToXml(sOldFile);
                GetWord(fData);
                WriteToXml(sNewFile);
            }

            private void ReadToXml(string sOldFile)
            {
                using (XmlReader xR = XmlReader.Create(sOldFile))
                {
                    while (xR.Read())
                    {
                        if (xR.NodeType == XmlNodeType.Element && xR.LocalName.ToLower() == "word")
                        {
                            if (!xR.GetAttribute("kr").Equals("") && !liOld.Contains(xR.GetAttribute("kr")))
                            {
                                liOld.Add(xR.GetAttribute("kr"));
                            }
                        }
                    }
                }
            }

            private void WriteToXml(string sNewFile)
            {
                using (StreamWriter sW = new StreamWriter(sNewFile))
                {
                    sW.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                    sW.WriteLine("<Language>");
                    sW.WriteLine();
                    foreach (string sData in liNew)
                    {
                        string sValue = sData;
                        sValue = sValue.Replace("&", "&amp;");
                        sValue = sValue.Replace("<", "&lt;");
                        sValue = sValue.Replace(">", "&gt");
                        sValue = sValue.Replace("\"", "&quot;");
                        sValue = sValue.Replace("\'", "&apos;");

                        sW.WriteLine("	<Word 	kr = \"" + sValue + "\"");
                        sW.WriteLine("		us = \"(미)" + sValue + "\"");
                        sW.WriteLine("		ja = \"(일)" + sValue + "\"");
                        sW.WriteLine("		ch = \"(중)" + sValue + "\"");
                        sW.WriteLine("		gm = \"(독)" + sValue + "\"");
                        sW.WriteLine("		id = \"(인)" + sValue + "\"/>");
                        sW.WriteLine();
                    }
                    sW.WriteLine("</Language>");
                }
            }

            private void GetWord(Form fData)
            {
                SetList(fData.Text);
                foreach (Control ct in fData.Controls)
                {
                    GetControl(ct);
                }

                //if (fData.MdiChildren.Length > 0)
                //{
                //    foreach (Form fDataSub in fData.MdiChildren)
                //    {
                //        GetWord(fDataSub);
                //    }
                //}
            }

            private void GetWordSub(Control ctdata)
            {
                foreach (Control ct in ctdata.Controls)
                {
                    GetControl(ct);
                }
            }

            private void GetControl(Control ct)
            {
            //    if (ct is DataGridView)
            //    {
            //        foreach (DataGridViewColumn dvc in ((DataGridView)ct).Columns)
            //        {
            //            SetList(dvc.HeaderText);
            //        }
            //    }
            //    else if (ct is MenuStrip)
            //    {
            //        foreach (ToolStripMenuItem tsmData in ((MenuStrip)ct).Items)
            //        {
            //            SetList(tsmData.Text);
            //            foreach (ToolStripItem tsmDataSub in tsmData.DropDown.Items)
            //            {
            //                SetList(tsmDataSub.Text);
            //            }
            //        }
            //    }
            //    else if (ct is StatusStrip)
            //    {
            //        foreach (ToolStripItem tsmData in ((StatusStrip)ct).Items)
            //        {
            //            SetList(tsmData.Text);
            //        }
            //    }
            //    else if (ct is ToolStrip)
            //    {
            //        foreach (ToolStripItem tsmData in ((ToolStrip)ct).Items)
            //        {
            //            SetList(tsmData.ToolTipText);
            //        }
            //    }
                //else 
            if (ct is ComboBox)
                {
                    foreach (Object oData in ((ComboBox)ct).Items)
                    {
                        SetList(oData.ToString());
                    }
                }
                //else if (ct is TextBox || ct is RichTextBox)
                //{
                //    if (!ct.Enabled || ((TextBox)ct).ReadOnly)
                //    {
                //        SetList(ct.Text);
                //    }
                //}
                else
                {
                    SetList(ct.Text);
                }
                if (ct.Controls.Count > 0) GetWordSub(ct);
            }

            private void SetList(string sData)
            {
                if (!liNew.Contains(sData) && !liOld.Contains(sData) && sData != null && !sData.Equals(""))
                {
                    liNew.Add(sData);
                }
            }
        }
    }

