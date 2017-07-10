using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using MVCLearning.SampleWCFServiceReference;
using System.Windows.Forms;

//[assembly: OwinStartup(typeof(MVCLearning.Startup))]

namespace MVCLearning
{
    public partial class Startup
    {
        public async void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);

            var client = new SampleWCFServiceClient();

            var x = client.ServiceAsyncMethodAsync("test");

            var y = 12;

            MessageBox.Show("1");

            MessageBox.Show("2");

            MessageBox.Show("3");

            MessageBox.Show(await x);
        }
    }
}
