// 
// SMS Golden Axe Editor
// Copyright (C) 2020 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System.ComponentModel;

namespace GoldenAxeEditor.Data
{
    /// <summary>
    /// Compression type enumeration
    /// </summary>
    public enum CompressionType : int
    {
        [Description("None")]
        None = 0,
        [Description("Phantasy Star RLE")]
        PhantasyStarRLE = 1,
        [Description("Zero Space")]
        ZeroSpace = 2
    }

    /// <summary>
    /// Describes the flip direction types
    /// </summary>
    public enum FlipDirectionType
    {
        Horizontal,
        Vertical
    }

    /// <summary>
    /// Describes different flip flag types
    /// </summary>
    public enum FlipType : byte
    {
        None = 0,
        Horizontal = 1,
        Vertical = 2,
        Both = 3
    }

    // Using enumerations as static data:

    /// <summary>
    /// Sprite enumeration
    /// </summary>
    public enum SpriteType
    {
        [Description("Title Screen")]
        [PaletteID(45056)]
        [TilesetID(65536)]
        [TilemapIDs(new int[] { 71055 })]
        TitleScreen = 0,
        [Description("Magic Select")]
        [PaletteID(45152)]
        [TilesetID(59640)]
        [TilemapIDs(new int[] { 62961 })]
        MagicSelect = 1,
        [Description("Magic Select Bars")]
        [PaletteID(45152)]
        [TilesetID(59640)]
        [TilemapIDs(new int[] { 63355 })]
        MagicSelectBars = 2,
        [Description("Map")]
        [PaletteID(45120)]
        [TilesetID(83699)]
        [TilemapIDs(new int[] { 90539 })]
        Map = 3,
        [Description("Stage 1")]
        [PaletteID(4044)]
        [TilesetID(51832)]
        [TilemapIDs(new int[] { 55800 })]
        Stage1 = 4,
        [Description("Stage 2")]
        [PaletteID(4076)]
        [TilesetID(172368)]
        [TilemapIDs(new int[] { 166992 })]
        Stage2 = 5,
        [Description("Stage 3")]
        [PaletteID(4108)]
        [TilesetID(207074)]
        [TilemapIDs(new int[] { 200930 })]
        Stage3 = 6,
        [Description("Stage 4")]
        [PaletteID(4140)]
        [TilesetID(183248)]
        [TilemapIDs(new int[] { 186352 })]
        Stage4 = 7,
        [Description("Stage 5")]
        [PaletteID(4172)]
        [TilesetID(223600)]
        [TilemapIDs(new int[] { 217456 })]
        Stage5 = 8,
        [Description("Ax Battler Walk")]
        [PaletteID(4044)]
        [TilesetID(98608)]
        [TilemapIDs(new int[] { 98310, 98348, 98386, 98424, 98462, 98500, 98538, 98576 })]
        AxBattlerWalk = 9,
        [Description("Ax Battler Walk Up")]
        [PaletteID(4044)]
        [TilesetID(104736)]
        [TilemapIDs(new int[] { 104438, 104476, 104514, 104552, 104590, 104628, 104666, 104704 })]
        AxBattlerWalkUp = 10,
        [Description("Ax Battler Idle")]
        [PaletteID(4044)]
        [TilesetID(110342)]
        [TilemapIDs(new int[] { 110246, 110297 })]
        AxBattlerIdle = 11,
        [Description("Ax Battler Magic")]
        [PaletteID(4044)]
        [TilesetID(112236)]
        [TilemapIDs(new int[] { 112140, 112186 })]
        AxBattlerMagic = 12,
        [Description("Ax Battler Attack Up")]
        [PaletteID(4044)]
        [TilesetID(114980)]
        [TilemapIDs(new int[] { 114694, 114742, 114780, 114840, 114888, 114926 })]
        AxBattlerAttackUp = 13,
        [Description("Ax Battler Throw")]
        [PaletteID(4044)]
        [TilesetID(120260)]
        [TilemapIDs(new int[] { 119978, 120020, 120068, 120122, 120164, 120212 })]
        AxBattlerThrow = 14,
        [Description("Ax Battler Run")]
        [PaletteID(4044)]
        [TilesetID(125424)]
        [TilemapIDs(new int[] { 125130, 125164, 125205, 125239, 125280, 125314, 125355, 125389 })]
        AxBattlerRun = 15,
        [Description("Ax Battler Jump Attack")]
        [PaletteID(4044)]
        [TilesetID(131480)]
        [TilemapIDs(new int[] { 131078, 131129, 131189, 131231, 131282, 131333, 131393, 131435 })]
        AxBattlerJumpAttack = 16,
        [Description("Ax Battler Damage")]
        [PaletteID(4044)]
        [TilesetID(138530)]
        [TilemapIDs(new int[] { 138142, 138183, 138217, 138248, 138303, 138339, 138380, 138414, 138445, 138500 })]
        AxBattlerDamage = 17,
        [Description("Ax Battler Camp")]
        [PaletteID(4044)]
        [TilesetID(146313)]
        [TilemapIDs(new int[] { 146248, 146274, 146289, 146304 })]
        AxBattlerCamp = 18,
        [Description("Ax Battler Kick")]
        [PaletteID(4044)]
        [TilesetID(147808)]
        [TilemapIDs(new int[] { 147462, 147503, 147551, 147638, 147679, 147727 })]
        AxBattlerKick = 19,
        [Description("Ax Battler Attack")]
        [PaletteID(4044)]
        [TilesetID(152744)]
        [TilemapIDs(new int[] { 152518, 152552, 152600, 152634, 152668, 152716 })]
        AxBattlerAttack = 20,
        [Description("Ax Battler Mount")]
        [PaletteID(4044)]
        [TilesetID(157424)]
        [TilemapIDs(new int[] { 157166, 157200, 157238, 157268, 157298, 157332, 157370, 157400  })]
        AxBattlerMount = 21,
        [Description("Ax Battler Tackle")]
        [PaletteID(4044)]
        [TilesetID(162224)]
        [TilemapIDs(new int[] { 162158, 162194 })]
        AxBattlerTackle = 22,
        [Description("Ax Battler Down Stab")]
        [PaletteID(4044)]
        [TilesetID(192578)]
        [TilemapIDs(new int[] { 192502, 192543 })]
        AxBattlerDownStab = 23,
        [Description("Earth Magic 1")]
        [PaletteID(4268)]
        [TilesetID(229514)]
        [TilemapIDs(new int[] { 229380, 229393, 229417, 229436, 229456, 229490 })]
        EarthMagic1 = 24,
        [Description("Earth Magic 2")]
        [PaletteID(4268)]
        [TilesetID(232872)]
        [TilemapIDs(new int[] { 232718, 232742, 232802 })]
        EarthMagic2 = 25,
        [Description("Earth Magic 3")]
        [PaletteID(4268)]
        [TilesetID(237456)]
        [TilemapIDs(new int[] { 236844, 237152 })]
        EarthMagic3 = 26,
        [Description("Thunder Magic 1")]
        [PaletteID(4292)]
        [TilesetID(245994)]
        [TilemapIDs(new int[] { 245764, 245816, 245868, 245875, 245888, 245904, 245920, 245933, 245940, 245953, 245969, 245985 })]
        ThunderMagic1 = 27,
        [Description("Thunder Magic 2")]
        [PaletteID(4292)]
        [TilesetID(248146)]
        [TilemapIDs(new int[] { 247982, 248066 })]
        ThunderMagic2 = 28,
        [Description("Thunder Magic 3")]
        [PaletteID(4292)]
        [TilesetID(250850)]
        [TilemapIDs(new int[] { 250550, 250602, 250654, 250754 })]
        ThunderMagic3 = 29,
        [Description("Fire Magic 1")]
        [PaletteID(4276)]
        [TilesetID(241530)]
        [TilemapIDs(new int[] { 241428, 241444, 241460, 241473, 241486, 241510 })]
        FireMagic1 = 30,
        [Description("Fire Magic 2")]
        [PaletteID(4276)]
        [TilesetID(253476)]
        [TilemapIDs(new int[] { 253254, 253328, 253402, 253441 })]
        FireMagic2 = 31,
        [Description("Fire Magic 3")]
        [PaletteID(4276)]
        [TilesetID(258200)]
        [TilemapIDs(new int[] { 257544, 257764, 257984 })]
        FireMagic3 = 32,
        [Description("Fire Magic 4")]
        [PaletteID(4284)]
        [TilesetID(263233)]
        [TilemapIDs(new int[] { 262148, 262284, 262480, 262750 })]
        FireMagic4 = 33,
        [Description("Fire Magic 5")]
        [PaletteID(4276)]
        [TilesetID(267473)]
        [TilemapIDs(new int[] { 267269 })]
        FireMagic5 = 34,
        [Description("Skeleton Walk Left")]
        [PaletteID(4044)]
        [TilesetID(278528)]
        [TilemapIDs(new int[] { 280294, 280335, 280376, 280417 })]
        SkeletonWalkLeft = 35,
        [Description("Skeleton Walk Right")]
        [PaletteID(4044)]
        [TilesetID(338464)]
        [TilemapIDs(new int[] { 340230, 340271, 340312, 340353 })]
        SkeletonWalkRight = 36,
        [Description("Skeleton Walk Up Left")]
        [PaletteID(4044)]
        [TilesetID(294912)]
        [TilemapIDs(new int[] { 296422, 296449, 296476, 296503 })]
        SkeletonWalkUpLeft = 37,
        [Description("Skeleton Walk Up Right")]
        [PaletteID(4044)]
        [TilesetID(296524)]
        [TilemapIDs(new int[] { 298034, 298061, 298088, 298115 })]
        SkeletonWalkUpRight = 38,
        [Description("Skeleton Attack Left")]
        [PaletteID(4044)]
        [TilesetID(280452)]
        [TilemapIDs(new int[] { 282282, 282312, 282367 })]
        SkeletonAttackLeft = 39,
        [Description("Skeleton Attack Right")]
        [PaletteID(4044)]
        [TilesetID(282427)]
        [TilemapIDs(new int[] { 284257, 284287, 284342 })]
        SkeletonAttackRight = 40,
        [Description("Skeleton Jump Attack Left")]
        [PaletteID(4044)]
        [TilesetID(284402)]
        [TilemapIDs(new int[] { 287480, 287518, 287560, 287601 })]
        SkeletonJumpAttackLeft = 41,
        [Description("Skeleton Jump Attack Right")]
        [PaletteID(4044)]
        [TilesetID(287631)]
        [TilemapIDs(new int[] { 290709, 290747, 290789, 290830 })]
        SkeletonJumpAttackRight = 42,
        [Description("Skeleton Thrown Left")]
        [PaletteID(4044)]
        [TilesetID(290860)]
        [TilemapIDs(new int[] { 292754, 292784, 292825 })]
        SkeletonThrownLeft = 43,
        [Description("Skeleton Thrown Right")]
        [PaletteID(4044)]
        [TilesetID(292881)]
        [TilemapIDs(new int[] { 294775, 294805, 294846 })]
        SkeletonThrownRight = 44,
        [Description("Skeleton Damage Left")]
        [PaletteID(4044)]
        [TilesetID(298136)]
        [TilemapIDs(new int[] { 301662, 301703, 301733, 301767, 301808 })]
        SkeletonDamageLeft = 45,
        [Description("Skeleton Damage Right")]
        [PaletteID(4044)]
        [TilesetID(301863)]
        [TilemapIDs(new int[] { 305389, 305430, 305460, 305494, 305535 })]
        SkeletonDamageRight = 46,
        [Description("Bad Bros. Walk Left")]
        [PaletteID(4044)]
        [TilesetID(311296)]
        [TilemapIDs(new int[] { 314086, 314146, 314206, 314266 })]
        BadBrosWalkLeft = 47,
        [Description("Bad Bros. Walk Right")]
        [PaletteID(4044)]
        [TilesetID(314320)]
        [TilemapIDs(new int[] { 317110, 317170, 317230, 317290 })]
        BadBrosWalkRight = 48,
        [Description("Bad Bros. Walk Up Left")]
        [PaletteID(4044)]
        [TilesetID(327680)]
        [TilemapIDs(new int[] { 330630, 330690, 330750, 330810 })]
        BadBrosWalkUpLeft = 49,
        [Description("Bad Bros. Walk Up Right")]
        [PaletteID(4044)]
        [TilesetID(330864)]
        [TilemapIDs(new int[] { 333814, 333874, 333934, 333994 })]
        BadBrosWalkUpRight = 50,
        [Description("Bad Bros. Attack Left")]
        [PaletteID(4044)]
        [TilesetID(317344)]
        [TilemapIDs(new int[] { 320294, 320360, 320438 })]
        BadBrosAttackLeft = 51,
        [Description("Bad Bros. Attack Right")]
        [PaletteID(4044)]
        [TilesetID(320510)]
        [TilemapIDs(new int[] { 323460, 323526, 323604 })]
        BadBrosAttackRight = 52,
        [Description("Bad Bros. Tackle Left")]
        [PaletteID(4044)]
        [TilesetID(323676)]
        [TilemapIDs(new int[] { 324994 })]
        BadBrosTackleLeft = 53,
        [Description("Bad Bros. Tackle Right")]
        [PaletteID(4044)]
        [TilesetID(307225)]
        [TilemapIDs(new int[] { 308543 })]
        BadBrosTackleRight = 54,
        [Description("Bad Bros. Damage Left")]
        [PaletteID(4044)]
        [TilesetID(519828)]
        [TilemapIDs(new int[] { 524026, 524080, 524142, 524204 })]
        BadBrosDamageLeft = 55,
        [Description("Bad Bros. Damage Right")]
        [PaletteID(4044)]
        [TilesetID(334048)]
        [TilemapIDs(new int[] { 338246, 338300, 338362, 338424 })]
        BadBrosDamageRight = 56,
        [Description("Dwarf Walk Left")]
        [PaletteID(4044)]
        [TilesetID(325050)]
        [TilemapIDs(new int[] { 326144, 326159, 326174, 326189, 326204, 326219 })]
        DwarfWalkLeft = 57,
        [Description("Dwarf Walk Right")]
        [PaletteID(4044)]
        [TilesetID(326228)]
        [TilemapIDs(new int[] { 327322, 327337, 327352, 327367, 327382, 327397 })]
        DwarfWalkRight = 58,
        [Description("Dwarf Damage Left")]
        [PaletteID(4044)]
        [TilesetID(374740)]
        [TilemapIDs(new int[] { 375354, 375372 })]
        DwarfDamageLeft = 59,
        [Description("Dwarf Damage Right")]
        [PaletteID(4044)]
        [TilesetID(375384)]
        [TilemapIDs(new int[] { 375998, 376016 })]
        DwarfDamageRight = 60,
        [Description("Meat")]
        [PaletteID(4044)]
        [TilesetID(327406)]
        [TilemapIDs(new int[] { 327604 })]
        Meat = 61,
        [Description("Potion")]
        [PaletteID(4044)]
        [TilesetID(327470)]
        [TilemapIDs(new int[] { 327612 })]
        Potion = 62,
        [Description("Lt. Bitter Walk Left")]
        [PaletteID(4044)]
        [TilesetID(344064)]
        [TilemapIDs(new int[] { 346310, 346366, 346422, 346478 })]
        LtBitterWalkLeft = 63,
        [Description("Lt. Bitter Walk Right")]
        [PaletteID(4044)]
        [TilesetID(360448)]
        [TilemapIDs(new int[] { 362694, 362750, 362806, 362862 })]
        LtBitterWalkRight = 64,
        [Description("Lt. Bitter Walk Up Left")]
        [PaletteID(4044)]
        [TilesetID(346528)]
        [TilemapIDs(new int[] { 348934, 348980, 349026, 349072 })]
        LtBitterWalkUpLeft = 65,
        [Description("Lt. Bitter Walk Up Right")]
        [PaletteID(4044)]
        [TilesetID(362912)]
        [TilemapIDs(new int[] { 365318, 365364, 365410, 365456 })]
        LtBitterWalkUpRight = 66,
        [Description("Lt. Bitter Attack Left")]
        [PaletteID(4044)]
        [TilesetID(365496)]
        [TilemapIDs(new int[] { 369822, 369876, 369962, 370008, 370070 })]
        LtBitterAttackLeft = 67,
        [Description("Lt. Bitter Attack Right")]
        [PaletteID(4044)]
        [TilesetID(370118)]
        [TilemapIDs(new int[] { 374444, 374498, 374584, 374630, 374692 })]
        LtBitterAttackRight = 68,
        [Description("Lt. Bitter Damage Left")]
        [PaletteID(4044)]
        [TilesetID(349112)]
        [TilemapIDs(new int[] { 353022, 353068, 353122, 353170 })]
        LtBitterDamageLeft = 69,
        [Description("Lt. Bitter Damage Right")]
        [PaletteID(4044)]
        [TilesetID(353198)]
        [TilemapIDs(new int[] { 357108, 357154, 357208, 357256 })]
        LtBitterDamageRight = 70,
        [Description("Death Adder Walk Left")]
        [PaletteID(4044)]
        [TilesetID(376832)]
        [TilemapIDs(new int[] { 380326, 380392, 380458, 380524 })]
        DeathAdderWalkLeft = 71,
        [Description("Death Adder Walk Right")]
        [PaletteID(4044)]
        [TilesetID(380584)]
        [TilemapIDs(new int[] { 384078, 384144, 384210, 384276 })]
        DeathAdderWalkRight = 72,
        [Description("Death Adder Walk Up Left")]
        [PaletteID(4044)]
        [TilesetID(393216)]
        [TilemapIDs(new int[] { 396294, 396360, 396426, 396492 })]
        DeathAdderWalkUpLeft = 73,
        [Description("Death Adder Walk Up Right")]
        [PaletteID(4044)]
        [TilesetID(396552)]
        [TilemapIDs(new int[] { 399630, 399696, 399762, 399828 })]
        DeathAdderWalkUpRight = 74,
        [Description("Death Adder Attack Left")]
        [PaletteID(4044)]
        [TilesetID(384336)]
        [TilemapIDs(new int[] { 388374, 388440, 388546 })]
        DeathAdderAttackLeft = 75,
        [Description("Death Adder Attack Right")]
        [PaletteID(4044)]
        [TilesetID(388627)]
        [TilemapIDs(new int[] { 392665, 392731, 392837 })]
        DeathAdderAttackRight = 76,
        [Description("Death Adder Punch Left")]
        [PaletteID(4044)]
        [TilesetID(409600)]
        [TilemapIDs(new int[] { 412166, 412235 })]
        DeathAdderPunchLeft = 77,
        [Description("Death Adder Punch Right")]
        [PaletteID(4044)]
        [TilesetID(412291)]
        [TilemapIDs(new int[] { 414857, 414926 })]
        DeathAdderPunchRight = 78,
        [Description("Death Adder Damage Left")]
        [PaletteID(4044)]
        [TilesetID(399888)]
        [TilemapIDs(new int[] { 404342, 404429, 404507 })]
        DeathAdderDamageLeft = 79,
        [Description("Death Adder Damage Right")]
        [PaletteID(4044)]
        [TilesetID(404567)]
        [TilemapIDs(new int[] { 409021, 409108, 409186 })]
        DeathAdderDamageRight = 80,
        [Description("Dragon Walk Left")]
        [PaletteID(4044)]
        [TilesetID(414982)]
        [TilemapIDs(new int[] { 419596, 419698, 419800, 419902, 420004, 420101, 420203 })]
        DragonWalkLeft = 81,
        [Description("Dragon Walk Right")]
        [PaletteID(4044)]
        [TilesetID(420275)]
        [TilemapIDs(new int[] { 424889, 424991, 425093, 425195, 425297, 425394, 425496 })]
        DragonWalkRight = 82,
        [Description("Dragon Jump Left")]
        [PaletteID(4044)]
        [TilesetID(425984)]
        [TilemapIDs(new int[] { 428134, 428250 })]
        DragonJumpLeft = 83,
        [Description("Dragon Jump Right")]
        [PaletteID(4044)]
        [TilesetID(428350)]
        [TilemapIDs(new int[] { 430500, 430616 })]
        DragonJumpRight = 84,
        [Description("Dragon Damage Left")]
        [PaletteID(4044)]
        [TilesetID(430716)]
        [TilemapIDs(new int[] { 433058, 433164 })]
        DragonDamageLeft = 85,
        [Description("Dragon Damage Right")]
        [PaletteID(4044)]
        [TilesetID(433200)]
        [TilemapIDs(new int[] { 435542, 435648 })]
        DragonDamageRight = 86,
        [Description("Dragon Flame Left")]
        [PaletteID(4044)]
        [TilesetID(305590)]
        [TilemapIDs(new int[] { 307132, 307147, 307189 })]
        DragonFlameLeft = 87,
        [Description("Dragon Flame Right")]
        [PaletteID(4044)]
        [TilesetID(435684)]
        [TilemapIDs(new int[] { 437226, 437241, 437283 })]
        DragonFlameRight = 88,
        [Description("Dragon Fireball Left")]
        [PaletteID(4044)]
        [TilesetID(425568)]
        [TilemapIDs(new int[] { 425958, 425970 })]
        DragonFireballLeft = 89,
        [Description("Dragon Fireball Right")]
        [PaletteID(4044)]
        [TilesetID(357284)]
        [TilemapIDs(new int[] { 357674, 357686 })]
        DragonFireballRight = 90,
        [Description("Chicken Leg Walk Left")]
        [PaletteID(4044)]
        [TilesetID(437319)]
        [TilemapIDs(new int[] { 439309, 439355, 439401, 439447 })]
        ChickenLegWalkLeft = 91,
        [Description("Chicken Leg Walk Right")]
        [PaletteID(4044)]
        [TilesetID(442368)]
        [TilemapIDs(new int[] { 444358, 444404, 444450, 444496 })]
        ChickenLegWalkRight = 92,
        [Description("Chicken Leg Attack Left")]
        [PaletteID(4044)]
        [TilesetID(439487)]
        [TilemapIDs(new int[] { 441445, 441486 })]
        ChickenLegAttackLeft = 93,
        [Description("Chicken Leg Attack Right")]
        [PaletteID(4044)]
        [TilesetID(458752)]
        [TilemapIDs(new int[] { 460710, 460751 })]
        ChickenLegAttackRight = 94,
        [Description("Chicken Leg Jump Left")]
        [PaletteID(4044)]
        [TilesetID(444536)]
        [TilemapIDs(new int[] { 446846, 446908 })]
        ChickenLegJumpLeft = 95,
        [Description("Chicken Leg Jump Right")]
        [PaletteID(4044)]
        [TilesetID(446964)]
        [TilemapIDs(new int[] { 449274, 449336 })]
        ChickenLegJumpRight = 96,
        [Description("Chicken Leg Damage Left")]
        [PaletteID(4044)]
        [TilesetID(441536)]
        [TilemapIDs(new int[] { 442310 })]
        ChcickenLegDamageLeft = 97,
        [Description("Chicken Leg Damage Right")]
        [PaletteID(4044)]
        [TilesetID(449392)]
        [TilemapIDs(new int[] { 450166 })]
        ChcickenLegDamageRight = 98,
        [Description("Long Moan Walk Left")]
        [PaletteID(4044)]
        [TilesetID(460801)]
        [TilemapIDs(new int[] { 462663, 462697, 462731, 462765 })]
        LongMoanWalkLeft = 99,
        [Description("Long Moan Walk Right")]
        [PaletteID(4044)]
        [TilesetID(462793)]
        [TilemapIDs(new int[] { 464655, 464689, 464723, 464757 })]
        LongMoanWalkRight = 100,
        [Description("Long Moan Walk Up Left")]
        [PaletteID(4044)]
        [TilesetID(450194)]
        [TilemapIDs(new int[] { 452088, 452122, 452156, 452190 })]
        LongMoanWalkUpLeft = 101,
        [Description("Long Moan Walk Up Right")]
        [PaletteID(4044)]
        [TilesetID(464785)]
        [TilemapIDs(new int[] { 466679, 466713, 466747, 466781 })]
        LongMoanWalkUpRight = 102,
        [Description("Long Moan Attack Left")]
        [PaletteID(4044)]
        [TilesetID(466809)]
        [TilemapIDs(new int[] { 468639, 468675, 468737 })]
        LongMoanAttackLeft = 103,
        [Description("Long Moan Attack Right")]
        [PaletteID(4044)]
        [TilesetID(468782)]
        [TilemapIDs(new int[] { 470612, 470648, 470710 })]
        LongMoanAttackRight = 104,
        [Description("Long Moan Thrown Left")]
        [PaletteID(4044)]
        [TilesetID(470755)]
        [TilemapIDs(new int[] { 472809, 472839, 472869 })]
        LongMoanThrownLeft = 105,
        [Description("Long Moan Thrown Right")]
        [PaletteID(4044)]
        [TilesetID(472911)]
        [TilemapIDs(new int[] { 474965, 474995, 475025 })]
        LongMoanThrownRight = 106,
        [Description("Long Moan Damage Left")]
        [PaletteID(4044)]
        [TilesetID(452218)]
        [TilemapIDs(new int[] { 455296, 455330, 455371, 455412 })]
        LongMoanDamageLeft = 107,
        [Description("Long Moan Damage Right")]
        [PaletteID(4044)]
        [TilesetID(455440)]
        [TilemapIDs(new int[] { 458518, 458552, 458593, 458634 })]
        LongMoanDamageRight = 108,
        [Description("Zuburoka Walk Left")]
        [PaletteID(4044)]
        [TilesetID(475136)]
        [TilemapIDs(new int[] { 476966, 476996, 477026, 477056 })]
        ZuburokaWalkLeft = 109,
        [Description("Zuburoka Walk Right")]
        [PaletteID(4044)]
        [TilesetID(491520)]
        [TilemapIDs(new int[] { 493350, 493380, 493410, 493440 })]
        ZuburokaWalkRight = 110,
        [Description("Zuburoka Walk Up Left")]
        [PaletteID(4044)]
        [TilesetID(493464)]
        [TilemapIDs(new int[] { 495294, 495324, 495354, 495384 })]
        ZuburokaWalkUpLeft = 111,
        [Description("Zuburoka Walk Up Right")]
        [PaletteID(4044)]
        [TilesetID(495408)]
        [TilemapIDs(new int[] { 497238, 497268, 497298, 497328 })]
        ZuburokaWalkUpRight = 112,
        [Description("Zuburoka Attack Left")]
        [PaletteID(4044)]
        [TilesetID(477080)]
        [TilemapIDs(new int[] { 478846, 478894, 478963 })]
        ZuburokaAttackLeft = 113,
        [Description("Zuburoka Attack Right")]
        [PaletteID(4044)]
        [TilesetID(497352)]
        [TilemapIDs(new int[] { 499118, 499166, 499235 })]
        ZuburokaAttackRight = 114,
        [Description("Zuburoka Thrown Left")]
        [PaletteID(4044)]
        [TilesetID(484599)]
        [TilemapIDs(new int[] { 486653, 486691, 486737 })]
        ZuburokaThrownLeft = 115,
        [Description("Zuburoka Thrown Right")]
        [PaletteID(4044)]
        [TilesetID(499265)]
        [TilemapIDs(new int[] { 501319, 501357, 501403 })]
        ZuburokaThrownRight = 116,
        [Description("Zuburoka Damage Left")]
        [PaletteID(4044)]
        [TilesetID(478993)]
        [TilemapIDs(new int[] { 481655, 481689, 481727, 481775 })]
        ZuburokaDamageLeft = 117,
        [Description("Zuburoka Damage Right")]
        [PaletteID(4044)]
        [TilesetID(481796)]
        [TilemapIDs(new int[] { 484458, 484492, 484530, 484578 })]
        ZuburokaDamageRight = 118,
        [Description("Zuburoka Mount Left")]
        [PaletteID(4044)]
        [TilesetID(486765)]
        [TilemapIDs(new int[] { 488979, 489006, 489040, 489070 })]
        ZuburokaMountLeft = 119,
        [Description("Zuburoka Mount Right")]
        [PaletteID(4044)]
        [TilesetID(489091)]
        [TilemapIDs(new int[] { 491305, 491332, 491366, 491396 })]
        ZuburokaMountRight = 120,
        [Description("Heninger Walk Left")]
        [PaletteID(4044)]
        [TilesetID(507904)]
        [TilemapIDs(new int[] { 509606, 509647, 509688, 509729 })]
        HeningerWalkLeft = 121,
        [Description("Heninger Walk Right")]
        [PaletteID(4044)]
        [TilesetID(509764)]
        [TilemapIDs(new int[] { 511466, 511507, 511548, 511589 })]
        HeningerWalkRight = 122,
        [Description("Heninger Walk Up Left")]
        [PaletteID(4044)]
        [TilesetID(501431)]
        [TilemapIDs(new int[] { 502941, 502968, 502995, 503022 })]
        HeningerWalkUpLeft = 123,
        [Description("Heninger Walk Up Right")]
        [PaletteID(4044)]
        [TilesetID(503043)]
        [TilemapIDs(new int[] { 504553, 504580, 504607, 504634 })]
        HeningerWalkUpRight = 124,
        [Description("Heninger Attack Left")]
        [PaletteID(4044)]
        [TilesetID(511624)]
        [TilemapIDs(new int[] { 513486, 513532, 513580 })]
        HeningerAttackLeft = 125,
        [Description("Heninger Attack Right")]
        [PaletteID(4044)]
        [TilesetID(513604)]
        [TilemapIDs(new int[] { 515466, 515512, 515560 })]
        HeningerAttackRight = 126,
        [Description("Heninger Thrown Left")]
        [PaletteID(4044)]
        [TilesetID(357692)]
        [TilemapIDs(new int[] { 359010, 359040 })]
        HeningerThrownLeft = 127,
        [Description("Heninger Thrown Right")]
        [PaletteID(4044)]
        [TilesetID(359068)]
        [TilemapIDs(new int[] { 360386, 360416 })]
        HeningerThrownRight = 128,
        [Description("Heninger Damage Left")]
        [PaletteID(4044)]
        [TilesetID(504655)]
        [TilemapIDs(new int[] { 507637, 507673, 507719, 507761 })]
        HeningerDamageLeft = 129,
        [Description("Heninger Damage Right")]
        [PaletteID(4044)]
        [TilesetID(340388)]
        [TilemapIDs(new int[] { 343370, 343406, 343452, 343494 })]
        HeningerDamageRight = 130,
        [Description("Heninger Jump Attack Left")]
        [PaletteID(4044)]
        [TilesetID(515584)]
        [TilemapIDs(new int[] { 517606, 517632, 517670 })]
        HeningerJumpAttackLeft = 131,
        [Description("Heninger Jump Attack Right")]
        [PaletteID(4044)]
        [TilesetID(517706)]
        [TilemapIDs(new int[] { 519728, 519754, 519792 })]
        HeningerJumpAttackRight = 132,
        [Description("Explosion")]
        [PaletteID(4044)]
        [TilesetID(308599)]
        [TilemapIDs(new int[] { 311165, 311191, 311217 })]
        Explosion = 133,
        [Description("HUD")]
        [PaletteID(4044)]
        [TilesetID(79574)]
        [TilemapIDs(new int[] { -1 })]
        [PaletteIndex(1)]
        HUD = 134,
        [Description("Font")]
        [PaletteID(4044)]
        [TilesetID(83138)]
        [TilemapIDs(new int[] { -2 })]
        [PaletteIndex(1)]
        Font = 135,
        [Description("End Screen 1")]
        [PaletteID(45184)]
        [TilesetID(91067)]
        [TilemapIDs(new int[] { 78918 })]
        EndScreen1 = 136,
        [Description("End Screen 2")]
        [PaletteID(45184)]
        [TilesetID(91067)]
        [TilemapIDs(new int[] { 78631 })]
        EndScreen2 = 137,
        [Description("End Screen 3")]
        [PaletteID(45184)]
        [TilesetID(71894)]
        [TilemapIDs(new int[] { 77571 })]
        EndScreen3 = 138,
        [Description("Score Screen")]
        [PaletteID(45088)]
        [TilesetID(176080)]
        [TilemapIDs(new int[] { 177147 })]
        [PaletteIndex(0)]
        ScoreScreen = 139
    }

