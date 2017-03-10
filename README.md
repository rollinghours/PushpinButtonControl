# PushpinButtonControl
A pushpin button control for WPF. Has built-in overridable "pinned vs. unpinned" images.  
Background and border properties can be set separately for each button state.
Based on ToggleButton.

## How To Install
Install the nuget package or build ```Rh.PushpinButton.Control``` and add reference to it
from your application project. Add the namespace mapping ```xmlns:rh="http://schemas.rollinghours.com/wpf"```
to the Window element in your XAML file, then use the button like in an example below.

## Sample Use
Default:
```xml
          <rh:PushpinButton />
```
No border, custom colors:
```xml
          <rh:PushpinButton MouseOverBackground="LightGoldenrodYellow"
                            BorderThickness="0" 
                            PressedBackground="PaleGoldenrod"
                            CheckedBackground="{Binding Background, RelativeSource={RelativeSource Self}}"/>
```
Custom glyph pics:
```xml
          <rh:PushpinButton EnabledPinnedImageSource="pack://application:,,,/MyApp;component/customPinned.png"
                            EnabledUnpinnedImageSource="pack://application:,,,/MyApp;component/customUnpinned.png" />
```
Unpinned glyph is hidden until mouse hover:
```xml
          <rh:PushpinButton Width="Auto" 
                            IsHiddenUnpinnedGlyph="True"
                            CheckedBackground="{Binding Background, RelativeSource={RelativeSource Self}}">
              <TextBlock Text="Hover over"/>
          </rh:PushpinButton>
```
Transparent:
```xml
          <rh:PushpinButton Cursor="Hand" 
                            Background="Transparent" BorderBrush="Transparent"
                            MouseOverBackground="Transparent" 
                            MouseOverBorder="Transparent"
                            PressedBackground="Transparent" 
                            PressedBorder="Transparent"
                            CheckedBackground="Transparent" 
                            CheckedBorder="Transparent" />
```
A custom styled glyph pic:
```xml
          <rh:PushpinButton EnabledPinnedImageSource="{Binding EnabledUnpinnedImageSource, RelativeSource={RelativeSource Self}}"
                            DisabledPinnedImageSource="{Binding DisabledUnpinnedImageSource, RelativeSource={RelativeSource Self}}"
                            DisabledUnpinnedImageSource="{Binding DisabledUnpinnedImageSource, RelativeSource={RelativeSource Self}}">
              <rh:PushpinButton.ImageStyle>
                  <Style TargetType="Image">
                      <Setter Property="RenderTransformOrigin" Value=".5,.5" />
                      <Setter Property="RenderTransform" >
                          <Setter.Value>
                              <RotateTransform Angle="-45" />
                          </Setter.Value>
                      </Setter>
                  </Style>
              </rh:PushpinButton.ImageStyle>
          </rh:PushpinButton>
```          
