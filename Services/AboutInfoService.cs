using Orchestra.Models;
using Orchestra.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RibbonApp1.Services
{

    internal class AboutInfoService : IAboutInfoService
    {
        public AboutInfo GetAboutInfo()
        {
            var aboutInfo = new AboutInfo(new Uri("pack://application:,,,/Resources/Images/CompanyLogo.png", UriKind.RelativeOrAbsolute),
                uriInfo: new UriInfo("http://www.catelproject.com", "Product website"));

            return aboutInfo;
        }
    }
}
