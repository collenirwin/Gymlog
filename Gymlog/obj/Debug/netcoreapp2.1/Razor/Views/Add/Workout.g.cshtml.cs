#pragma checksum "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Add\Workout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04d0f1b76ba656cb60a0257967e48c2d4062bab4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Add_Workout), @"mvc.1.0.view", @"/Views/Add/Workout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Add/Workout.cshtml", typeof(AspNetCore.Views_Add_Workout))]
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
#line 1 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog;

#line default
#line hidden
#line 2 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04d0f1b76ba656cb60a0257967e48c2d4062bab4", @"/Views/Add/Workout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221afc43e64317c4f1fa0904c7b9307c191dcbcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Add_Workout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-on:submit", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Add\Workout.cshtml"
  
    ViewData["Title"] = "Add Workout";

#line default
#line hidden
            BeginContext(49, 384, true);
            WriteLiteral(@"
<div id=""workout-container"">
    <hr />
    <input type=""text"" class=""form-control"" placeholder=""Workout Name"" name=""workout-name"" v-model=""workoutName""/>
    <hr />
    <div id=""workout-exercise-container"">
        <workout-exercise v-for=""x in exercises"" :exercise=""x"" />
    </div>

    <button class=""btn btn-default"" v-on:click=""addExercise"">Add Exercise</button>
    ");
            EndContext();
            BeginContext(433, 357, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7be6c5617b2743bfa04629d0dc705607", async() => {
                BeginContext(472, 311, true);
                WriteLiteral(@"
        <input type=""hidden"" name=""data"" id=""data"" />
        <input type=""hidden"" name=""name"" id=""workout-name"" />
        <input type=""submit"" class=""btn btn-default"" value=""Save Workout""
               style=""position: fixed; bottom: 50px; right: 50px; color:#9d9d9d; background-color:#101010;"" />
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(790, 2494, true);
            WriteLiteral(@"
</div>

<script type=""text/x-template"" id=""workout-exercise-template"">
    <div>
        <input type=""text"" class=""form-control"" placeholder=""Exercise Name"" name=""exercise-name"" v-model=""exercise.name"" />
        <table class=""table"">
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
                    <th>

                    </th>
                </tr>
            </thead>
            <tbody>
                <tr v-for=""(row, x) in exercise.rows"" :key=""x"">
                    <td>
                        {{row.setNumber}}
                    </td>
                    <td>
                        <input min=""1"" type=""number"" v-model=""row.reps"" />
                    </td>
                    <td>
                        <input type=""text"" v-mode");
            WriteLiteral(@"l=""row.comments"" />
                    </td>
                </tr>
            </tbody>
        </table>
        <button class=""btn btn-default"" v-on:click=""addRow"" style=""margin-bottom: 20px;"">Add Set</button>
    </div>
</script>

<script>
    class Exercise {
        constructor() {
            this.name = """";
            this.rows = [new Row(1)];
        }
    }
    class Row {
        constructor(setNumber) {
            this.setNumber = setNumber;
            this.reps = 1;
            this.comments = """";
        }
    }

    const ExerciseComponent = Vue.component(""workout-exercise"", {
        template: ""#workout-exercise-template"",
        props: [""exercise""],
        data() {
            return {
                nextSetNumber: 2
            };
        },
        methods: {
            addRow() {
                this.exercise.rows.push(new Row(this.nextSetNumber++));
            }
        }
    });

    new Vue({
        el: ""#workout-container"",
        data:");
            WriteLiteral(@" {
            workoutName: """",
            exercises: [new Exercise()]
        },
        methods: {
            addExercise() {
                this.exercises.push(new Exercise());
            },
            post() {
                document.getElementById(""data"").value = JSON.stringify(this.exercises);
                document.getElementById(""workout-name"").value = this.workoutName;
            }
        }
    });
</script>
");
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
