#pragma checksum "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "195846b1e2ac4e1d13328e9e9c9c2a3f7be08f3d"
// <auto-generated/>
#pragma warning disable 1591
namespace EmpManagment.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using EmpManagment.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using EmpManagment.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\_Imports.razor"
using Mahtab.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditEmployee/{id}")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
 if (Employee != null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.AddMarkupContent(5, "<h3>Edit Employee</h3>\r\n        <hr>\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group row");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n                First Name\r\n            </label>\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-sm-10");
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "firstName");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "First Name");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.AddMarkupContent(26, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n                Last Name\r\n            </label>\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-sm-10");
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "id", "lastName");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "placeholder", "Last Name");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                        Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group row");
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.AddMarkupContent(43, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n                Email\r\n            </label>\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-sm-10");
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "id", "email");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "placeholder", "Email");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                        Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group row");
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.AddMarkupContent(60, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n                Department\r\n            </label>\r\n            ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col-sm-10");
                __builder2.AddMarkupContent(63, "\r\n                ");
                __Blazor.EmpManagment.Web.Pages.EditEmployee.TypeInference.CreateCustomInputSelect_0(__builder2, 64, 65, "department", 66, "form-control", 67, 
#nullable restore
#line 41 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                                                Employee.DepartmentId

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DepartmentId = __value, Employee.DepartmentId)), 69, () => Employee.DepartmentId, 70, (__builder3) => {
                    __builder3.AddMarkupContent(71, "\r\n");
#nullable restore
#line 42 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                     foreach (var dept in Departments) {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(72, "                        ");
                    __builder3.OpenElement(73, "option");
                    __builder3.AddAttribute(74, "value", 
#nullable restore
#line 43 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                        dept.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(75, 
#nullable restore
#line 43 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                                            dept.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\r\n");
#nullable restore
#line 44 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(77, "                ");
                }
                );
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group row");
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.AddMarkupContent(84, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n                Gender\r\n            </label>\r\n            ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-sm-10");
                __builder2.AddMarkupContent(87, "\r\n                ");
                __Blazor.EmpManagment.Web.Pages.EditEmployee.TypeInference.CreateInputSelect_1(__builder2, 88, 89, "Gender", 90, "form-control", 91, 
#nullable restore
#line 53 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                                      Employee.Gender

#line default
#line hidden
#nullable disable
                , 92, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Gender = __value, Employee.Gender)), 93, () => Employee.Gender, 94, (__builder3) => {
                    __builder3.AddMarkupContent(95, "\r\n");
#nullable restore
#line 54 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                     foreach (var gender in Enum.GetValues(typeof(Gender))) {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(96, "                        ");
                    __builder3.OpenElement(97, "option");
                    __builder3.AddAttribute(98, "value", 
#nullable restore
#line 55 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                        gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(99, 
#nullable restore
#line 55 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                                 gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\r\n");
#nullable restore
#line 56 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(101, "                ");
                }
                );
                __builder2.AddMarkupContent(102, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group row");
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.AddMarkupContent(108, "<label for=\"dateOfBirth\" class=\"col-sm-2 col-form-label\">\r\n                Date Of Birth\r\n            </label>\r\n            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "col-sm-10");
                __builder2.AddMarkupContent(111, "\r\n                ");
                __Blazor.EmpManagment.Web.Pages.EditEmployee.TypeInference.CreateInputDate_2(__builder2, 112, 113, "dateOfBirth", 114, "form-control", 115, "DateOfBrith", 116, 
#nullable restore
#line 66 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"
                                        Employee.DateOfBrith

#line default
#line hidden
#nullable disable
                , 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DateOfBrith = __value, Employee.DateOfBrith)), 118, () => Employee.DateOfBrith);
                __builder2.AddMarkupContent(119, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 70 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EditEmployee.razor"

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EmpManagment.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Mahtab.Components.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591