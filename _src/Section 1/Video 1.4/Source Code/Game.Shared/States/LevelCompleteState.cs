﻿using Engine.Shared.State;
using Game.Shared.Level;
using Game.Shared.Objects.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Shared.States
{
    /// <summary> State entered when a level is complete - it progresses to the next level </summary>
    public class LevelCompleteState : State
    {
        /// <summary> Called when the state is entered - it resets the transitioning boolean & starts the timer </summary>
        public override void OnEnter()
        {
            FullscreenMessage.Instance.TransitionIn("level complete!", OnCompleteShown);
        }

        /// <summary> The method that's called when the level complete message has been shown - changes the state </summary>
        private void OnCompleteShown()
        {
            LevelController.Instance.ChangeLevel();
            if (LevelController.Instance.GameComplete)
            {
                StateManager.Instance.ChangeState(new GameCompleteState());
            }
            else
            {
                FullscreenMessage.Instance.ChangeText($"level {LevelController.Instance.CurrentLevelIndex}", () =>
                {
                    StateManager.Instance.ChangeState(new StartState());
                });
            }
        }

        /// <summary> Updates the state </summary>
        /// <param name="timeSinceUpdate"></param>
        public override void Update(TimeSpan timeSinceUpdate)
        {
        }

        /// <summary> Called when the state exits - disposes of the state </summary>
        public override void OnExit()
        {

        }

        /// <summary> Disposes of the state </summary>
        public override void Dispose()
        {

        }
    }
}
