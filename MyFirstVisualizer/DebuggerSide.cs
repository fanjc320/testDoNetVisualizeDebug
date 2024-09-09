using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;

[assembly: System.Diagnostics.DebuggerVisualizer(
typeof(MyFirstVisualizer.DebuggerSide),
typeof(VisualizerObjectSource),
Target = typeof(System.String),
Description = "My First Visualizer")]
namespace MyFirstVisualizer
{
    public class DebuggerSide : DialogDebuggerVisualizer
    {
        public DebuggerSide() : base(FormatterPolicy.NewtonsoftJson) // or FormatterPolicy.Json
        {
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MessageBox.Show(objectProvider.GetObject().ToString());
        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerSide));
            visualizerHost.ShowVisualizer();
        }
    }
}
