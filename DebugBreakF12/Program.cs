// See https://aka.ms/new-console-template for more information

using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

Console.WriteLine("Hello, World!");

using var window = new MyGameWindow(GameWindowSettings.Default, NativeWindowSettings.Default);

window.Run();

public class MyGameWindow : GameWindow
{
    public MyGameWindow(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
        : base(gameWindowSettings, nativeWindowSettings)
    {
    }

    private double TotalTime { get; set; }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        TotalTime += args.Time;
        
        if (KeyboardState[Keys.F12])
        {
            TotalTime = 0;
        }
    }

    protected override void OnRenderFrame(FrameEventArgs args)
    {
        GL.Clear(ClearBufferMask.ColorBufferBit);
        GL.ClearColor(Color4.FromHsv(new Vector4((float)TotalTime % 10f / 10f, 1.0f, 0.5f, 1.0f)));
        SwapBuffers();
    }

    protected override void OnResize(ResizeEventArgs e)
    {
        base.OnResize(e);
        GL.Viewport(0, 0, e.Width, e.Height);
    }
}