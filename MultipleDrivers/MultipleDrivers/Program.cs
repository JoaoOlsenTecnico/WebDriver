using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace ProxyDriver
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void ProxyDriver()
        {
            // Adiciona argumento que remove corpo do navegador(Deixando apenas visual pelo console)
            // options.AddArguments("--headless");
            var options = new ChromeOptions();
            var options_firefox = new FirefoxOptions();
            var proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.HttpProxy = proxy.SslProxy = "1.20.101.221:55707";
            options_firefox.Proxy = proxy;
            options.Proxy = proxy;
            options_firefox.AddArgument("ignore-certificate-errors");
            options.AddArgument("ignore-certificate-errors");
            // Inicia o navegador
            var firefoxDriver = new FirefoxDriver(options_firefox);
            //var chromeDriver = new ChromeDriver(options);
            // Acessando o site
            firefoxDriver.Navigate().GoToUrl("https://www.meuip.com.br/");
            //chromeDriver.Navigate().GoToUrl("https://www.meuip.com.br/");
        }
    }
}
