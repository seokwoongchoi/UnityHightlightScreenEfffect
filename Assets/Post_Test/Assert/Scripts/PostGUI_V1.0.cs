using System;
using UnityEngine;
using UnityEditor;


//눼쉔寧몸GUI잚
public class PostGUI : ShaderGUI
{
    public GUILayoutOption[] shortButtonStyle = new GUILayoutOption[] { GUILayout.Width(200) };

    public GUIStyle style = new GUIStyle() ;

    static bool Foldout(bool display, string title)
    {




        var style = new GUIStyle("ShurikenModuleTitle");
        style.font = new GUIStyle(EditorStyles.boldLabel).font;
        style.border = new RectOffset(15, 7, 4, 4);
        style.fixedHeight = 22;
        style.contentOffset = new Vector2(20f, -2f);
        style.fontSize = 11;
        style.normal.textColor = new Color(0.7f, 0.8f, 0.9f);


        var rect = GUILayoutUtility.GetRect(16f, 25f, style);
        GUI.Box(rect, title, style);

        var e = Event.current;

        var toggleRect = new Rect(rect.x + 4f, rect.y + 2f, 13f, 13f);
        if (e.type == EventType.Repaint)
        {
            EditorStyles.foldout.Draw(toggleRect, false, false, display, false);
        }

        if (e.type == EventType.MouseDown && rect.Contains(e.mousePosition))
        {
            display = !display;
            e.Use();
        }

        return display;
    }

    static bool Foldouts(bool display, string title)
    {



        var style = new GUIStyle("ShurikenModuleTitle");
        style.font = new GUIStyle(EditorStyles.boldLabel).font;
        style.border = new RectOffset(15, 7, 4, 4);
        style.fixedHeight = 18;
        style.contentOffset = new Vector2(30f, -2f);
        style.fontSize = 10;
        style.normal.textColor = new Color(0.75f, 0.75f, 0.75f);


        var rect = GUILayoutUtility.GetRect(16f, 15f, style);
        GUI.Box(rect, title, style);

        var e = Event.current;

        var toggleRect = new Rect(rect.x + 15f, rect.y + 2f, 13f, 13f);
        if (e.type == EventType.Repaint)
        {
            EditorStyles.foldout.Draw(toggleRect, false, false, display, false);
        }

        if (e.type == EventType.MouseDown && rect.Contains(e.mousePosition))
        {
            display = !display;
            e.Use();
        }

        return display;
    }


    static bool _Main = true;

    static bool _Base = true;

    static bool _Texxx = false;

    static bool _tips = false;

    static bool _Thanks = false;

    static bool _honglan = false;

    static bool _UVDistort = false;

    static bool _Black = false;

    static bool _Texx = false;

    static bool _Logox = false;

    static bool _Logoxx = false;
    static bool _zhenping = false;
    MaterialEditor m_MaterialEditor;


    MaterialProperty ColorStyle = null;
    MaterialProperty centerU = null;
    MaterialProperty centerV = null;
    MaterialProperty Color1 = null;
    MaterialProperty Color2 = null;
    MaterialProperty LineTilingU = null;
    MaterialProperty LineTilingV = null;
    MaterialProperty LineUVScale = null;
    MaterialProperty LineUVScaleK = null;
    MaterialProperty LineColorScale = null;
    MaterialProperty LineOffset = null;
    MaterialProperty BlurFactor = null;
    MaterialProperty BlurFactorK = null;
    MaterialProperty Soft = null;
    MaterialProperty StepFactor = null;
    MaterialProperty StepFactorK = null;
    MaterialProperty RedBlueFactor = null;
    MaterialProperty RedBlueFactorK = null;
    MaterialProperty Tex = null;
    MaterialProperty TexRotator = null;
    MaterialProperty TexAlpha = null;
    MaterialProperty VignettePower = null;
    MaterialProperty VignetteScale = null;
    MaterialProperty MainAlpha = null;
    MaterialProperty MainAlphaK = null;
    MaterialProperty IfMainAlpha = null;
    MaterialProperty IfStepFactor = null;
    MaterialProperty IfLineUVScale = null;
    MaterialProperty IfBlurFactor = null;
    MaterialProperty IfRedBlueFactor = null;
    MaterialProperty Logo = null;
    MaterialProperty LogoAR = null;
    MaterialProperty LogoAlpha = null;
    MaterialProperty zhenfu = null;
    MaterialProperty zhenfuK = null;
    MaterialProperty Ifzhenfu = null;
    MaterialProperty zhenpin = null;
    MaterialProperty zhenpinK = null;
    MaterialProperty Ifzhenpin = null;
    MaterialProperty IfVignettePower = null;
    MaterialProperty VignettePowerK = null;
    MaterialProperty IfVignetteScale = null;
    MaterialProperty VignetteScaleK = null;

