# Xamarin XamaTime
Xamarin cross-platform to practice with threads

## Nuget Packages

### [Matcha.BackgroundService](https://github.com/winstongubantes/MatchaBackgroundService)

#### For Android

You call the "Init" method before all libraries initialization in MainActivity class.

```c#
public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
{
    protected override void OnCreate(Bundle bundle)
    {
        BackgroundAggregator.Init(this);
        
        base.OnCreate(bundle);
        ....// Code for init was here
    }
}
```

#### For iOS

You call the "Init" method before all libraries initialization in FinishedLaunching method in FormsApplicationDelegate class.

```c#
public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
{
    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
         BackgroundAggregator.Init(this);
         
        ....// Code for init was here
         return base.FinishedLaunching(app, options);
    }
}
```

#### For UWP

First, You call the "Init" method before all libraries initialization in MainPage class.

```c#
public sealed partial class MainPage
{
    public MainPage()
    {
        this.InitializeComponent();
        
        BackgroundAggregator.Init(this);
        
        LoadApplication(new SampleBackground.App(new UwpInitializer()));
    }
}
```
