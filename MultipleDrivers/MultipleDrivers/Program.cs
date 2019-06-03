using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProxyDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyDriver();
        }

        public static void ProxyDriver()
        {
            // Adiciona argumento que remove corpo do navegador(Deixando apenas visual pelo console)
            // options.AddArguments("--headless");
            var ips = new List<string>();
            var ips_erro = new List<string>();
            using (StreamReader reader = new StreamReader(@"C:\Users\João Olsen\Documents\Pessoal\WebDriver\ip.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    ips.Add(linha);
                    
                }
            }

            var options = new ChromeOptions();
            Console.WriteLine(ips.Count);
            var proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.HttpProxy = proxy.SslProxy = "68.183.147.233:8080";
            options.Proxy = proxy;
            options.AddArgument("ignore-certificate-errors");
            var chromeDriver = new ChromeDriver(options);

            // Acessando o site
            chromeDriver.Navigate().GoToUrl("https://www.youtube.com/watch?v=RDDlceawWOI");
            //try
            //{
            //    Console.WriteLine(chromeDriver.FindElementByClassName("style-scope ytd-video-primary-info-renderer").Text);
            //    System.Threading.Thread.Sleep(60000);
            //}catch(Exception e) { ips_erro.Add(item); chromeDriver.Close();  }

            
        }
    }
}
