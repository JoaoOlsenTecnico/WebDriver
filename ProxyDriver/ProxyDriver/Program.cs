using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ProxyDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adiciona argumento que remove corpo do navegador(Deixando apenas visual pelo console)
            //options.AddArguments("--headless");
            var options = new ChromeOptions();
            var proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.HttpProxy = 
            proxy.SslProxy = "1.20.101.221:55707";
            options.Proxy = proxy;
            options.AddArgument("ignore-certificate-errors");
            // Inicia o navegador
            var chromeDriver = new ChromeDriver(options);
            // Acessando o painel de admin do Magento
            chromeDriver.Navigate().GoToUrl("https://www.meuip.com.br/");
        }
    }
}
