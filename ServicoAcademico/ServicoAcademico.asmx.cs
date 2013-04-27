using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PadroesProjeto
{
    /// <summary>
    /// Disponibiliza serviços acadêmicos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoAcademico : System.Web.Services.WebService
    {
        [WebMethod(
            Description="Exibe as notas de uma ou todas as disciplinas do aluno",
            BufferResponse=true,
            CacheDuration=600)]
        public string ConsultaNota(string _matricula)
        {
            string _notasXML;

            #region Monta XML
            
            _notasXML =
                "<ConsultaNota xmlns=\"http://tempuri.org/\">" +
                "    <Disciplina>" +
                "        <Nome>ANÁLISE E PROJETO DE ARQUITETURA DE SOFTWARE</Nome>" +
                "        <Nota>23</Nota>"+
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>ARQUITETURA DE APLICATIVOS AMBIENTE JEE</Nome>" +
                "        <Nota>44</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>ARQUITETURA DE APLICATIVOS AMBIENTE NET</Nome>" +
                "        <Nota>36</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>ARQUITETURA DE COMPUTAÇÃO EM NUVENS</Nome>" +
                "        <Nota>42</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>ARQUITETURA DE DADOS NA WEB SGBD NOSQL</Nome>" +
                "        <Nota>26</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>ARQUITETURA DE SISTEMAS DE INFORMAÇÃO WEB</Nome>" +
                "        <Nota></Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>ARQUITETURA DE SISTEMAS MOVEIS</Nome>" +
                "        <Nota></Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>ARQUITETURA ORIENTADA A SERVIÇOS - SOA</Nome>" +
                "        <Nota></Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>ARQUITETURAS CORPORATIVAS</Nome>" +
                "        <Nota></Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>AVALIAÇÃO DE ARQUITETURA DE SOFTWARE</Nome>" +
                "        <Nota>62</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>DESENVOLVIMENTO DE APLICAÇÕES MÓVEIS</Nome>" +
                "        <Nota>45</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>GERENCIAMENTO DE PROCESSOS DE NEGÓCIO (BPM)</Nome>" +
                "        <Nota>26</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>GOVERNANÇA DE TECNOLOGIA DA INFORMAÇÃO</Nome>" +
                "        <Nota>42</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>INTEGRAÇÃO DE APLICAÇÕES (EAI)</Nome>" +
                "        <Nota>90</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>INTRODUÇÃO A GERÊNCIA DE PROJETOS</Nome>" +
                "        <Nota>88</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>METODOLOGIA DA PESQUISA CIENTÍFICA (EAD)</Nome>" +
                "        <Nota>47</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>PADRÕES DE PROJETO</Nome>" +
                "        <Nota>87</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>PRINCÍPIOS DE ARQUITETURA DE SOFTWARE</Nome>" +
                "        <Nota>37</Nota>" +
                "    </Disciplina>" +
                "    <Disciplina>" +
                "        <Nome>PROCESSO DE DESENVOLVIMENTO DE SOFTWARE</Nome>" +
                "        <Nota>56</Nota>" +
                "    </Disciplina>" + 
                "</ConsultaNota>";

            #endregion

            return _notasXML;
        }

        [WebMethod(
            Description = "Exibe o histórico do aluno",
            BufferResponse = true,
            CacheDuration = 600)]
        public string ConsultaHistóricoEscolar(string _matricula)
        {
            string _historicoXML;

            _historicoXML = 
                "<historico>"+
                "    <nome>Jefferson Thadeu Santos da Costa</nome>" +
                "    <matricula>441144</matricula>" +
                "    <disciplinas>"+
                "        <disciplina>"+
                "            <nome>ALGORÍTMOS E TÉCNICAS DE PROGRAMAÇÃO I</nome>" +
                "            <carga_horaria>92</carga_horaria>" +
                "            <nota>80</nota>" +
                "        </disciplina>"+
                "        <disciplina>" +
                "            <nome>GEOMETRIA ANALÍTICA E ÁLGEBRA LINEAR</nome>" +
                "            <carga_horaria>60</carga_horaria>" +
                "            <nota>84</nota>" +
                "        </disciplina>" +
                "        <disciplina>" +
                "            <nome>CÁLCULO DIFERENCIA E INTEGRAL I</nome>" +
                "            <carga_horaria>92</carga_horaria>" +
                "            <nota>76</nota>" +
                "        </disciplina>" +
                "        <disciplina>" +
                "            <nome>FILOSOFIA I</nome>" +
                "            <carga_horaria>62</carga_horaria>" +
                "            <nota>63</nota>" +
                "        </disciplina>" +
                "        <disciplina>" +
                "            <nome>SEMINÁRIOS I</nome>" +
                "            <carga_horaria>30</carga_horaria>" +
                "            <nota>78</nota>" +
                "        </disciplina>" +
                "    </disciplinas>" +
                "</historico>";

            return
                _historicoXML;
        }

        [WebMethod(
            Description = "Solicita o trancamento da disciplina",
            BufferResponse = true)]
        public bool SolicitaTrancamentoDisciplina(string _matricula, string _disciplina)
        {
            return true;
        }

        [WebMethod(
            Description = "",
            BufferResponse = true)]
        public bool ConsultaSolicitacaoTrancamento(string _matricula, string _disciplina)
        {
            return true;
        }
    }
}
