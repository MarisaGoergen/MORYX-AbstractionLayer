﻿// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Marvin.AbstractionLayer.Recipes
{
    /// <summary>
    /// Recipe which is used for production. It has a product and workplan.
    /// </summary>
    public interface IProductionRecipe : IProductRecipe, IWorkplanRecipe
    {

    }
}