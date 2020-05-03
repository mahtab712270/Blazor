using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace EmpManagment.Web.Pages {
    public class DisplayEmployeeBase: ComponentBase {

        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

        public bool IsSelected { get; set; } = false;

        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e) {

            await OnEmployeeSelection.InvokeAsync((bool)e.Value);

            }
        }
    }
