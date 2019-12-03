﻿using Marvin.AbstractionLayer.UI;
using Marvin.Resources.UI.ResourceService;

namespace Marvin.Resources.UI.Interaction
{
    /// <summary>
    /// Tree item view model used for the resources tree
    /// </summary>
    internal class ResourceTreeItemViewModel : TreeItemViewModel
    {
        public ResourceInfoViewModel Resource { get; }

        public override long Id => Resource.Id;

        public override string DisplayName => Resource.Name;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTreeItemViewModel"/> class.
        /// </summary>
        public ResourceTreeItemViewModel(ResourceModel model)
        {
            Resource = new ResourceInfoViewModel(model);
        }

        public void UpdateModel(ResourceModel model)
        {
            Resource.UpdateModel(model);
            NotifyOfPropertyChange(nameof(DisplayName));
        }
    }
}