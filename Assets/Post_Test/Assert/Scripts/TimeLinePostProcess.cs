using UnityEngine;

[ExecuteInEditMode]
public class TimeLinePostProcess : MonoBehaviour
{

	public Material PostProcessMat;

	[Range(-5, 5)]
	public float centerU;
	[Range(-5, 5)]
	public float centerV;
	public Color Color1;
	public Color Color2;

	[Range(0, 5)]
	public float LineTilingU;
	[Range(1, 20)]
	public float LineTilingV;
	[Range(-1, 3)]
	public float LineColorScale;
	[Range(0, 1)]
	public float Soft;

	[Range(0, 2)]
	public float StepFactor;

	[Range(0, 1)]
	public float TexRotator;
	[Range(0, 1)]
	public float TexAlpha;
	[Range(0, 1)]
	public float LogoAlpha;
	[Range(0, 5)]
	public float LineOffset;

	public float MainAlpha = 1F;
	public float BlurFactor;
	public float LineUVScale;
	public float Chromatic;
	public float Frequency;
	public float Amplitude;
	public float VignettePower = 1.5F;
	public float VignetteScale = 1.5F;


	private void Awake()
	{
		if (PostProcessMat == null)
		{
			enabled = false;
		}
		else
		{

			PostProcessMat.mainTexture = PostProcessMat.mainTexture;
		}

	}

	//void Start()
	//{

	//var BlurFactor = PostProcessMat.GetFloat("_BlurFactorK");


	//}

	//void Update()
	//{



	//}

	void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		PostProcessMat.SetFloat("_centerU", centerU);
		PostProcessMat.SetFloat("_centerV", centerV);
		PostProcessMat.SetColor("_Color1", Color1);
		PostProcessMat.SetColor("_Color2", Color2);

		PostProcessMat.SetFloat("_LineTilingU", LineTilingU);
		PostProcessMat.SetFloat("_LineTilingV", LineTilingV);

		PostProcessMat.SetFloat("_LineColorScale", LineColorScale);
		PostProcessMat.SetFloat("_Soft", Soft);

		PostProcessMat.SetFloat("_StepFactor", StepFactor);

		PostProcessMat.SetFloat("_TexRotator", TexRotator);
		PostProcessMat.SetFloat("_TexAlpha", TexAlpha);
		PostProcessMat.SetFloat("_LogoAlpha", LogoAlpha);

		PostProcessMat.SetFloat("_LineOffset", LineOffset);

		//

		PostProcessMat.SetFloat("_BlurFactor", BlurFactor);
		PostProcessMat.SetFloat("_LineUVScale", LineUVScale);
		PostProcessMat.SetFloat("_MainAlpha", MainAlpha);
		PostProcessMat.SetFloat("_zhenpin", Frequency);
		PostProcessMat.SetFloat("_zhenfu", Amplitude);
		PostProcessMat.SetFloat("_RedBlueFactor", Chromatic);
		PostProcessMat.SetFloat("_VignettePower", VignettePower);
		PostProcessMat.SetFloat("_VignetteScale", VignetteScale);

		Graphics.Blit(src, dest, PostProcessMat);
	}
}
