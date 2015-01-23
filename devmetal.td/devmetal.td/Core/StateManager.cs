using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.Core
{
    public class StateManager : Module
    {
        public State CurrentState { get; protected set; }

        protected Dictionary<string, State> states;
        protected Game game;

        public StateManager(Game game)
        {
            this.game = game;
            states = new Dictionary<string, State>();
        }

        public void ChangeState(State state)
        {
            if (this.CurrentState != null)
            {
                this.CurrentState.Leave();
                this.CurrentState.IsActive = false;
            }

            if (!state.IsLoaded)
                state.Load();

            state.Enter();
            state.IsActive = true;

            this.CurrentState = state;
        }

        public void Add(string name, State state)
        {
            name = name.Trim().ToLower();

            state.StateManager = this;
            this.states.Add(name, state);
        }

        public void ChangeState(string stateName)
        {
            stateName = stateName.Trim().ToLower();

            ChangeState(states[stateName]);
        }

        public void Exit()
        {
            game.Exit();
        }

        public override void Initialize()
        {
            foreach (var state in this.states.Values)
            {
                state.Initialize();
            }
        }

        public override void Load()
        {
            this.CurrentState.Load();
        }

        public override void Unload()
        {
            foreach (var state in this.states.Values)
            {
                if (state.IsLoaded)
                {
                    state.Unload();
                }
            }
        }

        public override void Update(GameTime gameTime)
        {
            this.CurrentState.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.CurrentState.Draw(spriteBatch);
        }

        
    }
}
