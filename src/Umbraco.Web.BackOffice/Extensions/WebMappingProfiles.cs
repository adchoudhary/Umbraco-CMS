﻿using Umbraco.Core;
using Umbraco.Core.BackOffice;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;
using Umbraco.Web.Models.Mapping;

namespace Umbraco.Extensions
{
    public static class WebMappingProfiles
    {
        public static Composition ComposeWebMappingProfiles(this Composition composition)
        {
            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>()
                .Add<ContentMapDefinition>()
                .Add<MediaMapDefinition>()
                .Add<MemberMapDefinition>();

            composition.Register<CommonMapper>();
            composition.Register<CommonTreeNodeMapper>();
            composition.Register<MemberTabsAndPropertiesMapper>();

            return composition;
        }
    }
}
