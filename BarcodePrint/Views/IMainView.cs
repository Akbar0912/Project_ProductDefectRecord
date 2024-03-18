using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodePrint.Views
{
    public interface IMainView
    {
        event EventHandler ShowDefectView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowVetsView;
    }
}
