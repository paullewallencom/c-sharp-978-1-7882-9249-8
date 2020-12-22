﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Shared.Competitive
{
    /// <summary> The class that updates the competitive elements for either Android or iOS </summary>
    public abstract class CompetitiveController
    {
        /// <summary> Used to connect the updater to the relevant service </summary>
        /// <param name="onComplete"></param>
        public abstract void Connect(Action<Boolean> onComplete);
        /// <summary> Updates the achievement progress </summary>
        /// <param name="achievement"></param>
        public abstract void UpdateAchievement(Achievement achievement);
        /// <summary> Views the achievements for the game </summary>
        public abstract void ViewAchievements();
    }
}
