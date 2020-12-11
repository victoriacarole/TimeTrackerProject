#pragma checksum "C:\Users\ianbr\Desktop\TimeTracker\TimeTrackerProject\TimeTrackerProject\Pages\AddTimecard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8279cee6c4c8997b6e2bdb402ec092c1eca2090a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TimeTrackerProject.Pages.Pages_AddTimecard), @"mvc.1.0.razor-page", @"/Pages/AddTimecard.cshtml")]
namespace TimeTrackerProject.Pages
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
#line 1 "C:\Users\ianbr\Desktop\TimeTracker\TimeTrackerProject\TimeTrackerProject\Pages\_ViewImports.cshtml"
using TimeTrackerProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8279cee6c4c8997b6e2bdb402ec092c1eca2090a", @"/Pages/AddTimecard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df32640c29c658cbc3627aec0ff3d30e7a46d5c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddTimecard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"createTimecard\">\r\n    <h1>Create New Timecard</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8279cee6c4c8997b6e2bdb402ec092c1eca2090a3474", async() => {
                WriteLiteral(@"
        <div class=""row my-1"">
            <div class=""col-3"">
                <label>Username:</label>
            </div>
            <div class=""col-9"">
                <input id=""txtName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""row my-1"">
            <div class=""col-3"">
                <label>Time In:</label>
            </div>
            <div class=""col-9"">
                <input id=""timein""");
                BeginWriteAttribute("value", " value=\"", 620, "\"", 628, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" class=""form-control "" />
            </div>
        </div>
        <div class=""row my-1"">
            <div class=""col-3"">
                <label>Time Out:</label>
            </div>
            <div class=""col-9"">
                <input id=""timeout""");
                BeginWriteAttribute("value", " value=\"", 899, "\"", 907, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""row my-1"">
            <div class=""col-3"">
                <label>Comments:</label>
            </div>
            <div class=""col-9"">
                <textarea style=""height:100px;"" class=""form-control""></textarea>
            </div>
        </div>
        
        <button type=""submit"" id=""btnAddTime"" onclick=""return validateInput()"" value=""Add Time"" class=""btn btn-primary"">Add Time</button> <a onclick=""goBack()"" class=""btn btn-primary"" style=""color:white;"">Cancel</a>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        function goBack() {
            window.history.back();
        }


        $(function () {
            $(""#timein"").timepicker({ 'minTime': '1:00 AM', 'maxTime': '12:00 PM', step: '30' });
            $(""#timeout"").timepicker({ 'minTime': '1:00 AM', 'maxTime': '12:00 PM', step: '30' });
        });

        function validateInput() {
            var timeIn = document.getElementById(""timein"").value;
            var timeOut = document.getElementById(""timeout"").value;


            if (time.toString() == '') {
                swal(""Error"", ""Please select Start Time"", ""error"");
                return false;
            }
            if (name.toString() == '') {
                swal(""Error"", ""Please select End Time"", ""error"");
                return false;
            }
            return true;
        }

    </script>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>

    header {
        background: white;
    }

    footer {
        background: black;
        opacity: .7;
    }

    body {
        /* background-color: #492365; */
        background-image: url('../images/4703133.jpg');
        background-position: center;
        background-repeat: no-repeat;
        background-attachment: fixed;
        background-size: 100%;
    }

    /* Specific to page */
    .createTimecard {
        /* center on page */
        margin: 0px;
        position: absolute;
        top: 50%;
        left: 50%;
        -ms-transform: translate(-50%, -50%);
        transform: translate(-50%, -50%);
        /* other adjustments */
        padding: 30px;
        background-color: white;
    }

    .btn {
        background-color: #009844;
        color: white;
        font-weight: bold;
        border-style: none;
        margin: 2px;
    }

        .btn:hover {
            background-color: #00C957;
            border-style: none;
      ");
            WriteLiteral("  }\r\n\r\n        .btn:disabled {\r\n            opacity: 0.6;\r\n            cursor: not-allowed;\r\n        }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeTrackerProject.Pages.AddTimecardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TimeTrackerProject.Pages.AddTimecardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TimeTrackerProject.Pages.AddTimecardModel>)PageContext?.ViewData;
        public TimeTrackerProject.Pages.AddTimecardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
