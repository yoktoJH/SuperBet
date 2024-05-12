using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBet.UiElements
{
    public class ScreenStorage
    {
        public LoginScreen login;
        public RegisterScreen register;

        public ScreenStorage(Model model)
        {
            login = new LoginScreen(this,model);
            register = new RegisterScreen(this, model);
        }
    }
}
