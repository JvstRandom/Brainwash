using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionController : MonoBehaviour
{
    public Text misiTxt;

    // Update is called once per frame
    void Update()
    {
        if (MainMenu.level1)
        {
            if (!dialogTrigger.isZachDialog1End)
            {
                misiTxt.text = "Mencari Tahu siapa yang membangunkan mu";
            }

            if (dialogTrigger.isZachDialog1End && !SceneT4Bermain1.sceneMulai)
            {
                misiTxt.text = "Pergi ke tempat makan di sebelah kiri";
            }

            if (SceneT4Bermain1.sceneMulai && ngomongKeNPC.jmlhPerkenalan != 5)
            {
                misiTxt.text = "Berkenalan dengan teman yang lain";
            }

            if (ngomongKeNPC.jmlhPerkenalan == 5 && faithnhopeCutsceneTrigger.FaithnHopeHilang && !triggerNguping.buatAlatPendengar)
            {
                misiTxt.text = "Mencari tahu keberadaan Faith dan Hope";
            }

            if (triggerNguping.buatAlatPendengar)
            {
                misiTxt.text = "Membuat alat pendengar dengan bahan-bahan yang ada di panti asuhan ada 3 total";
            }

            if (triggerNguping.buatAlatPendengar && triggerSetelahAlatPendengar.sdhNguping)
            {
                misiTxt.text = "Lanjut mencari tahu keberadaan faith dan hope di ruangan sebelah ruang suster";
            }

            if (triggerPercakapandokter.sdhlvl1 && !triggerTidur.level2)
            {
                misiTxt.text = "Kembali tidur di ruangan paling pojok di kasur paling kiri";
            }
        }

        if (triggerTidur.level2)
        {
            if (bendaMemoriNm.jmlhNyentuhBendaMemoriNM == 0)
            {
                misiTxt.text = "Mencari tahu mengapa kamu berada di mimpi";
            }

            if (bendaMemoriNm.jmlhNyentuhBendaMemoriNM == 1)
            {
                misiTxt.text = "Cari Benda lain yang menyala";
            }
        }

        if (bendaMemoriNm.level3)
        {
            if (!SpriteChanger.sudahLevel3)
            {
                misiTxt.text = "Mencari tahu tentang benda di mimpi";
            }

            if (!SpriteChanger.sudahLevel3 && SpriteChanger.jmlhNyentuhBendaMemori == 1)
            {
                misiTxt.text = "Mencari memori benda lain";
            }

            if (!SpriteChanger.sudahLevel3 && SpriteChanger.jmlhNyentuhBendaMemori == 3)
            {
                misiTxt.text = "Tidur!";
            }
        }

        if (triggerTidur.level4)
        {
            if (!changeCutsceneMakan.cutsceneMakan)
            {
                misiTxt.text = "";
            }

            if (changeCutsceneMakan.cutsceneMakan && triggerdikejar.dikejar)
            {
                misiTxt.text = "Menghindar dari suster dan cari tahu cara untuk bangun dari mimpi";
            }

        }

        if (bukuZach.level5)
        {
            if (!TriggerMulaiSceneRS.mulaiSceneRS)
            {
                misiTxt.text = "Pergi ke ruang suster untuk mencari tahu lebih lanjut tentang ekbenaran isi buku Zaach";
            }

            if (TriggerMulaiSceneRS.mulaiSceneRS)
            {
                misiTxt.text = "";
            }
        }

        if (triggerTidur.level6)
        {
            misiTxt.text = "Cari semua clu yang bisa di dapat di ruangan ini";

            if (triggerPapan.sdhLevel6)
            {
                misiTxt.text = "";
            }
        }

        if (triggerSleseLevel6.level7)
        {
            if (!TriggerTimerLvl7.mulaiTimerLvl7)
            {
                misiTxt.text = "pergi ke ruang rahasia";
            }

            if (TriggerTimerLvl7.mulaiTimerLvl7)
            {
                misiTxt.text = "buat potion dan buka brankas";
            }

            if (PlayerManager.havePotion)
            {
                misiTxt.text = "kasih potion ke teman-teman";
            }

            if (ngomongKeNPC.jmlhNgobati == 5)
            {
                misiTxt.text = "kembali tidur";
            }
        }

        if (triggerTidur.level8)
        {
            if(!ObjectImage.sdhlevel8)
            {
                misiTxt.text = "menelusuri labirin untuk bangun";
            }

        }

        if(ObjectImage.sdhlevel8)
        {
            if(!PlayerManager.haveCostume)
            {
                misiTxt.text = "membuat kostum terdiri dari 2 objek";
            }

            if(PlayerManager.haveCostume)
            {
                misiTxt.text = "pergi ke labirin";
            }

        }
    }
}
