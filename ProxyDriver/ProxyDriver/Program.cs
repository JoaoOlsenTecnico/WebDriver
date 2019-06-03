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
        public static void TesteProxy()
        {
            var options = new ChromeOptions();
            var proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            options.AddArgument("ignore-certificate-errors");
            proxy.HttpProxy = proxy.SslProxy = "189.91.157.21:8080";
            options.Proxy = proxy;
            var url = "https://www.meuip.com.br/";
            var chromeDriver = new ChromeDriver(@"C:\chromeDriver\teste\", options);
            try
            {
                chromeDriver.Navigate().GoToUrl(url);
            }
            catch (Exception e) { }
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
            chromeDriver.Navigate().GoToUrl("https://hidemyna.me/en/proxy-list/?maxtime=500&type=s#list");
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
                    if(numero == 640)
                    {
                        sw.Close();
                        break;
                    }
                    numero += 64;
                    chromeDriver.Navigate().GoToUrl("https://hidemyna.me/en/proxy-list/?maxtime=500&type=s&start=" + numero +"#list"); 
                    campos_proxy = chromeDriver.FindElementsByTagName("table")[0].FindElements(By.TagName("tr"));
                    x = 0;
                }
               
            }
            
        }

        public static void ProxyDriver()
        {
            var ips = new List<string>();
            using (StreamReader reader = new StreamReader(@"C:\chromeDriver\ip_corretos.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    ips.Add(linha);
                }
            }
            // Adiciona argumento que remove corpo do navegador(Deixando apenas visual pelo console)
          
            var options = new ChromeOptions();
            var options_1 = new ChromeOptions();
            var options_2 = new ChromeOptions();
            var options_3 = new ChromeOptions();
            var options_4 = new ChromeOptions();
            var options_5 = new ChromeOptions();
            var options_6 = new ChromeOptions();
            var options_7 = new ChromeOptions();
            var options_8 = new ChromeOptions();
            var options_9 = new ChromeOptions();
            //options.AddArguments("--headless");
            var proxy = new Proxy();
            var proxy_1 = new Proxy();
            var proxy_2 = new Proxy();
            var proxy_3 = new Proxy();
            var proxy_4 = new Proxy();
            var proxy_5 = new Proxy();
            var proxy_6 = new Proxy();
            var proxy_7 = new Proxy();
            var proxy_8 = new Proxy();
            var proxy_9 = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;

            proxy_1.Kind = ProxyKind.Manual;
            proxy_1.IsAutoDetect = false;

            proxy_2.Kind = ProxyKind.Manual;
            proxy_2.IsAutoDetect = false;

            proxy_3.Kind = ProxyKind.Manual;
            proxy_3.IsAutoDetect = false;

            proxy_4.Kind = ProxyKind.Manual;
            proxy_4.IsAutoDetect = false;

            proxy_5.Kind = ProxyKind.Manual;
            proxy_5.IsAutoDetect = false;

            proxy_6.Kind = ProxyKind.Manual;
            proxy_6.IsAutoDetect = false;

            proxy_7.Kind = ProxyKind.Manual;
            proxy_7.IsAutoDetect = false;

            proxy_8.Kind = ProxyKind.Manual;
            proxy_8.IsAutoDetect = false;

            proxy_9.Kind = ProxyKind.Manual;
            proxy_9.IsAutoDetect = false;

            options.AddArgument("ignore-certificate-errors");
            options_1.AddArgument("ignore-certificate-errors");
            options_2.AddArgument("ignore-certificate-errors");
            options_3.AddArgument("ignore-certificate-errors");
            options_4.AddArgument("ignore-certificate-errors");
            options_5.AddArgument("ignore-certificate-errors");
            options_6.AddArgument("ignore-certificate-errors");
            options_7.AddArgument("ignore-certificate-errors");
            options_8.AddArgument("ignore-certificate-errors");
            options_9.AddArgument("ignore-certificate-errors");
            var ips_errados = new List<string>();
            var url = "https://www.youtube.com/watch?v=RDDlceawWOI";
            while (true)
            {
                for (var x = 0; x < ips.Count; x += 10)
                {
                    try
                    {

                        proxy.HttpProxy = proxy.SslProxy = "186.193.10.2:8080";
                        options.Proxy = proxy;
                        var chromeDriver = new ChromeDriver(@"C:\chromeDriver\teste\", options);
                        chromeDriver.Navigate().GoToUrl(url);

                        proxy_1.HttpProxy = proxy.SslProxy = ips[x + 1];
                        options_1.Proxy = proxy;
                        var chromeDriver_1 = new ChromeDriver(@"C:\chromeDriver\1\", options_1);
                        chromeDriver_1.Navigate().GoToUrl(url);

                        proxy_2.HttpProxy = proxy.SslProxy = ips[x + 2];
                        options_2.Proxy = proxy;
                        var chromeDriver_2 = new ChromeDriver(@"C:\chromeDriver\2\", options_2);
                        chromeDriver_2.Navigate().GoToUrl(url);

                        proxy_3.HttpProxy = proxy.SslProxy = ips[x + 3];
                        options_3.Proxy = proxy;
                        var chromeDriver_3 = new ChromeDriver(@"C:\chromeDriver\3\", options_3);
                        chromeDriver_3.Navigate().GoToUrl(url);

                        proxy_4.HttpProxy = proxy.SslProxy = ips[x + 4];
                        options_4.Proxy = proxy;
                        var chromeDriver_4 = new ChromeDriver(@"C:\chromeDriver\4\", options_4);
                        chromeDriver_4.Navigate().GoToUrl(url);

                        proxy_5.HttpProxy = proxy.SslProxy = ips[x + 5];
                        options_5.Proxy = proxy;
                        var chromeDriver_5 = new ChromeDriver(@"C:\chromeDriver\5\", options_5);
                        chromeDriver_5.Navigate().GoToUrl(url);

                        proxy_6.HttpProxy = proxy.SslProxy = ips[x + 6];
                        options_6.Proxy = proxy;
                        var chromeDriver_6 = new ChromeDriver(@"C:\chromeDriver\6\", options_6);
                        chromeDriver_6.Navigate().GoToUrl(url);

                        proxy_7.HttpProxy = proxy.SslProxy = ips[x + 7];
                        options_7.Proxy = proxy;
                        var chromeDriver_7 = new ChromeDriver(@"C:\chromeDriver\7\", options_7);
                        chromeDriver_7.Navigate().GoToUrl(url);

                        proxy_8.HttpProxy = proxy.SslProxy = ips[x + 8];
                        options_8.Proxy = proxy;
                        var chromeDriver_8 = new ChromeDriver(@"C:\chromeDriver\8\", options_8);
                        chromeDriver_8.Navigate().GoToUrl(url);

                        proxy_9.HttpProxy = proxy.SslProxy = ips[x + 9];
                        options_9.Proxy = proxy;
                        var chromeDriver_9 = new ChromeDriver(@"C:\chromeDriver\9\", options_9);
                        chromeDriver_9.Navigate().GoToUrl(url);

                        System.Threading.Thread.Sleep(120000);
                        chromeDriver.Close();
                        chromeDriver_1.Close();
                        chromeDriver_2.Close();
                        chromeDriver_3.Close();
                        chromeDriver_4.Close();
                        chromeDriver_5.Close();
                        chromeDriver_6.Close();
                        chromeDriver_7.Close();
                        chromeDriver_8.Close();
                        chromeDriver_9.Close();
                    } catch(Exception e)
                    {

                    }
                }

            }
        }
    }
}
