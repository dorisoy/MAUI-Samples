using Xamarin.Forms;

#if ANDROID
[assembly: Dependency(typeof(HelloForms.HelloAndroid))]
#elif IOS
[assembly: Dependency(typeof(HelloForms.HelloiOS))]
#endif

namespace HelloForms
{
    interface IHelloService
    {
        string Hello();
    }

#if ANDROID
    class HelloAndroid : IHelloService
    {
        public string Hello() => "Hello Android,\nfrom Xamarin.Forms!";
    }
#elif IOS
    class HelloiOS : IHelloService
    {
        public string Hello() => "Hello iOS,\nfrom Xamarin.Forms!";
    }
#endif
}