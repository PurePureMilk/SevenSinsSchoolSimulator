//this is "importing a namespace" >> used to bring in user interface information 
//turns Text to blue
//Remember to save your scripts >> control s
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{
    public Text myText; //publicly expose all the methods
    public Text backLogText;
    //Objects
    #region
    public GameObject Sprite0;
    public GameObject Sprite1;
    public GameObject Sprite2;
    public GameObject Sprite3;
    public GameObject Sprite4;
    public GameObject Sprite5;
    public GameObject Sprite6;
    public GameObject Box;
    public GameObject Background;



    public Sprite Akira;
    public Sprite Eiko;
    public Sprite Wakako;
    public Sprite Teiji;
    public Sprite Ofria;
    public Sprite Nagisa;
    public Sprite Hideo;
    public Sprite Monika;
    public Sprite Blank;

    public Sprite Cafe;
    public Sprite Exit;
    public Sprite Gym;
    public Sprite Hallway;
    public Sprite Hallway2;
    public Sprite MainEntrance;
    public Sprite MediaCenter;
    public Sprite Music;
    public Sprite NightMainEntrance;
    public Sprite Stage1;
    public Sprite Stage2;
    public Sprite Stage3;
    public Sprite Stairs;
    public Sprite Math;
    public Sprite Homeroom;
    public Sprite Science;


    public AudioSource MusicSource;
    public AudioSource BGMSource;


    public AudioClip bgm1;
    public AudioClip kaiwa;
    public AudioClip magic;

    public AudioClip voice0;
    public AudioClip voice1;
    public AudioClip voice2;
    public AudioClip voice3;
    public AudioClip voice4;
    public AudioClip voice5;
    public AudioClip voice6;
    public AudioClip voice7;
    public AudioClip voice8;
    public AudioClip voice9;
    public AudioClip voice10;
    public AudioClip voice11;
    public AudioClip voice12;
    public AudioClip voice13;
    public AudioClip voice14;
    public AudioClip voice15;
    public AudioClip voice16;
    public AudioClip voice17;
    public AudioClip voice18;
    public AudioClip voice19;
    public AudioClip voice20;
    public AudioClip voice21;
    public AudioClip voice22;
    public AudioClip voice23;
    public AudioClip voice24;
    public AudioClip voice25;
    public AudioClip voice26;
    public AudioClip voice27;
    public AudioClip voice28;
    public AudioClip voice29;
    public AudioClip voice30;
    public AudioClip voice31;
    public AudioClip voice32;
    public AudioClip voice33;
    public AudioClip voice34;
    public AudioClip voice35;
    public AudioClip voice36;
    public AudioClip voice37;
    public AudioClip voice38;
    public AudioClip voice39;
    public AudioClip voice40;
    public AudioClip voice41;
    public AudioClip voice42;
    public AudioClip voice43;
    public AudioClip voice44;
    public AudioClip voice45;
    public AudioClip voice46;
    public AudioClip voice47;
    public AudioClip voice48;
    public AudioClip voice49;
    public AudioClip voice50;
    public AudioClip voice51;
    public AudioClip voice52;
    public AudioClip voice53;
    public AudioClip voice54;
    public AudioClip voice55;
    public AudioClip voice56;
    public AudioClip voice57;
    public AudioClip voice58;
    public AudioClip voice59;
    public AudioClip voice60;
    public AudioClip voice61;
    public AudioClip voice62;
    public AudioClip voice63;
    public AudioClip voice64;
    public AudioClip voice65;
    public AudioClip voice66;
    public AudioClip voice67;
    public AudioClip voice68;
    public AudioClip voice69;
    public AudioClip voice70;
    public AudioClip voice71;
    public AudioClip voice72;
    public AudioClip voice73;
    public AudioClip voice74;
    public AudioClip voice75;
    public AudioClip voice76;
    public AudioClip voice77;
    public AudioClip voice78;
    public AudioClip voice79;
    public AudioClip voice80;
    public AudioClip voice81;
    public AudioClip voice82;
    public AudioClip voice83;
    public AudioClip voice84;
    public AudioClip voice85;
    public AudioClip voice86;
    public AudioClip voice87;
    public AudioClip voice88;
    public AudioClip voice89;
    public AudioClip voice90;
    public AudioClip voice91;
    public AudioClip voice92;
    public AudioClip voice93;
    public AudioClip voice94;
    public AudioClip voice95;
    public AudioClip voice96;
    public AudioClip voice97;
    public AudioClip voice98;
    public AudioClip voice99;
    public AudioClip voice100;
    public AudioClip voice101;
    public AudioClip voice102;
    public AudioClip voice103;
    public AudioClip voice104;
    public AudioClip voice105;
    public AudioClip voice106;
    public AudioClip voice107;
    public AudioClip voice108;
    public AudioClip voice109;
    public AudioClip voice110;
    public AudioClip voice111;
    public AudioClip voice112;
    public AudioClip voice113;
    public AudioClip voice114;
    public AudioClip voice115;
    public AudioClip voice116;
    public AudioClip voice117;
    public AudioClip voice118;
    public AudioClip voice119;
    public AudioClip voice120;
    public AudioClip voice121;
    public AudioClip voice122;
    public AudioClip voice123;
    public AudioClip voice124;
    public AudioClip voice125;
    public AudioClip voice126;
    public AudioClip voice127;
    public AudioClip voice128;
    public AudioClip voice129;
    public AudioClip voice130;
    public AudioClip voice131;
    public AudioClip voice132;
    #endregion

    private enum States
    {
        dia0, dia1, dia2, dia3, dia4, dia5, dia6, dia7, dia8, dia9, dia10,
        dia11, dia12, dia13, dia14, dia15, dia16, dia17, dia18, dia19, dia20,
        dia21, dia22, dia23, dia24, dia25, dia26, dia27, dia28, dia29, dia30,
        dia31, dia32, dia33, dia34, dia35, dia36, dia37, dia38, dia39, dia40,
        dia41, dia42, dia43, dia44, dia45, dia46, dia47, dia48, dia49, dia50,
        dia51, dia52, dia53, dia54, dia55, dia56, dia57, dia58, dia59, dia60,
        dia61, dia62, dia63, dia64, dia65, dia66, dia67, dia68, dia69, dia70,
        dia71, dia72, dia73, dia74, dia75, dia76, dia77, dia78, dia79, dia80,
        dia81, dia82, dia83, dia84, dia85, dia86, dia87, dia88, dia89, dia90,
        dia91, dia92, dia93, dia94, dia95, dia96, dia97, dia98, dia99, dia100,
        dia101, dia102, dia103, dia104, dia105, dia106, dia107, dia108, dia109, dia110,
        dia111, dia112, dia113, dia114, dia115, dia116, dia117, dia118, dia119, dia120,
        dia121, dia122, dia123, dia124, dia125, dia126, dia127, dia128, dia129, dia130,
        dia131, dia132, dia133, dia134, dia135, dia136, dia137, dia138, dia139, dia140,
        dia141, dia142, dia143, dia144, dia145, dia146, dia147, dia148, dia149, dia150,
        dia151, dia152, dia153, dia154, dia155, dia156, dia157, dia158, dia159, dia160,
        dia161, dia162, dia163, dia164, dia165, dia166, dia167, dia168, dia169, dia170,
        dia171, dia172, dia173, dia174, dia175, dia176, dia177, dia178, dia179, dia180,
        dia181, dia182, dia183, dia184, dia185, dia186, dia187, dia188, dia189, dia190,
        dia191, dia192, dia193, dia194, dia195, dia196, dia197, dia198, dia199, dia200,
        dia201, dia202, dia203, dia204, dia205, dia206, dia207, dia208, dia209, dia210,
        dia211, dia212, dia213, dia214, dia215, dia216, dia217, dia218, dia219, dia220,
        dia221, dia222, dia223, dia224, dia225, dia226, dia227, dia228, dia229, dia230,
        dia231, dia232, dia233, dia234, dia235, dia236, dia237, dia238, dia239, dia240,
        dia241, dia242, dia243, dia244, dia245, dia246, dia247, dia248, dia249, dia250,
        dia251, dia252, dia253, dia254, dia255, dia256, dia257, dia258, dia259, dia260,
        dia261, dia262, dia263, dia264, dia265, dia266, dia267, dia268, dia269, dia270,
        dia271, dia272, dia273, dia274, dia275, dia276, dia277, dia278, dia279, dia280,
        dia281, dia282, dia283, dia284, dia285, dia286, dia287, dia288, dia289, dia290,
        dia291, dia292, dia293, dia294, dia295, dia296, dia297, dia298, dia299, dia300,
        dia301, dia302, dia303, dia304, dia305, dia306, dia307, dia308, dia309, dia310,
        dia311, dia312, dia313, dia314, dia315, dia316, dia317, dia318, dia319, dia320,
        dia321, dia322, dia323, dia324, dia325, dia326, dia327, dia328, dia329, dia330,
        dia331, dia332, dia333, dia334, dia335, dia336, dia337, dia338, dia339, dia340,
        dia341, dia342, dia343, dia344, dia345, dia346, dia347, dia348, dia349, dia350,
        dia351, dia352, dia353, dia354, dia355, dia356, dia357, dia358, dia359, dia360,
        dia361, dia362, dia363, dia364, dia365, dia366, dia367, dia368, dia369, dia370,
        dia371, dia372, dia373, dia374, dia375, dia376, dia377, dia378, dia379, dia380,
        dia381, dia382, dia383, dia384, dia385, dia386, dia387, dia388, dia389, dia390,
        dia391, dia392, dia393, dia394, dia395, dia396, dia397, dia398, dia399, dia400,
        dia401, dia402, dia403, dia404, dia405, dia406, dia407, dia408, dia409, dia410,
        dia411, dia412, dia413, dia414, dia415, dia416, dia417, dia418, dia419, dia420,
        dia421, dia422, dia423, dia424, dia425, dia426, dia427, dia428, dia429, dia430,
        dia431, dia432, dia433, dia434, dia435, dia436, dia437, dia438, dia439, dia440,
        dia441, dia442, dia443, dia444, dia445, dia446, dia447, dia448, dia449, dia450,
        dia451, dia452, dia453, dia454, dia455, dia456, dia457, dia458, dia459, dia460,
        dia461, dia462, dia463, dia464, dia465, dia466, dia467, dia468, dia469, dia470,
        dia471, dia472, dia473, dia474, dia475, dia476, dia477, dia478, dia479, dia480,
        dia481, dia482, dia483, dia484, dia485, dia486, dia487, dia488, dia489, dia490,
        dia491, dia492, dia493, dia494, dia495, dia496, dia497, dia498, dia499
    };

    private States myState;

    //Flag Variables

    int letHer = 0;
    int give = 0;

    //Vars parameters
    #region

        //Current
     int wakakoC = 0;
     int hideoC = 0;
     int eikoC = 0;
     int akiraC = 0;
     int teijiC = 0;
     int ofriaC = 0;
     int nagisaC = 0;

     int wakakoV = 0;
    int hideoV = 0;
    int eikoV = 0;
    int akiraV = 0;
    int teijiV = 0;
    int ofriaV = 0;
    int nagisaV = 0;

    int wakako0 = 0;
    int hideo0 = 0;
    int eiko0 = 0;
    int akira0 = 0;
    int teiji0 = 0;
    int ofria0 = 0;
    int nagisa0 = 0;

    int wakako1 = 0;
    int hideo1 = 0;
    int eiko1 = 0;
    int akira1 = 0;
    int teiji1 = 0;
    int ofria1 = 0;
    int nagisa1 = 0;

    int wakako2 = 0;
    int hideo2 = 0;
    int eiko2 = 0;
    int akira2 = 0;
    int teiji2 = 0;
    int ofria2 = 0;
    int nagisa2 = 0;
   

    private States saveState;
    private States saveState0;
    private States saveState1;
    private States saveState2;


    #endregion

    // Use this for initialization
    void Start()
    {
        myState = States.dia0; //this is the starting 
        //playSound(bgm1);
        playSound(voice0);
    }

    // Update is called once per frame
    void Update()
    {
        print(myState);
        print("Wakako: " + wakakoC + " Hideo: " + hideoC + " Eiko: " + eikoC +
               " Akira: " + akiraC + " Teiji: " + teijiC + " Ofria: " + ofriaC + " Nagisa: " + nagisaC );
        print("WakakoV: " + wakakoV + " HideoV: " + hideoV + " EikoV: " + eikoV +
               " AkiraV: " + akiraV + " TeijiV: " + teijiV + " OfriaV: " + ofriaV + " NagisaV: " + nagisaV);
        //prelude
        if (myState == States.dia0) { dia0(); }
        else if (myState == States.dia1) { dia1(); }
        else if (myState == States.dia2) { dia2(); }
        else if (myState == States.dia3) { dia3(); }
        else if (myState == States.dia4) { dia4(); }
        else if (myState == States.dia5) { dia5(); }
        else if (myState == States.dia6) { dia6(); }
        else if (myState == States.dia7) { dia7(); }
        else if (myState == States.dia8) { dia8(); }
        else if (myState == States.dia9) { dia9(); }
        else if (myState == States.dia10) { dia10(); }
        else if (myState == States.dia11) { dia11(); }
        else if (myState == States.dia12) { dia12(); }
        else if (myState == States.dia13) { dia13(); }
        else if (myState == States.dia14) { dia14(); }
        else if (myState == States.dia15) { dia15(); }
        else if (myState == States.dia16) { dia16(); }
        else if (myState == States.dia17) { dia17(); }
        else if (myState == States.dia18) { dia18(); }
        else if (myState == States.dia19) { dia19(); }
        else if (myState == States.dia20) { dia20(); }
        else if (myState == States.dia21) { dia21(); }
        else if (myState == States.dia22) { dia22(); }
        else if (myState == States.dia23) { dia23(); }
        else if (myState == States.dia24) { dia24(); }
        else if (myState == States.dia25) { dia25(); }
        else if (myState == States.dia26) { dia26(); }
        else if (myState == States.dia27) { dia27(); }
        else if (myState == States.dia28) { dia28(); }
        else if (myState == States.dia29) { dia29(); }
        else if (myState == States.dia30) { dia30(); }
        else if (myState == States.dia31) { dia31(); }
        else if (myState == States.dia32) { dia32(); }
        else if (myState == States.dia33) { dia33(); }
        else if (myState == States.dia34) { dia34(); }
        else if (myState == States.dia35) { dia35(); }
        else if (myState == States.dia36) { dia36(); }
        else if (myState == States.dia37) { dia37(); }
        else if (myState == States.dia38) { dia38(); }
        else if (myState == States.dia39) { dia39(); }
        else if (myState == States.dia40) { dia40(); }
        else if (myState == States.dia41) { dia41(); }
        else if (myState == States.dia42) { dia42(); }
        else if (myState == States.dia43) { dia43(); }
        else if (myState == States.dia44) { dia44(); }
        else if (myState == States.dia45) { dia45(); }
        else if (myState == States.dia46) { dia46(); }
        else if (myState == States.dia47) { dia47(); }
        else if (myState == States.dia48) { dia48(); }
        else if (myState == States.dia49) { dia49(); }
        else if (myState == States.dia50) { dia50(); }
        else if (myState == States.dia51) { dia51(); }
        else if (myState == States.dia52) { dia52(); }
        else if (myState == States.dia53) { dia53(); }
        else if (myState == States.dia54) { dia54(); }
        else if (myState == States.dia55) { dia55(); }
        else if (myState == States.dia56) { dia56(); }
        else if (myState == States.dia57) { dia57(); }
        else if (myState == States.dia58) { dia58(); }
        else if (myState == States.dia59) { dia59(); }
        else if (myState == States.dia60) { dia60(); }
        else if (myState == States.dia61) { dia61(); }
        else if (myState == States.dia62) { dia62(); }
        else if (myState == States.dia63) { dia63(); }
        else if (myState == States.dia64) { dia64(); }
        else if (myState == States.dia65) { dia65(); }
        else if (myState == States.dia66) { dia66(); }
        else if (myState == States.dia67) { dia67(); }
        else if (myState == States.dia68) { dia68(); }
        else if (myState == States.dia69) { dia69(); }
        else if (myState == States.dia70) { dia70(); }
        else if (myState == States.dia71) { dia71(); }
        else if (myState == States.dia72) { dia72(); }
        else if (myState == States.dia73) { dia73(); }
        else if (myState == States.dia74) { dia74(); }
        else if (myState == States.dia75) { dia75(); }
        else if (myState == States.dia76) { dia76(); }
        else if (myState == States.dia77) { dia77(); }
        else if (myState == States.dia78) { dia78(); }
        else if (myState == States.dia79) { dia79(); }
        else if (myState == States.dia80) { dia80(); }
        else if (myState == States.dia81) { dia81(); }
        else if (myState == States.dia82) { dia82(); }
        else if (myState == States.dia83) { dia83(); }
        else if (myState == States.dia84) { dia84(); }
        else if (myState == States.dia85) { dia85(); }
        else if (myState == States.dia86) { dia86(); }
        else if (myState == States.dia87) { dia87(); }
        else if (myState == States.dia88) { dia88(); }
        else if (myState == States.dia89) { dia89(); }
        else if (myState == States.dia90) { dia90(); }
        else if (myState == States.dia91) { dia91(); }
        else if (myState == States.dia92) { dia92(); }
        else if (myState == States.dia93) { dia93(); }
        else if (myState == States.dia94) { dia94(); }
        else if (myState == States.dia95) { dia95(); }
        else if (myState == States.dia96) { dia96(); }
        else if (myState == States.dia97) { dia97(); }
        else if (myState == States.dia98) { dia98(); }
        else if (myState == States.dia99) { dia99(); }
        else if (myState == States.dia100) { dia100(); }
        else if (myState == States.dia101) { dia101(); }
        else if (myState == States.dia102) { dia102(); }
        else if (myState == States.dia103) { dia103(); }
        else if (myState == States.dia104) { dia104(); }
        else if (myState == States.dia105) { dia105(); }
        else if (myState == States.dia106) { dia106(); }
        else if (myState == States.dia107) { dia107(); }
        else if (myState == States.dia108) { dia108(); }
        else if (myState == States.dia109) { dia109(); }
        else if (myState == States.dia110) { dia110(); }
        else if (myState == States.dia111) { dia111(); }
        else if (myState == States.dia112) { dia112(); }
        else if (myState == States.dia113) { dia113(); }
        else if (myState == States.dia114) { dia114(); }
        else if (myState == States.dia115) { dia115(); }
        else if (myState == States.dia116) { dia116(); }
        else if (myState == States.dia117) { dia117(); }
        else if (myState == States.dia118) { dia118(); }
        else if (myState == States.dia119) { dia119(); }
        else if (myState == States.dia120) { dia120(); }
        else if (myState == States.dia121) { dia121(); }
        else if (myState == States.dia122) { dia122(); }
        else if (myState == States.dia123) { dia123(); }
        else if (myState == States.dia124) { dia124(); }
        else if (myState == States.dia125) { dia125(); }
        else if (myState == States.dia126) { dia126(); }
        else if (myState == States.dia127) { dia127(); }
        else if (myState == States.dia128) { dia128(); }
        else if (myState == States.dia129) { dia129(); }
        else if (myState == States.dia130) { dia130(); }
        else if (myState == States.dia131) { dia131(); }
        else if (myState == States.dia132) { dia132(); }
        else if (myState == States.dia133) { dia133(); }
        /*
        else if (myState == States.dia134) { dia134(); }
        else if (myState == States.dia135) { dia135(); }
        else if (myState == States.dia136) { dia136(); }
        else if (myState == States.dia137) { dia137(); }
        else if (myState == States.dia138) { dia138(); }
        else if (myState == States.dia139) { dia139(); }
        else if (myState == States.dia140) { dia140(); }
        else if (myState == States.dia141) { dia141(); }
        else if (myState == States.dia142) { dia142(); }
        else if (myState == States.dia143) { dia143(); }
        else if (myState == States.dia144) { dia144(); }
        else if (myState == States.dia145) { dia145(); }
        else if (myState == States.dia146) { dia146(); }
        else if (myState == States.dia147) { dia147(); }
        else if (myState == States.dia148) { dia148(); }
        else if (myState == States.dia149) { dia149(); }
        else if (myState == States.dia150) { dia150(); }
        else if (myState == States.dia151) { dia151(); }
        else if (myState == States.dia152) { dia152(); }
        else if (myState == States.dia153) { dia153(); }
        else if (myState == States.dia154) { dia154(); }
        else if (myState == States.dia155) { dia155(); }
        else if (myState == States.dia156) { dia156(); }
        else if (myState == States.dia157) { dia157(); }
        else if (myState == States.dia158) { dia158(); }
        else if (myState == States.dia159) { dia159(); }
        else if (myState == States.dia160) { dia160(); }
        else if (myState == States.dia161) { dia161(); }
        else if (myState == States.dia162) { dia162(); }
        else if (myState == States.dia163) { dia163(); }
        else if (myState == States.dia164) { dia164(); }
        else if (myState == States.dia165) { dia165(); }
        else if (myState == States.dia166) { dia166(); }
        else if (myState == States.dia167) { dia167(); }
        else if (myState == States.dia168) { dia168(); }
        else if (myState == States.dia169) { dia169(); }
        else if (myState == States.dia170) { dia170(); }
        else if (myState == States.dia171) { dia171(); }
        else if (myState == States.dia172) { dia172(); }
        else if (myState == States.dia173) { dia173(); }
        else if (myState == States.dia174) { dia174(); }
        else if (myState == States.dia175) { dia175(); }
        else if (myState == States.dia176) { dia176(); }
        else if (myState == States.dia177) { dia177(); }
        else if (myState == States.dia178) { dia178(); }
        else if (myState == States.dia179) { dia179(); }
        else if (myState == States.dia180) { dia180(); }
        else if (myState == States.dia181) { dia181(); }
        else if (myState == States.dia182) { dia182(); }
        else if (myState == States.dia183) { dia183(); }
        else if (myState == States.dia184) { dia184(); }
        else if (myState == States.dia185) { dia185(); }
        else if (myState == States.dia186) { dia186(); }
        else if (myState == States.dia187) { dia187(); }
        else if (myState == States.dia188) { dia188(); }
        else if (myState == States.dia189) { dia189(); }
        else if (myState == States.dia190) { dia190(); }
        else if (myState == States.dia191) { dia191(); }
        else if (myState == States.dia192) { dia192(); }
        else if (myState == States.dia193) { dia193(); }
        else if (myState == States.dia194) { dia194(); }
        else if (myState == States.dia195) { dia195(); }
        else if (myState == States.dia196) { dia196(); }
        else if (myState == States.dia197) { dia197(); }
        else if (myState == States.dia198) { dia198(); }
        else if (myState == States.dia199) { dia199(); }
        else if (myState == States.dia200) { dia200(); }
        else if (myState == States.dia201) { dia201(); }
        else if (myState == States.dia202) { dia202(); }
        else if (myState == States.dia203) { dia203(); }
        else if (myState == States.dia204) { dia204(); }
        else if (myState == States.dia205) { dia205(); }
        else if (myState == States.dia206) { dia206(); }
        else if (myState == States.dia207) { dia207(); }
        else if (myState == States.dia208) { dia208(); }
        else if (myState == States.dia209) { dia209(); }
        else if (myState == States.dia210) { dia210(); }
        else if (myState == States.dia211) { dia211(); }
        else if (myState == States.dia212) { dia212(); }
        else if (myState == States.dia213) { dia213(); }
        else if (myState == States.dia214) { dia214(); }
        else if (myState == States.dia215) { dia215(); }
        else if (myState == States.dia216) { dia216(); }
        else if (myState == States.dia217) { dia217(); }
        else if (myState == States.dia218) { dia218(); }
        else if (myState == States.dia219) { dia219(); }
        else if (myState == States.dia220) { dia220(); }
        else if (myState == States.dia221) { dia221(); }
        else if (myState == States.dia222) { dia222(); }
        else if (myState == States.dia223) { dia223(); }
        else if (myState == States.dia224) { dia224(); }
        else if (myState == States.dia225) { dia225(); }
        else if (myState == States.dia226) { dia226(); }
        else if (myState == States.dia227) { dia227(); }
        else if (myState == States.dia228) { dia228(); }
        else if (myState == States.dia229) { dia229(); }
        else if (myState == States.dia230) { dia230(); }
        else if (myState == States.dia231) { dia231(); }
        else if (myState == States.dia232) { dia232(); }
        else if (myState == States.dia233) { dia233(); }
        else if (myState == States.dia234) { dia234(); }
        else if (myState == States.dia235) { dia235(); }
        else if (myState == States.dia236) { dia236(); }
        else if (myState == States.dia237) { dia237(); }
        else if (myState == States.dia238) { dia238(); }
        else if (myState == States.dia239) { dia239(); }
        else if (myState == States.dia240) { dia240(); }
        else if (myState == States.dia241) { dia241(); }
        else if (myState == States.dia242) { dia242(); }
        else if (myState == States.dia243) { dia243(); }
        else if (myState == States.dia244) { dia244(); }
        else if (myState == States.dia245) { dia245(); }
        else if (myState == States.dia246) { dia246(); }
        else if (myState == States.dia247) { dia247(); }
        else if (myState == States.dia248) { dia248(); }
        else if (myState == States.dia249) { dia249(); }
        else if (myState == States.dia250) { dia250(); }
        else if (myState == States.dia251) { dia251(); }
        else if (myState == States.dia252) { dia252(); }
        else if (myState == States.dia253) { dia253(); }
        else if (myState == States.dia254) { dia254(); }
        else if (myState == States.dia255) { dia255(); }
        else if (myState == States.dia256) { dia256(); }
        else if (myState == States.dia257) { dia257(); }
        else if (myState == States.dia258) { dia258(); }
        else if (myState == States.dia259) { dia259(); }
        else if (myState == States.dia260) { dia260(); }
        else if (myState == States.dia261) { dia261(); }
        else if (myState == States.dia262) { dia262(); }
        else if (myState == States.dia263) { dia263(); }
        else if (myState == States.dia264) { dia264(); }
        else if (myState == States.dia265) { dia265(); }
        else if (myState == States.dia266) { dia266(); }
        else if (myState == States.dia267) { dia267(); }
        else if (myState == States.dia268) { dia268(); }
        else if (myState == States.dia269) { dia269(); }
        else if (myState == States.dia270) { dia270(); }
        else if (myState == States.dia271) { dia271(); }
        else if (myState == States.dia272) { dia272(); }
        else if (myState == States.dia273) { dia273(); }
        else if (myState == States.dia274) { dia274(); }
        else if (myState == States.dia275) { dia275(); }
        else if (myState == States.dia276) { dia276(); }
        else if (myState == States.dia277) { dia277(); }
        else if (myState == States.dia278) { dia278(); }
        else if (myState == States.dia279) { dia279(); }
        else if (myState == States.dia280) { dia280(); }
        else if (myState == States.dia281) { dia281(); }
        else if (myState == States.dia282) { dia282(); }
        else if (myState == States.dia283) { dia283(); }
        else if (myState == States.dia284) { dia284(); }
        else if (myState == States.dia285) { dia285(); }
        else if (myState == States.dia286) { dia286(); }
        else if (myState == States.dia287) { dia287(); }
        else if (myState == States.dia288) { dia288(); }
        else if (myState == States.dia289) { dia289(); }
        else if (myState == States.dia290) { dia290(); }
        else if (myState == States.dia291) { dia291(); }
        else if (myState == States.dia292) { dia292(); }
        else if (myState == States.dia293) { dia293(); }
        else if (myState == States.dia294) { dia294(); }
        else if (myState == States.dia295) { dia295(); }
        else if (myState == States.dia296) { dia296(); }
        else if (myState == States.dia297) { dia297(); }
        else if (myState == States.dia298) { dia298(); }
        else if (myState == States.dia299) { dia299(); }
        else if (myState == States.dia300) { dia300(); }
        else if (myState == States.dia301) { dia301(); }
        else if (myState == States.dia302) { dia302(); }
        else if (myState == States.dia303) { dia303(); }
        else if (myState == States.dia304) { dia304(); }
        else if (myState == States.dia305) { dia305(); }
        else if (myState == States.dia306) { dia306(); }
        else if (myState == States.dia307) { dia307(); }
        else if (myState == States.dia308) { dia308(); }
        else if (myState == States.dia309) { dia309(); }
        else if (myState == States.dia310) { dia310(); }
        else if (myState == States.dia311) { dia311(); }
        else if (myState == States.dia312) { dia312(); }
        else if (myState == States.dia313) { dia313(); }
        else if (myState == States.dia314) { dia314(); }
        else if (myState == States.dia315) { dia315(); }
        else if (myState == States.dia316) { dia316(); }
        else if (myState == States.dia317) { dia317(); }
        else if (myState == States.dia318) { dia318(); }
        else if (myState == States.dia319) { dia319(); }
        else if (myState == States.dia320) { dia320(); }
        else if (myState == States.dia321) { dia321(); }
        else if (myState == States.dia322) { dia322(); }
        else if (myState == States.dia323) { dia323(); }
        else if (myState == States.dia324) { dia324(); }
        else if (myState == States.dia325) { dia325(); }
        else if (myState == States.dia326) { dia326(); }
        else if (myState == States.dia327) { dia327(); }
        else if (myState == States.dia328) { dia328(); }
        else if (myState == States.dia329) { dia329(); }
        else if (myState == States.dia330) { dia330(); }
        else if (myState == States.dia331) { dia331(); }
        else if (myState == States.dia332) { dia332(); }
        else if (myState == States.dia333) { dia333(); }
        else if (myState == States.dia334) { dia334(); }
        else if (myState == States.dia335) { dia335(); }
        else if (myState == States.dia336) { dia336(); }
        else if (myState == States.dia337) { dia337(); }
        else if (myState == States.dia338) { dia338(); }
        else if (myState == States.dia339) { dia339(); }
        else if (myState == States.dia340) { dia340(); }
        else if (myState == States.dia341) { dia341(); }
        else if (myState == States.dia342) { dia342(); }
        else if (myState == States.dia343) { dia343(); }
        else if (myState == States.dia344) { dia344(); }
        else if (myState == States.dia345) { dia345(); }
        else if (myState == States.dia346) { dia346(); }
        else if (myState == States.dia347) { dia347(); }
        else if (myState == States.dia348) { dia348(); }
        else if (myState == States.dia349) { dia349(); }
        else if (myState == States.dia350) { dia350(); }
        else if (myState == States.dia351) { dia351(); }
        else if (myState == States.dia352) { dia352(); }
        else if (myState == States.dia353) { dia353(); }
        else if (myState == States.dia354) { dia354(); }
        else if (myState == States.dia355) { dia355(); }
        else if (myState == States.dia356) { dia356(); }
        else if (myState == States.dia357) { dia357(); }
        else if (myState == States.dia358) { dia358(); }
        else if (myState == States.dia359) { dia359(); }
        else if (myState == States.dia360) { dia360(); }
        else if (myState == States.dia361) { dia361(); }
        else if (myState == States.dia362) { dia362(); }
        else if (myState == States.dia363) { dia363(); }
        else if (myState == States.dia364) { dia364(); }
        else if (myState == States.dia365) { dia365(); }
        else if (myState == States.dia366) { dia366(); }
        else if (myState == States.dia367) { dia367(); }
        else if (myState == States.dia368) { dia368(); }
        else if (myState == States.dia369) { dia369(); }
        else if (myState == States.dia370) { dia370(); }
        else if (myState == States.dia371) { dia371(); }
        else if (myState == States.dia372) { dia372(); }
        else if (myState == States.dia373) { dia373(); }
        else if (myState == States.dia374) { dia374(); }
        else if (myState == States.dia375) { dia375(); }
        else if (myState == States.dia376) { dia376(); }
        else if (myState == States.dia377) { dia377(); }
        else if (myState == States.dia378) { dia378(); }
        else if (myState == States.dia379) { dia379(); }
        else if (myState == States.dia380) { dia380(); }
        else if (myState == States.dia381) { dia381(); }
        else if (myState == States.dia382) { dia382(); }
        else if (myState == States.dia383) { dia383(); }
        else if (myState == States.dia384) { dia384(); }
        else if (myState == States.dia385) { dia385(); }
        else if (myState == States.dia386) { dia386(); }
        else if (myState == States.dia387) { dia387(); }
        else if (myState == States.dia388) { dia388(); }
        else if (myState == States.dia389) { dia389(); }
        else if (myState == States.dia390) { dia390(); }
        else if (myState == States.dia391) { dia391(); }
        else if (myState == States.dia392) { dia392(); }
        else if (myState == States.dia393) { dia393(); }
        else if (myState == States.dia394) { dia394(); }
        else if (myState == States.dia395) { dia395(); }
        else if (myState == States.dia396) { dia396(); }
        else if (myState == States.dia397) { dia397(); }
        else if (myState == States.dia398) { dia398(); }
        else if (myState == States.dia399) { dia399(); }
        else if (myState == States.dia400) { dia400(); }
        else if (myState == States.dia401) { dia401(); }
        else if (myState == States.dia402) { dia402(); }
        else if (myState == States.dia403) { dia403(); }
        else if (myState == States.dia404) { dia404(); }
        else if (myState == States.dia405) { dia405(); }
        else if (myState == States.dia406) { dia406(); }
        else if (myState == States.dia407) { dia407(); }
        else if (myState == States.dia408) { dia408(); }
        else if (myState == States.dia409) { dia409(); }
        else if (myState == States.dia410) { dia410(); }
        else if (myState == States.dia411) { dia411(); }
        else if (myState == States.dia412) { dia412(); }
        else if (myState == States.dia413) { dia413(); }
        else if (myState == States.dia414) { dia414(); }
        else if (myState == States.dia415) { dia415(); }
        else if (myState == States.dia416) { dia416(); }
        else if (myState == States.dia417) { dia417(); }
        else if (myState == States.dia418) { dia418(); }
        else if (myState == States.dia419) { dia419(); }
        else if (myState == States.dia420) { dia420(); }
        else if (myState == States.dia421) { dia421(); }
        else if (myState == States.dia422) { dia422(); }
        else if (myState == States.dia423) { dia423(); }
        else if (myState == States.dia424) { dia424(); }
        else if (myState == States.dia425) { dia425(); }
        else if (myState == States.dia426) { dia426(); }
        else if (myState == States.dia427) { dia427(); }
        else if (myState == States.dia428) { dia428(); }
        else if (myState == States.dia429) { dia429(); }
        else if (myState == States.dia430) { dia430(); }
        else if (myState == States.dia431) { dia431(); }
        else if (myState == States.dia432) { dia432(); }
        else if (myState == States.dia433) { dia433(); }
        else if (myState == States.dia434) { dia434(); }
        else if (myState == States.dia435) { dia435(); }
        else if (myState == States.dia436) { dia436(); }
        else if (myState == States.dia437) { dia437(); }
        else if (myState == States.dia438) { dia438(); }
        else if (myState == States.dia439) { dia439(); }
        else if (myState == States.dia440) { dia440(); }
        else if (myState == States.dia441) { dia441(); }
        else if (myState == States.dia442) { dia442(); }
        else if (myState == States.dia443) { dia443(); }
        else if (myState == States.dia444) { dia444(); }
        else if (myState == States.dia445) { dia445(); }
        else if (myState == States.dia446) { dia446(); }
        else if (myState == States.dia447) { dia447(); }
        else if (myState == States.dia448) { dia448(); }
        else if (myState == States.dia449) { dia449(); }
        else if (myState == States.dia450) { dia450(); }
        else if (myState == States.dia451) { dia451(); }
        else if (myState == States.dia452) { dia452(); }
        else if (myState == States.dia453) { dia453(); }
        else if (myState == States.dia454) { dia454(); }
        else if (myState == States.dia455) { dia455(); }
        else if (myState == States.dia456) { dia456(); }
        else if (myState == States.dia457) { dia457(); }
        else if (myState == States.dia458) { dia458(); }
        else if (myState == States.dia459) { dia459(); }
        else if (myState == States.dia460) { dia460(); }
        else if (myState == States.dia461) { dia461(); }
        else if (myState == States.dia462) { dia462(); }
        else if (myState == States.dia463) { dia463(); }
        else if (myState == States.dia464) { dia464(); }
        else if (myState == States.dia465) { dia465(); }
        else if (myState == States.dia466) { dia466(); }
        else if (myState == States.dia467) { dia467(); }
        else if (myState == States.dia468) { dia468(); }
        else if (myState == States.dia469) { dia469(); }
        else if (myState == States.dia470) { dia470(); }
        else if (myState == States.dia471) { dia471(); }
        else if (myState == States.dia472) { dia472(); }
        else if (myState == States.dia473) { dia473(); }
        else if (myState == States.dia474) { dia474(); }
        else if (myState == States.dia475) { dia475(); }
        else if (myState == States.dia476) { dia476(); }
        else if (myState == States.dia477) { dia477(); }
        else if (myState == States.dia478) { dia478(); }
        else if (myState == States.dia479) { dia479(); }
        else if (myState == States.dia480) { dia480(); }
        else if (myState == States.dia481) { dia481(); }
        else if (myState == States.dia482) { dia482(); }
        else if (myState == States.dia483) { dia483(); }
        else if (myState == States.dia484) { dia484(); }
        else if (myState == States.dia485) { dia485(); }
        else if (myState == States.dia486) { dia486(); }
        else if (myState == States.dia487) { dia487(); }
        else if (myState == States.dia488) { dia488(); }
        else if (myState == States.dia489) { dia489(); }
        else if (myState == States.dia490) { dia490(); }
        else if (myState == States.dia491) { dia491(); }
        else if (myState == States.dia492) { dia492(); }
        else if (myState == States.dia493) { dia493(); }
        else if (myState == States.dia494) { dia494(); }
        else if (myState == States.dia495) { dia495(); }
        else if (myState == States.dia496) { dia496(); }
        else if (myState == States.dia497) { dia497(); }
        else if (myState == States.dia498) { dia498(); }
        else if (myState == States.dia499) { dia499(); }
        */

    }

    //Sprite Controller
    #region

    void freshie()
    {
        myText.color = new Color(51f / 255.0f, 9f / 255.0f, 107f / 255.0f); //Purple Freshie
    }

    void otherCharacters()
    {
        myText.color = new Color(26f / 255.0f, 93f / 255.0f, 201f / 255.0f); //Blue Other Characters
    }

    void hideo(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Hideo;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Hideo;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Hideo;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Hideo;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Hideo;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Hideo;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Hideo;

        myText.color = new Color(140f / 255.0f, 122f / 255.0f, 4f / 255.0f); //Gold
    }

    void ofria(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Ofria;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Ofria;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Ofria;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Ofria;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Ofria;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Ofria;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Ofria;
        else if (position == 7)//when they don't move
        { }
        myText.color = new Color(150f / 255.0f, 15f / 255.0f, 191f / 255.0f); //Pinky Purple Ofria
    }

    void akira(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Akira;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Akira;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Akira;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Akira;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Akira;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Akira;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Akira;
        else if (position == 7)//when they don't move
        { }
        myText.color = new Color(196f / 255.0f, 19f / 255.0f, 140f / 255.0f); //Rosy Akira
    }

    void eiko(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Eiko;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Eiko;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Eiko;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Eiko;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Eiko;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Eiko;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Eiko;
        else if (position == 7)//when they don't move
        { }
        myText.color = new Color(116f / 255.0f, 105f / 255.0f, 234f / 255.0f); //Blue Purple Eiko
    }

    void nagisa(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Nagisa;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Nagisa;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Nagisa;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Nagisa;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Nagisa;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Nagisa;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Nagisa;
        else if (position == 7)//when they don't move
        { }
        myText.color = new Color(30f / 255.0f, 119f / 255.0f, 28f / 255.0f); //Green Nagisa
    }

    void teiji(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Teiji;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Teiji;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Teiji;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Teiji;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Teiji;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Teiji;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Teiji;
        else if (position == 7)//when they don't move
        { }
        myText.color = new Color(30f / 255.0f, 160f / 255.0f, 149f / 255.0f); //Jade Teiji
    }

    void wakako(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Wakako;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Wakako;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Wakako;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Wakako;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Wakako;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Wakako;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Wakako;
        else if (position == 7)//when they don't move
        { }
        myText.color = new Color(153f / 255.0f, 13f / 255.0f, 32f / 255.0f); //Red Wakako
    }

    void monika(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Monika;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Monika;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Monika;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Monika;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Monika;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Monika;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Monika;
        else if (position == 7)//when they don't move
        { }
        myText.color = new Color(237f / 255.0f, 106f / 255.0f, 154f / 255.0f); //Peachy monika
    }

    void blank(int position)
    {
        if (position == 0)
            Sprite0.gameObject.GetComponent<SpriteRenderer>().sprite = Blank;
        else if (position == 1)
            Sprite1.gameObject.GetComponent<SpriteRenderer>().sprite = Blank;
        else if (position == 2)
            Sprite2.gameObject.GetComponent<SpriteRenderer>().sprite = Blank;
        else if (position == 3)
            Sprite3.gameObject.GetComponent<SpriteRenderer>().sprite = Blank;
        else if (position == 4)
            Sprite4.gameObject.GetComponent<SpriteRenderer>().sprite = Blank;
        else if (position == 5)
            Sprite5.gameObject.GetComponent<SpriteRenderer>().sprite = Blank;
        else if (position == 6)
            Sprite6.gameObject.GetComponent<SpriteRenderer>().sprite = Blank;
        else if (position == 7)//when they don't move
        { }
    }


    void bg(Sprite insertBg)
    {
        Background.gameObject.GetComponent<SpriteRenderer>().sprite = insertBg;
    }
    #endregion

    //variable controllers
    #region
    void saveVars()
    {

        wakakoV = wakakoC;
        hideoV = hideoC;
        eikoV = eikoC;
        akiraV = akiraC;
        teijiV = teijiC;
        ofriaV = ofriaC;
        nagisaV = nagisaC;
    }

    void inputVars()
    {
        wakakoC = wakakoV;
        hideoC = hideoV;
        eikoC = eikoV;
        akiraC = akiraV;
        teijiC = teijiV;
        ofriaC = ofriaV;
        nagisaC = nagisaV;

    }

    void saveVars0()
    {
        wakako0 = wakakoC;
        hideo0 = hideoC;
        eiko0 = eikoC;
        akira0 = akiraC;
        teiji0 = teijiC;
        ofria0 = ofriaC;
        nagisa0 = nagisaC;
    }

    void inputVars0()
    {
        wakakoC = wakako0;
        hideoC = hideo0;
        eikoC = eiko0;
        akiraC = akira0;
        teijiC = teiji0;
        ofriaC = ofria0;
        nagisaC = nagisa0;

    }

    void saveVars1()
    {
        wakako1 = wakakoC;
        hideo1 = hideoC;
        eiko1 = eikoC;
        akira1 = akiraC;
        teiji1 = teijiC;
        ofria1 = ofriaC;
        nagisa1 = nagisaC;
    }

    void inputVars1()
    {
       wakakoC = wakako1;
        hideoC = hideo1;
        eikoC = eiko1;
        akiraC = akira1;
        teijiC = teiji1;
        ofriaC = ofria1;
        nagisaC = nagisa1;
    }

    void saveVars2()
    {
       wakako2 = wakakoC;
        hideo2 = hideoC;
        eiko2 = eikoC;
        akira2 = akiraC;
        teiji2 = teijiC;
        ofria2 = ofriaC;
        nagisa2 = nagisaC;
    }

    void inputVars2()
    {
        wakakoC = wakako2;
        hideoC = hideo2;
        eikoC = eiko2;
        akiraC = akira2;
        teijiC = teiji2;
        ofriaC = ofria2;
        nagisaC = nagisa2;
    }
    #endregion

    void playSound(AudioClip insertMusic)
    {
        MusicSource.clip = insertMusic;
        MusicSource.Play();
    }

    void playBGM(AudioClip insertMusic)
    {
        BGMSource.clip = insertMusic;
        BGMSource.Play();
    }

    void buttons()
    {
        if (Input.GetKeyDown(KeyCode.S)) { saveState = myState; saveVars(); }
        if (Input.GetKeyDown(KeyCode.Alpha1)) { saveState0 = myState; saveVars0(); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { saveState1 = myState; saveVars1(); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { saveState2 = myState; saveVars2(); }
        if (Input.GetKeyDown(KeyCode.L)) { myState = saveState; inputVars(); }
        if (Input.GetKeyDown(KeyCode.Q)) { myState = saveState0; inputVars0(); }
        if (Input.GetKeyDown(KeyCode.W)) { myState = saveState1; inputVars1(); }
        if (Input.GetKeyDown(KeyCode.E)) { myState = saveState2; inputVars2(); }
    }
    //0-99
    #region

    //0-9
    #region
    void dia0()
    {
        myText.text = "Seven Sins of School Simulator\n\n" +
            "Press Space to Advance";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) {
            myState = States.dia1;
            playBGM(bgm1);
            playSound(voice1);
        }
        myText = gameObject.GetComponent<Text>();
        freshie();
        bg(Exit);

       
    }

    void dia1()
    {
        myText.text = "Main Entrance:\n" +
                        "It’s my first day at Wonton high school.\n" +
                       "With my mother’s new job, we had to move back here.\n" +
                       "It’s funny how we moved away due to my late father’s work, and back again because of my mother.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia2; playSound(voice2); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia0; }
        bg(MainEntrance);
        
    }

    void dia2()
    {
        myText.text = "Hideo: [Freshie]?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia3; playSound(voice3); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia1; }

        hideo(3);

    }

    void dia3()
    {
        myText.text = "My eyes wander for who called out my name.\n" +
                       "I see Hideo, an old childhood friend of mine. We used to play together outside all the time.";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia4; playSound(voice4); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia2; }
        buttons();
        freshie();
    }

    void dia4()
    {
        myText.text = "(Hideo runs up to the Freshie)\n" +
                        "Hideo: No way!! It’s actually you! It’s been like forever!";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia5; playSound(voice5); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia3; }
        hideo(7);
    }

    void dia5()
    {
        myText.text = "Hideo hasn’t changed much from when we were younger. He’s still energetic about everything.\n" +
                        "[Freshie]: Yeah, I guess it has. How have you been?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia6; playSound(voice6); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia4; }
        freshie();    }

    void dia6()
    {
        myText.text = "Hideo: I’ve been good. I didn’t know you’d be enrolling here.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia7; playSound(voice7); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia5; }
        hideo(7);
    }

    void dia7()
    {
        myText.text = "[Freshie]: Yeah, it's a long story and i’ll spare you the details. Now I’m a Freshman.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia8; playSound(voice8); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia6; }
        freshie();    }

    void dia8()
    {
        myText.text = "(Hideo’s face seems to shrivel in contempt.)\n Both: ...";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia9; playSound(voice9); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia7; }
        hideo(7);    }

    void dia9()
    {
        myText.text = "[Freshie]: You’re a senior, right?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia10; playSound(voice10); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia8; }
        freshie();    }
    #endregion

    //10-19
    #region
    void dia10()
    {
        myText.text = "Hideo: Yeah...\n" +
            "Both: ...\n" +
            "Hideo: You wanna come inside? It's still cold out.\n";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia11; playSound(voice11); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia9; }
        hideo(7);    }
    
    void dia11()
    {
        myText.text = "Hallway:\n" +
                        "We walk into the lobby and start pleasant conversation.\n" +
                        "Hideo and I walk around the first floor catching up while he tells me what the classrooms are for.\n" +
                        "The school seems easy to maneuver through.The floors are composed of straight hallways that make the shape of the square.\n" +
                        "If I keep walking around, I’ll find my class eventually.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia12; playSound(voice12); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia10; }
        freshie();
    }

    void dia12()
    {
        myText.text = "Hideo: And we’re back in the lobby, easy enough?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia13; playSound(voice13); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia11; }
        hideo(7);
    }

    void dia13()
    {
        myText.text = "I nod\n" +
                      "People walk into the building now, all upperclassmen that already know their way around the building.\n" +
                        "I then see two girls strut toward Hideo, sparking a flirtatious conversation with him, disregarding me.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia14; playSound(voice14); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia12; }
        freshie();
    }

    void dia14()
    {
        myText.text = "(Ofria & Akira enter the scene)\n" +
                        "Ofria: Hey He~day~oh~";

        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia15; playSound(voice15); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia13; }
        akira(1);
        ofria(0);
    }

    void dia15()
    {
        myText.text = "Akira: Hideo did you hear about Anri-";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia16; playSound(voice16); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia14; }
        myText.color = new Color(196f / 255.0f, 19f / 255.0f, 140f / 255.0f); //Rosy Akira
    }

    void dia16()
    {
        myText.text = "They talk gossip while Hideo passively replies about what they bring up.\n" +
            "He doesn’t seem really interested into their conversation\n" +
            "How awkward.\n" +
            "I stare at Hideo until he notices my presence again.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia17; playSound(voice17); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia15; }
        myText.color = new Color(51f / 255.0f, 9f / 255.0f, 107f / 255.0f); //Purple Freshie
    }

    void dia17()
    {
        myText.text = "Hideo: Oh. I forgot to mention Ofira, Akira, meet [Freshie]. ";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia18; playSound(voice18); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia16; }
        myText.color = new Color(140f / 255.0f, 122f / 255.0f, 4f / 255.0f); //Gold Hideo
    }

    void dia18()
    {
        myText.text = "Ofria and Akira look at me, but you can tell they only did so because Hideo told them to.\n" +
            "Double awkward.\n" +
            "The bell rings after what seems like forever and I wave bye to Hideo.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia19; playSound(voice19); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia17; }
        myText.color = new Color(51f / 255.0f, 9f / 255.0f, 107f / 255.0f); //Purple Freshie
    }

    void dia19()
    {
        myText.text = "Hideo: Will you actually be able to find class on your own?\n" +
                        "He’s right. I don’t really know where I’m going.\n" +
                        "Hideo: Come on, I’ll take you there.\n" +
                        "Hideo takes my paper and begins to lead me to my homeroom.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia20; playSound(voice20); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia18; }
        hideo(3);
        blank(0);
        blank(1);

    }


    #endregion

    //20-29
    #region

    void dia20()
    {
        myText.text = "Hallway:\n" +
            "Many people keep waving at Hideo, some even stop to talk to him.\n" +
            "Hideo’s just as popular in high school as he was in elementary school.\n" +
            "We reach the outside of a classroom that looks similar to all the rest.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia21; playSound(voice21); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia19; }
        bg(Hallway);
        freshie();
    }

    void dia21()
    {
        myText.text = "Hideo: Here we are, your homeroom. ";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia22; playSound(voice22); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia20; }
        hideo(7);
    }

    void dia22()
    {
        myText.text = "Hideo returns my paper to me.\n"+ "[Freshie]: Thanks. See you later, Hideo.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia23; playSound(voice23); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia21; }
        freshie();
    }

    void dia23()
    {
        myText.text = "Hideo: Later, dude.\n"
            ;
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia24; playSound(voice24); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia22; }
        hideo(7);
    }

    void dia24()
    {
        myText.text = "Hideo leaves as I walk into my homeroom.\n" +
            "Homeroom:\n" +
            "Once I walk in everyone is standing in a poorly made circle around the desks.\n" +
            "Most kids are on their phones or talking to one another, most must have came from the same middle school.\n" +
        "The bell rang as I found an empty space.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia25; playSound(voice25); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia23; }
        freshie();
        blank(3);
        bg(Homeroom);
    }

    void dia25()
    {
        myText.text = "Teacher: Welcome to highschool!\n" +
            "We’ll start off with an Icebreaker to get to know each other.\n" +
            "Say your name and your favorite thing to do.";

        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia26; playSound(voice26); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia24; }
        otherCharacters();
    }

    void dia26()
    {
        myText.text = "The teacher faked enthusiasm. You could tell she wishes this was still summer break.\n" +
"Each kid said their names and their favourite thing to do which hardly varied from sleeping, videogames, reading, and sports.\n" +
"The ball went around until it got to one girl who was on her phone the entire time and didn’t seem to notice that it was her turn for the ice breaker.\n" +
            "The kid next to her gently nudged her to tell her it was her turn.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia27; playSound(voice27); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia25; }
        freshie();
    }

    void dia27()
    {
        myText.text = "Wakako: What do ya want?\n" +
            "She turned toward the kid who gently nudged her with a fierce and enraged expression.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia28; playSound(voice28); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia26; }
        wakako(3);
    }

    void dia28()
    {
        myText.text = "Teacher: It’s your turn for the ice breaker.\n" +
            "Wakako: What do I gotta say.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia29; playSound(voice29); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia27; }
        wakako(7);
    }

    void dia29()
    {
        myText.text = "Teacher: Your name and your favourite thing to do.\n" +
            "The teacher was beginning to crack.\n" +
            "Her thinly veiled hatred of work became more and move evident with each thing she said to the girl.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia30; playSound(voice30); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia28; }
        otherCharacters();
    }
    #endregion

    //30=39
    #region
    void dia30()
    {
        myText.text = "Wakako: I’m Wakako. My favourite thing to do is complain about my teachers.\n" +
            "Wakako winks at the teacher and returns to their phone and continued to text.\n" +
            "The teacher was taken aback and grinded her teeth but went on to the next student.\n" +
            "After a few more kids, it was my turn.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia31; playSound(voice31); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia29; }
        wakako(7);
    }

    void dia31()
    {
        myText.text = "[Freshie]: My names [Freshie] and my favourite thing to do is…\n" +
                          "Choice:\n" +
                          "Press V for Videogames\t\t" + //(+Teiji & Eiko)
                          "Press R for Reading\n" + //(+Nagisa)
                          "Press Z for Shopping\t\t" + //(+Ofria)
                          "Press A for Sports\n" + //(+Hideo & Akira)
                          "Press T for Shutting down nosy teachers"; //(+Wakako)

        //don't use Q W E 1 2 3 S L
        buttons();
        if (Input.GetKeyDown(KeyCode.V))
        {
            myState = States.dia32; playSound(voice32);
            teijiC++;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.dia32; playSound(voice32);
            nagisaC++;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            myState = States.dia32; playSound(voice32);
            ofriaC++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.dia32; playSound(voice32);
            hideoC++;
            akiraC++;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.dia32; playSound(voice32);
            wakakoC++;
        }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia30; }
        freshie();
        blank(3);
    }

    void dia32()
    {
        myText.text = "After me, the icebreaker ended.\n" +
"The teacher began to speak but an incoming student interrupted her.\n" +
"A boy who wore pajama pants, sandals, and a worn down sweater trudged into the class bringing along the putrid scent of marijuana with him." +
" (Teiji enters)";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia33; playSound(voice33); }
    }

    void dia33()
    {
        myText.text = "Teacher: Hello class. Say your name and favourite thing to do. " +
            "The teacher was absolutely disgusted and held her breath as Teiji walked past.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia34; playSound(voice34); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia32; }
        otherCharacters();
    }

    void dia34()
    {
        myText.text = "Teiji: Hey.\n" +
            "His words were slurred and the dark bags under his eyes could carry groceries.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia35; playSound(voice35); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia33; }
        teiji(3);
    }

    void dia35()
    {
        myText.text = "Teiji: My name is Teiji. My favourite thing to do is sleep.\n" +
            "He takes so long to speak, the bell rings after he finishes his sentence.\n" +
            "I look at my schedule and begin to my next class, math... ";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia36; playSound(voice36); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia34; }
        teiji(7);
    }

    void dia36()
    {
        myText.text = "Hallway:\n" +
        "Where am I going?\n" +
"The hallways are large but full of people, the numbers on the door are hard to read.\n" +
"I have no idea where I am right now. " +
"After searching, I manage to find my classroom.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia37; playSound(voice37); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia35; }
        freshie();
        bg(Hallway2);
        blank(3);
    }

    void dia37()
    {
        myText.text = "Math:\n" +
"Our names are on the board to show our assigned seats. " +
"The bell rings as I sit.\n" +
"A few minutes later, the same kid from Homeroom walks in.\n" +
"Teiji ? I think that was his name. How’d he get here late?\n" +
 "Teiji sits down next to me which causes my breathe in his toxic air.";
        buttons(); 
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia38; playSound(voice38);}
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia36; }
        bg(Math);
        teiji(3);
        freshie();

    }

    void dia38()
    {
        myText.text = "Teacher: [Freshie], what’s the surface area formula of a sphere?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia39; playSound(voice39); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia37; }
        otherCharacters();
        blank(3);
    }

    void dia39()
    {
        myText.text = "[Freshie]: Uh…\n" +
            "Press U for 4πr^2\n" +
            "Press I for πr ^ 2\n" +
            "Press O for 2πr";
        buttons();
        if (Input.GetKeyDown(KeyCode.U)) { myState = States.dia40; playSound(voice40); }
        if (Input.GetKeyDown(KeyCode.I)) { myState = States.dia41; playSound(voice41); }
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.dia41; playSound(voice41); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia38; playSound(voice38); }
        freshie();
    }
    #endregion

    //40-49
    #region
    void dia40()
    {
        myText.text = "Teacher: Correct.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia42; playSound(voice42); }
        otherCharacters();
    }

    void dia41()
    {
        myText.text = "Pay attention please.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia42; playSound(voice42); }
        otherCharacters();
    }

    void dia42()
    {
        myText.text = "The teacher continues teaching the material rather than the syllabus.\n" +
"She passes out a worksheet for us to do, unsurprisingly, I don’t know how to do much.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia43; playSound(voice43); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia40; }
        freshie();
    }

    void dia43()
    {
        myText.text = "Teiji: Need help? You just gotta…\n" +
            "Teiji scooted over and began teaching me how to do these geometry problems.\n" +
            "Honestly, I barely understood what he was saying, but I appreciated his help.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia44; playSound(voice44); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia42; }
        teiji(3);
    }

    void dia44()
    {
        myText.text = "[Freshie]: You’re so smart, what grade are you in?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia45; playSound(voice45); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia43; }
        freshie();
    }

    void dia45()
    {
        myText.text = "Teiji: Senior.\n" +
            "Teiji returns to his desk and quickly sleeps.\n" +
            "I return to the math problems I now sort of know how to do and work on them.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia46; playSound(voice46); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia44; }
        teiji(7);
    }

    void dia46()
    {
        myText.text = "The bell rings after what seems like forever.\n" +
            "Teacher: Have that paper done by tomorrow.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia47; playSound(voice47); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia45; }
        otherCharacters();
    }

    void dia47()
    {
        myText.text = "I look over at Teiji’s paper to find that it was empty and he was still asleep.\n" +
            "I leave the classroom and find my way to my next class, science.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia48; playSound(voice48); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia46; }
        freshie();
    }

    void dia48()
    {
        myText.text = "Hallway:\n" +
"Thankfully, the science classrooms are on the same floor as math.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia49; playSound(voice49); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia47; }
        freshie();
        bg(Hallway2);
        blank(3);
    }

    void dia49()
    {
        myText.text = "Science Classroom:\n" +
"I walk into the classroom to find our names on the board again.\n" +
            "Walking over to my seat, I find a girl in it.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia50; playSound(voice50); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia48; }
        freshie();
        bg(Science);
    }
    #endregion

    //50-59
    #region
    void dia50()
    {
        myText.text = "[Freshie]: Uh, I think this is my seat.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia51; playSound(voice51); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia49; }
        eiko(3);
        freshie();
    }

    void dia51()
    {
        myText.text = "Eiko: I like this seat better.\n" +
            "True, it is a window seat. But the teacher assigned us these seats.\n" +
            "Choice: \n" +
            "Press H to Let her sit in your seat\n" + //Eiko
            "Press M to say \"It's my seat\""; //Ofira
        buttons();
        if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.dia58; playSound(voice58);
            eikoC++;
            letHer++;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.dia52; playSound(voice52);
            ofriaC++;
        }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia50; }
        eiko(3);
    }

    void dia52()
    {
        myText.text = "Eiko: What the f*** did you just f*cking say about me, you little bitch?\n" +
            "I’ll have you know I graduated top of my class in the Navy Seals, and I’ve been involved in numerous secret raids on Al-Quaeda, and I have over 300 confirmed kills.\n" +
            "I am trained in gorilla warfare and I’m the top sniper in the entire US armed forces. ";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia53; playSound(voice53); }
        eiko(7);
    }

    void dia53()
    {
        myText.text = "You are nothing to me but just another target.\n " +
            "I will wipe you the f*** out with precision the likes of which has never been seen before on this Earth, mark my f***ing words.\n" +
            "You think you can get away with saying that shit to me over the Internet? Think again, f**ker.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia54; playSound(voice54); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia52; }
        eiko(7);
    }

    void dia54()
    {
        myText.text = "As we speak I am contacting my secret network of spies across the USA and your IP is being traced right now so you better prepare for the storm, maggot.\n" +
            "The storm that wipes out the pathetic little thing you call your life.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia55; playSound(voice55); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia53; }
        eiko(7);
    }

    void dia55()
    {
        myText.text = "You’re ****ing dead, kid. I can be anywhere, anytime, and I can kill you in over seven hundred ways, and that’s just with my bare hands.\n" +
            "Not only am I extensively trained in unarmed combat, but I have access to the entire arsenal of the United States Marine Corps and I will use it to its full extent to wipe your miserable ass off the face of the continent, you little shit. ";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia56; playSound(voice56); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia54; }
        eiko(7);
    }

    void dia56()
    {
        myText.text = " If only you could have known what unholy retribution your little “clever” comment was about to bring down upon you, maybe you would have held your ****ing tongue. ";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia57; playSound(voice57); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia55; }
        eiko(7);
    }

    void dia57()
    {
        myText.text = "But you couldn’t, you didn’t, and now you’re paying the price, you goddamn idiot. I will shit fury all over you and you will drown in it.\n" +
            "You’re ****ing dead, kiddo.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia58; playSound(voice58); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia56; }
        eiko(7);
    }

    void dia58()
    {
        myText.text = "I decide to take her seat instead which is near the back of the class.\n" +
            "The teacher just lets me sit there and doesn’t ask her to go to her seat.\n" +
"The teacher hands out a syllabus and tells the class to take notes on it.\n" +
"Who asks kids to take notes on the syllabus?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia59; playSound(voice59); }
        freshie();
        blank(3);
    }

    void dia59()
    {
        myText.text = "The kid behind me taps my shoulder.\n" +
                        "Nagisa: Hey, you got a pencil?\n" +
                        "Choice:\n" +
                        "Press G to Give Nagisa a pencil\n" +
                        "Press R to Refuse to give Nagisa a pencil";
        buttons();
        if (Input.GetKeyDown(KeyCode.G)) { myState = States.dia60; nagisaC++; give++; playSound(voice60); }
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.dia61; playSound(voice61); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia58; playSound(voice58); }
        nagisa(3);
    }
    #endregion

    //60-69
    #region
    void dia60()
    {
        myText.text = "Nagisa: Thanks, my name’s Nagisa.\n" +
"[Freshie]: No problem, I’m [Freshie].";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia62; playSound(voice62); }
        freshie();
    }

    void dia61()
    {
        myText.text = "Nagisa: You don’t even got one extra pencil?\n" +
            "He turns away and asks the person next to him";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia62; playSound(voice62); }
        nagisa(7);
    }

    void dia62()
    {
        myText.text = "The bell rings and I go onto my next class.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (letHer == 0 && give == 0)
            {
                myState = States.dia65;
                playSound(voice65);
            }
            else if (letHer == 1) { 
                myState = States.dia63;
                playSound(voice63);
            }
            else if (give == 1)
            {
                myState = States.dia64;
                playSound(voice64);
            }
                
        }
        blank(3);
        freshie();
    }

    void dia63()
    {
        myText.text = "Eiko: What’s your next class?\n" +
            "[Freshie]: Uh… APUSH\n" +
"Eiko: Gross, you’re a freshman (Eiko leaves)";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) {
            if(give == 1)
            {
                myState = States.dia64;
                playSound(voice64);
            }
            else
            {
                myState = States.dia65;
                playSound(voice65);
            }
                
        }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia62; }
        eiko(3);
    }

    void dia64()
    {
        myText.text =
            "Nagisa: Aye so what class ya got?\n" +
            "[Freshie]: Uh… APUSH\n" +
"Nagisa: You a freshman?\n" +
"[Freshie]: “Yeah”\n" +
"Nagisa: Good luck, freshie. (Nagisa leaves)";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia65; playSound(voice65); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia63; }
        nagisa(3);
    }

    void dia65()
    {
        myText.text = "Hallway:\n" +
            "Am I even on the right floor?\n" +
"I walk around in confusion.\n" +
"Oh wait, here it is.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia66; playSound(voice66); }
        freshie();
        bg(Hallway);
        blank(3);
    }

    void dia66()
    {
        myText.text = "APUSH:\n" +
"Is that the girl from before? The same girl who was in my seat last period is in this class once again.\n" +
"Is she a freshman too? I sit in my seat and the teacher hands out the syllabus and tells us to read it.\n" +
"Blah blah this is an ap class it’s hard blah blah. " +
"The bell rings. " +
"Next is General P.E.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia67; playSound(voice67); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia65; }
        eiko(0);
        freshie();
        bg(MediaCenter);
    }

    void dia67()
    {
        myText.text = "Stairway:\n" +
"The gym is on the first floor, I remember Hideo showing me the gym.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia68; playSound(voice68); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia66; }
        blank(0);
        freshie();
        bg(Stairs);
    }

    void dia68()
    {
        myText.text = "Gym:\n" +
"Hey, is that Hideo ?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia69; playSound(voice69); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia67; }
        bg(Gym);
        freshie();
    }

    void dia69()
    {
        myText.text = "Hideo: Hey! [Freshie]!";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia70; playSound(voice70); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia68; }
        hideo(3);
    }
    #endregion

    //70-79
    #region
    void dia70()
    {
        myText.text = "[Freshie]: Hey Hideo, guess we have this class together?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia71; playSound(voice71); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia69; }
        freshie();
    }

    void dia71()
    {
        myText.text = "Hideo: Yeah! That’s awesome.\n" +
            "We sit on the bleachers and the teacher calls roll.\n" +
            "The teacher brings out a cart full of basketballs and Hideo runs up and grabs one.";
        buttons(); 
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia72; playSound(voice72); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia70; }
        hideo(7);
    }

    void dia72()
    {
        myText.text = "Hideo: Come on! Let’s play, like old times.\n" +
            "I used to always lose against Hideo in sports. Maybe this is redemption?\n" +
            "We play basketball until the teachers call for the balls back.\n" +
            "Hideo glistens in sweat while I’m drenched in it.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia73; playSound(voice73); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia71; }
        hideo(7);
    }

    void dia73()
    {
        myText.text = "Hideo: I won again! Just like old times, huh?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia74; playSound(voice74); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia72; }
        hideo(7);
    }

    void dia74()
    {
        myText.text = "[Freshie]: Yeah.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia75; playSound(voice75); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia73; }
        freshie();
    }

    void dia75()
    {
        myText.text = "Girls were entranced by Hideo’s sweat tight shirt revealing the outline of his upper body.\n" +
"Hideo goes to get our backpacks from the bleachers";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia76; playSound(voice76); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia74; }
        freshie();
    }

    void dia76()
    {
        myText.text = "Hideo: Do you need help going to your next class?\n" +
            "Choice:\n" +
            "Press Z for Sure\n" + //(+Hideo)
            "Press F for I’ll be fine"; //(+Wakako)
        buttons();
        if (Input.GetKeyDown(KeyCode.Z)) { myState = States.dia77; hideoC++; playSound(voice77); }
        if (Input.GetKeyDown(KeyCode.F)) { myState = States.dia78; wakakoC++; playSound(voice78); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia75; playSound(voice75); }
        bg(Stairs);
        hideo(7);
    }

    void dia77()
    {
        myText.text = "Hideo walks with me to class\n" +
            "Walking up and down all these stairs feels like a workout.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia79; playSound(voice79); }
        bg(Hallway2);
        freshie();
    }

    void dia78()
    {
        myText.text = "Hideo scoffs.\n" +
            "Hideo: Good luck then.\n" +
            "Walking up and down all these stairs feels like a workout";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia79; playSound(voice79); }
        blank(3);
        bg(Hallway2);
    }

    void dia79()
    {
        myText.text = "English Classroom:\n" +
                    "Is that the girl again?\n" +
                    "It’s free seating but the only seat left is next to her.\n" +
                    "She radiates a vibe of “Get away from me.”\n" +
                    "The bell rings, before she rushes out I try to talk to her.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia80; playSound(voice80); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia78; }
        eiko(0);
        freshie();
        blank(3);
        bg(MediaCenter);
    }

    void dia80()
    {
        myText.text = "[Freshie]: What class do you have next?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia81; playSound(voice81); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia79; }
        freshie();
    }
    #endregion

    //80-89
    #region
    void dia81()
    {
        myText.text = "Eiko: Lunch, idiot.\n" +
"Choice:\n" +
"Press G for Where are you going to eat?\n" + //(+Aiko) 
"Press H for What’re you eating?\n" + //(+Nagisa)
"Press J for Walk Away";//(+Teiji)

        buttons();
        if (Input.GetKeyDown(KeyCode.G)) { myState = States.dia82; playSound(voice82); }
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.dia83; playSound(voice83); }
        if (Input.GetKeyDown(KeyCode.J)) { myState = States.dia84; playSound(voice84); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia80; }
        blank(0);
        eiko(6);
    }

    void dia82()
    {
        myText.text = "Eiko: Away from you.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia85; playSound(voice85); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia81; }
        eiko(7);
    }

    void dia83()
    {
        myText.text = "Eiko: Nunya sandwich.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia85; playSound(voice85); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia81; }
        eiko(7);
    }

    void dia84()
    {
        myText.text = "I turn around and leave her. " +
"Why should I waste time on that bitch ?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia85; playSound(voice85); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia81; }
        freshie();
    }

    void dia85()
    {
        myText.text = "There are club tables everywhere inviting freshman to their clubs.\n" +
"I wander around until something finds my interest.";
buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia86; playSound(voice86); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia84; }
        freshie();
        blank(6);
        bg(Cafe);
    }

    void dia86()
    {
        myText.text = "Anime club? Too weeb-y.\n" +
"Robotics? Too nerdy. " +
"Book club? Extra nerdy.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia87; playSound(voice87); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia85; }
        freshie();
    }

    void dia87()
    {
        myText.text = "I wander until i find a stand that catches my eye.\n" +
            "Huh, the literature club?\n" +
            "A kind looking girl waves at me.\n" +
            "Monika: Hey…! Want to join Literature club?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia88; playSound(voice88); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia86; }
        monika(3);

    }

    void dia88()
    {
        myText.text = "[Freshie]: Uh, what do you do?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia89; playSound(voice89); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia87; }
        freshie();
    }

    void dia89()
    {
        myText.text = "Monika: We write poems and have fun together.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia90; playSound(voice90); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia88; }
        monika(7);
    }
    #endregion

    //90-99
    #region
    void dia90()
    {
        myText.text = "[Freshie]: Sure, may as well.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia91; playSound(voice91); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia89; }
        freshie();
    }

    void dia91()
    {
        myText.text = "I sign the paper then leave the club stands and search the cafeteria.\n" +
"Hideo is in the back sitting at a table surrounded by friends. I make my way towards him.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia92; playSound(voice92); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia90; }
        hideo(0);
        blank(3);
        freshie();
    }

    void dia92()
    {
        myText.text = "Akira: Ohmygosh Hideo I saw that pic of you in gym.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia93; playSound(voice93); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia91; }
        hideo(3);
        ofria(1);
        akira(0);
    }

    void dia93()
    {
        myText.text = "Ofria: You’re sooo athletic. What were you doing?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia94; playSound(voice94); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia92; }
        ofria(7);
        }

    void dia94()
    {
        myText.text = "Hideo: I was just playing basketball with [Freshie]. Couldn’t be helped that I won so easily.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia95; playSound(voice95); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia93; }
        hideo(3);
    }

    void dia95()
    {
        myText.text = "Harsh.\n[Freshie]: Hey Hideo.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia96; playSound(voice96); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia94; }
        freshie();
    }

    void dia96()
    {
        myText.text = "Hideo: [Freshie]! We were just talking about the game. This is Ofria and Akira.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia97; playSound(voice97); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia95; }
        hideo(7);
    }

    void dia97()
    {
        myText.text = "Ofria: How was it being crushed by Hideo?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia98; playSound(voice98); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia96; }
        ofria(7);
    }

    void dia98()
    {
        myText.text = "Hideo: Hey don’t rub it in [Freshie]’s face. I couldn’t be helped, I’m just the best.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia99; playSound(voice99); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia97; }
        hideo(7);
    }

    void dia99()
    {
        myText.text = "Akira: You really are the best~ ❤";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia100; playSound(voice100); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia98; }
        akira(7);
    }
    #endregion

    #endregion

    //100-199
    #region

    //100-109
    #region
    void dia100()
    {
        myText.text = "Hideo: We used to play all the time, remember?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia101; playSound(voice101); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia99; }
        hideo(7);
    }

    void dia101()
    {
        myText.text = "[Freshie]: Yeah, at your house, when we lived close to each other.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia102; playSound(voice102); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia100; }
        freshie();
    }

    void dia102()
    {
        myText.text = "Ofria: You lived in a mansion like Hideo? You’re rich?\n" +
            "Choice:\n" +
        "Press Y for Yes\n" + //(+Ofria)
        "Press N for No"; //(+Teiji)
        buttons();
        if (Input.GetKeyDown(KeyCode.Y)) { myState = States.dia103; ofriaC++; playSound(voice103); }
        if (Input.GetKeyDown(KeyCode.N)) { myState = States.dia104; teijiC++; playSound(voice104); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia101; }
        ofria(7);
    }

    void dia103()
    {
        myText.text = "Ofria’s eyes sparkle.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia105; playSound(voice105); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia102; }
        ofria(7);
    }

    void dia104()
    {
        myText.text = "Ofria looks at me with disdain.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia105; playSound(voice105); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia102; }
        ofria(7);
    }

    void dia105()
    {
        myText.text = "Hideo: We used to always play together though, and even then I still won.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia106; playSound(voice106); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia104; }
        hideo(7);
    }

    void dia106()
    {
        myText.text = "Actually, you lost at first.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia107; playSound(voice107); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia105; }
        freshie();
    }

    void dia107()
    {
        myText.text = "Akira: So amazing~ ❤";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia108; playSound(voice108); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia106; }
        akira(7);
    }

    void dia108()
    {
        myText.text = "Ofria: Even as a kid you were the greatest~ ❤";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia109; playSound(voice109); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia107; }
        ofria(7);
    }

    void dia109()
    {
        myText.text = "Awkward\n" +
            "After a while, the bell rings and everyone leaves the lunch table to walk to class.\n" +
            "I have music technology next, which is on the same floor.\n" +
"Ofria and Akira stayed behind to talk to Hideo longer.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia110; playSound(voice110); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia108; }
        freshie();
        blank(0);
        blank(1);
        blank(3);
    }
    #endregion

    //110-119
    #region
    void dia110()
    {
        myText.text = "Hallway:\n" +
"Am I going the right way? It’s somewhere on this floor…";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia111; playSound(voice111); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia109; }
        bg(Stairs);
    }

    void dia111()
    {
        myText.text = "Music Technology:\n" +
"I manage to get to the music tech room. The classroom is full of apple computers we get to use. " +
"I see Akira and Ofria, Akira waves at me and motions for me to sit with them.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia112; playSound(voice112); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia110; }
        
        akira(3);
        ofria(2);
        freshie();
        bg(Music);
    }

    void dia112()
    {
        myText.text = "I sit in the chair next to them, but they’re busy talking to each other and sharing whatever they have on their phone with one another.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia113; playSound(voice113); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia111; }
        freshie();
    }

    void dia113()
    {
        myText.text = "The teacher sits on their chair and plays an intro video.\n" +
            "Choice:\n" +
            "Press T to Talk to Ofria & Akira\n" + //(+ Ofria & Akira)
            "Press P to Play on your phone\n"; //(Eiko and Teiji)
        buttons();
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.dia114; ofriaC++; akiraC++; playSound(voice114); }
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.dia115; teijiC++; eikoC++; playSound(voice115); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia112; }
        freshie();
    }

    void dia114()
    {
        myText.text = "[Freshie]: Do you guys have any fresh me-mes?\n" +
"Akira: You mean memes?\n" +
"Ofria: We don’t waste time with those.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia116; playSound(voice116); }
        freshie();
    }

    void dia115()
    {
        myText.text = "I take out my phone and play some random phone game to pass the time.\n" +
"The bell rings, so I begin to go to my next class, Global Connections.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia116; playSound(voice116); }
        freshie();
    }

    void dia116()
    {
        myText.text = "Hallway:\n" +
        "My next class is also on the first floor, what a blessing.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia117; playSound(voice117); }
        bg(Stairs);
        freshie();
        blank(3);
        blank(2);
    }

    void dia117()
    {
        myText.text = "Global Connections:\n" +
"I sit down in the mostly empty classroom and play on my phone.\n" +
"The teacher doesn’t seem to be doing anything and there’s no one I know here.\n" +
 "{Time skip}\n" +
        "The bell rings.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia118; playSound(voice118); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia116; }
        freshie();
        bg(Homeroom);
    }

    void dia118()
    {
        myText.text = "Lobby:\n" +
"I walk out onto the main lobby and see Hideo standing around near the door.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia119; playSound(voice119); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia117; }
        freshie();
        bg(Stairs);
    }

    void dia119()
    {
        myText.text = "[Freshie]: Hey Hideo.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia120; playSound(voice120); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia118; }
        hideo(3);
        freshie();
    }
    #endregion

    //120-129
    #region
    void dia120()
    {
        myText.text = "Hideo: Hey, [Freshie]. You enjoy your first day of school?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia121; playSound(voice121); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia119; }
        hideo(3);
       
    }

    void dia121()
    {
        myText.text = "[Freshie]: It was okay I guess. ";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia122; playSound(voice122); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia120; }
        freshie();
    }

    void dia122()
    {
        myText.text = "Hideo: Yeah, playing basketball was really fun though. You interested in school sports?\n" +
            "Choice:\n" +
"Press Y for I’m a baller.\n" + //(+Hideo)
"Press N for Nah\n"; //(+Teiji)

        buttons();
        if (Input.GetKeyDown(KeyCode.Y)) { myState = States.dia123; hideoC++; playSound(voice123); }
        if (Input.GetKeyDown(KeyCode.N)) { myState = States.dia124; teijiC++; playSound(voice124); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia121; }
        hideo(7);
    }

    void dia123()
    {
        myText.text = "[Hideo smiles] Hideo: Nice! But don’t join any sports if you play like how you did during P.E. You’d get crushed.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia125; playSound(voice125); }
        hideo(7);
    }

    void dia124()
    {
        myText.text = "Hideo: No wonder I won so easily.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia125; playSound(voice125); }
        hideo(7);
    }

    void dia125()
    {
        myText.text = "Hideo: How are you getting home?";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia126; playSound(voice126); }
        hideo(7);
    }

    void dia126()
    {
        myText.text = "[Freshie]: Taking a bus.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia127; playSound(voice127); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia125; }
        freshie();
    }

    void dia127()
    {
        myText.text = "Hideo: Better rush, buses don’t wait.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia128; playSound(voice128); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia126; }
        hideo(7);
    }

    void dia128()
    {
        myText.text = "[Freshie]: Crap. Thanks, Hideo!";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia129; playSound(voice129); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia127; }
        freshie();
    }

    void dia129()
    {
        myText.text = "I rush out the door.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia130; playSound(voice130); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia128; }
        freshie();
    }
    #endregion
    void dia130()
    {
        myText.text = "Bus:\n" +
"I finally found my bus in the posse of busses in the bus loop.\n" +
"Gross, it smells like teen spirit.\n" +
"I sit right behind the bus driver, the only seat that’s left. My phone is the only thing that entertains me on the way home.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia131; playSound(voice131); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia129; }
        freshie();
        bg(MainEntrance);
        blank(3);
    }

    void dia131()
    {
        myText.text = "Home:\n" +
"Finally home.\n" +
"I go into my room and put my backpack on the floor and plop onto the bed.";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia132; playSound(voice132); }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia130; }
        freshie();
        bg(Blank);
    }

    void dia132()
    {
        myText.text = "Oh bed, I missed you so much. " +
"The day was weird. I met a bunch of okay people and got to hang out with Hideo again. " +
"I was so tired and began to drift of into a nap which didn’t end until tomorrow morning."
;
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia133;  }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia131; }
        freshie();
    }

    void dia133()
    {
        myText.text = "To be Continued...???";
        buttons();
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.dia134; }
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.dia132; }
        freshie();
    }


    #endregion


}






