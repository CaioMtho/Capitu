using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;

namespace Capitu.UI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void LoadFileBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        var path = await GetFilePath();
        StatusText.Text = "Caminho do arquivo: " + path;
        
    }

    private async Task<string?> GetFilePath()
    {
        var topLevel = GetTopLevel(this) ?? throw new InvalidOperationException("Erro de TopLevel");
        var file = await topLevel.StorageProvider.OpenFilePickerAsync(
            new FilePickerOpenOptions
            {
                Title = "Selecione um arquivo para diagramação",
                AllowMultiple = false,
                FileTypeFilter =
                [
                    new FilePickerFileType("Textos")
                    {
                        Patterns = ["*.txt", "*.pdf", "*.docx"]
                    }
                ]
            });
        
        return file.Count > 0 ? file[0].Path.LocalPath : null;
    }
}