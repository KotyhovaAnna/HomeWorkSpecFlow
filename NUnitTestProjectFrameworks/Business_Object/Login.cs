using System;
using System.Collections.Generic;
using System.Text;


namespace NUnitTestProjectFrameworks.Business_Object
{
    class Login
    {
        public string searchInputName { get; set; }
        public string searchInputPassword { get; set; }
        public string searchClick { get; set; }


        public Login(string searchInputName, string searchInputPassword)
        {
            this.searchInputName = searchInputName;
            this.searchInputPassword = searchInputPassword;
            this.searchClick = searchClick;
        }
    }
}
