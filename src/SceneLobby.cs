using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortice.Mathematics;

class SceneLobby : SceneBase
{
    override public void Init()
    {
        Console.WriteLine("SceneLobby::Init");
    }
    override public void Destroy()
    {
        Console.WriteLine("SceneLobby::Destroy");
    }
    override public void Update()
    {
        Console.WriteLine("SceneLobby::Update");
    }
    override public void Render()
    {
        Message?.DrawText("SceneLobby"
            , new Rect(20, 10, 600, 100)
            , new Color4(0.0F, 1.0F, 1.0F, 1.0F));
    }
}