    /// <summary>
    /// Palette enumeration (value(ID) = byte location in ROM)
    /// </summary>
    public enum PaletteType
    {
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        PaletteFCC = 4044,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        PaletteFEC = 4076,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        Palette100C = 4108,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        Palette102C = 4140,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        Palette104C = 4172,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        Palette106C = 4204,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        Palette108C = 4236,
        [Length(8)]
        [Offset(8)]
        [OffsetID(0)]
        Palette10AC = 4268,
        [Length(8)]
        [Offset(8)]
        [OffsetID(0)]
        Palette10B4 = 4276,
        [Length(8)]
        [Offset(8)]
        [OffsetID(4044)]
        Palette10BC = 4284,
        [Length(8)]
        [Offset(8)]
        [OffsetID(0)]
        Palette10C4 = 4292,
        [Length(8)]
        [Offset(0)]
        [OffsetID(0)]
        Palette1382 = 4994,
        [Length(6)]
        [Offset(0)]
        [OffsetID(0)]
        Palette2BC1 = 11201,
        [Length(6)]
        [Offset(0)]
        [OffsetID(0)]
        Palette2BC7 = 11207,
        [Length(8)]
        [Offset(0)]
        [OffsetID(0)]
        Palette2BCD = 11213,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        PaletteB000 = 45056,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        PaletteB020 = 45088,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        PaletteB040 = 45120,
        [Length(8)]
        [Offset(0)]
        [OffsetID(0)]
        PaletteB060 = 45152,
        [Length(32)]
        [Offset(0)]
        [OffsetID(0)]
        PaletteB080 = 45184,
    }

