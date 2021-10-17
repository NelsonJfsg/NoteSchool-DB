using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.Properties;
using NoteSchool.Layout.Home;
using NoteSchool.Layout.Homework;
using NoteSchool.Layout.Note;
using NoteSchool.Layout.Schedule;
using NoteSchool.Layout.Subject;
using NoteSchool.Layout.Information;

namespace NoteSchool.Layout.Home {

    public partial class ScHome : Form {

        //Instance all screens and stay in memory.
        private static ScStart scStart = new ScStart();
        private static ScSubject scSubject = new ScSubject();
        private static ScSchedule scSchedule = new ScSchedule();
        private static ScHomework scHomework = new ScHomework();
        private static ScNote scNote = new ScNote();
        private static ScInformation scInformation = new ScInformation();

        //Save picture picture box in a list.
        private static List<PictureBox> itemList = new List<PictureBox>();

        //Constructor
        public ScHome() {

            InitializeComponent();
            fillPictureBoxList();
        
        }

        private void ScHome_Load(object sender, EventArgs e) {

            ChangeScreen(pbHome, scStart); //Set firt screen

        }

        private void pbSubject_Click(object sender, EventArgs e) {  

            ChangeScreen(pbSubject, scSubject);
        
        }

        private void pbHome_Click(object sender, EventArgs e) {
            
            ChangeScreen(pbHome, scStart);

        }

        private void pbNote_Click(object sender, EventArgs e) {
            
            ChangeScreen(pbNote, scNote);

        }

        private void pbSchedule_Click(object sender, EventArgs e) {
            
            ChangeScreen(pbSchedule, scSchedule);

        }

        private void pbInformation_Click(object sender, EventArgs e) {
            
            ChangeScreen(pbInformation, scInformation);

        }

        //My methods

        //Fill list of picture box
        private void fillPictureBoxList() {

            itemList.Add(pbHome);
            itemList.Add(pbNote);
            itemList.Add(pbSubject);
            itemList.Add(pbSchedule);
            itemList.Add(pbInformation);

        }

        //Method to change screen panel.
        private void ChangeScreen(PictureBox pb, Form sc) {

            //Set pb back color to blue dark
            for (int i = 0; itemList.Count > i; i++) {
                if (itemList[i].BackColor == Color.White) {
                    itemList[i].BackColor = Color.FromArgb(28, 39, 43);
                }
            }

            //Check pb
            if (pb.Name != "pbInformation") {

                pb.BackColor = Color.White;
                pbInformation.Image = Properties.Resources.Information;

            } else {

                pbInformation.Image = Properties.Resources.InformationW;
            }

            //Panel change
            panel2.Controls.Clear();
            sc.TopLevel = false;
            sc.TopMost = false;
            panel2.Controls.Add(sc);
            sc.Show();

        }

    }
}