    MaterialProperty TexAR = null;

    public void FindProperties(MaterialProperty[] props)
    {


        ColorStyle = FindProperty("_ColorStyle", props);
        centerU = FindProperty("_centerU", props);
        centerV = FindProperty("_centerV", props);
        Color1 = FindProperty("_Color1", props);
        Color2 = FindProperty("_Color2", props);
        LineTilingU = FindProperty("_LineTilingU", props);
        LineTilingV = FindProperty("_LineTilingV", props);
        LineUVScale = FindProperty("_LineUVScale", props);
        LineUVScaleK = FindProperty("_LineUVScaleK", props);
        IfLineUVScale = FindProperty("_IfLineUVScale", props);
        LineColorScale = FindProperty("_LineColorScale", props);
        LineOffset = FindProperty("_LineOffset", props);
        BlurFactor = FindProperty("_BlurFactor", props);
        BlurFactorK = FindProperty("_BlurFactorK", props);
        IfBlurFactor = FindProperty("_IfBlurFactor", props);
        Soft = FindProperty("_Soft", props);
        StepFactor = FindProperty("_StepFactor", props);
        StepFactorK = FindProperty("_StepFactorK", props);
        IfStepFactor = FindProperty("_IfStepFactor", props);
        RedBlueFactor = FindProperty("_RedBlueFactor", props);
        RedBlueFactorK = FindProperty("_RedBlueFactorK", props);
        IfRedBlueFactor = FindProperty("_IfRedBlueFactor", props);
        Tex = FindProperty("_Tex", props);
        TexRotator = FindProperty("_TexRotator", props);
        TexAlpha = FindProperty("_TexAlpha", props);
        VignettePower = FindProperty("_VignettePower", props);
        VignetteScale = FindProperty("_VignetteScale", props);
        MainAlpha = FindProperty("_MainAlpha", props);
        MainAlphaK = FindProperty("_MainAlphaK", props);
        IfMainAlpha = FindProperty("_IfMainAlpha", props);
        LogoAR = FindProperty("_LogoAR", props);
        Logo = FindProperty("_Logo", props);
        LogoAlpha= FindProperty("_LogoAlpha", props);
        zhenfu = FindProperty("_zhenfu", props);
        zhenfuK = FindProperty("_zhenfuK", props);
        Ifzhenfu = FindProperty("_Ifzhenfu", props);
        zhenpin = FindProperty("_zhenpin", props);
        zhenpinK = FindProperty("_zhenpinK", props);
        Ifzhenpin = FindProperty("_Ifzhenpin", props);
        IfVignettePower = FindProperty("_IfVignettePower", props);
        VignettePowerK = FindProperty("_VignettePowerK", props);
        VignetteScaleK = FindProperty("_VignetteScaleK", props);
        IfVignetteScale = FindProperty("_IfVignetteScale", props);
        TexAR = FindProperty("_TexAR", props);
    }

