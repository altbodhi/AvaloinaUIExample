using Avalonia.Controls;
using Domain;
using System;

namespace ava
{
    public class MainWindow : Window
    {
        public MainWindow() : base()
        {
            Title = "NetcoreApp 2.0";
            this.Width = 800;
            this.Height = 640;
            var panel = new StackPanel();
            Content = panel;
            var button = new Button { Content = "Hello!" };
            var name = new TextBox { Text = Environment.UserName};
            var text = new TextBox();

            panel.Children.Add(new TextBlock { Text = "Name:" });
            panel.Children.Add(name);
            panel.Children.Add(button);
            panel.Children.Add(new TextBlock { Text = "Answer:" });
            panel.Children.Add(text);
            button.Click += (o, e) => text.Text = text.Text = Say.hello(name.Text);
        }
    }
}