    /// <summary>
    /// Tilemap enumeration (value(ID) = byte location in ROM)
    /// </summary>
    public enum TilemapType
    {
        // Stage 1
        [Compression(CompressionType.None)]
        [Columns(160)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        TilemapD9F8 = 55800,
        // Magic Select
        [Length(394)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Columns(32)]
        [Rows(24)]
        [Offset(0)]
        [UseFlags(true)]
        TilemapF5F1 = 62961,
        // Magic Select Bars
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(6)]
        [Offset(0)]
        [UseFlags(false)]
        TilemapF77B = 63355,
        // HUD
        [Compression(CompressionType.None)]
        [Columns(16)]
        [Rows(4)]
        [Offset(0)]
        [UseFlags(false)]
        TilemapHUD = -1,
        // Font
        [Compression(CompressionType.None)]
        [Columns(16)]
        [Rows(3)]
        [Offset(16)]
        [UseFlags(false)]
        TilemapFont = -2,
        // Title Screen
        [Length(456)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Columns(32)]
        [Rows(24)]
        [Offset(0)]
        [UseFlags(true)]
        Tilemap1158F = 71055,
        // End Screen 3
        [Length(278)]
        [Compression(CompressionType.ZeroSpace)]
        [Columns(16)]
        [Rows(24)]
        [Offset(0)]
        [UseFlags(false)]
        Tilemap12F03 = 77571,
        // End Screen 2
        [Length(278)]
        [Compression(CompressionType.ZeroSpace)]
        [Columns(16)]
        [Rows(20)]
        [Offset(0)]
        [UseFlags(false)]
        Tilemap13327 = 78631,
        // End Screen 1
        [Length(229)]
        [Compression(CompressionType.ZeroSpace)]
        [Columns(16)]
        [Rows(16)]
        [Offset(0)]
        [UseFlags(false)]
        Tilemap13446 = 78918,
        // Map
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(22)]
        [Offset(0)]
        [UseFlags(true)]
        Tilemap161AB = 90539,
        // Stage 2
        [Compression(CompressionType.None)]
        [Columns(128)]
        [Rows(42)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap28C50 = 166992,
        // Score Screen
        [Compression(CompressionType.None)]
        [Columns(11)]
        [Rows(20)]
        [UseFlags(false)]
        [Offset(44)]
        Tilemap283FB = 177147,
        // Stage 3
        [Compression(CompressionType.None)]
        [Columns(128)]
        [Rows(48)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap310E2 = 200930,
        // Stage 4
        [Compression(CompressionType.None)]
        [Columns(128)]
        [Rows(48)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap2D7F0 = 186352,
        // Stage 5
        [Compression(CompressionType.None)]
        [Columns(128)]
        [Rows(48)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap35170 = 217456,
        // Ax Battler Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap18006 = 98310,
        // Ax Battler Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap18026 = 98348,
        // Ax Battler Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap18052 = 98386,
        // Ax Battler Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap18078 = 98424,
        // Ax Battler Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1809E = 98462,
        // Ax Battler Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap180C4 = 98500,
        // Ax Battler Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap180EA = 98538,
        // Ax Battler Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap18110 = 98576,
        // Ax Battler Idle Left
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1AEA6 = 110246,
        // Ax Battler Idle Right
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1AED9 = 110297,
        // Ax Battler Walking Up Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap197F6 = 104438,
        // Ax Battler Walking Up Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1981C = 104476,
        // Ax Battler Walking Up Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap19842 = 104514,
        // Ax Battler Walking Up Left 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap19868 = 104552,
        // Ax Battler Walking Up Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1988E = 104590,
        // Ax Battler Walking Up Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap198B4 = 104628,
        // Ax Battler Walking Up Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap198DA = 104666,
        // Ax Battler Walking Up Right 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap19900 = 104704,
        // Ax Battler Magic 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1B60C = 112140,
        // Ax Battler Magic 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1B63A = 112186,
        // Ax Battler Attack Up Left 1
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1C006 = 114694,
        // Ax Battler Attack Up Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1C036 = 114742,
        // Ax Battler Attack Up Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1C05C = 114780,
        // Ax Battler Attack Up Right 1
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1C098 = 114840,
        // Ax Battler Attack Up Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1C0C8 = 114888,
        // Ax Battler Attack Up Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1C0EE = 114926,
        // Ax Battler Throw Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1D4AA = 119978,
        // Ax Battler Throw Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1D4D4 = 120020,
        // Ax Battler Throw Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1D504 = 120068,
        // Ax Battler Throw Right 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1D53A = 120122,
        // Ax Battler Throw Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1D564 = 120164,
        // Ax Battler Throw Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1D594 = 120212,
        // Ax Battler Run Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1E8CA = 125130,
        // Ax Battler Run Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1E8EC = 125164,
        // Ax Battler Run Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1E915 = 125205,
        // Ax Battler Run Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1E937 = 125239,
        // Ax Battler Run Right 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1E960 = 125280,
        // Ax Battler Run Right 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1E982 = 125314,
        // Ax Battler Run Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1E9AB = 125355,
        // Ax Battler Run Right 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap1E9CD = 125389,
        // Ax Battler Jump Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap20006 = 131078,
        // Ax Battler Jump Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap20039 = 131129,
        // Ax Battler Jump Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap20075 = 131189,
        // Ax Battler Jump Attack Left 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2009F = 131231,
        // Ax Battler Jump Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap200D2 = 131282,
        // Ax Battler Jump Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap20105 = 131333,
        // Ax Battler Jump Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap20141 = 131393,
        // Ax Battler Jump Attack Right 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2016B = 131435,
        // Ax Battler Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21B9E = 138142,
        // Ax Battler Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21BC7 = 138183,
        // Ax Battler Damage Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21BE9 = 138217,
        // Ax Battler Damage Left 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21C08 = 138248,
        // Ax Battler Damage Left 5
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21C3F = 138303,
        // Ax Battler Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21C63 = 138339,
        // Ax Battler Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21C8C = 138380,
        // Ax Battler Damage Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21CAE = 138414,
        // Ax Battler Damage Right 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21CCD = 138445,
        // Ax Battler Damage Right 5
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap21D04 = 138500,
        // Ax Battler Camp
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap23B48 = 146248,
        // Camp Fire 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap23B62 = 146274,
        // Camp Fire 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap23B71 = 146289,
        // Camp Fire 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap23B80 = 146304,
        // Ax Battler Kick Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap24006 = 147462,
        // Ax Battler Kick Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2402F = 147503,
        // Ax Battler Kick Left 3
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2405F = 147551,
        // Ax Battler Kick Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap240B6 = 147638,
        // Ax Battler Kick Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap240DF = 147679,
        // Ax Battler Kick Right 3
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2410F = 147727,
        // Ax Battler Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap253C6 = 152518,
        // Ax Battler Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap253E8 = 152552,
        // Ax Battler Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap25418 = 152600,
        // Ax Battler Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2543A = 152634,
        // Ax Battler Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2545C = 152668,
        // Ax Battler Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2548C = 152716,
        // Ax Battler Mount Left
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap265EE = 157166,
        // Ax Battler Mount Jump Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap26610 = 157200,
        // Ax Battler Mount Jump Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap26636 = 157238,
        // Ax Battler Mount Left Up
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap26654 = 157268,
        // Ax Battler Mount Right
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap26672 = 157298,
        // Ax Battler Mount Jump Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap26694 = 157332,
        // Ax Battler Mount Jump Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap266BA = 157370,
        // Ax Battler Mount Right Up
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap266D8 = 157400,
        // Ax Battler Tackle Left
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2796E = 162158,
        // Ax Battler Tackle Right
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap27992 = 162194,
        // Ax Battler Down Stab Left
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2EFF6 = 192502,
        // Ax Battler Down Stab Right
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap2F01F = 192543,
        // Earth Magic 1 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap38004 = 229380,
        // Earth Magic 1 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap38011 = 229393,
        // Earth Magic 1 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap38029 = 229417,
        // Earth Magic 1 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3803C = 229436,
        // Earth Magic 1 5
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap38050 = 229456,
        // Earth Magic 1 6
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap38072 = 229490,
        // Earth Magic 2 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap38D0E = 232718,
        // Earth Magic 2 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap38D26 = 232742,
        // Earth Magic 2 3
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap38D62 = 232802,
        // Earth Magic 3 1
        [Compression(CompressionType.None)]
        [Columns(16)]
        [Rows(19)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap39D2C = 236844,
        // Earth Magic 3 2
        [Compression(CompressionType.None)]
        [Columns(16)]
        [Rows(19)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap39E60 = 237152,
        // Fire Magic 1 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3AF14 = 241428,
        // Fire Magic 1 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3AF24 = 241444,
        // Fire Magic 1 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3AF34 = 241460,
        // Fire Magic 1 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3AF41 = 241473,
        // Fire Magic 1 5
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3AF4E = 241486,
        // Fire Magic 1 6
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3AF66 = 241510,
        // Thunder Magic 1 1
        [Compression(CompressionType.None)]
        [Columns(2)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C004 = 245764,
        // Thunder Magic 1 2
        [Compression(CompressionType.None)]
        [Columns(2)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C038 = 245816,
        // Thunder Magic 1 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(1)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C06C = 245868,
        // Thunder Magic 1 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C073 = 245875,
        // Thunder Magic 1 5
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C080 = 245888,
        // Thunder Magic 1 6
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C090 = 245904,
        // Thunder Magic 1 7
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C0A0 = 245920,
        // Thunder Magic 1 8
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(1)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C0AD = 245933,
        // Thunder Magic 1 9
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C0B4 = 245940,
        // Thunder Magic 1 10
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C0C1 = 245953,
        // Thunder Magic 1 11
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C0D1 = 245969,
        // Thunder Magic 1 12
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C0E1 = 245985,
        // Thunder Magic 2 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(20)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C8AE = 247982,
        // Thunder Magic 2 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(20)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3C902 = 248066,
        // Thunder Magic 3 1
        [Compression(CompressionType.None)]
        [Columns(2)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3D2B6 = 250550,
        // Thunder Magic 3 2
        [Compression(CompressionType.None)]
        [Columns(2)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3D2EA = 250602,
        // Thunder Magic 3 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3D31E = 250654,
        // Thunder Magic 3 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3D382 = 250754,
        // Fire Magic 2 1
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3DD46 = 253254,
        // Fire Magic 2 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3DD90 = 253328,
        // Fire Magic 2 3
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3DDDA = 253402,
        // Fire Magic 2 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3DE01 = 253441,
        // Fire Magic 3 1
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3EE08 = 257544,
        // Fire Magic 3 2
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3EEE4 = 257764,
        // Fire Magic 3 3
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(24)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap3EFC0 = 257984,
        // Magic 4 1
        [Compression(CompressionType.None)]
        [Columns(11)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap40004 = 262148,
        // Magic 4 2
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(16)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap4008C = 262284,
        // Magic 4 3
        [Compression(CompressionType.None)]
        [Columns(14)]
        [Rows(19)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap40150 = 262480,
        // Magic 4 4
        [Compression(CompressionType.None)]
        [Columns(21)]
        [Rows(23)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap4025E = 262750,
        // Magic 5
        [Compression(CompressionType.None)]
        [Columns(17)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(128)]
        Tilemap41405 = 267269,
        // Skeleton Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap446E6 = 280294,
        // Skeleton Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4470F = 280335,
        // Skeleton Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap44738 = 280376,
        // Skeleton Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap44761 = 280417,
        // Skeleton Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap44EAA = 282282,
        // Skeleton Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap44EC8 = 282312,
        // Skeleton Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap44EFF = 282367,
        // Skeleton Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap45661 = 284257,
        // Skeleton Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4567F = 284287,
        // Skeleton Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap456B6 = 284342,
        // Skeleton Jump Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap462F8 = 287480,
        // Skeleton Jump Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4631E = 287518,
        // Skeleton Jump Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap46348 = 287560,
        // Skeleton Jump Attack Left 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap46371 = 287601,
        // Skeleton Jump Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap46F95 = 290709,
        // Skeleton Jump Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap46FBB = 290747,
        // Skeleton Jump Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap46FE5 = 290789,
        // Skeleton Jump Attack Right 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4700E = 290830,
        // Skeleton Thrown Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap47792 = 292754,
        // Skeleton Thrown Left 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap477B0 = 292784,
        // Skeleton Thrown Left 3
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap477D9 = 292825,
        // Skeleton Thrown Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap47F77 = 294775,
        // Skeleton Thrown Right 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap47F95 = 294805,
        // Skeleton Thrown Right 3
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap477FBE = 294846,
        // Skeleton Walk Up Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap485E6 = 296422,
        // Skeleton Walk Up Left 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap48601 = 296449,
        // Skeleton Walk Up Left 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4861C = 296476,
        // Skeleton Walk Up Left 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap48637 = 296503,
        // Skeleton Walk Up Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap48C32 = 298034,
        // Skeleton Walk Up Left 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap48C4D = 298061,
        // Skeleton Walk Up Left 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap48C68 = 298088,
        // Skeleton Walk Up Left 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap48C83 = 298115,
        // Skeleton Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap49A5E = 301662,
        // Skeleton Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap49A87 = 301703,
        // Skeleton Damage Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap49AA5 = 301733,
        // Skeleton Damage Left 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap49AC7 = 301767,
        // Skeleton Damage Left 5
        [Compression(CompressionType.None)]
        [Columns(11)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap49AF0 = 301808,
        // Skeleton Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4A8ED = 305389,
        // Skeleton Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4A916 = 305430,
        // Skeleton Damage Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4A934 = 305460,
        // Skeleton Damage Right 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4A956 = 305494,
        // Skeleton Damage Right 5
        [Compression(CompressionType.None)]
        [Columns(11)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4A97F = 305535,
        // Dragon Flame Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4AFBC = 307132,
        // Dragon Flame Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4AFCB = 307147,
        // Dragon Flame Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4AFF5 = 307189,
        // Bad Bros. Tackle Right
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4B53F = 308543,
        // Explosion 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4BF7D = 311165,
        // Explosion 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4BF97 = 311191,
        // Explosion 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4BFB1 = 311217,
        // Bad Bros. Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4CAE6 = 314086,
        // Bad Bros. Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4CB22 = 314146,
        // Bad Bros. Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4CB5E = 314206,
        // Bad Bros. Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4CB9A = 314266,
        // Bad Bros. Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4D6B6 = 317110,
        // Bad Bros. Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4D6F2 = 317170,
        // Bad Bros. Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4D72E = 317230,
        // Bad Bros. Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4D76A = 317290,
        // Bad Bros. Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4E326 = 320294,
        // Bad Bros. Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4E368 = 320360,
        // Bad Bros. Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4E3B6 = 320438,
        // Bad Bros. Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4EF84 = 323460,
        // Bad Bros. Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4EFC6 = 323526,
        // Bad Bros. Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4F014 = 323604,
        // Bad Bros. Tackle Left
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4B582 = 324994,
        // Dwarf Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FA00 = 326144,
        // Dwarf Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FA0F = 326159,
        // Dwarf Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FA1E = 326174,
        // Dwarf Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FA2D = 326189,
        // Dwarf Walk Left 5
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FA3C = 326204,
        // Dwarf Walk Left 6
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FA4B = 326219,
        // Dwarf Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FE9A = 327322,
        // Dwarf Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FEA9 = 327337,
        // Dwarf Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FEB8 = 327352,
        // Dwarf Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FEC7 = 327367,
        // Dwarf Walk Right 5
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FED6 = 327382,
        // Dwarf Walk Right 6
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FEE5 = 327397,
        // Meat
        [Compression(CompressionType.None)]
        [Columns(2)]
        [Rows(1)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FFB4 = 327604,
        // Potion
        [Compression(CompressionType.None)]
        [Columns(2)]
        [Rows(2)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap4FFBC = 327612,
        // Bad Bros. Walk Up Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap50B86 = 330630,
        // Bad Bros. Walk Up Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap50BC2 = 330690,
        // Bad Bros. Walk Up Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap50BFE = 330750,
        // Bad Bros. Walk Up Left 4
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap50C3A = 330810,
        // Bad Bros. Walk Up Right 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap517FD6 = 333814,
        // Bad Bros. Walk Up Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap51832 = 333874,
        // Bad Bros. Walk Up Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5186E = 333934,
        // Bad Bros. Walk Up Right 4
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap518AA = 333994,
        // Bad Bros. Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap52946 = 338246,
        // Bad Bros. Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5297C = 338300,
        // Bad Bros. Damage Right 3
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap529BA = 338362,
        // Bad Bros. Damage Right 4
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap529F8 = 338424,
        // Skeleton Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap53106 = 340230,
        // Skeleton Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5312F = 340271,
        // Skeleton Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap53158 = 340312,
        // Skeleton Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap53181 = 340353,
        // Long Moan Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap53D4A = 343370,
        // Long Moan Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap53D6E = 343406,
        // Long Moan Damage Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap53D9C = 343452,
        // Long Moan Damage Right 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap53DC6 = 343494,
        // Lt. Bitter Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap548C6 = 346310,
        // Lt. Bitter Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap548FE = 346366,
        // Lt. Bitter Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap54936 = 346422,
        // Lt. Bitter Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5496E = 346478,
        // Lt. Bitter Walk Up Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap55306 = 348934,
        // Lt. Bitter Walk Up Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap55334 = 348980,
        // Lt. Bitter Walk Up Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap55362 = 349026,
        // Lt. Bitter Walk Up Left 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap55390 = 349072,
        // Lt. Bitter Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap562FE = 353022,
        // Lt. Bitter Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5632C = 353068,
        // Lt. Bitter Damage Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap56362 = 353122,
        // Lt. Bitter Damage Left 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap56392 = 353170,
        // Lt. Bitter Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap572F4 = 357108,
        // Lt. Bitter Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap57322 = 357154,
        // Lt. Bitter Damage Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap57358 = 357208,
        // Lt. Bitter Damage Right 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap57388 = 357256,
        // Fireball Right 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(2)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5752A = 357674,
        // Fireball Right 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(2)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap57536 = 357686,
        // Heninger Thrown Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap57A62 = 359010,
        // Heninger Thrown Left 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap57A80 = 359040,
        // Heninger Thrown Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap57FC2 = 360386,
        // Heninger Thrown Right 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap57FE0 = 360416,
        // Lt. Bitter Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap588C6 = 362694,
        // Lt. Bitter Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap588FE = 362750,
        // Lt. Bitter Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap58936 = 362806,
        // Lt. Bitter Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5896E = 362862,
        // Lt. Bitter Walk Up Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap59306 = 365318,
        // Lt. Bitter Walk Up Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap59334 = 365364,
        // Lt. Bitter Walk Up Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap59362 = 365410,
        // Lt. Bitter Walk Up Right 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap59390 = 365456,
        // Lt. Bitter Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5A49E = 369822,
        // Lt. Bitter Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5A4D4 = 369876,
        // Lt. Bitter Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5A52A = 369962,
        // Lt. Bitter Attack Left 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5A558 = 370008,
        // Lt. Bitter Attack Left 5
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5A596 = 370070,
        // Lt. Bitter Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5B6AC = 374444,
        // Lt. Bitter Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5B6E2 = 374498,
        // Lt. Bitter Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5B738 = 374584,
        // Lt. Bitter Attack Right 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5B766 = 374630,
        // Lt. Bitter Attack Right 5
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5B7A4 = 374692,
        // Dawrf Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5BA3A = 375354,
        // Dawrf Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5BA4C = 375372,
        // Dawrf Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5BCBE = 375998,
        // Dawrf Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5BCD0 = 376016,
        // Death Adder Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5CDA6 = 380326,
        // Death Adder Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5CDE8 = 380392,
        // Death Adder Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5CE2A = 380458,
        // Death Adder Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5CE6C = 380524,
        // Death Adder Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5DC4E = 384078,
        // Death Adder Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5DC90 = 384144,
        // Death Adder Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5DCD2 = 384210,
        // Death Adder Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5DD14 = 384276,
        // Death Adder Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5ED16 = 388374,
        // Death Adder Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5ED58 = 388440,
        // Death Adder Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5EDC2 = 388546,
        // Death Adder Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5FDD9 = 392665,
        // Death Adder Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5FE1B = 392731,
        // Death Adder Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap5FE85 = 392837,
        // Death Adder Walk Up Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap60C06 = 396294,
        // Death Adder Walk Up Left 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap60C48 = 396360,
        // Death Adder Walk Up Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap60C8A = 396426,
        // Death Adder Walk Up Left 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap60CCC = 396492,
        // Death Adder Walk Up Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6190E = 399630,
        // Death Adder Walk Up Right 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap61950 = 399696,
        // Death Adder Walk Up Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap61992 = 399762,
        // Death Adder Walk Up Right 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(12)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap619D4 = 399828,
        // Death Adder Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap62B76 = 404342,
        // Death Adder Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap62BCD = 404429,
        // Death Adder Damage Left 3
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap62C1B = 404507,
        // Death Adder Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap63DBD = 409021,
        // Death Adder Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap63E14 = 409108,
        // Death Adder Damage Right 3
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap63E62 = 409186,
        // Death Adder Punch Left 1
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap64A06 = 412166,
        // Death Adder Punch Left 2
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap64A4B = 412235,
        // Death Adder Punch Right 1
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap65489 = 414857,
        // Death Adder Punch Right 2
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap654CE = 414926,
        // Dragon Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6670C = 419596,
        // Dragon Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap66772 = 419698,
        // Dragon Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap667D8 = 419800,
        // Dragon Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6683E = 419902,
        // Dragon Walk Left 5
        [Compression(CompressionType.None)]
        [Columns(13)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap668A4 = 420004,
        // Dragon Walk Left 6
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap66905 = 420101,
        // Dragon Walk Left 7
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap669BB = 420203,
        // Dragon Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67BB9 = 424889,
        // Dragon Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67C1F = 424991,
        // Dragon Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67C85 = 425093,
        // Dragon Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67CEB = 425195,
        // Dragon Walk Right 5
        [Compression(CompressionType.None)]
        [Columns(13)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67D51 = 425297,
        // Dragon Walk Right 6
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67DB2 = 425394,
        // Dragon Walk Right 7
        [Compression(CompressionType.None)]
        [Columns(12)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67E18 = 425496,
        // Fireball Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(2)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67FE6 = 425958,
        // Fireball Left 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(2)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap67FF2 = 425970,
        // Dragon Jump Left 1
        [Compression(CompressionType.None)]
        [Columns(11)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap68866 = 428134,
        // Dragon Jump Left 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap688DA = 428250,
        // Dragon Jump Right 1
        [Compression(CompressionType.None)]
        [Columns(11)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap691A4 = 430500,
        // Dragon Jump Right 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap69218 = 430616,
        // Dragon Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap69BA2 = 433058,
        // Dragon Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap69C0C = 433164,
        // Dragon Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(10)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6A556 = 435542,
        // Dragon Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6A5C0 = 435648,
        // Dragon Flame Right 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6ABEA = 437226,
        // Dragon Flame Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6ABF9 = 437241,
        // Dragon Flame Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6AC23 = 437283,
        // Chicken Leg Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6B40D = 439309,
        // Chicken Leg Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6B43B = 439355,
        // Chicken Leg Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6B469 = 439401,
        // Chicken Leg Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6B497 = 439447,
        // Chicken Leg Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6BC65 = 441445,
        // Chicken Leg Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6BC8E = 441486,
        // Chicken Leg Damage Left
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6BFC6 = 442310,
        // Chicken Leg Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6C7C6 = 444358,
        // Chicken Leg Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6C7F4 = 444404,
        // Chicken Leg Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6C822 = 444450,
        // Chicken Leg Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6C850 = 444496,
        // Chicken Leg Jump Left 1
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6D17E = 446846,
        // Chicken Leg Jump Left 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6D1BC = 446908,
        // Chicken Leg Jump Right 1
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6DAFA = 449274,
        // Chicken Leg Jump Right 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6DB38 = 449336,
        // Chicken Leg Damage Right
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6DE76 = 450166,
        // Long Moan Walk Up Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6E5F8 = 452088,
        // Long Moan Walk Up Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6E61A = 452122,
        // Long Moan Walk Up Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6E63C = 452156,
        // Long Moan Walk Up Left 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6E65E = 452190,
        // Long Moan Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6F280 = 455296,
        // Long Moan Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6F2A2 = 455330,
        // Long Moan Damage Left 3
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6F2CB = 455371,
        // Long Moan Damage Left 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6F2F4 = 455412,
        // Long Moan Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6FF16 = 458518,
        // Long Moan Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6FF38 = 458552,
        // Long Moan Damage Right 3
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6FF61 = 458593,
        // Long Moan Damage Right 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap6FF8A = 458634,
        // Chicken Leg Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap707A6 = 460710,
        // Chicken Leg Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(10)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap707CF = 460751,
        // Long Moan Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap70F47 = 462663,
        // Long Moan Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap70F69 = 462697,
        // Long Moan Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap70F8B = 462731,
        // Long Moan Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap70FAD = 462765,
        // Long Moan Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7170F = 464655,
        // Long Moan Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap71731 = 464689,
        // Long Moan Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap71753 = 464723,
        // Long Moan Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap71775 = 464757,
        // Long Moan Walk Up Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap71EF7 = 466679,
        // Long Moan Walk Up Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap71F19 = 466713,
        // Long Moan Walk Up Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap71F3B = 466747,
        // Long Moan Walk Up Right 4
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap71F5D = 466781,
        // Long Moan Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7269F = 468639,
        // Long Moan Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap726C3 = 468675,
        // Long Moan Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap72701 = 468737,
        // Long Moan Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap72E54 = 470612,
        // Long Moan Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap72E78 = 470648,
        // Long Moan Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(9)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap72EB6 = 470710,
        // Long Moan Thrown Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap736E9 = 472809,
        // Long Moan Thrown Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap73707 = 472839,
        // Long Moan Thrown Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap73725 = 472869,
        // Long Moan Thrown Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap73F55 = 474965,
        // Long Moan Thrown Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap73F73 = 474995,
        // Long Moan Thrown Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap73F91 = 475025,
        // Zuburoka Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap74726 = 476966,
        // Zuburoka Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap74744 = 476996,
        // Zuburoka Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap74762 = 477026,
        // Zuburoka Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap74780 = 477056,
        // Zuburoka Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap74E7E = 478846,
        // Zuburoka Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap74EAE = 478894,
        // Zuburoka Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap74EF3 = 478963,
        // Zuburoka Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap75977 = 481655,
        // Zuburoka Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap75999 = 481689,
        // Zuburoka Damage Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap759BF = 481727,
        // Zuburoka Damage Left 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap759EF = 481775,
        // Zuburoka Damage Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7646E = 484458,
        // Zuburoka Damage Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7648C = 484492,
        // Zuburoka Damage Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap764B2 = 484530,
        // Zuburoka Damage Right 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap764E2 = 484578,
        // Zuburoka Thrown Left 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap76CFD = 486653,
        // Zuburoka Thrown Left 2
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap76D23 = 486691,
        // Zuburoka Thrown Left 3
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap76D51 = 486737,
        // Zuburoka Mount Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap77613 = 488979,
        // Zuburoka Mount Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7762E = 489006,
        // Zuburoka Mount Left 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap77650 = 489040,
        // Zuburoka Mount Left 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7766E = 489070,
        // Zuburoka Mount Right 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap77F29 = 491305,
        // Zuburoka Mount Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap77F44 = 491332,
        // Zuburoka Mount Right 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap77F66 = 491366,
        // Zuburoka Mount Right 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap77F84 = 491396,
        // Zuburoka Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap78726 = 493350,
        // Zuburoka Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap78744 = 493380,
        // Zuburoka Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap78762 = 493410,
        // Zuburoka Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap78780 = 493440,
        // Zuburoka Walk Up Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap78EBE = 495294,
        // Zuburoka Walk Up Left 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap78EDC = 495324,
        // Zuburoka Walk Up Left 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap78EFA = 495354,
        // Zuburoka Walk Up Left 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap78F18 = 495384,
        // Zuburoka Walk Up Right 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap79656 = 497238,
        // Zuburoka Walk Up Right 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap79674 = 497268,
        // Zuburoka Walk Up Right 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap79692 = 497298,
        // Zuburoka Walk Up Right 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap796B0 = 497328,
        // Zuburoka Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap796DAE = 499118,
        // Zuburoka Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(9)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap796DDE = 499166,
        // Zuburoka Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap796E23 = 499235,
        // Zuburoka Thrown Right 1
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7A647 = 501319,
        // Zuburoka Thrown Right 2
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7A66D = 501357,
        // Zuburoka Thrown Right 3
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7A69B = 501403,
        // Heninger Walk Up Left 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7AC9D = 502941,
        // Heninger Walk Up Left 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7ACB8 = 502968,
        // Heninger Walk Up Left 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7ACD3 = 502995,
        // Heninger Walk Up Left 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7ACEE = 503022,
        // Heninger Walk Up Right 1
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7B2E9 = 504553,
        // Heninger Walk Up Right 2
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7B304 = 504580,
        // Heninger Walk Up Right 3
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7B31F = 504607,
        // Heninger Walk Up Right 4
        [Compression(CompressionType.None)]
        [Columns(3)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7B33A = 504634,
        // Heninger Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7BEF5 = 507637,
        // Heninger Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7BF19 = 507673,
        // Heninger Damage Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7BF47 = 507719,
        // Heninger Damage Left 4
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(3)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7BF71 = 507761,
        // Heninger Walk Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7C6A6 = 509606,
        // Heninger Walk Left 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7C6CF = 509647,
        // Heninger Walk Left 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7C6F8 = 509688,
        // Heninger Walk Left 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7C721 = 509729,
        // Heninger Walk Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7CSEA = 511466,
        // Heninger Walk Right 2
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7CE13 = 511507,
        // Heninger Walk Right 3
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7CE3C = 511548,
        // Heninger Walk Right 4
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7CE65 = 511589,
        // Heninger Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7D5CE = 513486,
        // Heninger Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7D5FC = 513532,
        // Heninger Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7D62C = 513580,
        // Heninger Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7DD8A = 515466,
        // Heninger Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7DDB8 = 515512,
        // Heninger Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7DDE8 = 515560,
        // Heninger Jump Attack Left 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7E5E6 = 517606,
        // Heninger Jump Attack Left 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7E600 = 517632,
        // Heninger Jump Attack Left 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7E626 = 517670,
        // Heninger Jump Attack Right 1
        [Compression(CompressionType.None)]
        [Columns(5)]
        [Rows(4)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7EE30 = 519728,
        // Heninger Jump Attack Right 2
        [Compression(CompressionType.None)]
        [Columns(4)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7EE4A = 519754,
        // Heninger Jump Attack Right 3
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(6)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7EE70 = 519792,
        // Bad Bros. Damage Left 1
        [Compression(CompressionType.None)]
        [Columns(6)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7EEFA = 524026,
        // Bad Bros. Damage Left 2
        [Compression(CompressionType.None)]
        [Columns(7)]
        [Rows(8)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7FF30 = 524080,
        // Bad Bros. Damage Left 3
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(7)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7FF6E = 524142,
        // Bad Bros. Damage Left 4
        [Compression(CompressionType.None)]
        [Columns(8)]
        [Rows(5)]
        [UseFlags(false)]
        [Offset(0)]
        Tilemap7FFAC = 524204,
    }

    /// <summary>
    /// Tileset enumeration (value(ID) = byte location in ROM)
    /// </summary>
    public enum TilesetType
    {
        // Stage 1
        [Length(3968)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        TilesetCA78 = 51832,
        // Magic Select
        [Length(3321)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        TilesetE8F8 = 59640,
        // Title Screen
        [Length(5519)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset10000 = 65536,
        // End Screen 3
        [Length(5676)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset118D6 = 71894,
        // HUD
        [Length(1120)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset136D6 = 79574,
        // Font
        [Length(323)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset144C2 = 83138,
        // Map Quill
        [Length(238)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset14605 = 83461,
        // Map
        [Length(6840)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset146F3 = 83699,
        // End Screen 1 and 2
        [Length(7237)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset163BB = 91067,
        // Ax Battler Walk
        [Length(5824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset18131 = 98608,
        // Ax Battler Walk Up
        [Length(5504)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset19921 = 104736,
        // Ax Battler Idle
        [Length(1792)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset1AF07 = 110342,
        // Ax battler Magic
        [Length(1920)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset1B66D = 112236,
        // Ax Battler Attack Up
        [Length(4992)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset1C125 = 114980,
        // Ax Battler Throw
        [Length(4862)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset1D5C5 = 120260,
        // Ax Battler Run
        [Length(5376)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset1E9F1 = 125424,
        // Ax Battler Jump Attack
        [Length(6656)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset20199 = 131480,
        // Ax Battler Damage
        [Length(7712)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset21D23 = 138530,
        // Ax Battler Camp
        [Length(960)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset23B8A = 146313,
        // Ax Battler Kick
        [Length(4704)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset24161 = 147808,
        // Ax Battler Attack
        [Length(4416)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset254A9 = 152744,
        // Ax Battler Mount
        [Length(4736)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset266FA = 157424,
        // Ax Battler Tackle
        [Length(1344)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset279B1 = 162224,
        // Stage 2
        [Length(3680)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset2A150 = 172368,
        // Score Screen
        [Length(1067)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset2AFD0 = 176080,
        // End Rating Strength
        [Length(594)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset2B4DF = 177375,
        // Continue/Game Over 1
        [Length(1239)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset2B7FE = 178174,
        // Continue/Game Over 2
        [Length(1164)]
        [Compression(CompressionType.PhantasyStarRLE)]
        [Offset(0)]
        [Masked(false)]
        Tileset2B849 = 178249,
        // Stage 4
        [Length(3104)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset2CBD0 = 183248,
        // Ax Battler Down Stab
        [Length(1472)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset2F043 = 192578,
        // Stage 3
        [Length(3328)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset328E2 = 207074,
        // Stage 5
        [Length(3872)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset36970 = 223600,
        // Earth Magic 1
        [Length(3200)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset3808A = 229514,
        // Earth Magic 2
        [Length(3968)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset38DA8 = 232872,
        // Earth Magic 3
        [Length(3968)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset39F90 = 237456,
        // Fire Magic 1
        [Length(1984)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset3AF7A = 241530,
        // Thunder Magic 1
        [Length(1984)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset3C0EA = 245994,
        // Thunder Magic 2
        [Length(2400)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset3C952 = 248146,
        // Thunder Magic 3
        [Length(2400)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset3D3E2 = 250850,
        // Fire Magic 2
        [Length(4064)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset3DE23 = 253476,
        // Fire Magic 3
        [Length(3552)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset3F098 = 258200,
        // Fire Magic 4
        [Length(4032)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset40441 = 263233,
        // Fire Magic 5
        [Length(4000)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(false)]
        Tileset414D1 = 267473,
        // Skeleton Walk Left
        [Length(1760)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset44000 = 278528,
        // Skeleton Attack Left
        [Length(1824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset44785 = 280452,
        // Skeleton Attack Right
        [Length(1824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset44F3C = 282427,
        // Skeleton Jump Attack Left
        [Length(3072)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset456F3 = 284402,
        // Skeleton Jump Attack Right
        [Length(3072)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset46390 = 287631,
        // Skeleton Thrown Left
        [Length(1888)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4702D = 290860,
        // Skeleton Thrown Right
        [Length(1888)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset47812 = 292881,
        // Skeleton Walk Up Left
        [Length(1504)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset48001 = 294912,
        // Skeleton Walk Up Right
        [Length(1504)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4864D = 296524,
        // Skeleton Damage Left
        [Length(3520)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset48C99 = 298136,
        // Skeleton Damage Right
        [Length(3520)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset49B27 = 301863,
        // Dragon Flame Left
        [Length(1536)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4A9B6 = 305590,
        // Bad Bros. Tackle Right
        [Length(1312)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4B019 = 307225,
        // Explosion
        [Length(2560)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4B577 = 308599,
        // Bad Bros. Walk Left
        [Length(2784)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4C000 = 311296,
        // Bad Bros. Walk Right
        [Length(2784)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4CBD0 = 314320,
        // Bad Bros. Attack Left
        [Length(2944)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4D7A0 = 317344,
        // Bad Bros. Attack Right
        [Length(2944)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4E3FE = 320510,
        // Bad Bros. Tackle Left
        [Length(1312)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4E014 = 323676,
        // Dwarf Walk Left
        [Length(1088)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4F5BA = 325050,
        // Dwarf Walk Right
        [Length(1088)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4FEB8 = 326228,
        // Meat
        [Length(64)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4FEEF = 327406,
        // Potion
        [Length(128)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset4FF2F = 327470,
        // Bad Bros. Walk Up Left
        [Length(2944)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5000 = 327680,
        // Bad Bros. Walk Up Right
        [Length(2944)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset50C70 = 330864,
        // Bad Bros. Damage Right
        [Length(4192)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset518E0 = 334048,
        // Skeleton Walk Right
        [Length(1760)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset52A20 = 338464,
        // Long Moan Damage Right
        [Length(2976)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset531A4 = 340388,
        // Lt. Bitter Walk Left
        [Length(2240)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset54000 = 344064,
        // Lt. Bitter Walk Up Left
        [Length(2400)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset549A0 = 346528,
        // Lt. Bitter Damage Left
        [Length(3904)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset553B8 = 349112,
        // Lt. Bitter Damage Right
        [Length(3904)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset563AE = 353198,
        // Fireball Right
        [Length(384)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset573A4 = 357284,
        // Long Moan Thrown Left
        [Length(1312)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5753C = 357692,
        // Long Moan Thrown Right
        [Length(1312)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset57A9C = 359068,
        // Lt. Bitter Walk Right
        [Length(2240)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset58000 = 360448,
        // Lt. Bitter Walk Up Right
        [Length(2400)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset589A0 = 362912,
        // Lt. Bitter Attack Left
        [Length(4320)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset593B8 = 365496,
        // Lt. Bitter Attack Right
        [Length(4320)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5A5C6 = 370118,
        // Dwarf Damage Left
        [Length(608)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5B7D4 = 374740,
        // Dwarf Damage Right
        [Length(608)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5BA58 = 375384,
        // Death Adder Walk Left
        [Length(3488)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5C000 = 376832,
        // Death Adder Walk Right
        [Length(3488)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5CEA8 = 380584,
        // Death Adder Attack Left
        [Length(4032)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5DD50 = 384336,
        // Death Adder Attack Right
        [Length(4032)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset5EE13 = 388627,
        // Death Adder Walk Up Left
        [Length(3072)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset60000 = 393216,
        // Death Adder Walk Up Right
        [Length(3072)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset60D08 = 396552,
        // Death Adder Damage Left
        [Length(4448)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset619CE = 399888,
        // Death Adder Damage Right
        [Length(4448)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset62C57 = 404567,
        // Death Adder Punch Left
        [Length(2560)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset64000 = 409600,
        // Death Adder Punch Right
        [Length(2560)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset64A83 = 412291,
        // Dragon Walk Left
        [Length(4608)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset65506 = 414982,
        // Dragon Walk Right
        [Length(4608)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset669B3 = 420275,
        // Fireball Left
        [Length(384)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset67DAC = 425568,
        // Dragon Jump Left
        [Length(2144)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6800 = 425984,
        // Dragon Jump Right
        [Length(2144)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6893E = 428350,
        // Dragon Damage Left
        [Length(2336)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6927E = 430716,
        // Dragon Damage Right
        [Length(2336)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset69C30 = 433200,
        // Dragon Flame Right
        [Length(1536)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6A5E4 = 435684,
        // Chicken Leg Walk Left
        [Length(1984)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6AC47 = 437319,
        // Chicken Leg Attack Left
        [Length(1952)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6B4BF = 439487,
        // Chicken Leg Damage Left
        [Length(768)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6BCC0 = 441536,
        // Chicken Leg Walk Right
        [Length(1984)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6C000 = 442368,
        // Chicken Leg Jump Left
        [Length(2304)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6C878 = 444536,
        // Chicken Leg Jump Right
        [Length(2304)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6D1F4 = 446964,
        // Chicken Leg Damage Right
        [Length(768)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6DB70 = 449392,
        // Long Moan Walk Up Left
        [Length(1888)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6DE92 = 450194,
        // Long Moan Damage Left
        [Length(3072)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6E67A = 452218,
        // Long Moan Damage Right
        [Length(3072)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset6F310 = 455440,
        // Chicken Leg Attack Right
        [Length(1952)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset70000 = 458752,
        // Long Moan Walk Left
        [Length(1856)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset70801 = 460801,
        // Long Moan Walk Right
        [Length(1856)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset70FC9 = 462793,
        // Long Moan Walk Up Right
        [Length(1760)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset71791 = 464785,
        // Long Moan Attack Left
        [Length(1824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset71F79 = 466809,
        // Long Moan Attack Right
        [Length(1824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7272E = 468782,
        // Long Moan Thrown Left
        [Length(2048)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset72EE3 = 470755,
        // Long Moan Thrown Right
        [Length(2048)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7374F = 472911,
        // Zuburoka Walk Left
        [Length(1824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset74000 = 475136,
        // Zuburoka Attack Left
        [Length(1760)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset74798 = 477080,
        // Zuburoka Damage Left
        [Length(2656)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset74F11 = 478993,
        // Zuburoka Damage Right
        [Length(2656)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset75A04 = 481796,
        // Zuburoka Thrown Left
        [Length(2048)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset764f7 = 484599,
        // Zuburoka Mount Left
        [Length(2208)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset76D6D = 486765,
        // Zuburoka Mount Right
        [Length(2208)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset77683 = 489091,
        // Zuburoka Walk Right
        [Length(1824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset78000 = 491520,
        // Zuburoka Walk Up Left
        [Length(1824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset78798 = 493464,
        // Zuburoka Walk Up Right
        [Length(1824)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset78F30 = 495408,
        // Zuburoka Attack Right
        [Length(1760)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset796C8 = 497352,
        // Zuburoka Thrown Right
        [Length(2048)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset79E41 = 499265,
        // Heninger Walk Up Left
        [Length(1504)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7A6B7 = 501431,
        // Heninger Walk Up Right
        [Length(1504)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7AD03 = 503043,
        // Heninger Damage Left
        [Length(2976)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7B34F = 504655,
        // Heninger Walk Left
        [Length(1696)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7C000 = 507904,
        // Heninger Walk Right
        [Length(1696)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7C744 = 509764,
        // Heninger Attack Left
        [Length(1856)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7CE88 = 511624,
        // Heninger Attack Right
        [Length(1856)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7D644 = 513604,
        // Heninger Jump Attack Left
        [Length(2016)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7DE00 = 515584,
        // Heninger Jump Attack Right
        [Length(2016)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7E64A = 517706,
        // Bad Bros. Damage Left
        [Length(4192)]
        [Compression(CompressionType.None)]
        [Offset(1)]
        [Masked(true)]
        Tileset7EE94 = 519828,
    }
}
