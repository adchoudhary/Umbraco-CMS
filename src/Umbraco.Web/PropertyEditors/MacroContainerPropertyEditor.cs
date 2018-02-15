﻿using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;

namespace Umbraco.Web.PropertyEditors
{
    // fixme - if deprecated, what's the alternative?
    [DataEditor(Constants.PropertyEditors.Aliases.MacroContainer, "(Obsolete) Macro Picker", "macrocontainer", ValueType = ValueTypes.Text, Group="rich content", Icon="icon-settings-alt", IsDeprecated = true)]
    public class MacroContainerPropertyEditor : ConfiguredDataEditor
    {
        public MacroContainerPropertyEditor(ILogger logger)
            : base(logger)
        { }

        protected override IConfigurationEditor CreateConfigurationEditor() => new MacroContainerConfigurationEditor();
    }
}
