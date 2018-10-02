using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Lenovo.Models
{
    public class Laptop
    {
        public int LaptopID { get; set; }
        public string Name { get; set; }
        public ImageSource CoverImage { get; set; }
        public string Specification { get; set; }
    }
    public class LaptopManager
    {
        public static List<Laptop> GetLaptops()
        {
            string strImgPath1 = "ms-appx:///Assets/Laptops/1.png";
            string strImgPath2 = "ms-appx:///Assets/Laptops/4.png";
            string strImgPath3 = "ms-appx:///Assets/Laptops/3.png";
            var laptops = new List<Laptop>();
            laptops.Add(new Laptop
            {
                LaptopID = 1,
                Name = "ThinkPad A485",
                CoverImage = new BitmapImage(new Uri(strImgPath1, UriKind.Absolute)),
                Specification = "Raise the bar for business-class The lightweight 14 ThinkPad A485 is a heavyweight when it comes to boosting performance—the latest AMD Ryzen™ Pro processing and Radeon™ Vega™ graphics make multitasking a cinch. Biometric and encryption security protect critical data. And the 4G LTE-A option means you’re always connected, regardless of WiFi range."
            });

            laptops.Add(new Laptop
            {
                LaptopID = 2,
                Name = "ThinkPad 11e (4th Gen)",
                CoverImage = new BitmapImage(new Uri(strImgPath2, UriKind.Absolute)),
                Specification = "Digital education demands a special kind of PC. Rugged and durable enough to withstand classroom use, yet versatile enough to support students’ learning needs. You can find it all in the ThinkPad 11e, a laptop specifically engineered for students and their teachers."
            });
            laptops.Add(new Laptop
            {
                LaptopID = 3,
                Name = "ThinkPad Yoga 11e Chromebook",
                CoverImage = new BitmapImage(new Uri(strImgPath3, UriKind.Absolute)),
                Specification = "With its extra-durable design, this 2-in-1 Chromebook is engineered to withstand the rigors of the classroom. A flexible 360-degree hinge and 10-point multitouch display accommodates just about any work style. The lightweight portability of just 3.5 pounds makes the Yoga 11e perfect for on-the-go learning and either one-to-one or shared computing. Students and teachers enjoy access to tons of educational apps for fun and easy learning, while IT administrators appreciate fast system setup and flexible management capabilities to deliver unique classroom experiences to each teacher."
            });
            laptops.Add(new Laptop
            {
                LaptopID = 3,
                Name = "ThinkPad Yoga 11e Chromebook",
                CoverImage = new BitmapImage(new Uri(strImgPath2, UriKind.Absolute)),
                Specification = "With its extra-durable design, this 2-in-1 Chromebook is engineered to withstand the rigors of the classroom. A flexible 360-degree hinge and 10-point multitouch display accommodates just about any work style. The lightweight portability of just 3.5 pounds makes the Yoga 11e perfect for on-the-go learning and either one-to-one or shared computing. Students and teachers enjoy access to tons of educational apps for fun and easy learning, while IT administrators appreciate fast system setup and flexible management capabilities to deliver unique classroom experiences to each teacher."
            });
            laptops.Add(new Laptop
            {
                LaptopID = 3,
                Name = "ThinkPad Yoga 11e Chromebook",
                CoverImage = new BitmapImage(new Uri(strImgPath2, UriKind.Absolute)),
                Specification = "With its extra-durable design, this 2-in-1 Chromebook is engineered to withstand the rigors of the classroom. A flexible 360-degree hinge and 10-point multitouch display accommodates just about any work style. The lightweight portability of just 3.5 pounds makes the Yoga 11e perfect for on-the-go learning and either one-to-one or shared computing. Students and teachers enjoy access to tons of educational apps for fun and easy learning, while IT administrators appreciate fast system setup and flexible management capabilities to deliver unique classroom experiences to each teacher."
            });
            laptops.Add(new Laptop
            {
                LaptopID = 3,
                Name = "ThinkPad Yoga 11e Chromebook",
                CoverImage = new BitmapImage(new Uri(strImgPath2, UriKind.Absolute)),
                Specification = "With its extra-durable design, this 2-in-1 Chromebook is engineered to withstand the rigors of the classroom. A flexible 360-degree hinge and 10-point multitouch display accommodates just about any work style. The lightweight portability of just 3.5 pounds makes the Yoga 11e perfect for on-the-go learning and either one-to-one or shared computing. Students and teachers enjoy access to tons of educational apps for fun and easy learning, while IT administrators appreciate fast system setup and flexible management capabilities to deliver unique classroom experiences to each teacher."
            });

            return laptops;
        }
    }
}
