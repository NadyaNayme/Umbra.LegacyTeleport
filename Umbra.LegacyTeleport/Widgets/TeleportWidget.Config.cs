﻿/* Umbra | (c) 2024 by Una              ____ ___        ___.
 * Licensed under the terms of AGPL-3  |    |   \ _____ \_ |__ _______ _____
 *                                     |    |   //     \ | __ \\_  __ \\__  \
 * https://github.com/una-xiv/umbra    |    |  /|  Y Y  \| \_\ \|  | \/ / __ \_
 *                                     |______//__|_|  /____  /|__|   (____  /
 *     Umbra is free software: you can redistribute  \/     \/             \/
 *     it and/or modify it under the terms of the GNU Affero General Public
 *     License as published by the Free Software Foundation, either version 3
 *     of the License, or (at your option) any later version.
 *
 *     Umbra UI is distributed in the hope that it will be useful,
 *     but WITHOUT ANY WARRANTY; without even the implied warranty of
 *     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *     GNU Affero General Public License for more details.
 */

using System.Collections.Generic;
using Umbra.Common;

namespace Umbra.Widgets;

internal sealed partial class TeleportWidget
{
    protected override IEnumerable<IWidgetConfigVariable> GetConfigVariables()
    {
        return [
            new BooleanWidgetConfigVariable(
                "Decorate",
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.Decorate.Name"),
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.Decorate.Description"),
                true
            ) { Category = I18N.Translate("Widget.ConfigCategory.WidgetAppearance") },
            new BooleanWidgetConfigVariable(
                "DesaturateIcon",
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.DesaturateIcon.Name"),
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.DesaturateIcon.Description"),
                false
            ) { Category = I18N.Translate("Widget.ConfigCategory.WidgetAppearance") },
            new SelectWidgetConfigVariable(
                "DisplayMode",
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.DisplayMode.Name"),
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.DisplayMode.Description"),
                "TextAndIcon",
                new() {
                    { "TextAndIcon", I18N.Translate("Widgets.DefaultToolbarWidget.Config.DisplayMode.Option.TextAndIcon") },
                    { "TextOnly", I18N.Translate("Widgets.DefaultToolbarWidget.Config.DisplayMode.Option.TextOnly") },
                    { "IconOnly", I18N.Translate("Widgets.DefaultToolbarWidget.Config.DisplayMode.Option.IconOnly") }
                }
            ) { Category = I18N.Translate("Widget.ConfigCategory.WidgetAppearance") },
            new SelectWidgetConfigVariable(
                "IconLocation",
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.IconLocation.Name"),
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.IconLocation.Description"),
                "Left",
                new() {
                    { "Left", I18N.Translate("Widgets.DefaultToolbarWidget.Config.IconLocation.Option.Left") },
                    { "Right", I18N.Translate("Widgets.DefaultToolbarWidget.Config.IconLocation.Option.Right") }
                }
            ) { Category = I18N.Translate("Widget.ConfigCategory.WidgetAppearance") },
            new IntegerWidgetConfigVariable(
                "TextYOffset",
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.TextYOffset.Name"),
                I18N.Translate("Widgets.DefaultToolbarWidget.Config.TextYOffset.Description"),
                0,
                -5,
                5
            ) { Category = I18N.Translate("Widget.ConfigCategory.WidgetAppearance") },
        ];
    }
}
