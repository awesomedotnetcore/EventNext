﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventNext
{
    public interface IController
    {
        void Initialize(EventCenter center);
    }

    public interface IActorState
    {
        string EventPath { get; set; }

        string ActorPath { get; set; }

        object Token { get; set; }

        EventCenter EventCenter { get; set; }

        Task ActorInit(string id);

        Task ActorFlush();

    }

    public abstract class ActorState : IActorState
    {
        public string EventPath { get; set; }

        public string ActorPath { get; set; }

        public object Token { get; set; }

        public EventCenter EventCenter { get; set; }

        public virtual Task ActorFlush()
        {
            return Task.CompletedTask;
        }

        public virtual Task ActorInit(string id)
        {
            return Task.CompletedTask;
        }
    }

}
