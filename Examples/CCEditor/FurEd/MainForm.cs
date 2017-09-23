using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FurEd {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

		string lastINIPath = "";

        private void MainForm_Load(object sender, EventArgs e) {
            Remapper.Prepare();

			string path = String.Join(
				System.IO.Path.DirectorySeparatorChar.ToString(),
				new string[] {
					Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
					"Furcadia", "Furcadia Characters"
				});

			if (System.IO.Directory.Exists(path))
				chooseIniFileDialog.InitialDirectory = path;

            if (!LoadINI()) {
                LoadColourCode("t#############");
                saveButton.Enabled = false;
            }

            //LoadColourCode("t89J,I@,,&;$%#");

			tabControl1.SelectTab(5);
        }

		private void loadButton_Click(object sender, EventArgs e) {
			LoadINI();
		}

		private bool LoadINI() {
			if (chooseIniFileDialog.ShowDialog() != DialogResult.OK)
				return false;

			string[] IniText = System.IO.File.ReadAllLines(chooseIniFileDialog.FileName);
			foreach (string line in IniText) {
				if (line.StartsWith("Colors=")) {
					LoadColourCode(line.Substring(7));
				}
			}

			lastINIPath = chooseIniFileDialog.FileName;
			saveButton.Enabled = true;

			return true;
		}

        private void button4_Click(object sender, EventArgs e) {
			saveIniFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(lastINIPath);
			saveIniFileDialog.FileName = System.IO.Path.GetFileName(lastINIPath);

            if (saveIniFileDialog.ShowDialog() == DialogResult.OK) {
                string[] IniText = System.IO.File.ReadAllLines(chooseIniFileDialog.FileName);
                int idx = 0;
                int linenum = -1;
                foreach (string line in IniText) {
                    if (line.StartsWith("Colors=")) {
                        linenum = idx;
                        break;
                    }
                    idx++;
                }
                if (linenum != -1) {
                    IniText[linenum] = "Colors=" + ColourCode + SpeciesBlock;
                }
                System.IO.File.WriteAllLines(saveIniFileDialog.FileName, IniText);
            }
        }

        private string ColourCode;
        private string SpeciesBlock;

        private bool LoadColourCode(string colourcode) {
            if (colourcode.Length != 14 || colourcode[0] != 't') {
                System.Windows.Forms.MessageBox.Show("Invalid colour code!");
                return false;
            }

            ColourCode = colourcode.Substring(0, 11);
            SpeciesBlock = colourcode.Substring(11);

            furrePreview1.LoadStart(colourcode[12] - 35, colourcode[11] - 35);
            furrePreview2.LoadStart(colourcode[12] - 35, colourcode[11] - 35);
            furrePreview3.LoadStart(colourcode[12] - 35, colourcode[11] - 35);

            int FurColour = colourcode[1] - 35;
            int MarkingsColour = colourcode[2] - 35;
            int HairColour = colourcode[3] - 35;
            int EyeColour = colourcode[4] - 35;
            int BadgeColour = colourcode[5] - 35;
            int VestColour = colourcode[6] - 35;
            int BracerColour = colourcode[7] - 35;
            int CapeColour = colourcode[8] - 35;
            int BootColour = colourcode[9] - 35;
            int TrousersColour = colourcode[10] - 35;

            UpdatingColours = true;
            furListBox.SelectedIndex = FurColour;
            markingListBox.SelectedIndex = MarkingsColour;
            hairListBox.SelectedIndex = HairColour;
            eyeListBox.SelectedIndex = EyeColour;
            badgeListBox.SelectedIndex = BadgeColour;
            vestListBox.SelectedIndex = VestColour;
            bracerListBox.SelectedIndex = BracerColour;
            capeListBox.SelectedIndex = CapeColour;
            bootsListBox.SelectedIndex = BootColour;
            trouserListBox.SelectedIndex = TrousersColour;
            UpdatingColours = false;

            furrePreview1.UpdateColourCode(ColourCode);
            furrePreview2.UpdateColourCode(ColourCode);
            furrePreview3.UpdateColourCode(ColourCode);

            colourCodeTextBox.Text = ColourCode + SpeciesBlock;
            return true;
        }

        private bool UpdatingColours = false;

        private void RenderColourChoice(object sender, DrawItemEventArgs e) {
			//bool big = !(sender == badgeListBox || sender == hairListBox);
			bool big = true;

            e.DrawBackground();
            e.DrawFocusRectangle();

            ListBox giver = sender as ListBox;
            Rectangle TextArea = e.Bounds;
            TextArea.X += (big ? 68 : 34);
            //e.Graphics.DrawString((string)giver.Items[e.Index], e.Font, new SolidBrush(e.ForeColor), e.Bounds.Location);
            TextRenderer.DrawText(e.Graphics, (string)giver.Items[e.Index], e.Font, TextArea, e.ForeColor, e.BackColor, TextFormatFlags.Left);

            byte[] Target = null;

            if (giver == badgeListBox) {
                Target = new byte[8];
                for (int i = 0; i < 8; i++) {
                    Target[i] = Remapper.BadgeRemap[e.Index];
                }
            } else if (giver == bracerListBox) {
                Target = Remapper.BracersRemap[e.Index];
            } else if (giver == bootsListBox) {
                Target = Remapper.BootRemap[e.Index];
            } else if (giver == capeListBox) {
                Target = Remapper.CapeRemap[e.Index];
            } else if (giver == eyeListBox) {
                Target = new byte[8];
                for (int i = 0; i < 8; i++) {
                    Target[i] = Remapper.EyeRemap[e.Index];
                }
            } else if (giver == furListBox) {
                Target = Remapper.FurRemap[e.Index];
            } else if (giver == hairListBox) {
                Target = Remapper.HairRemap[e.Index];
            } else if (giver == markingListBox) {
                Target = Remapper.MarkingsRemap[e.Index];
            } else if (giver == trouserListBox) {
                Target = Remapper.TrousersRemap[e.Index];
            } else if (giver == vestListBox) {
                Target = Remapper.VestRemap[e.Index];
            }

            int dX = e.Bounds.X + 2;
            int dY = e.Bounds.Y + 3;
            for (int i = 0; i < 8; i++) {
				e.Graphics.FillRectangle(new SolidBrush(Remapper.Palette[Target[i]]), dX, dY, (big ? 8 : 4), 8);
                dX += (big ? 8 : 4);
            }

            Brush BorderBrush = new SolidBrush(e.BackColor);
            e.Graphics.FillRectangle(BorderBrush, e.Bounds.X + 2, e.Bounds.Y + 3, 1, 1);
            e.Graphics.FillRectangle(BorderBrush, e.Bounds.X + 2, e.Bounds.Y + 10, 1, 1);
            e.Graphics.FillRectangle(BorderBrush, e.Bounds.X + (big ? 65 : 33), e.Bounds.Y + 3, 1, 1);
			e.Graphics.FillRectangle(BorderBrush, e.Bounds.X + (big ? 65 : 33), e.Bounds.Y + 10, 1, 1);
        }

		private int GetNumberForListBox(ListBox giver) {
			if (giver == furListBox) {
				return 0;
			} else if (giver == markingListBox) {
				return 1;
			} else if (giver == hairListBox) {
				return 2;
			} else if (giver == eyeListBox) {
				return 3;
			} else if (giver == badgeListBox) {
				return 4;
			} else if (giver == vestListBox) {
				return 5;
			} else if (giver == bracerListBox) {
				return 6;
			} else if (giver == capeListBox) {
				return 7;
			} else if (giver == bootsListBox) {
				return 8;
			} else if (giver == trouserListBox) {
				return 9;
			}

			return -1;
		}

        private void ChangeColourChoice(object sender, EventArgs e) {
            if (UpdatingColours) return;

            ListBox giver = sender as ListBox;
            int modify = GetNumberForListBox(giver) + 1;

            ColourCode = ColourCode.Substring(0,modify) + ((char)(giver.SelectedIndex + 35)).ToString() + ColourCode.Substring(modify+1);
            furrePreview1.UpdateColourCode(ColourCode);
            furrePreview2.UpdateColourCode(ColourCode);
            furrePreview3.UpdateColourCode(ColourCode);

            colourCodeTextBox.Text = ColourCode + SpeciesBlock;
        }

        private void button1_Click(object sender, EventArgs e) {
            LoadColourCode(colourCodeTextBox.Text);
        }

		private void aboutButton_Click(object sender, EventArgs e) {
			MessageBox.Show(
				"Treeki's Extended Colour Code Editor\n\n" +
				"Originally created October 2009.\n" +
				"Updated and re-released December 2011\n\n" +
				"Thanks to Kylix for the FOX code which I cannibalised :p",

				"About");
		}

		static int[] tabIndicesToNumbers = new int[] {
			4, // Badge
			6, // Bracers
			8, // Boots
			7, // Cape
			3, // Eyes
			0, // Fur
			2, // Hair
			1, // Markings
			9, // Trousers
			5, // Vest
		};

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
			int number = tabIndicesToNumbers[tabControl1.SelectedIndex];

			furrePreview1.CurrentRemap = number;
			furrePreview2.CurrentRemap = number;
			furrePreview3.CurrentRemap = number;
		}
    }
}
