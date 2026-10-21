using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortice.Mathematics;

class SceneResult : SceneBase
{
    override public void Init()
    {

    }
    override public void Destroy()
    {

    }
    override public void Update()
    {

    }
    override public void Render()
    {
        Message?.DrawText("ScenePlay"
            , new Rect(20, 10, 600, 100)
            , new Color4(0.0F, 1.0F, 1.0F, 1.0F));
    }
}

