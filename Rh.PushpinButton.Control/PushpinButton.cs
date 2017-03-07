#region Copyright (c) 2015 Rollinghours.com owners (rhours@outlook.com)
/* The MIT License (MIT) for Rh.PushpinButton.Control
Copyright (c) 2015 Rollinghours.com owners (rhours@outlook.com)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
and associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, 
sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial 
portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT 
NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH 
THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

/* All the included images are taken from the Microsoft Visual Studio Image Library, 
   Copyright 2015 Microsoft Corporation */
#endregion

using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Rh.PushpinButton.Control {

    public class PushpinButton : ToggleButton {
        static PushpinButton() {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(PushpinButton)
                , new FrameworkPropertyMetadata(typeof(PushpinButton)));

        }

        public ImageSource EnabledPinnedImageSource {
            get { return (ImageSource)GetValue(EnabledPinnedImageSourceProperty); }
            set { SetValue(EnabledPinnedImageSourceProperty, value); }
        }

        public static readonly DependencyProperty EnabledPinnedImageSourceProperty =
            DependencyProperty.Register("EnabledPinnedImageSource", typeof(ImageSource), typeof(PushpinButton)
                , new PropertyMetadata(default(ImageSource)));




        public ImageSource DisabledPinnedImageSource {
            get { return (ImageSource)GetValue(DisabledPinnedImageSourceProperty); }
            set { SetValue(DisabledPinnedImageSourceProperty, value); }
        }

        public static readonly DependencyProperty DisabledPinnedImageSourceProperty =
            DependencyProperty.Register("DisabledPinnedImageSource", typeof(ImageSource), typeof(PushpinButton)
                , new PropertyMetadata(default(ImageSource)));



        public ImageSource EnabledUnpinnedImageSource {
            get { return (ImageSource)GetValue(EnabledUnpinnedImageSourceProperty); }
            set { SetValue(EnabledUnpinnedImageSourceProperty, value); }
        }

        public static readonly DependencyProperty EnabledUnpinnedImageSourceProperty =
            DependencyProperty.Register("EnabledUnpinnedImageSource", typeof(ImageSource), typeof(PushpinButton)
                , new PropertyMetadata(default(ImageSource)));




        public ImageSource DisabledUnpinnedImageSource {
            get { return (ImageSource)GetValue(DisabledUnpinnedImageSourceProperty); }
            set { SetValue(DisabledUnpinnedImageSourceProperty, value); }
        }

        public static readonly DependencyProperty DisabledUnpinnedImageSourceProperty =
            DependencyProperty.Register("DisabledUnpinnedImageSource", typeof(ImageSource), typeof(PushpinButton)
                , new PropertyMetadata(default(ImageSource)));




        public SolidColorBrush MouseOverBackground {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.MouseOverBackgroundProperty))); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty = DependencyProperty.Register("MouseOverBackground", typeof(SolidColorBrush), typeof(PushpinButton));




        public SolidColorBrush MouseOverBorder {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.MouseOverBorderProperty))); }
            set { SetValue(MouseOverBorderProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBorderProperty = DependencyProperty.Register("MouseOverBorder", typeof(SolidColorBrush), typeof(PushpinButton));




        public SolidColorBrush PressedBackground {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.PressedBackgroundProperty))); }
            set { SetValue(PressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty PressedBackgroundProperty = DependencyProperty.Register("PressedBackground", typeof(SolidColorBrush), typeof(PushpinButton));




        public SolidColorBrush PressedBorder {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.PressedBorderProperty))); }
            set { SetValue(PressedBorderProperty, value); }
        }

        public static readonly DependencyProperty PressedBorderProperty = DependencyProperty.Register("PressedBorder", typeof(SolidColorBrush), typeof(PushpinButton));




        public SolidColorBrush CheckedBackground {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.CheckedBackgroundProperty))); }
            set { SetValue(CheckedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedBackgroundProperty = DependencyProperty.Register("CheckedBackground", typeof(SolidColorBrush), typeof(PushpinButton));




        public SolidColorBrush CheckedBorder {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.CheckedBorderProperty))); }
            set { SetValue(CheckedBorderProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderProperty = DependencyProperty.Register("CheckedBorder", typeof(SolidColorBrush), typeof(PushpinButton));




        public SolidColorBrush DisabledBackground {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.DisabledBackgroundProperty))); }
            set { SetValue(DisabledBackgroundProperty, value); }
        }

        public static readonly DependencyProperty DisabledBackgroundProperty = DependencyProperty.Register("DisabledBackground", typeof(SolidColorBrush), typeof(PushpinButton));




        public SolidColorBrush DisabledBorder {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.DisabledBorderProperty))); }
            set { SetValue(DisabledBorderProperty, value); }
        }

        public static readonly DependencyProperty DisabledBorderProperty = DependencyProperty.Register("DisabledBorder", typeof(SolidColorBrush), typeof(PushpinButton));


        public SolidColorBrush DisabledForeground {
            get { return ((SolidColorBrush)(GetValue(PushpinButton.DisabledForegroundProperty))); }
            set { SetValue(DisabledForegroundProperty, value); }
        }

        public static readonly DependencyProperty DisabledForegroundProperty = DependencyProperty.Register("DisabledForeground", typeof(SolidColorBrush), typeof(PushpinButton));


        public bool IsHiddenUnpinnedGlyph {
            get { return ((bool)(GetValue(IsHiddenUnpinnedGlyphProperty))); }
            set { SetValue(IsHiddenUnpinnedGlyphProperty, value); }
        }

        public static DependencyProperty IsHiddenUnpinnedGlyphProperty = DependencyProperty.Register("IsHiddenUnpinnedGlyph", typeof(bool), typeof(PushpinButton), new PropertyMetadata(false));


        public Style ImageStyle {
            get { return ((Style)(GetValue(ImageStyleProperty))); }
            set { SetValue(ImageStyleProperty, value); }
        }

        public static DependencyProperty ImageStyleProperty = DependencyProperty.Register("ImageStyle", typeof(Style), typeof(PushpinButton));


    }
}
