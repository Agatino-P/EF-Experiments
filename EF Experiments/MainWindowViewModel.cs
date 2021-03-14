using EF_Experiments.EF;
using EF_Experiments.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Experiments
{
    public class MainWindowViewModel : ViewModelBase
    {


        private RelayCommand _testEfCmd;
        public RelayCommand TestEfCmd => _testEfCmd ?? (_testEfCmd = new RelayCommand(
            () => testEf(),
            () => { return 1 == 1; },
			keepTargetAlive:true
            ));
			private void testEf()
        {
            Context context = new();
            context.Database.EnsureCreated();
            Samurai s3 = new("Samurai 3");
            //context.Samurais.Add(samurai1);
            Quote q3 = new("Q3", s3);
            context.Quotes.Add(q3);
            //Quote quote1 = new("Quote1", samurai1.Id);
            //context.Quotes.Add(quote1);
            int a =context.SaveChanges();
            var ss = context.Samurais.ToList();
            var qs = context.Quotes.ToList();
        }

    }
}
