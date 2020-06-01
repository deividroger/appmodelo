using DevIO.UI.Site.Data;
using DevIO.UI.Site.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DevIO.UI.Site.Controllers
{
    public class HomeController : Controller
    {
       

        public HomeController(OperacaoService operacaoService, OperacaoService operacaoService2)
        {
            OperacaoService = operacaoService;
            OperacaoService2 = operacaoService2;
        }

        public OperacaoService OperacaoService { get; }
        public OperacaoService OperacaoService2 { get; }

        public string Index()
        {
          return "Primeira instância: " + Environment.NewLine +
                   OperacaoService.OperacaoTransient.OperacaoId + Environment.NewLine +
                   OperacaoService.OperacaoScoped.OperacaoId + Environment.NewLine +
                   OperacaoService.OperacaoSingleton.OperacaoId + Environment.NewLine +
                   OperacaoService.OperacaoSingletonInstance.OperacaoId + Environment.NewLine +

                   Environment.NewLine +
                   Environment.NewLine +
                   "Segunda instância: " + Environment.NewLine +
                   OperacaoService2.OperacaoTransient.OperacaoId + Environment.NewLine +
                   OperacaoService2.OperacaoScoped.OperacaoId + Environment.NewLine +
                   OperacaoService2.OperacaoSingleton.OperacaoId + Environment.NewLine +
                   OperacaoService2.OperacaoSingletonInstance.OperacaoId + Environment.NewLine;

        }
    }
}
