using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190509
{
    class EventDispatcher
    {
        private static EventDispatcher Instance;

        private Dictionary<string,EventHandler<EventArgs>>dicEventHandler = new Dictionary<string, EventHandler<EventArgs>>();
        
        private EventDispatcher()
        {
            if(EventDispatcher.Instance !=null)
            {
                throw new Exception("EventDispatcher는 싱클톤입니다");
            }
            
        }

        public static EventDispatcher GetInstance()
        {
            if(EventDispatcher.Instance == null)
            {
                EventDispatcher.Instance = new EventDispatcher();
            }
            return EventDispatcher.Instance;
        }


        //이벤트등록
        public void AddEventHandler(string eventName, EventHandler<EventArgs> executeHandler)
        {
            if(!this.dicEventHandler.ContainsKey(eventName))
            {
                this.dicEventHandler.Add(eventName, executeHandler);

                //this.dicEventHandler[eventName] = this.eventHandler;
                Console.WriteLine("이벤트 {0}가 등록되었습니다.{1}", eventName, executeHandler);
                Console.WriteLine("dicEventHandler 카운트 : {0}", this.dicEventHandler.Count);
            }
        }

        //이벤트 발생
        public void DispatchEvent(string eventName, EventArgs e)
        {
            var handler = this.dicEventHandler[eventName];

            Console.WriteLine("handler : {0}", handler);

            handler?.Invoke(EventDispatcher.GetInstance(), e);
        }
    }
}
