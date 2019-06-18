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
                if (String.IsNullOrEmpty(end.Autorizar))
                    return null;
                return end;
            }
            catch (Exception)
            { return null; }
        }
    }

    class pegarDados
    {
        private static string EnderecoUrl = "http://apirest.srirosario.com.br/usuarios/{0}";
        public static Dados VerUsuario(int code)
        {
            string NvUs = string.Format(EnderecoUrl, code);
            WebClient wc = new WebClient();
            try
            {
                string Coontent = wc.DownloadString(NvUs);
                Dados dadosus =
                JsonConvert.DeserializeObject<Dados>(Coontent);
                if (String.IsNullOrEmpty(dadosus.nome))
                    return null;
                return dadosus;
            }
            catch (Exception)
            { return null; }
        }
    }
}
