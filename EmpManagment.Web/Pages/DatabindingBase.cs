using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagment.Web.Pages {
    public class DatabindingBase: ComponentBase {

        protected string Name { get; set; } = "Tom";

        protected string Desctiption { get; set; } = string.Empty;

        protected string Gender { get; set; } = "Male";



        }
    }
