using ACC.Fundos.Business.Integration.CVM.Entities;
using ACC.Fundos.Business.Integration.CVM.Interface;
using ACC.Fundos.Business.Integration.CVM.Mapping;
using CsvHelper;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace ACC.Fundos.Business.Integration.CVM
{
    public class IntegracaoCVM : IIntegracaoCVM
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void ObterArquivoFundos(DateTime dataSolicitada)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://dados.cvm.gov.br/dados/FI/CAD/DADOS/inf_cadastral_fi_20190520.csv");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                {
                    string results = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error("Erro no ObterArquivoFundos: " + ex); 
            }
        }

        public IList<CadastroFundo> ListarFundos()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://dados.cvm.gov.br/dados/FI/CAD/DADOS/inf_cadastral_fi_" + ObterDataConsulta() + ".csv");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                using (var reader = new StreamReader(resp.GetResponseStream()))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.BadDataFound = null;
                    csv.Configuration.RegisterClassMap<CadastroFundoMap>();

                    return csv.GetRecords<CadastroFundo>().ToList();
                }
            }
            catch (Exception ex)
            {
                log.Error("Erro no ListarFundos: " + ex);
                return null;
            }
        }

        public CadastroFundo ObterFundo(string CnpjFundo)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://dados.cvm.gov.br/dados/FI/CAD/DADOS/inf_cadastral_fi_" + ObterDataConsulta() + ".csv");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                using (var reader = new StreamReader(resp.GetResponseStream()))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.BadDataFound = null;
                    csv.Configuration.RegisterClassMap<CadastroFundoMap>();

                    return csv.GetRecords<CadastroFundo>()
                              .Where(x => x.CNPJ_FUNDO.Replace(".", "").Replace("/", "").Replace("-", "") ==
                                             CnpjFundo.Replace(".", "").Replace("/", "").Replace("-", ""))
                              .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                log.Error("Erro no ObterFundo: " + ex);
                return null;
            }
        }

        public IList<InformacaoDiariaFundo> ObterInformacoesFundo(string CnpjFundo)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/inf_diario_fi_" + DateTime.Now.ToString("yyyyMM") + ".csv");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                using (var reader = new StreamReader(resp.GetResponseStream()))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.BadDataFound = null;
                    csv.Configuration.RegisterClassMap<InformacaoDiariaFundoMap>();

                    return csv.GetRecords<InformacaoDiariaFundo>()
                              .Where(x => x.CNPJ_FUNDO.Replace(".", "").Replace("/", "").Replace("-", "") ==
                                             CnpjFundo.Replace(".", "").Replace("/", "").Replace("-", ""))
                              .ToList();
                }
            }
            catch (Exception ex)
            {
                log.Error("Erro no ObterInformacoesFundo: " + ex);
                return null;
            }
        }

        private string ObterDataConsulta()
        {
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    return DateTime.Now.AddDays(-3).ToString("yyyyMMdd");
                case "Sunday":
                    return DateTime.Now.AddDays(-2).ToString("yyyyMMdd");
                default:
                    return DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
            }
        }
    }
}
