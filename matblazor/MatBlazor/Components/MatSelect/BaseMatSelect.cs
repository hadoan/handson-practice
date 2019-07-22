﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MatBlazor
{
    /// <summary>
    /// Selects allow users to select from a single-option menu. It functions as a wrapper around the browser's native select element.
    /// </summary>
    public class BaseMatSelect : BaseMatDomComponent
    {
        private string _value;

        public BaseMatSelect()
        {
            ClassMapper
                .Add("mat-select")
                .Add("mdc-select")
                .If("mdc-select--outlined", () => Outlined)
                .If("mdc-select--disabled", () => Disabled);
        }

        [Parameter]
        protected RenderFragment ChildContent { get; set; }

//        [Parameter]
        protected bool Enhanced { get; set; } = false;

        [Parameter]
        protected bool Outlined { get; set; }

        [Parameter]
        protected bool Disabled { get; set; }

        [Parameter]
        protected string Label { get; set; }

        [Parameter]
        protected string Value
        {
            get => _value;
            set
            {
                if (value != _value)
                {
                    _value = value;
                    ValueChanged.InvokeAsync(value);
                }
            }
        }

        [Parameter]
        protected EventCallback<string> ValueChanged { get; set; }

        public void OnChangeHandler(UIChangeEventArgs e)
        {
            Value = (string) e.Value;
        }

        protected async override Task OnFirstAfterRenderAsync()
        {
            await base.OnFirstAfterRenderAsync();
            await Js.InvokeAsync<object>("matBlazor.matSelect.init", Ref);
        }
    }
}