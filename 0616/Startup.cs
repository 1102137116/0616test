﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_0616.Startup))]
namespace _0616
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
