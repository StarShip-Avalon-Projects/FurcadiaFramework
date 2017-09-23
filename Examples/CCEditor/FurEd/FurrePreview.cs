using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FurEd {
    public partial class FurrePreview : UserControl {
        public FurrePreview() {
            InitializeComponent();

            TreeNode cr;

            speciesChooser.BeginUpdate();

            cr = speciesChooser.Nodes.Add("Default Species");
            AddSpecies(cr, "Rodent", 1, 1, 1, 1, 2, 15, 20, 0);
            AddSpecies(cr, "Equine", 1, 21, 1, 1, 2, 16, 21, 1);
            AddSpecies(cr, "Feline", 1, 41, 1, 1, 2, 17, 22, 2);
            AddSpecies(cr, "Canine", 1, 61, 1, 1, 2, 18, 23, 3);
            AddSpecies(cr, "Musteline", 1, 81, 1, 1, 2, 19, 24, 4);
            AddSpecies(cr, "Lapine", 5, 0, 5, 5, 5, 2, 1, 0);
            AddSpecies(cr, "Squirrel", 14, 0, 8, 8, 8, 2, 1, 0);
            AddSpecies(cr, "Bovine", 15, 0, 10, 10, 10, 2, 1, 0);
            AddSpecies(cr, "Ursine", 20, 0, 12, 12, 12, 2, 1, 0);
            AddSpecies(cr, "Bugge", 33, 0, 25, 25, 25, 2, 1, 0);

            cr = speciesChooser.Nodes.Add("Classic Wings");
            AddSpecies(cr, "Rodent", 2, 0, 1, 1, 2, 15, 20, 0);
            AddSpecies(cr, "Equine", 2, 20, 1, 1, 2, 16, 21, 1);
            AddSpecies(cr, "Feline", 2, 40, 1, 1, 2, 17, 22, 2);
            AddSpecies(cr, "Canine", 2, 60, 1, 1, 2, 18, 23, 3);
            AddSpecies(cr, "Musteline", 2, 80, 1, 1, 2, 19, 24, 4);
            AddSpecies(cr, "Lapine", 6, 0, 5, 5, 5, 2, 1, 0);
            AddSpecies(cr, "Squirrel", 14, 20, 8, 8, 8, 2, 1, 0);
            AddSpecies(cr, "Bovine", 15, 20, 10, 10, 10, 2, 1, 0);
            AddSpecies(cr, "Ursine", 20, 20, 12, 12, 12, 2, 1, 0);

            cr = speciesChooser.Nodes.Add("Tri Wings");
            AddSpecies(cr, "Rodent", 7, 1, 1, 1, 2, 15, 20, 0);
            AddSpecies(cr, "Equine", 7, 21, 1, 1, 2, 16, 21, 1);
            AddSpecies(cr, "Feline", 7, 41, 1, 1, 2, 17, 22, 2);
            AddSpecies(cr, "Canine", 7, 61, 1, 1, 2, 18, 23, 3);
            AddSpecies(cr, "Musteline", 7, 81, 1, 1, 2, 19, 24, 4);
            AddSpecies(cr, "Lapine", 8, 0, 5, 5, 5, 2, 1, 0);
            AddSpecies(cr, "Squirrel", 14, 40, 8, 8, 8, 2, 1, 0);
            AddSpecies(cr, "Bovine", 15, 40, 10, 10, 10, 2, 1, 0);
            AddSpecies(cr, "Ursine", 20, 40, 12, 12, 12, 2, 1, 0);

            cr = speciesChooser.Nodes.Add("Butterfly Wings");
            AddSpecies(cr, "Rodent", 9, 1, 1, 1, 2, 15, 20, 0);
            AddSpecies(cr, "Equine", 9, 21, 1, 1, 2, 16, 21, 1);
            AddSpecies(cr, "Feline", 9, 41, 1, 1, 2, 17, 22, 2);
            AddSpecies(cr, "Canine", 9, 61, 1, 1, 2, 18, 23, 3);
            AddSpecies(cr, "Musteline", 9, 81, 1, 1, 2, 19, 24, 4);
            AddSpecies(cr, "Lapine", 10, 0, 5, 5, 5, 2, 1, 0);
            AddSpecies(cr, "Squirrel", 14, 60, 8, 8, 8, 2, 1, 0);
            AddSpecies(cr, "Bovine", 15, 60, 10, 10, 10, 2, 1, 0);
            AddSpecies(cr, "Ursine", 20, 60, 12, 12, 12, 2, 1, 0);

            cr = speciesChooser.Nodes.Add("Bat Wings");
            AddSpecies(cr, "Rodent", 13, 0, 1, 1, 2, 15, 20, 0);
            AddSpecies(cr, "Equine", 13, 20, 1, 1, 2, 16, 21, 1);
            AddSpecies(cr, "Feline", 13, 40, 1, 1, 2, 17, 22, 2);
            AddSpecies(cr, "Canine", 13, 60, 1, 1, 2, 18, 23, 3);
            AddSpecies(cr, "Musteline", 13, 80, 1, 1, 2, 19, 24, 4);
            AddSpecies(cr, "Lapine", 13, 100, 5, 5, 5, 2, 1, 0);
            AddSpecies(cr, "Squirrel", 14, 80, 8, 8, 8, 2, 1, 0);
            AddSpecies(cr, "Bovine", 15, 80, 10, 10, 10, 2, 1, 0);
            AddSpecies(cr, "Ursine", 20, 80, 12, 12, 12, 2, 1, 0);

            cr = speciesChooser.Nodes.Add("Prime Wings");
            AddSpecies(cr, "Rodent", 16, 0, 1, 1, 2, 15, 20, 0);
            AddSpecies(cr, "Equine", 16, 20, 1, 1, 2, 16, 21, 1);
            AddSpecies(cr, "Feline", 16, 40, 1, 1, 2, 17, 22, 2);
            AddSpecies(cr, "Canine", 16, 60, 1, 1, 2, 18, 23, 3);
            AddSpecies(cr, "Musteline", 16, 80, 1, 1, 2, 19, 24, 4);
            AddSpecies(cr, "Lapine", 16, 100, 5, 5, 5, 2, 1, 0);
            AddSpecies(cr, "Squirrel", 16, 120, 8, 8, 8, 2, 1, 0);
            AddSpecies(cr, "Bovine", 16, 140, 10, 10, 10, 2, 1, 0);
            AddSpecies(cr, "Ursine", 20, 100, 12, 12, 12, 2, 1, 0);

            cr = speciesChooser.Nodes.Add("Mythicals");
            AddSpecies(cr, "Dragon", 3, 0, 3, 3, 3, 2, 1, 0);
            AddSpecies(cr, "Phoenix", 4, 0, 4, 4, 4, 2, 1, 0);
            AddSpecies(cr, "Gryffe", 11, 0, 6, 6, 6, 2, 1, 0);
            AddSpecies(cr, "Eagle", 12, 0, 7, 7, 7, 2, 1, 0);
            AddSpecies(cr, "Kitterwing", 18, 0, 9, 9, 9, 2, 1, 0);
            AddSpecies(cr, "Mini Kitter", 17, 0, 9, 9, 9, 2, 1, 0);
            AddSpecies(cr, "Unicorn", 28, 0, 21, 21, 21, 2, 1, 0);
            AddSpecies(cr, "Kirin", 34, 0, 26, 26, 26, 2, 1, 0);
			AddSpecies(cr, "Naga", 55, 0, 41, 41, 41, 2, 1, 0);
			AddDynamicSpecies(cr, "Ferian Dragon", 10);
			AddDynamicSpecies(cr, "Ferian Dragon (Fly)", 11);
			AddDynamicSpecies(cr, "Ferian Purrwing", 19);
			AddDynamicSpecies(cr, "Ferian Purrwing (Fly)", 20);

            cr = speciesChooser.Nodes.Add("Ferians");
            AddSpecies(cr, "Wolven", 19, 0, 11, 11, 11, 2, 1, 0);
            AddSpecies(cr, "Tygard", 21, 0, 13, 13, 13, 2, 1, 0);
            AddSpecies(cr, "Leonen", 22, 0, 14, 14, 14, 2, 1, 0);
            AddSpecies(cr, "Foxen", 26, 0, 19, 19, 19, 2, 1, 0);
            AddSpecies(cr, "Catten", 41, 0, 30, 30, 30, 2, 1, 0);
			AddSpecies(cr, "Owlen", 42, 0, 31, 31, 31, 2, 1, 0);
			AddSpecies(cr, "Panooki", 54, 0, 40, 40, 40, 2, 1, 0);
			AddDynamicSpecies(cr, "Ottifet", 3);
			AddDynamicSpecies(cr, "Canen", 6);
			AddDynamicSpecies(cr, "Lynxen", 9);
			AddDynamicSpecies(cr, "Squeeken", 13);
			AddDynamicSpecies(cr, "Poneigh", 17);

            cr = speciesChooser.Nodes.Add("Male Avatars");
            AddSpecies(cr, "Furling", 29, 0, 22, 22, 22, 2, 1, 0);
            AddSpecies(cr, "Noble Canine", 36, 0, 27, 27, 27, 2, 1, 0);
            AddSpecies(cr, "Noble Feline", 38, 0, 28, 28, 28, 2, 1, 0);
			AddSpecies(cr, "Noble Equine", 45, 0, 34, 34, 34, 2, 1, 0);
			AddSpecies(cr, "Noble Rodent", 50, 0, 38, 38, 38, 2, 1, 0);
			AddDynamicSpecies(cr, "Noble Musteline", 4);
			AddDynamicSpecies(cr, "Noble Lapine", 14);
			AddSpecies(cr, "Noble Hyooman", 52, 0, 39, 39, 39, 2, 1, 0);

            cr = speciesChooser.Nodes.Add("Female Avatars");
            AddSpecies(cr, "Furling", 30, 0, 22, 22, 22, 2, 1, 0);
            AddSpecies(cr, "Noble Canine", 37, 0, 27, 27, 27, 2, 1, 0);
            AddSpecies(cr, "Noble Feline", 39, 0, 28, 28, 28, 2, 1, 0);
            AddSpecies(cr, "Noble Equine", 46, 0, 34, 34, 34, 2, 1, 0);
			AddSpecies(cr, "Noble Rodent", 51, 0, 38, 38, 38, 2, 1, 0);
			AddDynamicSpecies(cr, "Noble Musteline", 5);
			AddDynamicSpecies(cr, "Noble Lapine", 15);
			AddSpecies(cr, "Noble Hyooman", 53, 0, 39, 39, 39, 2, 1, 0);

            cr = speciesChooser.Nodes.Add("Seasonals");
            AddSpecies(cr, "Kiwi", 2, 100, 18, 18, 18, 2, 1, 0);
            AddSpecies(cr, "Werewolf", 23, 0, 15, 15, 15, 2, 1, 0);
            AddSpecies(cr, "Penguin", 24, 0, 16, 16, 16, 2, 1, 0);
            AddSpecies(cr, "Bat", 25, 0, 17, 17, 17, 2, 1, 0);
            AddSpecies(cr, "Flox", 27, 0, 20, 20, 20, 2, 1, 0);
            AddSpecies(cr, "Chinchilla", 31, 0, 23, 23, 23, 2, 1, 0);
            AddSpecies(cr, "Toasterwing", 32, 0, 24, 24, 24, 2, 1, 0);
            AddSpecies(cr, "Reindeer", 40, 0, 29, 29, 29, 2, 1, 0);
            AddSpecies(cr, "Lovebird", 43, 0, 32, 32, 32, 2, 1, 0);
            AddSpecies(cr, "Woolie", 47, 0, 35, 35, 35, 2, 1, 0);
            AddSpecies(cr, "Toytle", 48, 0, 36, 36, 36, 2, 1, 0);
			AddSpecies(cr, "Tusker", 49, 0, 37, 37, 37, 2, 1, 0);
			AddDynamicSpecies(cr, "Flynx", 7);
			AddDynamicSpecies(cr, "Snayle", 8);
			AddDynamicSpecies(cr, "Fluff", 1);
			AddDynamicSpecies(cr, "Floof", 2);
			AddDynamicSpecies(cr, "Flutterphin", 12);
			AddDynamicSpecies(cr, "Pookie", 16);
			AddDynamicSpecies(cr, "Orchimodo", 18);
			AddDynamicSpecies(cr, "M. Leprechaun", 21);
			AddDynamicSpecies(cr, "F. Leprechaun", 22);
			AddDynamicSpecies(cr, "Love Puppy", 23);
			AddDynamicSpecies(cr, "Pillow", 24);
			AddDynamicSpecies(cr, "M. Easter Bunny", 25);
			AddDynamicSpecies(cr, "F. Easter Bunny", 26);
			speciesChooser.EndUpdate();

            ColourCode = "t##########";
            Gender = 0;
        }

        public void LoadStart(int species, int gender) {
            if (!Initialised) {
                speciesChooser.SelectedNode = speciesChooser.Nodes[0].Nodes[species];
                Gender = gender;
                Initialised = true;
            }
        }

		private int _CurrentRemap;

		public int CurrentRemap {
			get { return _CurrentRemap; }
			set {
				if (value == _CurrentRemap) return;
				_CurrentRemap = value;
				if (remapMaskCheckBox.Checked)
					RecreateRemaps();
			}
		}

        private bool Initialised = false;
        private int Gender;
        private Bitmap PortBitmap;
        private Bitmap AvatarBitmap;
        private int AvatarX;
        private int AvatarY;
        private int AvatarFile;
        private int AvatarOffset;
        private int PortraitMaleFile;
        private int PortraitFemaleFile;
        private int PortraitUnspecFile;
        private int PortraitMaleOffset;
        private int PortraitFemaleOffset;
        private int PortraitUnspecOffset;
        private int AvatarFrame = 0;
        private string ColourCode;

        private void AddSpecies(TreeNode parent, string name, int afile, int aoffset, int pmfile, int pffile, int pufile, int pm, int pf, int pu) {
            TreeNode newnode = new TreeNode(name);
            newnode.Tag = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", afile, aoffset, pmfile, pffile, pufile, pm, pf, pu);
            parent.Nodes.Add(newnode);
        }

		private void AddDynamicSpecies(TreeNode parent, string name, int number) {
			AddSpecies(parent, name, 100 + number, 0, 100 + number, 100 + number, 100 + number, 2, 1, 0);
		}

        private void RecreateRemaps() {
            RecreateRemaps(true, true);
        }

        private void RecreateRemaps(bool doav, bool doport) {
            if (!Remapper.PalLoaded) return;

            if (doav) {
                Shape AvatarShape = Remapper.Players[AvatarFile].Shapes[AvatarOffset + AvatarFrame];
				Frame oAvatarFrame = AvatarShape.Frames[0];

                AvatarBitmap = Remapper.Remap(oAvatarFrame.ImageData,
					oAvatarFrame.Width, oAvatarFrame.Height,
					ColourCode, remapMaskCheckBox.Checked ? CurrentRemap : -1);
				AvatarX = oAvatarFrame.FramePos.X + 46;
				AvatarY = oAvatarFrame.FramePos.Y + 31;
                avatarPreview.Invalidate();
            }

            if (doport) {
                Shape PortShape = Remapper.Portraits[1].Shapes[0];
                switch (Gender) {
                    case 0:
                        PortShape = Remapper.Portraits[PortraitFemaleFile].Shapes[PortraitFemaleOffset];
                        break;
                    case 1:
                        PortShape = Remapper.Portraits[PortraitMaleFile].Shapes[PortraitMaleOffset];
                        break;
                    case 2:
                        PortShape = Remapper.Portraits[PortraitUnspecFile].Shapes[PortraitUnspecOffset];
                        break;
                }

				Frame PortFrame = PortShape.Frames[0];

				PortBitmap = Remapper.Remap(PortFrame.ImageData,
					PortFrame.Width, PortFrame.Height,
					ColourCode, remapMaskCheckBox.Checked ? CurrentRemap : -1);
                pictureBox2.Image = PortBitmap;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            if (AvatarBitmap != null) {
                e.Graphics.DrawImage(AvatarBitmap, AvatarX, AvatarY);
            }
        }

        private void speciesChooser_AfterSelect(object sender, TreeViewEventArgs e) {
            if (e.Node.Tag == null) {
                return;
            }

            string[] getit = ((string)e.Node.Tag).Split(',');
            AvatarFile = int.Parse(getit[0]);
            AvatarOffset = int.Parse(getit[1]);
            PortraitMaleFile = int.Parse(getit[2]);
            PortraitFemaleFile = int.Parse(getit[3]);
            PortraitUnspecFile = int.Parse(getit[4]);
            PortraitMaleOffset = int.Parse(getit[5]);
            PortraitFemaleOffset = int.Parse(getit[6]);
            PortraitUnspecOffset = int.Parse(getit[7]);
            RecreateRemaps();
        }

        public void UpdateColourCode(string newcc) {
            ColourCode = newcc;
            RecreateRemaps();
        }

        private void button1_Click(object sender, EventArgs e) {
            Gender = 1;
            RecreateRemaps(false, true);
        }

        private void button2_Click(object sender, EventArgs e) {
            Gender = 0;
            RecreateRemaps(false, true);
        }

        private void button3_Click(object sender, EventArgs e) {
            Gender = 2;
            RecreateRemaps(false, true);
        }

        private void button6_Click(object sender, EventArgs e) {
            AvatarFrame -= 1;
            if (AvatarFrame < 0) AvatarFrame = 19;
            RecreateRemaps(true, false);
        }

        private void button5_Click(object sender, EventArgs e) {
            AvatarFrame += 1;
            if (AvatarFrame > 19) AvatarFrame = 0;
            RecreateRemaps(true, false);
        }

		private void remapMaskCheckBox_CheckedChanged(object sender, EventArgs e) {
			RecreateRemaps();
		}
    }
}
