VAR zach_trust = 0
VAR object_interaction = 0

-> nightmare1

=== nightmare1 ===
Frey terbangun dengan kondisi panti asuhan kosong.
Frey: Eh, kenapa disini gelap sekali, eh tunggu kenapa aku membawa senter? #thought
Frey: Huh, ini tidak bisa dinyalakan? Oh baterainya tidak ada. #thought
Frey: Aku harus mencari baterai agar ini bisa menyala dan membantuku berjalan. #thought
-> object

=== object ===
***Boneka Hope -> Hope_teddy
***Pesawat Faith -> Faith_plane
***Kalung Zach -> Zach_necklace

=== Hope_teddy ===
Frey: Hm? Sebuah boneka?
Frey: Kenapa ini bercahaya ya?
~object_interaction += 1
{object_interaction < 3: ->object}
{object_interaction >= 3: 
Frey: Hm… aku masih penasaran kenapa mereka bercahaya, sebaiknya aku mengeceknya lagi nanti.-> END
}

=== Faith_plane ===
Frey: Sebuah pesawat? Hm… Kira-kira ini milik siapa ya?
~object_interaction += 1
{object_interaction < 3: ->object}
{object_interaction >= 3: 
Frey: Hm… aku masih penasaran kenapa mereka bercahaya, sebaiknya aku mengeceknya lagi nanti. -> END
}

=== Zach_necklace ===
Frey: Kalung? Kalung bulan ini terlihat cantik sekali.
~object_interaction += 1
{object_interaction < 3: ->object}
{object_interaction >= 3: 
Frey: Hm… aku masih penasaran kenapa mereka bercahaya, sebaiknya aku mengeceknya lagi nanti. -> END
}