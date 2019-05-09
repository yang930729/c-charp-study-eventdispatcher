using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190509
{
    class GameLauncher
    {
        public InGameUI inGameUi;
        private Hero hero;
        private Monster monster;

        public GameLauncher()
        {
            this.inGameUi = new InGameUI();

            //이벤트등록
            //버튼이벤트등록
            EventDispatcher.GetInstance().AddEventHandler("MONSTER_DIE", (sender, e) =>
             {
                 Console.WriteLine("{0},{1}",sender, e);
                 var eventArgs = (GamgEvent.MonsterEventArgs)e;
                 //Console.WriteLine("{0},{1}", eventArgs.info.id, eventArgs.info.hp);
             });

            this.inGameUi.BtnHeroSkill.OnClickEventHandler += BtnHeroSkill_OnClickEventHandler;
        }

        private void BtnHeroSkill_OnClickEventHandler (object sender, EventArgs e)
        {
            Console.WriteLine("{0}{1}", sender, e);
            this.hero.ActiveSkill();
            this.monster.TakeDamage(5);
        }

        public void Init()
        {
            this.hero = new Hero();
            this.monster = new Monster();

            this.hero.Init("홍길동");
            this.monster.Init("오우거");
        }

        public void Start()
        {
            Console.WriteLine("게임런처실행");
            //사용자가 눌렀다고 가정
            this.inGameUi.BtnHeroSkill.Click();
            
        }
    }
}
