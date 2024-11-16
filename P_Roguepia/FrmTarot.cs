///////////////////////////////////////////////
// Créer par Robin Chessex
// 28.10.2024
// Distributeur de carte de divers jeux de tarot
///////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace P_Tarot
{
    public partial class FrmTarot : Form
    {
        int tarotDeckChoice = 0;
        int tirageEnLigneCompte = 1;

        List<string> tarotDeMarseille = new List<string> 
        {
            "I. Le Bateleur (ou le Magicien)",
            "II. La Papesse (ou la Grande Prêtresse)",
            "III. L'Impératrice",
            "IIII. L'Empereur",
            "V. Le Pape (ou le Hiérophante)",
            "VI. L'Amoureux (ou Les Amoureux dans les versions anglophones)",
            "VII. Le Chariot",
            "VIII. La Justice",
            "IX. L'Ermite",
            "X. La Roue de Fortune",
            "XI. La Force",
            "XII. Le Pendu",
            "XIII. L'Arcane sans nom/« La Mort »",
            "XIV. Tempérance",
            "XV. Le Diable",
            "XVI. La Maison Dieu (ou la Tour)",
            "XVII. L'Étoile",
            "XVIII. La Lune",
            "XVIIII. Le Soleil",
            "XX. Le Jugement",
            "XXI. Le Monde",
            "XXII. Le Mat / 0 - (ou le fou)"
        };

        List<string> tarotRiderWaite = new List<string> 
        {

            " 0 Le fou (The Fool)",
            "I. Le Magicien (The Magician)",
            "II. La Grande Prêtresse (The High Priestess)",
            "III. L'Impératrice (The Empress)",
            "IV. L'Empereur (The Emperor)",
            "V. Le Hiérophante (The Hierophant)",
            "VI. Les Amoureux (The Lovers)",
            "VII. Le Chariot (The Chariot)",
            "VIII. La Force (Strength)",
            "IX. L'Ermite (The Hermit)",
            "X. La Roue de Fortune (The Wheel Of Fortune)",
            "XI. La Justice (Justice)",
            "XII. Le Pendu (The Hanged Man)",
            "XIII La Mort (Death)",
            "XIV. Tempérance (Temperance)",
            "XV. Le Diable (The Devil)",
            "XVI. La Tour (The Tower)",
            "XVII. L'Étoile (The Star)",
            "XVIII. La Lune (The Moon)",
            "XIX. Le Soleil (The Sun)",
            "XX. Le Jugement (Judgement)",
            "XXI. Le Monde (The World)",
        };

        List<string> tarotEgyptien = new List<string> 
        {
            "I. Bes, The Magus",
            "II. Sameref, The High Priestess",
            "III. Isis, The Empress",
            "IV. Osiris, The Emperor",
            "V. Yumteph, The Hierophant",
            "VI. Hathor, The Lovers",
            "VII. Neshmet, The Chariot",
            "VIII. Thoth, Justice",
            "IX. Ma'at The Hermit",
            "X. Shaï The Wheel Of Fortune",
            "XI. Ptah, Strength",
            "XII. The Upset, The Hanged Man",
            "XIII A, Death",
            "XIV. Mut, Temperance",
            "XV. Ammit, The Devil",
            "XVI. Apep, The Ligthning",
            "XVII. Nut, The Star",
            "XVIII. Khonsu, The Moon",
            "XIX. Aten, the Sun",
            "XX. Anubis, The Judgment",
            "XXI. Geb, The Universe",
            "XXII Hu-Tepa, The Fool",
            "One of Ankh, One of Swords",
            "One of Kheprera, One of Coins",
            "One Of Ded, One of Staves",
            "One of Cups, One of Heset",
            "Ushabti of Ankh, Page of Swords",
            "Charioteer of Ankh, Knight of Swords",
            "Queen of Ankh, Queen of Swords",
            "Pharaoh of Ankh, King of Swords",
            "Ushabti of Heset, Page of Cups",
            "Charioteer of Heset, Knight of Cups",
            "Queen of Heset, Queen of Cups",
            "Pharaoh of Heset, King of Cups",
            "Ushabti of Kheprera, Page of Coins",
            "Charioteer of Kheprera, Knight of Coins",
            "Queen of Kheprera, Queen of Coins",
            "Pharaoh of Kheprera, King of Coins",
            "Ushabti of Ded, Page of Staves",
            "Charioteer of Ded, Knight of Staves",
            "Queen of Ded, Queen of Staves",
            "Pharaoh of Ded, King of Staves"
        };

        List<string> jeuDe54Cartes = new List<string>
        {
            "As de Cœurs", "2 de Cœurs", "3 de Cœurs", "4 de Cœurs", "5 de Cœurs",
            "6 de Cœurs", "7 de Cœurs", "8 de Cœurs", "9 de Cœurs", "10 de Cœurs",
            "Valet de Cœurs", "Dame de Cœurs", "Roi de Cœurs",
            "As de Carreaux", "2 de Carreaux", "3 de Carreaux", "4 de Carreaux", "5 de Carreaux",
            "6 de Carreaux", "7 de Carreaux", "8 de Carreaux", "9 de Carreaux", "10 de Carreaux",
            "Valet de Carreaux", "Dame de Carreaux", "Roi de Carreaux",
            "As de Trèfles", "2 de Trèfles", "3 de Trèfles", "4 de Trèfles", "5 de Trèfles",
            "6 de Trèfles", "7 de Trèfles", "8 de Trèfles", "9 de Trèfles", "10 de Trèfles",
            "Valet de Trèfles", "Dame de Trèfles", "Roi de Trèfles",
            "As de Piques", "2 de Piques", "3 de Piques", "4 de Piques", "5 de Piques",
            "6 de Piques", "7 de Piques", "8 de Piques", "9 de Piques", "10 de Piques",
            "Valet de Piques", "Dame de Piques", "Roi de Piques",
            "Joker 1", "Joker 2"
        };
        List<string> jeuDe36Cartes = new List<string>
        {
            "As de Cœurs", "7 de Cœurs", "8 de Cœurs", "9 de Cœurs", "10 de Cœurs",
            "Valet de Cœurs", "Dame de Cœurs", "Roi de Cœurs",
            "As de Carreaux", "7 de Carreaux", "8 de Carreaux", "9 de Carreaux", "10 de Carreaux",
            "Valet de Carreaux", "Dame de Carreaux", "Roi de Carreaux",
            "As de Trèfles", "7 de Trèfles", "8 de Trèfles", "9 de Trèfles", "10 de Trèfles",
            "Valet de Trèfles", "Dame de Trèfles", "Roi de Trèfles",
            "As de Piques", "7 de Piques", "8 de Piques", "9 de Piques", "10 de Piques",
            "Valet de Piques", "Dame de Piques", "Roi de Piques"
        };

        List<string> Briscola = new List<string>
        {
            "As de Coupes", "2 de Coupes", "3 de Coupes", "4 de Coupes", "5 de Coupes",
            "6 de Coupes", "7 de Coupes", "Fante de Coupes", "Cavallo de Coupes", "Re de Coupes",
            "As de Denari", "2 de Denari", "3 de Denari", "4 de Denari", "5 de Denari",
            "6 de Denari", "7 de Denari", "Fante de Denari", "Cavallo de Denari", "Re de Denari",
            "As de Épées", "2 de Épées", "3 de Épées", "4 de Épées", "5 de Épées",
            "6 de Épées", "7 de Épées", "Fante de Épées", "Cavallo de Épées", "Re de Épées",
            "As de Bâtons", "2 de Bâtons", "3 de Bâtons", "4 de Bâtons", "5 de Bâtons",
            "6 de Bâtons", "7 de Bâtons", "Fante de Bâtons", "Cavallo de Bâtons", "Re de Bâtons"
        };
        List<string> pacteDesEtoiles = new List<string>
        {
            "0. Le Vide",
            "X. Le Voyageur Interstellaire",       // 10
            "XX. Les Lunes",                        // 20
            "XXX. La Tempête Solaire",              // 30
            "XL. La Prétorienne",                   // 40
            "L. L’Arche",                           // 50
            "LX. La Danse Rituelle",               // 60
            "LXX. La Ceinture",                     // 70
            "LXXX. Le Fracas du Firmament",        // 80
            "XC. Le Guide Galactique",              // 90
            "C. La Nébuleuse Éternelle",            // 100
            "CC. L’Œil",                            // 200
            "CCC. Le Navire des Rêves",             // 300
            "CD. Le Ciel Infinie",                  // 400
            "D. Le Poids du Cosmos",                // 500
            "DC. L’Ordre Météore",                  // 600
            "DCC. L’Étoile Filante",                // 700
            "DCCC. La Lueur Astrale",               // 800
            "CM. La Lame",                          // 900
            "CXC. Le Monde Éthér",                  // 990
            "CC. La Constellation Sacrée",          // 2000
            "CCI. L’Ultime Révélation",             // 2100
        };

        List<string> tarotMer = new List<string>  
        {
            "0. Le Naufragé (The Castaway)",
            "I. Le Navigateur (The Navigator)",
            "II. La Sirène (The Mermaid)",
            "III. La Reine des Mers (The Sea Queen)",
            "IV. Le Capitaine (The Captain)",
            "V. Le Sage Marin (The Sea Sage)",
            "VI. Les Âmes Sœurs (The Soulmates)",
            "VII. Le Navire (The Ship)",
            "VIII. Le Kraken (The Kraken)",
            "IX. L'Ancien des Abysses (The Deep One)",
            "X. La Marée (The Tide)",
            "XI. Le Trident (The Trident)",
            "XII. L'Oiseau de Mer (The Seabird)",
            "XIII. Le Maelström (The Maelstrom)",
            "XIV. L'Alchimiste Marin (The Sea Alchemist)",
            "XV. Le Requin (The Shark)",
            "XVI. Le Phare Foudroyé (The Struck Lighthouse)",
            "XVII. La Constellation (The Constellation)",
            "XVIII. La Vague (The Wave)",
            "XIX. L'Horizon (The Horizon)",
            "XX. Le Chant des Profondeurs (The Deep Song)",
            "XXI. L'Océan (The Ocean)",
            "XXVII. La Terre (The Land)",
        };
        public FrmTarot()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Tirage();
            btnTirageEnCroix.Enabled = false;
            btnTirageEnLigne.Enabled = false;

        }

        private void Tirage()
        {
            // Initiatlisation ___________________________________________________________________________

            Random rnd = new Random();
            List<List<string>> tarotDeck = new List<List<string>>() { tarotDeMarseille, tarotRiderWaite, tarotEgyptien, jeuDe54Cartes, jeuDe36Cartes, Briscola, pacteDesEtoiles, tarotMer };
            List<string> allTarotCards = tarotDeMarseille.Concat(tarotEgyptien).Concat(tarotRiderWaite).ToList();

            int cardChoice = rnd.Next(0, tarotDeck[tarotDeckChoice].Count());
            string tirage = tarotDeck[tarotDeckChoice][cardChoice];
            bool sameCard = false;
            string[] board = tbxTirage.Text.Split("\r\n\r\n".ToCharArray());
            board = board.Where(txt => txt != "").ToArray();

            // Traitement __________________________________________________________________________________

            if (board.Length < tarotDeck[tarotDeckChoice].Count())
            {
                do
                {
                    sameCard = false;

                    foreach (string line in board)
                    {
                        if (line == tirage)
                            {
                            cardChoice = rnd.Next(0, tarotDeck[tarotDeckChoice].Count());
                            tirage = tarotDeck[tarotDeckChoice][cardChoice];
                            sameCard = true;
                        }
                    }
                } while (sameCard);

                // Affichage ________________________________________________________________________________________________________
                //tbxTirage.Text += tirage + "\r\n";

                tbxTirage.AppendText(tirage + "\r\n\r\n");

            }
            else
            {
                btnDraw.Enabled = false;
                btnShuffle.Select();
            }
        }

        private void FrmTarot_Load(object sender, EventArgs e)
        {
            btnDraw.Enabled = false;
            btnTirageEnCroix.Enabled = false;
            btnTirageEnLigne.Enabled = false;
            btnShuffle.Select();
            tbxTirage.Text = "\r\nBienvenue sur ce programme de tirage de cartes, veuillez choisir un type deck et puis en tirer les cartes selon la méthode choisie. \r\n\r\n\r\n Créé par L'Enlèvement du Tartare\r\n\r\n - 2024 - \r\n";
            tbxTirage.Text += "   __________\r\n  <_______ /\r\n   <______/  /(_\r\n    <____<  ( __\\\r\n     <____\\  \\ \\\r\n     <_____\\\\_) )\r\n    /          /\r\n   / /_|  )___/\r\n  / |  / /\r\n /  |   \\\\__\r\n~~~~    (~~~)";
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            btnDraw.Enabled = true;
            btnTirageEnCroix.Enabled = true;
            btnTirageEnLigne.Enabled = true;
            tirageEnLigneCompte = 1;
            tbxTirage.Clear();
            btnDraw.Select();
        }

        private void rbtnTarotDeMarseille_CheckedChanged(object sender, EventArgs e)
        {
            tarotDeckChoice = 0;
            btnShuffle_Click(sender, e);
        }

        private void rbtnRiderWaite_CheckedChanged(object sender, EventArgs e)
        {
            tarotDeckChoice = 1;
            btnShuffle_Click(sender, e);

        }

        private void rbtnTarotEgytian_CheckedChanged(object sender, EventArgs e)
        {
            tarotDeckChoice = 2;
            btnShuffle_Click(sender, e);

        }

        private void rbtnNormalCardGame_CheckedChanged(object sender, EventArgs e)
        {
            tarotDeckChoice = 3;
            btnShuffle_Click(sender, e);
        }

        private void rbtn36CardsGame_CheckedChanged(object sender, EventArgs e)
        {
            tarotDeckChoice = 4;
            btnShuffle_Click(sender, e);
        }

        private void rbtnBriscola_CheckedChanged(object sender, EventArgs e)
        {
            tarotDeckChoice = 5;
            btnShuffle_Click(sender, e);
        }

        private void rbtnPacteEtoiles_CheckedChanged(object sender, EventArgs e)
        {
            tarotDeckChoice = 6;
            btnShuffle_Click(sender, e);
        }

        private void rbtnTarotMer_CheckedChanged(object sender, EventArgs e)
        {
            tarotDeckChoice = 7;
            btnShuffle_Click(sender, e);
        }
        private void btnTirageEnCroix_Click(object sender, EventArgs e)
        {
            
            tbxTirage.Text += "Carte de gauche, représente le consultant : \r\n";
            Tirage();
            tbxTirage.Text += "Carte de droite représente les circonstances ou personnes externes: \r\n";
            Tirage();
            tbxTirage.Text += "Carte du haut, identifie le problème à régler : \r\n";
            Tirage();
            tbxTirage.Text += "Carte à bas, le résultat : \r\n";
            Tirage();
            tbxTirage.Text += " Continuez à tirer des cartes si cela vous semble nécessaire : \r\n____________________________\r\n";

            btnTirageEnCroix.Enabled = false;
            btnTirageEnLigne.Enabled = false;
            btnShuffle.Select();

        }

        private void btnTirageEnLigne_Click(object sender, EventArgs e)
        {

            if (tirageEnLigneCompte < numTirageEnLigne.Value)
            {
                tbxTirage.Text += $"Carte n° {tirageEnLigneCompte} : \r\n";
                Tirage();

                btnTirageEnLigne.Enabled = true;

                tirageEnLigneCompte++;

            }
            else if (tirageEnLigneCompte == numTirageEnLigne.Value) 
            {
                tbxTirage.Text += $"Carte n° {tirageEnLigneCompte} : \r\n";
                Tirage();

                btnTirageEnLigne.Enabled = false;
                btnShuffle.Select();
            }
            btnDraw.Enabled = false;
            btnTirageEnCroix.Enabled = false;
        }

    }
}
