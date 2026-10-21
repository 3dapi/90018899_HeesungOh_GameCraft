using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SceneBase
{
    public static int SCENE_PHASE_BEGIN = 0;
    public static int SCENE_PHASE_LOBBY = 1;
    public static int SCENE_PHASE_PLAY   = 2;
    public static int SCENE_PHASE_RESULT = 3;

    private G2Font? message;

    internal G2Font? Message { get => message; set => message = value; }

    public SceneBase()
    {
        Message = new G2Font("Arial", 48);
    }
    virtual public void Init()
    {
        Console.WriteLine("SceneBase::Init");
    }
    virtual public void Destroy()
    {
        Message.Dispose();
        Console.WriteLine("SceneBase::Destroy");
    }
    virtual public void Update()
    {
        Console.WriteLine("SceneBase::Update");
    }
    virtual public void Render()
    {
        Console.WriteLine("SceneBase::Render");
    }
}
