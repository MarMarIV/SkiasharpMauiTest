using SkiaSharp;
using SkiaSharp.Views.Maui;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		SKCanvasViewRef.EnableTouchEvents = true;
		SKCanvasViewRef.Touch += OnTouch;
		SKCanvasViewRef.PaintSurface += OnPaintSurface;
	}

    private void OnTouch(object? sender, SKTouchEventArgs e)
    {
        e.Handled = true;
    }

    private void OnPaintSurface(object? sender, SKPaintSurfaceEventArgs e)
    {
		var c = e.Surface.Canvas;
		//var r = e.Info.Rect;
		var r = new SKRect(100, 100, 200, 200);

		c.Clear();

		using(var p = new SKPaint())
		{
			p.Style = SKPaintStyle.StrokeAndFill;
			p.Color = SKColors.Red;		
			c.DrawRect(r, p);
		}
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
	}
}

