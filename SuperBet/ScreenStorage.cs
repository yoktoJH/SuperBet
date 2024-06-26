﻿using System;
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
        public UserScreen user;
        public AdminScreen admin;
        public ProfileScreen profile;
        public StatScreen stat;

        public ScreenStorage(Model model)
        {
            login = new LoginScreen(this,model);
            register = new RegisterScreen(this, model);
            user = new UserScreen(this, model);
            admin = new AdminScreen(this,model);
            profile = new ProfileScreen(this, model);
            stat = new StatScreen(this,model);
        }
    }
}
