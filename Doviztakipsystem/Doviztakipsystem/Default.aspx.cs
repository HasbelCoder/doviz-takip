using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doviztakipsystem
{
    public partial class Default : System.Web.UI.Page
    {
        HtmlAgilityPack.HtmlWeb hweb = new HtmlAgilityPack.HtmlWeb(); // agility pack yarattık
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // [Dolar]
            HtmlAgilityPack.HtmlDocument alis = hweb.Load("https://dovizborsa.com/doviz/dolar");
            HtmlAgilityPack.HtmlDocument satis = hweb.Load("https://dovizborsa.com/doviz/dolar");

            foreach (HtmlAgilityPack.HtmlNode item in alis.DocumentNode.SelectNodes("//span[@class='-by-']")) // span da classı by olan nesneyi çekiyoruz
            {
                dolaral.Text = item.InnerText.ToString();
            }
            foreach (HtmlAgilityPack.HtmlNode item in satis.DocumentNode.SelectNodes("//span[@class='-sl-']"))
            {
                dolarsat.Text = item.InnerText.ToString();
            }
            
            // [EURO]
            HtmlAgilityPack.HtmlDocument alis2 = hweb.Load("https://dovizborsa.com/doviz/ingiliz-sterlini");
            HtmlAgilityPack.HtmlDocument satis2 = hweb.Load("https://dovizborsa.com/doviz/ingiliz-sterlini");

            foreach (HtmlAgilityPack.HtmlNode item in alis2.DocumentNode.SelectNodes("//span[@class='-by-']")) // span da classı by olan nesneyi çekiyoruz
            {
                euroal.Text = item.InnerText.ToString();
            }
            foreach (HtmlAgilityPack.HtmlNode item in satis2.DocumentNode.SelectNodes("//span[@class='-sl-']"))
            {
                eurosat.Text = item.InnerText.ToString();
            }


        }
    }
}