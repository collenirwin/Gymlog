#pragma checksum "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618576d97514d898072d55bc80e0d6385d271cd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Saved_Workout), @"mvc.1.0.view", @"/Views/Saved/Workout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Saved/Workout.cshtml", typeof(AspNetCore.Views_Saved_Workout))]
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
#line 1 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog;

#line default
#line hidden
#line 2 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618576d97514d898072d55bc80e0d6385d271cd2", @"/Views/Saved/Workout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221afc43e64317c4f1fa0904c7b9307c191dcbcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Saved_Workout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymlog.Models.Workout>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Saved", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Workouts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
            BeginContext(74, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(81, 10, false);
#line 6 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(91, 16, true);
            WriteLiteral("</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(107, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9c08792701d49b599087a6511a3ac5a", async() => {
                BeginContext(167, 19, true);
                WriteLiteral("View Saved Workouts");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 10 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
 foreach (var workoutExercise in Model.WorkoutExercises)
{

#line default
#line hidden
            BeginContext(259, 8, true);
            WriteLiteral("    <h3>");
            EndContext();
            BeginContext(268, 28, false);
#line 12 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
   Write(workoutExercise.ExerciseName);

#line default
#line hidden
            EndContext();
            BeginContext(296, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(305, 332, true);
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Set
                </th>
                <th>
                    Reps
                </th>
                <th>
                    Comments
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 29 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
             foreach (var set in workoutExercise.Sets)
            {

#line default
#line hidden
            BeginContext(708, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(781, 13, false);
#line 33 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
                   Write(set.SetNumber);

#line default
#line hidden
            EndContext();
            BeginContext(794, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(874, 8, false);
#line 36 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
                   Write(set.Reps);

#line default
#line hidden
            EndContext();
            BeginContext(882, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(962, 12, false);
#line 39 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
                   Write(set.Comments);

#line default
#line hidden
            EndContext();
            BeginContext(974, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
            }

#line default
#line hidden
            BeginContext(1041, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 45 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workout.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymlog.Models.Workout> Html { get; private set; }
    }
}
#pragma warning restore 1591
