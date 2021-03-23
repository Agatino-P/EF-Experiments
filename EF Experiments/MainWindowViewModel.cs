using EF_Experiments.EF;
using EF_Experiments.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore;
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

            //This works
            //Samurai s3 = new("Samurai 3");
            //Quote q3 = new("Q3", s3);
            //s3.AddQuote(q3);
            //s3.AddQuote("t4");
            //context.Samurais.Add(s3);
            //int a =context.SaveChanges();

            //var samurai = context.Samurais.Include(s => s.Quotes).First();
            //var samurai = context.Samurais.First();

            //var stest = context.Samurais.Select(s =>new { Ident=s.Id,Nome=s.Name }).First();


            //Samurai s1 = new Samurai("s1");
            //s1.AddQuote("q1-1");
            //s1.AddQuote("q1-2");
            //context.Samurais.Add(s1);
            //context.SaveChanges();
            //var samurai = context.Samurais.First();
            //var samuraiw = context.Samurais.Include(s=>s.Quotes).Where(s => s.Id==samurai.Id).First();

            //var ss = context.Samurais.ToList();
            //var qs = context.Quotes.ToList();
        }

    }
}
