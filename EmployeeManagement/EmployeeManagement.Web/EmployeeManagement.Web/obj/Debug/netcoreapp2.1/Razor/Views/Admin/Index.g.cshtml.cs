#pragma checksum "F:\C Partition\Documents\Tejas Training\EmployeeManagement\EmployeeManagement.Web\EmployeeManagement.Web\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf767b2ddf827dd7bc99bf248be0c840fabc1dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf767b2ddf827dd7bc99bf248be0c840fabc1dc", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c15daa2e20f26dbe094095664c43e65e9f5dbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "F:\C Partition\Documents\Tejas Training\EmployeeManagement\EmployeeManagement.Web\EmployeeManagement.Web\Views\Admin\Index.cshtml"
   
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(38, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(46, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c851f45d69a4249b5fc5f57f18a69f0", async() => {
                BeginContext(52, 28, true);
                WriteLiteral("\r\n    <title>Admin</title>\r\n");
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
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(89, 16768, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce66df560d7c483299c53b46ee85978a", async() => {
                BeginContext(95, 16755, true);
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div class=""block-header"">
            <h2>ADMIN-DASHBOARD</h2>
        </div>

        <!-- Widgets -->
        <div class=""row clearfix"">
            <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                <div class=""info-box bg-pink hover-expand-effect"">
                    <div class=""icon"">
                        <i class=""material-icons"">playlist_add_check</i>
                    </div>
                    <div class=""content"">
                        <div class=""text"">NEW TASKS</div>
                        <div class=""number count-to"" data-from=""0"" data-to=""125"" data-speed=""15"" data-fresh-interval=""20""></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                <div class=""info-box bg-cyan hover-expand-effect"">
                    <div class=""icon"">
                        <i class=""material-icons"">help</i>
                    </d");
                WriteLiteral(@"iv>
                    <div class=""content"">
                        <div class=""text"">NEW TICKETS</div>
                        <div class=""number count-to"" data-from=""0"" data-to=""257"" data-speed=""1000"" data-fresh-interval=""20""></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                <div class=""info-box bg-light-green hover-expand-effect"">
                    <div class=""icon"">
                        <i class=""material-icons"">forum</i>
                    </div>
                    <div class=""content"">
                        <div class=""text"">NEW COMMENTS</div>
                        <div class=""number count-to"" data-from=""0"" data-to=""243"" data-speed=""1000"" data-fresh-interval=""20""></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                <div class=""info-box bg-orange hover-expand-effect"">
");
                WriteLiteral(@"                    <div class=""icon"">
                        <i class=""material-icons"">person_add</i>
                    </div>
                    <div class=""content"">
                        <div class=""text"">NEW VISITORS</div>
                        <div class=""number count-to"" data-from=""0"" data-to=""1225"" data-speed=""1000"" data-fresh-interval=""20""></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Widgets -->
        <!-- CPU Usage -->
        <div class=""row clearfix"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""card"">
                    <div class=""header"">
                        <div class=""row clearfix"">
                            <div class=""col-xs-12 col-sm-6"">
                                <h2>CPU USAGE (%)</h2>
                            </div>
                            <div class=""col-xs-12 col-sm-6 align-right"">
                                <div class=");
                WriteLiteral(@"""switch panel-switch-btn"">
                                    <span class=""m-r-10 font-12"">REAL TIME</span>
                                    <label>OFF<input type=""checkbox"" id=""realtime"" checked><span class=""lever switch-col-cyan""></span>ON</label>
                                </div>
                            </div>
                        </div>
                        <ul class=""header-dropdown m-r--5"">
                            <li class=""dropdown"">
                                <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">more_vert</i>
                                </a>
                                <ul class=""dropdown-menu pull-right"">
                                    <li><a href=""javascript:void(0);"">Action</a></li>
                                    <li><a href=""javascript:void(0);"">Another action</a></li>
           ");
                WriteLiteral(@"                         <li><a href=""javascript:void(0);"">Something else here</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                    <div class=""body"">
                        <div id=""real_time_chart"" class=""dashboard-flot-chart""></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# CPU Usage -->
        <div class=""row clearfix"">
            <!-- Visitors -->
            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card"">
                    <div class=""body bg-pink"">
                        <div class=""sparkline"" data-type=""line"" data-spot-Radius=""4"" data-highlight-Spot-Color=""rgb(233, 30, 99)"" data-highlight-Line-Color=""#fff""
                                data-min-Spot-Color=""rgb(255,255,255)"" data-max-Spot-Color=""rgb(255,255,255)"" data-spot-Color=""rgb(255,255,255)""
                           ");
                WriteLiteral(@"     data-offset=""90"" data-width=""100%"" data-height=""92px"" data-line-Width=""2"" data-line-Color=""rgba(255,255,255,0.7)""
                                data-fill-Color=""rgba(0, 188, 212, 0)"">
                            12,10,9,6,5,6,10,5,7,5,12,13,7,12,11
                        </div>
                        <ul class=""dashboard-stat-list"">
                            <li>
                                TODAY
                                <span class=""pull-right""><b>1 200</b> <small>USERS</small></span>
                            </li>
                            <li>
                                YESTERDAY
                                <span class=""pull-right""><b>3 872</b> <small>USERS</small></span>
                            </li>
                            <li>
                                LAST WEEK
                                <span class=""pull-right""><b>26 582</b> <small>USERS</small></span>
                            </li>
                        </ul>
              ");
                WriteLiteral(@"      </div>
                </div>
            </div>
            <!-- #END# Visitors -->
            <!-- Latest Social Trends -->
            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card"">
                    <div class=""body bg-cyan"">
                        <div class=""m-b--35 font-bold"">LATEST SOCIAL TRENDS</div>
                        <ul class=""dashboard-stat-list"">
                            <li>
                                #socialtrends
                                <span class=""pull-right"">
                                    <i class=""material-icons"">trending_up</i>
                                </span>
                            </li>
                            <li>
                                #materialdesign
                                <span class=""pull-right"">
                                    <i class=""material-icons"">trending_up</i>
                                </span>
                            </li>
    ");
                WriteLiteral(@"                        <li>#adminbsb</li>
                            <li>#freeadmintemplate</li>
                            <li>#bootstraptemplate</li>
                            <li>
                                #freehtmltemplate
                                <span class=""pull-right"">
                                    <i class=""material-icons"">trending_up</i>
                                </span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- #END# Latest Social Trends -->
            <!-- Answered Tickets -->
            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card"">
                    <div class=""body bg-teal"">
                        <div class=""font-bold m-b--35"">ANSWERED TICKETS</div>
                        <ul class=""dashboard-stat-list"">
                            <li>
                                TODAY
                 ");
                WriteLiteral(@"               <span class=""pull-right""><b>12</b> <small>TICKETS</small></span>
                            </li>
                            <li>
                                YESTERDAY
                                <span class=""pull-right""><b>15</b> <small>TICKETS</small></span>
                            </li>
                            <li>
                                LAST WEEK
                                <span class=""pull-right""><b>90</b> <small>TICKETS</small></span>
                            </li>
                            <li>
                                LAST MONTH
                                <span class=""pull-right""><b>342</b> <small>TICKETS</small></span>
                            </li>
                            <li>
                                LAST YEAR
                                <span class=""pull-right""><b>4 225</b> <small>TICKETS</small></span>
                            </li>
                            <li>
                             ");
                WriteLiteral(@"   ALL
                                <span class=""pull-right""><b>8 752</b> <small>TICKETS</small></span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- #END# Answered Tickets -->
        </div>
        <div class=""row clearfix"">
            <!-- Task Info -->
            <div class=""col-xs-12 col-sm-12 col-md-8 col-lg-8"">
                <div class=""card"">
                    <div class=""header"">
                        <h2>TASK INFOS</h2>
                        <ul class=""header-dropdown m-r--5"">
                            <li class=""dropdown"">
                                <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">more_vert</i>
                                </a>
                                <ul class=""dropdown-menu pull-rig");
                WriteLiteral(@"ht"">
                                    <li><a href=""javascript:void(0);"">Action</a></li>
                                    <li><a href=""javascript:void(0);"">Another action</a></li>
                                    <li><a href=""javascript:void(0);"">Something else here</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                    <div class=""body"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover dashboard-task-infos"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Task</th>
                                        <th>Status</th>
                                        <th>Manager</th>
                                        <th>Progress</th>
                                    </tr>
                ");
                WriteLiteral(@"                </thead>
                                <tbody>
                                    <tr>
                                        <td>1</td>
                                        <td>Task A</td>
                                        <td><span class=""label bg-green"">Doing</span></td>
                                        <td>John Doe</td>
                                        <td>
                                            <div class=""progress"">
                                                <div class=""progress-bar bg-green"" role=""progressbar"" aria-valuenow=""62"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 62%""></div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>2</td>
                                        <td>Task B</td>
                                        <td><span class=""label");
                WriteLiteral(@" bg-blue"">To Do</span></td>
                                        <td>John Doe</td>
                                        <td>
                                            <div class=""progress"">
                                                <div class=""progress-bar bg-blue"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 40%""></div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>3</td>
                                        <td>Task C</td>
                                        <td><span class=""label bg-light-blue"">On Hold</span></td>
                                        <td>John Doe</td>
                                        <td>
                                            <div class=""progress"">
                                                <div class=""progress-bar");
                WriteLiteral(@" bg-light-blue"" role=""progressbar"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 72%""></div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>4</td>
                                        <td>Task D</td>
                                        <td><span class=""label bg-orange"">Wait Approvel</span></td>
                                        <td>John Doe</td>
                                        <td>
                                            <div class=""progress"">
                                                <div class=""progress-bar bg-orange"" role=""progressbar"" aria-valuenow=""95"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 95%""></div>
                                            </div>
                                        </td>
                                    </tr>
         ");
                WriteLiteral(@"                           <tr>
                                        <td>5</td>
                                        <td>Task E</td>
                                        <td>
                                            <span class=""label bg-red"">Suspended</span>
                                        </td>
                                        <td>John Doe</td>
                                        <td>
                                            <div class=""progress"">
                                                <div class=""progress-bar bg-red"" role=""progressbar"" aria-valuenow=""87"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 87%""></div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!-- ");
                WriteLiteral(@"#END# Task Info -->
            <!-- Browser Usage -->
            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card"">
                    <div class=""header"">
                        <h2>BROWSER USAGE</h2>
                        <ul class=""header-dropdown m-r--5"">
                            <li class=""dropdown"">
                                <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">more_vert</i>
                                </a>
                                <ul class=""dropdown-menu pull-right"">
                                    <li><a href=""javascript:void(0);"">Action</a></li>
                                    <li><a href=""javascript:void(0);"">Another action</a></li>
                                    <li><a href=""javascript:void(0);"">Something else here</a></li>
                            ");
                WriteLiteral(@"    </ul>
                            </li>
                        </ul>
                    </div>
                    <div class=""body"">
                        <div id=""donut_chart"" class=""dashboard-donut-chart""></div>
                    </div>
                </div>
            </div>
            <!-- #END# Browser Usage -->
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
            BeginContext(16857, 9, true);
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
