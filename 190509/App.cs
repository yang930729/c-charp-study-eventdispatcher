using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190509
{
    class App
    {
        private GameLauncher gameLauncher;

        public void Start()
        {
            gameLauncher = new GameLauncher();

            this.gameLauncher.Init();
            this.gameLauncher.Start();
        }

        #region EX
        //private void Ex()
        //{
        //    //public event EventHandler ThresholdReached;
        //    //public class DieEventArgs : EventArgs
        //    //{
        //    //    public int hp;
        //    //}

        //    public void Start()
        //    {
        //        //var dieEventArgs = new EventArgs();
        //        //this.OnThresholdReached(dieEventArgs);//내용이 있을 경우
        //        //this.OnThresholdReached(EventArgs.Empty);//단순히 전송만
        //    }

        //        //protected virtual void OnThresholdReached(EventArgs e)
        //        //{
        //        //    EventHandler handler = ThresholdReached;
        //        //    handler.Invoke(this,e);//null을 검사함(NULL조건부연산자)
        //        //    //handler?.Invoke(this, e); //또다른방법
        //        //}
        //    }
        //}
        #endregion
    }
}
