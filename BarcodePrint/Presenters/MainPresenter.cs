using BarcodePrint._Repositories;
using BarcodePrint.Models;
using BarcodePrint.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodePrint.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        //Constructor
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowDefectView += ShowDefectsView;
        }

        private void ShowDefectsView(object sender, EventArgs e)
        {
            IDefectView view = DefectView.GetInstance((MainView)mainView);
            IDefectRepository repository = new DefectRepository(sqlConnectionString);
            new DefectPresenter(view, repository);
        }
    }
}
