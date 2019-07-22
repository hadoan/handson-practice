﻿using Microsoft.AspNetCore.Components;

namespace MatBlazor
{
    public class BaseMatOption : ComponentBase
    {
        [Parameter]
        protected RenderFragment ChildContent { get; set; }

        [Parameter]
        protected bool Disabled { get; set; }

        [Parameter]
        protected string Value { get; set; }
    }
}