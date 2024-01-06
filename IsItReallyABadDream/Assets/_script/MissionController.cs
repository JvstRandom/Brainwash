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

            if (triggerNguping.buatAlatPendengar && triggerSetelahAlatPendengar.sdhNguping)
            {
                misiTxt.text = "Lanjut mencari tahu keberadaan faith dan hope";
            }

            if (triggerPercakapandokter.sdhlvl1 && !triggerTidur.level2)
            {
                misiTxt.text = "Kembali tidur di ruangan paling pojok di kasur paling kiri";
            }
        }

        if (triggerTidur.level2)
        {

        }
    }
}
