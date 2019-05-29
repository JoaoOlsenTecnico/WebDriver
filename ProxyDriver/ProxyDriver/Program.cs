using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;

namespace ProxyDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            PegandoIPs();
        }

        public static void PegandoIPs()
        {
            var options = new ChromeOptions();
            //options.AddArguments("--headless");
            //options.AddArguments("--disable-gpu");
            //var proxy = new Proxy();
            //proxy.Kind = ProxyKind.Manual;
            //proxy.IsAutoDetect = false;
            //proxy.HttpProxy = proxy.SslProxy = "1.20.101.221:55707";
            //options.Proxy = proxy;
            //options.AddArgument("ignore-certificate-errors");
            var chromeDriver = new ChromeDriver(@"C:\chromeDriver\teste\", options);
            var numero = 0;
            StreamWriter sw = new StreamWriter(@"C:\chromeDriver\ip.txt");
            chromeDriver.Navigate().GoToUrl("https://hidemyna.me/en/proxy-list/?maxtime=1000");
            System.Threading.Thread.Sleep(10000);
            var campos_proxy = chromeDriver.FindElementsByTagName("table")[0].FindElements(By.TagName("tr"));
            Console.WriteLine(campos_proxy[0].Text);
                //.FindElements(By.TagName("tr"));
            for (var x = 0; x < campos_proxy.Count; x++)
            { 
                try
                {
                    var ip = campos_proxy[x].FindElements(By.TagName("td"))[0].Text;
                    var porta = campos_proxy[x].FindElements(By.TagName("td"))[1].Text;
                    Console.WriteLine(ip + ":" + porta);
                    sw.WriteLine(ip + ":" + porta);
                }
                catch(Exception e) {}
                if(x == campos_proxy.Count-1)
                {
                    if(numero == 1984)
                    {
                        sw.Close();
                        break;
                    }
                    numero += 64;
                    chromeDriver.Navigate().GoToUrl("https://hidemyna.me/en/proxy-list/?maxtime=1000&start="+ numero +"#list"); 
                    campos_proxy = chromeDriver.FindElementsByTagName("table")[0].FindElements(By.TagName("tr"));
                    x = 0;
                }
               
            }
            
        }

        public static void ProxyDriver()
        {
            // Adiciona argumento que remove corpo do navegador(Deixando apenas visual pelo console)
            // options.AddArguments("--headless");
            var options = new ChromeOptions();
            var proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.HttpProxy = proxy.SslProxy = "1.20.101.221:55707";
            options.Proxy = proxy;
            
            options.AddArgument("ignore-certificate-errors");
            // Inicia o navegador
            //var firefoxDriver = new FirefoxDriver(@"C:\chromeDriver\", options_firefox);
            //var firefoxDriver_2 = new FirefoxDriver(@"C:\chromeDriver\teste\", options_firefox);
            var chromeDriver = new ChromeDriver(@"C:\chromeDriver\teste\" ,options);

            // Acessando o site
            //firefoxDriver.Navigate().GoToUrl("https://www.meuip.com.br/");
            chromeDriver.Navigate().GoToUrl("https://www.meuip.com.br/");
        }
    }
}
