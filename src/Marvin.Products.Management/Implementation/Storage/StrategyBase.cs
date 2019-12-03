﻿using System;
using System.Linq;
using Marvin.AbstractionLayer;
using Marvin.Modules;
using Marvin.Tools;

namespace Marvin.Products.Management
{
    public class StrategyBase<TConfig, TConfigBase> : IConfiguredPlugin<TConfigBase>
        where TConfigBase : IProductStrategyConfiguation, IPluginConfig
        where TConfig : TConfigBase
    {
        /// <summary>
        /// Target type handled by this strategy
        /// </summary>
        public Type TargetType { get; protected set; }
        
        /// <summary>
        /// Configuration of this strategy
        /// </summary>
        protected TConfig Config { get; private set; }

        /// <summary>
        /// Initialize the strategy
        /// </summary>
        /// <param name="config"></param>
        public virtual void Initialize(TConfigBase config)
        {
            Config = (TConfig)config;
        }

        /// <summary>
        /// Start the strategy
        /// </summary>
        public virtual void Start()
        {
        }

        /// <summary>
        /// Stop the strategy
        /// </summary>
        public virtual void Stop()
        {
        }
    }
}