    //쉥충땍屢돨橄昑鞫刻瞳충겼
    public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] props)
    {
      

        FindProperties(props);

        m_MaterialEditor = materialEditor;

        Material material = materialEditor.target as Material;


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        _Main = Foldout(_Main, "奈친駕(ColorStyle)");

        if (_Main)
        {
            EditorGUI.indentLevel++;


            Main(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _UVDistort = Foldout(_UVDistort, "쓺蕨친빡(RadialBlur)");

        if (_UVDistort)
        {
            EditorGUI.indentLevel++;


            UVDistort(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _honglan = Foldout(_honglan, "븐융(Chromatic)");

        if (_honglan)
        {
            EditorGUI.indentLevel++;


            honglangui(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();




        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _zhenping = Foldout(_zhenping, "驢팁(ScreenShake)");

        if (_zhenping)
        {
            EditorGUI.indentLevel++;


            zhenpinggui(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();






        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        _Black = Foldout(_Black, "붚긋움(Vignette)");

        if (_Black)
        {
            EditorGUI.indentLevel++;


            Black(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _Texx = Foldout(_Texx, "샥잿暠(Texture)");

        if (_Texx)
        {
            EditorGUI.indentLevel++;


            Textures(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _Logox = Foldout(_Logox, "彊丹(Logo)");

        if (_Logox)
        {
            EditorGUI.indentLevel++;


            Logogui(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        _Base = Foldout(_Base, "빈퍅履북零(PostComprehensiveSettings)");

        if (_Base)
        {
            EditorGUI.indentLevel++;


            Base(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _Thanks = Foldout(_Thanks, "綱츠(Illustrate)");

        if (_Thanks)
        {
            EditorGUI.indentLevel++;


            Thanks(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();






        void Main(Material material)
        {
          

            m_MaterialEditor.ShaderProperty(ColorStyle, "奈친駕");



            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                style.wordWrap = true;
                GUILayout.Label("*Normal槨攣끽친駕，BlackWhite槨붚겜친駕，ReCover槨럽친駕", style);
                EditorGUILayout.EndVertical();
            }

          
            GUILayout.Space(5);

            

            if (material.GetFloat("_ColorStyle") == 1)
            {



                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                GUILayout.Space(5);

                m_MaterialEditor.ShaderProperty(Color1, "奈1");
                m_MaterialEditor.ShaderProperty(Color2, "奈2");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*좃蘆딧，옵鹿훨雷뫘뻣토，붚겜，붚븐된된", style);
                    EditorGUILayout.EndVertical();
                }
                GUILayout.Space(5);
          
                m_MaterialEditor.ShaderProperty(Soft, "獗羹흡袒넋똑");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*憐竟奈돨쉈긴炅똑，令督댕，炅똑督뻠，쉈긴督츠鞫", style);
                    EditorGUILayout.EndVertical();
                }

                GUILayout.Space(5);

                m_MaterialEditor.ShaderProperty(StepFactor, "獗羹烱뇜넋똑");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*憐竟奈돨烱뇜離鬼令，鬼黨맡令떼삔굳烱뇜냥槨붚", style);
                    EditorGUILayout.EndVertical();
                }
                GUILayout.Space(5);
                m_MaterialEditor.ShaderProperty(LineColorScale, "맒속窟뙈퓻똑");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*藤속寧硅띨棍돨루목뺏窟係，藤속녑샌먁，窟係돨쵱똑뵨렴櫓懃谿쓺蕨친빡寧鈴，옵鹿瞳쓺蕨친빡쟁零", style);
                    EditorGUILayout.EndVertical();
                }
                GUILayout.Space(5);
                EditorGUILayout.EndVertical();


            }




       

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);


         
            EditorGUILayout.BeginHorizontal();


            EditorGUILayout.PrefixLabel("悧拷츠똑K煉");
            if (material.GetFloat("_IfMainAlpha") == 0)
            {
                if (GUILayout.Button("綠밑균（MainAlpha）", shortButtonStyle))
                {
                    material.SetFloat("_IfMainAlpha",1);

                }
            }
            else

            {
                if (GUILayout.Button("綠역폘（MainAlpha）", shortButtonStyle))
                {
                    material.SetFloat("_IfMainAlpha", 0);

                }
            }

            EditorGUILayout.EndHorizontal();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*拳狼뚤憐竟AlphaK煉隣땡뺌，矜狼역폘늪朞淃，역폘빈苟렘悧拷츠똑鑒令쉥呵槻깻茶꾜，늪鑒令쉥譚렘신굶PandaPostProcess코돨MainAplha왠齡，K煉冷角矜狼K신굶쟁돨鑒令，꼼醴헷돨꽝鑒꼇連넣K煉", style);
                EditorGUILayout.EndVertical();
            }








            if (material.GetFloat("_IfMainAlpha") == 0)
            {

                m_MaterialEditor.ShaderProperty(MainAlpha, "悧拷츠똑");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*붚겜，럽，쓺蕨친빡，븐융튤盧돨살북槻벎돨憐竟拷츠똑", style);
                    EditorGUILayout.EndVertical();
                }
            }
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);





        }




    }



        void UVDistort(Material material)

        {


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        m_MaterialEditor.ShaderProperty(centerU, "櫓懃듐U");


        m_MaterialEditor.ShaderProperty(centerV, "櫓懃듐V");
        EditorGUILayout.EndVertical();
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*쓺蕨櫓懃듐，谿珂왠齡UV윗，븐융튤盧，쓺蕨친빡，맒속窟係돨櫓懃貫零", style);
            EditorGUILayout.EndVertical();
        }
        GUILayout.Space(5);

      



        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("쓺蕨친빡퓻똑K煉");
        if (material.GetFloat("_IfBlurFactor") == 0)
        {
            if (GUILayout.Button("綠밑균（BlurFactor）", shortButtonStyle))
            {
                material.SetFloat("_IfBlurFactor", 1);

            }
        }
        else

        {
            if (GUILayout.Button("綠역폘（BlurFactor）", shortButtonStyle))
            {
                material.SetFloat("_IfBlurFactor", 0);

            }
          
        }

        EditorGUILayout.EndHorizontal();
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*拳狼뚤쓺蕨친빡퓻똑K煉隣땡뺌，矜狼역폘늪朞淃，역폘빈苟렘쓺蕨친빡퓻똑鑒令쉥呵槻깻茶꾜，늪鑒令쉥譚렘신굶PandaPostProcess코돨BlurFactor왠齡，K煉冷角矜狼K신굶쟁돨鑒令，꼼醴헷돨꽝鑒꼇連넣K煉", style);
            EditorGUILayout.EndVertical();
        }

        if (material.GetFloat("_IfBlurFactor") == 0)
        { 

            m_MaterialEditor.ShaderProperty(BlurFactor, "쓺蕨친빡퓻똑");

        }
        EditorGUILayout.EndVertical();



        GUILayout.Space(5);

   



        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("UV윗퓻똑K煉");
        if (material.GetFloat("_IfLineUVScale") == 0)
        {
            if (GUILayout.Button("綠밑균（LineUVScale）", shortButtonStyle))
            {
                material.SetFloat("_IfLineUVScale", 1);

            }
        }
        else

        {
            if (GUILayout.Button("綠역폘（LineUVScale）", shortButtonStyle))
            {
                material.SetFloat("_IfLineUVScale", 0);

            }

        }

        EditorGUILayout.EndHorizontal();

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*拳狼뚤UV윗퓻똑K煉隣땡뺌，矜狼역폘늪朞淃，역폘빈苟렘UV윗퓻똑鑒令쉥呵槻깻茶꾜，늪鑒令쉥譚렘신굶PandaPostProcess코돨LineUVScale왠齡，K煉冷角矜狼K신굶쟁돨鑒令，꼼醴헷돨꽝鑒꼇連넣K煉", style);
            EditorGUILayout.EndVertical();
        }


        if (material.GetFloat("_IfLineUVScale") == 0)
        {
            m_MaterialEditor.ShaderProperty(LineUVScale, "UV윗퓻똑");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*UV렴榴윗넋똑", style);
                EditorGUILayout.EndVertical();
            }
        }

        EditorGUILayout.EndVertical();
          GUILayout.Space(5);





        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        m_MaterialEditor.ShaderProperty(LineTilingU, "窟뙈李蕨路팟");

        m_MaterialEditor.ShaderProperty(LineTilingV, "窟뙈뷘蕨路팟");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*렴窟뙈돨路팟똑，李蕨槨닒櫓懃鞏긋鍍렘蕨돨路팟똑，뷘蕨槨뻔近렘蕨路팟똑", style);
            EditorGUILayout.EndVertical();
        }
        EditorGUILayout.EndVertical();


        GUILayout.Space(5);









        m_MaterialEditor.ShaderProperty(LineOffset, "窟뙈튤盧");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*렴窟뙈돨튤盧令，옵鹿딧憐윱朞寧몸특좋돨窟뙈榴檄", style);
            EditorGUILayout.EndVertical();
        }

        GUILayout.Space(5);





   







        }


    void honglangui(Material material)
    {

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("퓻똑K煉");
        if (material.GetFloat("_IfRedBlueFactor") == 0)
        {
            if (GUILayout.Button("綠밑균（Chromatic）", shortButtonStyle))
            {
                material.SetFloat("_IfRedBlueFactor", 1);

            }
        }
        else

        {
            if (GUILayout.Button("綠역폘（Chromatic）", shortButtonStyle))
            {
                material.SetFloat("_IfRedBlueFactor", 0);

            }

        }

        EditorGUILayout.EndHorizontal();


        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*拳狼뚤퓻똑K煉隣땡뺌，矜狼역폘늪朞淃，역폘빈苟렘퓻똑鑒令쉥呵槻깻茶꾜，늪鑒令쉥譚렘신굶PandaPostProcess코돨Chromatic왠齡，K煉冷角矜狼K신굶쟁돨鑒令，꼼醴헷돨꽝鑒꼇連넣K煉", style);
            EditorGUILayout.EndVertical();
        }

        if (material.GetFloat("_IfRedBlueFactor") == 0)
        {

            m_MaterialEditor.ShaderProperty(RedBlueFactor, "퓻똑");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*렴榴븐융튤盧넋똑", style);
                EditorGUILayout.EndVertical();
            }
        }

        EditorGUILayout.EndVertical();



        GUILayout.Space(5);

    }
    void zhenpinggui(Material material)
    {

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);



        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("驪틉K煉");
        if (material.GetFloat("_Ifzhenpin") == 0)
        {
            if (GUILayout.Button("綠밑균（Frequency）", shortButtonStyle))
            {
                material.SetFloat("_Ifzhenpin", 1);

            }
        }
        else

        {
            if (GUILayout.Button("綠역폘（Frequency）", shortButtonStyle))
            {
                material.SetFloat("_Ifzhenpin", 0);

            }
        }

        EditorGUILayout.EndHorizontal();
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*拳狼뚤驪틉K煉隣땡뺌，矜狼역폘늪朞淃，역폘빈苟렘驪틉鑒令쉥呵槻깻茶꾜，늪鑒令쉥譚렘신굶PandaPostProcess코돨Frequency왠齡，K煉冷角矜狼K신굶쟁돨鑒令，꼼醴헷돨꽝鑒꼇連넣K煉", style);
            EditorGUILayout.EndVertical();
        }


        if (material.GetFloat("_Ifzhenpin") == 0)
        {

            m_MaterialEditor.ShaderProperty(zhenpin, "驪틉");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*팁캥驢땡돨틉쪽，令督댕驢땡돨틉쪽督댕", style);
                EditorGUILayout.EndVertical();
            }
        }
        EditorGUILayout.EndVertical();
        GUILayout.Space(5);





        EditorGUILayout.BeginVertical(EditorStyles.helpBox);



        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("驪류K煉");
        if (material.GetFloat("_Ifzhenfu") == 0)
        {
            if (GUILayout.Button("綠밑균（Amplitude）", shortButtonStyle))
            {
                material.SetFloat("_Ifzhenfu", 1);

            }
        }
        else

        {
            if (GUILayout.Button("綠역폘（Amplitude）", shortButtonStyle))
            {
                material.SetFloat("_Ifzhenfu", 0);

            }
        }

        EditorGUILayout.EndHorizontal();

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*拳狼뚤驪류K煉隣땡뺌，矜狼역폘늪朞淃，역폘빈苟렘驪류鑒令쉥呵槻깻茶꾜，늪鑒令쉥譚렘신굶PandaPostProcess코돨Amplitude왠齡，K煉冷角矜狼K신굶쟁돨鑒令，꼼醴헷돨꽝鑒꼇連넣K煉", style);
            EditorGUILayout.EndVertical();
        }

        if (material.GetFloat("_Ifzhenfu") == 0)
        {

            m_MaterialEditor.ShaderProperty(zhenfu, "驪류");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*팁캥驢땡돨류똑，令督댕驢땡돨류똑督댕", style);
                EditorGUILayout.EndVertical();
            }
        }
        EditorGUILayout.EndVertical();
        GUILayout.Space(5);

    }



    void Black(Material material)

        {
           

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);



        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("붚긋움욱똑K煉");
        if (material.GetFloat("_IfVignettePower") == 0)
        {
            if (GUILayout.Button("綠밑균（VignettePower）", shortButtonStyle))
            {
                material.SetFloat("_IfVignettePower", 1);

            }
        }
        else

        {
            if (GUILayout.Button("綠역폘（VignettePower）", shortButtonStyle))
            {
                material.SetFloat("_IfVignettePower", 0);

            }
        }

        EditorGUILayout.EndHorizontal();

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*拳狼뚤붚긋움욱똑K煉隣땡뺌，矜狼역폘늪朞淃，역폘빈苟렘붚긋움욱똑鑒令쉥呵槻깻茶꾜，늪鑒令쉥譚렘신굶PandaPostProcess코돨VignettePower왠齡，K煉冷角矜狼K신굶쟁돨鑒令，꼼醴헷돨꽝鑒꼇連넣K煉", style);
            EditorGUILayout.EndVertical();
        }

        if (material.GetFloat("_IfVignettePower") == 0)
        {

            m_MaterialEditor.ShaderProperty(VignettePower, "붚긋움욱똑");
    
        }
        EditorGUILayout.EndVertical();
        GUILayout.Space(5);



        EditorGUILayout.BeginVertical(EditorStyles.helpBox);



        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("붚긋움퓻똑K煉");
        if (material.GetFloat("_IfVignetteScale") == 0)
        {
            if (GUILayout.Button("綠밑균（VignetteScale）", shortButtonStyle))
            {
                material.SetFloat("_IfVignetteScale", 1);

            }
        }
        else

        {
            if (GUILayout.Button("綠역폘（VignetteScale）", shortButtonStyle))
            {
                material.SetFloat("_IfVignetteScale", 0);

            }
        }

        EditorGUILayout.EndHorizontal();

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*拳狼뚤붚긋움퓻똑K煉隣땡뺌，矜狼역폘늪朞淃，역폘빈苟렘붚긋움퓻똑鑒令쉥呵槻깻茶꾜，늪鑒令쉥譚렘신굶PandaPostProcess코돨VignetteScale왠齡，K煉冷角矜狼K신굶쟁돨鑒令，꼼醴헷돨꽝鑒꼇連넣K煉", style);
            EditorGUILayout.EndVertical();
        }

        if (material.GetFloat("_IfVignetteScale") == 0)
        {

            m_MaterialEditor.ShaderProperty(VignetteScale, "붚긋움퓻똑");

        }
        EditorGUILayout.EndVertical();
        GUILayout.Space(5);




    }

        void Textures(Material material)

        {
          
            m_MaterialEditor.TexturePropertySingleLine(new GUIContent("季暠"), Tex);
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*옵鹿痰윱齡鱗팁캥샥잿", style);
                EditorGUILayout.EndVertical();
            }


            if (Tex.textureValue != null)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _Texxx = Foldouts(_Texxx, "季暠零");

                if (_Texxx)
                {
                    EditorGUI.indentLevel++;


                m_MaterialEditor.ShaderProperty(TexAR, "賈痰R繫돛");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*뭅朞빈賈痰R繫돛槨鑒앴繫돛，꼇뭅朞賈痰A繫돛槨鑒앴繫돛，暠튬唐A繫돛꼇狼뭅朞！", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.ShaderProperty(TexRotator, "季暠旗瘻");
                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*季暠旗瘻，뇹잿季暠날蕨，伽혼릿齡季暠맣긴날蕨", style);
                        EditorGUILayout.EndVertical();
                    }





                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*嵐역빈옵鹿뚤季暠橄昑隣寧硅零，관벵繫돛朞嶝，旗瘻", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.TextureScaleOffsetProperty(Tex);

            
                GUILayout.Space(5);

                m_MaterialEditor.ShaderProperty(TexAlpha, "季暠拷츠똑");
                GUILayout.Space(5);

            }

        }


        void Logogui(Material material)
        {

            m_MaterialEditor.TexturePropertySingleLine(new GUIContent("季暠"), Logo);

            if (Logo.textureValue != null)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _Logoxx = Foldouts(_Logoxx, "季暠零");

                if (_Logoxx)
                {
                    EditorGUI.indentLevel++;




                    m_MaterialEditor.ShaderProperty(LogoAR, "賈痰R繫돛");
                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*뭅朞賈痰R繫돛鱗槨拷츠繫돛繫돛，꼇뭅朞賈痰A繫돛鱗槨拷츠繫돛", style);
                        EditorGUILayout.EndVertical();
                    }





                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*嵐역빈옵鹿뚤季暠橄昑隣寧硅零，관벵繫돛朞嶝", style);
                    EditorGUILayout.EndVertical();
                }

         


                m_MaterialEditor.TextureScaleOffsetProperty(Logo);
                GUILayout.Space(5);
                m_MaterialEditor.ShaderProperty(LogoAlpha, "季暠拷츠똑");
                GUILayout.Space(5);
            }


        }


        void Base(Material material)

        {
    
           
          





          







            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginHorizontal();


            EditorGUILayout.PrefixLabel("역폘놓欺諒친駕");
            if (_tips == false)
            {
                if (GUILayout.Button("綠밑균", shortButtonStyle))
                {
                    _tips = true;

                }
            }
            else

            {
                if (GUILayout.Button("綠역폘", shortButtonStyle))
                {
                    _tips = false;

                }
            }

            EditorGUILayout.EndHorizontal();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*역폘빈삔鞫刻첼寧몸긴좆돨圈玖묘콘斤口，刊북劤賈痰꼼醴돨놓欺諒", style);
                EditorGUILayout.EndVertical();
            }
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);
        }


        void Thanks(Material material)

        {

            style.fontSize = 12;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            style.wordWrap = true;


            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
           
            GUILayout.Label("MainAlpha뚤壇悧拷츠똑", style);
        GUILayout.Space(5);
        GUILayout.Label("BlurFactor뚤壇쓺蕨친빡퓻똑", style);
        GUILayout.Space(5);
        GUILayout.Label("LineUVScale뚤壇UV윗퓻똑", style);
        GUILayout.Space(5);
        GUILayout.Label("Chromatic뚤壇퓻똑", style);
        GUILayout.Space(5);
        GUILayout.Label("Frequency뚤壇驪틉", style);
        GUILayout.Space(5);
        GUILayout.Label("Amplitude뚤壇驪류", style);
        GUILayout.Space(5);
        GUILayout.Label("VignettePower뚤壇붚실욱똑", style);
        GUILayout.Space(5);
        GUILayout.Label("VignetteScale뚤壇붚실퓻똑", style);
        GUILayout.Space(5);
        EditorGUILayout.EndVertical();
        GUILayout.Label(" 굶꼼醴譚答콸젬촉뻐襟챔齡鱗，뻑短賈痰，景깎먁剋答콸젬촉곤燎꿎桿", style);
        GUILayout.Space(5);
        }

    }

