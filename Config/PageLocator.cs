using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Config
{
    public class PageLocator: IPageLocator
    {
        public Base CurrentPage { get; set; }

        public TPage GetInstance<TPage>() where TPage : Base, new()
        {
            return (TPage) Activator.CreateInstance(typeof(TPage));
            //return new TPage();
        }

        public TPage Is<TPage>() where TPage: Base
        {
            return (TPage)this;
        }


    }
}
