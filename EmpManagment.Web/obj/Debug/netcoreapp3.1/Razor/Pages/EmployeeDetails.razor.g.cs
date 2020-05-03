#pragma checksum "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ffdec104f144bdd3fda88e0869af1b2e9bf31d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee Details</h3>\r\n");
#nullable restore
#line 7 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
 if (Employee == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 9 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
    } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "       ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-deck");
            __builder.AddMarkupContent(5, "\r\n           ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                                  Mouse_Move

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "card m-3");
            __builder.AddAttribute(9, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.AddMarkupContent(10, "\r\n               ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-header");
            __builder.AddMarkupContent(13, "\r\n                   ");
            __builder.AddContent(14, 
#nullable restore
#line 13 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                    Coordinate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n               ");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 15 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                                                              Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n               ");
            __builder.OpenElement(21, "h3");
            __builder.AddContent(22, 
#nullable restore
#line 18 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                    Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " ");
            __builder.AddContent(24, 
#nullable restore
#line 18 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                                        Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n               ");
            __builder.OpenElement(26, "h4");
            __builder.AddContent(27, "EmployeeId :");
            __builder.AddContent(28, 
#nullable restore
#line 19 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                                Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n               ");
            __builder.OpenElement(31, "h4");
            __builder.AddContent(32, "DepartmentName: ");
            __builder.AddContent(33, 
#nullable restore
#line 20 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                                     Employee.Department==null?"": Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n               ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                                                        Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, " ");
            __builder.AddContent(40, 
#nullable restore
#line 21 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                                                                         ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n               ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card-footer" + " " + (
#nullable restore
#line 22 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                                        CssClass

#line default
#line hidden
#nullable disable
            ) + " text-center");
            __builder.AddMarkupContent(44, "\r\n\r\n                   ");
            __builder.AddMarkupContent(45, "<a href=\"/\" class=\"btn btn-primary m-1\">Back</a>\r\n\r\n                   ");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "href", 
#nullable restore
#line 26 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
                              $"EditEmployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "class", "btn btn-primary m-1");
            __builder.AddContent(49, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n                   ");
            __builder.AddMarkupContent(51, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>\r\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n           ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 32 "D:\Study\BlazorStudy\EmpManagment\EmpManagment.Web\Pages\EmployeeDetails.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591