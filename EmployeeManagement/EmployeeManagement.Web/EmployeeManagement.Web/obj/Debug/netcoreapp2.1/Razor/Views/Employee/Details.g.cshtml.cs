#pragma checksum "F:\C Partition\Documents\Tejas Training\EmployeeManagement\EmployeeManagement.Web\EmployeeManagement.Web\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3eb9b295f04d834bbc259f24dcc864022f82523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Details.cshtml", typeof(AspNetCore.Views_Employee_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\C Partition\Documents\Tejas Training\EmployeeManagement\EmployeeManagement.Web\EmployeeManagement.Web\Views\_ViewImports.cshtml"
using Emp.Web;

#line default
#line hidden
#line 2 "F:\C Partition\Documents\Tejas Training\EmployeeManagement\EmployeeManagement.Web\EmployeeManagement.Web\Views\_ViewImports.cshtml"
using Emp.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3eb9b295f04d834bbc259f24dcc864022f82523", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c15daa2e20f26dbe094095664c43e65e9f5dbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\C Partition\Documents\Tejas Training\EmployeeManagement\EmployeeManagement.Web\EmployeeManagement.Web\Views\Employee\Details.cshtml"
   
    Layout = "_FInalLayout";

#line default
#line hidden
            BeginContext(38, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(46, 3859, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "239bf3b8b32b4194b2e49344af05dde9", async() => {
                BeginContext(52, 3846, true);
                WriteLiteral(@"
    <style>
        body {
            margin: 0;
            font-family: 'Roboto';
            font-size: 14px;
            background: rgba(0, 0, 0,0);
        }

        h3 {
            color: black;
            font-size: 24px;
            text-align:left;
            margin-top: 0px;
            padding-bottom: 10px;
            border-bottom: 1px solid #eee;
            margin-bottom: 10px;
            font-weight: 300;
        }

        div[class*='col-'] {
            padding: 0 30px;
        }

        .wrap {
            box-shadow: 0px 2px 2px 0px rgba(0, 0, 0, 0.14), 0px 3px 1px -2px rgba(0, 0, 0, 0.2), 0px 1px 5px 0px rgba(0, 0, 0, 0.12);
            border-radius: 4px;
        }

        a:focus,
        a:hover,
        a:active {
            outline: 0;
            text-decoration: none;
        }

        .panel {
            border-width: 0 0 1px 0;
            border-style: solid;
            border-color: #fff;
            background: none;
    ");
                WriteLiteral(@"        box-shadow: none;
        }

            .panel:last-child {
                border-bottom: none;
            }

        .panel-group > .panel:first-child .panel-heading {
            border-radius: 4px 4px 0 0;
        }

        .panel-group .panel {
            border-radius: 0;
        }

            .panel-group .panel + .panel {
                margin-top: 0;
            }

        .panel-heading {
            background-color: #009688;
            border-radius: 0;
            border: none;
            color: #fff;
            padding: 0;
        }

        .panel-title a {
            display: block;
            color: #fff;
            padding: 15px;
            position: relative;
            font-size: 16px;
            font-weight: 400;
        }

        .panel-body {
            background: #fff;
            font-size:15px;
        }

        .panel:last-child .panel-body {
            border-radius: 0 0 4px 4px;
        }

        .panel:last");
                WriteLiteral(@"-child .panel-heading {
            border-radius: 0 0 4px 4px;
            transition: border-radius 0.3s linear 0.2s;
        }

            .panel:last-child .panel-heading.active {
                border-radius: 0;
                transition: border-radius linear 0s;
            }
        /* #bs-collapse icon scale option */

        .panel-heading a:before {
            content: '\e146';
            position: absolute;
            font-family: 'Material Icons';
            right: 5px;
            top: 10px;
            font-size: 24px;
            transition: all 0.5s;
            transform: scale(1);
        }

        .panel-heading.active a:before {
            content: ' ';
            transition: all 0.5s;
            transform: scale(0);
        }

        #bs-collapse .panel-heading a:after {
            content: ' ';
            font-size: 24px;
            position: absolute;
            font-family: 'Material Icons';
            right: 5px;
            top: 10p");
                WriteLiteral(@"x;
            transform: scale(0);
            transition: all 0.5s;
        }

        #bs-collapse .panel-heading.active a:after {
            content: '\e909';
            transform: scale(1);
            transition: all 0.5s;
        }
        /* #accordion rotate icon option */

        #accordion .panel-heading a:before {
            content: '\e316';
            font-size: 24px;
            position: absolute;
            font-family: 'Material Icons';
            right: 5px;
            top: 10px;
            transform: rotate(180deg);
            transition: all 0.5s;
        }

        #accordion .panel-heading.active a:before {
            transform: rotate(0deg);
            transition: all 0.5s;
        }
		
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3905, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3907, 7602, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25caeae612da488c9ff48f89b341a3eb", async() => {
                BeginContext(3913, 7589, true);
                WriteLiteral(@"
    <div class=""container"">
        <div>
            <h3>Details</h3>
            <div class=""panel-group wrap"" id=""bs-collapse"">

                <div class=""panel"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#"" href=""#one"">
                                Personal Details
                            </a>
                        </h4>
                    </div>
                    <div id=""one"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <div class=""form-horizontal"">

                                <div class=""form-group"">
                                    <label class=""control-label col-md-2"">Date Of Birth : </label>
                                    <div class=""col-md-10"">
                                        <label class=""control-label"">28/07/1997</label>
                                   ");
                WriteLiteral(@" </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""control-label col-md-2"">Contact No. : </label>
                                    <div class=""col-md-10"">
                                        <label class=""control-label"">7218901376</label>
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""control-label col-md-2"">Highest Qualification : </label>
                                    <div class=""col-md-10"">
                                        <label class=""control-label"">B.Sc</label>
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""control-label col-md-2"">Type Of Employee : </label>
                        ");
                WriteLiteral(@"            <div class=""col-md-10"">
                                        <label class=""control-label"">Full-Time</label>
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""control-label col-md-2"">Gender : </label>
                                    <div class=""col-md-10"">
                                        <label class=""control-label"">Male</label>
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""control-label col-md-2"">Start Date : </label>
                                    <div class=""col-md-10"">
                                        <label class=""control-label"">08/10/2018</label>
                                    </div>
                                </div>

                                <div clas");
                WriteLiteral(@"s=""form-group"">
                                    <label class=""control-label col-md-2"">End Date : </label>
                                    <div class=""col-md-10"">
                                        <label class=""control-label""> </label>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>
                <!-- end of panel -->

                <div class=""panel"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#"" href=""#two"">
                                Permanent Address
                            </a>
                        </h4>
                    </div>
                    <div id=""two"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <div class=""");
                WriteLiteral(@"body table-responsive"">
                                <table class=""table table-bordered table-hover"">
                                    <tr>
                                        <th>Address</th>
                                        <th>Active Status</th>
                                        <th>Actions</th>
                                    </tr>

                                    <tr>
                                        <td>
                                            A/P Khadpoli Wakanwadi,Tal-Chiplun, Dist-Ratnagiri, Maharashtra-415603
                                        </td>
                                        <td></td>
                                        <td>
                                            <button type=""button"" data-parent=""#accordion"" data-toggle=""ajax-modal"" class=""btn btn-primary waves-effect"">
                                                <span class=""glyphicon glyphicon-edit"" aria-hidden=""true""></span>
                                ");
                WriteLiteral(@"                <span><strong>Edit</strong></span>
                                            </button>
                                            <button id=""btndeletepermanent"" type=""button"" class=""btn btn btn-danger waves-effect"">
                                                <span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span>
                                                <span><strong>Delete</strong></span>
                                            </button>

                                        </td>

                                    </tr>



                                </table>
                            </div>
                            
                        </div>

                    </div>
                </div>
                <!-- end of panel -->

                <div class=""panel"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" da");
                WriteLiteral(@"ta-parent=""#"" href=""#three"">
                                Current Addresses
                            </a>
                        </h4>
                    </div>
                    <div id=""three"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            The days have gone down in the West behind the hills into shadow. Who shall gather the smoke of the deadwood burning, Or behold the flowing years from the Sea returning?
                        </div>
                    </div>
                </div>
                <!-- end of panel -->

                <div class=""panel"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#"" href=""#four"">
                                Emergency Addresses
                            </a>
                        </h4>
                    </div>
                    <div id=""four"" clas");
                WriteLiteral(@"s=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            They have passed like rain on the mountain, like a wind in the meadow; The days have gone down in the West behind the hills into shadow.
                        </div>
                    </div>
                </div>
                <!-- end of panel -->

            </div>

        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11509, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591