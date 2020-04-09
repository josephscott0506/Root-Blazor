﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Sidebar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/default-functionalities",
                FileName = "SidebarDefaultFunctionalities.razor",
                MappingSampleName = "With Default Functionalities",
                ActionDescription = new string[] {
                    @"<p>
                        Click the button to view the Sidebar sample in new tab.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the basic <code>Sidebar</code> component. Click the toggle
                        button to expand or collapse the sidebar.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Dock",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/dock",
                FileName = "SidebarDock.razor",
                MappingSampleName = "With Dock",
                ActionDescription = new string[] {
                    @"Click the button to view the Sidebar sample in new tab."
                },
                Description = new string[] {
                    @"This sample demonstrates the dock state. Here the list item has icon with text representation. On dock state only the icon
                    listed out to interact."
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/api",
                FileName = "SidebarAPI.razor",
                MappingSampleName = "With API",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Sidebar component with its features. Click the button to view the Sidebar sample in a new tab.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this sample allows to configure the <code>type</code>, <code>position</code>, <code>closeOnDocumentClick</code>and
                        <code>showBackdrop</code> property.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Sidebar with ListView",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-listview",
                FileName = "SidebarList.razor",
                MappingSampleName = "With ListView",
                ActionDescription = new string[] {
                    @"<p>
                        Click the button to view the Sidebar sample in new tab.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this sample, the ListView component is placed inside the Sidebar for navigation.

                    </p>"
                }
            },
            new Sample
            {
                Name = "Sidebar Menu",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-menu",
                FileName = "SidebarMenu.razor",
                MappingSampleName = "With Menu",
                ActionDescription = new string[] {
                    @"<p>
                        Click/Touch the button to view the Sidebar sample in new tab.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates how to use the Menu component inside the Sidebar for navigation purposes. Initially, the Sidebar renders in the dock state with icons, and expands when the hamburger icon at the top-left corner of the header section is clicked.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Responsive Panel",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/panel-with-responsive",
                FileName = "ResponsivePanel.razor",
                MappingSampleName = "With Responsive",
                ActionDescription = new string[] {
                    @"<p>
                        Click/Touch the button to view the Sidebar sample in new tab.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates how to use the TreeView component inside the Sidebar for navigation purposes. The Sidebar expands when the hamburger icon at the top-left corner of the header section is clicked, and TreeView expands and collapses when the TreeView expand/collapse icon is clicked.
                    </p>"
                }
            }

        };


        public List<Sample> ContextMenu { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Context Menu",
                Directory = "Navigations/ContextMenu",
                FileName = "DefaultFunctionalities.razor",
                Url = "context-menu/default-functionalities",
                TitleTag = "Context Menu . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the Syncfusion Blazor Context Menu items with icons, text and separator.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the Context Menu component. Right click/Touch hold the rectangular area to open the ContextMenu.</p>"
                },
                Description = new string[] {
                    @"<p>Context Menu is a graphical user interface that appears on the user right click/touch hold action. It has support to provide single level/multiple level of ContextMenu.</p>
                      <p>In this demo, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.IContextMenu~Target.html'>target
                      </a></code> property is set as '#contextmenutarget'. Hence, on right clicking the target element, the Context Menu will open.
                    </p>
                    <p>More information about Blazor Context Menu component can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/context-menu/getting-started/'> documentation section</a>.</p>"
          }      }
        };
        public List<Sample> MenuBar { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DefaultFunctionalities.razor",
                Url = "menu-bar/default-functionalities",
                TitleTag = "DefaultFunctionalities",
                MetaDescription = "This example demonstrates the Syncfusion Blazor Menu items with icons, text, separator and items submenu.",
                ActionDescription = new string[] {@"<p>This sample demonstrates default functionalities of the <code>Menu</code> component. Mouse hover or clicking the menu item displays the sub menu pop-up items.</p>"},
                Description = new string[] {
                    @"
                 <p>The menu component is a graphical user interface that serves as navigation header for your application or site. It provides a list of commands that can be carried out using the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.IMenu~Items.html'> Items</a> property.</p>
                 <p>More information about Blazor Context Menu component can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/menu/getting-started/'> documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DataBinding.razor",
                Url = "menu-bar/data-binding",
                TitleTag = "MenuBar . DataBinding . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to bind local data source with Syncfusion Blazor Menu control.",
                ActionDescription = new string[] {@"<p> This sample demonstrates data source binding of the menu component. Mouse hover or clicking the menu item displays the sub menu pop-up items. </p>"},
                Description = new string[] {
                    @"
                    <p>
                    The menu component loads the data through the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.IMenu~Items.html'> Items</a> property, where the data can either be structured as hierarchical or self-referential data, i.e. mapped with id and parentId fields.
                     </p>
                     <p>
                     In this demo, the component is bound with the list type data where the parent-child relation is referred by id and parentId mapping fields.
                      </p>
                     <p>More information about Blazor ContextMenu component can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/menu-bar/data-source-binding-and-custom-menu-items/'> documentation section</a>.</p>" }
            },
            new Sample
            {
                Name = "Scrollable",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Scrollable.razor",
                Url = "menu-bar/scrollable",
                TitleTag = "MenuBar . Scrollable . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to load menu and sub menus with large number of menu items in horizontal scrollable Syncfusion ASP.NET Core Blazor menu.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the <code>Scrollable</code> option in the Menu component. Click the scroll arrows to view the hidden menu items.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The menu component supports horizontal scrolling to render large menus and submenus in an adaptive way. This can be achieved by enabling the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.IMenu~EnableScrolling.html'> EnableScrolling</a> property and by restricting the corresponding menu/submenu size.
                    </p>
                    <p>
                        In this demo, the parent menu is horizontally scrollable while the submenu and nested submenu are vertically scrollable.
                    </p>
                    <p>
                        More information about Blazor Menu bar component can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/menu-bar/getting-started/"">
                            documentation
                        </a> section.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Templates.razor",
                Url = "menu-bar/templates",
                TitleTag = "MenuBar . Template . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to customize Syncfusion Blazor Menu popup items by using templates.",
                ActionDescription = new string[] { @"
                <p>
                 This sample demonstrates the template functionalities of the menu component. Mouse hover or clicking the menu item displays the sub menu pop-up items with its customized templates.
                 </p>"
                },
                Description = new string[] { @"
                <p>
                  The menu component has an option to customize menu items using the template, so that the menu items can be rendered according to the requirement.
                </p>
                <p>
                 More information about Blazor Menu bar component can be found in this <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/menu-bar/getting-started/""> documentation </a> section.
                 </p>"
                }
            },
            new Sample
            {
                Name = "Hamburger Mode",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Hamburger.razor",
                Url = "menu-bar/hamburger-menu",
                TitleTag = "MenuBar . Hamburger . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the hamburger mode of the Syncfusion Blazor Menu that enables the adaptive view.",
                ActionDescription = new string[] { @"<p>This sample demonstrates the hamburger mode in the <code>menu</code> component. </p>" },
                Description = new string[] { @"
                <p>
                 Enabling the <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.IMenu~HamburgerMode.html'> HamburgerMode </a> property makes the Menu component in adaptive view. By default, its shows header with hamburger icon in <code>Horizontal</code> orientation.
                </p>
                <p>The menu shows on clicking hamburger icon. You can use the Open and Close methods to show / hide the menu programmatically.</p>
                <p>
                 More information about Blazor Menu bar component can be found in this <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/menu-bar/getting-started/""> documentation </a> section.
                </p>" 
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Api.razor",
                Url = "menu-bar/api",
                TitleTag = "MenuBar . Api . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the supported API's and its functionalities of the Syncfusion Blazor Menu.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the customization of <code>Menu</code> component by using its properties from the property pane. Select any combination of properties from the property pane to customize <code>Menu</code> component.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this demo, default menu is rendered with minimal configuration.</p>
                    <p>This sample can be customized further with the combination of <code>Menu</code> properties from the property pane. For example,</p>
                    <ul>
                        <li>
                            You can switch to <b>Vertical</b> and <b>Horizontal</b> modes by clicking and selecting the
                            <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.IMenu~Orientation.html'> Orientation </a> mode from <i>Orientation</i> dropdownlist.
                        </li>
                        <li>
                            You can enable or disable menu items by clicking and selecting the item
                            from <i>Enable item</i> or <i>Disable item</i> dropdownlists.
                        </li>
                        <li>
                            You can also enable the show menu item on mouse click <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.IMenu~ShowItemOnClick.html'> ShowItemOnClick </a> property by checking the
                            <i>Show item on Click</i> checkbox.
                        </li>
                    </ul>
                    <p>
                        More information about Blazor Menu bar component can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/menu-bar/getting-started/"">
                            documentation section
                        </a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Toolbar Integration",
                Category = "Use Case",
                Directory = "Navigations/MenuBar",
                FileName = "Toolbar.razor",
                Url = "menu-bar/toolbar-integration",
                TitleTag = "MenuBar . Toolbar Integration . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the real use case of the Syncfusion Blazor Menu in web application. It is integrated with toolbar control.",
                ActionDescription = new string[] { @"<p> This sample demonstrates the real use case of menu component in blazor application. </p>" },
                Description = new string[] { @"
                <p>
                  Menu utilizes the items property to represent the menu bar in web application. The Toolbar component is used in this sample to make stylish menu bars.
                </p>
                <p>
                  More information about Blazor Menu bar component can be found in this
                     <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/menu-bar/getting-started/""> documentation section </a>.
                </p>" 
                }
            }

        };

        public List<Sample> Accordion { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "DefaultFunctionalities.razor",
                Url = "accordion/default-functionalities",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the default functionalities of the <code>Accordion</code>. Click on the <code>Header</code> element to expand/collapse the corresponding Accordion panel, and displays its content.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Accordion is a vertically collapsible content panel which is displaying panels, one or multiple at a time within the available space. This sample illustrates the simple Accordion rendering with <code>Multiple</code> expand mode.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                Url = "accordion/template",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Template",
                        FileName = "Template.razor"
                    },
                    new SourceCollection
                    {
                        Id = "NetworkData",
                        FileName = "NetworkData.razor"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the template functionalities of the <code>Accordion</code> component. The content of panel `Network & Connectivity` is loaded from external blazor component.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample illustrates to load an <code>Accordion</code> content from another razor page by using <code>ContentTemplate</code> property. The content of panel `Camera` is loaded based on the nested behavior of `Accordion` component.
                </p>"
                }
            },
            new Sample
            {
                Name = "Icons",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "Icons.razor",
                Url = "accordion/icons",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the icon representation of the <code>Accordion</code>. Click on the header element to expand/collapse the corresponding Accordion panel, and displays its content.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This Accordion is populated with icons which renders by mapping the <code>IconCss</code> field. This sample illustrates the some of the games list.
                    </p>"
                }
            }
        };

        public List<Sample> Toolbar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "DefaultFunctionalities.razor",
                Url = "toolbar/default-functionalities",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the default functionalities of the <code>Toolbar</code>. Select any command or click the left/right navigation icon or touch swipe to see the hidden commands of the Toolbar
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    <strong>Toolbar</strong> is a graphical control on which commands / buttons will be displayed in horizontal order.
                    By default scrolling display mode enabled when content exceeds the available viewing area.
                </p>
                <br>
                <p>
                    You can use left / right navigation icon or touch swipe to see the hidden commands of the toolbar.
                </p>
                <ul>
                    <li>
                        Initially toolbar rendered with the <code> left and right navigation</code> icon and you can see hidden commands by <code>moving in right or left</code> direction.
                    </li>
                    <li>
                        When you reach <code>right / left end of toolbar</code>, corresponding  navigation direction will be disabled.
                    </li>
                    <li>
                        You can continuously scroll the toolbar content by holding on the navigation icon.
                    </li>
                    <li>
                        In <code>devices</code> navigation icons are not available. you can touch swipe to see the hidden commands of the toolbar.
                    </li>
                </ul>
                <br />"
                }
            },
            new Sample
            {
                Name = "Popup",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Popup.razor",
                Url = "toolbar/popup",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the Popup mode in the <code>Toolbar</code>. Click the drop-down icon to open the <code>Popup</code> and see the hidden commands of the Toolbar.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Popup mode display can be enabled to view primary priority items in toolbar and secondary priority items in the popup.
                </p>
                <ul>
                    <li>
                        In first Toolbar, the popup will be shown when the content exceeds the available viewing area.
                    </li>
                    <li>
                        The second Toolbar is set with priority for specific toolbar items using <strong> <code> <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.ToolbarItem~ShowAlwaysInPopup.html"">ShowAlwaysInPopup</a></code> </strong>, which is always displayed in the popup.
                    </li>
                </ul>
                <br>
                <br>
                <p>
                    You can set priority to toolbar item using <strong> <code> <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.ToolbarItem~Overflow.html"">Overflow</a></code> </strong> property. Possible values are as follows,
                </p>
                <table style=""width:100%"">
                    <tr>
                        <th><strong>Overflow</strong></th>
                        <th><strong>Description</strong></th>
                    </tr>
                    <tr>
                        <td><code>Show</code></td>
                        <td>To display the commands in toolbar with primary priority.</td>
                    </tr>
                    <tr>
                        <td><code>Hide</code></td>
                        <td>To display the commands in popup with secondary priority.</td>
                    </tr>
                    <tr>
                        <td><code>None (default) </code></td>
                        <td>To display the commands with normal order without any priority.</td>
                    </tr>
                </table>
                <br />"
                }
            },
            new Sample
            {
                Name = "Alignment",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Alignment.razor",
                Url = "toolbar/alignment",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the aligning the <code>Toolbar</code> commands in left , right and center position.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    <strong>Toolbar</strong> commands can be aligned in left , right and center positions. By default, all the commands are left aligned. User can customize the alignment of each toolbar item using <code> <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.ToolbarItem~Align.html"">Align</a> </code> property. Possible values are as follows.
                </p><br />
                <table style=""width:100%"">
                    <tr>
                        <th><strong>Alignment Option</strong></th>
                        <th><strong>Description</strong></th>
                    </tr>
                    <tr>
                        <td><code>Left (default)</code> </td>
                        <td>To align commands to the left side of the toolbar.</td>
                    </tr>
                    <tr>
                        <td><code>Center</code> </td>
                        <td>To align commands to the center of the toolbar.</td>
                    </tr>
                    <tr>
                        <td><code>Right</code></td>
                        <td>To align commands to the right side of the toolbar.</td>
                    </tr>
                </table>"
                }
            }
        };

        public List<Sample> Tabs { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "DefaultFunctionalities.razor",
                Url = "tabs/default-functionalities",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the default functionalities of the <code>Tab</code>. Click on the <code>Header</code>  element to activate the corresponding Tab, and displays its <code>Content</code>.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    The <code>Tab</code> is a content panel to show multiple contents in specific space one at a time.
                </p>
                <p>
                    The default sample illustrates to render simple Tab by defining header and content as <code>Items</code> collections.
                </p>"
                }
            },
             new Sample
             {
                 Name = "Orientation",
                 Category = "Tabs",
                 Directory = "Navigations/Tabs",
                 FileName = "Orientation.razor",
                 Url = "tabs/orientation",
                 ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the <code>Header</code> orientation of the <code>Tab</code>. Select option from drop-downs to switch header placement and changing the header style in properties panel.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    The <code>Tab</code> allows to place the header section inside the Tab component either at <code>Top / Bottom / Left / Right</code> position by using <code>HeaderPlacement</code> property.
                </p>
                <p>
                    This sample illustrates the use of header placement and <code>ShowCloseButton</code> property.
                    Users can change the header position by changing the drop-down value options and can close the Tab item by clicking close icon in header.<br /><br />

                    The User can also view different header styles of Tab component by selecting options from `Header Styles` drop-down.
                    Header styles changed by adding predefined classes in Tab root element and it class names listed below
                    <br />
                    <ul>
                        <li>Material and Fabric theme differentiates all the available tab header styles such as <b>e-fill</b>, <b>e-background e-accent</b>.</li>
                        <li>In bootstrap theme, all the styles such as <b>e-fill</b> & <b>e-background e-accent</b> will have the same look with no difference.</li>
                    </ul>
                    If above classes not included in root element default style will applied in Tab component.
                </p>
                <p>
                    More information about Tab can be found in this <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/tab/getting-started/""> documentation </a> section.
                </p>"
                }
             },
            new Sample
            {
                Name = "Responsive Modes",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "ResponsiveModes.razor",
                Url = "tabs/responsive-modes",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates both <code>Scrollable</code> and <code>Popup</code> modes of the <code>Tab</code>. Select option from down-down to change the responsive option in property panel.
                </p>"
                },
                Description = new string[] {
                    @" <p>
                    The <code>Tab</code> is adaptable to the available space when the tab items exceed the view space.
                </p>
                <p>
                    The <code>Tab</code> allows to place the header section inside the Tab component either at <code>Top / Bottom / Left / Right</code> position by using <code>HeaderPlacement</code> property.
                </p>
                <p>
                    You can assign OverflowMode property value as <code>Scrollable / Popup</code>. By default scrollable mode of tab is enabled when tab item exceeds the view range. In this sample, users can change the <code>OverflowMode</code> by selecting the dropdown options.
                </p>
                <p>
                    More information about Tab can be found in this <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/tab/getting-started/""> documentation </a> section.
                </p>"
                }
            },
            new Sample
            {
                Name = "Wizard",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "Wizard.razor",
                Url = "tabs/wizard",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates simple train reservation wizard that Enable/Disable Tab items based on sequential validation of each Tab content.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Tab items can be disabled dynamically by passing the index and boolean value to the <a target=""_blank"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Navigations.SfTab~EnableTab.html"">EnableTab</a> method.
                </p>
                <p>
                    You can design wizard like sample with Tab using the in-built API and customizing the content with proper validations.
                </p>
                <p>
                    More information about Tab can be found in this <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/tab/getting-started/""> documentation </a> section.
                </p>"
                }
            }
        };
        public List<Sample> TreeView { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the default functionalities of the TreeView. Click on node to select it, and click on icon or double click on node to expand/collapse it. The child nodes will be loaded on expand the parent node.    </p>"
                },
                Description = new string[] {
                    @"<p>The <code>TreeView</code> component is used to display the data in a hierarchical structure with the configuration options to control the way of data is presented and manipulated. It will pull the data from a data source, such as an array of JSON objects, OData web services, or DataManager binding data fields to the <code>TreeViewFieldsSettings</code> directive.</p>
                <p>In this demo, the TreeView is populated with its minimum default settings.</p>
                <p>More information on the TreeView instantiation can be found in the <a href='https://ej2.syncfusion.com/aspnet-core-blazor/documentation/treeview/getting-started/' target='_blank'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Icons and Images",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/icons-and-images",
                FileName = "IconsandImages.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the node can be configured by icons/images in TreeView. Click on Icon or double click on node to expand/collapse it, and show the icons/images that configured with nodes.
                </p>"
                },
                Description = new string[] {
                    @"<p>The TreeView component has the built-in option to customize each node's appearance with the icons and images by mapping the IconCss and ImageUrl fields.

                    In this demo, the TreeView is showcased like a file system with custom icons and images.</p>"
                }
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/checkbox",
                FileName = "CheckBox.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the Checkbox functionalities of the TreeView. Click on any parent node's Checkbox to check/uncheck the node and its child nodes. The parent node's checked state will be determined by its child nodes checked state.
                </p>"
                },
                Description = new string[] {
                    @" <p>The <code>TreeView</code> component can be rendered with checkbox on the left side of each tree node. This allows the user to check more than one nodes, and this can be enabled by the <code>ShowCheckBox</code> property.</p>
                <p>In this demo, the TreeView is populated with checkbox enabled.</p>
                <p>For more information, you can refer to the <a href='https://ej2.syncfusion.com/aspnet-core-blazor/documentation/treeview/getting-started/' target='_blank'>Checkboxes</a> section from the documentation.</p>"
                }
            },
             new Sample
            {
                Name = "Node Editing",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/node-editing",
                FileName = "NodeEditing.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the node editing functionalities of the TreeView. Double click on the node or press F2 key on selected node to edit node's text in input textbox. Press enter key or click outside of the input element to save the node's, or press escape key to cancel the modified text.
                </p>"
                },
                Description = new string[] {
                    @"<p>The TreeView component has the built-in option to edit and modify the node text in inline by enabling the <code>AllowEditing</code> property.

                    More information about Treeview can be found in this <a target='blank' href='https://ej2.syncfusion.com/aspnet-core-blazor/documentation/treeview/node-editing/'>documentation section</a> section.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Multiple Selection",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/multiple-selection",
                FileName = "MultipleSelection.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the multiple node selection functionalities of the TreeView. To select multiple nodes, press the CTRL key and select the desired nodes; or select any node and by pressing SHIFT key select another node, this selects all the nodes in-between the selected nodes.
                </p>"
                },
                Description = new string[] {
                    @"<p>The TreeView component allows to select multiple nodes by enabling the <code>AllowMultiSelection</code> property.

                    In this demo, the TreeView is enabled with multiple selection

                    More information about Treeview can be found in this <a href='https://ej2.syncfusion.com/aspnet-core-blazor/documentation/treeview/multiple-selection/' target='_blank'>documentation section</a> section .
                    </p>"
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/template",
                FileName = "Template.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the template functionalities of the TreeView. Select the root node by clicking on it, or expand the root node and select the customized child node.
                    </p>"
                },
                Description = new string[] {
                    @" <p>The <code>TreeView</code> component  has an option to customize the node structure through the <code>NodeTemplate</code> tag, so that the tree node can be formed with any custom structure.</p>
                <p>In this demo, the node is formed as like webmail with folder name and number of unread messages.</p>"

                }
            },
              new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "treeview/local-data",
                FileName = "LocalData.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the binding of local data to the TreeView. Click on node to select it, and click on icon or double click on node to expand/collapse it.
                </p>"
                },
                Description = new string[] {
                    @"<p>The TreeView component loads the data through the dataSource property, where the data can be either local data or remote data. In case of local data, the data structure can be hierarchical data or list data (with self-referential format i.e., mapped with the Id and ParentID fields).

                    In this demo, the first TreeView is bound with the hierarchical data that contains array of nested objects. And the second TreeView is bound with the list type data where the parent-child relation is referred by the Id and ParentID mapping fields.

                    More information about Treeview can be found in this <a target='blank' href='https://ej2.syncfusion.com/aspnet-core-blazor/documentation/treeview/data-binding/'>documentation section</a> section .
                    </p>"
                }
            },
               new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "treeview/remote-data",
                FileName = "RemoteData.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the binding data to the TreeView from remote data source. On expanding the parent node, the spinner icon will be displayed until the child nodes will be loaded into parent node. Click on node to select it, and click on icon or double click on node to expand/collapse it.</p>"
                },
                Description = new string[] {
                    @"<p>
                    <p>The TreeView component loads the data through the dataSource property, where the data can be either local data or remote data. In case of remote data, the data can be loaded from any remote services though the DataManager.</p>

                    <p>The DataManager will act as an interface between the service endpoint and the TreeView, that requires the below minimal information to interact with the service endpoint.</p>

                    <p>DataManager->url - Defines the service endpoint to fetch data. DataManager->adaptor - Defines the adaptor option. By default, ODataV4Adaptor is used for remote binding.</p>

                    <p>In this demo, the TreeView is bound with the dataSource from the Northwind remote service by using the DataManager instance.</p>

                    <p>More information about Treeview can be found in this <a href='https://ej2.syncfusion.com/aspnet-core-blazor/documentation/treeview/data-binding/#remote-data' target='_blank'>documentation</a> section .</p>
                    </p>"}
            }

        };
        public List<Sample> FileManager { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/overview",
                FileName = "Overview.razor",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates the full features of the File Manager that includes toolbar, navigation pane and details view.</p>"
                },
                Description = new string[] {
                @"<p>
                    The <b>File Manager</b> component is used to explore a file system through a web application, similar to the windows explorer for windows. It supports all the basic file operations such as create, rename, delete, refresh and so on.
                </p>
                <p>
                    <b>Note: </b>File Manager's upload functionality is restricted in the online demo. If you need to test upload functionality, please install
                    <a target=""_blank"" href=""https://www.syncfusion.com/downloads"">Syncfusion Essential Studio </a>on your machine and run the demo.
                </p>"
            }
            },
             new Sample
            {
                Name = "Custom Thumbnails",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/custom-thumbnail",
                FileName = "CustomThumbnail.razor",
                ActionDescription = new string[] {
                        @"<p>This sample demonstrates the custom thumbnail of the File Manager you can customize with your own icon.</p>"
                },
                Description = new string[] {
                        @"<p>The <b>File Manager</b> component is used to explore a file system through a web application, similar to the windows explorer for windows. It supports all the basic file operations such as create, rename, delete and so on.</p>
                        <p>
                            <b>Note: </b>File Manager's upload functionality is restricted in the online demo. If you need to test upload functionality, please install
                            <a target=""_blank"" href=""https://www.syncfusion.com/downloads"">Syncfusion Essential Studio </a>on your machine and run the demo.
                        </p>"
                    }
            },
             new Sample
            {
                Name = "API",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/api",
                FileName = "API.razor",
                ActionDescription = new string[] {
                        @"<p>This sample demonstrates the properties of File Manager component from the property pane. Select any properties from the property pane to customize the File Manager.</p>"
                },
                Description = new string[] {
                        @"<p>The <b>File Manager</b> component is used to explore a file system through a web application, similar to the windows explorer for windows. It supports the basic file operations such as create, rename, delete.</p>
                        <p>
                            <b>Note: </b>File Manager's upload functionality is restricted in the online demo. If you need to test upload functionality, please install
                            <a target=""_blank"" href=""https://www.syncfusion.com/downloads"">Syncfusion Essential Studio </a>on your machine and run the demo.
                        </p>"
                }
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/drag-and-drop",
                FileName = "DragAndDrop.razor",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates the drag-and-drop feature of the File Manager. To drag and drop the file, select and drag a desired file or folder and drop it into the target folder. The File Manager component allows users to drag any file and drop it on any other folder in the same or different folder using the <code>AllowDragAndDrop</code> property.</p>"
                },
                Description = new string[] {
                @"<p>
                    The <b>File Manager</b> component is used to explore a file system through a web application, similar to the windows explorer for windows. It supports all the basic file operations such as create, rename, delete, refresh and so on.
                </p>
                <p>
                    <b>Note: </b>File Manager's upload functionality is restricted in the online demo. If you need to test upload functionality, please install
                    <a target=""_blank"" href=""https://www.syncfusion.com/downloads"">Syncfusion Essential Studio </a>on your machine and run the demo.
                </p>"
            }
            },
            new Sample
            {
                Name = "Azure Blob Storage",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/azure",
                FileName = "Azure.razor",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to utilize the Azure blob storage with File Manager component. To run the service, create the Azure blob storage account and register the Azure storage details like account name, password, and blob name details within the Register Azure method.</p>"
                },
                Description = new string[] {
                @"<p>
                    The <b>File Manager</b> component is used to explore a file system through a web application, similar to the windows explorer for windows. It supports all the basic file operations such as create, rename, delete, refresh and so on.
                </p>
                <p>
                    <b>Note: </b>File Manager's upload functionality is restricted in the online demo. If you need to test upload functionality, please install
                    <a target=""_blank"" href=""https://www.syncfusion.com/downloads"">Syncfusion Essential Studio </a>on your machine and run the demo.
                </p>"
            }
            }

        };

    }
}
