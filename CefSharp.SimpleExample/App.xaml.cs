using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CefSharp.SimpleExample
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //Monitor parent process exit and close subprocesses if parent process exits first
        //This will at some point in the future becomes the default
        CefSharpSettings.SubprocessExitIfParentProcessClosed = true;

            var settings = new CefSettings()
            {
                //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache")
            };

        //Example of setting a command line argument
        //Enables WebRTC
        settings.CefCommandLineArgs.Add("enable-media-stream", "1");

            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
        }
}
