namespace UD2_Ejemplo_BindingMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // No usar MainPage = ... aquí
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
