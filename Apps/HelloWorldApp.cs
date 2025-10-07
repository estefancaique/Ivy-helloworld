namespace HelloWorldApp.Apps;

[App(icon: Icons.Sparkles, title: "Hello World")]
public class HelloWorldApp : ViewBase
{
    public override object? Build()
    {
        var nameState = UseState("");
        var client = UseService<IClientProvider>();

        return Layout.Center()
            | (new Card(
                Layout.Vertical().Gap(6).Padding(4)
                | Text.H1("🎉 Hello World with Ivy!")
                | Text.P("Welcome to your first Ivy application. This is a simple demonstration of the Ivy framework.")
                | Layout.Vertical().Gap(3)
                    | Text.Lead("What's your name?")
                    | nameState.ToTextInput()
                        .Placeholder("Enter your name here...")
                | (string.IsNullOrEmpty(nameState.Value) 
                    ? Text.Muted("👋 Hello there!")
                    : Text.H2($"👋 Hello, {nameState.Value}!"))
                | new Separator()
                | Layout.Horizontal().Gap(3)
                    | new Button("Say Hello", _ => 
                        {
                            if (!string.IsNullOrEmpty(nameState.Value))
                            {
                                client.Toast($"Hello, {nameState.Value}! Welcome to Ivy! 🎊", "Greeting");
                            }
                            else
                            {
                                client.Toast("Please enter your name first! 😊", "Info");
                            }
                        })
                    | new Button("Clear", _ => nameState.Set(""))
                        .Variant(ButtonVariant.Secondary)
                | new Separator()
                | Text.Small("Built with ❤️ using the Ivy Framework")
                | Text.Markdown("⭐ Star us on [GitHub](https://github.com/Ivy-Interactive/Ivy-Framework)")
            )
            .Width(Size.Units(120).Max(500)));
    }
}