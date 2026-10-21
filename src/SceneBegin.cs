using System.Windows.Forms;
using Vortice.Mathematics;

class SceneBegin : SceneBase
{
    override public void Init()
    {
        Console.WriteLine("SceneBegin::Init");
    }
    override public void Destroy()
    {
            
        Console.WriteLine("SceneBegin::Destroy");
    }
    override public void Update()
    {
        
    }
    override public void Render()
    {
        Message?.DrawText("SceneBegin"
            , new Rect(20, 10, 600, 100)
            , new Color4(0.0F, 1.0F, 1.0F, 1.0F));
    }
}
