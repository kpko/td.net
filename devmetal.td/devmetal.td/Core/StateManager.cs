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
        protected Dictionary<string, State> States { get; set; }
        public State CurrentState { get; protected set; }

        public StateManager()
        {
            States = new Dictionary<string, State>();
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
            this.States.Add(name, state);
        }

        public void ChangeState(string stateName)
        {
            stateName = stateName.Trim().ToLower();

            ChangeState(States[stateName]);
        }

        public override void Initialize()
        {
            foreach (var state in this.States.Values)
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
            foreach (var state in this.States.Values)
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
