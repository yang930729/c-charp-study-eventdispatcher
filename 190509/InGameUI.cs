using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190509
{
    class InGameUI
    {
        private UIGauge monsterGauge;
        private UIGauge HeroGauge;
        public UIButton BtnHeroSkill { get; private set; }

        public InGameUI()
        {
            this.monsterGauge = new UIGauge();
            this.HeroGauge = new UIGauge();
            this.BtnHeroSkill = new UIButton();
        }
    }
}
