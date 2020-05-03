using EmpManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmpManagment.Web.Pages {
    public class EmployeeListBase : ComponentBase {

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        public bool ShowFooter { get; set; } = true;


       

        protected override async Task OnInitializedAsync() {
            Employees = (await EmployeeService.GetEmployees()).ToList();

            }

        public int SelectedEmployeeCount { get; set; } = 0;

        public void EmployeeSelectionChanged(bool IsSelected) {
            if (IsSelected) {
                SelectedEmployeeCount++;
                } else {
                SelectedEmployeeCount--;
                }

            }


        }
    }
