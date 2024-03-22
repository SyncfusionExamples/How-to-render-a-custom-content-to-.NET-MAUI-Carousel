# How-to-render-a-custom-content-to-.NET-MAUI-Carousel

This section demonstrates how to render custom content in a .NET MAUI Carousel. Custom views can be rendered by utilizing the ItemTemplate property of the Carousel. This property allows customization of the contents of carousel items. Follow these steps to render custom views:

**C#**

**Model**
```
public class CarouselModel 
{
    public CarouselModel(string buttonstr, string labelstr)
    {
        ButtonString = buttonstr;
        LabelString = labelstr;
    }
    public string ButtonString { get; set; }
    public string LabelString { get; set; }
}
```
**C#**

```
 public MainPage() 
 {
     InitializeComponent();

     SfCarousel sfCarousel = new SfCarousel();            

     var carouselModel = new List<CarouselModel> 
     {
     new CarouselModel ("Button1","Label1"),
     new CarouselModel ("Button2","Label2"),
     new CarouselModel ("Button3","Label3"),
     new CarouselModel ("Button4","Label4"),
     new CarouselModel ("Button5","Label5")
     };
     var carouselDataTemplate = new DataTemplate(() =>
     {

         var stack = new StackLayout();
         var buttonText = new Button() { TextColor = Colors.DarkGreen, FontSize =20, BackgroundColor = Color.FromArgb("#a9afb0"), HeightRequest = 200, WidthRequest = 200 };
         buttonText.SetBinding(Button.TextProperty, "ButtonString");
         var labelText = new Label() { TextColor = Colors.Red, FontSize = 20, HorizontalOptions = LayoutOptions.Center };
         labelText.SetBinding(Label.TextProperty, "LabelString");

         stack.Children.Add(buttonText);
         stack.Children.Add(labelText);

         return stack;

     });
     sfCarousel.ItemTemplate = carouselDataTemplate;
     sfCarousel.ItemsSource = carouselModel;
     this.Content = sfCarousel;
 }
```
## How to run this application?

To run this application, you need to first clone the How-to-render-a-custom-content-to-.NET-MAUI-Carousel repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.

