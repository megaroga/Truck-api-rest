using System;
using System.Collections.Generic;
using System.Text;
using truck.Model;
using Newtonsoft.Json;
using System.Net;

namespace truck
{
    class verificarLogin
    {
        private static string EnderecoUrl = "http://apirest.srirosario.com.br/login/{0}/{1}";
        public static Login VerificarAutorizacao(string usuario, string senha)
        {
            string NovoEnderecoUrl = string.Format(EnderecoUrl, usuario, senha);
            WebClient wc = new WebClient();
            try
            {
                string Conteudo = wc.DownloadString(NovoEnderecoUrl);
                Login end =
                JsonConvert.DeserializeObject<Login>(Conteudo);
                if (String.IsNullOrEmpty(end.autorizar))
                    return null;
                return end;
            }
            catch (Exception)
            { return null; }
        }
    }
}
