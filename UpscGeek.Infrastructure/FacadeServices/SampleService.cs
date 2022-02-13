using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using UpscGeek.Core.Entities;

namespace UpscGeek.Infrastructure.FacadeServices
{
    public class SampleService
    {
        private Subject<bool> _subject = new Subject<bool>();
        public IObservable<bool> Obs;

        public SampleService()
        {
            this.Obs = _subject.AsObservable();
        }

        public void SendTrue()
        {
            _subject.OnNext(true);
        }
        private void subscriber()
        {
            this.Obs.Subscribe(x => {
                Console.WriteLine(x);
            });
        }
    }
}