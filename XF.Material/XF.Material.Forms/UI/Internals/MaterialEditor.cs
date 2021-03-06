﻿using System.ComponentModel;
using Xamarin.Forms;

namespace XF.Material.Forms.UI.Internals
{
    /// <inheritdoc />
    /// <summary>
    /// Used for rendering the <see cref="T:Xamarin.Forms.Editor" /> control in <see cref="T:XF.Material.Forms.UI.MaterialTextArea" />.
    /// </summary>
    [DesignTimeVisible(true)]
    public class MaterialEditor : Editor
    {
        public static readonly BindableProperty TintColorProperty = BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(MaterialEditor), Material.Color.Secondary);

        public Color TintColor
        {
            get => (Color)this.GetValue(TintColorProperty);
            set => this.SetValue(TintColorProperty, value);
        }
    }
}