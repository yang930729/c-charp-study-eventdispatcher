using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190509
{
    class UIButton
    {
        public event EventHandler OnClickEventHandler;

        //public void AddListener(EventHandler call)
        //{
        //    OnClickEventHandler = call;
        //}
        
        public UIButton()
        {
            //this.onClick = new ButtonClickedEvent();
        }

        public void Click()
        {
            //이벤트발생
            this.OnClickEvent(EventArgs.Empty);
        }

        private void OnClickEvent(EventArgs e)
        {
            EventHandler handler = OnClickEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
