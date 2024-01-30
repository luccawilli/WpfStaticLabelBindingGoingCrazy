# WpfStaticLabelBindingGoingCrazy
## Problem: 
- Start a new c# xaml project.
- Create a new window or custom control --> just a .xaml File
- Add a Resource-File to the control --> .resx
- Add a Label and use it via static in your control
- Building works, but at the runtime a MissingManifestResourceException will be thrown
- => Something like "sub assembly was not included in the build output, check for .resource" will be thrown
- => To fix this, add the "\<DependentUpon>MainWindow.xaml.cs\</DependentUpon>" to the "\<EmbeddedResource Update="MainWindow.xaml.resx">" and it will work again.


This is a sample project to show the problem.