﻿using Microsoft.AspNetCore.Components;

namespace eTasks.Components.Bars
{
    /// <summary>
    /// Implementação da barra superior
    /// </summary>
    public class TopBarBase: ComponentBase
    {
        [Parameter] public string Height { get; set; } = "60px";
        [Parameter] public RenderFragment? ChildContent { get; set; }
        [Parameter] public bool isDarkMode { get; set; } = false;
        [Parameter] public TopBarPosition? Position { get; set; } = TopBarPosition.FixedTop;

        protected string CorFundo { get; set; } = "white";
        protected string BarPosition { get; set; } = "fixed-top";
        protected string Sombra { get; set; } = "0 4px 8px rgba(0, 0, 0, 0.2)";

        protected override void OnParametersSet()
        {
            CorFundo = ColorPallete.GetColor(Cor.Background, isDarkMode);
            //Sombra = ColorPallete.GetColor(Cor.Shadow, isDarkMode);
            switch(Position)
            {
                case TopBarPosition.FixedTop:
                    BarPosition = "fixed-top";
                    Sombra = ColorPallete.GetColor(Cor.Shadow, isDarkMode);
                    break;
                case TopBarPosition.FixedBottom:
                    BarPosition = "fixed-bottom";
                    Sombra = ColorPallete.GetColor(Cor.Shadow, isDarkMode);
                    break;
                case TopBarPosition.None:
                    BarPosition = "";
                    Sombra = "None";
                    break;
                default:
                    BarPosition = "fixed-top";
                    Sombra = ColorPallete.GetColor(Cor.Shadow, isDarkMode);
                    break;
            }
        }
    }

    public enum TopBarPosition
    {
        FixedTop,
        FixedBottom,
        None
    }
}
