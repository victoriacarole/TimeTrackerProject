#pragma checksum "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a73ab017f612e9453146f194700ba1543c89f3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TimeTrackerProject.Pages.Groups.Pages_Groups_GroupTimecard), @"mvc.1.0.razor-page", @"/Pages/Groups/GroupTimecard.cshtml")]
namespace TimeTrackerProject.Pages.Groups
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\_ViewImports.cshtml"
using TimeTrackerProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{groupId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a73ab017f612e9453146f194700ba1543c89f3c", @"/Pages/Groups/GroupTimecard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df32640c29c658cbc3627aec0ff3d30e7a46d5c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Groups_GroupTimecard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../AddTimecard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;margin:0px 5px 5px 0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Groups", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;margin: 0px 5px 0px 0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
  
    ViewData["Title"] = "Group TimeCard";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a73ab017f612e9453146f194700ba1543c89f3c5097", async() => {
                WriteLiteral("Add Time");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a73ab017f612e9453146f194700ba1543c89f3c6415", async() => {
                WriteLiteral(" All Groups");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <td><h1>");
#nullable restore
#line 14 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
           Write(Model.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></td>\r\n    </tr>\r\n    <tr class=\"headerRow\">\r\n        <td>Start Time</td>\r\n        <td>End Time</td>\r\n        <td>Work Comments</td>\r\n        <td>Total Hours</td>\r\n        <td>User Id</td>\r\n    </tr>\r\n");
#nullable restore
#line 23 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
     foreach (var timeCard in Model.UserTimes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
           Write(timeCard.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
           Write(timeCard.Stop);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
           Write(timeCard.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
           Write(timeCard.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
           Write(timeCard.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\joeys\Source\Repos\TimeTrackerProject\TimeTrackerProject\Pages\Groups\GroupTimecard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr class=""headerRow"">
        <td>Total Hours: </td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>   

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a73ab017f612e9453146f194700ba1543c89f3c10488", async() => {
                WriteLiteral("Add Time");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a73ab017f612e9453146f194700ba1543c89f3c11807", async() => {
                WriteLiteral(" All Groups");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""piechart""></div>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<script type=""text/javascript"">
    // Load google charts
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(drawChart);

    // Draw the chart and set the chart values
    function drawChart() {
        var data = google.visualization.arrayToDataTable([

           ['Task', 'Hours per Day'],
            ['Work', 8],
            ['Friends', 2],
            ['Eat', 2],
            ['TV', 2],
            ['Gym', 2],
            ['Sleep', 8]
        ]);

        // Optional; add a title and set the width and height of the chart
        var options = { 'title': 'My Average Day', 'width': 550, 'height': 400 };

        // Display the chart inside the <div> element with id=""piechart""
        var chart = new google.visualization.PieChart(document.getElementById('piechart'));
               chart.draw(data, options);
    ");
            WriteLiteral("}\r\n</script>\r\n\r\n");
            WriteLiteral(@"<style>

    header {
        background: white;
    }

    footer {
        display: none;
    }

    body {
        background-color: #492365;
        background-image: url('../images/4703133.jpg');
        background-position: center;
        background-repeat: no-repeat;
        background-attachment: fixed;
        background-size: 100%;
    }

    .table {
        background-color: white;
        margin: 0px;
        margin-bottom: 5px;
        margin-top: 5px;
    }

    .headerRow {
        font-weight: bold;
    }

    .btn {
        background-color: #009844;
        color: white;
        font-weight: bold;
        border-style: none;
    }

        .btn:hover {
            background-color: #00C957;
            border-style: none;
        }

        .btn:disabled {
            opacity: 0.6;
            cursor: not-allowed;
        }
</style>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeTrackerProject.Pages.GroupTimecardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TimeTrackerProject.Pages.GroupTimecardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TimeTrackerProject.Pages.GroupTimecardModel>)PageContext?.ViewData;
        public TimeTrackerProject.Pages.GroupTimecardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
