﻿using System;

namespace Marvin.AbstractionLayer
{
    /// <summary>
    /// Provides recipes for production
    /// </summary>
    public interface IRecipeProvider
    {
        /// <summary>
        /// Identity of this provider
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Load recipe by its database id
        /// </summary>
        IRecipe LoadRecipe(long id);

        /// <summary>
        /// A recipe was changed, give users the chance to update their reference
        /// </summary>
        event EventHandler<IRecipe> RecipeChanged;
    }
}