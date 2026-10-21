// -------------------------------------------------------------------------------------------------------------------------------------------------------------
// Author: 3dapi (https://github.com/3dapi)
// -------------------------------------------------------------------------------------------------------------------------------------------------------------

using Vortice.Mathematics;

class GameMain : G2AppBase
{
	public override System.Drawing.Size ScreenSize => GameGlobal.ScreenSize;
	public override string GameName => GameGlobal.GameName;

	protected override void Initialize()
	{
        //---------------------------------------
        // 게임 관련 객체를 생성합니다.
        //---------------------------------------

        gameSceneCurrent.Init();

    }

	protected override void Update()
	{
		//double elapsed = TotalTime;
		//this.ClearColor = new Color4(
		//	red: (float)(Math.Sin(elapsed) * 0.5 + 0.5),
		//	green: (float)(Math.Sin(elapsed + Math.PI / 2.0) * 0.5 + 0.5),
		//	blue: (float)(Math.Sin(elapsed + Math.PI) * 0.5 + 0.5),
		//	alpha: 1.0f);

		//---------------------------------------
		// 게임 관련 객체를 갱신합니다.
		//---------------------------------------
		gameSceneCurrent.Update();
    }

	protected override void Render()
	{
        //---------------------------------------
        // 게임 관련 객체를 렌더링 합니다.
        //---------------------------------------

        gameSceneCurrent.Render();
    }

	public override void Dispose()
	{
		base.Dispose();
        //---------------------------------------
        // 게임 관련 객체를 해제합니다.
        //---------------------------------------
    }

    public GameMain()
	{
		gameScene.Add(new SceneBegin());
        gameScene.Add(new SceneLobby());
        gameScene.Add(new ScenePlay());
        gameScene.Add(new SceneResult());

		gameSceneCurrent = gameScene[SceneBase.SCENE_PHASE_PLAY];
    }
    // 
    List<SceneBase> gameScene = new();
    SceneBase       gameSceneCurrent;
}
