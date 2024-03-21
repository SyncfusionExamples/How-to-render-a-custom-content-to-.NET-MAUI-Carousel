using Syncfusion.Maui.Carousel;
using Syncfusion.Maui.Core.Carousel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Carousel {
    public partial class MainPage : ContentPage {
        public MainPage() {
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
            var carouselDataTemplate = new DataTemplate(() => {

                var stack = new StackLayout();
                var buttonText = new Button() { TextColor = Colors.DarkGreen, FontSize = 20, BackgroundColor = Color.FromArgb("#a9afb0"), HeightRequest = 200, WidthRequest = 200 };
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


    }
    public class CarouselModel {
        public CarouselModel(string buttonstr, string labelstr)
        {
            ButtonString = buttonstr;
            LabelString = labelstr;
        }
        public string ButtonString { get; set; }
        public string LabelString { get; set; }
    }
}